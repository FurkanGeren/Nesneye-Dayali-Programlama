/****************************************************************************
**                          SAKARYA ÜNİVERSİTESİ
**                 BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                     BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                      PROGRAMLAMAYA GİRİŞİ DERSİ
**
**      ÖDEV NUMARASI: 1
**      ÖĞRENCİ ADI:Furkan Geren    
**      ÖĞRENCİ NUMARASI.:G221210376
**      DERS GRUBU…………: 2-B
**      YOUTUBE LİNKİ… …: https://www.youtube.com/watch?v=Dmi4a9IwQ1o
****************************************************************************/





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;




namespace ndpödevi1
{
    public partial class Form2 : Form 
    {
        public TextBox Xdeger1 { get; }
        public TextBox Xdeger2 { get; }
        public TextBox Xdeger3 { get; }
        public TextBox Xdeger4 { get; }
        public TextBox Xdeger5 { get; }
        public TextBox Ydeger1 { get; }
        public TextBox Ydeger2 { get; }
        public TextBox Zdeger1 { get; }
        public TextBox Zdeger2 { get; }
        public TextBox Yukseklikdeger1 { get; }
        public TextBox Yukseklikdeger2 { get; }
        public TextBox Derinlikdeger1 { get; }
        public TextBox Derinlikdeger2 { get; }
        public TextBox Genislikdeger1 { get; }
        public TextBox Genislikdeger2 { get; }
        public TextBox Yaricapdeger1 { get; }
        public TextBox Yaricapdeger2 { get; }

        private int X1;
        private int X2;
        private int X3;
        private int X4;
        private int X5;
        private int Y1;
        private int Y2;
        private int Z1;
        private int Z2;
        private int Derinlik1;
        private int Derinlik2;
        private int Yükseklik1;
        private int Yükseklik2;
        private int Genislik1;
        private int Genislik2;
        private int Yaricap1;
        private int Yaricap2;
        private int Secim1;
        private int Y3;
        private int Y4;
        private int Y5;
        private int car;

        private int c;

        public Form2(int x1, int x2, int x3, int x4, int x5, int y1, int y2, int z1, int z2, int derinlik1, int derinlik2, int yükseklik1, int yükseklik2, int genislik1, int genislik2, int yarıcap1, int yarıcap2,int secim2, int y3, int y4, int y5,int carpisma)
        {
            Secim1 = secim2;
            X1 = x1;
            X2 = x2;
            X3 = x3;
            X4 = x4;
            X5 = x5;
            Y1 = y1;
            Y2 = y2;
            Y3 = y3;
            Y4 = y4;
            Y5 = y5;
            Z1 = z1;
            Z2 = z2;
            car = carpisma;
            Derinlik1 = derinlik1;
            Derinlik2 = derinlik2;
            Yükseklik1 = yükseklik1;
            Yükseklik2 = yükseklik2;
            Genislik1 = genislik1;
            Genislik2 = genislik2;
            Yaricap1 = yarıcap1;
            Yaricap2 = yarıcap2;
            
            InitializeComponent();
            
        }
        private void DrawPoint(PaintEventArgs e)
        {

        }


        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {      

           
            



        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void ciz_Click(object sender, EventArgs e)
        {
             if (Secim1 == 18 )
            {
           
                 Graphics g = this.CreateGraphics();
                 g.DrawEllipse(Pens.Black, X1, Y1, 2, 2);

                Graphics g2 = this.CreateGraphics();
                Pen pen = new Pen(Color.Black);
                g2.DrawLine(pen, X2, Y2, X3, Y3);
                g2.DrawLine(pen, X3, Y3, X4, Y4);
                g2.DrawLine(pen, X4, Y4, X5, Y5);
                g2.DrawLine(pen, X5, Y5, X2, Y2);
            
            }
            else if(Secim1 == 81)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X2, Y2, 2, 2);

                Graphics g2 = this.CreateGraphics();
                Pen pen = new Pen(Color.Black); 
                g2.DrawLine(pen, X1, Y1, X3, Y3);
                g2.DrawLine(pen, X3, Y3, X4, Y4);
                g2.DrawLine(pen, X4, Y4, X5, Y5);
                g2.DrawLine(pen, X5, Y5, X1, Y1);
            }
            else if (Secim1 == 12)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X1, Y1, 2, 2);

