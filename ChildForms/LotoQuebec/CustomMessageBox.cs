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
using ProjetOOP_Hivers_2024.ChildForms.CurrencyConverter;

namespace ProjetOOP_Hivers_2024.ChildForms.LotoQuebec
{
    public partial class CustomMessageBox : Form
    {
        private string _filePath;
        public CustomMessageBox(string lbl1,string lbl2,string lbl3,string lbl4,string filePath)
        {
            InitializeComponent();
            label1.Text = lbl1;
            label2.Text = lbl2;
            label3.Text = lbl3;
            label4.Text = lbl4;
            this._filePath = filePath;
            LoadHistory(_filePath);
        }


        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show(
                    "Voulez-vous vraiment effacer le contenu du fichier History?\n" + 
                    "Les donnees seront perdues pour toujours...",
                    "Effacer l'historique",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //delete file
                File.Delete(_filePath);
                LoadHistory(_filePath);
            }
        }

        private void LoadHistory(string filePath)
        {
            if (filePath.Contains(".txt"))
            {
                var history = new HistoryHandler();
                var items = history.PrintWinningEntries();
                History.DataSource = items;
            }
            else if (filePath.Contains(".bin"))
            {
                var history = new BinFileHandler(filePath);
                var items = history.ReadBinHistory();
                History.DataSource = items;
            }
            else if (filePath.Contains(".xml"))
            {
                var history = new XmlFileHandler(filePath);
                var items = history.ReadHistory();
                History.DataSource = items;
            }
            
        }

    }
}
