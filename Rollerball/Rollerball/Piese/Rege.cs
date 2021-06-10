using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rollerball
{
    class Rege : Piesa
    {
        public Rege(culoare_piesa cul)
        {
            this.tip = tip_piesa.rege;
            this.culoare = cul;
        }
        public override void calculeaza_mutare_negre(Board a_board, ref List<Mutare> mutari_posibile)
        {
            imaginea_atacuri(a_board, culoare_piesa.alb);
            for (int r = rand - 1; r <= rand + 1; r++)
            {
                for (int c = coloana - 1; c <= coloana + 1; c++)
                {
                    if (r >= 0 && r < 7 && c >= 0 && c < 7)
                    {
                        if (!(r >= 2 && r <= 4 && c >= 2 && c <= 4))
                        {
                            if (a_board.tabla[r][c].piesa == null)
                            {
                                switch (tabla[r, c])
                                {
                                    case 0:
                                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)r, (byte)c, valoare_scor.liber));
                                        break;
                                    case 1:
                                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)r, (byte)c, valoare_scor.este_atacat));
                                        break;
                                }
                            }
                            else
                            {
                                if (a_board.tabla[r][c].piesa.culoare == culoare_piesa.alb)
                                {
                                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)r, (byte)c, valoare_scor.ia_piesa));
                                }
                            }

                        }


                    }
                }
              
            }
        }


        public override void calculeaza_mutare_albe(Board a_board, ref List<Mutare> mutari_posibile)
        {
            imaginea_atacuri(a_board, culoare_piesa.negru);
            for (int r = rand - 1; r <= rand + 1; r++)
            {
                for (int c = coloana - 1; c <= coloana + 1; c++)
                {
                    if (r >= 0 && r < 7 && c >= 0 && c < 7)
                    {
                        if (!(r >= 2 && r <= 4 && c >= 2 && c <= 4))
                        {
                            if (a_board.tabla[r][c].piesa == null)
                            {
                                switch (tabla[r, c])
                                {
                                    case 0:
                                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)r, (byte)c, valoare_scor.liber));
                                        break;
                                    case 1:
                                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)r, (byte)c, valoare_scor.este_atacat));
                                        break;
                                }
                            }
                            else
                            {
                                if (a_board.tabla[r][c].piesa.culoare == culoare_piesa.negru)
                                {
                                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)r, (byte)c, valoare_scor.ia_piesa));
                                }
                            }

                        }


                    }
                }
            }
         
        }
    }
}



