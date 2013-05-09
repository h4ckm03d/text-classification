using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

        private Dictionary<string, int> _words;

        public Dictionary<string, int> Words
        {
            get
            {
                if (_words == null)
                {
                    _words = CountWords(GetListWords());
                }
                return _words;
            }
            set { _words = value; }
        }

        private string _filepath;

        public string FilePath
        {
            get { return _filepath; }
            set { _filepath = value; }
        }

        TextLib.Reader.TextReader textReader;

        public TextInfo()
        {
             textReader= new TextLib.Reader.TextReader();
        }

        public List<string> GetListWords()
        {
            string sentence = textReader.Read(FilePath);
            Console.WriteLine(sentence);
            string[] words = Regex.Split(sentence, @"\W");
            var list = new List<string>();
            foreach (string value in words)
            {
                //
                // Check the word.
                //
                if (!string.IsNullOrEmpty(value))
                {
                    list.Add(value);
                }
            }
            return list;
        }

        private Dictionary<string, int> CountWords(IEnumerable<string> strings)
        {
            return strings.SelectMany(s => s.Split(' ')).GroupBy(w => w).ToDictionary(g => g.Key, g => g.Count());
        }

    }
}
