using repasoString.Dtos;

namespace repasoString.Servicios
{
    /// <summary>
    /// 
    /// </summary>
    internal interface AgenciaInterfaz
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agenciaLista"></param>
        void CrearPedidoParaProveedores(List<AgenciaDto> agenciaLista);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="empleadoLista"></param>
        void MostrarVentasDia(List<EmpleadoDto> empleadoLista);
    }
}