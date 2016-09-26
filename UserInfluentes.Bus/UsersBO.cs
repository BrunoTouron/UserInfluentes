using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using UserInfluentes.data;

namespace UserInfluentes.Bus
{
    public class UsersBO
    {
        List<Brands> brands;
        List<Users> users;
        List<Interactions> interactions;
        List<_Interactions> _interactions;
        List<__Interactions> __interactions;

        public List<Brands> GetBrands()
        {            
            
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            using (StreamReader r = new StreamReader("D:\\Projetos\\UserInfluentes\\brands.json"))
            {
                string json = r.ReadToEnd();

                var json_serializer = new JavaScriptSerializer();
                brands = json_serializer.Deserialize<List<Brands>>(json);
            }

            return brands;       
        }
        
        public List<__Interactions> GetInteractions()
        { 

            foreach (_Interactions _inter in _interactions)
            {
                if (__interactions == null)
                {
                    __interactions = new List<__Interactions>();

                    __interactions.Add(new __Interactions(_inter.Brand, "", _inter.User, "", 1));
                }
                else
                {
                    if (__interactions.Exists(x => x.User == _inter.User))
                    {
                        __interactions.Add(new __Interactions(_inter.Brand, "", _inter.User, "", 1));
                    }
                    else
                    {
                        __interactions.Add(new __Interactions(_inter.Brand, "", _inter.User, "", 1));
                    }
                }
            }

            return __interactions;
        }

        public List<_Interactions> Get_Interactions()
        {
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            using (StreamReader r = new StreamReader("D:\\Projetos\\UserInfluentes\\interactions.json"))
            {
                string json = r.ReadToEnd();

                var json_serializer = new JavaScriptSerializer();
                _interactions = json_serializer.Deserialize<List<_Interactions>>(json);
            }

            return _interactions;
        }

        public List<Users> GetUsers()
        {
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            using (StreamReader r = new StreamReader("D:\\Projetos\\UserInfluentes\\users.json"))
            {
                string json = r.ReadToEnd();

                var json_serializer = new JavaScriptSerializer();
                users = json_serializer.Deserialize<List<Users>>(json);
            }

            return users;
        }

    }
}
