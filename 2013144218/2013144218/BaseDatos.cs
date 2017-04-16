using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218
{
    class BaseDatos
    {

        public Cuenta cuenta;
        public List<Cuenta> listCuenta;
        public BaseDatos()
        {
            cuenta = new Cuenta();

            listCuenta = new List<Cuenta>();
        }

        public void llenar()
        {
            Console.WriteLine("LLENANDO BASEDEDATOS");          
            try
            {

              

                //Cuenta 1:
                cuenta.nCuenta = 2013144218;
                cuenta.id = 2013;
                cuenta.saldo = 7500;
                cuenta.saldoDisponible = 5200;
                listCuenta.Add(cuenta);

                //Cuenta 2:
                cuenta.nCuenta = 2014568932;
                cuenta.id = 2014;
                cuenta.saldo = 8500;
                cuenta.saldoDisponible = 7000;
                listCuenta.Add(cuenta);



                Console.WriteLine("CUENTS REGISTRADAS");

            }
            catch (Exception ex)
            {
                
               
                Console.WriteLine("NO SE REGISTRO");
            }

        }

        public bool AutenticarUsuario(int numCuenta, int pin)
        {
            if (listCuenta == null)
            {
                Console.WriteLine("GO");
                return false;
            }
            else
            {
                for (int i = 0; i < listCuenta.Count; i++)
                {
                    if (numCuenta == listCuenta[i].nCuenta && pin == listCuenta[i].id)
                    {
                        Console.WriteLine("LISTO");
                        return true;
                    }
                }
                return false;
            }
        }

        public double ObtenerSaldoDisponible(int numCuenta)
        {
           int cont = 0;
            for (int i = 0; i < listCuenta.Count; i++)
            {
                if (numCuenta == listCuenta[i].nCuenta)
                {
                   cont = i;
                    Console.WriteLine("SALDO DISPONIBLE:" +cont);
                }
            }
            Console.WriteLine("SU SALDO DISPONIBLE:" + listCuenta[cont].saldoDisponible);
            return listCuenta[cont].saldoDisponible;
        }

        public double ObtenerSaldoTotal(int numCuenta)
        {
            int variabletmp = 0;

            for (int j = 0; j < listCuenta.Count; j++)
            {
                if (numCuenta == listCuenta[j].nCuenta)
                {
                    variabletmp = j;
                }
            }
            Console.WriteLine("SALDO TOTAL ES:" + listCuenta[variabletmp].saldo);
            return listCuenta[variabletmp].saldo;
        }

      //  public void Debitar(int ncuenta, double monto)
       // {
       // }

       // public void acreditar(int nCuenta, double monto)
        //{
      //  }
    
}
}
