using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetOOP_Hivers_2024
{
    
    public partial class LotoQuebec : Form
    {
        public Random random = new Random();
        public LotoQuebec()
        {
            InitializeComponent();
            this.Paint += Confetti_Paint;


        }

        private void LotoQuebec_Load(object sender, EventArgs e)
        {
            this.Size = Parent.Size - new Size(5, 5);

        }

        public async void Animate()
        {
            for (int i = 0; i < 30; i++)
            {
                label1.Text = random.Next(51).ToString();
                label2.Text = random.Next(51).ToString();
                label3.Text = random.Next(51).ToString();
                label4.Text = random.Next(51).ToString();
                label5.Text = random.Next(51).ToString();
                label6.Text = random.Next(51).ToString();
                label7.Text = random.Next(51).ToString();
                this.Refresh();

                await Task.Delay(20);
            }
            label1.BackColor = Color.Chartreuse;
            label1.ForeColor = Color.WhiteSmoke;
            //put real value here
            for (int i = 0; i < 30; i++)
            {
                
                label2.Text = random.Next(51).ToString();
                label3.Text = random.Next(51).ToString();
                label4.Text = random.Next(51).ToString();
                label5.Text = random.Next(51).ToString();
                label6.Text = random.Next(51).ToString();
                label7.Text = random.Next(51).ToString();
                this.Refresh();

                await Task.Delay(20);
            }
            label2.BackColor = Color.Chartreuse;
            label2.ForeColor = Color.WhiteSmoke;
            //put real value here
            for (int i = 0; i < 30; i++)
            {
                
                label3.Text = random.Next(51).ToString();
                label4.Text = random.Next(51).ToString();
                label5.Text = random.Next(51).ToString();
                label6.Text = random.Next(51).ToString();
                label7.Text = random.Next(51).ToString();
                this.Refresh();

                await Task.Delay(20);
            }
            label3.BackColor = Color.Chartreuse;
            label3.ForeColor = Color.WhiteSmoke;
            //put real value here
            for (int i = 0; i < 30; i++)
            {
                
                label4.Text = random.Next(51).ToString();
                label5.Text = random.Next(51).ToString();
                label6.Text = random.Next(51).ToString();
                label7.Text = random.Next(51).ToString();
                this.Refresh();

                await Task.Delay(20);
            }
            label4.BackColor = Color.Chartreuse;
            label4.ForeColor = Color.WhiteSmoke;
            //put real value here
            for (int i = 0; i < 30; i++)
            {
                
                label5.Text = random.Next(51).ToString();
                label6.Text = random.Next(51).ToString();
                label7.Text = random.Next(51).ToString();
                this.Refresh();

                await Task.Delay(20);
            }
            label5.BackColor = Color.Chartreuse;
            label5.ForeColor = Color.WhiteSmoke;
            //put real value here
            for (int i = 0; i < 30; i++)
            {
                
                label6.Text = random.Next(51).ToString();
                label7.Text = random.Next(51).ToString();
                this.Refresh();

                await Task.Delay(20);
            }
            label6.BackColor = Color.Chartreuse;
            label6.ForeColor = Color.WhiteSmoke;
            //put real value here
            for (int i = 0; i < 30; i++)
            {
                
                label7.Text = random.Next(51).ToString();
                this.Refresh();

                await Task.Delay(20);
            }
            label7.BackColor = Color.Chartreuse;
            label7.ForeColor = Color.WhiteSmoke;
            //put real value here



        }

        private void btnTirage_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.BackColor = Color.White;
                    control.ForeColor = Color.Black;
                }   
            }
            Animate();
            
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
    }
}
