#pragma checksum "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9a3d55b9cc5fc5f8fc2340c2b6063de9baf2e44"
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
#line 1 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lista-compras")]
    public partial class ListaCompra : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex position-sticky justify-content-between mb-1");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "btn-group mr-2");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                          CrearCompra

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "class", "btn btn-success");
            __builder.AddMarkupContent(7, "<i class=\"oi oi-plus\"></i> Nueva compra");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "input-group");
            __builder.AddAttribute(11, "style", "width:60%");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "type", "date");
            __builder.AddAttribute(15, "placeholder", "Fecha compra");
            __builder.AddAttribute(16, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                                                                                  FechaFiltro

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(17, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FechaFiltro = __value, FechaFiltro, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "placeholder", "Nombre empleado");
            __builder.AddAttribute(23, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                                                                                     EmpleadoFiltro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EmpleadoFiltro = __value, EmpleadoFiltro));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "input-group-append");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                              Filtrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddMarkupContent(32, "<i class=\"oi oi-magnifying-glass\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                              Limpiar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "class", "btn btn-danger");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddMarkupContent(38, "<i class=\"oi oi-delete\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
 if (compras == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-border text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 29 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
}
else if (compras.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron compras.</text></div>");
#nullable restore
#line 35 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
}
else
{

#line default
#line hidden
#nullable disable
            global::__Blazor.SistemaVentasCaprichos.Client.Pages.Compras.ListaCompra.TypeInference.CreateMudTable_0(__builder, 41, 42, 
#nullable restore
#line 38 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                      compras

#line default
#line hidden
#nullable disable
            , 43, 
#nullable restore
#line 38 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                                       hover

#line default
#line hidden
#nullable disable
            , 44, 
#nullable restore
#line 38 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                                                         bordered

#line default
#line hidden
#nullable disable
            , 45, 
#nullable restore
#line 38 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                                                                             striped

#line default
#line hidden
#nullable disable
            , 46, 
#nullable restore
#line 38 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                                                                                              new Func<Compra,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 47, 
#nullable restore
#line 39 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                              selectedItem1

#line default
#line hidden
#nullable disable
            , 48, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 49, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(50);
                __builder2.AddAttribute(51, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 41 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(53, "Compras");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudSpacer>(55);
                __builder2.CloseComponent();
            }
            , 56, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(57);
                __builder2.AddAttribute(58, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(59, "Fecha");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(61);
                __builder2.AddAttribute(62, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(63, "Proveedor");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(65);
                __builder2.AddAttribute(66, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(67, "Empleado");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(69);
                __builder2.AddAttribute(70, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(71, "Total");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(73);
                __builder2.AddAttribute(74, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(75, "Acciones");
                }
                ));
                __builder2.CloseComponent();
            }
            , 76, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTd>(77);
                __builder2.AddAttribute(78, "DataLabel", "Fecha");
                __builder2.AddAttribute(79, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 53 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
__builder3.AddContent(80, context.Fecha.ToLongDateString());

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(82);
                __builder2.AddAttribute(83, "DataLabel", "Proveedor");
                __builder2.AddAttribute(84, "Style", "text-transform:uppercase");
                __builder2.AddAttribute(85, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 54 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
__builder3.AddContent(86, context.Proveedores.Nombre);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(88);
                __builder2.AddAttribute(89, "DataLabel", "Empleado");
                __builder2.AddAttribute(90, "Style", "text-transform:uppercase");
                __builder2.AddAttribute(91, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 55 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
__builder3.AddContent(92, context.ApplicationUser.NombreyApellido);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(94);
                __builder2.AddAttribute(95, "DataLabel", "Total");
                __builder2.AddAttribute(96, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(97, "C$ ");
#nullable restore
#line 56 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
__builder3.AddContent(98, context.Total);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(100);
                __builder2.AddAttribute(101, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudFab>(102);
                    __builder3.AddAttribute(103, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 58 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                               Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(104, "StartIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 58 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                                                        Icons.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(105, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 58 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                                                                                 Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(106, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
                                () => NavigationManager.NavigateTo($"/ver-compra/{context.Id}")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 107, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTablePager>(108);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 66 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\ender\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Compras\ListaCompra.razor"
       
    public List<Compra> compras { get; set; }
    
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private Compra selectedItem1 = null;
    private HashSet<Compra> selectedItems = new HashSet<Compra>();

    private DateTime FechaFiltro = DateTime.Today.AddDays(+1);
    private string EmpleadoFiltro = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await CargarCompras();
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

    async Task CargarCompras()
    {
        string fecha = Convert.ToString(FechaFiltro);

        var httpResponse = await Http.GetAsync($"api/compras/filtro?empleado={EmpleadoFiltro}&fecha={fecha}");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            compras = JsonSerializer.Deserialize<List<Compra>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    void CrearCompra()
    {
        NavigationManager.NavigateTo("crear-compra");
    }

    private async Task Filtrar()
    {
        await CargarCompras();
    }

    private async Task Limpiar()
    {
        EmpleadoFiltro = string.Empty;
        FechaFiltro = DateTime.Today.AddDays(+1);
        await CargarCompras();
    }
    // esta es la funcion de filtrado de MudBlazor
    private bool FilterFunc1(Compra element) => FilterFunc(element, searchString1);

    private bool FilterFunc(Compra element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.Fecha.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }

    public void ShowBtnPress(int nr)
    {
        Compra compra = compras.First(f => f.Id == nr);
        compra.Estado = !compra.Estado;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Compras.ListaCompra
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Func<T, global::System.Boolean> __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment __arg10)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Bordered", __arg2);
        __builder.AddAttribute(__seq3, "Striped", __arg3);
        __builder.AddAttribute(__seq4, "Filter", __arg4);
        __builder.AddAttribute(__seq5, "SelectedItem", __arg5);
        __builder.AddAttribute(__seq6, "SelectedItemChanged", __arg6);
        __builder.AddAttribute(__seq7, "ToolBarContent", __arg7);
        __builder.AddAttribute(__seq8, "HeaderContent", __arg8);
        __builder.AddAttribute(__seq9, "RowTemplate", __arg9);
        __builder.AddAttribute(__seq10, "PagerContent", __arg10);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
