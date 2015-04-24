using CliCountry.Facturacion.Web.WebExterno.Comun.Clases;
using CliCountry.SAHI.Dominio.Entidades.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CliCountry.Facturacion.Web.WebExterno.Facturacion.ClasesVinculacion
{
    public class VinculacionesFACActividad
    {
        private VinculacionesFACActividad() { }

        public static VinculacionesFACActividad Instancia = new VinculacionesFACActividad();
        /// <summary>
        /// Metodo para buscar vinculación persistidas en el ViewState.
        /// </summary>
        /// <param name="identificadorEntidad">Identificador del tercero.</param>
        /// <param name="ordenVinculacion">Orden de la vinculación.</param>
        /// <returns></returns>
        public Vinculacion BuscarVinculacion(int identificadorEntidad, int ordenVinculacion, List<Vinculacion> vinculacionesDeAtencion)
        {
            var vinculacion = from
                                  item in vinculacionesDeAtencion
                              where
                                  item.Tercero.Id == identificadorEntidad
                                  && item.Orden == ordenVinculacion
                              select
                                  item;

            return vinculacion.FirstOrDefault();
        }

         /// <summary>
        /// Metodo para Obtener la Vinculacion Seleccionada.
        /// </summary>
        /// <returns>Retorna Vinculacion.</returns>
        /// <remarks>
        /// Autor: Iván José Pimienta Serrano - INTERGRUPO\Ipimienta
        /// FechaDeCreacion: 17/04/2013
        /// UltimaModificacionPor: (Nombre del Autor de la modificación - Usuario del dominio)
        /// FechaDeUltimaModificacion: (dd/MM/yyyy)
        /// EncargadoSoporte: (Nombre del Autor - Usuario del dominio)
        /// Descripción: Descripción detallada del metodo, procure especificar todo el metodo aqui.
        /// </remarks>
        public Vinculacion ObtenerSeleccionada(IEnumerable<Vinculacion> VinculacionesDeAtencion, Vinculacion vinculacionSeleccionada)
        {
            var vinculacion = from
                                  item in VinculacionesDeAtencion
                              where
                                  item.Tercero.Id == vinculacionSeleccionada.Tercero.Id
                                  && item.Contrato.Id == vinculacionSeleccionada.Contrato.Id
                              select
                                  item;

            return vinculacion.FirstOrDefault();
        }


        /// <summary>
        /// Carga en el viewstate la vinculación seleccionada para modificación.
        /// </summary>
        /// <param name="identificadorEntidad">The id entidad.</param>
        /// <param name="identificadorContrato">The id contrato.</param>
        /// <param name="identificadorPlan">The id plan.</param>
        /// <returns>
        /// Retorna la vinculación seleccionada.
        /// </returns>
        /// <remarks>
        /// Autor: Iván José Pimienta Serrano - INTERGRUPO\Ipimienta
        /// FechaDeCreacion: 11/06/2013
        /// UltimaModificacionPor: (Nombre del Autor de la modificación - Usuario del dominio)
        /// FechaDeUltimaModificacion: (dd/MM/yyyy)
        /// EncargadoSoporte: (Nombre del Autor - Usuario del dominio)
        /// Descripción: Descripción detallada del metodo, procure especificar todo el metodo aqui.
        /// </remarks>
        public Vinculacion ObtenerVinculacionSeleccionada(int identificadorEntidad, int identificadorContrato, int identificadorPlan, string Atencion, IEnumerable<Vinculacion> VinculacionesDeAtencion)
        {
            var vinculacion = from
                                  item in VinculacionesDeAtencion
                              where
                                  item.IdAtencion == Convert.ToInt32(Atencion)
                                  && item.Tercero.Id == identificadorEntidad
                                  && item.Contrato.Id == identificadorContrato
                                  && item.Plan.Id == identificadorPlan
                              select
                                  item;

            return vinculacion.FirstOrDefault();
        }

        
    }
}