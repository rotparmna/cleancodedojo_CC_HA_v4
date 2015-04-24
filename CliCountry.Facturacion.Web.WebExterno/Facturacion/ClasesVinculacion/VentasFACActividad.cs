using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CliCountry.Facturacion.Web.WebExterno.Facturacion.ClasesVinculacion
{
    public class VentasFACActividad
    {
        private VentasFACActividad() {}
        public static VentasFACActividad Instancia = new VentasFACActividad();
        /// <summary>
        /// Método para controlar las ventas seleccionadas de la grilla de ventas.
        /// </summary>
        /// <returns>Lista de Ventas Seleccionadas.</returns>
        public List<int> ObtenerVentasMarcadas(IEnumerable<GridViewRow> filasGrilla)
        {
            var ventasMarcadas = from
                                     ventas in filasGrilla
                                 where
                                     (ventas.FindControl("chkFacturar") as CheckBox).Checked
                                 select
                                     Convert.ToInt32(ventas.Cells[2].Text);

            return ventasMarcadas.ToList();
        }


        /// <summary>
        /// Metodo para controlar las ventas Seleccionadas.
        /// </summary>
        /// <returns>Lista de Ventas No Seleccionadas.</returns>
        /// <remarks>
        /// Autor: Dario Fernando Preciado Barboza - INTERGRUPO\Dpreciado
        /// FechaDeCreacion: 03/07/2013
        /// UltimaModificacionPor: (Nombre del Autor de la modificación - Usuario del dominio)
        /// FechaDeUltimaModificacion: (dd/MM/yyyy)
        /// EncargadoSoporte: (Nombre del Autor - Usuario del dominio)
        /// Descripción: Descripción detallada del metodo, procure especificar todo el metodo aqui.
        /// </remarks>
        public List<int> ObtenerVentasNoMarcadas(IEnumerable<GridViewRow> filasGrilla)
        {
            var ventasMarcadas = from
                                     ventas in filasGrilla
                                 where
                                     (ventas.FindControl("chkFacturar") as CheckBox).Checked == false
                                 select
                                     Convert.ToInt32(ventas.Cells[2].Text);

            return ventasMarcadas.ToList();
        }


    }
}