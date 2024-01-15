namespace AplicacionDarDeAlta.Dtos
{
    internal class CuentasBancariasDto
    {
        int idCuentaBancaria;

        string isBan = "aaaaa";

        string switchEntidadBancaria = "CSI1SSXX";

        string fchBaja = "9999/12/31";

        string fchAlta = "9999/12/31";

        long idClienteDeLaCuenta = 99999;


        public int IdCuentaBancaria { get => idCuentaBancaria; set => idCuentaBancaria = value; }
        public string IsBan { get => isBan; set => isBan = value; }
        public string SwitchEntidadBancaria { get => switchEntidadBancaria; set => switchEntidadBancaria = value; }
        public string FchBaja { get => fchBaja; set => fchBaja = value; }
        public string FchAlta { get => fchAlta; set => fchAlta = value; }
        public long IdClienteDeLaCuenta { get => idClienteDeLaCuenta; set => idClienteDeLaCuenta = value; }

        public CuentasBancariasDto(int idCuentaBancaria, string isBan, string switchEntidadBancaria, string fchBaja, string fchAlta, int idClienteDeLaCuenta)
        {
            this.idCuentaBancaria = idCuentaBancaria;
            this.isBan = isBan;
            this.switchEntidadBancaria = switchEntidadBancaria;
            this.fchBaja = fchBaja;
            this.fchAlta = fchAlta;
            this.idClienteDeLaCuenta = idClienteDeLaCuenta;
        }
        public CuentasBancariasDto()
        {
        }

        override
        public string ToString()
        {
            string stringBanco = "id cuenta del banco: " + this.idCuentaBancaria + "isBan de la cuenta: " +
                this.isBan + "Switch de la entidad bancaria: "
                + this.switchEntidadBancaria + "fecha Baja: " + this.fchBaja + "fecha de alta: " + this.fchAlta +
                "Propietario: " + this.idClienteDeLaCuenta;


            return stringBanco;
        }
    }
}
