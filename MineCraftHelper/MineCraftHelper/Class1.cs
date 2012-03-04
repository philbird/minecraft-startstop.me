using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MineCraftHelper
{



    public class Stats
    {
         

        

    /// <summary>
    /// This returns a list of minecraft unique stat ID's and maps these to the detailed stat id's which are in startstop.me
    /// </summary>
    /// <returns>minecraftID,startstopid</returns>
       public Dictionary<string, string> MapMineCraftStats()
       {
           Dictionary<string, string> Lookup = new Dictionary<string, string>();

           // Modified to be the GUID
           // Games started
           Lookup.Add("1000", "BD6B8F97-69F3-4B0A-A048-32AC559CD841");

           //Worlds Created
           Lookup.Add("1001", "563bcbf2-9e8b-401b-8a7a-272bd1273e6f");
           //Worlds Loaded
           Lookup.Add("1002", "6c0d10da-d7c7-4f30-9c71-ba52ff856fd6");
           // Multiplayer Games Joined
           Lookup.Add("1003", "13036481-4599-46e8-b38d-fbbe1312b7cc");
           
           //Not Added to the Startstop.me platform yet. 
           //Lookup.Add("1004", "17");
           //Lookup.Add("1100", "18");

           Lookup.Add("2000", "50a7730e-4433-4179-a765-7baf9c9cdd4b");
           Lookup.Add("2001", "af07f9dd-0b02-43f9-afee-49635054be04");
           Lookup.Add("2002", "ff1d61af-6d81-4c8d-8158-b1da6b59662a");
           Lookup.Add("2003", "852dd6fc-53f1-4043-8bae-ea08967d6e01");
           Lookup.Add("2004", "15dd2e4c-bf1f-4c9e-902e-de10838373cd");
           Lookup.Add("2005", "d33d405f-5d4b-4f46-85b8-b94366902b1a");
           Lookup.Add("2006", "75e7706f-3af5-44b6-a30a-0cd15f2bc31b");
           Lookup.Add("2007", "38cada61-cea9-4e5e-8d0b-e2b21dbadb3c");
           Lookup.Add("2008", "2bbf1867-c5a5-4923-8d92-4be810c2d63d");

           Lookup.Add("2010", "a34ba54c-2d7f-452d-9ab8-b5f1dcb2c958");
           Lookup.Add("2011", "f1dc5446-93aa-4083-8b0a-864d38a0b799");

           Lookup.Add("2020", "f9175aa4-258b-4cc5-a714-95d1fbeaf743");
           Lookup.Add("2021", "9b2789d2-44cc-4d30-8e9c-540b4b37a599");
           Lookup.Add("2022", "bd05b5cf-5624-4684-927e-cd00d810d37a");
           Lookup.Add("2023", "e9fd1496-c38e-4fd6-a696-a08a84a6b047");
           Lookup.Add("2024", "1bca68ca-1de9-4194-8824-b9f6259d1aea");
           Lookup.Add("2025", "564fd10f-7de5-49ac-a45d-8cdad1168d3f"); 


           return Lookup; 
       }


        /// <summary>
        /// Returns the starstopid
        /// </summary>
        /// <param name="inboundID"></param>
        /// <returns></returns>
       public string ReturnStartStopID(string inboundID)
       {
           string _startstopid = "";

           Dictionary<string, string> Lookup = MapMineCraftStats();
           if (Lookup.ContainsKey(inboundID))
           {
               _startstopid = Lookup[inboundID].ToString(); 
           }

           return _startstopid; 
       }

    }
}
