#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Estadisticas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "948c246b8c6d4a4cb8fdf2ed62a5383a51a7307d"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages
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
#line 5 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Estadisticas.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/estadisticas")]
    public partial class Estadisticas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Estadisticas.razor"
 if (ventas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"d-flex justify-content-between\"><div class=\"spinner-grow text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div>\r\n        <h2><b>Estadísticas</b></h2></div>");
#nullable restore
#line 15 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Estadisticas.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"d-flex justify-content-end\"><h2><b>Estadísticas</b></h2></div>");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card mb-2");
            __builder.OpenElement(4, "a");
            __builder.AddAttribute(5, "href", "/lista-pedidos");
            __builder.AddAttribute(6, "style", "color:inherit; text-decoration:none");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "m-2");
#nullable restore
#line 26 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Estadisticas.razor"
                     if (pedidospendientes > 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "d-flex justify-content-between");
            __builder.AddMarkupContent(13, "<h5 class=\"card-title\">Pedidos pendientes</h5>\r\n                            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "style", "height:2rem; width:2rem; border-radius:1rem;\r\n                            background-color:orangered");
            __builder.AddAttribute(16, "class", "d-flex justify-content-center");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "mt-1 mb-1");
            __builder.OpenElement(19, "h5");
            __builder.AddAttribute(20, "style", "color:white");
#nullable restore
#line 33 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Estadisticas.razor"
__builder.AddContent(21, pedidospendientes);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Estadisticas.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<h5 class=\"card-title\">No hay pedidos pendientes</h5>");
#nullable restore
#line 41 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Estadisticas.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Estadisticas.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<div class=\"card mb-2\"><div id=\"ventas\"></div></div>\r\n\r\n");
            __builder.AddMarkupContent(24, "<div class=\"card mb-2\"><div id=\"ej_chart\"></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Estadisticas.razor"
       
    private int pedidospendientes { get; set; }
    private decimal[] ejercicio { get; set; }
    private decimal[] ventasAño { get; set; }
    private decimal[] compras { get; set; }

    public List<Venta> ventas { get; set; }

    protected override async Task OnInitializedAsync()
    {
        ventas = await Http.GetFromJsonAsync<List<Venta>>($"api/ventas");

        ejercicio = await Http.GetFromJsonAsync<decimal[]>($"api/estadisticas/ejercicio");
        compras = await Http.GetFromJsonAsync<decimal[]>($"api/estadisticas/compras");
        ventasAño = await Http.GetFromJsonAsync<decimal[]>($"api/estadisticas/ventas");
        pedidospendientes = await Http.GetFromJsonAsync<int>("api/estadisticas/pendientes");

        MostrarEstadisticas();
    }

    void MostrarEstadisticas()
    {
        JS.InvokeVoidAsync("chart_line", ejercicio, compras);
        JS.InvokeVoidAsync("chart_column", ventasAño);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
