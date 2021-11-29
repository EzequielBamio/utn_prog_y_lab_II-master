using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMejorada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbOver.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gamespeed);
            enemy(5);
            gameover();
            coins(gamespeed);
            coincolletions();

        }

        int collectedcoin = 0;

        Random r = new Random();
        int x;
        void enemy(int speed)
        {
            if(pbAuto1.Top >= 500)
            {
                x = r.Next(0, 200);
                pbAuto1.Location = new Point(x, 0);
            
            }
            else
            { pbAuto1.Top += speed; }

            if (pbAuto2.Top >= 500)
            {
                x = r.Next(0, 400);
                pbAuto2.Location = new Point(x, 0);
            }
            else
            { pbAuto2.Top += speed; }

            if (pbAuto3.Top >= 500)
            {
                x = r.Next(200, 350);
                pbAuto3.Location = new Point(x, 0);
            }
            else
            { pbAuto3.Top += speed; }
        }
        void coins(int speed)
        {
            if (pbCoin1.Top >= 500)
            {
                x = r.Next(0, 200);
                pbCoin1.Location = new Point(x, 0);
            }
            else
            { pbCoin1.Top += speed; }

            if (pbCoin2.Top >= 500)
            {
                x = r.Next(0, 200);
                pbCoin2.Location = new Point(x, 0);
            }
            else
            { pbCoin2.Top += speed; }

            if (pbCoin3.Top >= 500)
            {
                x = r.Next(50, 300);
                pbCoin3.Location = new Point(x, 0);
            }
            else
            { pbCoin3.Top += speed; }

            if (pbCoin4.Top >= 500)
            {
                x = r.Next(0, 350);
                pbCoin4.Location = new Point(x, 0);
            }
            else
            { pbCoin4.Top += speed; }
            
        }

        void gameover()
        {
            if (pbAutoRojo.Bounds.IntersectsWith(pbAuto1.Bounds))
            {
                timer1.Enabled = false;
                lbOver.Visible = true;
            }
            if (pbAutoRojo.Bounds.IntersectsWith(pbAuto2.Bounds))
            {
                timer1.Enabled = false;
                lbOver.Visible = true;
            }
            if (pbAutoRojo.Bounds.IntersectsWith(pbAuto3.Bounds))
            {
                timer1.Enabled = false;
                lbOver.Visible = true;
            }
        }

        void moveLine(int speed)
        {
            if(pb1.Top >= 500)
            {pb1.Top = 0;}
            else
            {pb1.Top += speed;}

            if (pb2.Top >= 500)
            { pb2.Top = 0; }
            else
            { pb2.Top += speed; }

            if (pb3.Top >= 500)
            { pb3.Top = 0; }
            else
            { pb3.Top += speed; }

            if (pb4.Top >= 500)
            { pb4.Top = 0; }
            else
            { pb4.Top += speed; }
        }

        void coincolletions()
        {
            if (pbAutoRojo.Bounds.IntersectsWith(pbCoin1.Bounds))
            {
                collectedcoin++;
                lbCantidad.Text = "Coins =" + collectedcoin.ToString();
                x = r.Next(50, 300);
                pbCoin1.Location = new Point(x, 0);
            }
            if (pbAutoRojo.Bounds.IntersectsWith(pbCoin2.Bounds))
            {
                collectedcoin++;
                lbCantidad.Text = "Coins =" + collectedcoin.ToString();
                x = r.Next(50, 300);
                pbCoin2.Location = new Point(x, 0);
            }
            if (pbAutoRojo.Bounds.IntersectsWith(pbCoin3.Bounds))
            {
                collectedcoin++;
                lbCantidad.Text = "Coins =" + collectedcoin.ToString();
                x = r.Next(50, 300);
                pbCoin3.Location = new Point(x, 0);
            }
            if (pbAutoRojo.Bounds.IntersectsWith(pbCoin4.Bounds))
            {
                collectedcoin++;
                lbCantidad.Text = "Coins =" + collectedcoin.ToString();
                x = r.Next(50, 300);
                pbCoin4.Location = new Point(x, 0);
            }
        }

        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pbAutoRojo.Left > 20)
                {
                    pbAutoRojo.Left += -8;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pbAutoRojo.Right < 360)
                {
                    pbAutoRojo.Left += 8;
                }
            }
            if(e.KeyCode == Keys.Up)
            {
                if(gamespeed < 21)
                {
                    gamespeed++;
                }
            }
            if(e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }
            

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbClose_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
