using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfluentes.data
{
    public class Picture
    {
        private string _large;
        public string Large
        {
            get { return _large; }
            set { _large = value; }
        }

        private string _medium;
        public string Medium
        {
            get { return _medium; }
            set { _medium = value; }
        }

        private string _thumbnail;
        public string Thumbnail
        {
            get { return _thumbnail; }
            set { _thumbnail = value; }
        }

    }
}
