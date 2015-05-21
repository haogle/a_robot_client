using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using NMEA2OSGdemo.Properties;
//using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Threading;
using SharpGL;
using System.Text.RegularExpressions;
using SmileWei.EmbeddedApp.WinForm;
using WifiVideo;

namespace NMEA2OSGdemo
{
    public partial class Form1 : Form
    {
        private float x_rotation = 0.0f;
        private float y_rotation = 0.0f;
        private float z_rotation = 0.0f;

        #region declarations
        // NMEA interpreter
        NmeaInterpreter GPS = new NmeaInterpreter();
        // OSGridConverter
        NMEA2OSG OSGconv = new NMEA2OSG();



        // The main control for communicating through the RS-232 port
        private SerialPort comport = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
        private SerialPort comport1 = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
        public string[] gpsString;
        public string[] gpsString_1;
        public string instring;
        public string instring_1;


        public string[] nrthest;
       
        public string x_location;
        public string y_location;
        public string z_location;
  
     //   public string[] nrthest;
        public double ellipHeight;

        #endregion

        public Form1()
        {
            // Build the form
            InitializeComponent();
            // Restore the users settings
            InitialiseControlValues();
            comport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

            GPS.PositionReceived += new NmeaInterpreter.PositionReceivedEventHandler(GPS_PositionReceived);
            GPS.SatellitesInViewReceived += new NmeaInterpreter.SatellitesInViewReceivedEventHandler(GPS_SatellitesInViewReceived);
            GPS.SatellitesUsed += new NmeaInterpreter.SatellitesUsedReceivedEventHandler(GPS_SatellitesUsed);
            GPS.SpeedReceived += new NmeaInterpreter.SpeedReceivedEventHandler(GPS_SpeedReceived);
            GPS.BearingReceived += new NmeaInterpreter.BearingReceivedEventHandler(GPS_BearingReceived);
            GPS.FixLost += new NmeaInterpreter.FixLostEventHandler(GPS_FixLost);
            GPS.FixObtained += new NmeaInterpreter.FixObtainedEventHandler(GPS_FixObtained);
            GPS.HDOPReceived += new NmeaInterpreter.HDOPReceivedEventHandler(GPS_HDOPReceived);
            GPS.EllipsoidHeightReceived += new NmeaInterpreter.EllipsoidHeightReceivedEventHandler(GPS_EllipsoidHeightReceived);  
            
            OSGconv.NorthingEastingReceived += new NMEA2OSG.NorthingEastingReceivedEventHandler(OSGconv_NorthingEastingReceived);
            OSGconv.NatGridRefReceived += new NMEA2OSG.NatGridRefReceivedEventHandler(OSGconv_NatGridRefReceived);

            comport1.DataReceived += new SerialDataReceivedEventHandler(port_1_DataReceived);
            //updated lately


            
            
             
        }
        private void port_1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // This method will be called when there is data waiting in the port's buffer
            // Read all the data waiting in the buffer and pasrse it

            /* http://forums.microsoft.com/MSDN/ShowPost.aspx?PageIndex=2&SiteID=1&PostID=293187
             * You would need to use Control.Invoke() to update the GUI controls
             * because unlike Windows Forms events like Button.Click which are processed 
             * in the GUI thread, SerialPort events are processed in a non-GUI thread 
             * (more precisely a ThreadPool thread). 
             */
            this.Invoke(new EventHandler(HandleMaterixstring));
        }
        private void HandleMaterixstring(object s, EventArgs e)
        {
            string inbuff;
            inbuff = comport1.ReadExisting();
            if (inbuff != null)
            {
                if (inbuff.StartsWith("#"))
                {
                    instring_1 = inbuff;
                }
                else
                {
                    instring_1 += inbuff;
                }
                //if (inbuff.Length > 40)
                //{
                //    inbuff = "";
                //}

                gpsString_1 = instring_1.Split();
                //MessageBox.Show(this,instring);
                // System.Console.WriteLine(instring);
                foreach (string item in gpsString_1) Parse_1(item);
            }
        }

