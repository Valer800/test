using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rollerball
{
    public partial class Form1 : Form
    {
        Game joc;
        public Form1()
        {

            InitializeComponent();
            joc = new Game();
            this.Controls.Add(joc.chessboard.spate_tabla);
            for (int rand = 0; rand < 7; rand++)
            {
                for (int coloana = 0; coloana < 7; coloana++)
                {
                    if (!((rand >= 2 && rand <= 4) && (coloana >= 2 && coloana <= 4))) //sa nu dau in mijloc click
                    {
                        joc.chessboard.tabla[rand][coloana].Click += tabla_click_piesa;

                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tabla_click_piesa(object sender, EventArgs e)
        {
            Celula celula_selectata = (Celula)sender;
            joc.click_piesa(celula_selectata);         
            //while (true)
            //{
            //    joc.click_piesa(celula_selectata);
            //}



        }
    }
}
