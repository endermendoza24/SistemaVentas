#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c63e8a5bac6c37a4ee5677cb8e2a8dbfc5a02fc"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Pagos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class FormPago : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                  pago

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                                       OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-field mt-2 mb-2");
                __builder2.AddAttribute(6, "b-v4oex3szsq");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group row");
                __builder2.AddAttribute(9, "b-v4oex3szsq");
                __builder2.AddMarkupContent(10, "<label class=\"col-3 col-form-label\" b-v4oex3szsq>Cliente</label>\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col");
                __builder2.AddAttribute(13, "b-v4oex3szsq");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "input-group");
                __builder2.AddAttribute(16, "b-v4oex3szsq");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pagos.FormPago.TypeInference.CreateInputSelect_0(__builder2, 17, 18, "custom-select", 19, "cliente", 20, 
#nullable restore
#line 9 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                                              pago.ClienteId

#line default
#line hidden
#nullable disable
                , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pago.ClienteId = __value, pago.ClienteId)), 22, () => pago.ClienteId, 23, (__builder3) => {
                    __builder3.AddMarkupContent(24, "<option selected value=\"0\" b-v4oex3szsq>Seleccione cliente</option>");
#nullable restore
#line 11 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                         foreach (var cliente in clientes)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(25, "option");
                    __builder3.AddAttribute(26, "value", 
#nullable restore
#line 13 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                                            cliente.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(27, "b-v4oex3szsq");
#nullable restore
#line 13 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
__builder3.AddContent(28, cliente.NombreyApellido);

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(29, " | DNI:");
#nullable restore
#line 13 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
__builder3.AddContent(30, cliente.Dni);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 14 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pagos.FormPago.TypeInference.CreateValidationMessage_1(__builder2, 32, 33, 
#nullable restore
#line 17 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                                          () => pago.ClienteId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group row");
                __builder2.AddAttribute(37, "b-v4oex3szsq");
                __builder2.AddMarkupContent(38, "<label class=\"col-3 col-form-label\" b-v4oex3szsq>Concepto</label>\r\n            ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col");
                __builder2.AddAttribute(41, "b-v4oex3szsq");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "input-group");
                __builder2.AddAttribute(44, "b-v4oex3szsq");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                                            pago.Concepto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pago.Concepto = __value, pago.Concepto))));
                __builder2.AddAttribute(49, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => pago.Concepto));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pagos.FormPago.TypeInference.CreateValidationMessage_2(__builder2, 51, 52, 
#nullable restore
#line 27 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                                          () => pago.Concepto

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n\r\n        ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group row");
                __builder2.AddAttribute(56, "b-v4oex3szsq");
                __builder2.AddMarkupContent(57, "<label class=\"col-3 col-form-label\" b-v4oex3szsq>Importe</label>\r\n            ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "col");
                __builder2.AddAttribute(60, "b-v4oex3szsq");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "input-group");
                __builder2.AddAttribute(63, "b-v4oex3szsq");
                __builder2.AddMarkupContent(64, "<div class=\"input-group-prepend\" b-v4oex3szsq><span class=\"input-group-text\" id=\"inputGroup-sizing-default\" b-v4oex3szsq>$</span></div>\r\n                    ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pagos.FormPago.TypeInference.CreateInputNumber_3(__builder2, 65, 66, "0.01", 67, "form-control", 68, 
#nullable restore
#line 38 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                                              pago.Importe

#line default
#line hidden
#nullable disable
                , 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pago.Importe = __value, pago.Importe)), 70, () => pago.Importe);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pagos.FormPago.TypeInference.CreateValidationMessage_4(__builder2, 72, 73, 
#nullable restore
#line 40 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                                          () => pago.Importe

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\r\n        ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group row");
                __builder2.AddAttribute(77, "b-v4oex3szsq");
                __builder2.AddMarkupContent(78, "<label class=\"col-3 col-form-label\" b-v4oex3szsq>Forma de Pago</label>\r\n            ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "col");
                __builder2.AddAttribute(81, "b-v4oex3szsq");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "input-group");
                __builder2.AddAttribute(84, "b-v4oex3szsq");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pagos.FormPago.TypeInference.CreateInputSelect_5(__builder2, 85, 86, "form-control", 87, 
#nullable restore
#line 48 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                                              pago.FormaPago

#line default
#line hidden
#nullable disable
                , 88, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pago.FormaPago = __value, pago.FormaPago)), 89, () => pago.FormaPago, 90, (__builder3) => {
#nullable restore
#line 49 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                         foreach (string fpago in Enum.GetNames(typeof(Pago.FormasPago)))
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(91, "option");
                    __builder3.AddAttribute(92, "value", 
#nullable restore
#line 51 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                                            fpago

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(93, "b-v4oex3szsq");
#nullable restore
#line 51 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
__builder3.AddContent(94, fpago);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 52 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pagos.FormPago.TypeInference.CreateValidationMessage_6(__builder2, 96, 97, 
#nullable restore
#line 55 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                                          () => pago.FormaPago

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n\r\n        ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "btn-group btn-block");
                __builder2.AddAttribute(101, "b-v4oex3szsq");
                __builder2.OpenElement(102, "button");
                __builder2.AddAttribute(103, "type", "submit");
                __builder2.AddAttribute(104, "class", "btn btn-success");
                __builder2.AddAttribute(105, "b-v4oex3szsq");
                __builder2.AddMarkupContent(106, "<i class=\"oi oi-check\" b-v4oex3szsq></i>");
                __builder2.OpenElement(107, "text");
                __builder2.AddAttribute(108, "style", "color:white");
                __builder2.AddAttribute(109, "b-v4oex3szsq");
#nullable restore
#line 60 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
__builder2.AddContent(110, textSubmit);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n            ");
                __builder2.OpenElement(112, "button");
                __builder2.AddAttribute(113, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
                               Volver

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "class", "btn btn-danger");
                __builder2.AddAttribute(115, "b-v4oex3szsq");
                __builder2.AddMarkupContent(116, "<i class=\"oi oi-x\" b-v4oex3szsq></i>");
                __builder2.AddMarkupContent(117, "<text style=\"color:white\" b-v4oex3szsq> Cancelar y volver atrás</text>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(119);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\Endersson\Desktop\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Pagos\FormPago.razor"
       
    [Parameter] public Pago pago { get; set; } = new Pago();
    [Parameter] public List<Cliente> clientes { get; set; } = new List<Cliente>();
    [Parameter] public EventCallback OnValidSubmit { get; set; }

    [Parameter] public string textSubmit { get; set; }

    void Volver()
    {
        NavigationManager.NavigateTo("/lista-pagos");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Pagos.FormPago
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "step", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
