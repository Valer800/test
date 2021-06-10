using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollerball
{
    class Mutare
    {
        public byte sursa_rand;
        public byte sursa_coloana;
        public byte destinatie_rand;
        public byte destinatie_coloana;
        public valoare_scor scor;

        public Mutare(byte sr,byte sc, byte dr,byte dc, valoare_scor sco=valoare_scor.normal)
        {
            sursa_rand = sr;
            sursa_coloana = sc;
            destinatie_rand = dr;
            destinatie_coloana = dc;
            scor = sco;
        }
    }
    
}
