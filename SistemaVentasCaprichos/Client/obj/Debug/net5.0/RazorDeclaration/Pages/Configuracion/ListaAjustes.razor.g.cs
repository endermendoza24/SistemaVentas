// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SistemaVentasCaprichos.Client.Pages.Configuracion
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using SistemaVentasCaprichos.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lista-ajustes")]
    public partial class ListaAjustes : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "c:\Users\Anderson\OneDrive\Documentos\SistemaVentas\SistemaVentasCaprichos\Client\Pages\Configuracion\ListaAjustes.razor"
           
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
#pragma warning restore 1591
