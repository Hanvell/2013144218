using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218
{
    class Retiro
    {
        public int NumeroTicket { get; private set; }
        public Atm Atm { get; private set; }
        public int Monto { get; private set; }
        public int numTicket;
        
        public Retiro()
        {

        }
        public Retiro(Atm atm)
        {
            Atm = atm;
        }
       

    }
}
