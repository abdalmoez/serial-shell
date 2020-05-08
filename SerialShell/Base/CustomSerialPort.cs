using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using MetroFramework;
using System.Windows.Forms;
using System.IO;


namespace SerialShell.Base
{
    class CustomSerialPort
    {
        SerialPort sp;
        MainForm mainform;
        public CustomSerialPort(MainForm f)
        {
            sp = new SerialPort("COM1", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
            sp.DataReceived += serialportdatareceived;
            mainform = f;
        }
        public bool open()
        {
            if (sp.IsOpen)
                return true;
            if (mainform.connectionport.Text == "")
            {
                MetroMessageBox.Show(mainform, "Error opening port: unvalid port name.", "SerialShell", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //sp = new System.IO.Ports.SerialPort("COM1", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
            }
            sp.PortName = mainform.connectionport.Text;
            sp.BaudRate = int.Parse(mainform.connectionbaud.Text.Split(' ')[0]);            
            sp.DataBits = (mainform.connectiondatasize.Checked == true)?7:8;
            switch(mainform.connectionstopbits.SelectedIndex)
            {
                //case 0: sp.StopBits = StopBits.None; break;
                case 0: sp.StopBits = StopBits.One; break;
                case 1: sp.StopBits = StopBits.OnePointFive; break;
                case 2: sp.StopBits = StopBits.Two; break;
            }
            switch (mainform.connectionparity.SelectedText)
            {
                case "Even": sp.Parity = Parity.Even; break;
                case "Odd": sp.Parity = Parity.Odd; break;
                case "None": sp.Parity = Parity.None; break;
                case "Mark": sp.Parity = Parity.Mark; break;
                case "Space": sp.Parity = Parity.Space; break;
            }

            try
            {
                sp.Open();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(mainform, "Error opening port: " + ex.Message, "SerialShell", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void close()
        {
            if (sp.IsOpen == false)
                return;
            sp.Close();
        }
        private void serialportdatareceived(object sender, SerialDataReceivedEventArgs e)
        {
            string type = "";
            int BytesToRead = sp.BytesToRead;
            byte[] data = new byte[sp.ReadBufferSize];
            MethodInvoker mi = delegate()
            { type = mainform.receivedatatype.Text; };
            MethodInvoker call = delegate
            {
                if (mainform.InvokeRequired)
                    mainform.Invoke(mi);
                else mi();
            };
            call();
            string value="";
            switch (type)
            {
                case "string":
                    sp.Read(data, 0, BytesToRead);
                    value = System.Text.Encoding.UTF8.GetString(data);
                    break;
                case "float 32bits":
                    sp.Read(data, 0, 4);
                    value=System.BitConverter.ToSingle(data, 0).ToString()+"\n";
                    break;
                case "byte":
                    value = sp.ReadByte().ToString() + "\n";
                    break;
                case "signed byte":
                    value = ((sbyte)sp.ReadByte()).ToString() + "\n";
                    break;
                case "word":
                    sp.Read(data, 0, 2);
                    value = System.BitConverter.ToUInt16(data, 0).ToString() + "\n";
                    break;
                case "signed word":
                    sp.Read(data, 0, 2);
                    value = System.BitConverter.ToInt16(data, 0).ToString() + "\n";
                    break;
                case "dword":
                    sp.Read(data, 0, 4);
                    value = System.BitConverter.ToUInt32(data, 0).ToString() + "\n";
                    break;
                case "signed dword":
                    sp.Read(data, 0, 4);
                    value = System.BitConverter.ToInt32(data, 0).ToString() + "\n";
                    break;
            }
            if (mainform.LogStartStop.Text == "Disable")//enabled
            {
                try
                {
                    System.IO.File.AppendAllText(mainform.receivelogpath.Text, value);
                }
                catch (Exception ex)
                {
                    mi = delegate { mainform.guestTextBox.AppendText("Error Log file:"+ex.Message); };
                    call();
                }
            }
            mi = delegate { mainform.guestTextBox.AppendText(value); };
            call();
         /*   mi = delegate()
            {
                //mainform.guestTextBox.AppendText(qs);//autoscroll
            };*/

         //   mainform.Invoke(mi);
        }

        private void sendlineending()
        {
            if (sp.IsOpen == false)
                return;
            try
            {
                switch (mainform.sendlineending.SelectedIndex)
                {
                    case 0: break;//None
                    case 1: sp.Write("\r\n"); break;//Windows (CR LF)
                    case 2: sp.Write("\r"); break;//Macintosh (CR)
                    case 3: sp.Write("\n"); break;//Unix (LF)
                }
            }
            catch
            {

                if (mainform.connectbtn.Text == "Disconnect")
                    mainform.connectbtn_Click(mainform.connectbtn, new EventArgs());
                return;
            }
        }

        public void send(string type, string value)
        {
            if (sp.IsOpen == false)
            {
                mainform.hostTextBox.AppendText("Error sending data:" + value + '\n');
                return;
            }
            sp.WriteTimeout = 3000;//3seconds
            try
            {
                switch (type)
                {
                    case "string": sp.Write(value); break;
                    case "verbatim string": sp.Write(StringFromVerbatimLiteral(value)); break;
                    case "float 32bits": sp.Write(BitConverter.GetBytes(float.Parse(value)), 0, 4); break;
                    case "byte": sp.Write(BitConverter.GetBytes(byte.Parse(value)), 0, 1); break;
                    case "signed byte": sp.Write(BitConverter.GetBytes(sbyte.Parse(value)), 0, 1); break;
                    case "word": sp.Write(BitConverter.GetBytes(ushort.Parse(value)), 0, 2); break;
                    case "signed word": sp.Write(BitConverter.GetBytes(short.Parse(value)), 0, 2); break;
                    case "dword": sp.Write(BitConverter.GetBytes(uint.Parse(value)), 0, 4); break;
                    case "signed dword": sp.Write(BitConverter.GetBytes(int.Parse(value)), 0, 4); break;
                }
            }
            catch (Exception ex)
            {

                
                mainform.hostTextBox.AppendText("Error sending data("+ex.Message+"):" + value + '\n');
                if (mainform.connectbtn.Text == "Disconnect")
                    mainform.connectbtn_Click(mainform.connectbtn, new EventArgs());
                return ;
            }
            mainform.hostTextBox.AppendText(" sending "+type+":"+value+"\n");
            sendlineending();
        }

        private static string StringFromVerbatimLiteral(string source)
        {
            StringBuilder sb = new StringBuilder(source.Length);
            int pos = 0;
            while (pos < source.Length)
            {
                char c = source[pos];
                if (c == '\"')
                {
                    // --- Handle escape sequences
                    pos++;
                    if (pos >= source.Length) throw new ArgumentException("Missing escape sequence");
                    if (source[pos] == '\"') c = '\"';
                    else throw new ArgumentException("Unrecognized escape sequence");
                }
                pos++;
                sb.Append(c);
            }
            return sb.ToString();
        }
        public void sendfile(string path)
        {
            if (sp.IsOpen == false)
                return;
            byte[] f = File.ReadAllBytes(path);
            try
            {
                sp.WriteTimeout = 60 * 60 * 1000;//1hour
                sp.Write(f, 0, f.Length);
            }
            catch(Exception ex)
            {
                mainform.hostTextBox.AppendText("Error sending file("+ex.Message+"):" + path + '\n');
                if (mainform.connectbtn.Text == "Disconnect")
                    mainform.connectbtn_Click(mainform.connectbtn, new EventArgs());
                return;
            }
            mainform.hostTextBox.AppendText("Successful sending file:" + path + '\n');
        }

    }
}
