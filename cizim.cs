using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futbol
{
    class cizim
    {
        public cizim()
        {
        }
        public void daire_ciz(int x, int y, int gen, int yuk, Form frm, bool dolumu, Color renk)
        {
            Graphics g = frm.CreateGraphics();
            Pen kalem = new Pen(renk, 3);
            Brush firca = new SolidBrush(renk);
            if (dolumu == true)
                g.FillEllipse(firca, x, y, gen, yuk);
            else
                g.DrawEllipse(kalem, x, y, gen, yuk);

            g.Dispose();
        }
        public void dikdortgen_ciz(int x, int y, int gen, int yuk, Form frm, bool dolumu, Color renk)
        {
            Graphics g = frm.CreateGraphics();
            Pen kalem = new Pen(renk, 3);
            Brush firca = new SolidBrush(renk);
            if (dolumu == true)
                g.FillRectangle(firca, x, y, gen, yuk);
            else
                g.DrawRectangle(kalem, x, y, gen, yuk);

            g.Dispose();
        }
    }
}
