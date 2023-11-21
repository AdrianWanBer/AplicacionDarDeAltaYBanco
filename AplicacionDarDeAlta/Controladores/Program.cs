using AplicacionDarDeAlta.Dtos;
using AplicacionDarDeAlta.Sevicios;
using System.Security.Cryptography;
//using AplicacionDarDeAlta.Dtos;

namespace AplicacionDarDeAlta
{
    class program
    {
        /// <summary>
        /// Metodo para la entrada de la palicacion
        /// <author>131123 - awb</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {

            //Creacion de objetos
            List<ClientesDto> listaClientes = new List<ClientesDto>();
            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz ci = new ClienteImplementacion();
            List<CuentasBancariasDto> ListaCuentasBancarias = new List<CuentasBancariasDto>();
            CuentaBancariaInterfaz cb = new CuentaBancariaImplementacion();


            //Variable que controla la apertura y cerrada del while
            bool cerrarMenu = false;

            ClientesDto cliente = new ClientesDto();


            //While que tendra todo el flujo del programa
            while (!cerrarMenu)
            {
                int seleccionUsuario = mi.menu();

                switch (seleccionUsuario)
                {
                    case 1: // Dar alta a nuevo cliente
                        Console.WriteLine("---| Dando de alta |---");
                        ci.darAltacliente(listaClientes);

                        break;

                    case 2: //Ver lista de clientes
                        foreach (ClientesDto recorrido in listaClientes)
                        {
                            Console.WriteLine(recorrido);
                        }
                        break;


                    case 3: //Crear cuenta bancaria
                        Console.WriteLine("---| Creando cuenta de banco |---");
                        cb.asignarCuentaBancaria(ListaCuentasBancarias);
                        foreach (CuentasBancariasDto recorrido in ListaCuentasBancarias)
                        {
                            Console.WriteLine(recorrido);
                        }
                        break;

                        break;
                        
                    case 4: //cerrar menu
                        cerrarMenu = true;
                        break;

                    default:
                        Console.WriteLine("No se ha seleccionado una opción valida");
                        break;

                }
            }

            //Crear una funcionalidad de dar de alta una nueva cuenta bancaria, (Necesito un campo que me identifique
            //a que cliente pertenece ) Campos que tiene que tener la cuenta bancaria [idCuentaBancaria,
            //isBan, switch de la entidad a la que pertenece (sera constante) , id del usuario al que pertenece,
            //fchBaja, fchAlta]
        }
    }
}
