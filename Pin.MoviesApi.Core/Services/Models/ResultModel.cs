using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Pin.MoviesApi.Core.Services.Models
{
    public class ResultModel
    {
        [JsonPropertyName("description")]
        public IEnumerable<MovieModel> MovieModels { get; set; }
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }
    }
}
