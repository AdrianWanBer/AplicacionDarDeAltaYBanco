using AplicacionDarDeAlta.Dtos;

namespace AplicacionDarDeAlta.Sevicios
{
    /// <summary>
    /// Implementacion que se encarga de la logica de la Cuenta Bancari
    /// </summary>
    internal class CuentaBancariaImplementacion : CuentaBancariaInterfaz
    {
        /// <summary>
        /// Metodo que añade la cuenta a la lista
        /// <author>211123 - awb</author>
        /// </summary>
        /// <param name="listaAntiguaBanco"></param>
        public void asignarCuentaBancaria(List<CuentasBancariasDto> listaAntiguaBanco)
        {
            CuentasBancariasDto cuentaBancaria = crearCuenta();
            listaAntiguaBanco.Add(cuentaBancaria);
        }

        /// <summary>
        /// Metodo que se encarga de crear la cuenta bancaria nueva
        /// <author>211123 - awb</author>
        /// </summary>
        /// <returns></returns>
        private CuentasBancariasDto crearCuenta()
        {
            CuentasBancariasDto cuentaNueva = new CuentasBancariasDto();
            Console.WriteLine("Introduce el id de la cuenta Bancaria: ");
            cuentaNueva.IdCuentaBancaria = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el isBan: ");
            cuentaNueva.IsBan = Console.ReadLine();
            Console.WriteLine("Introduce la fecha de baj: ");
            cuentaNueva.FchBaja = Console.ReadLine();
            Console.WriteLine("Introduce la id del usuario al que pertenece la cuenta bancaria: ");
            cuentaNueva.IdClienteDeLaCuenta = Convert.ToInt64(Console.ReadLine());

            return cuentaNueva;

        }
    }
}
