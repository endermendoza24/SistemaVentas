#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "603df30e2dde1d8d6ed594d8e010e17194544cd6"
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
#line 1 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudLayout>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(2);
                __builder2.AddAttribute(3, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                          3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(5);
                    __builder3.AddAttribute(6, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 24 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 24 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 26 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
         if (_isLightMode)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(9);
                    __builder3.AddAttribute(10, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                  Icons.Material.Filled.Brightness4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 28 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                                                            Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                                                                                    ToggleTheme

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
#nullable restore
#line 29 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(13);
                    __builder3.AddAttribute(14, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                  Icons.Material.Filled.Brightness5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 32 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                                                            Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                                                                                    ToggleTheme

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
#nullable restore
#line 33 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(18);
                __builder2.AddAttribute(19, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 35 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                                    1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                           _sidebarOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _sidebarOpen = __value, _sidebarOpen))));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudDrawerHeader>(23);
                    __builder3.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudAvatar>(25);
                        __builder4.AddAttribute(26, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 37 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                              Color.Transparent

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 37 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                                       Size.Large

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "Image", "assets/Logo-CodeMaze.png");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(29, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudText>(30);
                        __builder4.AddAttribute(31, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 38 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                           Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(32, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 38 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                                           Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "Style", "margin-top:10px; margin-left:15px;");
                        __builder4.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(35, "Caprichos");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n        ");
                    __builder3.OpenComponent<SistemaVentasCaprichos.Client.Shared.NavBar>(37);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(39);
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudContainer>(41);
                    __builder3.AddAttribute(42, "Class", "mt-6");
                    __builder3.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(44, 
#nullable restore
#line 45 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(46);
            __builder.AddAttribute(47, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 52 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
                         _currentTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(49);
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(51);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Shared\MainLayout.razor"
       
    private bool _isLightMode = true;
    private bool _sidebarOpen = true;
    private MudTheme _currentTheme = new MudTheme();

    private void ToggleTheme()
    {
        _isLightMode = !_isLightMode;

        if (!_isLightMode)
        {
            _currentTheme = GenerateDarkTheme();
        }
        else
        {
            _currentTheme = new MudTheme();
        }
    }

    private MudTheme GenerateDarkTheme() =>
     new MudTheme
     {
         Palette = new Palette()
         {
             Black = "#27272f",
             Background = "#32333d",
             BackgroundGrey = "#27272f",
             Surface = "#373740",
             TextPrimary = "#ffffffb3",
             TextSecondary = "rgba(255,255,255, 0.50)",
             AppbarBackground = "#27272f",
             AppbarText = "#ffffffb3",
             DrawerBackground = "#27272f",
             DrawerText = "#ffffffb3",
             DrawerIcon = "#ffffffb3"
         }
     };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
