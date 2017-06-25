using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using NDde.Client;
using SpaceHardwareClub;

namespace DDETest
{
    public partial class DDETest : Form
    {
        const string defaultSatName = "0";//do not make an actual name, this will be used to check the connection
        const int port = 6767;
        const string ipAddr = "127.0.0.1";
        string DDEmsg;
        SpaceHardwareClub.ITCPMessage tcpMessage = (ITCPMessage)Activator.GetObject(typeof(TCPMessage), "tcp://" + ipAddr + ":" + port + "/GetMessage");

        //NamedPipeServer pipeServer;
        //NamedPipeServerStream server = new NamedPipeServerStream("OrbitronPipe",PipeDirection.InOut,1,PipeTransmissionMode.Message,PipeOptions.None);
        NDde.Client.DdeClient client = new DdeClient("Orbitron", "Tracking");
        SatelliteData satellite = new SatelliteData(defaultSatName,0,0,0,0,0);
        
        public DDETest()
        {
            InitializeComponent();
            ddeTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {//		requestArray	"SN\"ISS\" AZ75.9 EL-49.8 DN130165152 UP121751728 RA10281.505 RR4.255 LO21.7041 LA3.9309 AL413.780 TU20121221221254 TL20121221161254\r\n\0"	string

            DDEmsg = client.Request("TrackingDataEx", 5000);
            MessageBox.Show("Got request!" + DDEmsg);
        }

        public void parseMessage(string msg)
        {
            //if (msg.Split(' ').Length > 12)
            //{

            //}
            string[] message = msg.Split(' ');
            try
            {
                satellite.name = (msg.Split('"')[1]).Substring(0);
            }
            catch
            {
                satellite.name = "0";
            }

            foreach (string str in message)
            {
                try
                {
                    if (str.Length < 2)
                        continue;
                    switch (str.Substring(0, 2))
                    {
                        //case "SN": satellite.name = str.Substring(3, str.Length - 4);//trims the \" from either side of the name
                        //    break;
                        case "AZ": satellite.azimuth = Double.Parse(str.Substring(2, str.Length - 3));
                            break;
                        case "EL": satellite.elevation = Double.Parse(str.Substring(2, str.Length - 3));
                            break;
                        case "DN": satellite.downlinkFreq = Int32.Parse(str.Substring(2, str.Length - 2));
                            break;
                        case "UP": satellite.uplinkFreq = Int32.Parse(str.Substring(2, str.Length - 2));
                            break;
                        case "AL": satellite.altitude = Double.Parse(str.Substring(2, str.Length - 2));
                            break;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Bad number was caught.", "Number format exception");
                }
            }
            //satellite.baseFreq = (satellite.uplinkFreq + satellite.downlinkFreq / 2);
            //satellite.doppShift = Math.Abs(satellite.downlinkFreq - satellite.baseFreq);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.Connect();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            client.Disconnect();
        }

        private void DDETest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(client.IsConnected)
                client.Disconnect();
        }

        private void ddeBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!client.IsConnected)
            {
                try
                {
                    client.Connect();
                }
                catch (Exception)
                {
                }
            }

            if (client.IsConnected)
            {//not an else if in case the connect succeeds
                DDEmsg = client.Request("TrackingDataEx", 5000);
                parseMessage(DDEmsg);
            }
        }

        private void ddeBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //string message = "";
            nameValueLabel.Text = satellite.name;
            azimuthValueLabel.Text = satellite.azimuth.ToString();
            elevationValueLabel.Text = satellite.elevation.ToString();
            altitudeValueLabel.Text = satellite.altitude.ToString();
            downlinkValueLabel.Text = satellite.downlinkFreq.ToString();
            uplinkValueLabel.Text = satellite.uplinkFreq.ToString();
            //baseFreqValueLabel.Text = satellite.baseFreq.ToString();
            

            if (client.IsConnected && satellite.name == defaultSatName)
                ddeStatusLabel.Text = "Connected";
            else if (client.IsConnected)
            {
                ddeStatusLabel.Text = "Open";
                Thread t = new Thread(interopMessage);
                t.Start();
            }
            else
                ddeStatusLabel.Text = "Disconnected";

            //if (!pipeBackgroundWorker.IsBusy)
            //    pipeBackgroundWorker.RunWorkerAsync();
        }

        private void interopMessage()
        {
            string msg = satellite.name + "|" + satellite.azimuth + "|" + satellite.elevation + "|" + satellite.downlinkFreq + "|" + satellite.uplinkFreq;
            try
            {
                tcpMessage.ping();
            }
            catch(System.Net.Sockets.SocketException)
            {
                //didn't connect to server, so leave thread
                return;
            }
            catch (System.Runtime.Remoting.RemotingException)
            {
                return;
            }

            tcpMessage.sendMessage(msg);
        }

        private void ddeTimer_Tick(object sender, EventArgs e)
        {
            if (!ddeBackgroundWorker.IsBusy)
            {
                //pipeTimer.Start();
                ddeBackgroundWorker.RunWorkerAsync();
            }
        }

        //private void pipeBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    
        //    string pipeWrite = satellite.name + "|" + satellite.azimuth + "|" + satellite.elevation + "|" + satellite.downlinkFreq + "|" + satellite.uplinkFreq;
        //
        //    try
        //    {
        //        if (!server.IsConnected && satellite.name != defaultSatName)
        //            server.WaitForConnection();
        //    
        //        if (server.IsConnected)
        //            server.Write(UnicodeEncoding.ASCII.GetBytes(pipeWrite), 0, pipeWrite.Length);
        //    }
        //    catch (Exception)
        //    {
        //        server.Disconnect();
        //    }
        //}
        //
        //private void pipeTimer_Tick(object sender, EventArgs e)
        //{
        //    
        //    pipeTimer.Stop();
        //}
    }
}
