using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfluentes.data
{
    public class __Interactions
    {
        public __Interactions()
        {
        }
        public __Interactions(int brand, string brandDesc, int user, string userDesc, int quantidade)
        {
            _brand = brand;
            _brandDesc = brandDesc;
            _user = user;
            _userDesc = userDesc;
            _quantidade = quantidade;
        }

        private int _brand;

        public int Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        private string _brandDesc;

        public string BrandDesc
        {
            get { return _brandDesc; }
            set { _brandDesc = value; }
        }

        private int _user;

        public int User
        {
            get { return _user; }
            set { _user = value; }
        }
        private string _userDesc;

        public string UserDesc
        {
            get { return _userDesc; }
            set { _userDesc = value; }
        }

        private int _quantidade;

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
    }
}
