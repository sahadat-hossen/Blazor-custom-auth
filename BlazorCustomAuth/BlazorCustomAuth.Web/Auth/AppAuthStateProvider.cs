using BlazorCustomAuth.Service;
using BlazorCustomAuth.Web.Data;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorCustomAuth.Web.Auth
{
    public class AppAuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly IUserService _userService;

        public AppAuthStateProvider(ILocalStorageService localStorageService,IUserService userService)
        {
           _localStorageService = localStorageService;
            _userService = userService;
        }
      
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //var _claimsPrincipal = await _localStorageService.GetItemAsync<ClaimsPrincipal>("AuthInfo");
            //_claimsPrincipal = _claimsPrincipal ?? new ClaimsPrincipal();
            string authInfo = await _localStorageService.GetItemAsync<string>("AuthInfo");
            ClaimsIdentity claimsIdentity;
            if (authInfo != null)
            {
                claimsIdentity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name, "mrfibuli"),
                 }, "userName");

            }
            else
            {
                claimsIdentity = new ClaimsIdentity();
            }
            var user = new ClaimsPrincipal(claimsIdentity);
            return await Task.FromResult(new AuthenticationState(user));
        }
        public async Task SetAuthenticationStateAsync(LoginModel model)
        {
            await _localStorageService.SetItemAsync<string>("AuthInfo", "Sahadat@");
            await   Task.CompletedTask;
        }
        public async Task ClearAuthenticationAsync()
        {
            await _localStorageService.RemoveItemAsync("AuthInfo");
            await Task.CompletedTask;
        }
    }
}
