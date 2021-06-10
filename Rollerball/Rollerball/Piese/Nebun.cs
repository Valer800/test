using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollerball
{
    class Nebun : Piesa
    {
        public Nebun(culoare_piesa cul)
        {
            this.tip = tip_piesa.nebun;
            this.culoare = cul;
        }
        public override void calculeaza_mutare_negre(Board a_board, ref List<Mutare> mutari_posibile)
        {
            if (rand == 0)
            {
                if (coloana == 5)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }
                if (coloana == 3)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }
                if (coloana == 1)
                {
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana -1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }
                if ((coloana + 1) < 7)
                {
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
                if (coloana == 0)
                {
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }
                if (coloana == 1)
                {
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }
                if (coloana == 2)
                {
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }
                if (coloana == 4)
                {
                    if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }
            }


            if (coloana == 6)
            {
                if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                }
                else if (a_board.tabla[rand+1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                }
                if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                }
                else if (a_board.tabla[rand-1][coloana -1].piesa.culoare == culoare_piesa.alb)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                }
            }

            else if (rand == 2)
            {
                if (coloana == 5)
                {
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }
                if (coloana == 1)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }

                }

            }

            else if (rand == 3)
            {

                if (coloana == 6)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }

                }

                if (coloana == 0)
                {
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }
            }
            else if (rand == 4)
            {
                if (coloana == 5)
                {
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }

                if (coloana == 1)
                {
                    if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana -1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }

                }
                if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                }
                else if (a_board.tabla[rand+1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana - 1), valoare_scor.ia_piesa));
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
            else if (rand == 5)
            {

                if (coloana == 0)
                {
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }
                if (coloana == 4)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }
                if (coloana == 6)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }
                if (coloana == 2)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand+1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana - 1), valoare_scor.ia_piesa));
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
            else if (rand == 6)
            {
                if (coloana == 1)
                {
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }

                }
                if (coloana == 3)
                {
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }

                }
                if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                }
                else if (a_board.tabla[rand-1][coloana - 1].piesa.culoare == culoare_piesa.alb)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                }
                if (coloana == 5)
                {
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand-1][coloana + 1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }
            }


        }
        public override void calculeaza_mutare_albe(Board a_board, ref List<Mutare> mutari_posibile)
        {
            if (rand == 0)
            {
                if (coloana == 5)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }
                if (coloana == 3)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }
                if (coloana == 1)
                {
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }
                if ((coloana + 1) < 7)
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
            }
            else if (rand == 1)
            {
                if (coloana == 0)
                {
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                }
                if (coloana == 1)
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
                if (coloana == 2)
                {
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }
                if (coloana == 4)
                {
                    if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
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


            if (coloana == 6)
            {
                if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                }
                else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                }
                if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                }
                else if (a_board.tabla[rand - 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                }
            }

            else if (rand == 2)
            {
                if (coloana == 5)
                {
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
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
                if (coloana == 1)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
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

            else if (rand == 3)
            {

                if (coloana == 6)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }

                }

                if (coloana == 0)
                {
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
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
            else if (rand == 4)
            {
                if (coloana == 5)
                {
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }

                if (coloana == 1)
                {
                    if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }

                }
                if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                }
                else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
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
            else if (rand == 5)
            {

                if (coloana == 0)
                {
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
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
                if (coloana == 4)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand + 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
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
                if (coloana == 6)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                }
                if (coloana == 2)
                {
                    if (a_board.tabla[rand + 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand + 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                    }
                    if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
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
            else if (rand == 6)
            {
                if (coloana == 1)
                {
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }

                }
                if (coloana == 3)
                {
                    if (a_board.tabla[rand - 1][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1)));
                    }
                    else if (a_board.tabla[rand - 1][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }

                }
                if (a_board.tabla[rand - 1][coloana - 1].piesa == null)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1)));
                }
                else if (a_board.tabla[rand - 1][coloana - 1].piesa.culoare == culoare_piesa.negru)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana - 1), valoare_scor.ia_piesa));
                }
                if (coloana == 5)
                {
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


        }
    }
}
