﻿using System;
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

        public const string emailUrlXitroo = "https://xitroo.com/#dfgdfgfdgentgen@xitroo.com";
        //public const string ServiceXitroo = "https://xitroo.com/#highdarwin@xitroo.com";
        ///#highdarwin@xitroo.com - добавляется если нужно, чтоб почта открывалась с введённой почтой которую нужно открыть
        public const string emailRandomUrlXitroo = "https://xitroo.com";
        public const string emailStudentStudTestNeww = "https://xitroo.com/#newstud@xitroo.com";

        public const string emailUrlForgotPasswordStudent = "https://xitroo.com/#elegantchandrasekhar@xitroo.com";
        public const string emailUrlForgotPasswordTeacher = "https://xitroo.com/#testteach@xitroo.com1";
        public const string emailUrlForgotPasswordAdmin = "";
    }

    public class Credentials
    {
        public const string emailForCreateAccount = "dfgdfgfdgentgen@xitroo.com";
        public const string passwordForCreateAccount = "1111";

        public const string emailStudentOne = "newstud@xitroo.com";
        public const string passwordStudentOne = "1111";

        public const string emailTeacherOne = "testteach@xitroo.com1";
        public const string passwordTeacherOne = "1111";

        public const string emailAdmin = "admin@admin.com1";
        public const string passwordAdmin = "1111";

        public const string emailForgotPassword = "elegantchandrasekhar@xitroo.com";
        public const string passwordForChange = "1234";
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

    public class PriceForLesson
    {
        public const string minPrice = "10";
    }
}