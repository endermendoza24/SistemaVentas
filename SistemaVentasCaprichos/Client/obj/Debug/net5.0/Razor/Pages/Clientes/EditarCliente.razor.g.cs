#pragma checksum "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2afd0cc457b3ba844c07ab08c5ff8a018d2fc99"
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
#line 1 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
           [Authorize(Roles = "admin, empleado")]

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
#line 8 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
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
#line 21 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
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
#line 27 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
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
#line 28 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
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
#line 32 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
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
#line 40 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                      cliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 40 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                                               EditarClient

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(32, "ocultarcedula", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 41 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                            ocultadni

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "TextBotonSubmit", "Guardar cambios");
            __builder.CloseComponent();
#nullable restore
#line 43 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
 if (cuenta.Count != 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "<hr>\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "mb-3");
            __builder.AddMarkupContent(37, "<h3 class=\"my-2\">Movimientos</h3>\r\n        ");
            __builder.OpenElement(38, "table");
            __builder.AddAttribute(39, "class", "table table-hover m-1");
            __builder.AddMarkupContent(40, "<thead class=\"thead-dark\"><tr><th>Comprobante</th>\r\n                    <th>Fecha</th>\r\n                    <th>Concepto</th>\r\n                    <th>Importe</th>\r\n                    <th>Saldo Parcial</th></tr></thead>\r\n            ");
            __builder.OpenElement(41, "tbody");
            global::__Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.EditarCliente.TypeInference.CreateVirtualize_0(__builder, 42, 43, 
#nullable restore
#line 59 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                                    cuenta

#line default
#line hidden
#nullable disable
            , 44, (cuenta) => (__builder2) => {
                __builder2.OpenElement(45, "tr");
                __builder2.SetKey(
#nullable restore
#line 60 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                              cuenta.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(46, "td");
#nullable restore
#line 62 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                             if (cuenta.Concepto == CuentaCorriente.Conceptos.Debe)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(47, "a");
                __builder2.AddAttribute(48, "href", "ver-venta/" + (
#nullable restore
#line 64 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                                                    cuenta.ComprobanteId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "class", "btn btn-sm btn-primary");
                __builder2.AddContent(50, "Ver");
                __builder2.CloseElement();
#nullable restore
#line 65 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                             if (cuenta.Concepto == CuentaCorriente.Conceptos.Haber)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(51, "a");
                __builder2.AddAttribute(52, "href", "ver-pago/" + (
#nullable restore
#line 68 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                                                   cuenta.ComprobanteId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "class", "btn btn-sm btn-primary");
                __builder2.AddContent(54, "Ver");
                __builder2.CloseElement();
#nullable restore
#line 69 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                        ");
                __builder2.OpenElement(56, "td");
#nullable restore
#line 71 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
__builder2.AddContent(57, cuenta.Fecha);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.OpenElement(59, "td");
#nullable restore
#line 72 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
__builder2.AddContent(60, cuenta.Concepto);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                        ");
                __builder2.OpenElement(62, "td");
                __builder2.OpenElement(63, "b");
#nullable restore
#line 73 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
__builder2.AddContent(64, cuenta.Importe);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                        ");
                __builder2.OpenElement(66, "td");
#nullable restore
#line 74 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
__builder2.AddContent(67, cuenta.Saldo_Parcial);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 80 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
       
    public Cliente cliente = new Cliente();
    public List<CuentaCorriente> cuenta { get; set; } = new List<CuentaCorriente>();

    [Parameter] public int idcliente { get; set; }
    public bool ocultadni = true;

    protected async override Task OnParametersSetAsync()
    {
        cliente = await Http.GetFromJsonAsync<Cliente>($"api/clientes/{idcliente}");
        cuenta = await Http.GetFromJsonAsync<List<CuentaCorriente>>($"api/cuentascorrientes/porcliente/{idcliente}");
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
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.EditarCliente
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateVirtualize_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.ICollection<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
