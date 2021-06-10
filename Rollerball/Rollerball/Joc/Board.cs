
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rollerball
{
    class Board
    {
        public Panel spate_tabla;
        public Celula[][] tabla;

        public Board(int x, int y)
        {
            //tabla iamgine
            spate_tabla = new Panel();
            spate_tabla.BackgroundImage = Properties.Resources.chessboard;
            spate_tabla.SetBounds(x, y, 884, 904);
            spate_tabla.Visible = true;
            spate_tabla.BackColor = Color.Transparent;
            tabla = new Celula[7][];
            for (int rand = 0; rand < 7; rand++)
            {
                tabla[rand] = new Celula[7];
                for (int coloana = 0; coloana < 7; coloana++)
                {
                    //celule de joc
                    tabla[rand][coloana] = new Celula();
                    tabla[rand][coloana].Location = new Point(coloana * 124, rand * 124);
                    tabla[rand][coloana].Size = new Size(124, 124);
                    tabla[rand][coloana].Visible = true;
                    tabla[rand][coloana].piesa = null;
                    tabla[rand][coloana].SizeMode = PictureBoxSizeMode.CenterImage;


                    //piese negre pe tabla
                    if ((rand <= 1) && (coloana == 2))
                    {
                        tabla[rand][coloana].piesa = new Tura(culoare_piesa.negru);
                        tabla[rand][coloana].LoadImage();
                    }
                    if ((rand <= 1) && (coloana == 4))
                    {
                        tabla[rand][coloana].piesa = new Pion(culoare_piesa.negru);
                        tabla[rand][coloana].LoadImage();
                    }
                    if ((rand == 1) && (coloana == 3))
                    {
                        tabla[rand][coloana].piesa = new Rege(culoare_piesa.negru);
                        tabla[rand][coloana].LoadImage();
                    }
                    if ((rand == 0) && (coloana == 3))
                    {
                        tabla[rand][coloana].piesa = new Nebun(culoare_piesa.negru);
                        tabla[rand][coloana].LoadImage();
                    }
                    //piese albe pe tabla

                    if ((rand >= 5) && (coloana == 4))
                    {
                        tabla[rand][coloana].piesa = new Tura(culoare_piesa.alb);
                        tabla[rand][coloana].LoadImage();
                    }
                    if ((rand >= 5) && (coloana == 2))
                    {
                        tabla[rand][coloana].piesa = new Pion(culoare_piesa.alb);
                        tabla[rand][coloana].LoadImage();
                    }
                    if ((rand == 5) && (coloana == 3))
                    {
                        tabla[rand][coloana].piesa = new Rege(culoare_piesa.alb);
                        tabla[rand][coloana].LoadImage();
                    }
                    if ((rand == 6) && (coloana == 3))
                    {
                        tabla[rand][coloana].piesa = new Nebun(culoare_piesa.alb);
                        tabla[rand][coloana].LoadImage();
                    }
                    if (tabla[rand][coloana].piesa != null)
                    {
                        tabla[rand][coloana].piesa.coloana = coloana;
                        tabla[rand][coloana].piesa.rand = rand;
                    }

                    spate_tabla.Controls.Add(tabla[rand][coloana]);
                   
                }
            }
        }
        public void EnableAll()
        {
            spate_tabla.Enabled = true;
           
        }
        public void DisableAll()
        {
            spate_tabla.Enabled = false;
        }
    }
    
}

