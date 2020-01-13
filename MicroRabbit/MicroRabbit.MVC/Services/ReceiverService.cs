using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;

namespace MicroRabbit.MVC.Services
{
    public class ReceiverService : IReceiverService
    {
        private readonly HttpClient _apiClient;

        public ReceiverService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }
        public async Task Receiver(ReceiverDto receiverDto)
        {
            var uri = "https://localhost:5001/api/Cataring";
            var transferContent = new StringContent(JsonConvert.SerializeObject(receiverDto),
                                     System.Text.Encoding.UTF8, "application/json");
            var response = await _apiClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
