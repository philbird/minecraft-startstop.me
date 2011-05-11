using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSonDeserialiser
{
    class JsonObject
    {
        public JsonUser User;
        public List<JsonStat> statschange { get; set; }
        public string Checksum { get; set; }
    }

    class JsonUser
    {
        public string Name { get; set; }
        public string SessionId { get; set; }
    }

    class JsonStat
    {
        public string Key { get; set; }
        public int Val { get; set; }
    }
}
