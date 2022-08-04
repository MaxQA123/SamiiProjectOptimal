using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.ApiPagesObjects
{
    public partial class LogInApi
    {
        public class RequestLogIn
        {
            public string Email { get; set; }
            public long Password { get; set; }
        }

        public partial class ResponseLogIn
        {
            public string AccessToken { get; set; }
            public long Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public long UserRoleType { get; set; }
            public long Result { get; set; }
            public string Email { get; set; }
            public bool IsProfileSetup { get; set; }
            public bool IsInvited { get; set; }
            public string AvatarFileData { get; set; }
            public object AvatarMimeType { get; set; }
            public bool IncludesOnlineLesson { get; set; }
        }
    }
}
