using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace futbol
{
    public partial class Form1 : Form
    {
        //_________________________________________________________________
        int skor_kaleci =0,skor_oyuncu=0;
        cizim ciz = new cizim();
        int kaleci_x = 325, kaleci_y = 80;
        int top_x = 350, top_y = 200;
        bool baslat = false;
        int mod;
        Color kaleci_renk = Color.Black, top_renk=Color.Black;
        bool otomatik = false;
        bool asagi = false;
        Random r = new Random();

        //_________________________________________________________________



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!otomatik) {
                if (e.KeyData == Keys.A)
                {
                    ciz.dikdortgen_ciz(kaleci_x, kaleci_y, 50, 5, this, true, Color.DarkGreen);
                    kaleci_x = kaleci_x - 10;
                    ciz.dikdortgen_ciz(kaleci_x, kaleci_y, 50, 5, this, true, kaleci_renk);
                }
                if (e.KeyData == Keys.D)
                {
                    ciz.dikdortgen_ciz(kaleci_x, kaleci_y, 50, 5, this, true, Color.DarkGreen);
                    kaleci_x = kaleci_x + 10;
                    ciz.dikdortgen_ciz(kaleci_x, kaleci_y, 50, 5, this, true, kaleci_renk);
                }
            }
            
        }
        
        //******************************************************************************************
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = kaleci_renk; label2.ForeColor = top_renk;
            label1.Text = skor_kaleci.ToString();
            label2.Text = skor_oyuncu.ToString();
            labelTopX.Text = top_x.ToString();
            labelTopY.Text = top_y.ToString();
            if (baslat)
            {
                
                yan_firlat(mod);
                //duz_firlat();
            }
            else
            {
              

            }
           
            if (top_y <= 50 )
            {
                asagi = false;
                baslat = false;


                if(top_x >= 250 && top_x <= 450)
                skor_oyuncu++;
                top_x = 350; top_y = 200;


            }

        }
        //******************************************************************************************
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            otomatik = true;
        }
        //******************************************************************************************
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            otomatik = false;
        }
        //******************************************************************************************
        private void otomatik_kaleci_Tick(object sender, EventArgs e)
        {
            if (otomatik)
            {
                /************************************************************
                 *    KALECİNİN X POZİSYONUNU TOPUN X POZİSYONUNA EŞİTLE    *
                 ************************************************************/

                ciz.dikdortgen_ciz(kaleci_x, kaleci_y, 50, 5, this, true, Color.DarkGreen);
                kaleci_x = top_x-20;
                ciz.dikdortgen_ciz(kaleci_x, kaleci_y, 50, 5, this, true, kaleci_renk);


            }
        }
        //******************************************************************************************
        public void saha_cizdir()
        {
            ciz.dikdortgen_ciz(125, 20, 450, 275, this, true, Color.Black); 

            ciz.dikdortgen_ciz(150, 25, 400, 250, this, true, Color.DarkGreen);//çimen
            ciz.daire_ciz(300, 140, 100, 100, this, false, Color.White);// kalei öndeki yuvarlak
            ciz.dikdortgen_ciz(180, 70, 350, 150, this, true, Color.DarkGreen);
            ciz.dikdortgen_ciz(180, 70, 350, 150, this, false, Color.White); //kale ikinci kare
            
            ciz.dikdortgen_ciz(225, 70, 265, 60, this, false, Color.White);// kalei ilk kare
           
          
            ciz.dikdortgen_ciz(150, 50, 400, 2, this, true, Color.White); //kale arka çizgi
        }
        //******************************************************************************************
        private void kale_cizdir()
        {
            ciz.dikdortgen_ciz(250, 50, 200, 20, this, true, Color.GreenYellow);
            ciz.dikdortgen_ciz(250, 50, 200, 10, this, true, kaleci_renk); //arka
            ciz.dikdortgen_ciz(250, 50, 10, 25, this, true, kaleci_renk);  //sol
            ciz.dikdortgen_ciz(450, 50, 10, 25, this, true, kaleci_renk); //sag
        }
        //******************************************************************************************
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            int hiz = Convert.ToInt32(textBox1.Text);
            if (hiz <= 1)
                timer1.Interval = 20;
            else if (hiz == 2)
                timer1.Interval = 10;
            else if (hiz >=3)
                timer1.Interval = 1;
        }

        private void manuelMod_Click(object sender, EventArgs e)
        {
            if (panel1.Enabled == false)
            {
                panel1.Visible = true;
                panel1.Enabled = true;
                timer2.Enabled = false;
            }
                
            else
            {
                panel1.Visible = false;
                panel1.Enabled = false;
                timer2.Enabled = true;
            }
               


        }

        private void duzSut_Click(object sender, EventArgs e)
        {
            
                if (!baslat)
                {
                    mod = 0;
                    baslat = true;
                }

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!baslat)
            {
                mod = 3;
                baslat = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!baslat)
            {
                mod = 4;
                baslat = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!baslat)
            {
                mod = 1;
                baslat = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!baslat)
            {
                mod = 2;
                baslat = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              
                
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (!baslat)
                {
                    mod = r.Next(0, 5);
                    baslat = true;
                }

            }
        }

       

        public void yan_firlat(int mod)
        {

            if ( top_x >= kaleci_x-5 && top_x <= kaleci_x + 40 && top_y == kaleci_y)
            {
                skor_kaleci++;
                asagi = true;

            }

            if (asagi)
            {
                if (top_y <= 200)
                {
                    ciz.daire_ciz(top_x, top_y, 10, 10, this, true, Color.DarkGreen);
                    top_y = top_y +1;
                    ciz.daire_ciz(top_x, top_y, 10, 10, this, true, top_renk);

                }
                else
                {
                    asagi = false;
                    baslat = false;
                    top_x = 350; top_y = 200;

                    saha_cizdir();
                    kale_cizdir();
                    ciz.dikdortgen_ciz(kaleci_x, kaleci_y, 50, 5, this, true, kaleci_renk); //kaleci
                    ciz.daire_ciz(top_x, top_y, 10, 10, this, true, top_renk); //top
                }

            }
            else
            {
                ciz.daire_ciz(top_x, top_y, 10, 10, this, true, Color.DarkGreen);
                if (mod==0)
                {
                    //düz
                    
                    top_y = top_y - 10;
                    
                }
                else if (mod == 1)
                {
                    //sağ köşe
                    top_y = top_y - 10;
                    top_x = top_x + 6;
                   
                }
                else if (mod == 2)
                {
                    //sol köşe
                    top_y = top_y - 10;
                    top_x = top_x - 6;
                }
                else if (mod == 3)
                {
                    //sağ köşe orta
                    top_y = top_y - 10;
                    top_x = top_x + 4;
                }
                else if (mod == 4)
                {
                    //sol köşe orta
                    top_y = top_y - 10;
                    top_x = top_x - 4;
                }
                ciz.daire_ciz(top_x, top_y, 10, 10, this, true, top_renk);

            }


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            saha_cizdir();
            kale_cizdir();
            ciz.dikdortgen_ciz(kaleci_x, kaleci_y, 50, 5, this, true, kaleci_renk); //kaleci
            ciz.daire_ciz(top_x, top_y, 10, 10, this, true, top_renk); //top
        }
    }
}
