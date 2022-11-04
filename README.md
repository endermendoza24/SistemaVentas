
# Sistema web transaccional
*Sistema hecho para optar al título de ingeniería en sistemas de información, por la UNAN - Managua, FAREM - Carazo.
Este sistema está hecho utilizando: Blazor WebAssembly, .NetCore 5, EntityFramework, MudBlazor, LINQ, SQLServer.*

Elaborado por:

 1. Oswald Armando Balladares Ruiz.
 2. Greyvin Josué Mora Zúniga.
 3. Endersson Alonso Mendoza Muñoz.

**¿Cómo abrir el proyecto?**

 1. Descargar y abrir el  proyecto desde github, `git clone https://github.com/endermendoza24/SistemaVentas.git`
 2. Abrir la solución y restaurar paquetes nugets desde la solución.
 3. Abrir la consola del manejador de paquetes y agregar el comando: `Add-Migration *NombreMigracion*`, posterior a eso ejecutar el comando `Update-Database`.
 4. Ejecutar el proyecto
 5. Registrarse como usuario.
 6. Iniciar sesión

> 26 de octubre de 2022, se agregó tabla de configuración, además de
> algunos ajustes de diseño.

> 30 de octubre, agregados cambios con la lógica de proveedor
> también algunos cambios en la fórmula de total, subtotal e IVA. Además de que se trabajó en el login y registro de usuario dándole un mejor aspecto.

> 02 de noviembre, agregadas todas las validaciones a través de modelo, también a través del modelo se agregaron las restricciones de base de datos.
> Se ha resuelto la lógica de dada de baja de producto.
> 03 de noviembre, se mejoró el diseño, además de terminar la lógica de dada de baja. Para el diseño nos basamos en este tutorial: 
> https://code-maze.com/creating-blazor-material-navigation-menu/

## Lógica de dada de bajas
La lógica de dada de baja está en loc controladores de cada catálogo, se le debe añadir una sentencia WHERE en el método GET, en esa sentencia se debe de especificar que solo muestre los registros cuyo estado sea igual a true, esto se hizo de la siguiente manera:

     [HttpGet]
        public async Task<ActionResult<List<Tallas>>> Get()
        {
            return await context.Tallas
                 .Where(x => x.Estado == true)
                .ToListAsync();
        }
En donde con simplemente añadirle la sentencia WHERE  el sistema determina no mostrar los registros que sean FALSE, además de tampoco mostrarlos en los registros con el que esa tabla tenga relación.

## Cosas por hacer en el proyecto...

 - [ ] Lógica de cambios/devolución
 - [x] Lógica de dada de baja de producto
 - [ ] Páginas donde solo se muestren los elementos que hayan sido dados de baja
 - [x] Lógica de número de factura en ventas (Se usará el ID de la factura)
 - [ ] Reportes a través de Power BI
 - [x] Mejoras en el área de logueo/deslogueo/registro.
 - [ ] Sistema de roles
 - [ ] Mejoras generales en el diseño y el aspecto visual.
 - [ ] Eliminar código innecesario.
 - [x] Añadir tooltips y detalles de accesibilidad del usuario

~~Fecha aproximada de entrega: 25 de noviembre de 2022.~~
~~Fecha aproximada de la defensa: 02 de diciembre de 2022.~~

