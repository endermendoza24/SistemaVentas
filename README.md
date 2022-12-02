# Sistema web transaccional

Sistema hecho para optar al título de ingeniería en sistemas de información, por la UNAN - Managua, FAREM - Carazo.

Este sistema está hecho utilizando: Blazor WebAssembly, .NetCore 5, EntityFramework, MudBlazor, LINQ, SQLServer.

Elaborado por:

1. Oswald Armando Balladares Ruiz.
2. Greyvin Josué Mora Zúniga.
3. Endersson Alonso Mendoza Muñoz.
   **¿Cómo abrir el proyecto?**

4. Descargar y abrir el proyecto desde github, `git clone https://github.com/endermendoza24/SistemaVentas.git`
5. Abrir la solución y restaurar paquetes nugets desde la solución.
6. Abrir la consola del manejador de paquetes y agregar el comando: `Add-Migration *NombreMigracion*`, posterior a eso ejecutar el comando `Update-Database`.
7. Ejecutar el proyecto
8. Registrar los datos del módulo de configuración
9. Registrarse como usuario.
10. Iniciar sesión

> 26 de octubre de 2022, se agregó tabla de configuración, además de

> algunos ajustes de diseño.
> 30 de octubre, agregados cambios con la lógica de proveedor

> también algunos cambios en la fórmula de total, subtotal e IVA. Además de que se trabajó en el login y registro de usuario dándole un mejor aspecto.

> 02 de noviembre, agregadas todas las validaciones a través de modelo, también a través del modelo se agregaron las restricciones de base de datos.

> Se ha resuelto la lógica de dada de baja de producto.

> 03 de noviembre, se mejoró el diseño, además de terminar la lógica de dada de baja. Para el diseño nos basamos en este tutorial:

> https://code-maze.com/creating-blazor-material-navigation-menu/

> 3 noviembre de 2022, Agregado modo oscuro en la aplicación, así como también se agrego una nueva barra de navegación, usando MudBlazor.

> 04 de noviembre se agrego funcion que permite exportar a excel las tablas de catálogos del sistema, únicamente se ha implementado en los módulos de catálogos.

> Se mejoraron algunos detalles de experiencia de usuario, en la barra de navegación.
> 16 de noviembre de 2022, agregado un componente que permite ver un dashboard de reportes elaborados con PowerBi

> 18-20 de noviembre de 2022, ya funciona la lógica de roles en el sistema, actualmente funcinando con dos roles, que son 'administrador' y 'empleado', cada rol tiene ciertos módulos que le corresponde solo a uno de ellos, aunque aún no funciona a la perfección si lo hace de muy buena manera, cumpliendo básicamente con lo que debería de hacer.
> 24 de noviembre, mejoras en el diseño del login
> 27 de noviembre, mejoras en diseño

> 01 de diciembre No hay muchos avances, se agregó una forma primitiva de egresos, aún falta el número de factura

## Lógica de dada de bajas

La lógica de dada de baja está en loc controladores de cada catálogo, se le debe añadir una sentencia WHERE en el método GET, en esa sentencia se debe de especificar que solo muestre los registros cuyo estado sea igual a true, esto se hizo de la siguiente manera:

    [HttpGet]
    public async Task<ActionResult<List<Tallas>>> Get()
    {
    return await context.Tallas
    .Where(x => x.Estado == true).ToListAsync();
    }

En donde con simplemente añadirle la sentencia WHERE el sistema determina no mostrar los registros que sean FALSE, además de tampoco mostrarlos en los registros con el que esa tabla tenga relación.

## Reportes en PowerBi

La manera en que se hicieron los reportes resulta ser muy fácil, simplemente consiste en:

- Hacer el reporte en PowerBi.
- Conectar PowerBi desktop con PowerBi en la nube a través de OnDataPremises.
- Subir el reporte.
- Obtener el id del reporte que se encuentra al momento de ver el reporte en el navegador.
- A través de una etiqueta Iframe de html mostrar ese reporte en la página principal del sistema.
  Una observación importante es que el reporte únicamente funciona en la computadora en la que fue hecho, esto debido a la naturaleza de OnDataPremises

<iframe src="https://app.powerbi.com/reportEmbed?reportId=8eebb4ca-050b-43c0-88c0-30c7bc248a91&autoAuth=true" frameborder="0" allowtransparency="true"> </iframe

## Cosas por hacer en el proyecto...

- [ ] Lógica de cambios/devolución - !urgente
- [x] Lógica de dada de baja de producto
- [x] Páginas donde solo se muestren los elementos que hayan sido dados de baja
- [x] Lógica de número de factura en ventas (Se usará el ID de la factura)
- [x] Reportes a través de Power BI
- [x] Mejoras en el área de logueo/deslogueo/registro.
- [x] Sistema de roles - !Urgente
- [x] Mejoras generales en el diseño y el aspecto visual.
- [x] Eliminar código innecesario.
- [x] Añadir tooltips y detalles de accesibilidad del usuario
- [x] Optimizar código de exportación a excel.
- [x] Mejorar modo oscuro, también reparar parte dañada del área de diseño del login.
- [x] Corregir ortografía.
- [ ] Reportes básicos
- [ ] Logo e imágenes.
- [ ] Reportes básicos
- [ ] Logo e imágenes.
- [ ] Mejorar login
- [ ] Lógica de apertura de caja
- [ ] Lógica de cierre de caja
- [ ] Mejoras generales en diseño
- [ ] Desactivar eliminación permanente
- [ ] Idea de Egresos hasta el momento