                Graphics g2 = this.CreateGraphics();
                Pen pen = new Pen(Color.Black);
                g2.DrawEllipse(pen, X2 - Yaricap2, Y2 - Yaricap2,Yaricap2 * 2, Yaricap2 * 2);


            }
             else if(Secim1 == 21)
            {

                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X2, Y2, 2, 2);

                Graphics g2 = this.CreateGraphics();
                Pen pen = new Pen(Color.Black);
                g2.DrawEllipse(pen, X1 - Yaricap1, Y1 - Yaricap1, Yaricap1 * 2, Yaricap1 * 2);
            }
             else if(Secim1 == 33)
            {
                Graphics g = this.CreateGraphics();
                g.DrawRectangle(Pens.Black, X1, Y1,Genislik1 , Yükseklik1);

                Graphics g2 = this.CreateGraphics();
                g2.DrawRectangle(Pens.Black, X2, Y2, Genislik2, Yükseklik2);

            }
             else if(Secim1 == 32)
            {
                Graphics g = this.CreateGraphics();
                g.DrawRectangle(Pens.Black, X1, Y1, Genislik1, Yükseklik1);
                Graphics g2 = this.CreateGraphics();
                Pen pen = new Pen(Color.Black);
                g2.DrawEllipse(pen, X2 - Yaricap2, Y2 - Yaricap2, Yaricap2 * 2, Yaricap2 * 2);
            }
             else if(Secim1 == 23)
            {
                Graphics g = this.CreateGraphics();
                g.DrawRectangle(Pens.Black, X2, Y2, Genislik2, Yükseklik2);
                Graphics g2 = this.CreateGraphics();
                Pen pen = new Pen(Color.Black);
                g2.DrawEllipse(pen, X1 - Yaricap1, Y1 - Yaricap1, Yaricap1 * 2, Yaricap1 * 2);
            }
             else if(Secim1 == 22)
            {
                Graphics g1 = this.CreateGraphics();
                Pen pen = new Pen(Color.Black);
                g1.DrawEllipse(pen, X1 - Yaricap1, Y1 - Yaricap1, Yaricap1 * 2, Yaricap1 * 2);

                Graphics g2 = this.CreateGraphics();
                Pen pen2 = new Pen(Color.Black);
                g2.DrawEllipse(pen2, X2 - Yaricap2, Y2 - Yaricap2, Yaricap2 * 2, Yaricap2 * 2);
            }
             else if(Secim1 == 14)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X1, Y1, 2, 2);

                g.DrawEllipse(Pens.Black, X2 - Yaricap2, Y2 - Yaricap2, 2 * Yaricap2, 2 * Yaricap2);

                
               

            }
             else if (Secim1 == 41)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X2, Y2, 2, 2);
                g.DrawEllipse(Pens.Black, X1 - Yaricap1, Y1 - Yaricap1, 2 * Yaricap1, 2 * Yaricap1);
            }
             else if(Secim1 == 13)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X1, Y1, 2, 2);
                Graphics g2 = this.CreateGraphics();
                g2.DrawRectangle(Pens.Black, X2, Y2, Genislik2, Yükseklik2);
            }
             else if(Secim1 == 31)
            {
                Graphics g2 = this.CreateGraphics();
                g2.DrawRectangle(Pens.Black, X1, Y1, Genislik1, Yükseklik1);
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X2, Y2, 2, 2);
            }
             else if(Secim1 == 15)
            {
              
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X1, Y1, 2, 2);

                g.DrawRectangle(Pens.Black, X2, Y2, Yaricap2 * 2, Yükseklik2);
                

            }
             else if(Secim1 == 51)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X2, Y1, 2, 2);

              
                g.DrawRectangle(Pens.Black, X1, Y1, Yaricap1 * 2, Yükseklik1);

            }
            else if (Secim1 == 55)
            {
                Graphics g = this.CreateGraphics();
           
                Pen myPen = new Pen(Color.Black);
                g.DrawRectangle(Pens.Black, X1, Y1, Yaricap1 * 2, Yükseklik1);
                g.DrawRectangle(Pens.Black, X2, Y2, Yaricap2 * 2, Yükseklik2);

            }
            else if(Secim1 == 44)
            {
                Graphics g = this.CreateGraphics();
               
                g.DrawEllipse(Pens.Black, X1 - Yaricap1, Y1 - Yaricap1, 2 * Yaricap1, 2 * Yaricap1);

                g.DrawEllipse(Pens.Black, X2 - Yaricap2, Y2 - Yaricap2, 2 * Yaricap2, 2 * Yaricap2);
            }
             else if(Secim1 == 43)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X1 - Yaricap1, Y1 - Yaricap1, 2 * Yaricap1, 2 * Yaricap1);
                g.DrawRectangle(Pens.Black, X2, Y2, Genislik2, Yükseklik2);

            }
             else if( Secim1 == 34)
            {
                Graphics g = this.CreateGraphics();
                g.DrawRectangle(Pens.Black, X1, Y1, Genislik1, Yükseklik1);

                g.DrawEllipse(Pens.Black, X2 - Yaricap2, Y2 - Yaricap2, 2 * Yaricap2, 2 * Yaricap2);
            }
             else if(Secim1 == 45)
            {
                Graphics g = this.CreateGraphics();

                g.DrawEllipse(Pens.Black, X1 - Yaricap1, Y1 - Yaricap1, 2 * Yaricap1, 2 * Yaricap1);

                g.DrawRectangle(Pens.Black, X2, Y2, Yaricap2 * 2, Yükseklik2);
                
            }
             else if(Secim1 == 54)
            {
                Graphics g = this.CreateGraphics();
               
                g.DrawRectangle(Pens.Black, X1, Y1, Yaricap1 * 2, Yükseklik1);

                g.DrawEllipse(Pens.Black, X2 - Yaricap2, Y2 - Yaricap2, 2 * Yaricap2, 2 * Yaricap2);

            }
             else if (Secim1 == 77)
            {
                Graphics g = this.CreateGraphics();
                
                g.DrawRectangle(Pens.Black, X2, Y2, Derinlik2, Yükseklik2);
                g.DrawRectangle(Pens.Black, X1, Y1, Derinlik1, Yükseklik1);
            }
             else if (Secim1 == 17)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X1, Y1, 2, 2);
                g.DrawRectangle(Pens.Black, X2, Y2, Derinlik2, Yükseklik2);
            }
             else if(Secim1 == 71)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X2, Y2, 2, 2);
                g.DrawRectangle(Pens.Black, X1, Y1, Derinlik1, Yükseklik1);
            }
            else if (Secim1 == 47)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X1 - Yaricap1, Y1 - Yaricap1, 2 * Yaricap1, 2 * Yaricap1);
                g.DrawRectangle(Pens.Black, X2, Y2, Derinlik2, Yükseklik2);
            }
            else if (Secim1 == 74)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X2 - Yaricap2, Y2 - Yaricap2, 2 * Yaricap2, 2 * Yaricap2);
                g.DrawRectangle(Pens.Black, X1, Y1, Derinlik1, Yükseklik1);
            }
            else if (Secim1 == 64)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X2 - Yaricap2, Y2 - Yaricap2, 2 * Yaricap2, 2 * Yaricap2);
                g.DrawLine(Pens.Black, X1, Y1, (X1 + Genislik1), Y1);
            }
            else if (Secim1 == 46)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black, X1 - Yaricap1, Y1 - Yaricap1, 2 * Yaricap1, 2 * Yaricap1);
                g.DrawLine(Pens.Black, X2, Y2, (X2 + Genislik2), Y2);
            }
            else if (Secim1 == 56)
            {
                
                Graphics g = this.CreateGraphics();
                g.DrawRectangle(Pens.Black, X1, Y1, Yaricap1 * 2, Yükseklik1);
                g.DrawLine(Pens.Black, X2, Y2, (X2 + Genislik2), Y2);
            }
            else if (Secim1 == 65)
            {

                Graphics g = this.CreateGraphics();
                g.DrawRectangle(Pens.Black, X2, Y2, Yaricap2 * 2, Yükseklik2);
                g.DrawLine(Pens.Black, X1, Y1, (X1 + Genislik1), Y1);
            }
            else if(Secim1 == 67)
            {
                Graphics g = this.CreateGraphics();
                g.DrawRectangle(Pens.Black, X2, Y2, Derinlik2, Yükseklik2);
                g.DrawLine(Pens.Black, X1, Y1, (X1 + Genislik1), Y1);
            }
            else if (Secim1 == 76)
            {
                Graphics g = this.CreateGraphics();
                g.DrawRectangle(Pens.Black, X1, Y1, Derinlik1, Yükseklik1);
                g.DrawLine(Pens.Black, X2, Y2, (X2 + Genislik2), Y2);
            }



            if (car == 1)
            {
                MessageBox.Show("Çarpışma Yok !!", "Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (car == 0)
            {
                
                MessageBox.Show("Çarpışma Var !!", "Kontrol", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Hatalı İşlem !!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
    
    }

