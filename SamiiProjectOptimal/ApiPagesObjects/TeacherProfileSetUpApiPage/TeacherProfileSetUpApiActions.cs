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
        public static string CreatePayload(string lastName)
        {
            string payload = string.Format("{{" +
                "\"userId\"" + ":" + $"\"228\"" + "," +
                "\"firstName\"" + ":" + $"\"TestTeacher\"" + "," +
                "\"lastName\"" + ":" + $"\"{lastName}\"" + "," +
                "\"email\"" + ":" + $"\"testteach@xitroo.com1\"" + "," +

                "\"phoneNumber\"" + ":" + $"\"54654654654\"" + "," +
                "\"instruments\"" + ":" + "{{" +
                   "\"id\"" + ":" + $"\"2\"" + "," +
                   "\"name\"" + ":" + $"\"Piano Accordion\"" + "," +
                   "\"id\"" + ":" + $"\"33\"" + "," +
                   "\"name\"" + ":" + $"\"Singing\"" + "," +
                   "\"id\"" + ":" + $"\"48\"" + "," +
                   "\"name\"" + ":" + $"\"Piano\"" + "," +
                   "\"id\"" + ":" + $"\"6\"" + "," +
                   "\"name\"" + ":" + $"\"Harpsichord\"" + "}}" +
                "\"address\"" + ":" + "{{" +
                   "\"id\"" + ":" + $"\"623\"" + "," +
                   "\"streetNumber\"" + ":" + $"\"null\"" + "," +
                   "\"streetName\"" + ":" + $"\"null\"" + "," +
                   "\"suburb\"" + ":" + $"\"Катумба\"" + "," +
                   "\"state\"" + ":" + $"\"NSW\"" + "," +
                   "\"country\"" + ":" + $"\"Австралия\"" + "," +
                   "\"postCode\"" + ":" + $"\"2780\"" + "," +
                   "\"longitude\"" + ":" + $"\"150.311944\"" + "," +
                   "\"latitude\"" + ":" + $"\"-33.712500000000013\"" + "," +
                   "\"location\"" + ":" + $"\"NSW\"" + "}}" +
                "\"teachingAddressAlsoResidential\"" + ":" + $"\"false\"" + "," +
                "\"includesOnlineLesson\"" + ":" + $"\"true\"" + "," +
                "\"onlineVideoLink\"" + ":" + $"\"4444\"" + "," +
                "\"isShowPriceGuide\"" + ":" + $"\"false\"" + "}}" +
                "\"teacherLocations\"" + ":" + "{{" +
                   "\"id\"" + ":" + $"\"54\"" + "," +
                   "\"name\"" + ":" + $"\"Home Studio\"" + "{{" +
                   "\"address\"" + ":" + "{{" +
                           "\"id\"" + ":" + $"\"324\"" + "," +
                           "\"streetNumber\"" + ":" + $"\"null\"" + "," +
                           "\"streetName\"" + ":" + $"\"null\"" + "," +
                           "\"suburb\"" + ":" + $"\"Катумба\"" + "," +
                           "\"state\"" + ":" + $"\"NSW\"" + "," +
                           "\"country\"" + ":" + $"\"Австралия\"" + "," +
                           "\"postCode\"" + ":" + $"\"2780\"" + "," +
                           "\"longitude\"" + ":" + $"\"150.311944\"" + "," +
                           "\"latitude\"" + ":" + $"\"-33.712500000000013\"" + "," +
                           "\"location\"" + ":" + $"\"NSW\"" + "}}" +
                  "\"teacherId\"" + ":" + $"\"29\"" + "," +
                  "\"hasLesson\"" + ":" + $"\"false\"" + "," +
                  "\"isDeleted\"" + ":" + $"\"false\"" + "}}" +

                  "\"id\"" + ":" + $"\"55\"" + "," +
                  "\"name\"" + ":" + $"\"Second\"" + "{{" +
                  "\"address\"" + ":" + "{{" +
                           "\"id\"" + ":" + $"\"325\"" + "," +
                           "\"streetNumber\"" + ":" + $"\"null\"" + "," +
                           "\"streetName\"" + ":" + $"\"null\"" + "," +
                           "\"suburb\"" + ":" + $"\"Ориндж\"" + "," +
                           "\"state\"" + ":" + $"\"NSW\"" + "," +
                           "\"country\"" + ":" + $"\"Австралия\"" + "," +
                           "\"postCode\"" + ":" + $"\"2080\"" + "," +
                           "\"longitude\"" + ":" + $"\"149.1\"" + "," +
                           "\"latitude\"" + ":" + $"\"-33.283333\"" + "," +
                           "\"location\"" + ":" + $"\"NSW\"" + "}}" +
                  "\"teacherId\"" + ":" + $"\"29\"" + "," +
                  "\"hasLesson\"" + ":" + $"\"false\"" + "," +
                  "\"isDeleted\"" + ":" + $"\"false\"" + "}}" +

                  "\"id\"" + ":" + $"\"61\"" + "," +
                  "\"name\"" + ":" + $"\"Third\"" + "{{" +
                  "\"address\"" + ":" + "{{" +
                           "\"id\"" + ":" + $"\"374\"" + "," +
                           "\"streetNumber\"" + ":" + $"\"null\"" + "," +
                           "\"streetName\"" + ":" + $"\"null\"" + "," +
                           "\"suburb\"" + ":" + $"\"null\"" + "," +
                           "\"state\"" + ":" + $"\"NSW\"" + "," +
                           "\"country\"" + ":" + $"\"Австралия\"" + "," +
                           "\"postCode\"" + ":" + $"\"null\"" + "," +
                           "\"longitude\"" + ":" + $"\"147.6991918\"" + "," +
                           "\"latitude\"" + ":" + $"\"-18.2870668\"" + "," +
                           "\"location\"" + ":" + $"\"QLD\"" + "}}" +
                  "\"teacherId\"" + ":" + $"\"29\"" + "," +
                  "\"hasLesson\"" + ":" + $"\"false\"" + "," +
                  "\"isDeleted\"" + ":" + $"\"false\"" + "}}" +

                  "\"id\"" + ":" + $"\"72\"" + "," +
                  "\"name\"" + ":" + $"\"Forth\"" + "{{" +
                  "\"address\"" + ":" + "{{" +
                           "\"id\"" + ":" + $"\"501\"" + "," +
                           "\"streetNumber\"" + ":" + $"\"null\"" + "," +
                           "\"streetName\"" + ":" + $"\"Drummond Street\"" + "," +
                           "\"suburb\"" + ":" + $"\"Carlton\"" + "," +
                           "\"state\"" + ":" + $"\"VIC\"" + "," +
                           "\"country\"" + ":" + $"\"Австралия\"" + "," +
                           "\"postCode\"" + ":" + $"\"3053\"" + "," +
                           "\"longitude\"" + ":" + $"\"144.9688269\"" + "," +
                           "\"latitude\"" + ":" + $"\"-37.7988884\"" + "," +
                           "\"location\"" + ":" + $"\"VIC\"" + "}}" +
                  "\"teacherId\"" + ":" + $"\"29\"" + "," +
                  "\"hasLesson\"" + ":" + $"\"false\"" + "," +
                  "\"isDeleted\"" + ":" + $"\"false\"" + "}}" +

                "\"timeZoneNameMoment\"" + ":" + $"\"null\"" + "}}");

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
