using MetroFramework;
using System;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SerialShell.Base
{
    class CustomSerialPort
    {
        public const int ReadBufferSize = 4 * 1024;
        public int BufferSize { get; private set; }
        private byte[] BufferData;

        SerialPort sp;
        MainForm mainform;

        public bool IsOpen { get { return sp.IsOpen; } }
        public CustomSerialPort(MainForm f)
        {
            sp = new SerialPort("COM1", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
            sp.DataReceived += serialportdatareceived;
            sp.Disposed += sp_Disposed;
            sp.ErrorReceived += sp_ErrorReceived;
            sp.PinChanged += sp_PinChanged;
            sp.ReadBufferSize = ReadBufferSize;
            BufferData = new byte[ReadBufferSize + 16];
            BufferSize = 0;
            mainform = f;
        }

        void sp_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            MethodInvoker mi = delegate ()
            {
                mainform.guestTextBox.AppendText("Serial pin changed(" + e.EventType.ToString() + ")"+Environment.NewLine);
            };
            MethodInvoker call = delegate
            {
                if (mainform.InvokeRequired)
                    mainform.Invoke(mi);
                else mi();
            };
            call();
        }

        void sp_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            string err = "";
            switch (e.EventType)
            {
                case SerialError.RXOver:
                    err = "An input buffer overflow has occurred. There is either no room in the input buffer, or a character was received after the end-of-file (EOF) character.";
                    break;
                case SerialError.Overrun:
                    err = "A character-buffer overrun has occurred. The next character is lost.";
                    break;
                case SerialError.RXParity:
                    err = "The hardware detected a parity error.";
                    break;
                case SerialError.Frame:
                    err = "The hardware detected a framing error.";
                    break;
                case SerialError.TXFull:
                    err = "The application tried to transmit a character, but the output buffer was full.";
                    break;
            }
            mainform.guestTextBox.AppendText("Error receiving data(" + err + ")"+Environment.NewLine);
        }

        void sp_Disposed(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
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
            BufferSize  = 0;
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
            if (BufferSize != 0)
            {
                DecodeData();

                if(BufferSize != 0)
                {
                    var data = "";
                    for (int i = 0; i < BufferSize; i++)
                    {
                        data += ((data != "") ? ", 0x" : "0x") + BufferData[i].ToString("X2");
                    }
                    var err = "Cannot receive valid value of type: " + mainform.receivedatatype.Text + " received_size: " + BufferSize + " received_data: " + data;
                    mainform.guestTextBox.AppendText("Error receiving data(" + err + ")" + Environment.NewLine);
                }
            }

        }
        private void serialportdatareceived(object sender, SerialDataReceivedEventArgs e)
        {
            int BytesToRead = sp.BytesToRead;
            sp.Read(BufferData, BufferSize, BytesToRead);
            BufferSize += BytesToRead;
            DecodeData();
        }
        public void DecodeData()
        { 
            string type = "", receive_data_separator="";
            MethodInvoker mi = delegate()
            { type = mainform.receivedatatype.Text; };
            MethodInvoker call = delegate
            {
                if (mainform.InvokeRequired)
                    mainform.Invoke(mi);
                else mi();
            };
            call();

            mi = delegate () { receive_data_separator = mainform.receiveDataSeparator.Text; };
            call();
            string value = "", separator = "";

            switch (receive_data_separator)
            {
                case "None": break;
                case "Newline": separator = Environment.NewLine; break;
                case "Space": separator = " "; break;
                case "Tab": separator = "\t"; break;
                case "-": separator = "-"; break;
            }
            int buffer_index = -1;
            switch (type)
            {
                case "string":
                {
                    value = System.Text.Encoding.UTF8.GetString(BufferData, 0, BufferSize) + separator;
                    buffer_index = BufferSize;
                    break;
                }

                case "ascii + hex":
                {
                    for (buffer_index = 0; buffer_index + 1 <= BufferSize; buffer_index += 1)
                    {
                        value += ((char)BufferData[buffer_index]) + " 0x" + BufferData[buffer_index].ToString("X2") + separator;
                    }
                    break;
                }
                
                case "hex":
                {
                    for (buffer_index = 0; buffer_index + 1 <= BufferSize; buffer_index += 1)
                    {
                        value += BufferData[buffer_index].ToString("X2") + separator;
                    }
                    break;
                }
                
                case "float 32bits":
                {
                    for(buffer_index = 0; buffer_index + 4 <= BufferSize; buffer_index += 4)
                    {
                        value += System.BitConverter.ToSingle(BufferData, buffer_index).ToString() + separator;
                    }
                    break;
                }
                
                case "byte":
                {
                    for (buffer_index = 0; buffer_index + 1 <= BufferSize; buffer_index += 1)
                    {
                        value += BufferData[buffer_index].ToString() + separator;
                    }
                    break;
                }
                
                case "signed byte":
                {
                    for (buffer_index = 0; buffer_index + 1 <= BufferSize; buffer_index += 1)
                    {
                        value += ((sbyte)BufferData[buffer_index]).ToString() + separator;
                    }
                    break;
                }
                
                case "word":
                {
                    for (buffer_index = 0; buffer_index + 2 <= BufferSize; buffer_index += 2)
                    {
                        value += System.BitConverter.ToUInt16(BufferData, buffer_index).ToString() + separator;
                    }
                    break;
                }
                
                case "signed word":
                {
                    for (buffer_index = 0; buffer_index + 2 <= BufferSize; buffer_index += 2)
                    {
                        value += System.BitConverter.ToInt16(BufferData, buffer_index).ToString() + separator;
                    }
                    break;
                }
                
                case "dword":
                {
                    for (buffer_index = 0; buffer_index + 4 <= BufferSize; buffer_index += 4)
                    {
                        value += System.BitConverter.ToUInt32(BufferData, buffer_index).ToString() + separator;
                    }
                    break;
                }
                
                case "signed dword":
                {
                    for (buffer_index = 0; buffer_index + 4 <= BufferSize; buffer_index += 4)
                    {
                        value += System.BitConverter.ToInt32(BufferData, buffer_index).ToString() + separator;
                    }
                    break;
                }
            }

            if (buffer_index != -1)
            {
                for (int i = buffer_index; i < BufferSize; i++)
                {
                    //Clear buffer
                    BufferData[i - buffer_index] = BufferData[i];
                }
                BufferSize -= buffer_index;
            }

            if (mainform.LogStartStop.Text == "Disable")//enabled
            {
                try
                {
                    System.IO.File.AppendAllText(mainform.receivelogpath.Text, value);
                }
                catch (Exception ex)
                {
                    mi = delegate { mainform.guestTextBox.AppendText("Error Log file:"+ex.Message + Environment.NewLine); };
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
                    mainform.Connectbtn_Click(mainform.connectbtn, new EventArgs());
                return;
            }
        }

        byte[] HexStringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                                        .Where(x => x % 2 == 0)
                                        .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                                        .ToArray();
        }

        public void send(string type, string value)
        {
            if (value == null)
                return;
            if (sp.IsOpen == false)
            {
                mainform.hostTextBox.AppendText("Error sending data:" + value + Environment.NewLine);
                return;
                
            }
            sp.WriteTimeout = 3000;//3seconds
            try
            {
                switch (type)
                {
                    case "string": sp.Write(value); break;
                    case "verbatim string": sp.Write(StringFromVerbatimLiteral(value)); break;
                    case "hex": sp.Write(HexStringToByteArray(value), 0, value.Length / 2); break;
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

                
                mainform.hostTextBox.AppendText("Error sending data("+ex.Message+"):" + value + Environment.NewLine);
                if (mainform.connectbtn.Text == "Disconnect")
                    mainform.Connectbtn_Click(mainform.connectbtn, new EventArgs());
                return ;
            }
            mainform.hostTextBox.AppendText(" sending "+type+":"+value+Environment.NewLine);
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
                mainform.hostTextBox.AppendText("Error sending file("+ex.Message+"):" + path + Environment.NewLine);
                if (mainform.connectbtn.Text == "Disconnect")
                    mainform.Connectbtn_Click(mainform.connectbtn, new EventArgs());
                return;
            }
            mainform.hostTextBox.AppendText("Successful sending file:" + path + Environment.NewLine);
        }

    }
}
