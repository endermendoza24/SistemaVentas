#pragma checksum "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\Pages\Proveedores\EditarProveedores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "410289b2d8a4adb841b38ee8029980ecb0c44082"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Proveedores
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\Pages\Proveedores\EditarProveedores.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/editar-proveedores/{idProveedor:int}")]
    public partial class EditarProveedores : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\Pages\Proveedores\EditarProveedores.razor"
                   Volver

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "btn btn-sm btn-secondary");
            __builder.AddMarkupContent(3, "<i class=\"oi oi-arrow-circle-left\"></i> Volver al listado\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "d-flex justify-content-between mb-3");
            __builder.AddMarkupContent(7, "<h3><b>Editar marca</b></h3>\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\Pages\Proveedores\EditarProveedores.razor"
                            () => BorrarArticulo(Proveedores.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "class", "btn btn-sm btn-danger");
            __builder.AddMarkupContent(12, "<i class=\"oi oi-trash\"></i> Eliminar marca\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenComponent<global::SistemaVentasCaprichos.Client.Pages.Proveedores.FormProveedor>(14);
            __builder.AddAttribute(15, "TextBotonSubmit", "Guardar cambios");
            __builder.AddAttribute(16, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 23 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\Pages\Proveedores\EditarProveedores.razor"
                              EditarArtic

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "Proveedores", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SistemaVentasCaprichos.Shared.Proveedores>(
#nullable restore
#line 23 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\Pages\Proveedores\EditarProveedores.razor"
                                                         Proveedores

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\sistemaventascaprichos\Client\Pages\Proveedores\EditarProveedores.razor"
       
    Proveedores Proveedores = new Proveedores();
    [Parameter] public int idProveedor { get; set; }

    protected async override Task OnParametersSetAsync()
    {
        Proveedores = await Http.GetFromJsonAsync<Proveedores>($"/api/proveedores/{idProveedor}");
    }

    void Volver()
    {
        NavigationManager.NavigateTo("/lista-proveedores");
    }

    async Task EditarArtic()
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "Editar",
            $"¿Desea editar {Proveedores.Nombre}?", "question");
        if (confirmacion)
        {
            var respuesta = await Http.PutAsJsonAsync("/api/proveedores", Proveedores);

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/lista-proveedores");
                await JS.InvokeVoidAsync("simple", "¡Éxito!", "Proveedores editada", "success");
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
            $"¿Desea eliminar {Proveedores.Nombre}?", "warning");
        if (confirmacion)
        {
            var respuesta = await Http.DeleteAsync($"/api/proveedores/{Proveedores.Id}");

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/lista-proveedores");
                await JS.InvokeVoidAsync("simple", "¡Éxito!", "Proveedores eliminada", "success");
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
