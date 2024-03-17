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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //add dateTime to menuStrip
            
        }

        private void btnLotoQuebec_Paint(object sender, PaintEventArgs e)
        {
            var graph = e.Graphics;
            Image img = Image.FromFile("Assets/loto.png");
            graph.DrawImage(img, 0, e.ClipRectangle.Height / 2 - img.Height / 2);
        }

        private void btnCurrency_Paint(object sender, PaintEventArgs e)
        {
            //print image on button
            var graph = e.Graphics;
            Image img = Image.FromFile("Assets/deviseConverter.png");
            graph.DrawImage(img, 0, e.ClipRectangle.Height / 2 - img.Height / 2);
        }

        private void btnTemperature_Paint(object sender, PaintEventArgs e)
        {
            //print image on button
            var graph = e.Graphics;
            Image img = Image.FromFile("Assets/tempConverter.png");
            graph.DrawImage(img, 0, e.ClipRectangle.Height / 2 - img.Height / 2);
        }

        private void btnLotoQuebec_Click(object sender, EventArgs e)
        {
            //import LotoQuebec form
            var loto = new LotoQuebec();
            loto.MdiParent = this;
            loto.Show();
        }

        private void btnCurrency_Click(object sender, EventArgs e)
        {
            //import CurrencyConverter form
            var currency = new CurrencyConverter();
            currency.MdiParent = this;
            currency.Show();
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            //import TemperatureConverter form
            var temp = new TemperatureConverter();
            temp.MdiParent = this;
            temp.Show();

        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            //resizing parent form will resize all child forms
            this.MdiChildren.ToList().ForEach(f => f.Size = (this.Size - new Size(20, 110)));
        }
    }
}
