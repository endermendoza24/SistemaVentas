#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e1e7a4076e51eb97f1865691a9428bfacc85e64"
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
#line 1 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editar-cliente/{idcliente:int}")]
    public partial class EditarCliente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
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
            __builder.AddMarkupContent(7, "<h3><b>Editar cliente</b></h3>\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                            () => BorrarCliente(cliente.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "class", "btn btn-sm btn-danger");
            __builder.AddMarkupContent(12, "<i class=\"oi oi-trash\"></i> Eliminar cliente\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenComponent<SistemaVentasCaprichos.Client.Pages.Clientes.FormCliente>(14);
            __builder.AddAttribute(15, "cliente", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SistemaVentasCaprichos.Shared.Cliente>(
#nullable restore
#line 23 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                      cliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 23 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                                               EditarClient

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "ocultadni", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                        ocultadni

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "TextBotonSubmit", "Guardar cambios");
            __builder.CloseComponent();
#nullable restore
#line 26 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
 if (cuenta.Count != 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "<hr>\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "mb-3");
            __builder.AddMarkupContent(22, "<h3 class=\"my-2\">Movimientos</h3>\r\n        ");
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table table-hover m-1");
            __builder.AddMarkupContent(25, "<thead class=\"thead-dark\"><tr><th>Comprobante</th>\r\n                    <th>Fecha</th>\r\n                    <th>Concepto</th>\r\n                    <th>Importe</th>\r\n                    <th>Saldo Parcial</th></tr></thead>\r\n            ");
            __builder.OpenElement(26, "tbody");
            __Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.EditarCliente.TypeInference.CreateVirtualize_0(__builder, 27, 28, 
#nullable restore
#line 42 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                                    cuenta

#line default
#line hidden
#nullable disable
            , 29, (cuenta) => (__builder2) => {
                __builder2.OpenElement(30, "tr");
                __builder2.SetKey(
#nullable restore
#line 43 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                              cuenta.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(31, "td");
#nullable restore
#line 45 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                             if (cuenta.Concepto == CuentaCorriente.Conceptos.Debe)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(32, "a");
                __builder2.AddAttribute(33, "href", "ver-venta/" + (
#nullable restore
#line 47 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                                                    cuenta.ComprobanteId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "class", "btn btn-sm btn-primary");
                __builder2.AddContent(35, "Ver");
                __builder2.CloseElement();
#nullable restore
#line 48 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                             if (cuenta.Concepto == CuentaCorriente.Conceptos.Haber)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(36, "a");
                __builder2.AddAttribute(37, "href", "ver-pago/" + (
#nullable restore
#line 51 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                                                   cuenta.ComprobanteId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "class", "btn btn-sm btn-primary");
                __builder2.AddContent(39, "Ver");
                __builder2.CloseElement();
#nullable restore
#line 52 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.OpenElement(41, "td");
                __builder2.AddContent(42, 
#nullable restore
#line 54 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                             cuenta.Fecha

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                        ");
                __builder2.OpenElement(44, "td");
                __builder2.AddContent(45, 
#nullable restore
#line 55 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                             cuenta.Concepto

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.OpenElement(47, "td");
                __builder2.OpenElement(48, "b");
                __builder2.AddContent(49, 
#nullable restore
#line 56 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                                cuenta.Importe

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __builder2.OpenElement(51, "td");
                __builder2.AddContent(52, 
#nullable restore
#line 57 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
                             cuenta.Saldo_Parcial

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\EditarCliente.razor"
       
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
                await JS.InvokeVoidAsync("simple", "¡Éxito!",
                "Cliente eliminado", "success");
            }
            else
            {
                await JS.InvokeVoidAsync("simple", "Error",
                    "No se pudo eliminar cliente", "error");
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
                await JS.InvokeVoidAsync("simple", "¡Éxito!",
                "Cliente editado", "success");
            }
            else
            {
                await JS.InvokeVoidAsync("simple", "Error",
                    $"No se pudo editar cliente", "error");
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
