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

namespace WinUploader
{
    public partial class Form1 : Form
    {
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
            // Load the data into a dictionary using the json deserliazer. 

            // Load the file into a strong; 
       
            StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
            string _StatsFile = streamReader.ReadToEnd();
            streamReader.Close();

            Dictionary<string, dynamic> values = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(_StatsFile);


            // Now we need to access the stats file bit

            JObject o = JObject.Parse(_StatsFile);
            JArray stats = (JArray)o["stats-change"];

            // stuck so far. :) 

        }
    }
}
