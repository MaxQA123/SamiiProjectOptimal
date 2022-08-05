using Newtonsoft.Json;
using RestSharp;
using SamiiProjectOptimal.ApiHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.ApiPagesObjects
{
    public partial class LogInApi
    {
        public static string GetUserData(string email, string password)
        {
            string payload = string.Format("{{" +
                "\"email\"" + ":" + $"\"{email}\"" + "," +
                "\"password\"" + ":" + $"\"{password}\"" + "}}");

            return payload;
        }

        public static RequestLogIn UserConstData()
        {
            var payload = new RequestLogIn();
            payload.Email = CredentialsApi.emailForLogInAdmin;
            payload.Password = 1111;

            return payload;
        }

        // public static ResponseLogIn ExecuteLogIn(string email, string password)
        public static ResponseLogIn ExecuteLogIn(string payload)
        {
            var restClient = new RestClient(EndPointsApi.apiHost);

            var restRequest = new RestRequest("//public/login", Method.Post);
            restRequest.AddHeaders(Headers.HeadersCommon());

            restRequest.AddJsonBody(payload);

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusDescription == "Bad Request")
            {
                Console.WriteLine(response.Content);
            }

            var dtoObject = JsonConvert.DeserializeObject<ResponseLogIn>(content);

            return dtoObject;
        }

    }
}