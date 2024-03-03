using repasoString.Dtos;
using System.Collections.Generic;

namespace repasoString.Servicios
{
    internal class AgenciaImplementacion : AgenciaInterfaz
    {
        public void CrearPedidoParaProveedores(List<AgenciaDto> agenciaLista)
        {
            bool isContinuar = false;
            do
            {

                long id = nuevoId(agenciaLista);
                Console.WriteLine("Ingrese nombre producto");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese cantidad");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese fecha de entrega (dd-mm-yyyy)");
                DateTime fechaEntrega = Convert.ToDateTime(Console.ReadLine());

                AgenciaDto agenciaDto = new AgenciaDto(id, nombre, cantidad, fechaEntrega);
                agenciaLista.Add(agenciaDto);

                Console.WriteLine("desea continuar? y/n : )");
                char sn = Convert.ToChar(Console.ReadLine());
                if(sn == 'y')
                {
                    isContinuar = true;  
                }else if(sn == 'n')
                {
                    isContinuar = false;
                }

            }while(isContinuar);
        }

        private long nuevoId(List<AgenciaDto> agenciaLista)
        {
            long idcalcular;

            if(agenciaLista.Count > 0)
            {
                idcalcular = 1;
            }
            else
            {
                idcalcular = agenciaLista.Count + 1;
            }
            return idcalcular;
        }

        public void MostrarVentasDia(List<EmpleadoDto> empleadoLista)
        {
            if(empleadoLista.Count > 0)
            {
                foreach(EmpleadoDto empleado in empleadoLista)
                {
                    Console.WriteLine($"///////////////\n" +
                                      $"Id: {empleado.Id}\n" +
                                      $"venta: {empleado.Valor}\n" +
                                      $"Hora: {empleado.FchaFinActividad}\n" +
                                      $"///////////////");
                }

                OrganizarBurbuja(empleadoLista);
            }
        }

        private void OrganizarBurbuja(List<EmpleadoDto> empleadoLista)
        {
            int n = empleadoLista.Count;

            for(int i = 0; i < n -1; i++)
            {
                for (int j = 0; j < n -1 -i; j++)
                {
                    if (empleadoLista[j].Valor > empleadoLista[j + 1].Valor)
                    {
                        EmpleadoDto temp = empleadoLista[j];
                        empleadoLista[j] = empleadoLista[j + 1];
                        empleadoLista[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Ventas ordenadas:");
            foreach (EmpleadoDto empleado in empleadoLista)
            {
                Console.WriteLine($"///////////////\n" +
                                  $"Id: {empleado.Id}\n" +
                                  $"venta: {empleado.Valor}\n" +
                                  $"Hora: {empleado.FchaFinActividad}\n" +
                                  $"///////////////");
            }
        }
    }
}