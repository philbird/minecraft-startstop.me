using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using JSonDeserialiser;
using System.Diagnostics;

namespace WinUploader
{
    public partial class Form1 : Form
    {

        #region deprecated calls
        // Setup a connection to the statdrop webservices
        public statdropws.DeveloperAPI oDevAPI = new statdropws.DeveloperAPI();

        //set up the return message
        public statdropws.ReturnMessage oReturnMessage = new statdropws.ReturnMessage();
        #endregion

        #region New Service Calls

        public startstop.AccessPoint StartStopAccess = new startstop.AccessPoint();
        public startstop.MessageResponse MessageResponse = new startstop.MessageResponse();
        public startstop.ValidatedUserInfo ValidatedUserInfo = new startstop.ValidatedUserInfo();
        public startstop.UserStat UserStat = new startstop.UserStat(); 

        #endregion

        // Developer APIKEY
        const string APIKey = "1b50f643-fb89-4d5a-8fcf-20ca96deef22";

        const Int64 cGameStarted = 13;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
            
            \AppData\Roaming\.minecraft\stats\*.dat
             
             */

            // Instead of using this lets grab the correct path
            string path =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\stats\\";


            string[] files = Directory.GetFiles(path);
            // Look for the .DAT files
            foreach (string fileInDir in files)
            {
                if (fileInDir.ToLower().Contains(".dat"))
                {
                    // Found the minecraft file
                    txbFileLocation.Text = fileInDir;
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            // Validate the user
            ValidatedUserInfo = StartStopAccess.LoginUser(APIKey, txbEmailAddress.Text, txbPassword.Text);
            // Check to see if the user is validated
            if (!ValidatedUserInfo.Validated) // User details invalid
            {
                if ((txbEmailAddress.Text == "") || (txbPassword.Text == ""))
                {
                    MessageBox.Show("You need to provide your email and password to upload");
                }
                else
                {
                    MessageBox.Show("Login not successful, please login.");
                }
            }
            else
            {
                if (txbFileLocation.Text == "")
                {
                    MessageBox.Show("You must select your file"); 
                    
                }
                else
                {

                    Int64 _UserID = oReturnMessage.ReturnedID;

                    #region Setup the Json file to be parsed... this is dirty, very dirty. ;)

                    StreamReader streamReader = new StreamReader(txbFileLocation.Text);
                    // We should read this by line so we can add key values into the JSON/ 
                    string _StatsFile = "";
                    bool _hitStatsChange = false;
                    while (!streamReader.EndOfStream)
                    {
                        string _holdLine = streamReader.ReadLine();

                        // Capture the end of the file. 
                        if ((_hitStatsChange) && (_holdLine.Contains("],")))
                        {

                            _hitStatsChange = false;
                        }


                        if (_hitStatsChange)
                        {
                            // Add the Value
                            _holdLine = _holdLine.Replace("\":", "\", \"Val\":");
                            // Add the Key
                            _holdLine = _holdLine.Replace("{\"", "{\"Key\":\"");

                        }
                        // This has to go below the above so we don't capure the initia line. 
                        if (_holdLine.ToLower().Contains("stats-change"))
                        {
                            _hitStatsChange = true;
                            // This is a dirty aweful hack this whole lot. 
                            _holdLine = _holdLine.Replace("stats-change", "statschange");
                        }
                        _StatsFile += _holdLine + System.Environment.NewLine;

                    }

                    streamReader.Close();
                    #endregion

                    var jsonObject = JsonConvert.DeserializeObject<JsonObject>(_StatsFile);

                    int _statsCount = 0;
                    while (_statsCount < jsonObject.statschange.Count)
                    {
                        string _Key = jsonObject.statschange[_statsCount].Key;
                        int _Val = jsonObject.statschange[_statsCount].Val;

                        #region UploadTheStat

                        // Load the dictionary
                        MineCraftHelper.Stats oStats = new MineCraftHelper.Stats();


                        // If this user has validated first. 
                        if (ValidatedUserInfo.Validated)
                        {
                            // This should only then try to load up the keys which have been converted to GUIDs
                            if ((oStats.ReturnStartStopID(_Key) != "") && (oStats.ReturnStartStopID(_Key).Length > 6))
                            {

                                //oDevAPI.ExactStatUpdateForUser(APIKey, _UserID, oStats.ReturnStartStopID(_Key), _Val, 0, "");
                                //oDevAPI.ExactStatUpdateForUser(APIKey, UserID, detailstatid, Count, perfectnag, Note);

                                // Flush it
                                UserStat = new startstop.UserStat();

                                // Load the object ready to send. 
                                UserStat.UserGuid = ValidatedUserInfo.UserGUID;
                                UserStat.DetailedStatGuid = new Guid(oStats.ReturnStartStopID(_Key));
                                UserStat.Count = _Val;
                                UserStat.Note = "";
                                // This is the minecraft over view GUID. 
                                UserStat.DetailedStatOverviewGUID = new Guid("81FC7B81-EF9C-4328-A24F-3F7229C8E052"); 

                                
                                // Send the object and load in the result. 
                                MessageResponse = StartStopAccess.AddUserStat("bdc11d92-7ade-4dc1-885d-24ccfe32d174", UserStat);

                                // Now we need to check to see if a problem has occurred. 
                                if (!MessageResponse.Success)
                                {
                                    MessageBox.Show(MessageResponse.Message); 
                                }

                            }

                        }


                        #endregion

                        _statsCount++;
                    }
                    // Update the last updated
                    // TO DO! 
                    //oDevAPI.ExactStatUpdateForUser(APIKey, _UserID, 34, 0, 0, DateTime.Now.ToString());
                    
                    
                    lblMessage.Visible = true;
                } // End no file record IF
            } // End Not Logged in IF

        }

        private void btnSelfLocate_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txbFileLocation.Text = openFileDialog1.FileName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.statstop.me/Register.aspx");
        }


        /// <summary>
        /// Lets the user validate it before he starts off. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate the user
            ValidatedUserInfo = StartStopAccess.LoginUser(APIKey, txbEmailAddress.Text, txbPassword.Text);
            // Check to see if the user is validated
            if (!ValidatedUserInfo.Validated) // User details invalid
            {
                if ((txbEmailAddress.Text == "") || (txbPassword.Text == ""))
                {
                    MessageBox.Show("You need to provide your email and password to upload");
                }
                else
                {
                    MessageBox.Show("Login not successful, please login.");
                }
            }
            else
            {
                // Once logged in we can disable all the stuff
                txbPassword.Enabled = false;
                txbEmailAddress.Enabled = false;
                btnLogin.Enabled = false; 
            }
        }

    }
}
