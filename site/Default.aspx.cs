using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using JSonDeserialiser;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; 

public partial class _Default : System.Web.UI.Page
{

    
     

    // Developer APIKEY
    const string APIKey = "1b50f643-fb89-4d5a-8fcf-20ca96deef22";

    const Int64 cGameStarted = 13;


    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void uxDoUpload_Click(object sender, EventArgs e)
    {

        if (uxUpload.HasFile)
        {
            try
            {
                string filename = Path.GetFileName(uxUpload.FileName);
                uxUpload.SaveAs(Server.MapPath("~/uploadedstats/") + filename);



                // Next read the file from the directory

                statdropws.DeveloperAPI oDevAPI = new statdropws.DeveloperAPI();
                Int64 _UserID = oDevAPI.AuthenticateUser(APIKey, uxEmailAddress.Text, uxPassword.Text);


                #region Setup the Json file to be parsed... this is dirty, very dirty. ;)

                StreamReader streamReader = new StreamReader(Server.MapPath("~/uploadedstats/") + filename);
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

                    if (_UserID != -1)
                    {
                        switch (_Key)
                        {
                            case "1000":
                                // Number of times game started
                                oDevAPI.ExactStatUpdateForUser(APIKey, _UserID, cGameStarted, _Val, 0, "");
                                break;
                        }

                    }


                    #endregion

                    _statsCount++;
                }

            }
            catch (Exception ex)
            {
                // StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
            }
        } 
    }
}