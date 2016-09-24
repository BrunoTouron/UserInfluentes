using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfluentes.data
{
    public class Brands
    {
        public Brands()
        {
        }

        public Brands(int id, string name, string image)
        {
            _id = id;
            _name = name;
            _image = image;
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _image;
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}
