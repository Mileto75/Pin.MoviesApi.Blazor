using Pin.MoviesApi.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pin.MoviesApi.Core.Services.Interfaces
{
    public interface IApiService
    {
        Task<ResultModel> GetMoviesAsync();
        Task<ResultModel> SearchMoviesAsync(string search);
    }
}
