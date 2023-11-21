using AplicacionDarDeAlta.Dtos;

namespace AplicacionDarDeAlta.Sevicios
{
    internal interface ClienteInterfaz
    {
        /// <summary>
        /// interfaz que contiene las implementaciones de Cliente
        /// <author>201123 - awb</author>
        /// </summary>

        //Metodo darAltaCliente
        public void darAltacliente(List<ClientesDto> listaAntigua);


    }
}
