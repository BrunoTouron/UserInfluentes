using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfluentes.data
{
    public class _Interactions
    {
        public _Interactions()
        {
        }
        public _Interactions(int brand, int user, string type, string text)
        {

            _brand = brand;
            _user = user;
            _type = type;
            _text = text;
        }

        private int _brand;

        public int Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        private int _user;

        public int User
        {
            get { return _user; }
            set { _user = value; }
        }
       
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _text;
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
    }
}
