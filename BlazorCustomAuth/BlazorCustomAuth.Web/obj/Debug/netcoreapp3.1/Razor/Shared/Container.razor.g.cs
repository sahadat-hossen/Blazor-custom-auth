#pragma checksum "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Shared\Container.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1d3455b64600e8b04f1ab6d42f52d2e59a3044e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCustomAuth.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 1 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Shared\Container.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class Container : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "display: flex; flex-direction: column; padding: 10px;");
            __builder.AddAttribute(2, "class", "mat-elevation-z5 mdc-theme--surface");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddContent(4, 
#nullable restore
#line 5 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Shared\Container.razor"
     Header

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "padding: 5px; border: 1px solid white;");
            __builder.AddAttribute(8, "class", 
#nullable restore
#line 6 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Shared\Container.razor"
                                                                Class

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddContent(10, 
#nullable restore
#line 7 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Shared\Container.razor"
         Content

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\Projects\Blazor-custom-auth\BlazorCustomAuth\BlazorCustomAuth.Web\Shared\Container.razor"
 

    [Parameter]
    public string Class { get; set; }

    [Parameter]
    public RenderFragment Header { get; set; }
    [Parameter]
    public RenderFragment Content { get; set; }
    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
        if (firstRender)
        {
            JsRuntime.InvokeAsync<object>("matBlazorDemo.initAd");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591