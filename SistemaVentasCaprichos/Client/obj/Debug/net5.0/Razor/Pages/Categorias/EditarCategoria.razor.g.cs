#pragma checksum "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Categorias\EditarCategoria.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70a771c95881553d64ce630cb1d5689a8fefbbfb"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Categorias
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
#line 11 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

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
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Categorias\EditarCategoria.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/editar-categoria/{idCategoria:int}")]
    public partial class EditarCategoria : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Categorias\EditarCategoria.razor"
                   Volver

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "btn btn-sm btn-secondary");
            __builder.AddMarkupContent(3, "<i class=\"oi oi-arrow-circle-left\"></i> Volver al listado\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n<hr>\r\n\r\n\r\n");
            __builder.AddMarkupContent(5, "<div class=\"d-flex justify-content-between mb-3\"><h3><b>Editar Categoría</b></h3></div>\r\n");
            __builder.OpenComponent<global::SistemaVentasCaprichos.Client.Pages.Categorias.FormularioCategorias>(6);
            __builder.AddAttribute(7, "TextBotonSubmit", "Guardar cambios");
            __builder.AddAttribute(8, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 39 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Categorias\EditarCategoria.razor"
                                      EditarArtic

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "Categoria", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SistemaVentasCaprichos.Shared.Categoria>(
#nullable restore
#line 39 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Categorias\EditarCategoria.razor"
                                                               Categoria

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Categorias\EditarCategoria.razor"
       
    Categoria Categoria = new Categoria();
    [Parameter] public int idCategoria { get; set; }

    protected async override Task OnParametersSetAsync()
    {
        Categoria = await Http.GetFromJsonAsync<Categoria>($"/api/cate/{idCategoria}");
    }

    void Volver()
    {
        NavigationManager.NavigateTo("/indexcategoria");
    }

    async Task EditarArtic()
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "Editar",
            $"¿Desea editar {Categoria.Nombre}?", "question");
        if (confirmacion)
        {
            var respuesta = await Http.PutAsJsonAsync("/api/cate", Categoria);

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/indexcategoria");
                //await JS.InvokeVoidAsync("simple", "¡Éxito!", "Categoria editada", "success");
                Snackbar.Add("Editado con éxito", Severity.Success, a => a.VisibleStateDuration = 200);
            }
            else
            {
                Snackbar.Add("Ha ocurrido un error", Severity.Error, a =>
        a.VisibleStateDuration = 200);
                //await JS.InvokeVoidAsync("simple", "Error",
                //"No se pudo editar Categoria", "error");
            }
        }
    }

    async Task BorrarArticulo(int idCategoria)
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "Eliminar",
            $"¿Desea eliminar {Categoria.Nombre}?", "warning");
        if (confirmacion)
        {
            var respuesta = await Http.DeleteAsync($"/api/cate/{Categoria.Id}");

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/indexcategoria");
                //await JS.InvokeVoidAsync("simple", "¡Éxito!", "Categoria eliminada", "success");
                Snackbar.Add("Borrado con éxito", Severity.Success, a => a.VisibleStateDuration = 200);
            }
            else
            {

                Snackbar.Add("Ha ocurrido un error", Severity.Error, a =>
        a.VisibleStateDuration = 200);
                //await JS.InvokeVoidAsync("simple", "Error",
                //"No se pudo eliminar Categoria", "error");
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
