using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfluentes.data
{
    public class Interactions
    {
        public Interactions()
        {
        }
        public Interactions(Brands brand, Users user, string type, string text)
        {
            _brand = brand;
            _user = user;
            _type = type;
            _text = text;
        }

        private Brands _brand;

        public Brands Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        private Users _user;

        public Users User
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
