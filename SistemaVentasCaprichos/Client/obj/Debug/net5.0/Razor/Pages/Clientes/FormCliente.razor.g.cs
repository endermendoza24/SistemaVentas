#pragma checksum "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dbdae073efb6e0fda21cc58ddbc6ae91f1003d5"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages.Clientes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
    public partial class FormCliente : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 2 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                  cliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 2 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                           OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-field mt-2 mb-2");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group row");
                __builder2.AddMarkupContent(8, "<label class=\"col-3 col-form-label\">Nombre</label>\r\n            ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "input-group");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "oninput", "this.value=this.value.toUpperCase()");
                __builder2.AddAttribute(15, "placeholder", "Nombre");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 8 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                             cliente.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Nombre = __value, cliente.Nombre))));
                __builder2.AddAttribute(19, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Nombre));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                ");
                global::__Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.FormCliente.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 10 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                          () => cliente.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group row");
                __builder2.AddMarkupContent(26, "<label class=\"col-3 col-form-label\">Apellido</label>\r\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "input-group");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "oninput", "this.value=this.value.toUpperCase()");
                __builder2.AddAttribute(33, "placeholder", "Apellido");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 18 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                             cliente.Apellido

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Apellido = __value, cliente.Apellido))));
                __builder2.AddAttribute(37, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Apellido));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                ");
                global::__Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.FormCliente.TypeInference.CreateValidationMessage_1(__builder2, 39, 40, 
#nullable restore
#line 20 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                          () => cliente.Apellido

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group row");
                __builder2.AddMarkupContent(44, "<label class=\"col-3 col-form-label\">Cédula</label>\r\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "col");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "input-group");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(49);
                __builder2.AddAttribute(50, "placeholder", "Cédula");
                __builder2.AddAttribute(51, "oninput", "this.value=this.value.toUpperCase()");
                __builder2.AddAttribute(52, "class", "form-control");
                __builder2.AddAttribute(53, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 28 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                             cliente.Cedula

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Cedula = __value, cliente.Cedula))));
                __builder2.AddAttribute(55, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Cedula));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                ");
                global::__Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.FormCliente.TypeInference.CreateValidationMessage_2(__builder2, 57, 58, 
#nullable restore
#line 30 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                          () => cliente.Cedula

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\r\n        ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group row");
                __builder2.AddMarkupContent(62, "<label class=\"col-3 col-form-label\">Sexo</label>\r\n            ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "col");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "input-group");
                global::__Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.FormCliente.TypeInference.CreateInputSelect_3(__builder2, 67, 68, "form-control", 69, 
#nullable restore
#line 38 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                              cliente.Sexo

#line default
#line hidden
#nullable disable
                , 70, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Sexo = __value, cliente.Sexo)), 71, () => cliente.Sexo, 72, (__builder3) => {
#nullable restore
#line 39 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                         foreach (string sexo in Enum.GetNames(typeof(Cliente.Sexos)))
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(73, "option");
                    __builder3.AddAttribute(74, "value", 
#nullable restore
#line 41 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                            sexo

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 41 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
__builder3.AddContent(75, sexo);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 42 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                ");
                global::__Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.FormCliente.TypeInference.CreateValidationMessage_4(__builder2, 77, 78, 
#nullable restore
#line 45 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                          () => cliente.Sexo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n\r\n\r\n\r\n        ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group row");
                __builder2.AddMarkupContent(82, "<label class=\"col-3 col-form-label\">Dirección</label>\r\n            ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "col");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "input-group");
                global::__Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.FormCliente.TypeInference.CreateMudTextField_5(__builder2, 87, 88, "Dirección", 89, 
#nullable restore
#line 56 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                             Variant.Outlined

#line default
#line hidden
#nullable disable
                , 90, 
#nullable restore
#line 56 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                                      3

#line default
#line hidden
#nullable disable
                , 91, 
#nullable restore
#line 57 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                                  Margin.Dense

#line default
#line hidden
#nullable disable
                , 92, 
#nullable restore
#line 55 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                               cliente.Dirección

#line default
#line hidden
#nullable disable
                , 93, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Dirección = __value, cliente.Dirección)));
                __builder2.AddMarkupContent(94, "\r\n                            ");
                global::__Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.FormCliente.TypeInference.CreateValidationMessage_6(__builder2, 95, 96, 
#nullable restore
#line 58 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                                      () => cliente.Dirección

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n\r\n        ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "form-group row");
                __builder2.AddMarkupContent(100, "<label class=\"col-3 col-form-label\">Teléfono</label>\r\n            ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "col");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "input-group");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(105);
                __builder2.AddAttribute(106, "class", "form-control");
                __builder2.AddAttribute(107, "oninput", "this.value=this.value.toUpperCase()");
                __builder2.AddAttribute(108, "placeholder", "Teléfono");
                __builder2.AddAttribute(109, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 67 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                             cliente.Teléfono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Teléfono = __value, cliente.Teléfono))));
                __builder2.AddAttribute(111, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Teléfono));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                ");
                global::__Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.FormCliente.TypeInference.CreateValidationMessage_7(__builder2, 113, 114, 
#nullable restore
#line 69 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                          () => cliente.Teléfono

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n\r\n            ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "form-group row");
                __builder2.AddMarkupContent(118, "<label class=\"col-3 col-form-label\">Estado</label>\r\n                ");
                __builder2.OpenElement(119, "div");
                __builder2.AddAttribute(120, "class", "col");
                __builder2.OpenComponent<global::MudBlazor.MudTooltip>(121);
                __builder2.AddAttribute(122, "Text", "Si selecciona esta opción dará de baja al cliente correspondiente.");
                __builder2.AddAttribute(123, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 76 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                       Color.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(124, "Placement", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Placement>(
#nullable restore
#line 76 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                                                   Placement.Top

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(125, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    global::__Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.FormCliente.TypeInference.CreateMudSwitch_8(__builder3, 126, 127, "Activo", 128, 
#nullable restore
#line 78 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                          Color.Success

#line default
#line hidden
#nullable disable
                    , 129, 
#nullable restore
#line 77 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                                   cliente.Estado

#line default
#line hidden
#nullable disable
                    , 130, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Estado = __value, cliente.Estado)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(131, "\r\n                    ");
                global::__Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.FormCliente.TypeInference.CreateValidationMessage_9(__builder2, 132, 133, 
#nullable restore
#line 80 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
                                              () => cliente.Estado

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n\r\n        ");
                __builder2.OpenElement(135, "button");
                __builder2.AddAttribute(136, "type", "submit");
                __builder2.AddAttribute(137, "class", "btn btn-block btn-success");
                __builder2.AddMarkupContent(138, "<i class=\"oi oi-check \"></i>\r\n            ");
                __builder2.OpenElement(139, "text");
                __builder2.AddAttribute(140, "style", "color:white");
#nullable restore
#line 87 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
__builder2.AddContent(141, TextBotonSubmit);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(143);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\ender\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Clientes\FormCliente.razor"
       
    [Parameter] public Cliente cliente { get; set; } = new Cliente();
    [Parameter] public string TextBotonSubmit { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public bool ocultarcedula { get; set; } = false;

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.FormCliente
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
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
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::System.Int32 __arg2, int __seq3, global::MudBlazor.Margin __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Lines", __arg2);
        __builder.AddAttribute(__seq3, "Margin", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSwitch_8<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Color __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudSwitch<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Color", __arg1);
        __builder.AddAttribute(__seq2, "Checked", __arg2);
        __builder.AddAttribute(__seq3, "CheckedChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
