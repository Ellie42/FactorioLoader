using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FactorioLoader.Main.Helpers;
using FactorioLoader.Main.Models.Mods;

namespace FactorioLoader.Main.Models.Download
{
    public class ModUrlList : IEnumerable
    {
//        public KeyValuePair<string, ModFileHelper.ModFileType> Current; 
        public List<string> Urls = new List<string>();

        public ModUrlList(Mod mod)
        {
            AddUrlToList(mod.Url);
            AddUrlToList(mod.Mirror);
        }

        private void AddUrlToList(string url)
        {
            if (url == null) return;
            Urls.Add(url);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Urls.Select((t, i) => new ModUrl(
                t)).GetEnumerator();
        }
    }
}