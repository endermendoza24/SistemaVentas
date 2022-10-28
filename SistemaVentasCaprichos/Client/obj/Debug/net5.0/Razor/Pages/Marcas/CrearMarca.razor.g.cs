#pragma checksum "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\CrearMarca.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ca2859f0bbce8d93a2e9f783d13aa04fce4874c"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Marcas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/crearmarca")]
    public partial class CrearMarca : Microsoft.AspNetCore.Components.ComponentBase
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
#line 10 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\CrearMarca.razor"
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
            __builder.AddMarkupContent(8, "<div><h3><b>Nueva marca</b></h3></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenComponent<SistemaVentasCaprichos.Client.Pages.Marcas.FormularioMarcas>(10);
            __builder.AddAttribute(11, "TextBotonSubmit", "Guardar");
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 19 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\CrearMarca.razor"
                                                            Crear

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "Marca", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SistemaVentasCaprichos.Shared.Marcas>(
#nullable restore
#line 19 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\CrearMarca.razor"
                                                                           Marca

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\CrearMarca.razor"
       
    Marcas Marca = new Marcas();

    async Task Crear()
    {
        var respuesta = await Http.PostAsJsonAsync("/api/marcas", Marca);

        if (respuesta.IsSuccessStatusCode)
        {
            NavigationManager.NavigateTo("/lista-marcas"); //  cambiar a indexArticulo
            //await JS.InvokeVoidAsync("simple", "¡Éxito!", "Marca creada", "success");
            Snackbar.Add("Agregada con éxito", Severity.Success, a => a.VisibleStateDuration = 200);
        }
        else
        {
            //await JS.InvokeVoidAsync("simple", "Error",
            //        "No se pudo crear este producto", "error");
            Snackbar.Add("Ha ocurrido un error", Severity.Error);
        }
    }

    void Volver()
    {
        NavigationManager.NavigateTo("/lista-marcas"); //  cambiar a index
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
