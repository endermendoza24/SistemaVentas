#pragma checksum "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "143a4a77ff5582deca95b0e7ea72a0ff8bfa327b"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasCaprichos.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/roles")]
    public partial class Roles : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "<label>Empleado</label>\r\n    ");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "class", "custom-select");
            __builder.AddAttribute(5, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor"
                    usuarioId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usuarioId = __value, usuarioId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "selected");
            __builder.AddAttribute(9, "disabled");
            __builder.AddContent(10, " Seleccione empleado");
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor"
         foreach (var usuario in usuarios)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", 
#nullable restore
#line 13 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor"
                            usuario.Id

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 13 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor"
__builder.AddContent(13, usuario.NombreyApellido);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.AddMarkupContent(15, "<label>Rol</label>\r\n    ");
            __builder.OpenElement(16, "select");
            __builder.AddAttribute(17, "class", "custom-select");
            __builder.AddAttribute(18, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor"
                    nombreRol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nombreRol = __value, nombreRol));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "selected");
            __builder.AddAttribute(22, "disabled");
            __builder.AddContent(23, " Seleccione rol");
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor"
         foreach (var rol in roles)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", 
#nullable restore
#line 21 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor"
                            rol.Name

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 21 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor"
__builder.AddContent(26, rol.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "btn-group btn-block my-2");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor"
                            () => AccionRol(nombreRol, usuarioId, true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddContent(33, " Asignar rol");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "btn-group btn-block");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor"
                            () => AccionRol(nombreRol, usuarioId, false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "class", "btn btn-danger");
            __builder.AddContent(40, " Eliminar rol");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Anderson\OneDrive\Desktop\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Roles.razor"
       
    private List<IdentityRole> roles = new List<IdentityRole>();
    private List<ApplicationUser> usuarios = new List<ApplicationUser>();

    private string nombreRol { get; set; }
    private string usuarioId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        roles = await Http.GetFromJsonAsync<List<IdentityRole>>($"api/roles/");
        usuarios = await Http.GetFromJsonAsync<List<ApplicationUser>>($"api/roles/usuarios");
    }

    async Task AccionRol(string nombreRol, string usuarioId, bool crear)
    {
        var mensaje = "";

        if (nombreRol != null && usuarioId != null)
        {
            if (crear == true)
            {
                mensaje = "¿Asignar rol?";
            }
            else
            {
                mensaje = "¿Eliminar rol?";
            }

            var confirmacion = await JS.InvokeAsync<bool>("confirmar", mensaje,
        $"Usuario: {usuarioId}. Rol:{nombreRol}", "question");
            if (confirmacion)
            {
                var rol = await Http.GetFromJsonAsync<IdentityRole>($"api/roles/rol/" + nombreRol);
                var respuesta = await Http.PostAsJsonAsync<IdentityRole>($"api/roles/{usuarioId}/{crear}", rol);

                if (respuesta.IsSuccessStatusCode && crear == true)
                {
                    await JS.InvokeVoidAsync("simple", "¡Éxito!", "Rol asignado", "success");
                }
                else if (respuesta.IsSuccessStatusCode && crear == false)
                {
                    await JS.InvokeVoidAsync("simple", "¡Éxito!", "Rol eliminado", "success");
                }
                else
                {
                    await JS.InvokeVoidAsync("simple", "Error", "No se pudo asignar rol", "error");
                }
            }
        }
        else
        {
            await JS.InvokeVoidAsync("simple", "Error", "Seleccione usuario y rol.", "error");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
