using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextLib.Reader
{
    interface IReader
    {
        public T Read<T>(string path);
        public T GetInfo<T>(string path);
    }
}
