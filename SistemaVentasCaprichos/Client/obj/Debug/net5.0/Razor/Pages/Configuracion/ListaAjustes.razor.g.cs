#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b79b69ce113f241e558b904af8325b2e2b603c4"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Configuracion
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
#line 7 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lista-ajustes")]
    public partial class ListaAjustes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudButton>(0);
            __builder.AddAttribute(1, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                Icons.Material.Filled.Create

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                     Color.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
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
#line 10 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                            CrearArticulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(9, "Agregar ajuste");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
 if (Configuracion == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-grow text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 22 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
}
else if (Configuracion.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron Configuracion.</text></div>");
#nullable restore
#line 28 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
}
else
{   
    


#line default
#line hidden
#nullable disable
            __Blazor.SistemaVentasCaprichos.Client.Pages.Configuracion.ListaAjustes.TypeInference.CreateMudTable_0(__builder, 12, 13, 
#nullable restore
#line 33 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                     Configuracion

#line default
#line hidden
#nullable disable
            , 14, (__builder2) => {
            }
            , 15, (context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "<br>\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudButton>(17);
                __builder2.AddAttribute(18, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 39 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                            Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 39 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                               Color.Warning

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 39 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                                                    Size.Medium

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(23, "a");
                    __builder3.AddAttribute(24, "style", "text-decoration:none; color:#fff;");
                    __builder3.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                               () => NavigationManager.NavigateTo($"/editar-ajustes/{context.Id}")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(26, "Editar");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-field mt-2 mb-2");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "row");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-6");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group row");
                __builder2.AddMarkupContent(36, "<label class=\"col-4 col-form-label\">Nombre propietario</label>\r\n                            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "input-group");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Configuracion.ListaAjustes.TypeInference.CreateMudTextField_1(__builder2, 41, 42, "Propietario del negocio", 43, 
#nullable restore
#line 50 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                                                                    Variant.Outlined

#line default
#line hidden
#nullable disable
                , 44, "this.value=this.value.toUpperCase()", 45, 
#nullable restore
#line 51 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                          Margin.Dense

#line default
#line hidden
#nullable disable
                , 46, 
#nullable restore
#line 51 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
                , 47, 
#nullable restore
#line 50 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                context.NombrePropietario

#line default
#line hidden
#nullable disable
                , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.NombrePropietario = __value, context.NombrePropietario)));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n                        ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group row");
                __builder2.AddMarkupContent(52, "<label class=\"col-4 col-form-label\">Nombre del negocio</label>\r\n                            ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "input-group");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Configuracion.ListaAjustes.TypeInference.CreateMudTextField_2(__builder2, 57, 58, "Nombre del negocio", 59, 
#nullable restore
#line 60 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                                                           Variant.Outlined

#line default
#line hidden
#nullable disable
                , 60, "this.value=this.value.toUpperCase()", 61, 
#nullable restore
#line 61 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                 Margin.Dense

#line default
#line hidden
#nullable disable
                , 62, 
#nullable restore
#line 61 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                , 63, 
#nullable restore
#line 60 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                context.NombreSistema

#line default
#line hidden
#nullable disable
                , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.NombreSistema = __value, context.NombreSistema)));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n                        ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group row");
                __builder2.AddMarkupContent(68, "<label class=\"col-4 col-form-label\">Dirección</label>\r\n                            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "col");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "input-group");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Configuracion.ListaAjustes.TypeInference.CreateMudTextField_3(__builder2, 73, 74, "Dirección", 75, 
#nullable restore
#line 70 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                                              Variant.Outlined

#line default
#line hidden
#nullable disable
                , 76, "this.value=this.value.toUpperCase()", 77, 
#nullable restore
#line 71 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                          Margin.Dense

#line default
#line hidden
#nullable disable
                , 78, 
#nullable restore
#line 71 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
                , 79, 
#nullable restore
#line 71 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                               3

#line default
#line hidden
#nullable disable
                , 80, 
#nullable restore
#line 70 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                context.Direccion

#line default
#line hidden
#nullable disable
                , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Direccion = __value, context.Direccion)));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n                        ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-group row");
                __builder2.AddMarkupContent(85, "<label class=\"col-4 col-form-label\">Teléfono</label>\r\n                            ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "col");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "input-group");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Configuracion.ListaAjustes.TypeInference.CreateMudTextField_4(__builder2, 90, 91, "Teléfono", 92, 
#nullable restore
#line 80 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                                            Variant.Outlined

#line default
#line hidden
#nullable disable
                , 93, "this.value=this.value.toUpperCase()", 94, 
#nullable restore
#line 81 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                          Margin.Dense

#line default
#line hidden
#nullable disable
                , 95, 
#nullable restore
#line 81 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
                , 96, 
#nullable restore
#line 80 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                context.Telefono

#line default
#line hidden
#nullable disable
                , 97, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Telefono = __value, context.Telefono)));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n\r\n                        ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-group row");
                __builder2.AddMarkupContent(101, "<label class=\"col-4 col-form-label\">Email</label>\r\n                            ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "col");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "input-group");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Configuracion.ListaAjustes.TypeInference.CreateMudTextField_5(__builder2, 106, 107, "Correo electrónico", 108, 
#nullable restore
#line 90 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                , 109, "this.value=this.value.toUpperCase()", 110, 
#nullable restore
#line 91 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                          Margin.Dense

#line default
#line hidden
#nullable disable
                , 111, 
#nullable restore
#line 91 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
                , 112, 
#nullable restore
#line 90 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                context.Email

#line default
#line hidden
#nullable disable
                , 113, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Email = __value, context.Email)));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n\r\n                        ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "form-group row");
                __builder2.AddMarkupContent(117, "<label class=\"col-4 col-form-label\">R.U.C</label>\r\n                            ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "col");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "input-group");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Configuracion.ListaAjustes.TypeInference.CreateMudTextField_6(__builder2, 122, 123, "Número RUC", 124, 
#nullable restore
#line 100 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                                         Variant.Outlined

#line default
#line hidden
#nullable disable
                , 125, "this.value=this.value.toUpperCase()", 126, 
#nullable restore
#line 101 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                          Margin.Dense

#line default
#line hidden
#nullable disable
                , 127, 
#nullable restore
#line 101 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
                , 128, 
#nullable restore
#line 100 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
                                                                context.RUC

#line default
#line hidden
#nullable disable
                , 129, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.RUC = __value, context.RUC)));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
