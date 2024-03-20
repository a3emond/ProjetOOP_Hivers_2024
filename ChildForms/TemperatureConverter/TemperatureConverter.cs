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
using ProjetOOP_Hivers_2024.ChildForms.TemperatureConverter;

namespace ProjetOOP_Hivers_2024
{
    public partial class TemperatureConverter : Form
    {
        public int celsiusTemperature = 70;

        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void TemperatureConverter_Load(object sender, EventArgs e)
        {
            this.Size = Parent.Size - new Size(5, 5);

        }

        private void TemperatureConverter_Paint(object sender, PaintEventArgs e)
        {
            var thermometer = new Thermometer(e.Graphics, 150, 100, -celsiusTemperature);
            

        }

        private void cValue_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void fValue_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void fValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
