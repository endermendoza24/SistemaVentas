#pragma checksum "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41525a2a100e6e1094b64929abdae867c50cd6e0"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Clientes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lista-clientes")]
    public partial class ListaCliente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex position-sticky justify-content-between");
            __builder.AddAttribute(2, "b-phqimgj4wb");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "btn-group mr-2");
            __builder.AddAttribute(5, "b-phqimgj4wb");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                          CrearCliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "class", "btn btn-success");
            __builder.AddAttribute(9, "b-phqimgj4wb");
            __builder.AddMarkupContent(10, "<i class=\"oi oi-plus\" b-phqimgj4wb></i> Agregar cliente");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "input-group");
            __builder.AddAttribute(14, "style", "width:60%");
            __builder.AddAttribute(15, "b-phqimgj4wb");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "placeholder", "Nombre del cliente");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                                                                        NombreFiltro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NombreFiltro = __value, NombreFiltro));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(22, "b-phqimgj4wb");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "input-group-append");
            __builder.AddAttribute(26, "b-phqimgj4wb");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                              Filtrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "b-phqimgj4wb");
            __builder.AddMarkupContent(32, "<i class=\"oi oi-magnifying-glass\" b-phqimgj4wb></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                              Limpiar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "class", "btn btn-danger");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "b-phqimgj4wb");
            __builder.AddMarkupContent(39, "<i class=\"oi oi-delete\" b-phqimgj4wb></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "d-flex justify-content-between mt-2 mb-2");
            __builder.AddAttribute(43, "b-phqimgj4wb");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "btn-group");
            __builder.AddAttribute(46, "b-phqimgj4wb");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                          MostrarTodos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "style", "background:none; border: none");
            __builder.AddAttribute(50, "b-phqimgj4wb");
            __builder.AddMarkupContent(51, "<b b-phqimgj4wb>Ver todos</b>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "btn-group");
            __builder.AddAttribute(55, "b-phqimgj4wb");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                          CambiarVista

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "style", "background:none; border: none");
            __builder.AddAttribute(59, "b-phqimgj4wb");
            __builder.AddMarkupContent(60, "<b b-phqimgj4wb>Cambiar vista</b>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
            __builder.OpenComponent<MudBlazor.MudTooltip>(62);
            __builder.AddAttribute(63, "Text", "Exportar esta tabla a excel");
            __builder.AddAttribute(64, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 34 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                                      Color.Tertiary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "Placement", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Placement>(
#nullable restore
#line 34 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                                                                 Placement.Bottom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "Arrow", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                                                                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(68);
                __builder2.AddAttribute(69, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 35 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                        Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "StartIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                                    Icons.Custom.FileFormats.FileExcel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                         ExportarExcel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 37 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                      Color.Warning

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(74, "Excel");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 39 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
 if (clientes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\" b-phqimgj4wb><div class=\"spinner-grow text-success\" role=\"status\" b-phqimgj4wb><span class=\"sr-only\" b-phqimgj4wb>Cargando...</span></div></div>");
#nullable restore
#line 46 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
}
else if (clientes.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(76, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\" b-phqimgj4wb><text b-phqimgj4wb>No se encontraron clientes.</text></div>");
#nullable restore
#line 52 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "card-columns");
            __builder.AddAttribute(79, "hidden", 
#nullable restore
#line 55 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                       card

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(80, "b-phqimgj4wb");
#nullable restore
#line 56 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
         foreach (var cliente in clientes)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(81, "a");
            __builder.AddAttribute(82, "href", "/editar-cliente/" + (
#nullable restore
#line 58 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                      cliente.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "style", "color: inherit");
            __builder.AddAttribute(84, "b-phqimgj4wb");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "card");
            __builder.AddAttribute(87, "b-phqimgj4wb");
#nullable restore
#line 60 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                     if (cliente.Sexo == Cliente.Sexos.Masculino)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(88, "<img class=\"card-img-top\" src=\"img/masculino.png\" alt=\"Cliente\" b-phqimgj4wb>");
#nullable restore
#line 63 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                    }
                    else if (cliente.Sexo == Cliente.Sexos.Femenino)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(89, "<img class=\"card-img-top\" src=\"img/femenino.png\" alt=\"Cliente\" b-phqimgj4wb>");
#nullable restore
#line 67 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(90, "<img class=\"card-img-top\" src=\"img/noimage.png\" alt=\"Cliente\" b-phqimgj4wb>");
#nullable restore
#line 71 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "card-body");
            __builder.AddAttribute(93, "b-phqimgj4wb");
            __builder.OpenElement(94, "h5");
            __builder.AddAttribute(95, "class", "card-title");
            __builder.AddAttribute(96, "b-phqimgj4wb");
            __builder.OpenElement(97, "b");
            __builder.AddAttribute(98, "b-phqimgj4wb");
#nullable restore
#line 74 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
__builder.AddContent(99, cliente.NombreyApellido);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                        ");
            __builder.OpenElement(101, "p");
            __builder.AddAttribute(102, "class", "card-text");
            __builder.AddAttribute(103, "b-phqimgj4wb");
            __builder.AddMarkupContent(104, "\r\n                            DNI: ");
#nullable restore
#line 77 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
__builder.AddContent(105, cliente.Cedula);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(106, "\r\n                            <br b-phqimgj4wb> ");
#nullable restore
#line 78 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
__builder.AddContent(107, cliente.Dirección);

#line default
#line hidden
#nullable disable
            __builder.AddContent(108, " - (");
#nullable restore
#line 78 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
__builder.AddContent(109, cliente.Teléfono);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(110, ")\r\n                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 86 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(111, "table");
            __builder.AddAttribute(112, "class", "table table-hover");
            __builder.AddAttribute(113, "hidden", 
#nullable restore
#line 89 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                              lista

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(114, "b-phqimgj4wb");
            __builder.AddMarkupContent(115, @"<thead class=""thead-dark"" b-phqimgj4wb><tr b-phqimgj4wb><th b-phqimgj4wb></th>
                <th b-phqimgj4wb>Nombre y Apellido</th>
                <th b-phqimgj4wb>Dni</th>
                <th b-phqimgj4wb>Sexo</th>
                <th b-phqimgj4wb>Dirección</th>
                <th b-phqimgj4wb>Teléfono</th></tr></thead>
        ");
            __builder.OpenElement(116, "tbody");
            __builder.AddAttribute(117, "b-phqimgj4wb");
            __Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.ListaCliente.TypeInference.CreateVirtualize_0(__builder, 118, 119, 
#nullable restore
#line 102 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                clientes

#line default
#line hidden
#nullable disable
            , 120, (cliente) => (__builder2) => {
                __builder2.OpenElement(121, "tr");
                __builder2.AddAttribute(122, "b-phqimgj4wb");
                __builder2.SetKey(
#nullable restore
#line 103 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                          cliente.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(123, "td");
                __builder2.AddAttribute(124, "b-phqimgj4wb");
                __builder2.OpenElement(125, "a");
                __builder2.AddAttribute(126, "href", "/editar-cliente/" + (
#nullable restore
#line 104 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                                  cliente.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(127, "style", "color:white");
                __builder2.AddAttribute(128, "class", "btn btn-sm btn-primary");
                __builder2.AddAttribute(129, "b-phqimgj4wb");
                __builder2.AddMarkupContent(130, "<i class=\"oi oi-eye\" b-phqimgj4wb></i> Ver");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n                    ");
                __builder2.OpenElement(132, "td");
                __builder2.AddAttribute(133, "b-phqimgj4wb");
                __builder2.OpenElement(134, "b");
                __builder2.AddAttribute(135, "b-phqimgj4wb");
#nullable restore
#line 105 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
__builder2.AddContent(136, cliente.NombreyApellido);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\r\n                    ");
                __builder2.OpenElement(138, "td");
                __builder2.AddAttribute(139, "b-phqimgj4wb");
#nullable restore
#line 106 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
__builder2.AddContent(140, cliente.Cedula);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n                    ");
                __builder2.OpenElement(142, "td");
                __builder2.AddAttribute(143, "b-phqimgj4wb");
#nullable restore
#line 108 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                         if (cliente.Sexo == Cliente.Sexos.Masculino)
                        {
                            

#line default
#line hidden
#nullable disable
                __builder2.AddContent(144, "M");
#nullable restore
#line 110 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                          
                        }
                        else if (cliente.Sexo == Cliente.Sexos.Femenino)
                        {
                            

#line default
#line hidden
#nullable disable
                __builder2.AddContent(145, "F");
#nullable restore
#line 114 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                          
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
                __builder2.AddContent(146, "N/E");
#nullable restore
#line 118 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                            
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n                    ");
                __builder2.OpenElement(148, "td");
                __builder2.AddAttribute(149, "b-phqimgj4wb");
#nullable restore
#line 121 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
__builder2.AddContent(150, cliente.Dirección);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\r\n                    ");
                __builder2.OpenElement(152, "td");
                __builder2.AddAttribute(153, "b-phqimgj4wb");
#nullable restore
#line 122 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
__builder2.AddContent(154, cliente.Teléfono);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 140 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 141 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
       
    public List<Cliente> clientes { get; set; } //muestra todos los clientes

    private string NombreFiltro = String.Empty; //filtros

    protected bool lista = true;
    protected bool card = false;

    public int limitedeuda = 1000;

    protected override async Task OnInitializedAsync()
    {
        await CargarClientes();
    }

    async Task CargarClientes()
    {
        var httpResponse = await Http.GetAsync($"api/clientes/filtro?nombre={NombreFiltro}");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            clientes = JsonSerializer.Deserialize<List<Cliente>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    void CrearCliente()
    {
        NavigationManager.NavigateTo("crear-cliente");
    }

    void CambiarVista()
    {
        lista = !lista;
        card = !card;
    }

    private async Task Filtrar()
    {
        await CargarClientes();
    }

    private async Task Limpiar()
    {
        NombreFiltro = string.Empty;
        await CargarClientes();
    }

    void MostrarDeudores()
    {
        clientes = clientes.Where(x => x.Saldo > limitedeuda).OrderByDescending(x => x.Saldo).ToList();
    }

    async Task MostrarTodos()
    {
        await CargarClientes();
    }
    
    private void ExportarExcel()
    {
        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Clientes");
            worksheet.Cells["A1"].Value = "Caprichos.";
            var tableBody = worksheet.Cells["A3:E3"].LoadFromCollection(
                from f in clientes
                select new { f.Id, f.NombreyApellido, f.Teléfono, f.Cedula,f.Dirección, f.Sexo, f.Estado }, true);
            using (ExcelRange r = worksheet.Cells["A1:G1"])
            {
                r.Merge = true; r.Style.Font.Bold = true;
                r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
                worksheet.DefaultColWidth = 60;
                r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                r.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGreen);
            }
            worksheet.Cells["A2"].Value = $"Informe de clientes en existencia {DateTime.Now.ToLongTimeString()}";
            using (ExcelRange r = worksheet.Cells["A2:G2"])
            {
                r.Merge = true;
                r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
                worksheet.DefaultColWidth = 60;
                r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                r.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightYellow);
            }
    

            var header = worksheet.Cells["A3:G3"];
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

            JS.GuardarComo($"Informe_Clientes_{DateTime.Now.ToShortDateString()}.xlsx", package.GetAsByteArray());
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
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.ListaCliente
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateVirtualize_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.ICollection<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
