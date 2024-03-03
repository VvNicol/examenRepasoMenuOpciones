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
    internal interface MenuInterfaz
    {   
        /// <summary>
          /// 
         /// </summary>
        void MenuAgencia();
        /// <summary>
        /// 
        /// </summary>
        void MenuCliente();

        /// <summary>
        /// 
        /// </summary>
        void MenuEmpleado();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int MenuPrincipal();
    }
}
