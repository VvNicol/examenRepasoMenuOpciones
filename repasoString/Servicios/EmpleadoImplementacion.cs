using repasoString.Dtos;

namespace repasoString.Servicios
{
    /// <summary>
    /// 
    /// </summary>
    internal class EmpleadoImplementacion : EmpleadoInterfaz
    {
        public void AgregarVenta(List<EmpleadoDto> empleadoLista)
        {
            long idVenta = nuevoId(empleadoLista);

            Console.WriteLine("Ingrese el valor de la venta: ");
            decimal venta = decimal.Parse(Console.ReadLine());

            DateTime fchaVenta = DateTime.Now;

            String horaCompra = fchaVenta.ToString("HH:mm:ss");

            EmpleadoDto empleado = new EmpleadoDto( idVenta,venta,fchaVenta,horaCompra);
            empleadoLista.Add(empleado);
        }

        private long nuevoId(List<EmpleadoDto> empleadoLista)
        {
            long nuevoId;
            int tamanioLista = empleadoLista.Count();

            if(empleadoLista.Count == 0)
            {
                nuevoId = 1;
            }else {

                nuevoId = tamanioLista + 1;

            }
            return nuevoId;
        }

        public void CalculoTotalVentasDiario(List<EmpleadoDto> empleadoLista)
        {
            Console.WriteLine("Ingrese una fecha (formato dd-mm-yyy): ");
            DateTime fcha = Convert.ToDateTime(Console.ReadLine());

            decimal totalVentasDiaro = 0;
            TimeSpan diferenciaDeTiempo = TimeSpan.Zero;

            foreach (EmpleadoDto venta in empleadoLista)
            {

                if (venta.FchaFinActividad.Date == fcha.Date)
                {
                   
                   decimal numero = venta.Valor;
                   totalVentasDiaro += numero;
                   diferenciaDeTiempo = TimeSpan.Parse(venta.HoraCompleta) - diferenciaDeTiempo;

                }
            }

            Console.WriteLine($"Total ventas del dia {fcha.ToShortDateString()} es : {totalVentasDiaro} ");
            Console.WriteLine($"Minutos desde la primera hasta la última compra: {diferenciaDeTiempo.Hours} horas, {diferenciaDeTiempo.Minutes} minutos y  {diferenciaDeTiempo.Seconds} segundos");
        }

        public void ValidarCliente(List<ClienteDto> clienteLista)
        {
            if(clienteLista.Count() > 0)
            {
                foreach (ClienteDto cliente in clienteLista)
                {
                    Console.WriteLine(  $"///////////////\n" +
                                        $"dni : {cliente.DniCl}\n" +
                                        $"nombre : {cliente.NombreCl} {cliente.Apellido1Cl} {cliente.Apellido2Cl}\n" +
                                        $"///////////////");
                }


                Console.WriteLine("Ingrese dni a validar");
                string dniValidar = Console.ReadLine();

                foreach(ClienteDto cliente in clienteLista)
                {
                    if (cliente.DniCl.Equals(dniValidar))
                    {
                        cliente.IsValido = true;
                    }
                }
            }
        }
    }
}