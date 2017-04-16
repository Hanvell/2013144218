using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218
{
    public class Atm
    {
        //private Teclado teclado;
        //private Pantalla pantalla;
        private Retiro retiro;
        BaseDatos baseD =null;
        //private RanuraDeposito ranuraDeposito;
       // private DispensadordeEfectivo dispensadorEfectivo;

        public void comenzar()
        {
             baseD = new BaseDatos();
            baseD.llenar();
            baseD.AutenticarUsuario(2013144218, 2013);
            baseD.ObtenerSaldoDisponible(2013144218);
            baseD.ObtenerSaldoTotal(2013144218);
            Console.ReadKey();

        }


    }
}
