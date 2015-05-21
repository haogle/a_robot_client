using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using NMEA2OSGdemo.Properties;

namespace NMEA2OSGdemo
{
    public partial class Form1 : Form
    {
        #region declarations
        // NMEA interpreter
        NmeaInterpreter GPS = new NmeaInterpreter();
        // OSGridConverter
        NMEA2OSG OSGconv = new NMEA2OSG();



        // The main control for communicating through the RS-232 port
        private SerialPort comport = new SerialPort("COM1", 4800, Parity.None, 8, StopBits.One);
        public string[] gpsString;
        public string instring;
        public string[] nrthest;
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
                this.Close();
            }
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

      
    }
}