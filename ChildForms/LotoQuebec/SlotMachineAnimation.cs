using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetOOP_Hivers_2024.ChildForms.LotoQuebec
{
    internal class SlotMachineAnimation
    {
        private Stack<System.Windows.Forms.Label> _labelStack = new Stack<System.Windows.Forms.Label>();
        private Random _random = new Random();
        private int[] _winningNumbers;
        public int[] WinningNumbers
        {
            get
            {
                return _winningNumbers;
            }
        }

        public SlotMachineAnimation(System.Windows.Forms.Label[] labels, int[] winningNumbers)
        {
            for (int i = 6; i >= 0; i--)
            {
                _labelStack.Push(labels[i]);
            }
            this._winningNumbers = winningNumbers;
        }

        public async void Animate()
        {
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 30; i++)
                {
                    foreach (var label in _labelStack)
                    {
                        label.Text = _random.Next(51).ToString();
                    }
                    //this.Refresh();
                    await Task.Delay(20);
                }
                _labelStack.Peek().BackColor = Color.Chartreuse;
                _labelStack.Peek().ForeColor = Color.WhiteSmoke;
                _labelStack.Peek().Text = _winningNumbers[j].ToString();
                _labelStack.Pop();
            }

        }
    }
}
