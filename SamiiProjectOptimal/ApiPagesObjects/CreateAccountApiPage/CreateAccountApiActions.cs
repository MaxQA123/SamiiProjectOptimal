using Newtonsoft.Json;
using RestSharp;
using SamiiProjectOptimal.ApiHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.ApiPagesObjects.CreateAccountApiPage
{
    public partial class CreateAccountApi
    {
        public static string CreatePayload(string email, long password, long confirmPassword)
        {
            string payload = string.Format("{{" +
                "\"emailAddress\"" + ":" + $"\"{email}\"" + "," +
                "\"password\"" + ":" + $"\"{password}\"" + "," +
                "\"confirmPassword\"" + ":" + $"\"{confirmPassword}\"" + "}}");

            return payload;
        }

        public static RequestCreateAccountStudentApi UserRandomForCreateStudent()
        {
            var payload = new RequestCreateAccountStudentApi();
            payload.EmailAddress = Randomaser.RandomFullEmailApi();
            payload.Password = CredentialsApi.passwordLong;
            payload.ConfirmPassword = CredentialsApi.passwordLong;

            return payload;
        }

        // public static ResponseLogIn ExecuteLogIn(string email, string password)
        public static ResponseCreateAccountStudentApi ExecuteSignUp(string payload)
        {
            var restClient = new RestClient(EndPointsApi.apiHost);

            var restRequest = new RestRequest("//public/signup", Method.Post);
            restRequest.AddHeaders(Headers.HeadersCommon());

            restRequest.AddJsonBody(payload);

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusDescription == "Bad Request")
            {
                Console.WriteLine(response.Content);
            }

            var dtoObject = JsonConvert.DeserializeObject<ResponseCreateAccountStudentApi>(content);

            return dtoObject;
        }
    }
}
