#pragma checksum "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b8f8018cca659d6bee494ca6e71e3f59ff80347"
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
#line 1 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class FormularioMarcas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
                  Marca

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
                                         OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-field mt-2 mb-2");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-6");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group row");
                __builder2.AddMarkupContent(12, "<label class=\"col-4 col-form-label\">Nombre</label>\r\n                    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "input-group");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Marcas.FormularioMarcas.TypeInference.CreateMudTextField_0(__builder2, 17, 18, "Nombre", 19, 
#nullable restore
#line 13 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
                                                                                              Variant.Outlined

#line default
#line hidden
#nullable disable
                , 20, "this.value=this.value.toUpperCase()", 21, 
#nullable restore
#line 14 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
                                                  Margin.Dense

#line default
#line hidden
#nullable disable
                , 22, 
#nullable restore
#line 13 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
                                                        Marca.Nombre

#line default
#line hidden
#nullable disable
                , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Marca.Nombre = __value, Marca.Nombre)));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Marcas.FormularioMarcas.TypeInference.CreateValidationMessage_1(__builder2, 25, 26, 
#nullable restore
#line 16 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
                                                  () => Marca.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n                ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group row");
                __builder2.AddMarkupContent(30, "<label class=\"col-4 col-form-label\">Descripción</label>\r\n                    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "input-group");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Marcas.FormularioMarcas.TypeInference.CreateMudTextField_2(__builder2, 35, 36, "Descripción", 37, 
#nullable restore
#line 24 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
                                                                                                        Variant.Outlined

#line default
#line hidden
#nullable disable
                , 38, "this.value=this.value.toUpperCase()", 39, 
#nullable restore
#line 25 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
                                                  Margin.Dense

#line default
#line hidden
#nullable disable
                , 40, 
#nullable restore
#line 24 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
                                                        Marca.Descripcion

#line default
#line hidden
#nullable disable
                , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Marca.Descripcion = __value, Marca.Descripcion)));
                __builder2.AddMarkupContent(42, "                            \r\n                            ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Marcas.FormularioMarcas.TypeInference.CreateValidationMessage_3(__builder2, 43, 44, 
#nullable restore
#line 26 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
                                                      () => Marca.Descripcion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group row");
                __builder2.AddMarkupContent(48, "<label class=\"col-4 col-form-label\">Dar de baja</label>\r\n                    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "input-group");
                __builder2.OpenComponent<MudBlazor.MudTooltip>(53);
                __builder2.AddAttribute(54, "Text", "Si selecciona esta opción dará de baja a la marca correspondiente.");
                __builder2.AddAttribute(55, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 34 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
                                                                                                                         Color.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "Placement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Placement>(
#nullable restore
#line 34 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
                                                                                                                                                     Placement.Top

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.SistemaVentasCaprichos.Client.Pages.Marcas.FormularioMarcas.TypeInference.CreateMudSwitch_4(__builder3, 58, 59, "Está activo?", 60, 
#nullable restore
#line 35 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
                                                                                                     Color.Success

#line default
#line hidden
#nullable disable
                    , 61, 
#nullable restore
#line 35 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
                                                           Marca.Estado

#line default
#line hidden
#nullable disable
                    , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Marca.Estado = __value, Marca.Estado)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.AddMarkupContent(64, "<button type=\"submit\" class=\"btn btn-block btn-success\"><i class=\"oi oi-check \"></i>\r\n            <text style=\"color:white\"></text></button>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(66);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\osday\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Marcas\FormularioMarcas.razor"
       

    [Parameter] public Marcas Marca { get; set; } = new Marcas();
    
    [Parameter] public string TextBotonSubmit { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }       

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Marcas.FormularioMarcas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, System.Object __arg2, int __seq3, global::MudBlazor.Margin __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "oninput", __arg2);
        __builder.AddAttribute(__seq3, "Margin", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, System.Object __arg2, int __seq3, global::MudBlazor.Margin __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "oninput", __arg2);
        __builder.AddAttribute(__seq3, "Margin", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSwitch_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Color __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudSwitch<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Color", __arg1);
        __builder.AddAttribute(__seq2, "Checked", __arg2);
        __builder.AddAttribute(__seq3, "CheckedChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
