#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25af4fece604ddc55a3f2435bd391c22547bb2cb"
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
#line 18 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
           [Authorize]

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
                __builder2.AddContent(9, "Agregar proveedor");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.AddMarkupContent(11, "<div class=\"d-flex justify-content-between mt-2 mb-2\"><div class=\"btn-group\"><a href=\"/lista-proveedores-bajas\" style=\"background:none; border:none\">\r\n            &nbsp;&nbsp;<b>Dados de baja</b></a></div></div>");
#nullable restore
#line 21 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
 if (Proveedores == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-border text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 28 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
}
else if (Proveedores.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron proveedores.</text></div>");
#nullable restore
#line 34 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
}
else
{   

#line default
#line hidden
#nullable disable
            __Blazor.SistemaVentasCaprichos.Client.Pages.Proveedores.ListaProveedores.TypeInference.CreateMudTable_0(__builder, 14, 15, 
#nullable restore
#line 37 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                      Proveedores

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 37 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                           dense

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 37 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                          hover

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 37 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                            bordered

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 37 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                striped

#line default
#line hidden
#nullable disable
            , 20, 
#nullable restore
#line 37 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                                 new Func<Proveedores,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 21, 
#nullable restore
#line 38 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                  selectedItem1

#line default
#line hidden
#nullable disable
            , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 23, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(24);
                __builder2.AddAttribute(25, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 40 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(27, "Proveedores");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudSpacer>(29);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Proveedores.ListaProveedores.TypeInference.CreateMudTextField_1(__builder2, 31, 32, "Buscar proveedor...", 33, 
#nullable restore
#line 42 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                   Adornment.Start

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 42 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                                                    Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 35, 
#nullable restore
#line 42 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                                                                                                            Size.Medium

#line default
#line hidden
#nullable disable
                , 36, "mt-0", 37, 
#nullable restore
#line 42 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                       searchString1

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
            }
            , 39, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(40);
                __builder2.AddAttribute(41, "Style", "width:50px;");
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(43, "Nr");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(45);
                __builder2.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(47, "Nombre");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(49);
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(51, "Teléfono");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(53);
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(55, "Dirección");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(57);
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(59, "Fecha registro");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(61);
                __builder2.AddAttribute(62, "Style", "width:70px;");
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(64, "Acciones");
                }
                ));
                __builder2.CloseComponent();
            }
            , 65, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(66);
                __builder2.AddAttribute(67, "DataLabel", "Id");
                __builder2.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(69, 
#nullable restore
#line 53 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                   context.Id

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(71);
                __builder2.AddAttribute(72, "DataLabel", "Nombre");
                __builder2.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(74, 
#nullable restore
#line 54 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                       context.Nombre

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(76);
                __builder2.AddAttribute(77, "DataLabel", "Teléfono");
                __builder2.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(79, 
#nullable restore
#line 55 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                         context.Telefono

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(81);
                __builder2.AddAttribute(82, "DataLabel", "Dirección");
                __builder2.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(84, 
#nullable restore
#line 56 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                          context.Direccion

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(86);
                __builder2.AddAttribute(87, "DataLabel", "Fecha");
                __builder2.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(89, 
#nullable restore
#line 57 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                      context.Fecha.ToLongDateString()

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(91);
                __builder2.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudFab>(93);
                    __builder3.AddAttribute(94, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 59 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                               Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(95, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                        Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 59 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
                                                                                          Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
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
            , 98, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(99);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 68 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Proveedores\ListaProveedores.razor"
       
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
