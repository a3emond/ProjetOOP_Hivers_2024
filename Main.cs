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
        private LotoQuebec lotoQuebecForm;
        private CurrencyConverter currencyForm;
        private TemperatureConverter tempForm;
        private readonly Timer timer = new Timer();

        public Main()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Start();
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now;
            clockLabel.Text = time.ToShortDateString() + "  " + time.ToLongTimeString();
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
            Image img = Image.FromFile("Assets/currencyExchange.png");
            graph.DrawImage(img, 0, e.ClipRectangle.Height / 2 - img.Height / 2);
        }

        private void btnTemperature_Paint(object sender, PaintEventArgs e)
        {
            //print image on button
            var graph = e.Graphics;
            Image img = Image.FromFile("Assets/tempConvert.png");
            graph.DrawImage(img, 0, e.ClipRectangle.Height / 2 - img.Height / 2);
        }

        //make sure only one instance of each form is open
        private void OpenForm<T>(ref T form) where T : Form, new()
        {
            if (form == null || form.IsDisposed)
            {
                form = new T();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                form.WindowState = FormWindowState.Normal;
                form.BringToFront();
            }
        }

        private void btnLotoQuebec_Click(object sender, EventArgs e)
        {
            OpenForm<LotoQuebec>(ref lotoQuebecForm);
        }

        private void btnCurrency_Click(object sender, EventArgs e)
        {
            OpenForm<CurrencyConverter>(ref currencyForm);
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            OpenForm<TemperatureConverter>(ref tempForm);
        }

        //resizing parent form will resize all child forms
        private void Main_SizeChanged(object sender, EventArgs e)
        {
            this.MdiChildren.ToList().ForEach(f => f.Size = (this.Size - new Size(20, 110)));
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter l'application?",
                    "Quit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
    }
}
