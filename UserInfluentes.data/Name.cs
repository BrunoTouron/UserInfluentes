using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfluentes.data
{
    public class Name
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _first;
        public string First
        {
            get { return _first; }
            set { _first = value; }
        }

        private string _last;
        public string Last
        {
            get { return _last; }
            set { _last = value; }
        }

    }
}
