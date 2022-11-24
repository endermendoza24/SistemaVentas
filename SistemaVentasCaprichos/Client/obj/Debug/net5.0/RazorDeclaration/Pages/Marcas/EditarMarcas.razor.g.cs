// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SistemaVentasCaprichos.Client.Pages.Marcas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\EditarMarcas.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/editar-marcas/{idMarca:int}")]
    public partial class EditarMarcas : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\EditarMarcas.razor"
       
    Marcas Marca = new Marcas();
    [Parameter] public int idMarca { get; set; }

    protected async override Task OnParametersSetAsync()
    {
        Marca = await Http.GetFromJsonAsync<Marcas>($"/api/marcas/{idMarca}");
    }

    void Volver()
    {
        NavigationManager.NavigateTo("/lista-marcas");
    }

    async Task EditarArtic()
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "Editar",
            $"¿Desea editar {Marca.Nombre}?", "question");
        if (confirmacion)
        {
            var respuesta = await Http.PutAsJsonAsync("/api/marcas", Marca);

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/lista-marcas");
                await JS.InvokeVoidAsync("simple", "¡Éxito!", "Marca editada", "success");
            }
            else
            {
                await JS.InvokeVoidAsync("simple", "Error",
                    "No se pudo editar la marca", "error");
            }
        }
    }

    async Task BorrarArticulo(int idCategoria)
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "Eliminar",
            $"¿Desea eliminar {Marca.Nombre}?", "warning");
        if (confirmacion)
        {
            var respuesta = await Http.DeleteAsync($"/api/marcas/{Marca.Id}");

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/lista-marcas");
                await JS.InvokeVoidAsync("simple", "¡Éxito!", "Marca eliminada", "success");
            }
            else
            {
                await JS.InvokeVoidAsync("simple", "Error",
                    "No se pudo eliminar la marca", "error");
            }
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
