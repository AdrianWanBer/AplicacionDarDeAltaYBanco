namespace AplicacionDarDeAlta.Sevicios
{
    /// <summary>
    /// Interfaz que contiene los metodos de MenuImplementacion
    /// <author>211123 - awb</author>
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que mostrara las opciones del menu y recojera la seleccion del usuario
        /// <author>271123 - awb</author>
        /// </summary>
        /// <returns></returns>
        public int menu();

        /// <summary>
        /// Metodo que pedira el dni al usuario
        /// </summary>
        /// <returns></returns>
        public string pedirDni();

        /// <summary>
        /// Metodo que imprimi
        /// </summary>
        /// <returns></returns>
        public int seleccionModificar();
    }
}
