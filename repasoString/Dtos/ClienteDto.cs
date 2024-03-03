using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoString.Dtos
{
    internal class ClienteDto
    {
        long id;
        string nombreCl = "aaaaa";
        string dniCl = "aaaaa";
        string apellido1Cl = "aaaaa";
        string apellido2Cl = "aaaaa";
        string nombrecompleto = "aaaaa";
        string email = "aaaaa";
        string contrasenia = "aaaaa";
        int edad = 11111;
        DateTime fchaNacimeinto = DateTime.Now;
        bool isValido = false;

        public ClienteDto(long id, string nombrecompleto, string dniCl, string email, string contrasenia, int edad, DateTime fchaNacimeinto)
        {
            this.id = id;
            string[] nombre = nombrecompleto.Split(" ");
            this.nombreCl = nombre[0];
            this.apellido1Cl = nombre[1];
            this.apellido2Cl = nombre[2];
            this.dniCl = dniCl;
            this.email = email;
            this.contrasenia = contrasenia;
            this.edad = edad;
            this.fchaNacimeinto = fchaNacimeinto;
        }

        public ClienteDto() { }
        public long Id { get => id; set => id = value; }
        public string NombreCl { get => nombreCl; set => nombreCl = value; }
        public string Apellido1Cl { get => apellido1Cl; set => apellido1Cl = value; }
        public string Apellido2Cl { get => apellido2Cl; set => apellido2Cl = value; }
        public string Nombrecompleto { get => nombrecompleto; set => nombrecompleto = value; }
        public string Email { get => email; set => email = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public int Edad { get => edad; set => edad = value; }
        public DateTime FchaNacimeinto { get => fchaNacimeinto; set => fchaNacimeinto = value; }
        public bool IsValido { get => isValido; set => isValido = value; }
        public string DniCl { get => dniCl; set => dniCl = value; }
    }
}
