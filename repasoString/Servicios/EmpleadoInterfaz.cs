using repasoString.Dtos;

namespace repasoString.Servicios
{  
    /// <summary>
    /// 
    /// </summary>
    internal interface EmpleadoInterfaz
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="empleadoLista"></param>
        void AgregarVenta(List<EmpleadoDto> empleadoLista);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="empleadoLista"></param>
        void CalculoTotalVentasDiario(List<EmpleadoDto> empleadoLista);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clienteLista"></param>
        void ValidarCliente(List<ClienteDto> clienteLista);
    }
}