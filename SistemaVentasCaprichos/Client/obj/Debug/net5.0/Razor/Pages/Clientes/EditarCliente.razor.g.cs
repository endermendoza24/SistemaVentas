#pragma checksum "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e9a4f8dc30f74d8c63941f3f41f1a5c7607d998"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/editar-cliente/{idcliente:int}")]
    public partial class EditarCliente : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
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
            __builder.AddMarkupContent(7, "<h3><b>Editar cliente</b></h3>\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.OpenComponent<global::MudBlazor.MudTooltip>(9);
            __builder.AddAttribute(10, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(11, "button");
                __builder2.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                                    () => BorrarCliente(cliente.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "class", "btn btn-sm btn-danger");
                __builder2.AddMarkupContent(14, "<i class=\"oi oi-trash\"></i> Eliminar cliente\r\n                ");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(15, "TooltipContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(16);
                __builder2.AddAttribute(17, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 26 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                               Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(19, "ALERTA");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenComponent<global::MudBlazor.MudText>(21);
                __builder2.AddAttribute(22, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 27 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                               Typo.body2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(24, "\r\n                    Esta opción eliminará este elemento de forma\r\n                    permanente\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenComponent<global::MudBlazor.MudIcon>(26);
                __builder2.AddAttribute(27, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 31 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
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
            __builder.OpenComponent<global::SistemaVentasCaprichos.Client.Pages.Clientes.FormCliente>(29);
            __builder.AddAttribute(30, "cliente", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SistemaVentasCaprichos.Shared.Cliente>(
#nullable restore
#line 39 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                      cliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 39 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                                               EditarClient

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(32, "ocultarcedula", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 40 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                            ocultadni

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "TextBotonSubmit", "Guardar cambios");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
       
    public Cliente cliente = new Cliente();
   

    [Parameter] public int idcliente { get; set; }
    public bool ocultadni = true;

    protected async override Task OnParametersSetAsync()
    {
        cliente = await Http.GetFromJsonAsync<Cliente>($"api/clientes/{idcliente}");
        
    }

    async Task BorrarCliente(int idcliente)
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "Eliminar",
            $"¿Desea eliminar cliente {cliente.NombreyApellido}?", "warning");
        if (confirmacion)
        {
            var respuesta = await Http.DeleteAsync($"api/clientes/{idcliente}");

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/lista-clientes");
                Snackbar.Add("Borrado con éxito", Severity.Success, a => a.VisibleStateDuration = 200);
                //await JS.InvokeVoidAsync("simple", "¡Éxito!",
                //"Cliente eliminado", "success");
            }
            else
            {
                //await JS.InvokeVoidAsync("simple", "Error",
                //"No se pudo eliminar cliente", "error");
                Snackbar.Add("Ha ocurrido un error", Severity.Error, a =>
       a.VisibleStateDuration = 200);
            }
        }
    }

    async Task EditarClient()
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "Editar",
            $"¿Desea editar {cliente.NombreyApellido}?", "question");
        if (confirmacion)
        {
            var respuesta = await Http.PutAsJsonAsync("api/clientes", cliente);

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/lista-clientes");
                Snackbar.Add("Editado con éxito", Severity.Success, a => a.VisibleStateDuration = 200);
                //await JS.InvokeVoidAsync("simple", "¡Éxito!",
                //"Cliente editado", "success");
            }
            else
            {

                Snackbar.Add("Ha ocurrido un error", Severity.Error, a =>
        a.VisibleStateDuration = 200);
                //await JS.InvokeVoidAsync("simple", "Error",
                //  $"No se pudo editar cliente", "error");
            }
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
