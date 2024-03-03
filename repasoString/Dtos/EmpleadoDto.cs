using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoString.Dtos
{
    /// <summary>
    /// 
    /// </summary>
    internal class EmpleadoDto
    {
        long id;
        decimal valor = 0.0000m;
        DateTime fchaFinActividad = DateTime.Now;
        String horaCompleta = DateTime.Now.ToString("HH:mm:ss");


        public EmpleadoDto() { }
        public EmpleadoDto(long id, decimal valor, DateTime fchaFinActividad, string horaCompleta)
        {
            this.id = id;
            this.valor = valor;
            this.fchaFinActividad = fchaFinActividad;
            this.horaCompleta = horaCompleta;
        }

        public long Id { get => id; set => id = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public DateTime FchaFinActividad { get => fchaFinActividad; set => fchaFinActividad = value; }
        public string HoraCompleta { get => horaCompleta; set => horaCompleta = value; }
    }
}
