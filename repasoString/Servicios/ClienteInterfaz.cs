using repasoString.Dtos;

namespace repasoString.Servicios
{
    internal interface ClienteInterfaz
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clienteLista"></param>
        void IniciarSesion(List<ClienteDto> clienteLista);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clienteLista"></param>
        void Registrarse(List<ClienteDto> clienteLista);
    }
}