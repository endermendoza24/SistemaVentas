#pragma checksum "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f6ea71f84645e41ca3db2f2e569cb180b723a91"
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
#line 1 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lista-clientes")]
    public partial class ListaCliente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex position-sticky justify-content-between");
            __builder.AddAttribute(2, "b-phqimgj4wb");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "btn-group mr-2");
            __builder.AddAttribute(5, "b-phqimgj4wb");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                          CrearCliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "class", "btn btn-success");
            __builder.AddAttribute(9, "b-phqimgj4wb");
            __builder.AddMarkupContent(10, "<i class=\"oi oi-plus\" b-phqimgj4wb></i> Agregar cliente");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "input-group");
            __builder.AddAttribute(14, "style", "width:60%");
            __builder.AddAttribute(15, "b-phqimgj4wb");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "placeholder", "Nombre del cliente");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                                                                        NombreFiltro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NombreFiltro = __value, NombreFiltro));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(22, "b-phqimgj4wb");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "input-group-append");
            __builder.AddAttribute(26, "b-phqimgj4wb");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                              Filtrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "b-phqimgj4wb");
            __builder.AddMarkupContent(32, "<i class=\"oi oi-magnifying-glass\" b-phqimgj4wb></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                              Limpiar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "class", "btn btn-danger");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "b-phqimgj4wb");
            __builder.AddMarkupContent(39, "<i class=\"oi oi-delete\" b-phqimgj4wb></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "d-flex justify-content-between mt-2 mb-2");
            __builder.AddAttribute(43, "b-phqimgj4wb");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "btn-group");
            __builder.AddAttribute(46, "b-phqimgj4wb");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                          MostrarTodos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "style", "background:none; border: none");
            __builder.AddAttribute(50, "b-phqimgj4wb");
            __builder.AddMarkupContent(51, "<b b-phqimgj4wb>Ver todos</b>");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                          MostrarDeudores

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "style", "background:none; border: none");
            __builder.AddAttribute(56, "b-phqimgj4wb");
            __builder.AddMarkupContent(57, "<b b-phqimgj4wb>Sólo deudores</b>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n    ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "btn-group");
            __builder.AddAttribute(61, "b-phqimgj4wb");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                          CambiarVista

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "style", "background:none; border: none");
            __builder.AddAttribute(65, "b-phqimgj4wb");
            __builder.AddMarkupContent(66, "<b b-phqimgj4wb>Cambiar vista</b>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
 if (clientes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(67, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\" b-phqimgj4wb><div class=\"spinner-grow text-success\" role=\"status\" b-phqimgj4wb><span class=\"sr-only\" b-phqimgj4wb>Cargando...</span></div></div>");
#nullable restore
#line 45 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
}
else if (clientes.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\" b-phqimgj4wb><text b-phqimgj4wb>No se encontraron clientes.</text></div>");
#nullable restore
#line 51 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "card-columns");
            __builder.AddAttribute(71, "hidden", 
#nullable restore
#line 54 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                       card

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(72, "b-phqimgj4wb");
#nullable restore
#line 55 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
         foreach (var cliente in clientes)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(73, "a");
            __builder.AddAttribute(74, "href", "/editar-cliente/" + (
#nullable restore
#line 57 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                      cliente.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "style", "color: inherit");
            __builder.AddAttribute(76, "b-phqimgj4wb");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "card");
            __builder.AddAttribute(79, "b-phqimgj4wb");
#nullable restore
#line 59 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                     if (cliente.Sexo == Cliente.Sexos.Masculino)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(80, "<img class=\"card-img-top\" src=\"img/masculino.png\" alt=\"Cliente\" b-phqimgj4wb>");
#nullable restore
#line 62 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                    }
                    else if (cliente.Sexo == Cliente.Sexos.Femenino)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(81, "<img class=\"card-img-top\" src=\"img/femenino.png\" alt=\"Cliente\" b-phqimgj4wb>");
#nullable restore
#line 66 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(82, "<img class=\"card-img-top\" src=\"img/noimage.png\" alt=\"Cliente\" b-phqimgj4wb>");
#nullable restore
#line 70 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "card-body");
            __builder.AddAttribute(85, "b-phqimgj4wb");
            __builder.OpenElement(86, "h5");
            __builder.AddAttribute(87, "class", "card-title");
            __builder.AddAttribute(88, "b-phqimgj4wb");
            __builder.OpenElement(89, "b");
            __builder.AddAttribute(90, "b-phqimgj4wb");
            __builder.AddContent(91, 
#nullable restore
#line 73 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                cliente.NombreyApellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                        ");
            __builder.OpenElement(93, "p");
            __builder.AddAttribute(94, "class", "card-text");
            __builder.AddAttribute(95, "b-phqimgj4wb");
            __builder.AddMarkupContent(96, "\r\n                            DNI: ");
            __builder.AddContent(97, 
#nullable restore
#line 76 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                  cliente.Dni

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(98, "\r\n                            <br b-phqimgj4wb> ");
            __builder.AddContent(99, 
#nullable restore
#line 77 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                    cliente.Dirección

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(100, " - (");
            __builder.AddContent(101, 
#nullable restore
#line 77 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                                          cliente.Teléfono

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(102, ")\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                        ");
            __builder.OpenElement(104, "h5");
            __builder.AddAttribute(105, "class", "card-text text-right");
            __builder.AddAttribute(106, "b-phqimgj4wb");
            __builder.OpenElement(107, "b");
            __builder.AddAttribute(108, "b-phqimgj4wb");
            __builder.AddContent(109, "DEUDA: $");
            __builder.AddContent(110, 
#nullable restore
#line 80 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                        cliente.Saldo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(111, "table");
            __builder.AddAttribute(112, "class", "table table-hover");
            __builder.AddAttribute(113, "hidden", 
#nullable restore
#line 88 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                              lista

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(114, "b-phqimgj4wb");
            __builder.AddMarkupContent(115, @"<thead class=""thead-dark"" b-phqimgj4wb><tr b-phqimgj4wb><th b-phqimgj4wb></th>
                <th b-phqimgj4wb>Nombre y Apellido</th>
                <th b-phqimgj4wb>Dni</th>
                <th b-phqimgj4wb>Sexo</th>
                <th b-phqimgj4wb>Dirección</th>
                <th b-phqimgj4wb>Teléfono</th>
                <th b-phqimgj4wb>Saldo</th></tr></thead>
        ");
            __builder.OpenElement(116, "tbody");
            __builder.AddAttribute(117, "b-phqimgj4wb");
            __Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.ListaCliente.TypeInference.CreateVirtualize_0(__builder, 118, 119, 
#nullable restore
#line 101 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                clientes

#line default
#line hidden
#nullable disable
            , 120, (cliente) => (__builder2) => {
                __builder2.OpenElement(121, "tr");
                __builder2.AddAttribute(122, "b-phqimgj4wb");
                __builder2.SetKey(
#nullable restore
#line 102 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                          cliente.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(123, "td");
                __builder2.AddAttribute(124, "b-phqimgj4wb");
                __builder2.OpenElement(125, "a");
                __builder2.AddAttribute(126, "href", "/editar-cliente/" + (
#nullable restore
#line 103 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                                  cliente.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(127, "style", "color:white");
                __builder2.AddAttribute(128, "class", "btn btn-sm btn-primary");
                __builder2.AddAttribute(129, "b-phqimgj4wb");
                __builder2.AddMarkupContent(130, "<i class=\"oi oi-eye\" b-phqimgj4wb></i> Ver");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n                    ");
                __builder2.OpenElement(132, "td");
                __builder2.AddAttribute(133, "b-phqimgj4wb");
                __builder2.OpenElement(134, "b");
                __builder2.AddAttribute(135, "b-phqimgj4wb");
                __builder2.AddContent(136, 
#nullable restore
#line 104 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                            cliente.NombreyApellido

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\r\n                    ");
                __builder2.OpenElement(138, "td");
                __builder2.AddAttribute(139, "b-phqimgj4wb");
                __builder2.AddContent(140, 
#nullable restore
#line 105 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                         cliente.Dni

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n                    ");
                __builder2.OpenElement(142, "td");
                __builder2.AddAttribute(143, "b-phqimgj4wb");
#nullable restore
#line 107 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                         if (cliente.Sexo == Cliente.Sexos.Masculino)
                        {
                            

#line default
#line hidden
#nullable disable
                __builder2.AddContent(144, "M");
#nullable restore
#line 109 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                          
                        }
                        else if (cliente.Sexo == Cliente.Sexos.Femenino)
                        {
                            

#line default
#line hidden
#nullable disable
                __builder2.AddContent(145, "F");
#nullable restore
#line 113 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                          
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
                __builder2.AddContent(146, "N/E");
#nullable restore
#line 117 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                            
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n                    ");
                __builder2.OpenElement(148, "td");
                __builder2.AddAttribute(149, "b-phqimgj4wb");
                __builder2.AddContent(150, 
#nullable restore
#line 120 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                         cliente.Dirección

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\r\n                    ");
                __builder2.OpenElement(152, "td");
                __builder2.AddAttribute(153, "b-phqimgj4wb");
                __builder2.AddContent(154, 
#nullable restore
#line 121 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                         cliente.Teléfono

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 123 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                     if (cliente.Saldo > limitedeuda)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(155, "td");
                __builder2.AddAttribute(156, "style", "color:darkred;");
                __builder2.AddAttribute(157, "b-phqimgj4wb");
                __builder2.OpenElement(158, "b");
                __builder2.AddAttribute(159, "b-phqimgj4wb");
                __builder2.AddContent(160, "$");
                __builder2.AddContent(161, 
#nullable restore
#line 126 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                                 cliente.Saldo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 128 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(162, "td");
                __builder2.AddAttribute(163, "b-phqimgj4wb");
                __builder2.AddMarkupContent(164, "\r\n                            $");
                __builder2.AddContent(165, 
#nullable restore
#line 132 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                              cliente.Saldo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 134 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 139 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 140 "C:\Users\Endersson\source\repos\SistemaVentasCaprichos\SistemaVentasCaprichos\Client\Pages\Clientes\ListaCliente.razor"
       
    public List<Cliente> clientes { get; set; } //muestra todos los clientes

    private string NombreFiltro = String.Empty; //filtros

    protected bool lista = true;
    protected bool card = false;

    public int limitedeuda = 1000;

    protected override async Task OnInitializedAsync()
    {
        await CargarClientes();
    }

    async Task CargarClientes()
    {
        var httpResponse = await Http.GetAsync($"api/clientes/filtro?nombre={NombreFiltro}");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            clientes = JsonSerializer.Deserialize<List<Cliente>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    void CrearCliente()
    {
        NavigationManager.NavigateTo("crear-cliente");
    }

    void CambiarVista()
    {
        lista = !lista;
        card = !card;
    }

    private async Task Filtrar()
    {
        await CargarClientes();
    }

    private async Task Limpiar()
    {
        NombreFiltro = string.Empty;
        await CargarClientes();
    }

    void MostrarDeudores()
    {
        clientes = clientes.Where(x => x.Saldo > limitedeuda).OrderByDescending(x => x.Saldo).ToList();
    }

    async Task MostrarTodos()
    {
        await CargarClientes();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.SistemaVentasCaprichos.Client.Pages.Clientes.ListaCliente
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateVirtualize_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.ICollection<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
