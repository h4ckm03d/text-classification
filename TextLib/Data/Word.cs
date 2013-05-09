using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextLib.Data
{
    public class Word
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private int _frequency;

        public int Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }

    }
}
