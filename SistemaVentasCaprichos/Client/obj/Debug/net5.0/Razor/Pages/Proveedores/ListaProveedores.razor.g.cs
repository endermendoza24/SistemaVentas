#pragma checksum "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d60434c7c048343587e5dbca0e4098c599a6fcd3"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Proveedores
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lista-proveedores")]
    public partial class ListaProveedores : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudButton>(0);
            __builder.AddAttribute(1, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 9 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "StartIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 9 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                Icons.Material.Filled.Create

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                     Color.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 9 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                          Size.Medium

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(6, "a");
                __builder2.AddAttribute(7, "style", "text-decoration:none; color:#fff;");
                __builder2.AddAttribute(8, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                            CrearArticulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(9, "Agregar proveedor");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.AddMarkupContent(11, "<div class=\"d-flex justify-content-between mt-2 mb-2\"><div class=\"btn-group\"><a href=\"/lista-proveedores-bajas\" style=\"background:none; border:none\">\r\n            &nbsp;&nbsp;<b>Dados de baja</b></a></div></div>");
#nullable restore
#line 20 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
 if (Proveedores == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-border text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 27 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
}
else if (Proveedores.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron proveedores.</text></div>");
#nullable restore
#line 33 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::MudBlazor.MudButtonGroup>(14);
            __builder.AddAttribute(15, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 37 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                           Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 37 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTooltip>(18);
                __builder2.AddAttribute(19, "Text", "Exportar esta tabla a excel");
                __builder2.AddAttribute(20, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 38 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                              Color.Tertiary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Placement", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Placement>(
#nullable restore
#line 38 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                         Placement.Bottom

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Arrow", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 38 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudButton>(24);
                    __builder3.AddAttribute(25, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 39 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "StartIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 39 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                            Icons.Custom.FileFormats.FileExcel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                             ExportarExcel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 41 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                          Color.Warning

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(30, "Excel");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudTooltip>(32);
                __builder2.AddAttribute(33, "Text", "Exportar esta tabla a CSV");
                __builder2.AddAttribute(34, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 43 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                            Color.Tertiary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Placement", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Placement>(
#nullable restore
#line 43 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                       Placement.Bottom

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "Arrow", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 43 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudButton>(38);
                    __builder3.AddAttribute(39, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 44 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "StartIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 44 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                            Icons.Custom.FileFormats.FileDocument

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                             ExportAsCSV

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 46 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                          Color.Warning

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(44, "CSV");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n    ");
            global::__Blazor.SistemaVentasCaprichos.Client.Pages.Proveedores.ListaProveedores.TypeInference.CreateMudTable_0(__builder, 46, 47, 
#nullable restore
#line 49 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                      Proveedores

#line default
#line hidden
#nullable disable
            , 48, 
#nullable restore
#line 49 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                           dense

#line default
#line hidden
#nullable disable
            , 49, 
#nullable restore
#line 49 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                          hover

#line default
#line hidden
#nullable disable
            , 50, 
#nullable restore
#line 49 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                            bordered

#line default
#line hidden
#nullable disable
            , 51, 
#nullable restore
#line 49 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                striped

#line default
#line hidden
#nullable disable
            , 52, 
#nullable restore
#line 49 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                                 new Func<Proveedores,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 53, 
#nullable restore
#line 50 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                  selectedItem1

#line default
#line hidden
#nullable disable
            , 54, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 55, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(56);
                __builder2.AddAttribute(57, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 52 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(59, "Proveedores");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudSpacer>(61);
                __builder2.CloseComponent();
            }
            , 62, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(63);
                __builder2.AddAttribute(64, "Style", "width:50px;");
                __builder2.AddAttribute(65, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(66, "Nr");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(68);
                __builder2.AddAttribute(69, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(70, "Nombre");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(72);
                __builder2.AddAttribute(73, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(74, "Teléfono");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(76);
                __builder2.AddAttribute(77, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(78, "Dirección");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(80);
                __builder2.AddAttribute(81, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(82, "Fecha registro");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(84);
                __builder2.AddAttribute(85, "Style", "width:70px;");
                __builder2.AddAttribute(86, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(87, "Acciones");
                }
                ));
                __builder2.CloseComponent();
            }
            , 88, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTd>(89);
                __builder2.AddAttribute(90, "DataLabel", "Id");
                __builder2.AddAttribute(91, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 65 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
__builder3.AddContent(92, context.Id);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(94);
                __builder2.AddAttribute(95, "DataLabel", "Nombre");
                __builder2.AddAttribute(96, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 66 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
__builder3.AddContent(97, context.Nombre);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(98, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(99);
                __builder2.AddAttribute(100, "DataLabel", "Teléfono");
                __builder2.AddAttribute(101, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 67 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
__builder3.AddContent(102, context.Telefono);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(104);
                __builder2.AddAttribute(105, "DataLabel", "Dirección");
                __builder2.AddAttribute(106, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 68 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
__builder3.AddContent(107, context.Direccion);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(108, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(109);
                __builder2.AddAttribute(110, "DataLabel", "Fecha");
                __builder2.AddAttribute(111, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 69 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
__builder3.AddContent(112, context.Fecha.ToLongDateString());

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(113, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(114);
                __builder2.AddAttribute(115, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudFab>(116);
                    __builder3.AddAttribute(117, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 71 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                               Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(118, "StartIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 71 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                        Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(119, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 71 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                          Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(120, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                    () => NavigationManager.NavigateTo($"/editar-proveedores/{context.Id}")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 121, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTablePager>(122);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 80 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
       
    private bool dense = false;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private Proveedores selectedItem1 = null;
    private HashSet<Proveedores> selectedItems = new HashSet<Proveedores>();


    public List<Proveedores> Proveedores { get; set; } //muestra todos los Categoria
    Proveedores objMarca = new Proveedores();

    private string NombreArtFiltro = String.Empty; //filtros

    protected bool lista = false;
    protected bool card = true;

    protected override async Task OnInitializedAsync()
    {
        await CargarProveedores();
    }

    async Task CargarProveedores()
    {
        var httpResponse = await Http.GetAsync($"api/proveedores");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            Proveedores = JsonSerializer.Deserialize<List<Proveedores>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    void CambiarVista() //  esta parte cambia entre vista de tarjetas o vista de grilla
    {
        lista = !lista;
        card = !card;
    }


    async Task MostrarTodos()
    {
        await CargarProveedores();
    }

    void CrearArticulo()
    {
        NavigationManager.NavigateTo("crearproveedores");
    }

    private async Task Filtrar()
    {
        await CargarProveedores();
    }

    private async Task Limpiar()
    {
        NombreArtFiltro = string.Empty;
        await CargarProveedores();
    }

    // esta es la funcion de filtrado de MudBlazor
    private bool FilterFunc1(Proveedores element) => FilterFunc(element, searchString1);

    private bool FilterFunc(Proveedores element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.Nombre.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.Telefono.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.Direccion.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    }
    private void ExportAsCSV()
    {
        using (var memoryStream = new MemoryStream())
        {
            using (var writer = new StreamWriter(memoryStream))
            {
                using (var csv = new CsvHelper.CsvWriter(writer))
                {
                    csv.WriteRecords(Proveedores);
                }

                var arr = memoryStream.ToArray();
                JS.GuardarComo($"Exportacion_CSV_Proveedores_{DateTime.Now.ToShortDateString()}.txt", arr);
            }
        }
    }
    
    private void ExportarExcel()
    {
        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Proveedores");
            worksheet.Cells["A1"].Value = "Caprichos.";
            var tableBody = worksheet.Cells["A3:E3"].LoadFromCollection(
                from f in Proveedores
                select new { f.Id, f.Nombre, f.Telefono, f.Fecha, f.Estado }, true);
            using (ExcelRange r = worksheet.Cells["A1:E1"])
            {
                r.Merge = true; r.Style.Font.Bold = true;
                r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
                worksheet.DefaultColWidth = 60;
                r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                r.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGreen);
            }
            worksheet.Cells["A2"].Value = $"Informe de proveedores en existencia {DateTime.Now.ToLongTimeString()}";
            using (ExcelRange r = worksheet.Cells["A2:E2"])
            {
                r.Merge = true;
                r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
                worksheet.DefaultColWidth = 60;
                r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                r.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightYellow);
            }
    

            var header = worksheet.Cells["A3:E3"];
            worksheet.DefaultColWidth = 32;
            tableBody.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

            //  esto afecta al cuerpo

            tableBody.Style.Fill.PatternType = ExcelFillStyle.None;
            // bordes
            tableBody.Style.Border.BorderAround(ExcelBorderStyle.Hair);
            worksheet.Cells.Style.Border.BorderAround(ExcelBorderStyle.Hair);

            // fuentes
            header.Style.Font.Bold = true;
            header.Style.Font.Color.SetColor(System.Drawing.Color.Black);

            // Este es el encabezado.
            header.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            header.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

            JS.GuardarComo($"Informe_Proveedores_{DateTime.Now.ToShortDateString()}.xlsx", package.GetAsByteArray());
        }
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Proveedores.ListaProveedores
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Func<T, global::System.Boolean> __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg10, int __seq11, global::Microsoft.AspNetCore.Components.RenderFragment __arg11)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Hover", __arg2);
        __builder.AddAttribute(__seq3, "Bordered", __arg3);
        __builder.AddAttribute(__seq4, "Striped", __arg4);
        __builder.AddAttribute(__seq5, "Filter", __arg5);
        __builder.AddAttribute(__seq6, "SelectedItem", __arg6);
        __builder.AddAttribute(__seq7, "SelectedItemChanged", __arg7);
        __builder.AddAttribute(__seq8, "ToolBarContent", __arg8);
        __builder.AddAttribute(__seq9, "HeaderContent", __arg9);
        __builder.AddAttribute(__seq10, "RowTemplate", __arg10);
        __builder.AddAttribute(__seq11, "PagerContent", __arg11);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
