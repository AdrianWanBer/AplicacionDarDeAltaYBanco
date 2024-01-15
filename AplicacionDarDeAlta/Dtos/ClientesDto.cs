namespace AplicacionDarDeAlta.Dtos
{
    internal class ClientesDto

    {

        //ATRIBUTOS (CARACTERISTICAS)
        //Son privados por defecto

        public long idCliente; //PK    (UNÍVOCO)


        string nombreCliente = "aaaaa";

        string apellidosCLiente = "aaaaa";

        string dniCliente = "aaaaa";

        long tlfCliente = 111111111;

        int edadCliente = "9999";

        string fechaDeNacimiento = "9999/12/31";

        string fecAltaCliente = "9999/12/31";

        string fecBajaCliente = "9999/12/31";

        string emailCliente = "aaaaa";

        //Getters y Setters (método de acceso)
        public global::System.String NombreCliente { get => nombreCliente; set => nombreCliente = value; }

        public global::System.String ApellidosCLiente { get => apellidosCLiente; set => apellidosCLiente = value; }

        public global::System.String DniCliente { get => dniCliente; set => dniCliente = value; }

        public global::System.Int64 TlfCliente { get => tlfCliente; set => tlfCliente = value; }

        public string FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public global::System.String EmailCliente { get => emailCliente; set => emailCliente = value; }

        public string FecAltaCliente { get => fecAltaCliente; set => fecAltaCliente = value; }

        public string FecBajaCliente { get => fecBajaCliente; set => fecBajaCliente = value; }
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public int EdadCliente { get => edadCliente; set => edadCliente = value; }


        //Constructores (metodos que crean objetos -new)

        public ClientesDto(long idCliente, string nombreCliente, string apellidosCLiente, string dniCliente, int tlfCliente, DateOnly fechaDeNacimineto, string fecAltaCliente, string fecBajaCliente, string emailCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCLiente = apellidosCLiente;
            this.dniCliente = dniCliente;
            this.tlfCliente = tlfCliente;
            this.edadCliente = edadCliente;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.fecAltaCliente = fecAltaCliente;
            this.fecBajaCliente = fecBajaCliente;
            this.emailCliente = emailCliente;
        }
        public ClientesDto()
        {

        }

        //TOSTRING

        override
        public string ToString()
        {
            string clienteString = "nombre:" + this.nombreCliente + "apellidos: " +
                this.apellidosCLiente + "DNI: " + this.dniCliente + "Tlf: " + this.fechaDeNacimiento + this.tlfCliente + "Fecha de nacimiento: " +
                 this.fechaDeNacimiento + "email: " + this.emailCliente + "fecha baja cliente: "
                 + this.fecBajaCliente + "id: " + this.idCliente;

            return clienteString;
        }



    }
}
