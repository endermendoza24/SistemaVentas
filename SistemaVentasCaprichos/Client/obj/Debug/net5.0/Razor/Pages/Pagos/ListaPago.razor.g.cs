#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a5fe77ec176df790ca1853aa0f348e453e2c816"
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
#nullable restore
#line 6 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lista-pagos")]
    public partial class ListaPago : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex position-sticky justify-content-between mb-1");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "btn-group mr-2");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
                          CrearPago

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "class", "btn btn-success");
            __builder.AddMarkupContent(7, "<i class=\"oi oi-plus\"></i> Nuevo pago");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "input-group");
            __builder.AddAttribute(11, "style", "width:60%");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "type", "date");
            __builder.AddAttribute(15, "placeholder", "Fecha Venta");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
                                                                                 FechaFiltro

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FechaFiltro = __value, FechaFiltro, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "input-group-append");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
                              Filtrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddMarkupContent(25, "<i class=\"oi oi-magnifying-glass\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
                              Limpiar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "btn btn-danger");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddMarkupContent(31, "<i class=\"oi oi-delete\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
 if (pagos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-grow text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 28 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
}
else if (pagos.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron pagos.</text></div>");
#nullable restore
#line 34 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "table");
            __builder.AddAttribute(35, "class", "table table-hover");
            __builder.AddMarkupContent(36, "<thead class=\"thead-dark\"><tr><th></th>\r\n                <th>#</th>\r\n                <th>Fecha</th>\r\n                <th>Cliente</th>\r\n                <th>Empleado</th>\r\n                <th>Importe</th></tr></thead>\r\n        ");
            __builder.OpenElement(37, "tbody");
            __Blazor.SistemaVentasCaprichos.Client.Pages.Pagos.ListaPago.TypeInference.CreateVirtualize_0(__builder, 38, 39, 
#nullable restore
#line 49 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
                                pagos

#line default
#line hidden
#nullable disable
            , 40, (pago) => (__builder2) => {
                __builder2.OpenElement(41, "tr");
                __builder2.SetKey(
#nullable restore
#line 50 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
                          pago.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(42, "td");
                __builder2.OpenElement(43, "a");
                __builder2.AddAttribute(44, "href", "ver-pago/" + (
#nullable restore
#line 51 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
                                           pago.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "class", "btn btn-sm btn-primary");
                __builder2.AddAttribute(46, "data-toggle", "tooltip");
                __builder2.AddAttribute(47, "title", "Ver" + " pago" + " Id:" + " " + (
#nullable restore
#line 51 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
                                                                                                                              pago.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(48, "<i class=\"oi oi-eye\"></i> Ver");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.OpenElement(50, "td");
                __builder2.AddContent(51, 
#nullable restore
#line 52 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
                         pago.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                    ");
                __builder2.OpenElement(53, "td");
                __builder2.AddContent(54, 
#nullable restore
#line 53 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
                         pago.Fecha

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.OpenElement(56, "td");
                __builder2.OpenElement(57, "a");
                __builder2.AddAttribute(58, "href", "editar-cliente/" + (
#nullable restore
#line 54 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
                                                 pago.ClienteId

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(59, "b");
                __builder2.AddContent(60, 
#nullable restore
#line 54 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
                                                                     pago.Cliente.NombreyApellido

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __builder2.OpenElement(62, "td");
                __builder2.AddContent(63, 
#nullable restore
#line 55 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
                         pago.ApplicationUser.NombreyApellido

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                    ");
                __builder2.OpenElement(65, "td");
                __builder2.OpenElement(66, "b");
                __builder2.AddContent(67, "$");
                __builder2.AddContent(68, 
#nullable restore
#line 56 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
                             pago.Importe

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pagos\ListaPago.razor"
       
    public List<Pago> pagos { get; set; }

    private DateTime FechaFiltro = DateTime.Today.AddDays(+1);

    private string ClienteFiltro = String.Empty;
    private string EmpleadoFiltro = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        await CargarPagos();
    }

    async Task CargarPagos()
    {
        string fecha = Convert.ToString(FechaFiltro);

        var httpResponse = await Http.GetAsync($"api/pagos/filtro?fecha={fecha}");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            pagos = JsonSerializer.Deserialize<List<Pago>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    void CrearPago()
    {
        NavigationManager.NavigateTo("crear-pago");
    }

    private async Task Filtrar()
    {
        await CargarPagos();
    }

    private async Task Limpiar()
    {
        FechaFiltro = DateTime.Today.AddDays(+1);
        await CargarPagos();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Pagos.ListaPago
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
