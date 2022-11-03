// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SistemaVentasCaprichos.Client.Pages.Tallas
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
#line 6 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\EditarTallas.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editar-tallas/{idTallas:int}")]
    public partial class EditarTallas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\EditarTallas.razor"
       
    Tallas Tallas = new Tallas();
    [Parameter] public int idTallas { get; set; }

    protected async override Task OnParametersSetAsync()
    {
        Tallas = await Http.GetFromJsonAsync<Tallas>($"/api/tallas/{idTallas}");
    }

    void Volver()
    {
        NavigationManager.NavigateTo("/lista-tallas");
    }

    async Task EditarArtic()
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "Editar",
            $"¿Desea editar {Tallas.Nombre}?", "question");
        if (confirmacion)
        {
            var respuesta = await Http.PutAsJsonAsync("/api/tallas", Tallas);

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/lista-tallas");
                //await JS.InvokeVoidAsync("simple", "¡Éxito!", "Marca editada", "success");
                Snackbar.Add("Editada con éxito", Severity.Info, a => a.VisibleStateDuration = 200);
            }
            else
            {
                //await JS.InvokeVoidAsync("simple", "Error",
                //    "No se pudo editar la talla", "error");
                Snackbar.Add("Hubo un error editando este elemento", Severity.Error, a => a.VisibleStateDuration = 300);
            }
        }
    }

    async Task BorrarArticulo(int idCategoria)
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "Eliminar",
            $"¿Desea eliminar {Tallas.Nombre}?", "warning");
        if (confirmacion)
        {
            var respuesta = await Http.DeleteAsync($"/api/tallas/{Tallas.Id}");

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/lista-tallas");
                await JS.InvokeVoidAsync("simple", "¡Éxito!", "Talla eliminada", "success");
            }
            else
            {
                await JS.InvokeVoidAsync("simple", "Error",
                    "No se pudo eliminar la talla", "error");
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
