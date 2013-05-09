using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            TextLib.Reader.TextReader tr = new TextLib.Reader.TextReader();
            string sentence = tr.Read(@"49960");
            Console.WriteLine(sentence);
            string[] uppercaseWords = Regex.Split(sentence, @"\W");
            var list = new List<string>();
            foreach (string value in uppercaseWords)
            {
                //
                // Check the word.
                //
                if (!string.IsNullOrEmpty(value))
                {
                    list.Add(value);
                }
            }
            var dt = CountWords3(list);
            foreach (var s in dt)
            {
                Console.WriteLine("{0}={1}",s.Key,s.Value);
            }
            Console.ReadLine();
        }

        public static Dictionary<string, int> CountWords3(IEnumerable<string> strings)
        {
            return strings.SelectMany(s => s.Split(' ')).GroupBy(w => w).ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
