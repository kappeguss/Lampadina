using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampadina_classe
{
    public class Lampadina

        private bool Stato;
        private int Posizione;
        public bool Stato
        {
            get { return Stato; }
            set { Stato = value; }
        }
        public void Toggle()
        {
            Stato = !Stato;
        }
        public int Posizione
        {
            get { return Posizione; }
            set { Posizione = value; }
        }
        public void PosUp()
        {
            Posizione -= 27;
        }
        public void PosDown()
        {
            Posizione += 27;
        }
    }
}