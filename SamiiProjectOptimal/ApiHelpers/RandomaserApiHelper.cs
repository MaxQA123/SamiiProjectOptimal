using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.ApiHelpers
{
    public class Randomaser
    {
        public static string RandomEmail()
        {
            string email = "qatester" + DateTime.Now.ToString("yyyy-MM-d-hh-mm") + "@xitroo.com";

            return email;
        }

        public static string RandomText(int size)
        {
            var chars = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[size];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return finalString;
        }

        public static string RandomNumber()
        {
            Random r = new Random();
            int genRand = r.Next(0000000, 9999999);

            return genRand.ToString();
        }
    }
}
