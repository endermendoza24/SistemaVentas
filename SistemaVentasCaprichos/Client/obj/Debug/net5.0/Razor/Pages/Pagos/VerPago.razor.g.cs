#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "476a6bd7703c69a7fd6307239e382010b13ea228"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Pagos
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
#line 7 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ver-pago/{idpago:int}")]
    public partial class VerPago : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex justify-content-between mb-2");
            __builder.AddAttribute(2, "b-ul2til6j4m");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "btn-group");
            __builder.AddAttribute(5, "b-ul2til6j4m");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-sm btn-secondary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
                                                            Volver

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "b-ul2til6j4m");
            __builder.AddMarkupContent(10, "<i class=\"oi oi-arrow-circle-left\" b-ul2til6j4m></i> Volver atrás\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<button class=\"btn btn-sm btn-primary\" onclick=\"window.print()\" b-ul2til6j4m>\r\n            Imprimir\r\n        </button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "btn-group");
            __builder.AddAttribute(16, "b-ul2til6j4m");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
                            () => BorrarPago(pago.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(20, "b-ul2til6j4m");
            __builder.AddMarkupContent(21, "<i class=\"oi oi-trash\" b-ul2til6j4m></i> Eliminar pago\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
 if (pago != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card m-1");
            __builder.AddAttribute(24, "style", "margin:25px; background-color:#f4f4f4; border-style:dotted");
            __builder.AddAttribute(25, "b-ul2til6j4m");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "card-body");
            __builder.AddAttribute(28, "b-ul2til6j4m");
            __builder.AddMarkupContent(29, "<h4 class=\"card-title d-flex justify-content-center\" b-ul2til6j4m><b b-ul2til6j4m>RECIBO DE PAGO</b></h4>\r\n\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "d-flex justify-content-between");
            __builder.AddAttribute(32, "b-ul2til6j4m");
            __builder.AddMarkupContent(33, "<b b-ul2til6j4m>VIVERO BRITH</b>\r\n                ");
            __builder.OpenElement(34, "small");
            __builder.AddAttribute(35, "b-ul2til6j4m");
            __builder.AddMarkupContent(36, "<b b-ul2til6j4m>N° Comprobante:</b> ");
#nullable restore
#line 35 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
__builder.AddContent(37, pago.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "d-flex justify-content-between");
            __builder.AddAttribute(41, "b-ul2til6j4m");
            __builder.AddMarkupContent(42, "<small b-ul2til6j4m>Tienda de vivero y jardineria</small>\r\n                ");
            __builder.OpenElement(43, "small");
            __builder.AddAttribute(44, "b-ul2til6j4m");
            __builder.AddMarkupContent(45, "<b b-ul2til6j4m>Fecha:</b> ");
#nullable restore
#line 40 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
__builder.AddContent(46, pago.Fecha);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "d-flex justify-content-between");
            __builder.AddAttribute(50, "b-ul2til6j4m");
            __builder.AddMarkupContent(51, "<small b-ul2til6j4m>H. Irigoyen esq. Córdoba, Río Segundo</small>\r\n                ");
            __builder.OpenElement(52, "small");
            __builder.AddAttribute(53, "b-ul2til6j4m");
            __builder.AddMarkupContent(54, "<b b-ul2til6j4m>F.de Pago :</b> ");
#nullable restore
#line 44 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
__builder.AddContent(55, pago.FormaPago);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n            ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "d-flex justify-content-between");
            __builder.AddAttribute(59, "b-ul2til6j4m");
            __builder.AddMarkupContent(60, "<small b-ul2til6j4m>3572550166</small>\r\n                ");
            __builder.OpenElement(61, "small");
            __builder.AddAttribute(62, "b-ul2til6j4m");
            __builder.AddMarkupContent(63, "<b b-ul2til6j4m>Empleado:</b> ");
#nullable restore
#line 49 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
__builder.AddContent(64, pago.ApplicationUser.NombreyApellido);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n            <hr b-ul2til6j4m>\r\n            ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "text-left");
            __builder.AddAttribute(68, "b-ul2til6j4m");
            __builder.OpenElement(69, "small");
            __builder.AddAttribute(70, "b-ul2til6j4m");
            __builder.AddMarkupContent(71, "<b b-ul2til6j4m>Cliente:</b> ");
#nullable restore
#line 54 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
__builder.AddContent(72, pago.Cliente.NombreyApellido);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(73, " <br b-ul2til6j4m>\r\n                ");
            __builder.OpenElement(74, "small");
            __builder.AddAttribute(75, "b-ul2til6j4m");
            __builder.AddMarkupContent(76, "<b b-ul2til6j4m>Dirección:</b> ");
#nullable restore
#line 55 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
__builder.AddContent(77, pago.Cliente.Dirección);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(78, " <br b-ul2til6j4m>\r\n                ");
            __builder.OpenElement(79, "small");
            __builder.AddAttribute(80, "b-ul2til6j4m");
            __builder.AddMarkupContent(81, "<b b-ul2til6j4m>Teléfono:</b> ");
#nullable restore
#line 56 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
__builder.AddContent(82, pago.Cliente.Teléfono);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            <hr b-ul2til6j4m>\r\n\r\n            ");
            __builder.OpenElement(84, "table");
            __builder.AddAttribute(85, "class", "table table-sm");
            __builder.AddAttribute(86, "b-ul2til6j4m");
            __builder.AddMarkupContent(87, "<thead b-ul2til6j4m><tr b-ul2til6j4m><th style=\"text-align:justify\" b-ul2til6j4m><small b-ul2til6j4m>Concepto</small></th></tr></thead>\r\n                ");
            __builder.OpenElement(88, "tbody");
            __builder.AddAttribute(89, "b-ul2til6j4m");
            __builder.OpenElement(90, "tr");
            __builder.AddAttribute(91, "b-ul2til6j4m");
            __builder.OpenElement(92, "td");
            __builder.AddAttribute(93, "style", "text-align:justify");
            __builder.AddAttribute(94, "b-ul2til6j4m");
            __builder.OpenElement(95, "small");
            __builder.AddAttribute(96, "b-ul2til6j4m");
#nullable restore
#line 68 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
__builder.AddContent(97, pago.Concepto);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n\r\n            ");
            __builder.OpenElement(99, "p");
            __builder.AddAttribute(100, "class", "card-text text-right");
            __builder.AddAttribute(101, "style", "margin:1.5rem");
            __builder.AddAttribute(102, "b-ul2til6j4m");
            __builder.AddMarkupContent(103, "<h6 b-ul2til6j4m><b b-ul2til6j4m>IMPORTE</b></h6>\r\n                ");
            __builder.OpenElement(104, "h5");
            __builder.AddAttribute(105, "b-ul2til6j4m");
            __builder.OpenElement(106, "b");
            __builder.AddAttribute(107, "b-ul2til6j4m");
            __builder.AddContent(108, "$");
#nullable restore
#line 75 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
__builder.AddContent(109, pago.Importe);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 79 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\VerPago.razor"
       
    public Pago pago { get; set; }

    [Parameter] public int idpago { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var httpResponse = await Http.GetAsync($"api/pagos/{idpago}");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            pago = JsonSerializer.Deserialize<Pago>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            await JS.InvokeVoidAsync("simple", "Error", "Pago no encontrado.", "error");
            NavigationManager.NavigateTo("lista-pagos");
        }
    }

    async Task BorrarPago(int idpago)
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "¿Eliminar pago?",
            $"Cliente {pago.Cliente.NombreyApellido}. Fecha: {pago.Fecha}", "warning");
        if (confirmacion)
        {
            var respuesta = await Http.DeleteAsync($"/api/pagos/{idpago}");

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("lista-pagos");
                await JS.InvokeVoidAsync("simple", "¡Exito!", "Pago eliminado", "success");
            }
            else
            {
                await JS.InvokeVoidAsync("simple", "Error", "No se pudo eliminar pago", "error");
            }
        }
    }

    void Volver()
    {
        NavigationManager.NavigateTo("lista-pagos");
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
