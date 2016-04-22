using System;
using System.Collections;
using System.Collections.Generic;
using FactorioLoader.Main.Helpers;
using FactorioLoader.Main.Models.Mods;

namespace FactorioLoader.Main.Models.Download
{
    public class ModUrlList : IEnumerable
    {
        private int curIndex;
//        public KeyValuePair<string, ModFileHelper.ModFileType> Current; 
        public List<string> Urls;
        public List<ModFileHelper.ModFileType> Types;

        public ModUrlList(Mod mod)
        {
            AddUrlToList(mod.Url);
            AddUrlToList(mod.Mirror);
        }

        private void AddUrlToList(string url)
        {
            var type = ModFileHelper.GetTypeFromUrl(url);

            if (type == ModFileHelper.ModFileType.Null ||
                type == ModFileHelper.ModFileType.Unknown)
            {
                return;
            }       

            Urls.Add(url);
            Types.Add(type);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (var i = 0; i < Urls.Count; i ++)
            {
                yield return new KeyValuePair<string,ModFileHelper.ModFileType>(
                    Urls[i],Types[i]);
            }
        }
    }
}