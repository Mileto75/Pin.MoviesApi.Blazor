using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pin.MoviesApi.Core.Services.Models
{
    public class TokenResultModel
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
    }
}
