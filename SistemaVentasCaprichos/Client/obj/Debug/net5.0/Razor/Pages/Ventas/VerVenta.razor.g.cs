#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10c6517592143925d785e50e7bb90a35961f000b"
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
#line 6 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ver-venta/{idventa:int}")]
    public partial class VerVenta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex justify-content-between mb-2");
            __builder.AddAttribute(2, "b-np7uj7vsnh");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "btn-group");
            __builder.AddAttribute(5, "b-np7uj7vsnh");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-sm btn-secondary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
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
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "btn-group");
            __builder.AddAttribute(16, "b-np7uj7vsnh");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                            () => BorrarVenta(venta.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(20, "b-np7uj7vsnh");
            __builder.AddMarkupContent(21, "<i class=\"oi oi-trash\" b-np7uj7vsnh></i> Eliminar venta\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
 if (venta != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card m-1");
            __builder.AddAttribute(24, "style", "border-color: #fff; border-style: dotted; box-shadow: 22px 3px 39px 1px rgba(0,0,0,0.51);");
            __builder.AddAttribute(25, "b-np7uj7vsnh");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "card-body");
            __builder.AddAttribute(28, "b-np7uj7vsnh");
            __builder.AddMarkupContent(29, "<h4 class=\"card-title d-flex justify-content-center\" b-np7uj7vsnh><b b-np7uj7vsnh>FACTURA</b></h4>\r\n\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "d-flex justify-content-between");
            __builder.AddAttribute(32, "b-np7uj7vsnh");
            __builder.AddMarkupContent(33, "<b b-np7uj7vsnh>CAPRICHOS </b> \r\n                ");
            __builder.OpenElement(34, "small");
            __builder.AddAttribute(35, "b-np7uj7vsnh");
            __builder.AddMarkupContent(36, "<b b-np7uj7vsnh>N° factura:</b> ");
            __builder.AddContent(37, 
#nullable restore
#line 34 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                           venta.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "d-flex justify-content-between");
            __builder.AddAttribute(41, "b-np7uj7vsnh");
            __builder.AddMarkupContent(42, "<small b-np7uj7vsnh>Tienda de ropa Caprichos</small>\r\n                ");
            __builder.OpenElement(43, "small");
            __builder.AddAttribute(44, "b-np7uj7vsnh");
            __builder.AddMarkupContent(45, "<b b-np7uj7vsnh>Fecha:</b> ");
            __builder.AddContent(46, 
#nullable restore
#line 39 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                      venta.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "d-flex justify-content-between");
            __builder.AddAttribute(50, "b-np7uj7vsnh");
            __builder.AddMarkupContent(51, "<small b-np7uj7vsnh>Contiguo a la empresa médica de Carazo</small>\r\n                ");
            __builder.OpenElement(52, "small");
            __builder.AddAttribute(53, "b-np7uj7vsnh");
            __builder.AddMarkupContent(54, "<b b-np7uj7vsnh>F.de Pago:</b> ");
            __builder.AddContent(55, 
#nullable restore
#line 43 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                          venta.FormaPago

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n            ");
            __builder.AddMarkupContent(57, "<div class=\"d-flex justify-content-between\" b-np7uj7vsnh><small b-np7uj7vsnh>82072291</small></div>");
#nullable restore
#line 50 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
             if (venta.ClienteId != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(58, "<hr b-np7uj7vsnh>\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "text-left");
            __builder.AddAttribute(61, "b-np7uj7vsnh");
            __builder.OpenElement(62, "small");
            __builder.AddAttribute(63, "b-np7uj7vsnh");
            __builder.AddMarkupContent(64, "<b b-np7uj7vsnh>Cliente:</b> ");
            __builder.AddContent(65, 
#nullable restore
#line 54 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                            venta.Cliente.NombreyApellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, " <br b-np7uj7vsnh>\r\n                    ");
            __builder.OpenElement(67, "small");
            __builder.AddAttribute(68, "b-np7uj7vsnh");
            __builder.AddMarkupContent(69, "<b b-np7uj7vsnh>Dirección:</b> ");
            __builder.AddContent(70, 
#nullable restore
#line 55 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                              venta.Cliente.Dirección

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, " <br b-np7uj7vsnh>\r\n                    ");
            __builder.OpenElement(72, "small");
            __builder.AddAttribute(73, "b-np7uj7vsnh");
            __builder.AddMarkupContent(74, "<b b-np7uj7vsnh>Teléfono:</b> ");
            __builder.AddContent(75, 
#nullable restore
#line 56 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                             venta.Cliente.Teléfono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(76, "<hr b-np7uj7vsnh>\r\n\r\n            ");
            __builder.OpenElement(77, "table");
            __builder.AddAttribute(78, "class", "table table-sm");
            __builder.AddAttribute(79, "b-np7uj7vsnh");
            __builder.AddMarkupContent(80, @"<thead b-np7uj7vsnh><tr b-np7uj7vsnh><th b-np7uj7vsnh><small b-np7uj7vsnh>Descripción</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Precio x un.</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Cantidad</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Descuento</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Iva aplicada</small></th>
                        <th b-np7uj7vsnh><small b-np7uj7vsnh>Subtotal</small></th></tr></thead>
                ");
            __builder.OpenElement(81, "tbody");
            __builder.AddAttribute(82, "b-np7uj7vsnh");
#nullable restore
#line 73 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                     foreach (var item in venta.DetalleVentas)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(83, "tr");
            __builder.AddAttribute(84, "b-np7uj7vsnh");
            __builder.OpenElement(85, "td");
            __builder.AddAttribute(86, "b-np7uj7vsnh");
            __builder.OpenElement(87, "small");
            __builder.AddAttribute(88, "b-np7uj7vsnh");
            __builder.AddContent(89, 
#nullable restore
#line 76 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                        item.Articulo.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                            ");
            __builder.OpenElement(91, "td");
            __builder.AddAttribute(92, "b-np7uj7vsnh");
            __builder.OpenElement(93, "small");
            __builder.AddAttribute(94, "b-np7uj7vsnh");
            __builder.AddContent(95, 
#nullable restore
#line 77 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                        item.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                            ");
            __builder.OpenElement(97, "td");
            __builder.AddAttribute(98, "b-np7uj7vsnh");
            __builder.OpenElement(99, "small");
            __builder.AddAttribute(100, "b-np7uj7vsnh");
            __builder.AddContent(101, 
#nullable restore
#line 78 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                        item.Cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                            ");
            __builder.OpenElement(103, "td");
            __builder.AddAttribute(104, "b-np7uj7vsnh");
            __builder.OpenElement(105, "small");
            __builder.AddAttribute(106, "b-np7uj7vsnh");
            __builder.AddContent(107, 
#nullable restore
#line 79 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                        item.Descuento

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(108, "%");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                            ");
            __builder.OpenElement(110, "td");
            __builder.AddAttribute(111, "b-np7uj7vsnh");
            __builder.OpenElement(112, "small");
            __builder.AddAttribute(113, "b-np7uj7vsnh");
            __builder.AddContent(114, 
#nullable restore
#line 80 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                        item.Iva

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                            ");
            __builder.OpenElement(116, "td");
            __builder.AddAttribute(117, "b-np7uj7vsnh");
            __builder.OpenElement(118, "small");
            __builder.AddAttribute(119, "b-np7uj7vsnh");
            __builder.AddContent(120, 
#nullable restore
#line 81 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                                        item.SubTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 83 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n\r\n            ");
            __builder.OpenElement(122, "p");
            __builder.AddAttribute(123, "class", "card-text text-right m-4");
            __builder.AddAttribute(124, "b-np7uj7vsnh");
            __builder.AddMarkupContent(125, "<h6 b-np7uj7vsnh><b b-np7uj7vsnh>TOTAL</b></h6>\r\n                ");
            __builder.OpenElement(126, "h5");
            __builder.AddAttribute(127, "b-np7uj7vsnh");
            __builder.OpenElement(128, "b");
            __builder.AddAttribute(129, "b-np7uj7vsnh");
            __builder.AddContent(130, "C$");
            __builder.AddContent(131, 
#nullable restore
#line 89 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
                          venta.Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 93 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
       
    public Venta venta { get; set; }

    [Parameter] public int idventa { get; set; }

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


    }

    async Task BorrarVenta(int idventa)
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "¿Eliminar venta?",
            $"Venta N° {venta.Id}. Fecha: {venta.Fecha}. Total: {venta.Total}", "warning");
        if (confirmacion)
        {
            var respuesta = await Http.DeleteAsync($"/api/ventas/{idventa}");

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("lista-ventas");
                await JS.InvokeVoidAsync("simple", "¡Exito!", "Venta eliminada", "success");
            }
            else
            {
                await JS.InvokeVoidAsync("simple", "Error", "No se pudo eliminar venta", "error");
            }
        }
    }

    void Volver()
    {
        NavigationManager.NavigateTo("lista-ventas");
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
