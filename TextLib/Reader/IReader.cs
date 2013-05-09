using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextLib.Reader
{
    interface IReader
    {
        string Read(string path);
        object GetInfo(string path);
    }
}
