using repasoString.Servicios;
using System.Reflection.Metadata;

namespace repasoString.Controlador
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static string logFilePath = "log.txt";
        public static StreamWriter logStreamWriter;

        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();

            logStreamWriter = new StreamWriter(logFilePath); 


            int opcionSeleccionada;
            bool isCerrado = false;

            RegistrarLog("Menú Principal ");

            do
            {
                opcionSeleccionada = mi.MenuPrincipal();
                switch (opcionSeleccionada)
                {
                    case 0:
                        isCerrado = true;
                        Console.WriteLine("Cerrado");

                        RegistrarLog("Opcion seleccionada 0 - cerrar menu");

                        break;
                    case 1:
                        mi.MenuEmpleado();
                        RegistrarLog("Opcion seleccionada 1 - Menu empleado");

                        break;

                    case 2:
                        mi.MenuAgencia();
                        RegistrarLog("Opcion seleccionada 2 - Menu agencia");

                        break;

                    case 3:
                        mi.MenuCliente();

                        RegistrarLog("Opcion seleccionada 3 - Menu cliente");

                        break;

                    default:

                        RegistrarLog("Opción inválida seleccionada");

                        Console.WriteLine("La opcion no existe");
                        break;
                }

            } while (!isCerrado);

            logStreamWriter.Close();

        }
        private static void RegistrarLog(string mensaje)
        {
            try
            {
               logStreamWriter.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + mensaje);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al escribir en el archivo de log: " + ex.Message);
            }
        }
    }

}
