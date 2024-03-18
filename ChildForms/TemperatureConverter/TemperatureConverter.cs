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
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void TemperatureConverter_Load(object sender, EventArgs e)
        {
            this.Size = Parent.Size - new Size(5, 5);

        }
    }
}
