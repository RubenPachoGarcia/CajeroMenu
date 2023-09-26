using ClaseBienvenida.Servicios;

namespace ClaseBienvenida
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicacion
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo de entrada a la aplicacion
        /// Contiene el procedimiento o el flujo de la aplicacion
        /// 250923 - rpg
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Llamada al metodo que imprime el mensaje por consola
            MenuInterfaz menuInterfaz = new MenuImplementacion();

            menuInterfaz.mostrarMensajeBienvenida();

            //Variable que controla la entrada y salida del bucle while
            bool cerrarMenu = false;
            //Esto contiene la opcion del usuario
            int opcionSeleccionada;

            //Desde la primera iteracion debe cumplirse la condicion iteracion
            while (!cerrarMenu)
            {
                opcionSeleccionada = menuInterfaz.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccionada);
                
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta la opcion 0.");
                        cerrarMenu = true;
                        break;
                    
                    case 1:
                        Console.WriteLine("[INFO] - Se ejecuta la opcion 1.");
                        break;
                    
                    case 2:
                        Console.WriteLine("[INFO] - Se ejecuta la opcion 2.");
                        break;
                    
                    case 3:
                        Console.WriteLine("[INFO] - Se ejecuta la opcion 3.");
                        break;
                    
                    case 4:
                        Console.WriteLine("[INFO] - Se ejecuta la opcion 4.");
                        break;
                    
                    case 5:
                        Console.WriteLine("[INFO] - Se ejecuta la opcion 5.");
                        break;
                    
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;
                }
            }

        }
    }
}
       