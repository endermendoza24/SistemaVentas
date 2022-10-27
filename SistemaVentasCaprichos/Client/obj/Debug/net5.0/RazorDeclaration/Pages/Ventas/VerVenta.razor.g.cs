// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SistemaVentasCaprichos.Client.Pages.Ventas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ver-venta/{idventa:int}")]
    public partial class VerVenta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\Endersson\Pictures\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Ventas\VerVenta.razor"
       
    public Venta venta { get; set; }
    public Configuracion ajustes { get; set; } = new Configuracion();
    public List<Configuracion> ListaAjustes { get; set; } = new List<Configuracion>();

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

        await CargarAjustes();
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

    async Task CargarAjustes()
    {
        var httpResponse = await Http.GetAsync($"api/configuracion/{idventa}");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            ajustes = JsonSerializer.Deserialize<Configuracion>(responseString,
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
