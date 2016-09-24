using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfluentes.data
{
    public class Users
    {
        public Users()
        {
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private Name _name;

        public Name Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Location _location;

        public Location Location
        {
            get { return _location; }
            set { _location = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private Login _login;

        public Login Login
        {
            get { return _login; }
            set { _login = value; }
        }

        private int _registered;
        public int Registered
        {
            get { return _registered; }
            set { _registered = value; }
        }

        private int _dob;
        public int Dob
        {
            get { return _dob; }
            set { _dob = value; }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private string _cell;
        public string Cell
        {
            get { return _cell; }
            set { _cell = value; }
        }

        private Picture _picture;

        public Picture Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }

        private string _nat;
        public string Nat
        {
            get { return _nat; }
            set { _nat = value; }
        }

    }
}
