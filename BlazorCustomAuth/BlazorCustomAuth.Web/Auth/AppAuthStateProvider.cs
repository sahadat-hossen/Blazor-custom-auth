using BlazorCustomAuth.Entities;
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
        private readonly IUserRoleService _userRoleService;

        public AppAuthStateProvider(ILocalStorageService localStorageService, IUserRoleService userRoleService)
        {
            _localStorageService = localStorageService;
            _userRoleService = userRoleService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var user = await _localStorageService.GetItemAsync<User>("userInfo");
            var userRoles = await _localStorageService.GetItemAsync<List<string>>("userRoles");
            ClaimsIdentity claimsIdentity;
            if (user != null)
            {
                claimsIdentity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name, user.FullName),
                //new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.GivenName,user.UserName)
                 }, "userInfo");
                if (userRoles != null)
                {
                    foreach(var role in userRoles)
                    {
                        claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, role));
                    }

                }

                
            }
            else
            {
                claimsIdentity = new ClaimsIdentity();
            }
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            return await Task.FromResult(new AuthenticationState(claimsPrincipal));
        }
        public async Task<Boolean> SetAuthenticationStateAsync(User user)
        {
            try
            {
                await _localStorageService.SetItemAsync<User>("userInfo", user);
                var role = await _userRoleService.GetByIdAsync(user.RoleId);
                if (role != null && role.RoleTasks.Any())
                {
                    await _localStorageService.SetItemAsync<List<string>>("userRoles", role.RoleTasks.Select(s => s.Task).ToList());
                }
               

                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                return await Task.FromResult(false);
            }
        }
        public async Task ClearAuthenticationAsync()
        {
            await _localStorageService.RemoveItemAsync("userInfo");
            await _localStorageService.RemoveItemAsync("userRoles");
            await Task.CompletedTask;
        }
    }
}
