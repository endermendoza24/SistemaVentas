// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
