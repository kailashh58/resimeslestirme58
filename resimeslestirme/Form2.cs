using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resimeslestirme
{
    public partial class Form2 : Form
    {

        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6,7,7,8,8,9,9,10,10,11,11,12,12,13,13,14,14,15,15};
        string birincisecenek;
        string ikincisecenek;
        int tries;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        bool gameIsOver;






        public Form2()
        {
            InitializeComponent();
            resimyukle();
        }

     

        private void tekrarbaslat_Click(object sender, EventArgs e)
        {
            tekrarrbaslat();
        }
        private void resimyukle()
        {
            int leftpos = 40;
            int toppos = 120;
            int rows = 0;
            for (int i = 0; i < 30; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 70;
                newPic.Width = 70;
                newPic.BackColor = Color.LightGray;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click;
                pictures.Add(newPic);

                if (rows < 5)
                {
                    rows++;
                    newPic.Left = leftpos;
                    newPic.Top = toppos;
                    this.Controls.Add(newPic);
                    leftpos = leftpos + 85;
                }
                if (rows == 5)
                {
                    leftpos = 40;
                    toppos += 90;
                    rows = 0;
                }

                  }
            tekrarrbaslat();
        }

        private void NewPic_Click(object? sender, EventArgs e)
        {
            if (birincisecenek == null)
            {
                picA = sender as PictureBox;

                if(picA.Tag != null && picA.Image == null)
                {
                    picA.Image = Image.FromFile("../../../pictures/" + (string)picA.Tag + ".png");
                    birincisecenek = (string)picA.Tag;
                }
            



            }
            else if (ikincisecenek == null)
            {
                picB = sender as PictureBox;

                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("../../../pictures/" + (string)picB.Tag + ".png");
                    ikincisecenek = (string)picB.Tag;

                }
                



            }
            else
            {
                fotografkontrol(picA, picB);
            }



        }

        private void tekrarrbaslat() //fonks
        {
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();
            numbers = randomList;

            for(int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();

                tries = 0;
               


            }
        }
        private void fotografkontrol(PictureBox A,PictureBox B)
        {
            if (birincisecenek == ikincisecenek)
            {
                A.Tag = null;
                B.Tag = null;
            }
            else
            {
                tries++;
            }
            birincisecenek = null;
            ikincisecenek = null;

            foreach(PictureBox pics in pictures.ToList())
            {
             if(pics.Tag!= null)
                {
                    pics.Image = null;
                }
            }
            if (pictures.All(o=>o.Tag== pictures[0].Tag))
            {
            gameover("Tebrikler oyunu bitirdiniz.");
            }


        }
        private void gameover(string msg)
        {
            
            gameIsOver = true;
             
            MessageBox.Show(msg + " Tekrar oynamak için tıklayın.");
        }



    }
}
