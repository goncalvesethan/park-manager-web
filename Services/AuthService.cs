// Services/AuthService.cs
using System.Net.Http.Json;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Models;

namespace ParkManagerWeb.Services;

public class AuthService
{
    private readonly HttpClient _httpClient;
    private readonly ILocalStorageService _localStorage;
    private readonly CustomAuthStateProvider _authStateProvider;

    public AuthService(HttpClient httpClient, ILocalStorageService localStorage, AuthenticationStateProvider authStateProvider)
    {
        _httpClient = httpClient;
        _localStorage = localStorage;
        _authStateProvider = (CustomAuthStateProvider)authStateProvider;
    }

    public async Task<bool> LoginAsync(LoginModel loginModel)
    {
        var response = await _httpClient.PostAsJsonAsync("api/auth/login", loginModel);

        if (response.IsSuccessStatusCode)
        {
            var tokenResponse = await response.Content.ReadFromJsonAsync<TokenResponse>();
            if (tokenResponse != null)
            {
                await _localStorage.SetItemAsync("jwt_token", tokenResponse.Token);
                _authStateProvider.NotifyUserLoggedIn(tokenResponse.Token);
                return true;
            }
        }
        return false;
    }

    public async Task LogoutAsync()
    {
        await _localStorage.RemoveItemAsync("jwt_token");
        _authStateProvider.NotifyUserLogout();

    }

    public async Task<string?> GetTokenAsync()
    {
        return await _localStorage.GetItemAsync<string>("jwt_token");
    }
}

// Classe pour la réponse du token JWT
public class TokenResponse
{
    public string Token { get; set; } = "";
}