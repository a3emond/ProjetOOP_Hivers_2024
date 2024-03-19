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

namespace ProjetOOP_Hivers_2024.ChildForms.LotoQuebec
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
            LoadHistory();
        }


        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string path = "../../ChildForms/LotoQuebec/History/history.txt";
            if (MessageBox.Show(
                    "Voulez-vous vraiment effacer le contenu du fichier History?\n" + 
                    "Les donnees seront perdues pour toujours...",
                    "Effacer l'historique",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //overwrite the file with an empty string
                File.WriteAllText(path, "");
                LoadHistory();
            }
        }

        private void LoadHistory()
        {
            var history = new HistoryHandler();
            var items = history.PrintWinningEntries();
            History.DataSource = items;
        }
    }
}
