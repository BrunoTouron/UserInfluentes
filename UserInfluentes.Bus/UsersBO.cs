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

        public List<Interactions> GetInteractions()
        {
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            using (StreamReader r = new StreamReader("D:\\Projetos\\UserInfluentes\\brands.json"))
            {
                string json = r.ReadToEnd();

                var json_serializer = new JavaScriptSerializer();
                interactions = json_serializer.Deserialize<List<Interactions>>(json);
            }

            return interactions;
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
