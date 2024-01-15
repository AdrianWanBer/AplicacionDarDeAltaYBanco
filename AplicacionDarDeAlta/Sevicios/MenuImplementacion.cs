namespace AplicacionDarDeAlta.Sevicios
{
    /// <summary>
    /// Clase que se encargara de los metodos relacionados con el menu
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Metodo que se encarga de mostrar por consola las opciones (el menu) y recojer la seleccion del usuario
        /// <author>211123 - awb</author>
        /// </summary>
        /// <returns></returns>
        public int menu()
        {

            Console.WriteLine("+----------------------+");
            Console.WriteLine("|  ¿Que quiere hacer?  ");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 1.Cerrar ");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 2.Dar alta clientes     ");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 3. Crear cuenta bancaria");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 4.ver clientes ");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 5.Modificar clientes");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 5.Borrar CLientes");
            Console.WriteLine("+----------------------+");

            int seleccionUsuario = Convert.ToInt32(Console.ReadLine());


            return seleccionUsuario;
        }


        public string pedirDni()
        {
            Console.WriteLine("Indica el DNI del cliente: ");
            string dniCliente = Console.ReadLine();
            return dniCliente;
        }

        public int seleccionModificar()
        {
            int seleccion;
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 0.DNI  ");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 1.Nombre ");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 2.Apellido");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 3.Fecha Nacimiento");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 4.Email ");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 5.Numero de Telefono");
            Console.WriteLine("+----------------------+");
            seleccion = Convert.ToInt32(Console.ReadLine());
            return seleccion;
        }
    }
}
