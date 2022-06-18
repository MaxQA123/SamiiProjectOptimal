using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.Additional
{
    public class EndPoints
    {
        public const string logInPageUrl = "https://samii-refact.anuitexdevelopment.com/#/";
        public const string VerifyCodePageUrl = "https://samii-refact.anuitexdevelopment.com/#/signup?isTeacher=false";

        public const string emailUrlXitroo = "https://xitroo.com/#pensiveroentgen@xitroo.com";
        //public const string ServiceXitroo = "https://xitroo.com/#highdarwin@xitroo.com";
        ///#highdarwin@xitroo.com - добавляется если нужно, чтоб почта открывалась с введённой почтой которую нужно открыть
        public const string emailRandomUrlXitroo = "https://xitroo.com";
    }

    public class Credentials
    {
        public const string emailForCreateAccount = "pensiveroentgen@xitroo.com";
        public const string passwordForCreateAccount = "1111";

        public const string emailStudentOne = "newstud@xitroo.com";
        public const string passwordStudentOne = "1111";
        public const string passwordTeacherOne = "1111";

        public const string emailAdmin = "admin@admin.com1";
        public const string passwordAdmin = "1111";
    }

    public class CountryCode
    {
        public const string russia = "+7";
    }

    public class UploadImages
    {
        public const string avatarStudent = $"\\UploadImages\\ImagePandaStudent.jpg";
    }

    public class NameDomen
    {
        public static string Xitroo = "@xitroo.com";
    }
}