using AplicacionDarDeAlta.Dtos;
using AplicacionDarDeAlta.Sevicios;

namespace AplicacionDarDeAlta.Sevicios
{
    /// <summary>
    /// 
    /// </summary>
    internal interface ClienteInterfaz
    {
        /// <summary>
        /// interfaz que contiene las implementaciones de Cliente
        /// <author>201123 - awb</author>
        /// </summary>
        /// <param name="listaAntigua"></param>


        public void darAltacliente(List<ClientesDto> listaAntigua);
        /// <summary>
        /// Interfaz que contiene los metodos de borrarClientes
        /// <author>201123 - awb</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void borrarClientes(List<ClientesDto> listaAntigua);

        public void modificarCliente(List<ClientesDto> listaAntigua);

        public void ordenarEdad(List<ClientesDto> listaAntigua);

    }
}
