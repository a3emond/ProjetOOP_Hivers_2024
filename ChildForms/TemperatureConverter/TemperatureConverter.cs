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
        public int celsiusTemperature;

        public TemperatureConverter()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void TemperatureConverter_Load(object sender, EventArgs e)
        {
            this.Size = Parent.Size - new Size(5, 5);
        }

        private void TemperatureConverter_Paint(object sender, PaintEventArgs e)
        {
            var thermometer = new Thermometer(e.Graphics, 150, 100, -celsiusTemperature);
        }
        //ici j'ai utilise les keyPress au lieu de keyDown parce que
        //keyDown est appele avant que le text change, ce qui cause des problemes
        //pour verifier si le text est dans le bon range
        private void cValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keyboard handler numbers range -90 to 100
            HandleKeys(e, cValue, -90, 100);
        }

        private void fValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keyboard handler numbers range -130 to 212
            HandleKeys(e, fValue, -130, 212);
        }

        private void kValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keyboard handler numbers range 183 to 373
            HandleKeys(e, kValue, 0, 373);
        }
        // j'ai finalement decide d'utiliser key up parce que
        // textchanged est appele a chaque fois que le text change
        // dans chaque textbox, ce qui cause des problemes de curseur
        private void cValue_KeyUp(object sender, KeyEventArgs e)
        {
            //update fValue and kValue
            //update thermometer
            if (cValue.Text == "")
            {
                celsiusTemperature = 0;
                fValue.Text = (celsiusTemperature * 9 / 5 + 32).ToString();
                kValue.Text = (celsiusTemperature + 273).ToString();
                Invalidate();
            }
            if (int.TryParse(cValue.Text, out int number))
            {
                celsiusTemperature = number;
                fValue.Text = (celsiusTemperature * 9 / 5 + 32).ToString();
                kValue.Text = (celsiusTemperature + 273).ToString();
                Invalidate();
            }
        }

        private void fValue_KeyUp(object sender, KeyEventArgs e)
        {
            if (fValue.Text == "")
            {
                celsiusTemperature = 0;
                cValue.Text = celsiusTemperature.ToString();
                kValue.Text = (celsiusTemperature + 273).ToString();
                Invalidate();
            }

            if (int.TryParse(fValue.Text, out int number))
            {
                celsiusTemperature = (number - 32) * 5 / 9;
                cValue.Text = celsiusTemperature.ToString();
                kValue.Text = (celsiusTemperature + 273).ToString();
                Invalidate();
            }
        }

        private void kValue_KeyUp(object sender, KeyEventArgs e)
        {
            if (kValue.Text == "")
            {
                celsiusTemperature = 0;
                cValue.Text = celsiusTemperature.ToString();
                fValue.Text = (celsiusTemperature * 9 / 5 + 32).ToString();
                Invalidate();
            }

            if (int.TryParse(kValue.Text, out int number))
            {
                celsiusTemperature = number - 273;
                cValue.Text = celsiusTemperature.ToString();
                fValue.Text = (celsiusTemperature * 9 / 5 + 32).ToString();
                Invalidate();
            }
        }

        //utility Functions
        private void HandleKeys(KeyPressEventArgs e, TextBox textBox, int min, int max)
        {
            if (!(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 189 ||e.KeyChar == '-'))
            {
                //189 is the ascii code for the minus sign
                e.Handled = true;
            }

            //check for minus sign
            if (e.KeyChar == 189 || e.KeyChar == '-')
            {
                //if the minus sign is not the first character, ignore the key press
                if (textBox.Text.Length > 0)
                {
                    e.Handled = true;
                }
            }

            // Concatenate the pressed key to the current text
            string newText = textBox.Text + e.KeyChar.ToString();
            if (!IsInRange(newText, min, max))
            {
                e.Handled = true;
            }
        }

        private bool IsInRange(string value, int min, int max)
        {
            if (int.TryParse(value, out int number))
            {
                // Check if the number is within the valid range
                if (number < min || number > max)
                {
                    // If the number is out of range, ignore the key press
                    return false;
                }

            }
            return true;

        }

        private void cValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsInRange(cValue.Text,-90,100))
                keyUpAndDownAction(cValue, e);
        }

        private void fValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsInRange(fValue.Text,-130,212))
                keyUpAndDownAction(fValue, e);
        }

        private void kValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsInRange(kValue.Text,0,373))
                keyUpAndDownAction(kValue, e);
        }

        private void keyUpAndDownAction(TextBox textBox, KeyEventArgs e)
        {
            int temp=0;
            if (e.KeyCode == Keys.Up)
            {
                if (int.TryParse(textBox.Text, out temp) || textBox.Text == "")
                {
                    temp++;
                    textBox.Text = temp.ToString();
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (int.TryParse(textBox.Text, out temp) || textBox.Text == "")
                {
                    temp--;
                    textBox.Text = temp.ToString();
                }
            }
        }


    }
}
