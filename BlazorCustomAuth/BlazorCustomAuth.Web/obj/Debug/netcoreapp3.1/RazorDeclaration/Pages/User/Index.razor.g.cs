#pragma checksum "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\User\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efbbc49c4174bc59d9e4e22c5cbcbc785fa9a4a9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCustomAuth.Web.Pages.User
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
#line 2 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\User\Index.razor"
using BlazorCustomAuth.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\User\Index.razor"
using BlazorCustomAuth.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\User\Index.razor"
       
    List<User> users = new List<User>();
    protected override async Task OnInitializedAsync()
    {
        users = await userService.GetAllAsync();
    }


    public EventCallback EditUser(int id)
    {
        return EventCallback.Empty;
    }

    public void ShowForm(int? id)
    {
        ModalOptions modalOptions = new ModalOptions();
        modalOptions.HideCloseButton = true;

        if (id.HasValue)
        {
            ModalParameters modalParameters = new ModalParameters();
            modalParameters.Add("Id", id);
            Modal.Show<Form>("Edit User", modalParameters, modalOptions);
        }
        else
        {
            Modal.Show<Form>("Add User", modalOptions);
        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
    }
}
#pragma warning restore 1591
