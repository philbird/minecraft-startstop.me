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

           Lookup.Add("1000", "13");
           Lookup.Add("1001", "14");
           Lookup.Add("1002", "15");
           Lookup.Add("1003", "16");
           
           //Not Added to the Startstop.me platform yet. 
           //Lookup.Add("1004", "17");
           //Lookup.Add("1100", "18");

           Lookup.Add("2000", "17");
           Lookup.Add("2001", "18");
           Lookup.Add("2002", "19");
           Lookup.Add("2003", "20");
           Lookup.Add("2004", "21");
           Lookup.Add("2005", "22");
           Lookup.Add("2006", "23");
           Lookup.Add("2007", "24");
           Lookup.Add("2008", "25");
          
           Lookup.Add("2010", "26");
           Lookup.Add("2011", "27");

           Lookup.Add("2020", "28");
           Lookup.Add("2021", "29");
           Lookup.Add("2022", "30");
           Lookup.Add("2023", "31");
           Lookup.Add("2024", "32");
           Lookup.Add("2025", "33"); 


           return Lookup; 
       }


        /// <summary>
        /// Returns the starstopid
        /// </summary>
        /// <param name="inboundID"></param>
        /// <returns></returns>
       public Int64 ReturnStartStopID(string inboundID)
       {
           Int64 _startstopid = -1;

           Dictionary<string, string> Lookup = MapMineCraftStats();
           if (Lookup.ContainsKey(inboundID))
           {
               _startstopid = Int64.Parse(Lookup[inboundID]); 
           }

           return _startstopid; 
       }

    }
}
