using AplicacionDarDeAlta.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDarDeAlta.Sevicios
{
    internal interface CuentaBancariaInterfaz
    {
        /// <summary>
        /// Interfaz que implementa los metodos de CuentasBancarias
        /// <author>201123 - awb</author>
        /// </summary>
        /// <param name="listaAntiguaBanco"></param>

        //Metodo que introducira la nueva cuenta en la lista
        public void asignarCuentaBancaria(List<CuentasBancariasDto> listaAntiguaBanco);


    }
}