#nullable restore
#line 110 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"

    


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
       
    private bool dense = false;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private Configuracion selectedItem1 = null;
    private HashSet<Configuracion> selectedItems = new HashSet<Configuracion>();    


    public List<Configuracion> Configuracion { get; set; } //muestra todos los Categoria
    Configuracion objConfiguracion = new Configuracion();

    private string NombreArtFiltro = String.Empty; //filtros

    protected bool lista = false;
    protected bool card = true;

    protected override async Task OnInitializedAsync()
    {
        await CargarConfiguracion();
    }

    async Task CargarConfiguracion()
    {
        var httpResponse = await Http.GetAsync($"api/configuracion");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            Configuracion = JsonSerializer.Deserialize<List<Configuracion>>(responseString,
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
        await CargarConfiguracion();
    }

    void CrearArticulo()
    {
        NavigationManager.NavigateTo("crearajustes");
    }

    private async Task Filtrar()
    {
        await CargarConfiguracion();
    }

    private async Task Limpiar()
    {
        NombreArtFiltro = string.Empty;
        await CargarConfiguracion();
    }

    // esta es la funcion de filtrado de MudBlazor
    private bool FilterFunc1(Configuracion element) => FilterFunc(element, searchString1);

    private bool FilterFunc(Configuracion element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.NombreSistema.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
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
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Configuracion.ListaAjustes
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "HeaderContent", __arg1);
        __builder.AddAttribute(__seq2, "RowTemplate", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, System.Object __arg2, int __seq3, global::MudBlazor.Margin __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "oninput", __arg2);
        __builder.AddAttribute(__seq3, "Margin", __arg3);
        __builder.AddAttribute(__seq4, "ReadOnly", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, System.Object __arg2, int __seq3, global::MudBlazor.Margin __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "oninput", __arg2);
        __builder.AddAttribute(__seq3, "Margin", __arg3);
        __builder.AddAttribute(__seq4, "ReadOnly", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, System.Object __arg2, int __seq3, global::MudBlazor.Margin __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Int32 __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "oninput", __arg2);
        __builder.AddAttribute(__seq3, "Margin", __arg3);
        __builder.AddAttribute(__seq4, "ReadOnly", __arg4);
        __builder.AddAttribute(__seq5, "Lines", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, System.Object __arg2, int __seq3, global::MudBlazor.Margin __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "oninput", __arg2);
        __builder.AddAttribute(__seq3, "Margin", __arg3);
        __builder.AddAttribute(__seq4, "ReadOnly", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, System.Object __arg2, int __seq3, global::MudBlazor.Margin __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "oninput", __arg2);
        __builder.AddAttribute(__seq3, "Margin", __arg3);
        __builder.AddAttribute(__seq4, "ReadOnly", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, System.Object __arg2, int __seq3, global::MudBlazor.Margin __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "oninput", __arg2);
        __builder.AddAttribute(__seq3, "Margin", __arg3);
        __builder.AddAttribute(__seq4, "ReadOnly", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
