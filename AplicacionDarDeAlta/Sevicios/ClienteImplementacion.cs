using AplicacionDarDeAlta.Dtos;

namespace AplicacionDarDeAlta.Sevicios
{
    /// <summary>
    /// Implementacion que se encarga de la logica de los clientes
    /// <author>211123 - awb</author>
    /// </summary>
    internal class ClienteImplementacion : ClienteInterfaz
    {
        /// <summary>
        /// metodo que contiene el añadr el cliente a la lista
        /// <author>201123 - awb</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltacliente(List<ClientesDto> listaAntigua)
        {
            ClientesDto cliente = crearNuevoCliente();
            listaAntigua.Add(cliente);
        }
        /// <summary>
        /// Peticion de datos para la lista de clientes
        /// <author>201123 - awb</author>
        /// </summary>
        private ClientesDto crearNuevoCliente()
        {
            ClientesDto nuevoCliente = new ClientesDto();
            Console.WriteLine("Introduzca el id: ");
            nuevoCliente.idCliente = (Convert.ToInt64(Console.ReadLine()));

            Console.WriteLine("Introduzca el nombre: ");
            nuevoCliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("Introduzca el apellidos: ");
            nuevoCliente.ApellidosCLiente = Console.ReadLine();

            Console.WriteLine("Introduzca el dni: ");
            nuevoCliente.DniCliente = Console.ReadLine();

            Console.WriteLine("Introduzca el fecha de nacimiento: ");
            nuevoCliente.FechaDeNacimiento = Console.ReadLine();

            Console.WriteLine("Introduzca el email: ");
            nuevoCliente.EmailCliente = Console.ReadLine();

            Console.WriteLine("Introduzca el numero de telefono: ");
            nuevoCliente.TlfCliente = (Convert.ToInt64(Console.ReadLine()));

            Console.WriteLine("Introduzca el Fecha de alta: ");
            nuevoCliente.FecAltaCliente = Console.ReadLine();

            


            return nuevoCliente;
        }
    }
}
