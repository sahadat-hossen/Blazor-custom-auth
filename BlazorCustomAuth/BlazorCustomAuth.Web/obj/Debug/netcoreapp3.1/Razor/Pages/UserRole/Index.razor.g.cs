#pragma checksum "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\UserRole\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cbc280da3e0706a26385a2ded51b8b7512cd3f2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCustomAuth.Web.Pages.UserRole
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
#line 2 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\UserRole\Index.razor"
using BlazorCustomAuth.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\UserRole\Index.razor"
using BlazorCustomAuth.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\UserRole\Index.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userroles")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n        .width-modal-md {\r\n            min-width: 450px;\r\n        }\r\n    </style>\r\n");
            __builder.OpenComponent<BlazorCustomAuth.Web.Shared.Container>(1);
            __builder.AddAttribute(2, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        &nbsp;\r\n        ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-2");
                __builder2.AddMarkupContent(9, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatH6>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(12, "User Roles");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.AddMarkupContent(15, "<div class=\"col-md-9\">\r\n\r\n            </div>\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-md-1");
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatButton>(19);
                __builder2.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\UserRole\Index.razor"
                                       () => ShowForm(null)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Style", "align-content:end");
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatIcon>(23);
                    __builder3.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(25, "control_point");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n      \r\n    ");
            }
            ));
            __builder.AddAttribute(29, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "\r\n\r\n        ");
                __builder2.OpenElement(31, "table");
                __builder2.AddAttribute(32, "class", "table table-bordered table-sm");
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.AddMarkupContent(34, @"<thead>
                <tr>
                    <th>
                        Role Name
                    </th>
                    <th>
                        Status
                    </th>
                    <th>
                        Actions
                    </th>
                </tr>
            </thead>
            ");
                __builder2.OpenElement(35, "tbody");
                __builder2.AddMarkupContent(36, "\r\n");
#nullable restore
#line 45 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\UserRole\Index.razor"
                 if (userRoles.Any())
                {
                    foreach(var role in userRoles)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(37, "                        ");
                __builder2.OpenElement(38, "tr");
                __builder2.AddMarkupContent(39, "\r\n                            ");
                __builder2.OpenElement(40, "td");
                __builder2.AddMarkupContent(41, "\r\n                                ");
                __builder2.AddContent(42, 
#nullable restore
#line 51 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\UserRole\Index.razor"
                                 role.RoleName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(43, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.OpenElement(45, "td");
                __builder2.AddMarkupContent(46, "\r\n                                ");
                __builder2.AddContent(47, 
#nullable restore
#line 54 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\UserRole\Index.razor"
                                 role.Status

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(48, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                            ");
                __builder2.OpenElement(50, "td");
                __builder2.AddMarkupContent(51, "\r\n                                ");
                __builder2.OpenComponent<MatBlazor.MatButton>(52);
                __builder2.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\UserRole\Index.razor"
                                                       () => ShowForm(role.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatIcon>(55);
                    __builder3.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(57, "edit");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n");
#nullable restore
#line 60 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\UserRole\Index.razor"
                    }
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(61, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Pages\UserRole\Index.razor"
       



    List<UserRole> userRoles = new List<UserRole>();
    protected override async Task OnInitializedAsync()
    {
        userRoles = await userRoleService.GetAllAsync();
    }


    public EventCallback EditRole(int id)
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
            Modal.Show<Form>("Edit User Role",modalParameters, modalOptions);
        }
        else
        {
            Modal.Show<Form>("Add User Role", modalOptions);
        }


    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRoleService userRoleService { get; set; }
    }
}
#pragma warning restore 1591
