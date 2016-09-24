using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfluentes.data
{
    public class Login
    {
        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _salt;
        public string Salt
        {
            get { return _salt; }
            set { _salt = value; }
        }

        private string _md5;
        public string Md5
        {
            get { return _md5; }
            set { _md5 = value; }
        }

        private string _sha1;
        public string Sha1
        {
            get { return _sha1; }
            set { _sha1 = value; }
        }

        private string _sha256;
        public string Sha256
        {
            get { return _sha256; }
            set { _sha256 = value; }
        }

    }
}
