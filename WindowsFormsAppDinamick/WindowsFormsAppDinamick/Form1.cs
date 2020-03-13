using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDinamick
{
    public partial class Form1 : Form
    {
       

        List<Image> kepek = new List<Image>();

        public Form1()
        {
            InitializeComponent();
            kepek.Add(Image.FromFile("kep1.jpg"));
            kepek.Add(Image.FromFile("kep2.jpg"));
            kepek.Add(Image.FromFile("kep3.jpg"));
        }


        int[,] tablazat;
        int X;
         int Y;
        private object pb;

        void TablzatMegjelenites() {

            gombPanel.Controls.Clear();

            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    var pb = new PictureBox();
                    int i2 = i;
                    int j2 = j;

                    pb.Image = kepek[tablazat[i2, j2]];
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.SetBounds(i * 40, j * 40, 40, 40);


                    //Lamda Fügvény
                    pb.Click += (s2, m2) => {
                        tablazat[i2, j2]++;
                        if (tablazat[i2, j2] >= kepek.Count)
                        {
                            tablazat[i2, j2] = 0;
                        }
                        pb.Image = kepek[tablazat[i2, j2]];


                        /*
                                                if (pb.Image == kepek[0])
                                                {
                                                    pb.Image = kepek[1];
                                                }
                                                else if (pb.Image == kepek[1])
                                                {
                                                    pb.Image = kepek[2];
                                                }
                                                else {
                                                    pb.Image = kepek[0];
                                                }*/


                    };


                    gombPanel.Controls.Add(pb);



                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            


             X=(int) NumUpDX.Value;
            Y = (int)NumUpDY.Value;
          
            tablazat = new int[X, Y];

            TablzatMegjelenites();


            /*  for (int i = 0; i < X; i++)
             {
                 for (int j = 0; j < Y; j++)
                 {
                     var gomb = new Button();
                     int i2 = i;
                     int j2 = j;

                     gomb.Text = ("X");

                     gomb.SetBounds(i * 50, j * 50, 50, 50);

                     //Lamda Fügvény
                     gomb.Click += (s2, m2) => {

                         MessageBox.Show(i2+","+j2);
                         gomb.BackColor = Color.Aquamarine;

                     };
                    var szin = Color.FromArgb(100 + i * 10, 100 + j * 10, 255);
                     gomb.BackColor = szin;
                     gomb.MouseEnter += (s2, m2) => {


                         gomb.BackColor = Color.Purple;

                     };
                     gomb.MouseLeave += (s2, m2) => {

                         gomb.BackColor = szin;

                     };





            gombPanel.Controls.Add(gomb);



                }

        }*/
        }

        private void mentesButton_Click(object sender, EventArgs e)
        {
            using (var file = File.CreateText("adat.csv"))
            {
                file.WriteLine(X + "," + Y);

                for (int j = 0; j < Y; j++)
                {
                    for (int i = 0; i < X; i++)
                        {
                        file.Write(tablazat[i, j]);
                        if (j != X - 1) 
                        {
                            file.Write(",");
                        }
                    }
                    file.WriteLine();
                }
            }
        }

        private void beolvasasButt_Click(object sender, EventArgs e)
        {

            using (var file = File.OpenText("adat.csv")) {
                string elsosor = file.ReadLine();
                string[] elsosorAdat = elsosor.Split(',');
                X = int.Parse(elsosorAdat[0]);
                Y = int.Parse(elsosorAdat[1]);
                tablazat = new int[X, Y];
                for (int j = 0; j < Y; j++)
                {
                    string sor = file.ReadLine();
                    string[] sorAdat = sor.Split(',');
                    for (int i = 0; i < X; i++)
                    {
                        tablazat[i, j] = int.Parse(sorAdat[i]);
                    }
                
                }
                TablzatMegjelenites();


            }




        }
    }
}
