using System;
using System.Data;

namespace UX.Modelos
{
    public class SaldoAsignado
    {
        private string _nombre;
        private int _saldo;

        public SaldoAsignado(IDataReader reader)
        {
            _nombre = Convert.ToString(reader["Nombre"]);
            _saldo = Convert.ToInt32(reader["Saldo"]);
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Saldo { get => _saldo; set => _saldo = value; }
    }
}
