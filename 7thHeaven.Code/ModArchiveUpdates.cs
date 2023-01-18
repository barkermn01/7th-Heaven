using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7thHeaven.Code
{
    public class ModArchiveUpdates
    {
        public ModArchiveUpdates() { }

        [System.Xml.Serialization.XmlElement("Patch")]
        public List<ModArchivePatch> patches;

        public int[] convertVersion(string version)
        {

            string[] parts = version.Split('.');
            int[] versionParts = new int[parts.Length];
            for(int key = 0; key<parts.Length; key++)
            {
                versionParts[key] = int.Parse(parts[key]);
            }
            return versionParts;
        }

        public bool isPatchAvailable(decimal version)
        {
            return GetUpdatePatches(version).Count() > 0;
        }

        public List<ModArchivePatch> GetUpdatePatches(decimal version)
        {
             return patches.FindAll((ModArchivePatch patch) => {
                return (patch.Version > version);
            });
        }
    }
}
