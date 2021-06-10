using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rollerball
{
    class Celula:PictureBox
    {
        public Piesa piesa;

        public Celula()
        {
            if (piesa != null)
            {
                this.piesa.coloana = this.Location.X / 124;
                this.piesa.rand= this.Location.Y / 124;
            }
        }

        public void LoadImage()
        {
            Bitmap[][] Piese = new Bitmap[2][];

            Piese[0] = new Bitmap[4] { Properties.Resources.pion_alb, Properties.Resources.nebun_alb, Properties.Resources.tura_alb, Properties.Resources.rege_alb};
            Piese[1] = new Bitmap[4] { Properties.Resources.pion_negru, Properties.Resources.nebun_negru, Properties.Resources.tura_neagru, Properties.Resources.rege_negru};

            if (this.piesa != null)
            {

                this.Image = Piese[(int)this.piesa.culoare][(int)this.piesa.tip];
               
            }
            else
            {
                this.Image = null;
            }

           
        }
        

    }
}
