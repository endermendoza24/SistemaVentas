#pragma checksum "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\CrearCompra.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab94349b2682c6c285ed6a2ed5c3787903b6d7f4"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Compras
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
#line 6 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\CrearCompra.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/crear-compra")]
    public partial class CrearCompra : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><b>Nueva compra</b></h3>\r\n\r\n");
            __builder.OpenComponent<global::SistemaVentasCaprichos.Client.Pages.Compras.FormCompra>(1);
            __builder.AddAttribute(2, "textSubmit", " Cargar compra");
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\CrearCompra.razor"
                                                       CrearCompr

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "compra", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SistemaVentasCaprichos.Shared.Compra>(
#nullable restore
#line 10 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\CrearCompra.razor"
                                                                           compra

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ocultabtn", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 11 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\CrearCompra.razor"
                     false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "articulos", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.List<SistemaVentasCaprichos.Shared.Articulo>>(
#nullable restore
#line 11 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\CrearCompra.razor"
                                      articulos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "categoria", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.List<SistemaVentasCaprichos.Shared.Categoria>>(
#nullable restore
#line 11 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\CrearCompra.razor"
                                                            categoria

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ListaProveedores", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.List<SistemaVentasCaprichos.Shared.Proveedores>>(
#nullable restore
#line 11 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\CrearCompra.razor"
                                                                                         ListaProveedores

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\CrearCompra.razor"
       
    public Compra compra = new Compra();
    public List<Articulo> articulos { get; set; } = new List<Articulo>();
    public List<Categoria> categoria { get; set; } = new List<Categoria>();
    public List<Proveedores> ListaProveedores { get; set; } = new List<Proveedores>();

    protected override async Task OnInitializedAsync()
    {
        articulos = await Http.GetFromJsonAsync<List<Articulo>>("api/articulos"); //muestro todos los articulos
        categoria = await Http.GetFromJsonAsync<List<Categoria>>("api/cate"); //muestro todos los articulos
        ListaProveedores = await Http.GetFromJsonAsync<List<Proveedores>>("api/proveedores"); //trae los proveedores
    }

    async Task CrearCompr()
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "¿Finalizar compra?",
            $"Total: ${compra.Total}. Proveedor: {compra.ProveedoresId}", "question");
        if (confirmacion)
        {
            var respuesta = await Http.PostAsJsonAsync("api/compras", compra);
            var cuerporespuest = await respuesta.Content.ReadAsStringAsync();

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("lista-compras/");
                //await JS.InvokeVoidAsync("simple", "¡Éxito!", "Compra cargada", "success");
                Snackbar.Add("¡¡¡Compra finalizada con éxito!!!", Severity.Success, a =>
            a.VisibleStateDuration = 200);
            }
            else
            {
                //await JS.InvokeVoidAsync("simple", "Error", "No se pudo cargar compra", "error");
                Snackbar.Add("No se pudo hacer la compra", Severity.Success, a =>
            a.VisibleStateDuration = 200);
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
