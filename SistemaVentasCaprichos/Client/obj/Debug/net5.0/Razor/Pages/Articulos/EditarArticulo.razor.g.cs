#pragma checksum "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\EditarArticulo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc75ae68362851cdcdaea400d089302d6473dda1"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Articulos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\EditarArticulo.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editar-articulo/{idarticulo:int}")]
    public partial class EditarArticulo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\EditarArticulo.razor"
                   Volver

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "btn btn-sm btn-secondary");
            __builder.AddMarkupContent(3, "<i class=\"oi oi-arrow-circle-left\"></i> Volver al listado\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n<hr>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "d-flex justify-content-between mb-3");
            __builder.AddMarkupContent(7, "<h3><b>Editar artículo</b></h3>\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.OpenComponent<MudBlazor.MudTooltip>(9);
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(11, "button");
                __builder2.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\EditarArticulo.razor"
                                    () => BorrarArticulo(articulo.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "class", "btn btn-sm btn-danger");
                __builder2.AddMarkupContent(14, "<i class=\"oi oi-trash\"></i> Eliminar artículo\r\n                ");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(15, "TooltipContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(16);
                __builder2.AddAttribute(17, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 30 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\EditarArticulo.razor"
                               Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(19, "ALERTA");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenComponent<MudBlazor.MudText>(21);
                __builder2.AddAttribute(22, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 31 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\EditarArticulo.razor"
                               Typo.body2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(24, "\r\n                    Esta opción eliminará este elemento de forma\r\n                    permanente\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenComponent<MudBlazor.MudIcon>(26);
                __builder2.AddAttribute(27, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\EditarArticulo.razor"
                                Icons.Material.Filled.DeleteForever

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n");
            __builder.OpenComponent<SistemaVentasCaprichos.Client.Pages.Articulos.FormArticulo>(29);
            __builder.AddAttribute(30, "TextBotonSubmit", "Guardar cambios");
            __builder.AddAttribute(31, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 44 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\EditarArticulo.razor"
                              EditarArtic

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(32, "articulo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SistemaVentasCaprichos.Shared.Articulo>(
#nullable restore
#line 44 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\EditarArticulo.razor"
                                                      articulo

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\ENDERSSONMENDOZA\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\EditarArticulo.razor"
       
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
