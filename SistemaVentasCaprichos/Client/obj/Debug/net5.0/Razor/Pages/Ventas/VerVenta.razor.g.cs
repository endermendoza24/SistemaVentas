#pragma checksum "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3028eee85b17f66e1425e206c8e85163d691ab2"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Ventas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
           [Authorize(Roles = "admin, empleado")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/ver-venta/{idventa:int}")]
    public partial class VerVenta : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex justify-content-between mb-2");
            __builder.AddAttribute(2, "b-np7uj7vsnh");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "btn-group");
            __builder.AddAttribute(5, "b-np7uj7vsnh");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "id", "miboton");
            __builder.AddAttribute(8, "class", "btn btn-sm btn-secondary");
            __builder.AddAttribute(9, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                                                         Volver

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "b-np7uj7vsnh");
            __builder.AddMarkupContent(11, "<i class=\"oi oi-arrow-circle-left\" b-np7uj7vsnh></i> Volver atrás\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, "<button id=\"miboton\" class=\"btn btn-sm btn-primary\" onclick=\"window.print()\" b-np7uj7vsnh>\r\n         Imprimir\r\n        </button>\r\n        ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "id", "miboton");
            __builder.AddAttribute(16, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(17, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                                                       NuevaVenta

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "b-np7uj7vsnh");
            __builder.AddMarkupContent(19, "\r\n           Nueva venta\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    <div class=\"btn-group\" b-np7uj7vsnh></div>");
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
 if (venta != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card m-1");
            __builder.AddAttribute(23, "style", "border-color: #fff; border-style: dotted; box-shadow: 22px 3px 39px 1px rgba(0,0,0,0.51);");
            __builder.AddAttribute(24, "b-np7uj7vsnh");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "card-body");
            __builder.AddAttribute(27, "b-np7uj7vsnh");
            __builder.AddMarkupContent(28, "<div class=\"cabecera\" b-np7uj7vsnh><img src=\"https://i.ibb.co/p118xjy/logo1-24-18234.png\" alt=\"logo\" class=\"img-fluid\" b-np7uj7vsnh></div>\r\n\r\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "informacion-fija");
            __builder.AddAttribute(31, "b-np7uj7vsnh");
            __builder.AddMarkupContent(32, "<small class=\"lema\" b-np7uj7vsnh>Caprichos, un estilo para cada ocasion</small> <br b-np7uj7vsnh>\r\n                ");
            __builder.OpenElement(33, "small");
            __builder.AddAttribute(34, "b-np7uj7vsnh");
            __builder.AddMarkupContent(35, "<b b-np7uj7vsnh>Dirección:</b>");
#nullable restore
#line 35 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(36, ListaAjustes.Direccion);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "<br b-np7uj7vsnh>\r\n                ");
            __builder.OpenElement(38, "small");
            __builder.AddAttribute(39, "b-np7uj7vsnh");
            __builder.AddMarkupContent(40, "<b b-np7uj7vsnh>N° factura:</b> ");
#nullable restore
#line 36 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(41, venta.Numero.ToString("D5"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "<br b-np7uj7vsnh>\r\n                ");
            __builder.OpenElement(43, "small");
            __builder.AddAttribute(44, "b-np7uj7vsnh");
            __builder.AddMarkupContent(45, "<b b-np7uj7vsnh>RUC:</b> ");
#nullable restore
#line 37 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(46, ListaAjustes.RUC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, " <br b-np7uj7vsnh>\r\n                ");
            __builder.OpenElement(48, "small");
            __builder.AddAttribute(49, "b-np7uj7vsnh");
            __builder.AddMarkupContent(50, "<b b-np7uj7vsnh>Teléfono:</b> ");
#nullable restore
#line 38 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(51, ListaAjustes.Telefono);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "<br b-np7uj7vsnh>\r\n                ");
            __builder.OpenElement(53, "small");
            __builder.AddAttribute(54, "b-np7uj7vsnh");
            __builder.AddMarkupContent(55, "<b b-np7uj7vsnh>Email:</b> ");
#nullable restore
#line 39 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(56, ListaAjustes.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, " <br b-np7uj7vsnh>\r\n                ");
            __builder.OpenElement(58, "small");
            __builder.AddAttribute(59, "b-np7uj7vsnh");
            __builder.AddMarkupContent(60, "<b b-np7uj7vsnh>Propietario:</b> ");
#nullable restore
#line 40 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(61, ListaAjustes.NombrePropietario);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "<br b-np7uj7vsnh>\r\n                ");
            __builder.OpenElement(63, "small");
            __builder.AddAttribute(64, "b-np7uj7vsnh");
            __builder.AddMarkupContent(65, "<b b-np7uj7vsnh>Fecha:</b> ");
#nullable restore
#line 41 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(66, venta.Fecha);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "<br b-np7uj7vsnh>");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "info-cliente");
            __builder.AddAttribute(71, "b-np7uj7vsnh");
#nullable restore
#line 45 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                 if (venta.ClienteId != null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(72, "<hr b-np7uj7vsnh>\r\n                    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "b-np7uj7vsnh");
#nullable restore
#line 49 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                         if (venta.ClienteId != null)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(75, "small");
            __builder.AddAttribute(76, "b-np7uj7vsnh");
            __builder.AddMarkupContent(77, "<b b-np7uj7vsnh>Cliente:</b> ");
#nullable restore
#line 51 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(78, venta.Cliente.Nombre);

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, " ");
#nullable restore
#line 51 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(80, venta.Cliente.Apellido);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(81, " <br b-np7uj7vsnh>");
#nullable restore
#line 52 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(82, "<small b-np7uj7vsnh><b b-np7uj7vsnh>Cliente:</b> CLIENTE GENÉRICO</small> <br b-np7uj7vsnh>");
#nullable restore
#line 56 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(83, "small");
            __builder.AddAttribute(84, "b-np7uj7vsnh");
            __builder.AddMarkupContent(85, "<b b-np7uj7vsnh>Dirección:</b> ");
#nullable restore
#line 57 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(86, venta.Cliente.Dirección);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(87, " <br b-np7uj7vsnh>\r\n                        ");
            __builder.OpenElement(88, "small");
            __builder.AddAttribute(89, "b-np7uj7vsnh");
            __builder.AddMarkupContent(90, "<b b-np7uj7vsnh>Teléfono:</b> ");
#nullable restore
#line 58 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(91, venta.Cliente.Teléfono);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\r\n\r\n            <hr b-np7uj7vsnh>\r\n\r\n            ");
            __builder.OpenElement(93, "table");
            __builder.AddAttribute(94, "class", "table table-sm");
            __builder.AddAttribute(95, "b-np7uj7vsnh");
            __builder.AddMarkupContent(96, @"<thead b-np7uj7vsnh><tr b-np7uj7vsnh><th b-np7uj7vsnh><small b-np7uj7vsnh>Descripción</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Precio</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Cantidad</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Descuento</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Iva</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Subtotal</small></th></tr></thead>
                ");
            __builder.OpenElement(97, "tbody");
            __builder.AddAttribute(98, "b-np7uj7vsnh");
#nullable restore
#line 78 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                     foreach (var item in venta.DetalleVentas)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(99, "tr");
            __builder.AddAttribute(100, "b-np7uj7vsnh");
            __builder.OpenElement(101, "td");
            __builder.AddAttribute(102, "style", "text-transform:uppercase");
            __builder.AddAttribute(103, "b-np7uj7vsnh");
            __builder.OpenElement(104, "small");
            __builder.AddAttribute(105, "b-np7uj7vsnh");
#nullable restore
#line 81 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(106, item.Articulo.Nombre);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                            ");
            __builder.OpenElement(108, "td");
            __builder.AddAttribute(109, "b-np7uj7vsnh");
            __builder.OpenElement(110, "small");
            __builder.AddAttribute(111, "b-np7uj7vsnh");
            __builder.AddContent(112, "C$ ");
#nullable restore
#line 82 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(113, item.Precio);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                            ");
            __builder.OpenElement(115, "td");
            __builder.AddAttribute(116, "b-np7uj7vsnh");
            __builder.OpenElement(117, "small");
            __builder.AddAttribute(118, "b-np7uj7vsnh");
#nullable restore
#line 83 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(119, item.Cantidad);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                            ");
            __builder.OpenElement(121, "td");
            __builder.AddAttribute(122, "b-np7uj7vsnh");
            __builder.OpenElement(123, "small");
            __builder.AddAttribute(124, "b-np7uj7vsnh");
#nullable restore
#line 84 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(125, item.Descuento);

#line default
#line hidden
#nullable disable
            __builder.AddContent(126, " %");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                            ");
            __builder.OpenElement(128, "td");
            __builder.AddAttribute(129, "b-np7uj7vsnh");
            __builder.OpenElement(130, "small");
            __builder.AddAttribute(131, "b-np7uj7vsnh");
            __builder.AddContent(132, "C$ ");
#nullable restore
#line 85 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(133, item.IvaAlternativo.ToString("#.##"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                            ");
            __builder.OpenElement(135, "td");
            __builder.AddAttribute(136, "b-np7uj7vsnh");
            __builder.OpenElement(137, "small");
            __builder.AddAttribute(138, "b-np7uj7vsnh");
            __builder.AddContent(139, "C$ ");
#nullable restore
#line 86 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(140, item.SubTotal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 88 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n\r\n            ");
            __builder.OpenElement(142, "p");
            __builder.AddAttribute(143, "class", "card-text text-right m-4");
            __builder.AddAttribute(144, "b-np7uj7vsnh");
            __builder.AddMarkupContent(145, "<h6 b-np7uj7vsnh><b b-np7uj7vsnh>TOTAL</b></h6>\r\n                ");
            __builder.OpenElement(146, "h5");
            __builder.AddAttribute(147, "b-np7uj7vsnh");
            __builder.OpenElement(148, "b");
            __builder.AddAttribute(149, "b-np7uj7vsnh");
            __builder.AddContent(150, "C$ ");
#nullable restore
#line 94 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(151, venta.Total);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 98 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
       
    public Venta venta { get; set; }

    [Parameter] public int idventa { get; set; }

    public Configuracion ListaAjustes { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var httpResponse = await Http.GetAsync($"api/ventas/{idventa}");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            venta = JsonSerializer.Deserialize<Venta>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            await JS.InvokeVoidAsync("simple", "Error", "Venta no encontrada.", "error");
            NavigationManager.NavigateTo("lista-ventas");
        }
        await CargarAjustes();

    }



    void Volver()
    {
        NavigationManager.NavigateTo("lista-ventas");
    }
    void NuevaVenta()
    {
        NavigationManager.NavigateTo("crear-venta");
    }

    async Task CargarAjustes()
    {
        var httpResponse = await Http.GetAsync($"api/configuracion/1");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            ListaAjustes = JsonSerializer.Deserialize<Configuracion>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            await JS.InvokeVoidAsync("simple", "Error", "Venta no encontrada.", "error");
            NavigationManager.NavigateTo("lista-ventas");
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
#pragma warning restore 1591
