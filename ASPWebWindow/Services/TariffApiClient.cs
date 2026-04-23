using ASPWebWindow.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebWindow.Services
{
    public class TariffApiClient
    {
        private readonly HttpClient httpClient;
        private readonly string baseUrl = "https://localhost:7287/api/Tariff";
        public string returnMessage = string.Empty;

        public TariffApiClient()
        {
            HttpClientHandler handler = new HttpClientHandler();
            // SSL 인증서 검증 무시
            handler.ServerCertificateCustomValidationCallback =
                (message, cert, chain, errors) => true;
            httpClient = new HttpClient(handler);
        }

        public (decimal TariffAmount, decimal RatePercent) CalcAndSave(int cargoId)
        {
            HttpResponseMessage response = httpClient
                .PostAsync($"{baseUrl}/calc/{cargoId}", null).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            dynamic result = JsonConvert.DeserializeObject(json);
            return (
                TariffAmount: (decimal)result.tariffAmount,
                RatePercent: (decimal)result.ratePercent
            );
        }

        public List<TariffRate> GetRate()
        {
            // API 서버에 GET 요청
            HttpResponseMessage response = httpClient.GetAsync($"{baseUrl}/rates").Result;
            // Return Message 문자열(JSON)로 변환
            string json = response.Content.ReadAsStringAsync().Result;
            // JSON 문자열을 List<Cargo> 객체로 파싱
            return JsonConvert.DeserializeObject<List<TariffRate>>(json);
        }
    }
}
