#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a641b2f823cd84de94228e2f8321354022a8853c"
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
#line 7 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lista-marcas")]
    public partial class ListaMarcas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudButton>(0);
            __builder.AddAttribute(1, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                Icons.Material.Filled.Create

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                     Color.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
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
#line 10 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                            CrearArticulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(9, "Agregar categoría");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
 if (Marca == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-grow text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 22 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
}
else if (Marca.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron marcas.</text></div>");
#nullable restore
#line 28 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
}
else
{   

#line default
#line hidden
#nullable disable
            __Blazor.SistemaVentasCaprichos.Client.Pages.Marcas.ListaMarcas.TypeInference.CreateMudTable_0(__builder, 12, 13, 
#nullable restore
#line 31 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                      Marca

#line default
#line hidden
#nullable disable
            , 14, 
#nullable restore
#line 31 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                     dense

#line default
#line hidden
#nullable disable
            , 15, 
#nullable restore
#line 31 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                    hover

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 31 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                      bordered

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 31 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                          striped

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 31 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                                           new Func<Marcas,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 32 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                  selectedItem1

#line default
#line hidden
#nullable disable
            , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 21, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(22);
                __builder2.AddAttribute(23, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 34 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(25, "Marcas");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudSpacer>(27);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Marcas.ListaMarcas.TypeInference.CreateMudTextField_1(__builder2, 29, 30, "Buscar marca...", 31, 
#nullable restore
#line 36 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                               Adornment.Start

#line default
#line hidden
#nullable disable
                , 32, 
#nullable restore
#line 36 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                                                                Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 33, 
#nullable restore
#line 36 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                                                                                                        Size.Medium

#line default
#line hidden
#nullable disable
                , 34, "mt-0", 35, 
#nullable restore
#line 36 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                       searchString1

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
            }
            , 37, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(38);
                __builder2.AddAttribute(39, "Style", "width:50px;");
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(41, "Nr");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(43);
                __builder2.AddAttribute(44, "Class", "thead-dark");
                __builder2.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(46, "Nombre");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(48);
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(50, "Descripción");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(52);
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(54, "Fecha registro");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(56);
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(58, "Acciones");
                }
                ));
                __builder2.CloseComponent();
            }
            , 59, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(60);
                __builder2.AddAttribute(61, "DataLabel", "Id");
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(63, 
#nullable restore
#line 46 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                   context.Id

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(65);
                __builder2.AddAttribute(66, "DataLabel", "Nombre");
                __builder2.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(68, 
#nullable restore
#line 47 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                       context.Nombre

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(70);
                __builder2.AddAttribute(71, "DataLabel", "Descripción");
                __builder2.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(73, 
#nullable restore
#line 48 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                            context.Descripcion

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(75);
                __builder2.AddAttribute(76, "DataLabel", "Fecha");
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(78, 
#nullable restore
#line 49 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                      context.Fecha

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(80);
                __builder2.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudFab>(82);
                    __builder3.AddAttribute(83, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 51 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                               Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(84, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                        Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 51 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                          Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
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
            , 87, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(88);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 60 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\ListaMarcas.razor"
       
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