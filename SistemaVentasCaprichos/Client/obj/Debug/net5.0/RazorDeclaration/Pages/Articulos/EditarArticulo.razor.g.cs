// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SistemaVentasCaprichos.Client.Pages.Articulos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\EditarArticulo.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/editar-articulo/{idarticulo:int}")]
    public partial class EditarArticulo : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\EditarArticulo.razor"
       
    Articulo articulo = new Articulo();
    [Parameter] public int idarticulo { get; set; }

    protected async override Task OnParametersSetAsync()
    {
        articulo = await Http.GetFromJsonAsync<Articulo>($"/api/articulos/{idarticulo}");
    }

    void Volver()
    {
        NavigationManager.NavigateTo("/lista-articulos");
    }

    async Task EditarArtic()
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "Editar",
            $"¿Desea editar {articulo.Nombre}?", "question");
        if (confirmacion)
        {
            var respuesta = await Http.PutAsJsonAsync("/api/articulos", articulo);

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/lista-articulos");
                //await JS.InvokeVoidAsync("simple", "¡Éxito!", "Artículo editado", "success");
                Snackbar.Add("Editado con éxito", Severity.Success, a => a.VisibleStateDuration = 200);
            }
            else
            {
                // await JS.InvokeVoidAsync("simple", "Error",
                // "No se pudo editar artículo", "error");
                Snackbar.Add("Ha ocurrido un error", Severity.Error, a =>
         a.VisibleStateDuration = 200);
            }
        }
    }

    async Task BorrarArticulo(int idarticulo)
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "Eliminar",
            $"¿Desea eliminar {articulo.Nombre}?", "warning");
        if (confirmacion)
        {
            var respuesta = await Http.DeleteAsync($"/api/articulos/{idarticulo}");

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/lista-articulos");
                //await JS.InvokeVoidAsync("simple", "¡Éxito!", "Artículo eliminado", "success");
                Snackbar.Add("Borrado con éxito", Severity.Success, a => a.VisibleStateDuration = 200);
            }
            else
            {

                Snackbar.Add("Ha ocurrido un error", Severity.Error, a =>
         a.VisibleStateDuration = 200);
                //await JS.InvokeVoidAsync("simple", "Error",
                //"No se pudo eliminar artículo", "error");
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
