using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextLib.Data
{
    public class Category
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private List<string> _keyword;

        public List<string> Keyword
        {
            get { return _keyword; }
            set { _keyword = value; }
        }
        
    }
}
