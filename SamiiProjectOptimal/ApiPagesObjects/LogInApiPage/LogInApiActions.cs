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

        public static ResponseLogIn ExecuteLogIn(string email, string password)
        {
            var restClient = new RestClient(EndPointsApi.apiHost);

            var restRequest = new RestRequest("//public/login", Method.Post);
            restRequest.AddHeaders(Headers.HeadersCommon());

            restRequest.AddJsonBody(GetUserData(email, password));

            var response = restClient.Execute(restRequest);

            var content = response.Content;
            var dtoObject = JsonConvert.DeserializeObject<ResponseLogIn>(content);

            return dtoObject;
        }

    }
}
