using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218
{
    class Cuenta
    {
       
        public int id { get; set; }
        public int nCuenta { get; set; }
        public double saldo { get; set; }
        public double saldoDisponible { get; set; }

        public Cuenta()
        { }

        public Cuenta(int nCuenta, int id , double saldo ,double SaldoDisponible)
        {
            this.nCuenta = nCuenta;
            this.id = id;
            this.saldo = saldo;
            this.saldoDisponible = SaldoDisponible;
        }

    }
}
