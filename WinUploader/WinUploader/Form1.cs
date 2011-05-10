﻿using System;
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

namespace WinUploader
{
    public partial class Form1 : Form
    {

        // Setup a connection to the statdrop webservices
        public statdropws.DeveloperAPI oDevAPI = new statdropws.DeveloperAPI();
        
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
            
            openFileDialog1.ShowDialog();
            txbFileLocation.Text = openFileDialog1.FileName; 
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
           
         Int64 _UserID = oDevAPI.AuthenticateUser(APIKey, txbEmailAddress.Text, txbPassword.Text);
           

            #region Setup the Json file to be parsed... this is dirty, very dirty. ;) 

            StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
            // We should read this by line so we can add key values into the JSON/ 
             string _StatsFile ="";
             bool _hitStatsChange = false; 
            while (!streamReader.EndOfStream)
            {
                string _holdLine = streamReader.ReadLine();
               
                // Capture the end of the file. 
                if ((_hitStatsChange)&&(_holdLine.Contains("],")))
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
                _StatsFile += _holdLine + System.Environment.NewLine ; 
                
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

                      if (_UserID != -1)
             {
                          switch (_Key)
                          {
                              case "1000": 
                                  // Number of times game started
                                  oDevAPI.ExactStatUpdateForUser(APIKey, _UserID, cGameStarted,_Val, 0, "");
                                  break; 
                          }
                 
             }


                #endregion 

                _statsCount++; 
            }

          
       
        }
    }
}
