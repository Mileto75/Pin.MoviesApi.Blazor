using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pin.MoviesApi.Core.Services.Models
{
    public class FollowersModel
    {
        [JsonPropertyName("href")]
        public object Href { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
