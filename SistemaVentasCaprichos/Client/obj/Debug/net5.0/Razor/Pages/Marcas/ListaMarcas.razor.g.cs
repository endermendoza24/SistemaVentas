#pragma checksum "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6af42f096a7eb510b064bd330e8e29e1721e4054"
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
#nullable restore
#line 6 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lista-marcas")]
    public partial class ListaMarcas : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudButton>(0);
            __builder.AddAttribute(1, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 8 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "StartIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 8 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                Icons.Material.Filled.Create

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 8 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                     Color.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 8 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                                          Size.Medium

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(6, "a");
                __builder2.AddAttribute(7, "style", "text-decoration:none; color:#fff;");
                __builder2.AddAttribute(8, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                           CrearArticulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(9, "Agregar marca");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.AddMarkupContent(11, "<div class=\"d-flex justify-content-between mt-2 mb-2\"><div class=\"btn-group\"><a href=\"/lista-marcas-bajas\" style=\"background:none; border:none\">\r\n            &nbsp;&nbsp;<b>Dados de baja</b></a></div></div>");
#nullable restore
#line 22 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
 if (Marca == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-grow text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 29 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
}
else if (Marca.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron marcas.</text></div>");
#nullable restore
#line 35 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
}
else
{

#line default
#line hidden
#nullable disable
            global::__Blazor.SistemaVentasCaprichos.Client.Pages.Marcas.ListaMarcas.TypeInference.CreateMudTable_0(__builder, 14, 15, 
#nullable restore
#line 38 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                      Marca

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 38 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                     dense

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 38 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                    hover

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 38 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                      bordered

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 38 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                          striped

#line default
#line hidden
#nullable disable
            , 20, 
#nullable restore
#line 38 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                                           new Func<Marcas,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 21, 
#nullable restore
#line 39 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                  selectedItem1

#line default
#line hidden
#nullable disable
            , 22, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 23, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(24);
                __builder2.AddAttribute(25, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 41 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(27, "Marcas");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudSpacer>(29);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n            ");
                global::__Blazor.SistemaVentasCaprichos.Client.Pages.Marcas.ListaMarcas.TypeInference.CreateMudTextField_1(__builder2, 31, 32, "Buscar marca...", 33, 
#nullable restore
#line 43 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                               Adornment.Start

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 43 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                                                                Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 35, 
#nullable restore
#line 43 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                                                                                                        Size.Medium

#line default
#line hidden
#nullable disable
                , 36, "mt-0", 37, 
#nullable restore
#line 43 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                       searchString1

#line default
#line hidden
#nullable disable
                , 38, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
            }
            , 39, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(40);
                __builder2.AddAttribute(41, "Style", "width:50px;");
                __builder2.AddAttribute(42, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(43, "Nr");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(45);
                __builder2.AddAttribute(46, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(47, "Nombre");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(49);
                __builder2.AddAttribute(50, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(51, "Descripción");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(53);
                __builder2.AddAttribute(54, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(55, "Fecha registro");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(57);
                __builder2.AddAttribute(58, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(59, "Acciones");
                }
                ));
                __builder2.CloseComponent();
            }
            , 60, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTd>(61);
                __builder2.AddAttribute(62, "DataLabel", "Id");
                __builder2.AddAttribute(63, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 53 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
__builder3.AddContent(64, context.Id);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(66);
                __builder2.AddAttribute(67, "DataLabel", "Nombre");
                __builder2.AddAttribute(68, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 54 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
__builder3.AddContent(69, context.Nombre);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(71);
                __builder2.AddAttribute(72, "DataLabel", "Descripción");
                __builder2.AddAttribute(73, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 55 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
__builder3.AddContent(74, context.Descripcion);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(76);
                __builder2.AddAttribute(77, "DataLabel", "Fecha");
                __builder2.AddAttribute(78, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 56 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
__builder3.AddContent(79, context.Fecha);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(81);
                __builder2.AddAttribute(82, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudFab>(83);
                    __builder3.AddAttribute(84, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 58 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                               Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "StartIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 58 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                        Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 58 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                          Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(87, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                    () => NavigationManager.NavigateTo($"/editar-marcas/{context.Id}")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 88, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTablePager>(89);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 67 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\Anderson\Downloads\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
       
    private bool dense = false;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private Marcas selectedItem1 = null;
    private HashSet<Marcas> selectedItems = new HashSet<Marcas>();


    public List<Marcas> Marca { get; set; } //muestra todos los Categoria
    Marcas objMarca = new Marcas();

    private string NombreArtFiltro = String.Empty; //filtros

    protected bool lista = false;
    protected bool card = true;

    protected override async Task OnInitializedAsync()
    {
        await CargarMarcas();
    }

    async Task CargarMarcas()
    {
        var httpResponse = await Http.GetAsync($"api/marcas");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            Marca = JsonSerializer.Deserialize<List<Marcas>>(responseString,
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
        await CargarMarcas();
    }

    void CrearArticulo()
    {
        NavigationManager.NavigateTo("crearmarca");
    }

    private async Task Filtrar()
    {
        await CargarMarcas();
    }

    private async Task Limpiar()
    {
        NombreArtFiltro = string.Empty;
        await CargarMarcas();
    }

    // esta es la funcion de filtrado de MudBlazor
    private bool FilterFunc1(Marcas element) => FilterFunc(element, searchString1);

    private bool FilterFunc(Marcas element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.Nombre.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.Descripcion.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
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
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Marcas.ListaMarcas
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
