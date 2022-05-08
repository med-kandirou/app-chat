using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
namespace app_chat
{
    class User
    {
        public static int id;
        public static string email;
        public static string nom;
        public static string password;
        public static byte[] image;

        public static bool close=false;
        


        public static bool checkemail(string email) 
        {
            Regex model = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (model.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool checkchampsignin(string nom,string pass,string confirmpass,string email)
        {
            bool res=false;
            if (nom==string.Empty|| pass == string.Empty || confirmpass==string.Empty ||email == string.Empty) 
            {
                res = true;
            }
            return res;
        }

        public static bool checkchampslogin(string email, string pass)
        {
            bool res = false;
            if (email == string.Empty || pass == string.Empty)
            {
                res = true;
            }
            return res;
        }
    }
}
