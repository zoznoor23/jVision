#pragma checksum "C:\Users\natha\source\repos\jVision\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08522527c7dc05f79c370f999613465fd301ba78"
// <auto-generated/>
#pragma warning disable 1591
namespace jVision.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using jVision.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using jVision.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natha\source\repos\jVision\Client\Shared\MainLayout.razor"
using jVision.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\natha\source\repos\jVision\Client\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\natha\source\repos\jVision\Client\Shared\MainLayout.razor"
using jVision.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "page");
                __builder2.AddAttribute(4, "b-06gx0wb925");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "sidebar");
                __builder2.AddAttribute(7, "b-06gx0wb925");
                __builder2.OpenComponent<jVision.Client.Shared.NavMenu>(8);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "main");
                __builder2.AddAttribute(12, "b-06gx0wb925");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "top-row");
                __builder2.AddAttribute(15, "b-06gx0wb925");
                __builder2.OpenElement(16, "button");
                __builder2.AddAttribute(17, "type", "button");
                __builder2.AddAttribute(18, "class", "btn btn-link ml-md-auto");
                __builder2.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\natha\source\repos\jVision\Client\Shared\MainLayout.razor"
                                                                                     LogoutClick

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "b-06gx0wb925");
                __builder2.AddContent(21, 
#nullable restore
#line 15 "C:\Users\natha\source\repos\jVision\Client\Shared\MainLayout.razor"
                                                                                                   context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(22, " Logout");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "content px-4");
                __builder2.AddAttribute(26, "b-06gx0wb925");
                __builder2.AddContent(27, 
#nullable restore
#line 18 "C:\Users\natha\source\repos\jVision\Client\Shared\MainLayout.razor"
                     Body

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(28, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(29, "<h1 b-06gx0wb925>Enabling Turbo Thrusters ...</h1>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\natha\source\repos\jVision\Client\Shared\MainLayout.razor"
           
        [CascadingParameter]
        Task<AuthenticationState> AuthenticationState { get; set; }
        protected override async Task OnParametersSetAsync()
        {
            if (!(await AuthenticationState).User.Identity.IsAuthenticated)
            {
                navigationManager.NavigateTo("/login");
            }
        }
        async Task LogoutClick()
        {
            await authStateProvider.Logout();
            navigationManager.NavigateTo("/login");
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
