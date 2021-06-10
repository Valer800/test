using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollerball
{
    class Tura : Piesa
    {
        public Tura(culoare_piesa cul)
        {
            this.tip = tip_piesa.tura;
            this.culoare = cul;
        }
        public override void calculeaza_mutare_negre(Board a_board, ref List<Mutare> mutari_posibile)
        {
            if ((rand == 0) || (rand == 1))
            {
                int temp = coloana + 1;
                while (temp < 7)
                {
                    if (a_board.tabla[rand][temp].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(temp)));
                        temp++;
                        if (rand == 0 && temp == 6)
                        {
                            int temp2 = rand + 1;
                            while (temp2 < 7)
                            {
                                if (a_board.tabla[temp2][temp].piesa == null)
                                {
                                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp2), (byte)(temp)));
                                    temp2++;
                                }
                                else if (a_board.tabla[temp2][temp].piesa.culoare == culoare_piesa.alb)
                                {
                                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp2), (byte)(temp), valoare_scor.ia_piesa));
                                    temp2--;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (((coloana - 1) >= 0) && a_board.tabla[rand][coloana - 1].piesa == null)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1)));
                }
                else if (((coloana - 1) >= 0) && a_board.tabla[rand][coloana - 1].piesa.culoare == culoare_piesa.alb)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1), valoare_scor.ia_piesa));
                }

                if (rand == 1)
                {
                    if (((rand - 1) >= 0) && a_board.tabla[rand - 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana)));

                    }
                    else if (((rand - 1) >= 0) && a_board.tabla[rand-1][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana), valoare_scor.ia_piesa));
                    }

                    if (((rand + 1) < 2) || (coloana >= 5) && a_board.tabla[rand + 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana)));

                    }
                    else if (((rand + 1) < 2) || (coloana >= 5) && a_board.tabla[rand + 1][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }

                }
                if (rand == 0)
                {
                    if (((rand + 1) < 2) && a_board.tabla[rand + 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana)));

                    }
                    else if (((rand + 1) < 2) && a_board.tabla[rand + 1][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }

                }
            }
            if ( (rand == 2) || (rand == 3) || (rand == 4))
            {
                if (coloana == 6)
                {
                    int temp = rand + 1;
                    while (temp < 7)
                    {
                        if (a_board.tabla[temp][coloana].piesa == null)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana)));
                            temp++;

                        }
                        else if (a_board.tabla[temp][coloana].piesa.culoare == culoare_piesa.alb)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana), valoare_scor.ia_piesa));
                            temp++;
                        }

                        else
                        {
                            break;
                        }
                    }
                    if (((coloana - 1) > 4) && a_board.tabla[rand][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1)));

                    }
                    else if (((coloana - 1) > 4) && a_board.tabla[rand + 1][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }
                    if (((rand - 1) >= 5) && a_board.tabla[rand - 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana)));

                    }
                    else if (((rand - 1) >= 5) && a_board.tabla[rand - 1][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }

                }
                if (coloana == 5)
                {
                    int temp = rand + 1;
                    while (temp <= 5)
                    {
                        if (a_board.tabla[temp][coloana].piesa == null)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana)));
                            temp++;

                        }
                        else if (a_board.tabla[temp][coloana].piesa.culoare == culoare_piesa.alb)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana), valoare_scor.ia_piesa));
                            temp++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (((coloana + 1) < 7) && a_board.tabla[rand][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1)));

                    }
                    else if (((coloana + 1) < 7) && a_board.tabla[rand][coloana+1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana+1), valoare_scor.ia_piesa));
                    }
                    if (((rand - 1) >= 5) && a_board.tabla[rand - 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana)));

                    }
                    else if (((rand - 1) >= 5) && a_board.tabla[rand-1][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand-1), (byte)(coloana), valoare_scor.ia_piesa));
                    }

                }
            }
            if (coloana == 0 || coloana == 1)
            {
                int temp = rand - 1;
                while (temp > 0)
                {
                    if (a_board.tabla[temp][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana)));
                        temp--;

                    }
                    else if (a_board.tabla[temp][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana), valoare_scor.ia_piesa));
                        temp++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (((rand + 1) < 7) && a_board.tabla[rand + 1][coloana].piesa == null)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana)));
                }
                else if (((rand + 1) < 7) && a_board.tabla[rand+1][coloana].piesa.culoare == culoare_piesa.alb)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                   
                }
                if (coloana == 0)
                {
                    if (((coloana + 1) < 2) && a_board.tabla[rand][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana)));
                    }
                    else if (((coloana + 1) < 2) && a_board.tabla[rand + 1][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));

                    }
                }
                if (coloana == 1)
                {
                    if (((coloana - 1) >= 0) && a_board.tabla[rand][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1)));
                    }
                    else if (((coloana - 1) >= 0) && a_board.tabla[rand][coloana-1].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana-1), valoare_scor.ia_piesa));

                    }

                }
                if (coloana == 0 && rand == 6)
                {
                    int temp2 = rand - 1;
                    while (temp2 > 0)
                    {
                        if (a_board.tabla[temp][coloana].piesa == null)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp2), (byte)(coloana)));
                            temp2--;

                        }
                        else if (a_board.tabla[temp][coloana].piesa.culoare == culoare_piesa.alb)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana - 1), valoare_scor.ia_piesa));
                            temp++;
                        }

                        else
                        {
                            break;
                        }
                    }
                    if (((rand + 1) < 7) && a_board.tabla[rand + 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana)));


                    }
                    else if (((rand + 1) < 7) && a_board.tabla[rand+1][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand+1), (byte)(coloana), valoare_scor.ia_piesa));

                    }

                }


            }
            if ((rand == 6) || (rand == 5))
            {
                int temp = coloana - 1;
                while (temp > 0)
                {
                    if (a_board.tabla[rand][temp].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(temp)));
                        temp--;
                        if (rand == 6 && temp == 6)
                        {
                            int temp2 = coloana - 1;
                            while (temp2 < 7)
                            {
                                if (a_board.tabla[temp2][temp].piesa == null)
                                {
                                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp2), (byte)(temp)));
                                    temp2--;
                                }
                                else if (a_board.tabla[temp2][temp].piesa.culoare == culoare_piesa.alb)
                                {
                                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp2), (byte)(temp), valoare_scor.ia_piesa));
                                    temp2--;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (((coloana + 1) < 7) && a_board.tabla[rand][coloana + 1].piesa == null)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1)));
                }
                else if (((coloana + 1) < 7) && a_board.tabla[rand][coloana+1].piesa.culoare == culoare_piesa.alb)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana+1), valoare_scor.ia_piesa));

                }

            }

            if (coloana == 0 && rand == 0)
            {
                int temp = coloana + 1;
                while (temp < 7)
                {
                    if (a_board.tabla[temp][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana)));
                        temp++;

                    }
                    else if (a_board.tabla[temp][coloana].piesa.culoare == culoare_piesa.alb)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana), valoare_scor.ia_piesa));
                        temp++;
                    }

                    else
                    {
                        break;
                    }
                }

            }            
        }
        public override void calculeaza_mutare_albe(Board a_board, ref List<Mutare> mutari_posibile)
        {
            if ((rand == 0) || (rand == 1))
            {
                int temp = coloana + 1;
                while (temp < 7)
                {
                    if (a_board.tabla[rand][temp].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(temp)));
                        temp++;
                        if (rand == 0 && temp == 6)
                        {
                            int temp2 = rand + 1;
                            while (temp2 < 7)
                            {
                                if (a_board.tabla[temp2][temp].piesa == null)
                                {
                                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp2), (byte)(temp)));
                                    temp2++;
                                }
                                else if (a_board.tabla[temp2][temp].piesa.culoare == culoare_piesa.negru)
                                {
                                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp2), (byte)(temp), valoare_scor.ia_piesa));
                                    temp2--;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (((coloana - 1) >= 0) && a_board.tabla[rand][coloana - 1].piesa == null)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1)));
                }
                else if (((coloana - 1) >= 0) && a_board.tabla[rand][coloana - 1].piesa.culoare == culoare_piesa.negru)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1), valoare_scor.ia_piesa));
                }

                if (rand == 1)
                {
                    if (((rand - 1) >= 0) && a_board.tabla[rand - 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana)));

                    }
                    else if (((rand - 1) >= 0) && a_board.tabla[rand - 1][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }

                    if (((rand + 1) < 2) || (coloana >= 5) && a_board.tabla[rand + 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana)));

                    }
                    else if (((rand + 1) < 2) || (coloana >= 5) && a_board.tabla[rand + 1][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }

                }
                if (rand == 0)
                {
                    if (((rand + 1) < 2) && a_board.tabla[rand + 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana)));

                    }
                    else if (((rand + 1) < 2) && a_board.tabla[rand + 1][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }

                }
            }
            if ((rand == 2) || (rand == 3) || (rand == 4))
            {
                if (coloana == 6)
                {
                    int temp = rand + 1;
                    while (temp < 7)
                    {
                        if (a_board.tabla[temp][coloana].piesa == null)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana)));
                            temp++;

                        }
                        else if (a_board.tabla[temp][coloana].piesa.culoare == culoare_piesa.negru)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana), valoare_scor.ia_piesa));
                            temp++;
                        }

                        else
                        {
                            break;
                        }
                    }
                    if (((coloana - 1) > 4) && a_board.tabla[rand][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1)));

                    }
                    else if (((coloana - 1) > 4) && a_board.tabla[rand + 1][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }
                    if (((rand - 1) >= 5) && a_board.tabla[rand - 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana)));

                    }
                    else if (((rand - 1) >= 5) && a_board.tabla[rand - 1][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }

                }
                if (coloana == 5)
                {
                    int temp = rand + 1;
                    while (temp <= 5)
                    {
                        if (a_board.tabla[temp][coloana].piesa == null)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana)));
                            temp++;

                        }
                        else if (a_board.tabla[temp][coloana].piesa.culoare == culoare_piesa.negru)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana), valoare_scor.ia_piesa));
                            temp++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (((coloana + 1) < 7) && a_board.tabla[rand][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1)));

                    }
                    else if (((coloana + 1) < 7) && a_board.tabla[rand][coloana + 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1), valoare_scor.ia_piesa));
                    }
                    if (((rand - 1) >= 5) && a_board.tabla[rand - 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana)));

                    }
                    else if (((rand - 1) >= 5) && a_board.tabla[rand - 1][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand - 1), (byte)(coloana), valoare_scor.ia_piesa));
                    }

                }
            }
            if (coloana == 0 || coloana == 1)
            {
                int temp = rand - 1;
                while (temp > 0)
                {
                    if (a_board.tabla[temp][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana)));
                        temp--;

                    }
                    else if (a_board.tabla[temp][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana), valoare_scor.ia_piesa));
                        temp++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (((rand + 1) < 7) && a_board.tabla[rand + 1][coloana].piesa == null)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana)));
                }
                else if (((rand + 1) < 7) && a_board.tabla[rand + 1][coloana].piesa.culoare == culoare_piesa.negru)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));

                }
                if (coloana == 0)
                {
                    if (((coloana + 1) < 2) && a_board.tabla[rand][coloana + 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana)));
                    }
                    else if (((coloana + 1) < 2) && a_board.tabla[rand + 1][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));

                    }
                }
                if (coloana == 1)
                {
                    if (((coloana - 1) >= 0) && a_board.tabla[rand][coloana - 1].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1)));
                    }
                    else if (((coloana - 1) >= 0) && a_board.tabla[rand][coloana - 1].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana - 1), valoare_scor.ia_piesa));

                    }

                }
                if (coloana == 0 && rand == 6)
                {
                    int temp2 = rand - 1;
                    while (temp2 > 0)
                    {
                        if (a_board.tabla[temp][coloana].piesa == null)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp2), (byte)(coloana)));
                            temp2--;

                        }
                        else if (a_board.tabla[temp][coloana].piesa.culoare == culoare_piesa.negru)
                        {
                            mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana - 1), valoare_scor.ia_piesa));
                            temp++;
                        }

                        else
                        {
                            break;
                        }
                    }
                    if (((rand + 1) < 7) && a_board.tabla[rand + 1][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana)));


                    }
                    else if (((rand + 1) < 7) && a_board.tabla[rand + 1][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand + 1), (byte)(coloana), valoare_scor.ia_piesa));

                    }

                }


            }
            if ((rand == 6) || (rand == 5))
            {
                int temp = coloana - 1;
                while (temp > 0)
                {
                    if (a_board.tabla[rand][temp].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(temp)));
                        temp--;
                        if (rand == 6 && temp == 6)
                        {
                            int temp2 = coloana - 1;
                            while (temp2 < 7)
                            {
                                if (a_board.tabla[temp2][temp].piesa == null)
                                {
                                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp2), (byte)(temp)));
                                    temp2--;
                                }
                                else if (a_board.tabla[temp2][temp].piesa.culoare == culoare_piesa.negru)
                                {
                                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp2), (byte)(temp), valoare_scor.ia_piesa));
                                    temp2--;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (((coloana + 1) < 7) && a_board.tabla[rand][coloana + 1].piesa == null)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1)));
                }
                else if (((coloana + 1) < 7) && a_board.tabla[rand][coloana + 1].piesa.culoare == culoare_piesa.negru)
                {
                    mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(rand), (byte)(coloana + 1), valoare_scor.ia_piesa));

                }

            }

            if (coloana == 0 && rand == 0)
            {
                int temp = coloana + 1;
                while (temp < 7)
                {
                    if (a_board.tabla[temp][coloana].piesa == null)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana)));
                        temp++;

                    }
                    else if (a_board.tabla[temp][coloana].piesa.culoare == culoare_piesa.negru)
                    {
                        mutari_posibile.Add(new Mutare((byte)rand, (byte)coloana, (byte)(temp), (byte)(coloana), valoare_scor.ia_piesa));
                        temp++;
                    }

                    else
                    {
                        break;
                    }
                }

            }
        }

    }
    

}
