#pragma checksum "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a5b806f1d71855b61a0a6bb52e38698fcca13c0"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudLayout>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudDrawer>(2);
                __builder2.AddAttribute(3, "Elevation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 23 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                                    1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "Open", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 23 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                           _sidebarOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "OpenChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _sidebarOpen = __value, _sidebarOpen))));
                __builder2.AddAttribute(6, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudDrawerHeader>(7);
                    __builder3.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudAvatar>(9);
                        __builder4.AddAttribute(10, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 25 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                              Color.Transparent

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(11, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 25 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                                       Size.Large

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "Image", "assets/Logo-CodeMaze.png");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(13, "\r\n            ");
                        __builder4.OpenComponent<global::MudBlazor.MudText>(14);
                        __builder4.AddAttribute(15, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 26 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                           Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 26 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                           Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "Style", "margin-top:10px; margin-left:15px;");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n        ");
                    __builder3.OpenComponent<global::SistemaVentasCaprichos.Client.Shared.AppBar>(19);
                    __builder3.AddAttribute(20, "OnSidebarToggled", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 28 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                  ToggleSidebar

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(21, "OnThemeToggled", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::MudBlazor.MudTheme>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::MudBlazor.MudTheme>(this, 
#nullable restore
#line 28 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                                                 ToggleTheme

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n        ");
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(23);
                    __builder3.AddAttribute(24, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.OpenComponent<global::SistemaVentasCaprichos.Client.Shared.NavBar>(25);
                        __builder4.AddAttribute(26, "SideBarOpen", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 31 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                     _sidebarOpen

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n    \r\n    ");
                __builder2.OpenComponent<global::MudBlazor.MudMainContent>(28);
                __builder2.AddAttribute(29, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudContainer>(30);
                    __builder3.AddAttribute(31, "Class", "mt-6");
                    __builder3.AddAttribute(32, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 38 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
__builder4.AddContent(33, Body);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<global::MudBlazor.MudThemeProvider>(35);
            __builder.AddAttribute(36, "Theme", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.MudTheme>(
#nullable restore
#line 45 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                         _currentTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.OpenComponent<global::MudBlazor.MudDialogProvider>(38);
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.OpenComponent<global::MudBlazor.MudSnackbarProvider>(40);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
       
    private MudTheme _currentTheme = new MudTheme();
    private bool _sidebarOpen = false;
    private void ToggleTheme(MudTheme changedTheme) => _currentTheme = changedTheme;
    private void ToggleSidebar() => _sidebarOpen = !_sidebarOpen;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
