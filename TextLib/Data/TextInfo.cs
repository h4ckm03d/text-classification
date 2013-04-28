using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextLib.Data
{
    public class TextInfo
    {
        private string _raw;

        public string Raw
        {
            get { return _raw; }
            set { _raw = value; }
        }

        private List<Word> _words;

        public List<Word> Words
        {
            get { return _words; }
            set { _words = value; }
        }

        private string _filepath;

        public string FilePath
        {
            get { return _filepath; }
            set { _filepath = value; }
        }
        

    }
}
