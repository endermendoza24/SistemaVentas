#pragma checksum "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e50787dbaf8f4a594a15efb8c9b209ab5090250"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Pedidos
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
    public partial class FormPedidos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                  pedido

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 2 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                         OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-field mt-2 mb-2");
                __builder2.AddAttribute(6, "b-9i5hs6tbjf");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group row");
                __builder2.AddAttribute(9, "b-9i5hs6tbjf");
                __builder2.AddMarkupContent(10, "<label class=\"col-3 col-form-label\" b-9i5hs6tbjf>Cliente</label>\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col");
                __builder2.AddAttribute(13, "b-9i5hs6tbjf");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "input-group");
                __builder2.AddAttribute(16, "b-9i5hs6tbjf");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pedidos.FormPedidos.TypeInference.CreateInputSelect_0(__builder2, 17, 18, "custom-select", 19, "cliente", 20, 
#nullable restore
#line 8 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                              pedido.ClienteId

#line default
#line hidden
#nullable disable
                , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pedido.ClienteId = __value, pedido.ClienteId)), 22, () => pedido.ClienteId, 23, (__builder3) => {
                    __builder3.AddMarkupContent(24, "<option selected value=\"0\" b-9i5hs6tbjf>Seleccione cliente</option>");
#nullable restore
#line 10 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                         foreach (var cliente in clientes)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(25, "option");
                    __builder3.AddAttribute(26, "value", 
#nullable restore
#line 12 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                            cliente.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(27, "b-9i5hs6tbjf");
                    __builder3.AddContent(28, 
#nullable restore
#line 12 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                         cliente.NombreyApellido

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(29, " | Cédula:");
                    __builder3.AddContent(30, 
#nullable restore
#line 12 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                                                           cliente.Cedula

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 13 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pedidos.FormPedidos.TypeInference.CreateValidationMessage_1(__builder2, 32, 33, 
#nullable restore
#line 16 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                          () => pedido.ClienteId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddAttribute(37, "b-9i5hs6tbjf");
#nullable restore
#line 21 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
             for (int i = 0; i < pedido.DetallePedidos.Count; i++)
            {
                var indice = i;
                var detalle = pedido.DetallePedidos[i];


#line default
#line hidden
#nullable disable
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "d-flex justify-content-between m-1");
                __builder2.AddAttribute(40, "b-9i5hs6tbjf");
                __builder2.OpenElement(41, "h5");
                __builder2.AddAttribute(42, "b-9i5hs6tbjf");
                __builder2.AddMarkupContent(43, "Ítem #");
                __builder2.AddContent(44, 
#nullable restore
#line 27 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                i + 1

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "b-9i5hs6tbjf");
                __builder2.OpenElement(48, "button");
                __builder2.AddAttribute(49, "type", "button");
                __builder2.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                          () => pedido.DetallePedidos.RemoveAt(indice)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "class", "btn btn-danger btn-sm");
                __builder2.AddAttribute(52, "style", "border-radius:10px");
                __builder2.AddAttribute(53, "b-9i5hs6tbjf");
                __builder2.AddMarkupContent(54, "<i class=\"oi oi-trash\" b-9i5hs6tbjf></i>");
                __builder2.OpenElement(55, "text");
                __builder2.AddAttribute(56, "style", "color:white");
                __builder2.AddAttribute(57, "b-9i5hs6tbjf");
                __builder2.AddMarkupContent(58, "Quitar ítem ");
                __builder2.AddContent(59, 
#nullable restore
#line 30 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                                                               indice+1

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "card mb-2");
                __builder2.AddAttribute(62, "style", "background-color:lightgrey; border-radius:0.5rem");
                __builder2.AddAttribute(63, "b-9i5hs6tbjf");
                __builder2.AddMarkupContent(64, "<div class=\"row ml-1 mt-1\" b-9i5hs6tbjf><div class=\"col-8\" b-9i5hs6tbjf><label b-9i5hs6tbjf>Artículo </label></div>\r\n                        <div class=\"col-4\" b-9i5hs6tbjf><label b-9i5hs6tbjf>Cantidad </label></div></div>\r\n                    ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "row ml-1 mb-1");
                __builder2.AddAttribute(67, "b-9i5hs6tbjf");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "col-8");
                __builder2.AddAttribute(70, "b-9i5hs6tbjf");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pedidos.FormPedidos.TypeInference.CreateInputSelect_2(__builder2, 71, 72, true, 73, "form-control", 74, 
#nullable restore
#line 46 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                      detalle.ArticuloId

#line default
#line hidden
#nullable disable
                , 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => detalle.ArticuloId = __value, detalle.ArticuloId)), 76, () => detalle.ArticuloId, 77, (__builder3) => {
                    __builder3.AddMarkupContent(78, "<option selected value b-9i5hs6tbjf>Seleccione un artículo</option>");
#nullable restore
#line 48 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                 foreach (var articulo in articulos)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(79, "option");
                    __builder3.AddAttribute(80, "value", 
#nullable restore
#line 50 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                    articulo.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(81, "b-9i5hs6tbjf");
                    __builder3.AddContent(82, 
#nullable restore
#line 50 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                                  articulo.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(83, " | $");
                    __builder3.AddContent(84, 
#nullable restore
#line 50 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                                                      articulo.PrecioUnitario

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(85, " | STOCK: ");
                    __builder3.AddContent(86, 
#nullable restore
#line 50 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                                                                                        articulo.StockActual

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 51 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(87, "\r\n                            ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pedidos.FormPedidos.TypeInference.CreateValidationMessage_3(__builder2, 88, 89, 
#nullable restore
#line 53 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                      () => detalle.ArticuloId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                        ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "col-4");
                __builder2.AddAttribute(93, "b-9i5hs6tbjf");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pedidos.FormPedidos.TypeInference.CreateInputNumber_4(__builder2, 94, 95, "form-control", 96, "1", 97, 
#nullable restore
#line 56 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                      detalle.Cantidad

#line default
#line hidden
#nullable disable
                , 98, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => detalle.Cantidad = __value, detalle.Cantidad)), 99, () => detalle.Cantidad);
                __builder2.AddMarkupContent(100, "\r\n                            ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pedidos.FormPedidos.TypeInference.CreateValidationMessage_5(__builder2, 101, 102, 
#nullable restore
#line 57 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                      () => detalle.Cantidad

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 61 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "btn-group");
                __builder2.AddAttribute(105, "b-9i5hs6tbjf");
                __builder2.OpenElement(106, "button");
                __builder2.AddAttribute(107, "type", "button");
                __builder2.AddAttribute(108, "class", "btn btn-success");
                __builder2.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                    () => pedido.DetallePedidos.Add(new DetallePedido())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "b-9i5hs6tbjf");
                __builder2.AddMarkupContent(111, "\r\n                    Agregar ítem\r\n                ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n\r\n            <hr b-9i5hs6tbjf>\r\n\r\n            ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "form-group row");
                __builder2.AddAttribute(115, "b-9i5hs6tbjf");
                __builder2.AddMarkupContent(116, "<label class=\"col-3 col-form-label\" b-9i5hs6tbjf>Seña</label>\r\n                ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "col");
                __builder2.AddAttribute(119, "b-9i5hs6tbjf");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "input-group");
                __builder2.AddAttribute(122, "b-9i5hs6tbjf");
                __builder2.AddMarkupContent(123, "<div class=\"input-group-prepend\" b-9i5hs6tbjf><span class=\"input-group-text\" id=\"inputGroup-sizing-default\" b-9i5hs6tbjf>$</span></div>\r\n                        ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pedidos.FormPedidos.TypeInference.CreateInputNumber_6(__builder2, 124, 125, "form-control", 126, 
#nullable restore
#line 79 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                  pedido.Seña

#line default
#line hidden
#nullable disable
                , 127, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pedido.Seña = __value, pedido.Seña)), 128, () => pedido.Seña);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                    ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pedidos.FormPedidos.TypeInference.CreateValidationMessage_7(__builder2, 130, 131, 
#nullable restore
#line 81 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                              () => pedido.Seña

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n\r\n            ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "form-group d-flex align-items-center row");
                __builder2.AddAttribute(135, "b-9i5hs6tbjf");
                __builder2.AddMarkupContent(136, "<label class=\"col-3 col-form-label\" b-9i5hs6tbjf>Finalizado</label>\r\n                ");
                __builder2.OpenElement(137, "div");
                __builder2.AddAttribute(138, "class", "col");
                __builder2.AddAttribute(139, "b-9i5hs6tbjf");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(140);
                __builder2.AddAttribute(141, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 88 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                pedido.Finalizado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(142, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pedido.Finalizado = __value, pedido.Finalizado))));
                __builder2.AddAttribute(143, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => pedido.Finalizado));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\r\n                ");
                __Blazor.SistemaVentasCaprichos.Client.Pages.Pedidos.FormPedidos.TypeInference.CreateValidationMessage_8(__builder2, 145, 146, 
#nullable restore
#line 90 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                          () => pedido.Finalizado

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n\r\n            ");
                __builder2.OpenElement(148, "div");
                __builder2.AddAttribute(149, "class", "btn-group btn-block");
                __builder2.AddAttribute(150, "b-9i5hs6tbjf");
                __builder2.OpenElement(151, "button");
                __builder2.AddAttribute(152, "type", "submit");
                __builder2.AddAttribute(153, "class", "btn btn-success");
                __builder2.AddAttribute(154, "b-9i5hs6tbjf");
                __builder2.AddMarkupContent(155, "<i class=\"oi oi-check\" b-9i5hs6tbjf></i>");
                __builder2.OpenElement(156, "text");
                __builder2.AddAttribute(157, "style", "color:white");
                __builder2.AddAttribute(158, "b-9i5hs6tbjf");
                __builder2.AddContent(159, 
#nullable restore
#line 94 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
                                                                                                                     textSubmit

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(161);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Users\Endersson\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Pedidos\FormPedidos.razor"
       
    [Parameter] public Pedido pedido { get; set; } = new Pedido();
    [Parameter] public List<Cliente> clientes { get; set; } = new List<Cliente>();
    [Parameter] public List<Articulo> articulos { get; set; } = new List<Articulo>();
    [Parameter] public EventCallback OnValidSubmit { get; set; }

    [Parameter] public string textSubmit { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Pedidos.FormPedidos
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
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "required", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "min", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
