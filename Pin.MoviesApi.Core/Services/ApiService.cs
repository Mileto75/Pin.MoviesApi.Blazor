using Pin.MoviesApi.Core.Services.Interfaces;
using Pin.MoviesApi.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Pin.MoviesApi.Core.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        private readonly Uri _baseUrl;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _baseUrl = new Uri("https://imdb.iamidiotareyoutoo.com/search?q=");
        }

        public async Task<ResultModel> GetMoviesAsync()
        {
            ResultModel resultModel = new ResultModel();
            var result = await _httpClient.GetAsync($"{_baseUrl}a");
            if (result.IsSuccessStatusCode) 
            {
                var content = await result.Content.ReadAsStreamAsync();
                resultModel = JsonSerializer.Deserialize<ResultModel>(content);
            }
            return resultModel;
        }

        public async Task<ResultModel> SearchMoviesAsync(string search)
        {
            ResultModel resultModel = new ResultModel();
            var result = await _httpClient.GetAsync($"{_baseUrl}{search}");
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStreamAsync();
                resultModel = JsonSerializer.Deserialize<ResultModel>(content);
            }
            return resultModel;
        }
    }
}
