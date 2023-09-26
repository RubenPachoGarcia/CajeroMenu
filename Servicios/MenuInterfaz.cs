using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBienvenida.Servicios
{
    /// <summary>
    /// Interfaz que corresponde a la funcionalidad de menu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que mostrara el mensaje de bienvenida
        /// 250923 - rpg
        /// </summary>
        public void mostrarMensajeBienvenida();

        /// <summary>
        /// Metodo que muestra y recoge la seleccion del usuario
        /// 260923 - rpg
        /// </summary>
        /// <returns>entero con la opcion seleccionada</returns>
        public int mostrarMenuYSeleccion();
    }
}
