#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45cc7ec28be1a48428a17bec86fb5ac6b5e2e2fe"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Tallas
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
#line 15 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lista-tallas")]
    public partial class ListaTallas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudButton>(0);
            __builder.AddAttribute(1, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                                Icons.Material.Filled.Create

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                                                                     Color.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                                                                                          Size.Medium

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(6, "a");
                __builder2.AddAttribute(7, "style", "text-decoration:none; color:#fff;");
                __builder2.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                                           CrearArticulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(9, "Agregar tallas");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(11, "<div class=\"d-flex justify-content-between mt-2 mb-2\"><div class=\"btn-group\"><a href=\"/lista-tallas-bajas\" style=\"background:none; border:none\">\r\n            &nbsp;&nbsp;<b>Dados de baja</b></a></div></div>");
#nullable restore
#line 22 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
 if (Tallas == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "d-flex justify-content-center align-items-center");
            __builder.AddAttribute(14, "style", "height:24rem");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "spinner-grow text-success");
            __builder.AddAttribute(17, "role", "status");
            __builder.AddMarkupContent(18, "<span class=\"sr-only\">Cargando...</span>\r\n            ");
            __builder.OpenComponent<MudBlazor.MudProgressCircular>(19);
            __builder.AddAttribute(20, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 27 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                        Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Style", "height:70px;width:70px;");
            __builder.AddAttribute(22, "Indeterminate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
}
else if (Tallas.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron tallas.</text></div>");
#nullable restore
#line 36 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.SistemaVentasCaprichos.Client.Pages.Tallas.ListaTallas.TypeInference.CreateMudTable_0(__builder, 24, 25, 
#nullable restore
#line 39 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                      Tallas

#line default
#line hidden
#nullable disable
            , 26, 
#nullable restore
#line 39 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                      dense

#line default
#line hidden
#nullable disable
            , 27, 
#nullable restore
#line 39 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                                     hover

#line default
#line hidden
#nullable disable
            , 28, 
#nullable restore
#line 39 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                                                       bordered

#line default
#line hidden
#nullable disable
            , 29, 
#nullable restore
#line 39 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                                                                           striped

#line default
#line hidden
#nullable disable
            , 30, 
#nullable restore
#line 39 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                                                                                            new Func<Tallas,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 31, 
#nullable restore
#line 40 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                  selectedItem1

#line default
#line hidden
#nullable disable
            , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 33, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(34);
                __builder2.AddAttribute(35, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 42 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(37, "Tallas");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudSpacer>(39);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Tallas.ListaTallas.TypeInference.CreateMudTextField_1(__builder2, 41, 42, "Buscar marca...", 43, 
#nullable restore
#line 44 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                                                                               Adornment.Start

#line default
#line hidden
#nullable disable
                , 44, 
#nullable restore
#line 44 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                                                                                                                Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 45, 
#nullable restore
#line 44 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                                                                                                                                                        Size.Medium

#line default
#line hidden
#nullable disable
                , 46, "mt-0", 47, 
#nullable restore
#line 44 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                       searchString1

#line default
#line hidden
#nullable disable
                , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
            }
            , 49, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(50);
                __builder2.AddAttribute(51, "Style", "width:50px;");
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(53, "Nr");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(55);
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(57, "Nombre");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(59);
                __builder2.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(61, "Fecha registro");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(63);
                __builder2.AddAttribute(64, "Style", "width:50px;");
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(66, "Acciones");
                }
                ));
                __builder2.CloseComponent();
            }
            , 67, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(68);
                __builder2.AddAttribute(69, "DataLabel", "Id");
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(71, 
#nullable restore
#line 53 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                   context.Id

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(73);
                __builder2.AddAttribute(74, "DataLabel", "Nombre");
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(76, 
#nullable restore
#line 54 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                       context.Nombre

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(78);
                __builder2.AddAttribute(79, "DataLabel", "Fecha");
                __builder2.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(81, 
#nullable restore
#line 55 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                      context.Fecha.ToLongDateString()

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(83);
                __builder2.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudFab>(85);
                    __builder3.AddAttribute(86, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 57 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                               Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(87, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                                        Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 57 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                                                                          Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
                                    () => NavigationManager.NavigateTo($"/editar-tallas/{context.Id}")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 90, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(91);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 65 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Tallas\ListaTallas.razor"
       
    private bool dense = false;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private Tallas selectedItem1 = null;
    private HashSet<Tallas> selectedItems = new HashSet<Tallas>();


    public List<Tallas> Tallas { get; set; } //muestra todos los Categoria
    Tallas objMarca = new Tallas();

    private string NombreArtFiltro = String.Empty; //filtros

    protected bool lista = false;
    protected bool card = true;

    protected override async Task OnInitializedAsync()
    {
        await CargarTallas();
    }

    async Task CargarTallas()
    {
        var httpResponse = await Http.GetAsync($"api/tallas");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            Tallas = JsonSerializer.Deserialize<List<Tallas>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    void CambiarVista() //  esta parte cambia entre vista de tarjetas o vista de grilla
    {
        lista = !lista;
        card = !card;
    }


    async Task MostrarTodos()
    {
        await CargarTallas();
    }

    void CrearArticulo()
    {
        NavigationManager.NavigateTo("creartallas");
    }

    private async Task Filtrar()
    {
        await CargarTallas();
    }

    private async Task Limpiar()
    {
        NombreArtFiltro = string.Empty;
        await CargarTallas();
    }

    // esta es la funcion de filtrado de MudBlazor
    private bool FilterFunc1(Tallas element) => FilterFunc(element, searchString1);

    private bool FilterFunc(Tallas element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.Nombre.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Tallas.ListaTallas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Func<T, global::System.Boolean> __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg10, int __seq11, global::Microsoft.AspNetCore.Components.RenderFragment __arg11)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Hover", __arg2);
        __builder.AddAttribute(__seq3, "Bordered", __arg3);
        __builder.AddAttribute(__seq4, "Striped", __arg4);
        __builder.AddAttribute(__seq5, "Filter", __arg5);
        __builder.AddAttribute(__seq6, "SelectedItem", __arg6);
        __builder.AddAttribute(__seq7, "SelectedItemChanged", __arg7);
        __builder.AddAttribute(__seq8, "ToolBarContent", __arg8);
        __builder.AddAttribute(__seq9, "HeaderContent", __arg9);
        __builder.AddAttribute(__seq10, "RowTemplate", __arg10);
        __builder.AddAttribute(__seq11, "PagerContent", __arg11);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Adornment __arg1, int __seq2, global::System.String __arg2, int __seq3, global::MudBlazor.Size __arg3, int __seq4, global::System.String __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Adornment", __arg1);
        __builder.AddAttribute(__seq2, "AdornmentIcon", __arg2);
        __builder.AddAttribute(__seq3, "IconSize", __arg3);
        __builder.AddAttribute(__seq4, "Class", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
