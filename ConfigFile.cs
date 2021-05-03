using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Config.Utils;

namespace Config
{

    internal class ConfigFile
    {
        private Dictionary<String, String> Data;
        private string _configPath;

        internal ConfigFile(string path)
        {
            Data = new Dictionary<string, string>();

            _configPath = path;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string currentLine;
                    while((currentLine = sr.ReadLine()) != null)
                    {
                        var splitLine = currentLine.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        if (splitLine.Length < 2) continue;
                        var voice = splitLine[0].Trim();
                        var value = splitLine[1].Trim();

                        Data.Add(voice, value);
                    }

                }
            }
            catch (Exception e) {  /* We'll just use default  data */}
        }

        internal void Save()
        {
            using(var sw = new StreamWriter(_configPath, false))
            {
                foreach(var entry in Data)
                {
                    sw.WriteLine("{0}\t{1}", entry.Key, entry.Value);
                }
            }
        }

        internal Resolution GetResolution()
        {
            // Loading from INI
            var width = Read("WIDTH", 800);
            var height = Read("HEIGHT", 600);
            var ret = new Resolution(width, height);
            // Checking if the resolution is valid
            return  ret ;
        }
        internal void SetResolution( Resolution resolution)
        {
            Write( "WIDTH", resolution.X);
            Write( "HEIGHT", resolution.Y);
        }
        internal void Write( string name, string value)
        {
            if (Data.ContainsKey(name))
                Data[name] = value;
            else
                Data.Add(name, value);
        }
        internal string Read( string name, string defaultValue)
        {
            if (!Data.ContainsKey(name))
                Data[name] = defaultValue;
            return Data[name];
        }

        #region Read/Write overloads
        internal void Write( string name, int value)
        {
            Write( name, value.ToString());
        }

        internal void Write( string name, bool value)
        {
            Write( name, value ? "1" : "0");
        }

        internal void Write(string name, float value)
        {
            Write( name, value.ToString("0.00"));
        }



        internal int Read(string name, int defaultValue)
        {
            int ret = 0;
            Int32.TryParse(Read( name, defaultValue.ToString()), out ret);
            return ret;
        }

        internal bool Read(string name, bool defaultValue)
        {
            
            return Read( name, (defaultValue ? "1" : "0")).ToLower() != "0";
        }

        internal float Read( string name, float defaultValue)
        {
            float ret = 0;
            Single.TryParse(Read( name, defaultValue.ToString()).Replace('.', ','), out ret);
            return ret;
        }
        #endregion
    }
}
