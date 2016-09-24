using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfluentes.data
{
    public class Location
    {
        
        private string _street;
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _state;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        private string _postcode;
        public string Postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }
    }
}
