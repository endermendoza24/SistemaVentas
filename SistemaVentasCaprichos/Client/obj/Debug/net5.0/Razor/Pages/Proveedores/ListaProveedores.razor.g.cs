#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdfc3966bd7c197b799e86c8ac4044d84d4eabfa"
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
#line 7 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lista-proveedores")]
    public partial class ListaProveedores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudButton>(0);
            __builder.AddAttribute(1, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                Icons.Material.Filled.Create

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                     Color.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
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
#line 10 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
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
#line 15 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
 if (Proveedores == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-grow text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 22 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
}
else if (Proveedores.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron marcas.</text></div>");
#nullable restore
#line 28 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
}
else
{   

#line default
#line hidden
#nullable disable
            __Blazor.SistemaVentasCaprichos.Client.Pages.Proveedores.ListaProveedores.TypeInference.CreateMudTable_0(__builder, 12, 13, 
#nullable restore
#line 31 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                      Proveedores

#line default
#line hidden
#nullable disable
            , 14, 
#nullable restore
#line 31 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                           dense

#line default
#line hidden
#nullable disable
            , 15, 
#nullable restore
#line 31 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                          hover

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 31 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                            bordered

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 31 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                striped

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 31 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                                 new Func<Proveedores,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 32 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                  selectedItem1

#line default
#line hidden
#nullable disable
            , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 21, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(22);
                __builder2.AddAttribute(23, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 34 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(25, "Proveedores");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudSpacer>(27);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Proveedores.ListaProveedores.TypeInference.CreateMudTextField_1(__builder2, 29, 30, "Buscar proveedor...", 31, 
#nullable restore
#line 36 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                   Adornment.Start

#line default
#line hidden
#nullable disable
                , 32, 
#nullable restore
#line 36 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                                                    Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 33, 
#nullable restore
#line 36 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                                                                                            Size.Medium

#line default
#line hidden
#nullable disable
                , 34, "mt-0", 35, 
#nullable restore
#line 36 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
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
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(45, "Nombre");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(47);
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(49, "Teléfono");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(51);
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(53, "Dirección");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(55);
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(57, "Fecha registro");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(59);
                __builder2.AddAttribute(60, "Style", "width:70px;");
                __builder2.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(62, "Acciones");
                }
                ));
                __builder2.CloseComponent();
            }
            , 63, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(64);
                __builder2.AddAttribute(65, "DataLabel", "Id");
                __builder2.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(67, 
#nullable restore
#line 47 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                   context.Id

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(69);
                __builder2.AddAttribute(70, "DataLabel", "Nombre");
                __builder2.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(72, 
#nullable restore
#line 48 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                       context.Nombre

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(74);
                __builder2.AddAttribute(75, "DataLabel", "Teléfono");
                __builder2.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(77, 
#nullable restore
#line 49 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                         context.Telefono

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(79);
                __builder2.AddAttribute(80, "DataLabel", "Dirección");
                __builder2.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(82, 
#nullable restore
#line 50 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                          context.Direccion

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(84);
                __builder2.AddAttribute(85, "DataLabel", "Fecha");
                __builder2.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(87, 
#nullable restore
#line 51 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                      context.Fecha

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(89);
                __builder2.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudFab>(91);
                    __builder3.AddAttribute(92, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 53 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                               Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(93, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                        Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(94, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 53 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                          Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                    () => NavigationManager.NavigateTo($"/editar-proveedores/{context.Id}")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 96, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(97);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 62 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
       
    private bool dense = false;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private Proveedores selectedItem1 = null;
    private HashSet<Proveedores> selectedItems = new HashSet<Proveedores>();


    public List<Proveedores> Proveedores { get; set; } //muestra todos los Categoria
    Proveedores objMarca = new Proveedores();

    private string NombreArtFiltro = String.Empty; //filtros

    protected bool lista = false;
    protected bool card = true;

    protected override async Task OnInitializedAsync()
    {
        await CargarProveedores();
    }

    async Task CargarProveedores()
    {
        var httpResponse = await Http.GetAsync($"api/proveedores");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            Proveedores = JsonSerializer.Deserialize<List<Proveedores>>(responseString,
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
        await CargarProveedores();
    }

    void CrearArticulo()
    {
        NavigationManager.NavigateTo("crearproveedores");
    }

    private async Task Filtrar()
    {
        await CargarProveedores();
    }

    private async Task Limpiar()
    {
        NombreArtFiltro = string.Empty;
        await CargarProveedores();
    }

    // esta es la funcion de filtrado de MudBlazor
    private bool FilterFunc1(Proveedores element) => FilterFunc(element, searchString1);

    private bool FilterFunc(Proveedores element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.Nombre.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.Telefono.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.Direccion.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
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
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Proveedores.ListaProveedores
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
