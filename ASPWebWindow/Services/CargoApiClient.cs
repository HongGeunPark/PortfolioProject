using ASPWebWindow.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace ASPWebWindow.Services
{
    public class CargoApiClient
    {
        private readonly HttpClient httpClient;
        private readonly string baseUrl = "https://localhost:7287/api/Cargo";
        public string returnMessage = string.Empty; 


        public CargoApiClient()
        {
            HttpClientHandler handler = new HttpClientHandler();
            // SSL 인증서 검증 무시
            handler.ServerCertificateCustomValidationCallback =
                (message, cert, chain, errors) => true;
            httpClient = new HttpClient(handler);
        }

        /**************************************************************
        * GET    →  URL만 보냄  →  JSON 받아서 객체로 파싱          *
        * POST   →  객체를 JSON으로 변환해서 보냄  →  성공여부 확인 *
        * PUT    →  URL에 값 담아서 보냄  →  성공여부 확인          *
        * DELETE →  URL에 ID 담아서 보냄  →  성공여부 확인          *
        ***************************************************************/

        public List<Cargo> GetAll()
        {
            // API 서버에 GET 요청
            HttpResponseMessage response = httpClient.GetAsync(baseUrl).Result;
            // Return Message 문자열(JSON)로 변환
            string json = response.Content.ReadAsStringAsync().Result;
            // JSON 문자열을 List<Cargo> 객체로 파싱
            return JsonConvert.DeserializeObject<List<Cargo>>(json);
        }

        public List<Cargo> GetHistory(int cargoId)
        {
            // API 서버에 GET 요청
            HttpResponseMessage response = httpClient.GetAsync($"{baseUrl}/{cargoId}/history").Result;
            // Return Message 문자열(JSON)로 변환
            string json = response.Content.ReadAsStringAsync().Result;
            // JSON 문자열을 List<Cargo> 객체로 파싱
            return JsonConvert.DeserializeObject<List<Cargo>>(json);
        }

        public JArray GetAllJObject()
        {
            // API 서버에 GET 요청
            HttpResponseMessage response = httpClient.GetAsync(baseUrl).Result;
            // Return Message 문자열(JSON)로 변환
            string json = response.Content.ReadAsStringAsync().Result;
            JArray array = JArray.Parse(json);
            // JSON 문자열을 JObject에 담아서 객체 이용없이 DataTable과 유사한 동작을 할 수 있도록 함
            return array;
        }
        public dynamic GetAllDynamic()
        {
            // API 서버에 GET 요청
            HttpResponseMessage response = httpClient.GetAsync(baseUrl).Result;
            // Return Message 문자열(JSON)로 변환
            string json = response.Content.ReadAsStringAsync().Result;
            dynamic result = JsonConvert.DeserializeObject(json);
            // JSON 자체를 사용
            return result;
        }

        public Cargo GetById(int cargoId)
        {
            HttpResponseMessage response = httpClient.GetAsync($"{baseUrl}/{cargoId}").Result;
            string json = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Cargo>(json);
        }

        public bool ExecuteDML(Cargo cargo, string dml)
        {
            // C# 객체를 JSON 문자열로 변환
            string json = JsonConvert.SerializeObject(cargo);

            // JSON을 HTTP 전송 가능한 형태로 담기
            StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = new HttpResponseMessage();
            if (dml.Equals("I"))
            {
                // API 서버에 POST
                response = httpClient.PostAsync(baseUrl, content).Result;

                returnMessage = response.Content.ReadAsStringAsync().Result;

                return response.IsSuccessStatusCode;
            }
            else if (dml.Equals("U"))
            {
                // API 서버에 PUT
                response = httpClient.PutAsync($"{baseUrl}/{cargo.CargoId}", content).Result;

                returnMessage = response.Content.ReadAsStringAsync().Result;

                return response.IsSuccessStatusCode;
            }
            else if (dml.Equals("D"))
            {
                // API 서버에 PUT
                response = httpClient.DeleteAsync($"{baseUrl}/{cargo.CargoId}/ADMIN").Result;

                returnMessage = response.Content.ReadAsStringAsync().Result;

                return response.IsSuccessStatusCode;
            }

            return response.IsSuccessStatusCode;
        }

        public bool UpdateStatus(int cargoId, int status)
        {
            // JSON 형식으로 API에 보내는게 아닌 URL 자체에 값을 담아서 보내는 방식
            HttpResponseMessage response = httpClient.PutAsync(
                $"{baseUrl}/{cargoId}/status/{status}", null).Result;
            return response.IsSuccessStatusCode;
        }

        public bool Delete(int cargoId)
        {
            // JSON 형식으로 API에 보내는게 아닌 URL 자체에 값을 담아서 보내는 방식
            HttpResponseMessage response = httpClient.DeleteAsync($"{baseUrl}/{cargoId}").Result;
            return response.IsSuccessStatusCode;
        }
    }
}
