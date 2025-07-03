﻿
using BaseLibrary.DTOs;
using BaseLibrary.Responses;

namespace ClientLibrary.Services.Contracts
{
    public interface IUserAccountService
    {

        Task<GeneralResponse> CreateAsync(Register user);
        Task<LoginResponse> SigninAsync(Login user);
        Task<LoginResponse> RefreshTokenAsync(RefreshToken token);
        // For test purposes only
        Task<WeatherForecast[]> GetWeatherForecast();
    }
}
