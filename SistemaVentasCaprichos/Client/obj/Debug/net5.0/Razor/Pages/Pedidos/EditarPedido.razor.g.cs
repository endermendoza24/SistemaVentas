#pragma checksum "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\EditarPedido.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37bf23870353d9725962a20f68e53af940939db2"
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
#line 1 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\EditarPedido.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editar-pedido/{idpedido:int}")]
    public partial class EditarPedido : Microsoft.AspNetCore.Components.ComponentBase
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
#line 10 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\EditarPedido.razor"
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
            __builder.AddMarkupContent(8, "<div><h3><b>Editar pedido</b></h3></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenComponent<SistemaVentasCaprichos.Client.Pages.Pedidos.FormPedidos>(10);
            __builder.AddAttribute(11, "textSubmit", " Guardar cambios");
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 19 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\EditarPedido.razor"
                                                          EditPedido

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "pedido", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SistemaVentasCaprichos.Shared.Pedido>(
#nullable restore
#line 20 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\EditarPedido.razor"
                               pedido

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "clientes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<SistemaVentasCaprichos.Shared.Cliente>>(
#nullable restore
#line 20 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\EditarPedido.razor"
                                                 clientes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "articulos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<SistemaVentasCaprichos.Shared.Articulo>>(
#nullable restore
#line 20 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\EditarPedido.razor"
                                                                      articulos

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\EditarPedido.razor"
       
    public Pedido pedido = new Pedido();
    public List<Cliente> clientes { get; set; } = new List<Cliente>();
    public List<Articulo> articulos { get; set; } = new List<Articulo>();
    [Parameter] public int idpedido { get; set; } //parametro id pedido

    protected override async Task OnInitializedAsync()
    {
        pedido = await Http.GetFromJsonAsync<Pedido>($"api/pedidos/{idpedido}"); //traigo id del parametro
        clientes = await Http.GetFromJsonAsync<List<Cliente>>("api/clientes"); //muestro todos los clientes
        articulos = await Http.GetFromJsonAsync<List<Articulo>>("api/articulos"); //muestro todos los articulos
    }

    async Task EditPedido()
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "¿Editar pedido?",
            $"Pedido N° {pedido.Id}. Fecha: {pedido.Fecha} Seña: ${pedido.Seña}", "question");
        if (confirmacion)
        {
            var respuesta = await Http.PutAsJsonAsync("api/pedidos", pedido);

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/lista-pedidos");
                await JS.InvokeVoidAsync("simple", "¡Éxito!",
                    "Pedido editado", "success");
            }
            else
            {
                await JS.InvokeVoidAsync("simple", "Error",
                    $"No se pudo editar pedido", "error");
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
