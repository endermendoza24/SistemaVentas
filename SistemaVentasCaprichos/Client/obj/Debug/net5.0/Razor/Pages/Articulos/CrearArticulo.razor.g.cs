#pragma checksum "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\CrearArticulo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c933ef8f37efe0c14f6c8e239f904ecd7cc2efa"
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
#line 7 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\CrearArticulo.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/crear-articulo")]
    public partial class CrearArticulo : Microsoft.AspNetCore.Components.ComponentBase
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
#line 11 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\CrearArticulo.razor"
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
            __builder.AddMarkupContent(8, "<div><h3><b>Nuevo artículo</b></h3></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenComponent<SistemaVentasCaprichos.Client.Pages.Articulos.FormArticulo>(10);
            __builder.AddAttribute(11, "TextBotonSubmit", "Guardar artículo");
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 20 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\CrearArticulo.razor"
                                                                 CrearArtic

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "articulo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SistemaVentasCaprichos.Shared.Articulo>(
#nullable restore
#line 20 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\CrearArticulo.razor"
                                                                                        articulo

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Articulos\CrearArticulo.razor"
       
    Articulo articulo = new Articulo();
    

    async Task CrearArtic()
    {
        var respuesta = await Http.PostAsJsonAsync("/api/articulos", articulo);

        if (respuesta.IsSuccessStatusCode)
        {
            NavigationManager.NavigateTo("/lista-articulos");
            //await JS.InvokeVoidAsync("simple", "¡Éxito!", "Artículo creado", "success");
            Snackbar.Add("Agregada con éxito", Severity.Success, a => a.VisibleStateDuration = 200);
        }
        else
        {
            //await JS.InvokeVoidAsync("simple", "Error",
            //        "No se pudo crear artículo", "error");
        }
    }

    void Volver()
    {
        NavigationManager.NavigateTo("/lista-articulos");
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
