using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7thHeaven.Code
{
    public class ModArchivePatch
    {
        [System.Xml.Serialization.XmlElement("Version")]
        public decimal Version { get; set; }


        [System.Xml.Serialization.XmlElement("url")]
        public string Patch { get; set; }
    }
}
