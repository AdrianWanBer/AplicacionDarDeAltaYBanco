using AplicacionDarDeAlta.Dtos;
using AplicacionDarDeAlta.Sevicios;

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

            Console.WriteLine("Introduzca la edad: ");
            nuevoCliente.EdadCliente = Convert.ToInt32(Console.ReadLine());

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

        public void buscarCliente()
        {

        }


        public void borrarClientes(List<ClientesDto> listaAntigua)
        {
            MenuInterfaz mi = new MenuImplementacion();
            string dniABuscar = mi.pedirDni();

            //Posicion
            /*
            int i;
            bool aBorrar = false;
            for ( i = 0 ; i < listaAntigua.Count() ; i++ )
            {
                if (listaAntigua[i].DniCliente.Equals(dniABuscar))
                {
                    aBorrar = true;
                    break;
                }
            }
            if (aBorrar)
            {
                    listaAntigua.RemoveAt(i);
            } else
            {
            Console.WriteLine("El dni no existe");
            }
            */


            //Objeto Especifico

            ClientesDto clienteABorrar = new ClientesDto();
            foreach (ClientesDto cliente in listaAntigua)
            {
                if (cliente.DniCliente.Equals(dniABuscar))
                {
                    clienteABorrar = cliente;
                    break;
                }
            }
            listaAntigua.Remove(clienteABorrar);


        }

        MenuInterfaz mi = new MenuImplementacion();

        public void ordenarEdad(List<ClientesDto> listaAntigua)
        {

            int edades = listaAntigua.Count;

            // // Ordena la lista por edad usando el algoritmo de Burbuja
            if (listaAntigua.Count >= 3)
            {
                // Bucle anidado para recorrer toda la lista
                for (int filas = 0; filas < listaAntigua.Count; filas++)
                {
                    for (int columnas = 0; columnas < listaAntigua.Count - 1 - filas; columnas++)
                    {
                        // Intercambia las posiciones entre clientes dependiendo de la edad que tengan
                        if (listaAntigua[columnas + 1].EdadCliente > listaAntigua[columnas].EdadCliente)
                        {
                            int aux = listaAntigua[columnas + 1].EdadCliente;
                            listaAntigua[columnas + 1].EdadCliente = listaAntigua[columnas].EdadCliente;
                            listaAntigua[columnas].EdadCliente = aux;


                        }

                    }
                }
                Console.WriteLine("Estos son los clientes ordenados de forma descendente");

                // Muestra la lista de clientes ordenada
                foreach (ClientesDto cliente in listaAntigua)
                {
                    Console.WriteLine(cliente.ToString());
                }

            }
            else
            {
                Console.WriteLine("Debe añadir minimo 3 usuarios para poder ordenarlos");
            }

        }

    }
    }
