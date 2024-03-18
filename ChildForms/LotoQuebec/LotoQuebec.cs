using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetOOP_Hivers_2024.ChildForms.LotoQuebec;

namespace ProjetOOP_Hivers_2024
{
    
    public partial class LotoQuebec : Form
    {
        public Random random = new Random();
        public System.Windows.Forms.Label[] labels;
        public LotoQuebec()
        {
            InitializeComponent();
            this.Paint += Confetti_Paint;
            labels = new System.Windows.Forms.Label[] { label1, label2, label3, label4, label5, label6, label7 };


        }

        private void LotoQuebec_Load(object sender, EventArgs e)
        {
            this.Size = Parent.Size - new Size(5, 5);

        }


        private void btnTirage_Click(object sender, EventArgs e)
        {
            ResetLabelsColors();
            //start the animation + feed winning numbers
            var animation = new SlotMachineAnimation(labels,GetProperRandom());
            animation.Animate();
            //save the winning numbers to the history
            var log = new HistoryHandler(animation.WinningNumbers);
            log.LogWinningEntry();
        }

        private void Confetti_Paint(object sender, PaintEventArgs e)
        {
            Image img1 = Image.FromFile("Assets/confetti.png");
            Image img2 = Image.FromFile("Assets/confettiCone.png");
            e.Graphics.DrawImage(img1,0,0);
            e.Graphics.DrawImage(img1, img1.Width, 0);
            e.Graphics.DrawImage(img1, 2*img1.Width, 0);

            e.Graphics.DrawImage(img2,0,this.Height/2);
        }
        //get the real value of the loto quebec
        private int[] GetProperRandom()
        {
            int[] randoms = new int[7];
            List<int> avaliablesNumbers = new List<int>();
            //make a list of all numbers from 1 to 50
            for (int i = 1; i <= 50; i++)
            {
                avaliablesNumbers.Add(i);
            }
            //get 6 random numbers from the list whitout repeating
            for (int i = 0; i < 7; i++)
            {
                //get a random number from the list using random index of the list to select the number
                randoms[i] = avaliablesNumbers[random.Next(avaliablesNumbers.Count)];
                //remove the number from the list
                avaliablesNumbers.Remove(randoms[i]);
            }
            return randoms;
        }
        //utility Functions
        private void ResetLabelsColors()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.BackColor = Color.White;
                    control.ForeColor = Color.Black;
                }
            }
        }
    }
}
