using repasoString.Controlador;
using repasoString.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoString.Servicios
{
    /// <summary>
    /// 
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {

        List<EmpleadoDto> EmpleadoLista = new List<EmpleadoDto>();
        List<AgenciaDto> AgenciaLista = new List<AgenciaDto>();
        List<ClienteDto> ClienteLista = new List<ClienteDto>();

        

        public void MenuAgencia()
        {
            AgenciaInterfaz ai = new AgenciaImplementacion();

            RegistrarLog("Menú de agencia");


            int opcionSeleccionada = MenuMostrarAgencia();
                switch (opcionSeleccionada)
                {
                    case 0:

                         RegistrarLog("Opcion seleccionada 0 - Volver a menu principal");

                         break;
                    case 1:
                        ai.MostrarVentasDia(EmpleadoLista);

                        RegistrarLog("Opcion seleccionada 1 - Mostrar las ventas del dia");

                    break;

                    case 2:
                        ai.CrearPedidoParaProveedores(AgenciaLista);

                        RegistrarLog(" Opcion seleccionada 2 - Crear pedido para proveedores");

                    break;
                    default:

                         RegistrarLog("Opción inválida seleccionada");

                         Console.WriteLine("La opcion no existe");

                        break;
                }

        }

        private int MenuMostrarAgencia()
        {
            Console.WriteLine("------------");
            Console.WriteLine("Menu Agencia");
            Console.WriteLine("0. volver");
            Console.WriteLine("1. Mostrar ventas del dia");
            Console.WriteLine("2. crear pedido para proveedores");

            int opcionMenuE = int.Parse(Console.ReadLine());

            return opcionMenuE;
        }

        public void MenuEmpleado()
        {
            EmpleadoInterfaz ei = new EmpleadoImplementacion();

            RegistrarLog("Menú de Empleado");


            int opcionSeleccionada = MenuMostrarEmpleado();
                switch (opcionSeleccionada)
                {
                    case 0:

                    RegistrarLog("Opcion seleccionada 0 - Volver a menu principal");

                    break;
                    case 1:
                        ei.AgregarVenta(EmpleadoLista);
                        RegistrarLog("Opcion seleccionada 1 - Agregar ventas");


                    break;

                    case 2:
                        ei.CalculoTotalVentasDiario(EmpleadoLista);
                        RegistrarLog("Opcion seleccionada 2 - Calculo total de ventas diario");

                    break;
                case 3:
                        ei.ValidarCliente(ClienteLista);
                        RegistrarLog("Opcion seleccionada 3 - Validar cliente");

                    break;
                    default:

                         RegistrarLog("Opción inválida seleccionada");

                        Console.WriteLine("La opcion no existe");
                        break;
                }
        }

        private int MenuMostrarEmpleado()
        {
            Console.WriteLine("------------");
            Console.WriteLine("Menu Empleado");
            Console.WriteLine("0. volver");
            Console.WriteLine("1. agregar venta");
            Console.WriteLine("2. calculo total de ventas diaro");
            Console.WriteLine("3. verificar cliente");
  
            int opcionMenuE = int.Parse(Console.ReadLine());

            return opcionMenuE;
        }

        public int MenuPrincipal()
        {  
            Console.WriteLine("------------");
            Console.WriteLine("Menu Principal");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1. menu empleado");
            Console.WriteLine("2. menu agencia");
            Console.WriteLine("3. menu cliente");

            int opcionMenuP = int.Parse(Console.ReadLine());

            return opcionMenuP;
        }

        public void MenuCliente()
        {
            ClienteInterfaz ci = new ClienteImplementacion();
            RegistrarLog("Menú de cliente");


            int opcionSeleccionada = MenuMostrarCliente();
            switch (opcionSeleccionada)
            {
                case 0:

                    RegistrarLog("Opcion seleccionada 0 - Volver a menu principal");

                    break;
                case 1:

                    ci.Registrarse(ClienteLista);
                    RegistrarLog("Opcion seleccionada 1 - Registrarse");

                    break;

                case 2:
                    
                    ci.IniciarSesion(ClienteLista);
                    RegistrarLog("Opcion seleccionada 2 - IniciarSesion");

                    break;
                default:

                    RegistrarLog("Opción inválida seleccionada");

                    Console.WriteLine("La opcion no existe");
                    break;
            }

        }

        private int MenuMostrarCliente()
        {
            Console.WriteLine("------------");
            Console.WriteLine("Menu Cliente");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1. registrarse");
            Console.WriteLine("2. iniciar sesion (login)");

            int opcionMenuC = int.Parse(Console.ReadLine());

            return opcionMenuC;
        }

        private void RegistrarLog(string mensaje)
        {
            try
            {
                StreamWriter logStreamWriter = Program.logStreamWriter;

                logStreamWriter.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + mensaje);
                logStreamWriter.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al escribir en el archivo de log: " + ex.Message);
            }
        }
    }
}
