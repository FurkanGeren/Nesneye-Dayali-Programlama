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

using System.Numerics;
using System.Text.RegularExpressions;

namespace ndpödevi1
{
    public partial class Form1 : Form
    {
        
        
        
        
        
        
        
        string[] secimler = new string[] { "Seçiniz","Nokta","Çember","Dikdörtgen","Küre","Silindir","Yüzey","DikdörtgenPrizma","Dörtgen" };
        string[] secimler2 = new string[] { "Seçiniz", "Nokta", "Çember", "Dikdörtgen", "Küre", "Silindir", "Yüzey", "DikdörtgenPrizma", "Dörtgen" };
        public Form1()
        {
            InitializeComponent();
        }

        private void secim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            birincisecim.DataSource = secimler;
            ikincisecim.DataSource = secimler2;
            birincisecim.AutoCompleteMode = AutoCompleteMode.Suggest;
            birincisecim.AutoCompleteSource = AutoCompleteSource.ListItems;
            ikincisecim.AutoCompleteMode = AutoCompleteMode.Suggest;
            ikincisecim.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void birincionayla_Click(object sender, EventArgs e)
        {
            if (birincisecim.SelectedIndex == 0)
            {
                birincionayla.BackColor = Color.Red;
                MessageBox.Show("Lütfen bir seçenek seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                birincisecim.Focus(); // combobox'a odaklanarak tekrar seçim yapılmasını sağla
            }
            else 
            {
               
                birincionayla.BackColor = Color.Green;
                
                birincisecim.Enabled = false;
                birincionayla.Enabled = false; 
            }
            if(birincisecim.SelectedIndex == 1)
            {
                X1.Visible = true;
                xdeger1.Visible = true;
                Y1.Visible = true;
                ydeger1.Visible = true;
            }
            else if(birincisecim.SelectedIndex == 2)
            {
                X1.Visible = true;
                xdeger1.Visible = true;
                Y1.Visible = true;
                ydeger1.Visible = true;
                yaricap1.Visible = true;
                yaricapdeger1.Visible = true;
                yaricap1.Location = new Point(32, 144);
                yaricapdeger1.Location = new Point(32, 159);
                
                

            }
            else if(birincisecim.SelectedIndex == 3)
            {
                X1.Visible = true;
                xdeger1.Visible = true;
                Y1.Visible = true;
                ydeger1.Visible = true;
                yükseklik11.Location = new Point(32, 144);
                yukseklikdeger1.Location = new Point(32, 159);
                yükseklik11.Visible = true;
                yukseklikdeger1.Visible = true;
                genislik1.Visible = true;
                genislikdeger1.Visible = true;
            }
            else if(birincisecim.SelectedIndex == 4)
            {

                X1.Visible = true;
                xdeger1.Visible = true;
                Y1.Visible = true;
                ydeger1.Visible = true;
                Z1.Visible = true;
                zdeger1.Visible = true;
                yaricap1.Location = new Point(32, 185);
                yaricapdeger1.Location = new Point(32, 203);
                yaricap1.Visible = true;
                yaricapdeger1.Visible = true;
            }
            else if(birincisecim.SelectedIndex == 5)
            {
                X1.Visible = true;
                xdeger1.Visible = true;
                Y1.Visible = true;
                ydeger1.Visible = true;
                Z1.Visible = true;
                zdeger1.Visible = true;
                yükseklik11.Visible = true;
                yukseklikdeger1.Visible = true;
                yaricap1.Location = new Point(32, 185);
                yaricapdeger1.Location = new Point(32, 203);
                yaricap1.Visible = true;
                yaricapdeger1.Visible = true;
            }
            else if(birincisecim.SelectedIndex == 6)
            {
                X1.Visible = true;
                xdeger1.Visible = true;
                Y1.Visible = true;
                ydeger1.Visible = true;
                Z1.Visible = true;
                zdeger1.Visible = true;
                genislik1.Location = new Point(32, 185);
                genislikdeger1.Location = new Point(32, 203);
                genislik1.Visible = true;
                genislikdeger1.Visible = true;
                derinlik1.Visible = true;
                derinlikdeger1.Visible = true;

            }
            else if(birincisecim.SelectedIndex == 7)
            {
                
                X1.Visible = true;
                xdeger1.Visible = true;
                Y1.Visible = true;
                ydeger1.Visible = true;
                yükseklik11.Location = new Point(32, 144);
                yukseklikdeger1.Location = new Point(32, 159);
                yükseklik11.Visible = true;
                yukseklikdeger1.Visible = true;
                derinlik1.Location = new Point(32, 185);
                derinlikdeger1.Location = new Point(32, 203);
                derinlik1.Visible = true;
                derinlikdeger1.Visible=true;
                if (ikincisecim.SelectedIndex == 1)
                {
                    Z2.Visible = true;
                    zdeger2.Visible = true;

                }
            }          
            else if(birincisecim.SelectedIndex == 8)
            {
                X1.Visible = true;
                xdeger1.Visible = true;
                X3.Visible = true;
                xdeger3.Visible = true;
                X4.Visible = true;
                xdeger4.Visible = true;
                X5.Visible = true;
                xdeger5.Visible = true;
                X3.Location = new Point(32, 100);
                xdeger3.Location = new Point(32, 118);
                X4.Location = new Point(32, 144);
                xdeger4.Location = new Point(32, 159);
                X5.Location = new Point(32, 185);
                xdeger5.Location = new Point(32, 203);
                Y1.Visible = true;
                Y1.Location = new Point(32, 227);
                ydeger1.Visible = true;
                ydeger1.Location = new Point(32, 245);
                Y3.Visible = true;
                Y3.Location = new Point(32, 267);
                ydeger3.Visible = true;
                ydeger3.Location = new Point(32, 285);
                Y4.Visible = true;
                ydeger4.Visible=true;
                Y4.Location = new Point(32, 308);
                ydeger4.Location = new Point(32, 326);
                Y5.Visible = true;
                Y5.Location = new Point(32, 351);
                ydeger5.Visible = true;
                ydeger5.Location = new Point(32, 369);
            }

        }

        private void ikincionayla_Click(object sender, EventArgs e)
        {
            if (ikincisecim.SelectedIndex == 0)
            {
                ikincionayla.BackColor = Color.Red;
                MessageBox.Show("Lütfen bir seçenek seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                ikincisecim.Focus(); // combobox'a odaklanarak tekrar seçim yapılmasını sağla

            }
            else
            {
                ikincionayla.BackColor = Color.Green;
                ikincionayla.Enabled = false;
                ikincisecim.Enabled = false;
            }
            if (ikincisecim.SelectedIndex == 1)
            {
                X2.Visible = true;
                xdeger2.Visible = true;
                Y2.Visible = true;
                ydeger2.Visible = true;
            }
            else if (ikincisecim.SelectedIndex == 2)
            {
                X2.Visible = true;
                xdeger2.Visible = true;
                Y2.Visible = true;
                ydeger2.Visible = true;
                yaricap2.Visible = true;
                yaricapdeger2.Visible = true;
                yaricap2.Location = new Point(216, 144);
                yaricapdeger2.Location = new Point(216, 159);
                

            }
            else if (ikincisecim.SelectedIndex == 3)
            {
                X2.Visible = true;
                xdeger2.Visible = true;
                Y2.Visible = true;
                ydeger2.Visible = true;
                yükseklik22.Location = new Point(216, 144);
                yukseklikdeger2.Location = new Point(216, 159);
                yükseklik22.Visible = true;
                yukseklikdeger2.Visible = true;
                genislikdeger2.Visible = true;
                genislik2.Visible = true;
            }
            else if (ikincisecim.SelectedIndex == 4)
            {

                X2.Visible = true;
                xdeger2.Visible = true;
                Y2.Visible = true;
                ydeger2.Visible = true;
                Z2.Visible = true;
                zdeger2.Visible = true;
                yaricap2.Location = new Point(216, 185);
                yaricapdeger2.Location = new Point(216, 203);
                yaricap2.Visible = true;
                yaricapdeger2.Visible = true;
            }
            else if (ikincisecim.SelectedIndex == 5)
            {
                X2.Visible = true;
                xdeger2.Visible = true;
                Y2.Visible = true;
                ydeger2.Visible = true;
                Z2.Visible = true;
                zdeger2.Visible = true;
                yükseklik22.Visible = true;
                yukseklikdeger2.Visible = true;
                yaricap2.Location = new Point(216, 185);
                yaricapdeger2.Location = new Point(216, 203);
                yaricap2.Visible = true;
                yaricapdeger2.Visible = true;
            }
            else if (ikincisecim.SelectedIndex == 6)
            {
                X2.Visible = true;
                xdeger2.Visible = true;
                Y2.Visible = true;
                ydeger2.Visible = true;
                Z2.Visible = true;
                zdeger2.Visible = true;
                genislik2.Location = new Point(216, 185);
                genislikdeger2.Location = new Point(216, 203);
                genislik2.Visible = true;
                genislikdeger2.Visible = true;
                derinlik2.Visible = true;
                derinlikdeger2.Visible = true;
            }
            else if (ikincisecim.SelectedIndex == 7)
            {              
                X2.Visible = true;
                xdeger2.Visible = true;
                Y2.Visible = true;
                ydeger2.Visible = true;
                yükseklik22.Location = new Point(216, 144);
                yukseklikdeger2.Location = new Point(216, 159);
                yükseklik22.Visible = true;
                yukseklikdeger2.Visible = true;
                derinlik2.Location = new Point(216, 185);
                derinlikdeger2.Location = new Point(216, 203);
                derinlik2.Visible = true;
                derinlikdeger2.Visible = true;
                if(birincisecim.SelectedIndex == 1)
                {
                    Z1.Visible = true;
                    zdeger1.Visible = true;

                }
            }
            else if(ikincisecim.SelectedIndex == 8)
            {
                X2.Visible = true;
                xdeger2.Visible = true;
                X3.Visible = true;
                xdeger3.Visible = true;
                X4.Visible = true;
                xdeger4.Visible = true;
                X5.Visible = true;
                xdeger5.Visible = true;
                X3.Location = new Point(216, 100);
                xdeger3.Location = new Point(216, 118);
                X4.Location = new Point(216, 144);
                xdeger4.Location = new Point(216, 159);
                X5.Location = new Point(216, 185);
                xdeger5.Location = new Point(216, 203);
                Y2.Visible = true;
                Y2.Location = new Point(216, 227);
                ydeger2.Visible = true;
                ydeger2.Location = new Point(216, 245);
                Y3.Visible = true;
                Y3.Location = new Point(216, 267);
                ydeger3.Visible = true;
                ydeger3.Location = new Point(216, 285);
                Y4.Visible = true;
                ydeger4.Visible = true;
                Y4.Location = new Point(216, 308);
                ydeger4.Location = new Point(216, 326);
                Y5.Visible = true;
                Y5.Location = new Point(216, 351);
                ydeger5.Visible = true;
                ydeger5.Location = new Point(216, 369);

            }
        }

        private void degistir_Click(object sender, EventArgs e)
        {
            ikincionayla.Enabled = true;
            birincionayla.Enabled = true;
            birincisecim.Enabled = true;
            ikincisecim.Enabled = true;
            birincionayla.BackColor = Color.White;
            ikincionayla.BackColor = Color.White;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int carpisma = 2;
            int secim1 = 0;
            int secim2;
            int y3, y4, y5;
            int x5;
            int x3, x4;
            int x1, x2;
            int y1, y2;
            int z1, z2;
            int derinlik1, derinlik2;
            int yükseklik1, yükseklik2;
            int genislik1, genislik2;
            int yarıcap1, yarıcap2;
            //string strx = xdeger1.Text; 
            int.TryParse(ydeger5.Text, out y5);
            int.TryParse(ydeger3.Text, out y3);
            int.TryParse(ydeger4.Text, out y4);

            int.TryParse(xdeger5.Text, out x5);
            int.TryParse(xdeger3.Text, out x3);
            int.TryParse(xdeger4.Text, out x4);
            int.TryParse(xdeger1.Text, out x1);
            int.TryParse(xdeger2.Text, out x2);
            int.TryParse(ydeger1.Text, out y1);
            int.TryParse(ydeger2.Text, out y2);
            int.TryParse(zdeger1.Text, out z1);
            int.TryParse(zdeger2.Text, out z2);
            int.TryParse(derinlikdeger1.Text, out derinlik1);
            int.TryParse(derinlikdeger2.Text, out derinlik2);
            int.TryParse(yukseklikdeger1.Text, out yükseklik1);
            int.TryParse(yukseklikdeger2.Text, out yükseklik2);
            int.TryParse(genislikdeger1.Text, out genislik1);
            int.TryParse(genislikdeger2.Text, out genislik2);
            int.TryParse(yaricapdeger1.Text, out yarıcap1);
            int.TryParse(yaricapdeger2.Text, out yarıcap2);
            int[] dörtgenkose = new int[] { x1, x3, x4, x5 };
            int[] dörtgenkose2 = new int[] { x2, x3, x4, x5 };
            if (birincisecim.SelectedIndex == 1 && ikincisecim.SelectedIndex == 2 || birincisecim.SelectedIndex == 2 && ikincisecim.SelectedIndex == 1)
            {
                if (birincisecim.SelectedIndex == 1)
                {
                    secim1 = 12;
                    int mesafeX = x1 - x2;
                    int mesafeY = y1 - y2;
                    double mesafe = Math.Sqrt(mesafeX * mesafeX + mesafeY * mesafeY);
                    if (mesafe <= yarıcap2)
                    {
                        carpisma = 1;
                    }
                    else
                    {
                        carpisma = 0;
                    }
                }
                else
                {
                    secim1 = 21;
                    int mesafeX = x2 - x1;
                    int mesafeY = y2 - y1;
                    double mesafe = Math.Sqrt(mesafeX * mesafeX + mesafeY * mesafeY);
                    if (mesafe <= yarıcap1)
                    {
                        carpisma = 1;
                    }
                    else
                    {
                        carpisma = 0;
                    }
                }
            }
            else if (birincisecim.SelectedIndex == 3 && ikincisecim.SelectedIndex == 3)
            {
                secim1 = 33;
                if (x1 + genislik1 < x2 || // dikdörtgen 1 sağda
                   x1 > x2 + genislik2 || // dikdörtgen 1 solda
                   y1 + yükseklik1 < y2 || // dikdörtgen 1 altta
                   y1 > y2 + yükseklik2)
                {
                    carpisma = 1;
                }
                else
                {
                    carpisma = 0;
                }
            }
            else if (birincisecim.SelectedIndex == 3 && ikincisecim.SelectedIndex == 2 || birincisecim.SelectedIndex == 2 && ikincisecim.SelectedIndex == 3)
            {
                if (birincisecim.SelectedIndex == 3)
                {
                    secim1 = 32;
                    int dikdörtgenOrtaX = x1 + genislik1 / 2;
                    int dikdörtgenOrtaY = y1 + yükseklik1 / 2;
                    int deltaX = Math.Abs(x2 - x1);
                    int deltaY = Math.Abs(y2 - y1);

                    if (deltaX <= genislik1 / 2 || deltaY <= yükseklik1)
                    {
                        carpisma = 1;
                    }
                    int xUzaklık = deltaX - genislik1 / 2;
                    int yUzaklık = deltaY - yükseklik1 / 2;
                    int uzaklıkKare = xUzaklık * xUzaklık + yUzaklık * yUzaklık;
                    if (uzaklıkKare <= (yarıcap2 * yarıcap2))
                    {
                        carpisma = 1;
                    }
                    else
                    {
                        carpisma = 0;
                    }
                }
                else
                {
                    secim1 = 23;
                    int dikdörtgenOrtaX = x2 + genislik2 / 2;
                    int dikdörtgenOrtaY = y2 + yükseklik2 / 2;
                    int deltaX = Math.Abs(x1 - x2);
                    int deltaY = Math.Abs(y1 - y2);

                    if (deltaX <= genislik2 / 2 || deltaY <= yükseklik2)
                    {
                        carpisma = 1;
                    }
                    int xUzaklık = deltaX - genislik1 / 2;
                    int yUzaklık = deltaY - yükseklik1 / 2;
                    int uzaklıkKare = xUzaklık * xUzaklık + yUzaklık * yUzaklık;
                    if (uzaklıkKare <= (yarıcap1 * yarıcap1))
                    {
                        carpisma = 0;
                    }
                    else
                    {
                        carpisma = 0;
                    }
                }
            }
            else if (birincisecim.SelectedIndex == 2 && ikincisecim.SelectedIndex == 2)
            {
                secim1 = 22;
                int deltaX = x1 - x2;
                int deltaY = y1 - y2;
                double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
                if (distance <= yarıcap1 + yarıcap2)
                {
                    carpisma = 1;
                }
                else
                {
                    carpisma = 0;
                }
            }
            else if (birincisecim.SelectedIndex == 1 && ikincisecim.SelectedIndex == 4 || birincisecim.SelectedIndex == 4 && ikincisecim.SelectedIndex == 1)
            {
                if (birincisecim.SelectedIndex == 1)
                {
                    secim1 = 14;
                    int deltaX = x1 - x2;
                    int deltaY = y1 - y2;
                    int deltaZ = z1 - z2;
                    double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
                    if (distance <= yarıcap2)
                    {
                        carpisma = 1;
                    }
                    else
                    {
                        carpisma = 0;
                    }
                }
                else
                {
                    secim1 = 41;
                    int deltaX = x2 - x1;
                    int deltaY = y2 - y1;
                    int deltaZ = z2 - z1;
                    double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
                    if (distance <= yarıcap1)
                    {
                        carpisma = 1;
                    }
                    else
                    {
                        carpisma = 0;
                    }
                }
            }
            else if (birincisecim.SelectedIndex == 1 && ikincisecim.SelectedIndex == 3 || birincisecim.SelectedIndex == 3 && ikincisecim.SelectedIndex == 1)
            {
                if (birincisecim.SelectedIndex == 1)
                {
                    secim1 = 13;

                    int dikdortgenSagAltX = x2 + genislik2;
                    int dikdortgenSagAltY = y2 + yükseklik2;
                    if (x1 >= x2 && x1 <= x2 && y1 >= y2 && y1 <= y2)
                    {
                        carpisma = 1;
                    }
                    else
                    {
                        carpisma = 0;
                    }
                }
                else
                {
                    secim1 = 31;
                    int dikdortgenSagAltX = x1 + genislik1;
                    int dikdortgenSagAltY = y1 + yükseklik1;
                    if (x2 >= x1 && x2 <= x1 && y2 >= y1 && y2 <= y1)
                    {
                        carpisma = 1;
                    }
                    else
                    {
                        carpisma = 0;
                    }
                }
            }
            else if (birincisecim.SelectedIndex == 1 && ikincisecim.SelectedIndex == 5 || ikincisecim.SelectedIndex == 5 && ikincisecim.SelectedIndex == 1)
            {
                if (birincisecim.SelectedIndex == 1)
                {
                    secim1 = 15;
                    int silindirTabanY = y2 - (yükseklik2 / 2);
                    int yukseklikFarki = Math.Abs(z1 - y2);
                    if (yukseklikFarki <= yarıcap2)
                    {
                        int yatayFarkX = Math.Abs(x1 - x2);
                        int yatayFarkY = Math.Abs(y1 - y2);
                        if (yatayFarkX <= yarıcap2 && yatayFarkY <= yarıcap2)
                        {
                            carpisma = 1;
                        }
                    }
                    else
                    {
                        carpisma = 0;
                    }
                }
                else
                {
                    secim1 = 51;
                    int silindirTabanY = y1 - (yükseklik1 / 2);
                    int yukseklikFarki = Math.Abs(z2 - y1);
                    if (yukseklikFarki <= yarıcap2)
                    {
                        int yatayFarkX = Math.Abs(x2 - x1);
                        int yatayFarkY = Math.Abs(y2 - y1);
                        if (yatayFarkX <= yarıcap1 && yatayFarkY <= yarıcap1)
                        {
                            carpisma = 1;
                        }
                    }
                    else
                    {
                        carpisma = 0;
                    }
                }

            }
            else if (birincisecim.SelectedIndex == 5 && ikincisecim.SelectedIndex == 5)
            {
                secim1 = 55;
                int mesafe = (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

                // Eğer iki silindirin merkezleri arasındaki mesafe, iki silindirin yarıçaplarının toplamına eşit veya küçükse, 
                // iki silindir çarpışmaktadır.
                if (mesafe <= yarıcap1 + yarıcap2)
                {
                    carpisma = 1;
                }
                else
                {
                    carpisma = 0;
                }
            }
            else if (birincisecim.SelectedIndex == 4 && ikincisecim.SelectedIndex == 4)
            {
                secim1 = 44;
                int mesafe = (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

                // Eğer iki kürenin merkezleri arasındaki mesafe, iki kürenin yarıçaplarının toplamına eşit veya küçükse, 
                // iki küre çarpışmaktadır.
                if (mesafe <= yarıcap1 + yarıcap2)
                {
                    carpisma = 1;
                }
                else
                {
                    carpisma = 0;
                }
            }
            else if (birincisecim.SelectedIndex == 4 && ikincisecim.SelectedIndex == 3 || ikincisecim.SelectedIndex == 3 && ikincisecim.SelectedIndex == 4)
            {
                if (birincisecim.SelectedIndex == 4)
                {
                    secim1 = 43;
                    // Kürenin merkezi ile dikdörtgen arasındaki mesafeyi hesapla
                    float distX = Math.Abs(x1 - x2 - genislik2 / 2);
                    float distY = Math.Abs(y1 - y2 - yükseklik2 / 2);
                    float distZ = Math.Abs(z1 - z2 - derinlik2 / 2);

                    // Kürenin merkezi, dikdörtgenin sınırları içinde mi?
                    if (distX > (genislik2 / 2 + yarıcap1))
                    {
                        carpisma = 0;
                    }
                    if (distY > (yükseklik2 / 2 + yarıcap1))
                    {
                        carpisma = 0;
                    }
                    if (distZ > (derinlik2 / 2 + yarıcap1))
                    {
                        carpisma = 0;
                    }

                    // Kürenin merkezi, dikdörtgenin içinde mi?
                    if (distX <= (genislik2 / 2))
                    {
                        carpisma = 0;
                    }
                    if (distY <= (yükseklik2 / 2))
                    {
                        carpisma = 0;
                    }
                    if (distZ <= (derinlik2 / 2))
                    {
                        carpisma = 0;
                    }

                    // Kürenin merkezi, dikdörtgenin köşelerinden birinde mi?
                    float dx = distX - genislik2 / 2;
                    float dy = distY - yükseklik2 / 2;
                    float dz = distZ - derinlik2 / 2;
                    if (dx * dx + dy * dy + dz * dz <= (yarıcap1 * yarıcap1))
                    {
                        carpisma = 1;
                    }
                    else
                    {
                        carpisma = 0;
                    }
                }
                else
                {
                    secim1 = 34;
                    // Kürenin merkezi ile dikdörtgen arasındaki mesafeyi hesapla
                    float distX = Math.Abs(x2 - x1 - genislik1 / 2);
                    float distY = Math.Abs(y2 - y1 - yükseklik1 / 2);
                    float distZ = Math.Abs(z2 - z1 - derinlik1 / 2);

                    // Kürenin merkezi, dikdörtgenin sınırları içinde mi?
                    if (distX > (genislik1 / 2 + yarıcap2))
                    {
                        carpisma = 0;
                    }
                    if (distY > (yükseklik1 / 2 + yarıcap2))
                    {
                        carpisma = 0;
                    }
                    if (distZ > (derinlik1 / 2 + yarıcap2))
                    {
                        carpisma = 0;
                    }

                    // Kürenin merkezi, dikdörtgenin içinde mi?
                    if (distX <= (genislik1 / 2))
                    {
                        carpisma = 0;
                    }
                    if (distY <= (yükseklik1 / 2))
                    {
                        carpisma = 0;
                    }
                    if (distZ <= (derinlik1 / 2))
                    {
                        carpisma = 0;
                    }

                    // Kürenin merkezi, dikdörtgenin köşelerinden birinde mi?
                    float dx = distX - genislik1 / 2;
                    float dy = distY - yükseklik1 / 2;
                    float dz = distZ - derinlik1 / 2;
                    if (dx * dx + dy * dy + dz * dz <= (yarıcap2 * yarıcap2))
                    {
                        carpisma = 1;
                    }
                    else
                    {
                        carpisma = 0;
                    }
                }
            }
            else if (birincisecim.SelectedIndex == 7 && ikincisecim.SelectedIndex == 7)
            {
                secim1 = 77;
                double x33 = genislik1;
                double y33 = yükseklik1;
                double z3 = derinlik1;
                double x44 = genislik2;
                double y44 = yükseklik2;
                double z4 = derinlik2;

                double x_overlap = Math.Max(0, Math.Min(x33, x44) - Math.Max(0, x33 - x44));
                double y_overlap = Math.Max(0, Math.Min(y33, y44) - Math.Max(0, y33 - y44));
                double z_overlap = Math.Max(0, Math.Min(z3, z4) - Math.Max(0, z3 - z4));

                double overlapVolume = x_overlap * y_overlap * z_overlap;
                if (overlapVolume > 0)
                {
                    carpisma = 1;
                }
                else
                {
                    carpisma = 0;
                }

            }
            else if (birincisecim.SelectedIndex == 6 && ikincisecim.SelectedIndex == 4 || birincisecim.SelectedIndex == 4 && ikincisecim.SelectedIndex == 6)
            {
                if (birincisecim.SelectedIndex == 6)
                {
                    secim1 = 64;
                    if (x2 >= x1 && x2 <= x1 + genislik1 &&
                        y2 >= y1 && y2 <= y1 + derinlik1 &&
                        z2 >= z1 && z2 <= z1 + yarıcap2)
                    {
                        carpisma = 0;
                    }
                    else
                    {
                        carpisma = 1;
                    }

                }
                else
                {
                    secim1 = 46;
                    if (x1 >= x2 && x1 <= x2 + genislik2 &&
                        y1 >= y2 && y1 <= y2 + derinlik2 &&
                        z1 >= z2 && z1 <= z2 + yarıcap1)
                    {
                        carpisma = 0;
                    }
                    else
                    {
                        carpisma = 1;
                    }
                }
            }
            else if (birincisecim.SelectedIndex == 6 && ikincisecim.SelectedIndex == 5 || birincisecim.SelectedIndex == 5 && ikincisecim.SelectedIndex == 6)
            {

                if (birincisecim.SelectedIndex == 6)
                {
                    secim1 = 65;

                    int altZ = z2 - (yükseklik2 / 2);
                    int ustZ = z2 + (yükseklik2 / 2);

                    int dx = Math.Abs(x2 - (x1 + (genislik1 / 2)));

                    int dy = Math.Abs(y2 - (y1 + (derinlik2 / 2)));

                    if (dx <= (genislik1 / 2) + yarıcap2 && dy <= (yükseklik2 / 2) + yarıcap2)
                    {

                        if (altZ <= z1 && z1 <= ustZ)
                        {
                            carpisma = 1;
                        }
                        else if (altZ <= (z1 + yükseklik2) && (z1 + yükseklik2) <= ustZ)
                        {
                            carpisma = 0;
                        }
                        else if (altZ > z1 && ustZ < (z1 + yükseklik2))
                        {
                            carpisma = 0;
                        }
                        else
                        {
                            carpisma = 1;
                        }
                    }
                    else
                    {
                        carpisma = 1;
                    }
                }
                else
                {
                    secim1 = 56;
                    int altZ = z1 - (yükseklik1 / 2);
                    int ustZ = z1 + (yükseklik1 / 2);

                    int dx = Math.Abs(x1 - (x2 + (genislik2 / 2)));

                    int dy = Math.Abs(y1 - (y2 + (derinlik1 / 2)));

                    if (dx <= (genislik2 / 2) + yarıcap1 && dy <= (yükseklik1 / 2) + yarıcap1)
                    {

                        if (altZ <= z2 && z2 <= ustZ)
                        {
                            carpisma = 1;
                        }
                        else if (altZ <= (z2 + yükseklik1) && (z2 + yükseklik1) <= ustZ)
                        {
                            carpisma = 0;
                        }
                        else if (altZ > z2 && ustZ < (z2 + yükseklik1))
                        {
                            carpisma = 0;
                        }
                        else
                        {
                            carpisma = 1;
                        }
                    }
                    else
                    {
                        carpisma = 1;
                    }

                }
            }
            else if (birincisecim.SelectedIndex == 1 && ikincisecim.SelectedIndex == 8 || birincisecim.SelectedIndex == 8 && ikincisecim.SelectedIndex == 1)
            {
                if (birincisecim.SelectedIndex == 1)
                {
                    secim1 = 18;
                    int numberOfCorners = dörtgenkose2.Length / 2;

                    bool collision = false;
                    int i, j = numberOfCorners - 1;
                    for (i = 0; i < numberOfCorners; i++)
                    {
                        if ((dörtgenkose2[i * 2 + 1] < y1 && dörtgenkose2[j * 2 + 1] >= y1
                            || dörtgenkose2[j * 2 + 1] < y1 && dörtgenkose2[i * 2 + 1] >= y1)
                            && (dörtgenkose2[i * 2] + (y1 - dörtgenkose2[i * 2 + 1]) / (dörtgenkose2[j * 2 + 1] - dörtgenkose2[i * 2 + 1]) * (dörtgenkose2[j * 2] - dörtgenkose2[i * 2]) < x1))
                        {
                            collision = !collision;
                        }
                        j = i;
                    }
                    if (collision == true)
                    {
                        carpisma = 0;
                    }
                    else
                    {
                        carpisma = 1;
                    }

                }
                else
                {
                    secim1 = 81;
                    int numberOfCorners = dörtgenkose.Length / 2;

                    bool collision = false;
                    int i, j = numberOfCorners - 1;
                    for (i = 0; i < numberOfCorners; i++)
                    {
                        if ((dörtgenkose[i * 2 + 1] < y2 && dörtgenkose[j * 2 + 1] >= y2
                            || dörtgenkose[j * 2 + 1] < y2 && dörtgenkose[i * 2 + 1] >= y2)
                            && (dörtgenkose[i * 2] + (y2 - dörtgenkose[i * 2 + 1]) / (dörtgenkose[j * 2 + 1] - dörtgenkose[i * 2 + 1]) * (dörtgenkose[j * 2] - dörtgenkose[i * 2]) < x2))
                        {
                            collision = !collision;
                        }
                        j = i;
                    }
                    if (collision == true)
                    {
                        carpisma = 1;
                    }
                    else
                    {
                        carpisma = 0;
                    }
                }

            }
            else if (birincisecim.SelectedIndex == 1 && ikincisecim.SelectedIndex == 7 || birincisecim.SelectedIndex == 7 && ikincisecim.SelectedIndex == 1)
            {
                if (birincisecim.SelectedIndex == 1)
                {
                    secim1 = 17;
                    float xMin = x2;
                    float xMax = x2 + genislik2;
                    float yMin = y2;
                    float yMax = y2 + yükseklik2;
                    float zMin = z2;
                    float zMax = z2 + derinlik2;
                    if (x1 >= xMin && x1 <= xMax && y1 >= yMin && y1 <= yMax && z1 >= zMin && z1 <= zMax)
                    {
                        carpisma = 1;
                    }
                    else
                    {
                        carpisma = 0;
                    }

                }
                else
                {
                    secim1 = 71;
                    float xMin = x1;
                    float xMax = x1 + genislik1;
                    float yMin = y1;
                    float yMax = y1 + yükseklik1;
                    float zMin = z1;
                    float zMax = z1 + derinlik1;
                    if (x2 >= xMin && x2 <= xMax && y2 >= yMin && y2 <= yMax && z2 >= zMin && z2 <= zMax)
                    {
                        carpisma = 1;
                    }
                    else
                    {
                        carpisma = 0;
                    }
                }
            }
            else if (birincisecim.SelectedIndex == 4 && ikincisecim.SelectedIndex == 5 || birincisecim.SelectedIndex == 5 && ikincisecim.SelectedIndex == 4)
            {
                if (birincisecim.SelectedIndex == 4)
                {
                    secim1 = 45;
                    float distanceX = x1 - x2;
                    float distanceY = y1 - y2;
                    float distanceZ = z1 - z2;

                    float distance = (float)Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
                    float minDistance = 0.0f;
                    if (distance < yarıcap2)
                    {
                        // Küre merkezi silindir içindeyse
                        minDistance = distance - yarıcap1;
                    }
                    else if (distance < yarıcap2 + yarıcap1)
                    {
                        // Küre merkezi silindir yüzeyindeyse
                        minDistance = yarıcap2 + yarıcap1 - distance;
                    }
                    else
                    {
                        // Küre merkezi silindir dışında ise
                        minDistance = distance - yarıcap2 - yarıcap1;
                    }

                    if (minDistance <= 0.0f)
                    {
                        carpisma = 1;

                    }
                    else
                    {
                        carpisma = 0;

                    }


                }
                else
                {
                    secim1 = 54;
                    float distanceX = x2 - x1;
                    float distanceY = y2 - y1;
                    float distanceZ = z2 - z1;

                    float distance = (float)Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
                    float minDistance = 0.0f;
                    if (distance < yarıcap1)
                    {
                        // Küre merkezi silindir içindeyse
                        minDistance = distance - yarıcap2;
                    }
                    else if (distance < yarıcap1 + yarıcap2)
                    {
                        // Küre merkezi silindir yüzeyindeyse
                        minDistance = yarıcap1 + yarıcap2 - distance;
                    }
                    else
                    {
                        // Küre merkezi silindir dışında ise
                        minDistance = distance - yarıcap1 - yarıcap2;
                    }

                    if (minDistance <= 0.0f)
                    {
                        carpisma = 1;

                    }
                    else
                    {
                        carpisma = 0;

                    }
                }
            }
            else if (birincisecim.SelectedIndex == 4 && ikincisecim.SelectedIndex == 7 || birincisecim.SelectedIndex == 7 && ikincisecim.SelectedIndex == 4)
            {
                if (birincisecim.SelectedIndex == 4)
                {
                    secim1 = 47;
                    float sphereMinX = x1 - yarıcap1;
                    float sphereMaxX = x1 + yarıcap1;
                    float sphereMinY = y1 - yarıcap1;
                    float sphereMaxY = y1 + yarıcap1;
                    float sphereMinZ = z1 - yarıcap1;
                    float sphereMaxZ = z1 + yarıcap1;

                    float boxMinX = x2 - genislik2 / 2;
                    float boxMaxX = x2 + genislik2 / 2;
                    float boxMinY = y2 - yükseklik2 / 2;
                    float boxMaxY = y2 + yükseklik2 / 2;
                    float boxMinZ = z2 - derinlik2 / 2;
                    float boxMaxZ = z2 + derinlik2 / 2;

                    if (sphereMaxX < boxMinX || sphereMinX > boxMaxX)
                    {
                        carpisma = 0;
                    }

                    if (sphereMaxY < boxMinY || sphereMinY > boxMaxY)
                    {
                        carpisma = 0;
                    }

                    if (sphereMaxZ < boxMinZ || sphereMinZ > boxMaxZ)
                    {
                        carpisma = 0;
                    }
                    else
                    {
                        carpisma = 1;
                    }
                }
                else
                {
                    secim1 = 74;
                    float sphereMinX = x2 - yarıcap2;
                    float sphereMaxX = x2 + yarıcap2;
                    float sphereMinY = y2 - yarıcap2;
                    float sphereMaxY = y2 + yarıcap2;
                    float sphereMinZ = z2 - yarıcap2;
                    float sphereMaxZ = z2 + yarıcap2;

                    float boxMinX = x1 - genislik1 / 2;
                    float boxMaxX = x1 + genislik1 / 2;
                    float boxMinY = y1 - yükseklik1 / 2;
                    float boxMaxY = y1 + yükseklik1 / 2;
                    float boxMinZ = z1 - derinlik1 / 2;
                    float boxMaxZ = z1 + derinlik1 / 2;

                    if (sphereMaxX < boxMinX || sphereMinX > boxMaxX)
                    {
                        carpisma = 0;
                    }

                    if (sphereMaxY < boxMinY || sphereMinY > boxMaxY)
                    {
                        carpisma = 0;
                    }

                    if (sphereMaxZ < boxMinZ || sphereMinZ > boxMaxZ)
                    {
                        carpisma = 0;
                    }
                    else
                    {
                        carpisma = 1;
                    }
                }
            }
            else if (birincisecim.SelectedIndex == 6 && ikincisecim.SelectedIndex == 7 || birincisecim.SelectedIndex == 7 && ikincisecim.SelectedIndex == 6)
            {
                if (birincisecim.SelectedIndex == 6)
                {
                    secim1 = 67;
                    Vector3 prizmaKose = new Vector3(x2, y2, z2); // Prizmanın üst sol köşesi, (3, 0, 3)
                    // Dikdörtgen prizma ve zemin arasındaki mesafe
                    float prizmaMesafeY = Math.Abs(prizmaKose.Y - y1);

                    // Dikdörtgen prizma-zemin çarpışması kontrolü
                    if (prizmaMesafeY <= yükseklik2 / 2f)
                    {
                        float prizmaX1 = prizmaKose.X;
                        float prizmaX2 = prizmaKose.X + genislik2;
                        float prizmaZ1 = prizmaKose.Z;
                        float prizmaZ2 = prizmaKose.Z + derinlik2;

                        if (prizmaX2 >= x1 && prizmaX1 <= (x1 + genislik1) && prizmaZ1 >= z1 && prizmaZ1 <= (z1 + derinlik1))
                        {
                            carpisma = 0;
                        }
                        else
                        {
                            carpisma = 1;
                        }
                    }
                }
            }
            else
            {
                secim1 = 76;
                Vector3 prizmaKose = new Vector3(x1, y1, z1); // Prizmanın üst sol köşesi, (3, 0, 3)
                                                              // Dikdörtgen prizma ve zemin arasındaki mesafe
                float prizmaMesafeY = Math.Abs(prizmaKose.Y - y2);

                // Dikdörtgen prizma-zemin çarpışması kontrolü
                if (prizmaMesafeY <= yükseklik1 / 2f)
                {
                    float prizmaX1 = prizmaKose.X;
                    float prizmaX2 = prizmaKose.X + genislik1;
                    float prizmaZ1 = prizmaKose.Z;
                    float prizmaZ2 = prizmaKose.Z + derinlik1;

                    if (prizmaX2 >= x2 && prizmaX1 <= (x2 + genislik2) && prizmaZ2 >= z2 && prizmaZ1 <= (z2 + derinlik2))
                    {
                        carpisma = 0;
                    }
                    else
                    {
                        carpisma = 1;
                    }
                }
            }
        
            


            secim2 = secim1;
            Form2 frm2 = new Form2(x1, x2, x3, x4, x5, y1, y2, z1, z2, derinlik1, derinlik2, yükseklik1, yükseklik2, genislik1, genislik2, yarıcap1, yarıcap2, secim2,y3,y4,y5, carpisma);

            button1.BackColor = Color.Green;
            
            frm2.Show();
            this.Hide();
        }

        private void xdeger1_Enter(object sender, EventArgs e)
        {
            if (xdeger1.Text == "Sol alt noktası")
            {
                xdeger1.Text = "";
                xdeger1.ForeColor = Color.Black;
            }
        }
        
        private void xdeger1_Leave(object sender, EventArgs e)
        {
           
        }

        private void ydeger1_Enter(object sender, EventArgs e)
        {
            if (xdeger1.Text == "Sol alt noktası")
            {
                xdeger1.Text = "";
                xdeger1.ForeColor = Color.Black;
            }
        }

        private void zdeger1_Enter(object sender, EventArgs e)
        {
            if (xdeger1.Text == "Sol alt noktası")
            {
                xdeger1.Text = "";
                xdeger1.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}