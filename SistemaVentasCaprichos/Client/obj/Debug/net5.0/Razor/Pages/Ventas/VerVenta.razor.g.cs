#pragma checksum "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ef4e14ead3f13e614673faf0f82fa88f23dc2c3"
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
#line 7 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
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
            __builder.AddAttribute(7, "class", "btn btn-sm btn-secondary");
            __builder.AddAttribute(8, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                                            Volver

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "b-np7uj7vsnh");
            __builder.AddMarkupContent(10, "<i class=\"oi oi-arrow-circle-left\" b-np7uj7vsnh></i> Volver atrás\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<button class=\"btn btn-sm btn-primary\" onclick=\"window.print()\" b-np7uj7vsnh>\r\n            Imprimir\r\n        </button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    <div class=\"btn-group\" b-np7uj7vsnh></div>");
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
 if (venta != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card m-1");
            __builder.AddAttribute(16, "style", "border-color: #fff; border-style: dotted; box-shadow: 22px 3px 39px 1px rgba(0,0,0,0.51);");
            __builder.AddAttribute(17, "b-np7uj7vsnh");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card-body");
            __builder.AddAttribute(20, "b-np7uj7vsnh");
            __builder.AddMarkupContent(21, "<h4 class=\"card-title d-flex justify-content-center\" b-np7uj7vsnh><b b-np7uj7vsnh>FACTURA</b></h4>\r\n\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "d-flex justify-content-between");
            __builder.AddAttribute(24, "b-np7uj7vsnh");
            __builder.AddMarkupContent(25, "<b b-np7uj7vsnh></b>                ");
            __builder.OpenElement(26, "small");
            __builder.AddAttribute(27, "b-np7uj7vsnh");
            __builder.AddMarkupContent(28, "<b b-np7uj7vsnh>N° factura:</b> ");
#nullable restore
#line 33 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(29, venta.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "d-flex justify-content-between");
            __builder.AddAttribute(33, "b-np7uj7vsnh");
            __builder.OpenElement(34, "small");
            __builder.AddAttribute(35, "b-np7uj7vsnh");
            __builder.OpenElement(36, "b");
            __builder.AddAttribute(37, "b-np7uj7vsnh");
#nullable restore
#line 37 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(38, ListaAjustes.NombreSistema);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "small");
            __builder.AddAttribute(41, "b-np7uj7vsnh");
            __builder.AddMarkupContent(42, "<b b-np7uj7vsnh>Fecha:</b> ");
#nullable restore
#line 38 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(43, venta.Fecha);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "d-flex justify-content-between");
            __builder.AddAttribute(47, "b-np7uj7vsnh");
            __builder.OpenElement(48, "small");
            __builder.AddAttribute(49, "b-np7uj7vsnh");
            __builder.OpenElement(50, "b");
            __builder.AddAttribute(51, "b-np7uj7vsnh");
            __builder.AddContent(52, "Propietario: ");
#nullable restore
#line 41 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(53, ListaAjustes.NombrePropietario);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "small");
            __builder.AddAttribute(56, "b-np7uj7vsnh");
            __builder.AddMarkupContent(57, "<b b-np7uj7vsnh>F.de Pago:</b> ");
#nullable restore
#line 42 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(58, venta.FormaPago);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "d-flex justify-content-between");
            __builder.AddAttribute(62, "b-np7uj7vsnh");
            __builder.OpenElement(63, "small");
            __builder.AddAttribute(64, "b-np7uj7vsnh");
            __builder.AddMarkupContent(65, "<b b-np7uj7vsnh>Dirección:</b> ");
#nullable restore
#line 45 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(66, ListaAjustes.Direccion);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\r\n            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "d-flex justify-content-between");
            __builder.AddAttribute(70, "b-np7uj7vsnh");
            __builder.OpenElement(71, "small");
            __builder.AddAttribute(72, "b-np7uj7vsnh");
            __builder.OpenElement(73, "b");
            __builder.AddAttribute(74, "b-np7uj7vsnh");
            __builder.AddMarkupContent(75, "Teléfono ");
#nullable restore
#line 49 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(76, ListaAjustes.Telefono);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n\r\n            ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "d-flex justify-content-between");
            __builder.AddAttribute(80, "b-np7uj7vsnh");
            __builder.OpenElement(81, "small");
            __builder.AddAttribute(82, "b-np7uj7vsnh");
            __builder.OpenElement(83, "b");
            __builder.AddAttribute(84, "b-np7uj7vsnh");
            __builder.AddContent(85, "RUC ");
#nullable restore
#line 53 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(86, ListaAjustes.RUC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
             if (venta.ClienteId != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(87, "<hr b-np7uj7vsnh>\r\n                ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "text-left");
            __builder.AddAttribute(90, "b-np7uj7vsnh");
#nullable restore
#line 60 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                     if(venta.ClienteId != null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(91, "small");
            __builder.AddAttribute(92, "b-np7uj7vsnh");
            __builder.AddMarkupContent(93, "<b b-np7uj7vsnh>Cliente:</b> ");
#nullable restore
#line 62 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(94, venta.Cliente.Nombre);

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "   ");
#nullable restore
#line 62 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(96, venta.Cliente.Apellido);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(97, " <br b-np7uj7vsnh>");
#nullable restore
#line 63 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(98, "<small b-np7uj7vsnh><b b-np7uj7vsnh>Cliente:</b> cliente genérico</small> <br b-np7uj7vsnh>");
#nullable restore
#line 67 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(99, "small");
            __builder.AddAttribute(100, "b-np7uj7vsnh");
            __builder.AddMarkupContent(101, "<b b-np7uj7vsnh>Dirección:</b> ");
#nullable restore
#line 68 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(102, venta.Cliente.Dirección);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(103, " <br b-np7uj7vsnh>\r\n                    ");
            __builder.OpenElement(104, "small");
            __builder.AddAttribute(105, "b-np7uj7vsnh");
            __builder.AddMarkupContent(106, "<b b-np7uj7vsnh>Teléfono:</b> ");
#nullable restore
#line 69 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(107, venta.Cliente.Teléfono);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 71 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(108, "<hr b-np7uj7vsnh>\r\n\r\n            ");
            __builder.OpenElement(109, "table");
            __builder.AddAttribute(110, "class", "table table-sm");
            __builder.AddAttribute(111, "b-np7uj7vsnh");
            __builder.AddMarkupContent(112, @"<thead b-np7uj7vsnh><tr b-np7uj7vsnh><th b-np7uj7vsnh><small b-np7uj7vsnh>Descripción</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Precio x un.</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Cantidad</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Descuento</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Iva aplicada</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Subtotal</small></th></tr></thead>
                ");
            __builder.OpenElement(113, "tbody");
            __builder.AddAttribute(114, "b-np7uj7vsnh");
#nullable restore
#line 86 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                     foreach (var item in venta.DetalleVentas)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(115, "tr");
            __builder.AddAttribute(116, "b-np7uj7vsnh");
            __builder.OpenElement(117, "td");
            __builder.AddAttribute(118, "b-np7uj7vsnh");
            __builder.OpenElement(119, "small");
            __builder.AddAttribute(120, "b-np7uj7vsnh");
#nullable restore
#line 89 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(121, item.Articulo.Nombre);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                            ");
            __builder.OpenElement(123, "td");
            __builder.AddAttribute(124, "b-np7uj7vsnh");
            __builder.OpenElement(125, "small");
            __builder.AddAttribute(126, "b-np7uj7vsnh");
#nullable restore
#line 90 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(127, item.Precio);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n                            ");
            __builder.OpenElement(129, "td");
            __builder.AddAttribute(130, "b-np7uj7vsnh");
            __builder.OpenElement(131, "small");
            __builder.AddAttribute(132, "b-np7uj7vsnh");
#nullable restore
#line 91 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(133, item.Cantidad);

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
#nullable restore
#line 92 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(139, item.Descuento);

#line default
#line hidden
#nullable disable
            __builder.AddContent(140, "%");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                            ");
            __builder.OpenElement(142, "td");
            __builder.AddAttribute(143, "b-np7uj7vsnh");
            __builder.OpenElement(144, "small");
            __builder.AddAttribute(145, "b-np7uj7vsnh");
#nullable restore
#line 93 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(146, item.Iva);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                            ");
            __builder.OpenElement(148, "td");
            __builder.AddAttribute(149, "b-np7uj7vsnh");
            __builder.OpenElement(150, "small");
            __builder.AddAttribute(151, "b-np7uj7vsnh");
#nullable restore
#line 94 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(152, item.SubTotal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 96 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n\r\n            ");
            __builder.OpenElement(154, "p");
            __builder.AddAttribute(155, "class", "card-text text-right m-4");
            __builder.AddAttribute(156, "b-np7uj7vsnh");
            __builder.AddMarkupContent(157, "<h6 b-np7uj7vsnh><b b-np7uj7vsnh>TOTAL</b></h6>\r\n                ");
            __builder.OpenElement(158, "h5");
            __builder.AddAttribute(159, "b-np7uj7vsnh");
            __builder.OpenElement(160, "b");
            __builder.AddAttribute(161, "b-np7uj7vsnh");
            __builder.AddContent(162, "C$");
#nullable restore
#line 102 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
__builder.AddContent(163, venta.Total);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 106 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
       
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
