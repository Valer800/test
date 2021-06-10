using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rollerball
{
    enum tip_piesa
    {
        gol = 9,
        pion = 0,
        nebun = 1,
        tura = 2,
        rege = 3
    };
    enum culoare_piesa
    {
        alb = 0, negru = 1
    };
    enum valoare_scor
    {
        normal = 100,
        ataca = 105,
        este_atacat = 95,
        ia_piesa = 110,
        liber = 100


    };
    abstract class Piesa
    {
        public tip_piesa tip;
        public culoare_piesa culoare;
        public int rand;
        public int coloana;
        protected byte[,] tabla;


        public Piesa()
        {

        }

        public abstract void calculeaza_mutare_negre(Board c, ref List<Mutare> mutari);
        public abstract void calculeaza_mutare_albe(Board c, ref List<Mutare> mutari);

        public void imaginea_atacuri(Board c, culoare_piesa culoare)
        {
            tabla = null;
            tabla = new byte[7, 7];
            for (int rand = 0; rand < 7; rand++)
            {
                for (int coloana = 0; coloana < 7; coloana++)
                {
                    if (!(rand >= 2 && rand <= 4 && coloana >= 2 && coloana <= 4))
                    {
                        if (c.tabla[rand][coloana].piesa != null && c.tabla[rand][coloana].piesa.culoare == culoare)
                        {
                            switch (c.tabla[rand][coloana].piesa.tip)
                            {
                                case tip_piesa.pion:
                                    tabla[rand, coloana] = 2;
                                    if ((rand - 1) >= 0 && (rand - 1) != 4)
                                    {
                                        tabla[rand - 1, coloana] = 1;
                                        if ((coloana - 1) >= 0 && (coloana - 1) != 4)
                                        {
                                            tabla[rand - 1, coloana - 1] = 1;
                                        }
                                        if ((coloana + 1) <= 6 && (coloana + 1) != 2)
                                        {
                                            tabla[rand - 1, coloana + 1] = 1;
                                        }

                                    }
                                    if ((coloana - 1) >= 0 && (coloana - 1) != 4)
                                    {
                                        tabla[rand, coloana - 1] = 1;
                                    }
                                    if ((coloana + 1) <= 6 && (coloana + 1) != 2)
                                    {
                                        tabla[rand, coloana + 1] = 1;
                                    }
                                    if ((rand + 1) <= 6 && (rand + 1) != 2)
                                    {
                                        tabla[rand + 1, coloana] = 1;
                                        if ((coloana - 1) >= 0 && (coloana - 1) != 4)
                                        {
                                            tabla[rand + 1, coloana - 1] = 1;
                                        }
                                        if ((coloana + 1) <= 6 && (coloana + 1) != 2)
                                        {
                                            tabla[rand + 1, coloana + 1] = 1;
                                        }
                                    }

                                    break;

                                case tip_piesa.rege:
                                    tabla[rand, coloana] = 5;
                                    if ((rand - 1) >= 0 && (rand - 1) != 4)
                                    {
                                        tabla[rand - 1, coloana] = 1;
                                        if ((coloana - 1) >= 0 && (coloana - 1) != 4)
                                        {
                                            tabla[rand - 1, coloana - 1] = 1;
                                        }
                                        if ((coloana + 1) <= 6 && (coloana + 1) != 2)
                                        {
                                            tabla[rand - 1, coloana + 1] = 1;
                                        }

                                    }
                                    if ((coloana - 1) >= 0 && (coloana - 1) != 4)
                                    {
                                        tabla[rand, coloana - 1] = 1;
                                    }
                                    if ((coloana + 1) <= 6 && (coloana + 1) != 2)
                                    {
                                        tabla[rand, coloana + 1] = 1;
                                    }
                                    if ((rand + 1) <= 6 && (rand + 1) != 2)
                                    {
                                        tabla[rand + 1, coloana] = 1;
                                        if ((coloana - 1) >= 0 && (coloana - 1) != 4)
                                        {
                                            tabla[rand + 1, coloana - 1] = 1;
                                        }
                                        if ((coloana + 1) <= 6 && (coloana + 1) != 2)
                                        {
                                            tabla[rand + 1, coloana + 1] = 1;
                                        }
                                    }

                                    break;
                                case tip_piesa.tura:
                                    tabla[rand, coloana] = 3;
                                    break;
                                case tip_piesa.nebun:
                                    tabla[rand, coloana] = 4;
                                    break;

                            }
                        }
                    }
                }
            }
        }
    }
}

