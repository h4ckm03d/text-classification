using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TextLib.Reader
{
    public class TextReader:IReader
    {
        public string Read(string path)
        {
            if (!File.Exists(path))
                return null;

            try
            {
                return File.ReadAllText(path);
            }
            catch (Exception e)
            {
                //log here
            }

            return null;
        }

        public object GetInfo(string path)
        {
            return null;
        }
    }
}
