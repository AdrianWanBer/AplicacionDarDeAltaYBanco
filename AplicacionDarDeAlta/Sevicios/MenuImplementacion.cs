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
            Console.WriteLine("| 1.Dar alta clientes ");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 2.Ver clientes     ");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 3. Crear cuenta bancaria");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 4.Cerrar");
            Console.WriteLine("+----------------------+");

            int seleccionUsuario = Convert.ToInt32(Console.ReadLine());


            return seleccionUsuario;
        }
    }
}
