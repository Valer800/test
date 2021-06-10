using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rollerball
{
    class Game
    {
        public Board chessboard;
        public culoare_piesa cine_muta;
        public bool unde_mut;
        public Celula ce_mut;
        public List<Mutare> mutari_posibile_negre;
        public List<Mutare> mutari_posibile_albe;
        public Random random = new Random();
        public bool gata;

        public Game()
        {
            chessboard = new Board(0, 0);
            cine_muta = culoare_piesa.alb;
            unde_mut = false;
            mutari_posibile_negre = new List<Mutare>();
            mutari_posibile_albe = new List<Mutare>();
            gata = false;
        }

        public void genereaza_mutari_negre()
        {
            mutari_posibile_negre = null;
            mutari_posibile_negre = new List<Mutare>();
            for (int rand = 0; rand < 7; rand++)
            {
                for (int coloana = 0; coloana < 7; coloana++)
                {
                    if (!((rand >= 2) && (rand <= 4) && (coloana >= 2) && (coloana <= 4)))
                    {
                        if (chessboard.tabla[rand][coloana].piesa != null)
                        {
                            if (chessboard.tabla[rand][coloana].piesa.culoare == culoare_piesa.negru)
                            {

                                chessboard.tabla[rand][coloana].piesa.calculeaza_mutare_negre(chessboard, ref mutari_posibile_negre);
                            }
                        }
                    }
                }
            }
        }

        public void genereaza_mutari_albe()
        {
            mutari_posibile_albe = null;
            mutari_posibile_albe = new List<Mutare>();
            for (int rand = 0; rand < 7; rand++)
            {
                for (int coloana = 0; coloana < 7; coloana++)
                {
                    if (!(rand >= 2 && rand <= 4 && coloana >= 2 && coloana <= 4))
                    {
                        if (chessboard.tabla[rand][coloana].piesa != null)
                        {
                            if (chessboard.tabla[rand][coloana].piesa.culoare == culoare_piesa.alb)
                            {

                                chessboard.tabla[rand][coloana].piesa.calculeaza_mutare_albe(chessboard, ref mutari_posibile_albe);
                            }
                        }
                    }
                }
            }
        }

        public int verific_stare()
        {
            int ct = 0;
            int care_rege = 0;
            for (int rand = 0; rand < 7; rand++)
            {
                for (int coloana = 0; coloana < 7; coloana++)
                {
                    if (chessboard.tabla[rand][coloana].piesa != null && chessboard.tabla[rand][coloana].piesa.tip == tip_piesa.rege)
                    {
                        ct++;
                        if (chessboard.tabla[rand][coloana].piesa.culoare == culoare_piesa.alb)
                        {
                            care_rege = 1;
                        }
                        else
                        {
                            care_rege = 2;
                        }
                    }
                }
            }
            if (ct == 2)
            {
                if (chessboard.tabla[1][3].piesa != null && chessboard.tabla[1][3].piesa.tip == tip_piesa.rege && chessboard.tabla[1][3].piesa.culoare == culoare_piesa.alb)
                {
                    care_rege = 1;
                    ct--;

                }
                else if (chessboard.tabla[5][3].piesa != null && chessboard.tabla[5][3].piesa.tip == tip_piesa.rege && chessboard.tabla[5][3].piesa.culoare == culoare_piesa.negru)
                {
                    care_rege = 2;
                    ct--;

                }
            }
            if (ct == 1)
            {
                
                if (care_rege == 1)
                {
                    MessageBox.Show("Sfarsit joc, castiga alb, aplicatia se va inchide ");
                    return 1;
                }
                else if (care_rege == 2)
                {
                    MessageBox.Show("Sfarsit joc, castiga negru, aplicatia se va inchide ");
                    return 1;
                }
            }
            return 0;
          
        }

        public void muta_piesa(int rand_vechi, int coloana_veche, int rand_nou, int coloana_noua)
        {
            chessboard.tabla[rand_nou][coloana_noua].piesa = chessboard.tabla[rand_vechi][coloana_veche].piesa;
            chessboard.tabla[rand_vechi][coloana_veche].piesa = null;
            chessboard.tabla[rand_nou][coloana_noua].LoadImage();
            chessboard.tabla[rand_vechi][coloana_veche].LoadImage();
            chessboard.tabla[rand_nou][coloana_noua].piesa.rand = rand_nou;
            chessboard.tabla[rand_nou][coloana_noua].piesa.coloana = coloana_noua;

        }
        public void click_piesa(Celula c)
        {
            for (int rand = 0; rand < 7; rand++)
            {
                for (int coloana = 0; coloana < 7; coloana++)
                {
                    if (chessboard.tabla[rand][coloana].Equals(c))
                    {

                        if (unde_mut == false)
                        {
                            ce_mut = c;
                            unde_mut = !unde_mut;
                        }
                        else
                        {
                            
                            //muta_piesa(ce_mut.piesa.rand, ce_mut.piesa.coloana, rand, coloana);                           
                            int verificare=verific_stare();
                            if (verificare == 1)
                            {
                                chessboard.DisableAll();
                                Thread.Sleep(2000);
                                Application.Exit();
                            }
                            else
                            {
                                chessboard.DisableAll();
                                genereaza_mutari_negre();
                                mutari_posibile_negre = mutari_posibile_negre.OrderBy(order => order.scor).ToList();
                                int r;
                                if (mutari_posibile_negre[0].scor == mutari_posibile_negre[mutari_posibile_negre.Count - 1].scor)
                                {
                                    r = random.Next(0, mutari_posibile_negre.Count);
                                }
                                else
                                {
                                    int i = 0;
                                    for (i = mutari_posibile_negre.Count - 2; i >= 0; i--)
                                    {
                                        if (mutari_posibile_negre[mutari_posibile_negre.Count - 1].scor != mutari_posibile_negre[i].scor)
                                        {
                                            break;
                                        }
                                    }
                                    if (i == 0)
                                    {
                                        r = mutari_posibile_negre.Count - 1;
                                    }
                                    else
                                    {
                                        r = random.Next(i + 1, mutari_posibile_negre.Count);
                                    }

                                }
                                muta_piesa(mutari_posibile_negre[r].sursa_rand, mutari_posibile_negre[r].sursa_coloana, mutari_posibile_negre[r].destinatie_rand, mutari_posibile_negre[r].destinatie_coloana);
                                chessboard.EnableAll();


                                chessboard.DisableAll();
                                genereaza_mutari_albe();
                                mutari_posibile_albe = mutari_posibile_albe.OrderBy(order => order.scor).ToList();
                                int r2;
                                if (mutari_posibile_albe[0].scor == mutari_posibile_albe[mutari_posibile_albe.Count - 1].scor)
                                {
                                    r2 = random.Next(0, mutari_posibile_albe.Count);
                                }
                                else
                                {
                                    int i = 0;
                                    for (i = mutari_posibile_albe.Count - 2; i >= 0; i--)
                                    {
                                        if (mutari_posibile_albe[mutari_posibile_albe.Count - 1].scor != mutari_posibile_albe[i].scor)
                                        {
                                            break;
                                        }
                                    }
                                    if (i == 0)
                                    {
                                        r2 = mutari_posibile_albe.Count - 1;
                                    }
                                    else
                                    {
                                        r2 = random.Next(i + 1, mutari_posibile_albe.Count);
                                    }

                                }
                                muta_piesa(mutari_posibile_albe[r2].sursa_rand, mutari_posibile_albe[r2].sursa_coloana, mutari_posibile_albe[r2].destinatie_rand, mutari_posibile_albe[r2].destinatie_coloana);
                                chessboard.EnableAll();
                                verificare = verific_stare();
                                if (verificare == 1)
                                {
                                    chessboard.DisableAll();
                                    Thread.Sleep(2000);
                                    Application.Exit();
                                }
                                unde_mut = !unde_mut;
                            } 
                            

                        }
                    }
                }
                //}
            }

        }
    }
}
