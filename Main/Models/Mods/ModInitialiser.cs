using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using Newtonsoft.Json.Linq;

namespace FactorioLoader.Main.Models.Mods
{
    public partial class Mod
    {
        public Mod()
        {
        }

        /// <summary>
        /// Create object using json from info.json
        /// </summary>
        /// <param name="json"></param>
        /// <param name="folderPath"></param>
        public Mod(Dictionary<string,dynamic> json,string folderPath = null)
        {
            Name = GetValueFromJson(json,"name") as string;
            Description = GetValueFromJson(json, "description") as string;
            Author = GetValueFromJson(json, "author") as string;
            DependencyString = GetValueFromJson(json, "dependencies") as string;
            Version = GetValueFromJson(json, "version") as string;
            Title = GetValueFromJson(json, "title") as string;
            HomePage = GetValueFromJson(json, "homepage") as string;

            if (folderPath != null)
            {
                var splitPath = folderPath.Split('\\');
                FolderName = splitPath[splitPath.Length - 1];
            }
        }

        /// <summary>
        /// Create mod using downloaded JSON
        /// </summary>
        /// <param name="json"></param>
        public Mod(JObject json)
        {
            Name = GetValueFromJson(json,"name") as string;
            Description = GetValueFromJson(json,"description") as string;
            Author = GetValueFromJson(json,"author") as string;
            DependencyString = GetValueFromJson(json,"dependencies") as string;
            Title = GetValueFromJson(json,"title") as string;
            HomePage = GetValueFromJson(json,"id") as string;
            GeneralId = GetValueFromJson(json,"id") as string;
            GeneralUrl = GetValueFromJson(json,"url") as string;

            var release = json["releases"][0];
            Id = release["id"].Value<string>();
            Version = release["version"].Value<string>();
            Url = release["files"][0]["url"].Value<string>() ?? release["files"][0]["mirror"].Value<string>();

        }

        /// <summary>
        /// Return value from json if exists
        /// </summary>
        /// <param name="json"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private dynamic GetValueFromJson(JObject json, string key)
        {
            JToken value;
            json.TryGetValue(key, out value);
            try
            {
                return value.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Return value from json if exists
        /// </summary>
        /// <param name="json"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private dynamic GetValueFromJson(Dictionary<string, dynamic> json, string key)
        {
            if (json.ContainsKey(key))
            {
                return json[key];
            }
            return null;
        }
    }
}