#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcf174a61003a92984a027cfc115dd00eb50ad23"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Pedidos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lista-pedidos")]
    public partial class ListaPedido : Microsoft.AspNetCore.Components.ComponentBase
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
#line 11 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                          NuevoPedido

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "class", "btn btn-success");
            __builder.AddMarkupContent(7, "<i class=\"oi oi-plus\"></i> Nuevo pedido");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "input-group");
            __builder.AddAttribute(11, "style", "width:60%");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "placeholder", "Nombre cliente");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                                                                                    ClienteFiltro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ClienteFiltro = __value, ClienteFiltro));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "placeholder", "Nombre artículo");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                                                                                     ArticuloFiltro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ArticuloFiltro = __value, ArticuloFiltro));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "input-group-append");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                              Filtrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddMarkupContent(32, "<i class=\"oi oi-magnifying-glass\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                              Limpiar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "class", "btn btn-danger");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddMarkupContent(38, "<i class=\"oi oi-delete\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "d-flex justify-content-start mt-2 mb-2");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "btn-group");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                          MostrarTodos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "style", "background:none; border: none");
            __builder.AddMarkupContent(47, "<b>Ver todos</b>");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                          MostrarPendientes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "style", "background:none; border: none");
            __builder.AddMarkupContent(52, "<b>Sólo pendientes</b>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
 if (pedidos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-grow text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 41 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
}
else if (pedidos.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(54, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron pedidos.</text></div>");
#nullable restore
#line 47 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "table");
            __builder.AddAttribute(56, "class", "table table-hover");
            __builder.AddMarkupContent(57, @"<thead class=""thead-dark""><tr><th></th>
                <th></th>
                <th>#</th>
                <th>Cliente</th>
                <th>Fecha</th>
                <th>Seña</th>
                <th>Detalle</th>
                <th>Finalizado</th></tr></thead>
        ");
            __builder.OpenElement(58, "tbody");
            __Blazor.SistemaVentasCaprichos.Client.Pages.Pedidos.ListaPedido.TypeInference.CreateVirtualize_0(__builder, 59, 60, 
#nullable restore
#line 64 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                                pedidos

#line default
#line hidden
#nullable disable
            , 61, (pedido) => (__builder2) => {
                __builder2.OpenElement(62, "tr");
                __builder2.SetKey(
#nullable restore
#line 65 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                          pedido.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(63, "td");
                __builder2.OpenElement(64, "a");
                __builder2.AddAttribute(65, "href", "/editar-pedido/" + (
#nullable restore
#line 66 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                                                 pedido.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "style", "color:white");
                __builder2.AddAttribute(67, "class", "btn btn-sm btn-warning");
                __builder2.AddMarkupContent(68, "<i class=\"oi oi-pencil\" aria-hidden=\"true\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                    ");
                __builder2.OpenElement(70, "td");
                __builder2.OpenElement(71, "button");
                __builder2.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                                            () => BorrarPedido(pedido.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "class", "btn btn-sm btn-danger");
                __builder2.AddMarkupContent(74, "<i class=\"oi oi-trash\" aria-hidden=\"true\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __builder2.OpenElement(76, "td");
#nullable restore
#line 68 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
__builder2.AddContent(77, pedido.Id);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                    ");
                __builder2.OpenElement(79, "td");
                __builder2.OpenElement(80, "a");
                __builder2.AddAttribute(81, "href", "editar-cliente/" + (
#nullable restore
#line 69 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                                                 pedido.ClienteId

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(82, "b");
#nullable restore
#line 69 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
__builder2.AddContent(83, pedido.Cliente.NombreyApellido);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                    ");
                __builder2.OpenElement(85, "td");
                __builder2.OpenElement(86, "b");
#nullable restore
#line 70 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
__builder2.AddContent(87, pedido.Fecha);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                    ");
                __builder2.OpenElement(89, "td");
                __builder2.AddContent(90, "$");
#nullable restore
#line 71 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
__builder2.AddContent(91, pedido.Seña);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                    ");
                __builder2.OpenElement(93, "td");
                __builder2.OpenElement(94, "button");
                __builder2.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                                          MuestraDetalle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "class", "btn btn-sm btn-outline-success");
                __builder2.AddContent(97, "Mostrar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                        ");
                __builder2.OpenElement(99, "button");
                __builder2.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                                          OcultaDetalle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "class", "btn btn-sm btn-outline-secondary");
                __builder2.AddContent(102, "Ocultar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                        ");
                __builder2.OpenElement(104, "table");
                __builder2.AddAttribute(105, "hidden", 
#nullable restore
#line 75 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                                        oculto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(106, "class", "table table-sm");
                __builder2.AddMarkupContent(107, "<thead class=\"thead-light\"><tr><th>Artículo</th>\r\n                                    <th>Cantidad</th></tr></thead>");
#nullable restore
#line 82 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                             foreach (var detalle in pedido.DetallePedidos)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(108, "tbody");
                __builder2.OpenElement(109, "tr");
                __builder2.OpenElement(110, "td");
#nullable restore
#line 86 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
__builder2.AddContent(111, detalle.Articulo.Nombre);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                                        ");
                __builder2.OpenElement(113, "td");
#nullable restore
#line 87 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
__builder2.AddContent(114, detalle.Cantidad);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 90 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                    ");
                __builder2.OpenElement(116, "td");
                __builder2.OpenElement(117, "input");
                __builder2.AddAttribute(118, "type", "checkbox");
                __builder2.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                                           () => Finalizado(pedido)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(120, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 94 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
                                                      pedido.Finalizado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pedido.Finalizado = __value, pedido.Finalizado));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 101 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\ListaPedido.razor"
       
    public List<Pedido> pedidos { get; set; }

    protected bool oculto = true;

    private string ClienteFiltro = String.Empty;
    private string ArticuloFiltro = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        await CargarPedidos();
    }

    async Task CargarPedidos()
    {
        var httpResponse = await Http.GetAsync($"api/pedidos/filtro?cliente={ClienteFiltro}&articulo={ArticuloFiltro}");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            pedidos = JsonSerializer.Deserialize<List<Pedido>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    async Task Finalizado(Pedido pedido)
    {
        pedido.Finalizado = !pedido.Finalizado;
        await Http.PutAsJsonAsync($"api/pedidos", pedido);
        await CargarPedidos();
    }

    void MuestraDetalle()
    {
        oculto = false;
    }

    void OcultaDetalle()
    {
        oculto = true;
    }

    async Task MostrarTodos()
    {
        await CargarPedidos();
    }

    void MostrarPendientes()
    {
        pedidos = pedidos.Where(x => x.Finalizado == false).ToList();
    }

    async Task BorrarPedido(int idpedido)
    {
        var seleccion = pedidos.FirstOrDefault(x => x.Id == idpedido);
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "¿Eliminar pedido?",
            $"Cliente {seleccion.Cliente.NombreyApellido}. Fecha: {seleccion.Fecha}", "warning");
        if (confirmacion)
        {
            var respuesta = await Http.DeleteAsync($"/api/pedidos/{idpedido}");

            if (respuesta.IsSuccessStatusCode)
            {
                await CargarPedidos();
                await JS.InvokeVoidAsync("simple", "¡Exito!", "Pedido eliminado", "success");
            }
            else
            {
                await JS.InvokeVoidAsync("simple", "Error", "No se pudo eliminar pedido", "error");
            }
        }
    }

    void NuevoPedido()
    {
        NavigationManager.NavigateTo("crear-pedido");
    }

    private async Task Filtrar()
    {
        await CargarPedidos();
    }

    private async Task Limpiar()
    {
        ClienteFiltro = string.Empty;
        ArticuloFiltro = string.Empty;
        await CargarPedidos();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Pedidos.ListaPedido
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