        public bool Parse_1(string sentence)
        {
            if (!IsValid(sentence))
            {
                // MessageBox.Show(this, "fuck you");
                return false;

            }
            //MessageBox.Show("fuck");



            x_location = GetWords(sentence)[0];

            y_location = GetWords(sentence)[1];

            z_location = GetWords(sentence)[2];
            //z_location = z_location.Substring(0, z_location.IndexOf("E"));

            label3_1.Text = x_location;
            label4_1.Text = y_location;
            label5_1.Text = z_location;
            x_rotation = Convert.ToSingle(x_location);
            y_rotation = Convert.ToSingle(y_location);
            z_rotation = Convert.ToSingle(z_location);




            // MessageBox.Show(this, GetWords(sentence)[0]);



            return true;



        }

        #region serialport
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           // This method will be called when there is data waiting in the port's buffer
           // Read all the data waiting in the buffer and pasrse it

            /* http://forums.microsoft.com/MSDN/ShowPost.aspx?PageIndex=2&SiteID=1&PostID=293187
             * You would need to use Control.Invoke() to update the GUI controls
             * because unlike Windows Forms events like Button.Click which are processed 
             * in the GUI thread, SerialPort events are processed in a non-GUI thread 
             * (more precisely a ThreadPool thread). 
             */
            this.Invoke(new EventHandler(HandleGPSstring));
        }
        private void HandleGPSstring(object s, EventArgs e)
        {
            string inbuff;
            inbuff = comport.ReadExisting();
            if (inbuff != null)
            {
                if (inbuff.StartsWith("$"))
                {
                    instring = inbuff;
                }
                else
                {
                    instring += inbuff;
                }
                gpsString = instring.Split();
                foreach (string item in gpsString) GPS.Parse(item);
            }
        }
        #endregion
      
        //updated lately

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //  joystick = new JoyKeys.Core.Joystick();
            // joystick.Click += new EventHandler<JoyKeys.Core.JoystickEventArgs>(joystick_Click);
            //  joystick.Register(base.Handle, JoyKeys.Core.API.JOYSTICKID1);
            //   joystick.Register(base.Handle, JoyKeys.Core.API.JOYSTICKID2);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //joystick.UnRegister(JoyKeys.Core.API.JOYSTICKID1);
            // joystick.UnRegister(JoyKeys.Core.API.JOYSTICKID2);
            base.OnClosing(e);
        }



        //语音识别部分
        public delegate void StringEvent(string str);
        public StringEvent SetMessage;
        //声明读写INI文件的API函数
        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);
        static string FileName = Application.StartupPath + "\\Config.ini";
        public string ReadIni(string Section, string Ident, string Default)
        {
            Byte[] Buffer = new Byte[65535];
            int bufLen = GetPrivateProfileString(Section, Ident, Default, Buffer, Buffer.GetUpperBound(0), FileName);
            string s = Encoding.GetEncoding(0).GetString(Buffer);
            s = s.Substring(0, bufLen);
            return s.Trim();
        }

        void SendData(byte[] data)
        {
            try
            {
                IPAddress ips = IPAddress.Parse(ControlIp);//("192.168.1.1");192.168.10.1
                IPEndPoint ipe = new IPEndPoint(ips, int.Parse(Port));//把ip和端口转化为IPEndPoint实例;1376
                UdpClient c = new UdpClient(23456);//创建一个Socket

                //  c.Connect(ipe);//连接到服务器

                //byte[] bs = Encoding.ASCII.GetBytes(data); 


                c.Send(data, data.Length, ipe);//发送测试信息
                c.Close();
                //Thread.Sleep(10);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.Exit();
            }
        }

        string CameraIp = @"http://192.168.8.1:8083/?action=stream";
        string ControlIp = "192.168.8.1";
        string Port = "1376";
        byte[] CMD = new byte[5];
        byte[] CMD_Forward = new byte[5];
        byte[] CMD_Backward = new byte[5];
        byte[] CMD_TurnLeft = new byte[5];
        byte[] CMD_TurnRight = new byte[5];
        byte[] CMD_Stop = new byte[5];

        byte[] CMD_EngineUpDown = new byte[5];
        byte[] CMD_EngineLeftRight = new byte[5];

        byte[] CMD_Light = new byte[5];

        private void GetIni()
        {
            CameraIp = ReadIni("VideoUrl", "videoUrl", "");
            ControlIp = ReadIni("ControlUrl", "controlUrl", "");
            Port = ReadIni("ControlPort", "controlPort", "");

            CMD_Forward[0] = 0xFF; CMD_Forward[1] = 0x00; CMD_Forward[2] = 0x01; CMD_Forward[3] = 0x00; CMD_Forward[4] = 0xFF;
            CMD_Backward[0] = 0xFF; CMD_Backward[1] = 0x00; CMD_Backward[2] = 0x02; CMD_Backward[3] = 0x00; CMD_Backward[4] = 0xFF;
            CMD_TurnLeft[0] = 0xFF; CMD_TurnLeft[1] = 0x00; CMD_TurnLeft[2] = 0x03; CMD_TurnLeft[3] = 0x00; CMD_TurnLeft[4] = 0xFF;
            CMD_TurnRight[0] = 0xFF; CMD_TurnRight[1] = 0x00; CMD_TurnRight[2] = 0x04; CMD_TurnRight[3] = 0x00; CMD_TurnRight[4] = 0xFF;
            CMD_Stop[0] = 0xFF; CMD_Stop[1] = 0x00; CMD_Stop[2] = 0x00; CMD_Stop[3] = 0x00; CMD_Stop[4] = 0xFF;

            CMD_Light[0] = 0xFF;
            CMD_Light[1] = 0x02;
            CMD_Light[2] = 0x00;
            CMD_Light[3] = 0x00;
            CMD_Light[4] = 0xFF;


            CMD_EngineLeftRight[0] = 0xFF;
            CMD_EngineLeftRight[1] = 0x01;
            CMD_EngineLeftRight[2] = 0x01;
            CMD_EngineLeftRight[3] = 0x5A;
            CMD_EngineLeftRight[4] = 0xFF;


            CMD_EngineUpDown[0] = 0xFF;
            CMD_EngineUpDown[1] = 0x01;
            CMD_EngineUpDown[2] = 0x02;
            CMD_EngineUpDown[3] = 0x7B;
            CMD_EngineUpDown[4] = 0xFF;



        }

        System.Threading.Thread thread = null;
        void btn_show_Click(object sender, EventArgs e)
        {
            btnEngineStop.Select();
            btn_show.Enabled = false;
            btn_set.Enabled = false;
            //启动一个线程   
            thread = new System.Threading.Thread(ThreadProc);
            thread.Start();
        }

        public void ThreadProc()
        {
            GetStream(CameraIp);
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            Config cfg = new Config();
            cfg.ShowDialog();
           btnEngineStop.Select();
        }
        private void Mainfrm_Load(object sender, EventArgs e)
        {
            GetIni();
            //buttonForward.BackColor = Color.LightBlue;
            //buttonBackward.BackColor = Color.LightBlue;
            //buttonLeft.BackColor = Color.LightBlue;
            //buttonRight.BackColor = Color.LightBlue;
            //btnEngineUp.BackColor = Color.LightBlue;
            //btnEngineDown.BackColor = Color.LightBlue;
            //btnEngineLeft.BackColor = Color.LightBlue;
            //btnEngineRight.BackColor = Color.LightBlue;
           // btnEngineStop.BackColor = Color.LightBlue;
            //buttonLight.BackColor = Color.LightBlue;

            btnEngineStop.Select();
            // tB_Joykeys.Text = "手柄未连接";
        }

        bool dupflag = false;



        private void btnEngineStop_Click(object sender, EventArgs e)
        {
            ;
        }

        private void Mainfrm_Deactivate(object sender, EventArgs e)
        {
            dupflag = false;
            //statucs_n = 0;
        }


        private Image byteArrayToImage(byte[] Bytes, int count)
        {
            using (MemoryStream ms = new MemoryStream(Bytes, 0, count))
            {
                //Bitmap bmp = (Bitmap)Bitmap.FromStream(ms);
                Image outputImg = Image.FromStream(ms);
                return outputImg;
            }
        }

        /// <summary>
        /// 获取视频流
        /// </summary>
        /// /// <param name="UriString">控制Uri</param>
        private void GetStream(string UriString)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream stream = null;
            System.DateTime time;
            int fps = 0;

            const int bufSize = 512 * 1024;	            //视频图片缓冲
            byte[] jpg_buf = new byte[bufSize];	        // buffer to read jpg
            const int readSize = 16384;		            //每次最大获取的流
            byte[] buffer = new byte[readSize];	        // buffer to read stream            


            while (true)
            {

                try
                {
                    time = System.DateTime.Now;
                    fps = 0;

                    request = (HttpWebRequest)System.Net.WebRequest.Create(UriString);
                    response = (HttpWebResponse)request.GetResponse();

                    int read;
                    int status = 0;
                    int jpg_count = 0;                          //jpg数据下标
                    while (true)
                    {
                        stream = response.GetResponseStream();

                        if ((read = stream.Read(buffer, 0, readSize)) > 0)
                        {
                            for (int i = 0; i < read; i++)
                            {
                                switch (status)
                                {
                                    //Content-Length:
                                    case 0: if (buffer[i] == (byte)'C') status++; else status = 0; break;
                                    case 1: if (buffer[i] == (byte)'o') status++; else status = 0; break;
                                    case 2: if (buffer[i] == (byte)'n') status++; else status = 0; break;
                                    case 3: if (buffer[i] == (byte)'t') status++; else status = 0; break;
                                    case 4: if (buffer[i] == (byte)'e') status++; else status = 0; break;
                                    case 5: if (buffer[i] == (byte)'n') status++; else status = 0; break;
                                    case 6: if (buffer[i] == (byte)'t') status++; else status = 0; break;
                                    case 7: if (buffer[i] == (byte)'-') status++; else status = 0; break;
                                    case 8: if (buffer[i] == (byte)'L') status++; else status = 0; break;
                                    case 9: if (buffer[i] == (byte)'e') status++; else status = 0; break;
                                    case 10: if (buffer[i] == (byte)'n') status++; else status = 0; break;
                                    case 11: if (buffer[i] == (byte)'g') status++; else status = 0; break;
                                    case 12: if (buffer[i] == (byte)'t') status++; else status = 0; break;
                                    case 13: if (buffer[i] == (byte)'h') status++; else status = 0; break;
                                    case 14: if (buffer[i] == (byte)':') status++; else status = 0; break;
                                    case 15:
                                        if (buffer[i] == 0xFF) status++;
                                        jpg_count = 0;
                                        jpg_buf[jpg_count++] = buffer[i];
                                        break;
                                    case 16:
                                        if (buffer[i] == 0xD8)
                                        {
                                            status++;
                                            jpg_buf[jpg_count++] = buffer[i];
                                        }
                                        else
                                        {
                                            if (buffer[i] != 0xFF) status = 15;
                                        }
                                        break;
                                    case 17:
                                        jpg_buf[jpg_count++] = buffer[i];
                                        if (buffer[i] == 0xFF) status++;
                                        if (jpg_count >= bufSize) status = 0;
                                        break;
                                    case 18:
                                        jpg_buf[jpg_count++] = buffer[i];
                                        if (buffer[i] == 0xD9)
                                        {
                                            status = 0;
                                            //jpg接收完成
                                            this.Invoke((EventHandler)delegate
                                            {
                                                fps++;

                                                Image image = byteArrayToImage(jpg_buf, jpg_count);

                                               wifi.Image = image;

                                                if (System.DateTime.Now >= time.AddSeconds(1))
                                                {
                                                    //label_fps.Text = fps.ToString() + " fps";
                                                    fps = 0;
                                                    time = System.DateTime.Now;
                                                }

                                                //label_fps在图片上显示的位置 
                                                //Rectangle r = new Rectangle(pBShow.Image.Width - 42, pBShow.Image.Height - 22, 40, 20);
                                                //pBShow.DrawToBitmap((Bitmap)pBShow.Image, r);
                                                //pBShow.Refresh();




                                            });

                                        }
                                        else
                                        {
                                            if (buffer[i] != 0xFF) status = 17;
                                        }
                                        break;
                                    default:
                                        status = 0;
                                        break;

                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    //textBox2.Text = ex.Message;

                    if (request != null)
                    {
                        request.Abort();
                        request = null;
                    }
                    // close response stream
                    if (response != null)
                    {
                        response.Close();
                        response = null;
                    }
                    // close response
                    if (stream != null)
                    {
                        stream.Close();
                        stream = null;
                    }

                }
            }


        }

        private void Mainfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null) thread.Abort();
        }



        private void InitialiseControlValues()
        {
            cmbParity.Items.Clear(); cmbParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            cmbStopBits.Items.Clear(); cmbStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));

            cmbParity.Text = Settings.Default.Parity.ToString();
            cmbStopBits.Text = Settings.Default.StopBits.ToString();
            cmbDataBits.Text = Settings.Default.DataBits.ToString();
            cmbParity.Text = Settings.Default.Parity.ToString();
            cmbBaudRate.Text = Settings.Default.BaudRate.ToString();
            
            cmbPortName.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
                cmbPortName.Items.Add(s);

            if (cmbPortName.Items.Count > 0) cmbPortName.SelectedIndex = 0;
            else
            {
                MessageBox.Show(this, "There are no COM Ports detected on this computer.\nPlease install a COM Port and restart this app.", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // this.Close();
            }

            cmbParity_1.Items.Clear(); cmbParity_1.Items.AddRange(Enum.GetNames(typeof(Parity)));
            cmbStopBits_1.Items.Clear(); cmbStopBits_1.Items.AddRange(Enum.GetNames(typeof(StopBits)));

            cmbParity_1.Text = Settings.Default.Parity.ToString();
            cmbStopBits_1.Text = Settings.Default.StopBits.ToString();
            cmbDataBits_1.Text = Settings.Default.DataBits.ToString();
            cmbParity_1.Text = Settings.Default.Parity.ToString();
            cmbBaudRate_1.Text = Settings.Default.BaudRate.ToString();

            cmbPortName_1.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
                cmbPortName_1.Items.Add(s);

            if (cmbPortName_1.Items.Count > 0) cmbPortName_1.SelectedIndex = 0;
            else
            {
                //   MessageBox.Show(this, "There are no COM Ports detected on this computer.\nPlease install a COM Port and restart this app.", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //  this.Close();
            }
        }

        public string[] GetWords(string sentence)
        {
            //strip off the final * + checksum
            sentence = sentence.Substring(sentence.IndexOf("=") + 1, sentence.IndexOf("E") - sentence.IndexOf("=") - 1);
            //now split it up
            //  MessageBox.Show(this, sentence);
            return sentence.Split(',');

        }
        public bool IsValid(string sentence)
        {
            // Compare the characters after the asterisk to the calculation
            //int x = sentence.IndexOf("N") - sentence.IndexOf("#");
            // String varint = Convert.ToString(x);
            // MessageBox.Show(varint);
            // if (sentence.Length==0) return false;
            return (Regex.IsMatch(sentence, "^(#YPR=[-+]?[0-9]{1,}[.][0-9]*,[-+]?[0-9]{1,}[.][0-9]*,[-+]?[0-9]{1,}[.][0-9]*EN)$"));
          //  return (sentence.IndexOf("#") == (sentence.IndexOf("N") - 24));
            // return (sentence.IndexOf("#") == (sentence.IndexOf("=") - 4));
        }




        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            //  TODO: Initialise OpenGL here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the clear color.
            gl.ClearColor(0, 0, 0, 0);
        }

        /// <summary>
        /// Handles the Resized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            //  TODO: Set the projection matrix here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Load the identity.
            gl.LoadIdentity();

            //  Create a perspective transformation.
            gl.Perspective(30.0f, (double)Width / (double)Height, 0.01, 50.0);
            //  gl.Perspective(0.0f, 0.0f, 0.01, 100.0);

            //  Use the 'look at' helper function to position and aim the camera.
            gl.LookAt(0, 0, 10, 0, 0, 0, 0, 1, 0);

            //  Set the modelview matrix.

            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }
        private void openGLControl_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Handles the OpenGLDraw event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RenderEventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs e)
        {
            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Clear the color and depth buffer.
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            //  Load the identity matrix.
            gl.LoadIdentity();

            //  Rotate around the Y axis.
            gl.Rotate(-x_rotation, 0.0f, 1.0f, 0.0f);
            gl.Rotate(-y_rotation, 1.0f, 0.0f, 0.0f);
            gl.Rotate(z_rotation, 0.0f, 0.0f, 1.0f);

            gl.Begin(OpenGL.GL_QUADS);

            gl.Color(0.0f, 1.0f, 0.0f);			// 颜色改为蓝色

            gl.Vertex(1.0f, -0.5f, -1.0f);			// 四边形的右上顶点 (顶面)

            gl.Vertex(-1.0f, -0.5f, -1.0f);			// 四边形的左上顶点 (顶面)

            gl.Vertex(-1.0f, -0.5f, 1.0f);			// 四边形的左下顶点 (顶面)

            gl.Vertex(1.0f, -0.5f, 1.0f);

            gl.Color(1.0f, 0.5f, 0.0f);			// 颜色改成橙色

            gl.Vertex(1.0f, -1.0f, 1.0f);			// 四边形的右上顶点(底面)

            gl.Vertex(-1.0f, -1.0f, 1.0f);			// 四边形的左上顶点(底面)

            gl.Vertex(-1.0f, -1.0f, -1.0f);			// 四边形的左下顶点(底面)

            gl.Vertex(1.0f, -1.0f, -1.0f);			// 四边形的右下顶点(底面)

            gl.Color(1.0f, 0.0f, 0.0f);			// 颜色改成红色

            gl.Vertex(1.0f, -0.5f, 1.0f);			// 四边形的右上顶点(前面)

            gl.Vertex(-1.0f, -0.5f, 1.0f);			// 四边形的左上顶点(前面)

            gl.Vertex(-1.0f, -1.0f, 1.0f);			// 四边形的左下顶点(前面)

            gl.Vertex(1.0f, -1.0f, 1.0f);			// 四边形的右下顶点(前面)
            gl.Color(1.0f, 1.0f, 0.0f);			// 颜色改成黄色

            gl.Vertex(1.0f, -1.0f, -1.0f);			// 四边形的右上顶点(后面)

            gl.Vertex(-1.0f, -1.0f, -1.0f);			// 四边形的左上顶点(后面)

            gl.Vertex(-1.0f, -0.5f, -1.0f);			// 四边形的左下顶点(后面)

            gl.Vertex(1.0f, -0.5f, -1.0f);			// 四边形的右下顶点(后面)
            gl.Color(0.0f, 0.0f, 1.0f);			// 颜色改成蓝色

            gl.Vertex(-1.0f, -0.5f, 1.0f);			// 四边形的右上顶点(左面)

            gl.Vertex(-1.0f, -0.5f, -1.0f);			// 四边形的左上顶点(左面)

            gl.Vertex(-1.0f, -1.0f, -1.0f);			// 四边形的左下顶点(左面)

            gl.Vertex(-1.0f, -1.0f, 1.0f);			// 四边形的右下顶点(左面)
            gl.End();



            //  Draw a coloured pyramid.
            //gl.Begin(OpenGL.GL_TRIANGLES);
            //gl.Color(1.0f, 0.0f, 0.0f);
            //gl.Vertex(0.0f, 1.0f, 0.0f);
            //gl.Color(0.0f, 1.0f, 0.0f);
            //gl.Vertex(-1.0f, -1.0f, 1.0f);
            //gl.Color(0.0f, 0.0f, 1.0f);
            //gl.Vertex(1.0f, -1.0f, 1.0f);
            //gl.Color(1.0f, 0.0f, 0.0f);
            //gl.Vertex(0.0f, 1.0f, 0.0f);
            //gl.Color(0.0f, 0.0f, 1.0f);
            //gl.Vertex(1.0f, -1.0f, 1.0f);
            //gl.Color(0.0f, 1.0f, 0.0f);
            //gl.Vertex(1.0f, -1.0f, -1.0f);
            //gl.Color(1.0f, 0.0f, 0.0f);
            //gl.Vertex(0.0f, 1.0f, 0.0f);
            //gl.Color(0.0f, 1.0f, 0.0f);
            //gl.Vertex(1.0f, -1.0f, -1.0f);
            //gl.Color(0.0f, 0.0f, 1.0f);
            //gl.Vertex(-1.0f, -1.0f, -1.0f);
            //gl.Color(1.0f, 0.0f, 0.0f);
            //gl.Vertex(0.0f, 1.0f, 0.0f);
            //gl.Color(0.0f, 0.0f, 1.0f);
            //gl.Vertex(-1.0f, -1.0f, -1.0f);
            //gl.Color(0.0f, 1.0f, 0.0f);
            //gl.Vertex(-1.0f, -1.0f, 1.0f);
            //gl.End();

            //  Nudge the x_rotation.
            // y_rotation += 3.0f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comport.IsOpen) 
            {
                comport.Close();
                button1.Text = "Open Port";
            }
            else
            {
                // Set the port's settings
                comport.BaudRate = int.Parse(cmbBaudRate.Text);
                comport.DataBits = int.Parse(cmbDataBits.Text);
                comport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
                comport.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
                comport.PortName = cmbPortName.Text;

                // Open the port
                comport.Open();
                button1.Text = "Close Port";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ExitProg();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitProg();
        }
        private void ExitProg()
        {
            if (comport.IsOpen) comport.Close();
            Environment.Exit(0);
        }

        #region GPS data
      
        private void GPS_PositionReceived(string Lat, string Lon)
        {
            textBoxLat.Text = Lat;
            textBoxLon.Text = Lon;
            //convert to OS grid
            if (OSGconv.ParseNMEA(Lat, Lon, ellipHeight))
            {
                //display decimal values of lat and lon
                textBox1.Text = Convert.ToString(OSGconv.deciLat);
                textBox2.Text = Convert.ToString(OSGconv.deciLon);
            }
        }

        private void GPS_SatellitesInViewReceived(int SatInView)
        {
            textBoxSatInView.Text = Convert.ToString(SatInView);
        }

        private void GPS_SatellitesUsed(int SatInUse)
        {
            textBoxSatInUse.Text = Convert.ToString(SatInUse);
        }

        private void GPS_SpeedReceived(double Speed)
        {
            textBoxSpeed.Text = Convert.ToString(Speed);
        }

        private void GPS_BearingReceived(double Bearing)
        {
            textBoxBearing.Text = Convert.ToString(Bearing);
        }
        
        void GPS_FixLost()
        {
            textBoxFix.Text = "Lost";
        }

        void GPS_FixObtained()
        {
            textBoxFix.Text = "Obtained";
        }

        void GPS_HDOPReceived(double value)
        {
            textBoxHDOP.Text = Convert.ToString(value);
        }

        void GPS_EllipsoidHeightReceived(double value)
        {
            ellipHeight = value;
            textBoxEllipsoidHeight.Text = Convert.ToString(ellipHeight);
        }
        
        #endregion

        #region OSGconv data

        void OSGconv_NatGridRefReceived(string ngr)
        {
            textBoxGridRef.Text = ngr;
        }

        void OSGconv_NorthingEastingReceived(double northing, double easting)
        {
            textBoxNorthing.Text = Convert.ToString(northing);
            textBoxEasting.Text = Convert.ToString(easting);
        }

        #endregion

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button3_Click(object sender, EventArgs e)
        //{
           
                
        //       String Url = "http://www.amap.com/#!poi!!q=31.234527,121.287689";
        //       // string Url = "http://www.amap.com/#!poi!!q=" + textBoxLat + "," + textBoxLon;
        //        webBrowser1.Navigate(Url);
                
            
        //}

        
     

    
        private void button3_Click_1(object sender, EventArgs e)
        {
            Mainfrm video = new Mainfrm();
            video.ShowDialog();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void wifi_Click(object sender, EventArgs e)
        {

        }

        private void button1_1_Click(object sender, EventArgs e)
        {
            if (comport1.IsOpen)
            {
                comport1.Close();
                button1_1.Text = "Open Port";
            }
            else
            {
                // Set the port's settings
                comport1.BaudRate = int.Parse(cmbBaudRate_1.Text);
                comport1.DataBits = int.Parse(cmbDataBits_1.Text);
                comport1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits_1.Text);
                comport1.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity_1.Text);
                comport1.PortName = cmbPortName_1.Text;

                // Open the port
                comport1.Open();
                button1_1.Text = "Close Port";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMain video = new FormMain();
            video.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        

       
     
        

      
    }
}