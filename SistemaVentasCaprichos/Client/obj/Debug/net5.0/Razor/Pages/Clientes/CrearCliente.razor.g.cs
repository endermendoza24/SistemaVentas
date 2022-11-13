#pragma checksum "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\CrearCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc8da7011b5d25a14053b7393e3380844cb0af1f"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Clientes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/crear-cliente")]
    public partial class CrearCliente : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex justify-content-between mb-3");
            __builder.OpenElement(2, "div");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\CrearCliente.razor"
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
            __builder.AddMarkupContent(8, "<div><h3><b>Nuevo cliente</b></h3></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenComponent<global::SistemaVentasCaprichos.Client.Pages.Clientes.FormCliente>(10);
            __builder.AddAttribute(11, "cliente", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SistemaVentasCaprichos.Shared.Cliente>(
#nullable restore
#line 20 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\CrearCliente.razor"
                      cliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "TextBotonSubmit", "Guardar cliente");
            __builder.AddAttribute(13, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 21 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\CrearCliente.razor"
                             CrearClient

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\CrearCliente.razor"
       
    public Cliente cliente = new Cliente();

    async Task CrearClient()
    {
        var respuesta = await Http.PostAsJsonAsync("api/clientes", cliente);

        if (respuesta.IsSuccessStatusCode)
        {
            NavigationManager.NavigateTo("/lista-clientes");
            // await JS.InvokeVoidAsync("simple", "¡Éxito!", "Cliente creado", "success");
            Snackbar.Add("Agregada con éxito", Severity.Success, a =>
            a.VisibleStateDuration = 200);
        }
        else
        {
            // await JS.InvokeVoidAsync("simple", "Error",
            //$"DNI: {cliente.Cedula} ya registrado. ", "error");
            Snackbar.Add("Ha ocurrido un error", Severity.Error, a =>
            a.VisibleStateDuration = 200);
        }
    }

    void Volver()
    {
        NavigationManager.NavigateTo("/lista-clientes");
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
