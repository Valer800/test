using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rollerball
{
    class Pion : Piesa
    {
        public Pion(culoare_piesa cul)
        {
            this.tip = tip_piesa.pion;
            this.culoare = cul;
        }
        public override void calculeaza_mutare_negre(Board a_board, ref List<Mutare> mutari_posibile)
        {
            if (rand == 0)
            {
                if ((coloana + 1) < 7)
                {
                    if (a_board.tabla[rand][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1)));
                    }
                    else if(a_board.tabla[rand][coloana + 1].piesa.culoare == culoare_piesa.alb) 
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }
            }
            else if (rand == 1)
            {
                if (coloana < 2)
                {
                    if (a_board.tabla[rand - 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana)));
                    }
                    else if (a_board.tabla[rand -1][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana- 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }

                }
                else if ((coloana + 1) < 7)
                {

                    if (a_board.tabla[rand][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (coloana == 4)
                    {
                        if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                        }
                        else if (a_board.tabla[rand + 1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                        }
                    }
                    if (a_board.tabla[rand - 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana)));
                    }
                    else if (a_board.tabla[rand - 1][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }


            }
            else if (rand == 2 || rand == 3 || rand == 4)
            {
                if (coloana >= 5)
                {

                    if (((coloana + 1) < 7) && a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (((coloana + 1) < 7) && a_board.tabla[rand + 1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana)));
                    }
                    else if (a_board.tabla[rand + 1][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }
                    if ((coloana - 1) > 4 && a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if ((coloana - 1) > 4 && a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }

                if (rand == 4 && coloana == 5)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }
            }
            else
            {
                if (coloana > 4)
                {
                    if (a_board.tabla[rand][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand ), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (((rand + 1) < 7) && a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (((rand + 1) < 7) && a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if ((rand + 1) < 7 && a_board.tabla[rand + 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana)));
                    }
                    else if ((rand + 1) < 7 && a_board.tabla[rand + 1][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }
                }
                else if (coloana >= 2 && coloana <= 4)
                {
                    if (a_board.tabla[rand][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if ((rand + 1) < 7 && a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if ((rand + 1) < 7 && a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (coloana == 2 && rand == 5)
                    {
                        if ((rand + 1) < 7 && a_board.tabla[rand - 1][coloana - 1].piesa == null)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                        }
                        else if ((rand + 1) < 7 && a_board.tabla[rand - 1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                        }
                    }

                }
                else if (coloana < 2)
                {
                    if ((rand - 1) >= 0 && a_board.tabla[rand - 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana)));
                    }
                    else if ((rand - 1) >= 0 && a_board.tabla[rand - 1][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }
                    if ((rand - 1) >= 0 && (coloana - 1) >= 0 && a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if ((rand - 1) >= 0 && (coloana - 1) >= 0 && a_board.tabla[rand - 1][coloana -1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if ((coloana - 1) >= 0 && a_board.tabla[rand][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1)));
                    }
                    else if ((coloana - 1) >= 0 && a_board.tabla[rand][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }
            }
        }
        public override void calculeaza_mutare_albe(Board a_board, ref List<Mutare> mutari_posibile)
        {
            if (rand == 0)
            {
                if ((coloana + 1) < 7)
                {
                    if (a_board.tabla[rand][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }
            }
            else if (rand == 1)
            {
                if (coloana < 2)
                {
                    if (a_board.tabla[rand - 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana)));
                    }
                    else if (a_board.tabla[rand - 1][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }

                }
                else if ((coloana + 1) < 7)
                {

                    if (a_board.tabla[rand][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (coloana == 4)
                    {
                        if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                        }
                        else if (a_board.tabla[rand + 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                        }
                    }
                    if (a_board.tabla[rand - 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana)));
                    }
                    else if (a_board.tabla[rand - 1][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }


            }
            else if (rand == 2 || rand == 3 || rand == 4)
            {
                if (coloana >= 5)
                {

                    if (((coloana + 1) < 7) && a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (((coloana + 1) < 7) && a_board.tabla[rand + 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana)));
                    }
                    else if (a_board.tabla[rand + 1][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }
                    if ((coloana - 1) > 4 && a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if ((coloana - 1) > 4 && a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }

                if (rand == 4 && coloana == 5)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }
            }
            else
            {
                if (coloana > 4)
                {
                    if (a_board.tabla[rand][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (((rand + 1) < 7) && a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (((rand + 1) < 7) && a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if ((rand + 1) < 7 && a_board.tabla[rand + 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana)));
                    }
                    else if ((rand + 1) < 7 && a_board.tabla[rand + 1][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }
                }
                else if (coloana >= 2 && coloana <= 4)
                {
                    if (a_board.tabla[rand][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if ((rand + 1) < 7 && a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if ((rand + 1) < 7 && a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (coloana == 2 && rand == 5)
                    {
                        if ((rand + 1) < 7 && a_board.tabla[rand - 1][coloana - 1].piesa == null)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                        }
                        else if ((rand + 1) < 7 && a_board.tabla[rand - 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                        }
                    }

                }
                else if (coloana < 2)
                {
                    if ((rand - 1) >= 0 && a_board.tabla[rand - 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana)));
                    }
                    else if ((rand - 1) >= 0 && a_board.tabla[rand - 1][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }
                    if ((rand - 1) >= 0 && (coloana - 1) >= 0 && a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if ((rand - 1) >= 0 && (coloana - 1) >= 0 && a_board.tabla[rand - 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if ((coloana - 1) >= 0 && a_board.tabla[rand][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1)));
                    }
                    else if ((coloana - 1) >= 0 && a_board.tabla[rand][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }
            }
        }
    }
}
