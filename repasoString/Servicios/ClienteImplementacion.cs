using repasoString.Dtos;

namespace repasoString.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {
        public void Registrarse(List<ClienteDto> clienteLista)
        {
            long id = nuevoId(clienteLista);
            Console.WriteLine("Ingrese nombre completo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese dni");
            string dni = Console.ReadLine();
            Console.WriteLine("Ingrese email");
            string email = Console.ReadLine();
            Console.WriteLine("Ingrese contrasenia");
            string contrasenia = Console.ReadLine();
            Console.WriteLine("Ingrese edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese fecha de nacimiento (formato dd-mm-yyyy)");
            DateTime fchaNacimeinto = Convert.ToDateTime(Console.ReadLine());

            ClienteDto cliente = new ClienteDto( id, nombre, dni, email, contrasenia, edad, fchaNacimeinto);
            clienteLista.Add(cliente);
        }

        private long nuevoId(List<ClienteDto> clienteLista)
        {
            long calcularId;
            if(clienteLista.Count > 0)
            {
                calcularId = 1;
            }
            else
            {
                calcularId = clienteLista.Count() +1;
            }
            return calcularId;
        }

        public void IniciarSesion (List<ClienteDto> clienteLista)
        {
            if (clienteLista.Count() > 0)
            {
                Console.WriteLine("Ingrese email");
                string emailVerificar = Console.ReadLine();

                Console.WriteLine("Ingrese contrasenia");
                string contraseniaVerificar = Console.ReadLine();

                foreach(ClienteDto cliente in clienteLista)
                {
                    if(cliente.Email.Equals(emailVerificar) && cliente.Contrasenia.Equals(contraseniaVerificar) && cliente.IsValido == true)
                    {
                        Console.WriteLine("Ha iniciado sesion");
                    }
                    else
                    {
                        Console.WriteLine("Email o contrasenia incorrecta");
                        Console.WriteLine("verifique si usted esta validado");
                    }
                }

            }
        }
    }
}