using Newtonsoft.Json;
using RestSharp;
using RimuTec.Faker;
using SamiiProjectOptimal.ApiHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.ApiPagesObjects.TeacherProfileSetUpApiPage
{
    public partial class TeacherProfileSetUpApi
    {
        public static string CreatePayload(long userId, string lastName)
        {
            string payload = string.Format("{{" +
                "\"userId\"" + ":" + $"\"{userId}\"" + "," +
                "\"lastName\"" + ":" + $"\"{lastName}\"" + "}}");

            return payload;
        }

        public static RequestTeacherProfileSetUpApi ChangeLastNameForTeacher()
        {
            var payload = new RequestTeacherProfileSetUpApi();
            payload.LastName = Name.LastName();

            return payload;
        }

        public static ResponseTeacherProfileSetUpApi ExecuteSignUp(string payload)
        {
            var restClient = new RestClient(EndPointsApi.apiHost);

            var restRequest = new RestRequest("//teacher/profile/setup/setup", Method.Put);
            restRequest.AddHeaders(Headers.HeadersCommon());

            restRequest.AddJsonBody(payload);

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusDescription == "Bad Request")
            {
                Console.WriteLine(response.Content);
            }

            var dtoObject = JsonConvert.DeserializeObject<ResponseTeacherProfileSetUpApi>(content);

            return dtoObject;
        }
    }
}
