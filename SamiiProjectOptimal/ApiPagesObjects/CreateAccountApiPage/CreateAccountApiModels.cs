using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.ApiPagesObjects.CreateAccountApiPage
{
    public partial class RequestCreateAccountStudentApi
    {
        public string EmailAddress { get; set; }
        public long Password { get; set; }
        public long ConfirmPassword { get; set; }
    }

    public partial class ResponseCreateAccountStudentApi
    {
        public long Result { get; set; }
        public string Message { get; set; }
    }

}
