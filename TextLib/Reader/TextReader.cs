using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TextLib.Reader
{
    public class TextReader:IReader
    {
        public string Read<string>(string path)
        {
            if (!File.Exists(path))
                return null;

            try
            {
                return File.ReadAllText(path, ASCIIEncoding.UTF32);
            }
            catch (Exception e)
            {
                //log here
            }

            return null;
        }

        public T GetInfo<T>(string path)
        {
            throw new NotImplementedException();
        }
    }
}
