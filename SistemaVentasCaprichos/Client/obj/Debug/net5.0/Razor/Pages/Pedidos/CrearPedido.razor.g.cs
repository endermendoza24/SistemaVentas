#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\CrearPedido.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc87b730ac72b8f73a654206a6bc3436352acc37"
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
#line 6 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\CrearPedido.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/crear-pedido")]
    public partial class CrearPedido : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex justify-content-between mb-3");
            __builder.OpenElement(2, "div");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\CrearPedido.razor"
                           Volver

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "btn btn-sm btn-secondary");
            __builder.AddMarkupContent(6, "<i class=\"oi oi-arrow-circle-left\"></i> Volver al listado\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<div><h3><b>Nuevo pedido</b></h3></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenComponent<SistemaVentasCaprichos.Client.Pages.Pedidos.FormPedidos>(10);
            __builder.AddAttribute(11, "textSubmit", " Guardar pedido");
            __builder.AddAttribute(12, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 19 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\CrearPedido.razor"
                                                         NuevoPedido

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "pedido", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SistemaVentasCaprichos.Shared.Pedido>(
#nullable restore
#line 20 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\CrearPedido.razor"
                               pedido

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "clientes", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<SistemaVentasCaprichos.Shared.Cliente>>(
#nullable restore
#line 20 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\CrearPedido.razor"
                                                 clientes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "articulos", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<SistemaVentasCaprichos.Shared.Articulo>>(
#nullable restore
#line 20 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\CrearPedido.razor"
                                                                      articulos

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pedidos\CrearPedido.razor"
       
    public Pedido pedido = new Pedido();
    public List<Cliente> clientes { get; set; } = new List<Cliente>();
    public List<Articulo> articulos { get; set; } = new List<Articulo>();

    protected override async Task OnInitializedAsync()
    {
        clientes = await Http.GetFromJsonAsync<List<Cliente>>("api/clientes"); //muestro todos los clientes
        articulos = await Http.GetFromJsonAsync<List<Articulo>>("api/articulos"); //muestro todos los articulos
    }

    async Task NuevoPedido()
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "¿Finalizar pedido?",
            $"Seña: ${pedido.Seña}", "question");
        if (confirmacion)
        {
            var respuesta = await Http.PostAsJsonAsync("api/pedidos", pedido);

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/lista-pedidos");
                await JS.InvokeVoidAsync("simple", "¡Éxito!", "Pedido finalizado", "success");
            }
            else
            {
                await JS.InvokeVoidAsync("simple", "Error", "No se pudo realizar pedido", "error");
            }
        }
    }

    void Volver()
    {
        NavigationManager.NavigateTo("/lista-pedidos");
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
