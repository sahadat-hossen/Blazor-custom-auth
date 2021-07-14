#pragma checksum "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\Auth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "597a5aa5eaa4861baf914f81ff4e6b783a0a5680"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCustomAuth.Web.Pages.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\_Imports.razor"
using BlazorCustomAuth.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\_Imports.razor"
using BlazorCustomAuth.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\Auth\Login.razor"
using BlazorCustomAuth.Web.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\Auth\Login.razor"
using BlazorCustomAuth.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\Auth\Login.razor"
using BlazorCustomAuth.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Auth/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorCustomAuth.Web.Pages.Auth.LogInStyle>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "wrapper fadeInDown");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "formContent");
            __builder.AddMarkupContent(7, "\r\n        \r\n        \r\n        ");
            __builder.AddMarkupContent(8, "<div class=\"fadeIn first\">\r\n            <img src=\"/User.png\" id=\"icon\" alt=\"User Icon\">\r\n\r\n        </div>\r\n\r\n        \r\n        ");
            __builder.OpenElement(9, "form");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "id", "login");
            __builder.AddAttribute(14, "class", "fadeIn second");
            __builder.AddAttribute(15, "placeholder", "User ID");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\Auth\Login.razor"
                                                       loginModel.UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loginModel.UserName = __value, loginModel.UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "password");
            __builder.AddAttribute(21, "id", "password");
            __builder.AddAttribute(22, "class", "fadeIn third");
            __builder.AddAttribute(23, "placeholder", "Password");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\Auth\Login.razor"
                                                              loginModel.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loginModel.Password = __value, loginModel.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\Auth\Login.razor"
                                           LoginFn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "fadeIn fourth");
            __builder.AddAttribute(31, "value", "Log In");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(34, "<div id=\"formFooter\">\r\n         \r\n            <a class=\"underlineHover\" href=\"#\">Forgot Password?</a>\r\n        </div>\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\Auth\Login.razor"
       
    LoginModel loginModel = new LoginModel();
    Boolean login = false;
    protected override void OnInitialized()
    {


    }
    void NavigatetoNextComponent()
    {
        UriHelper.NavigateTo("/",true);
    }
    public async Task LoginFn()
    {
        if (string.IsNullOrEmpty(loginModel.UserName))
        {
            toastService.ShowError("Enter Your User Name!");
        }
        else if (string.IsNullOrEmpty(loginModel.Password))
        {
            toastService.ShowError("Enter Your Password!");
        }
        else
        {
            var user = await userService.GetUserByUserNamePassword(loginModel.UserName, loginModel.Password);
            if (user == null)
            {
                toastService.ShowError("User Name or Password not match!");
            }
            else
            {
                login=   await ((AppAuthStateProvider)auth).SetAuthenticationStateAsync(user);
                if (login)
                {
                    toastService.ShowSuccess("Log in sucessfull!");
                    NavigatetoNextComponent();
                }
                else
                {
                    toastService.ShowSuccess("Log in Failed!");
                }

            }

        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
#pragma warning restore 1591
