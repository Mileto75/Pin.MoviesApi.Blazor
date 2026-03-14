using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pin.MoviesApi.Core.Services.Models
{
    public class ExternalUrlModel
    {
        [JsonPropertyName("spotify")]
        public string Spotify { get; set; }
    }
}
