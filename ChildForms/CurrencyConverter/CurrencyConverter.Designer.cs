namespace ProjetOOP_Hivers_2024
{
    partial class CurrencyConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyConverter));
            this.fromCurrencyBox = new System.Windows.Forms.ComboBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toCurrencyBox = new System.Windows.Forms.ComboBox();
            this.inputSymbol = new System.Windows.Forms.Label();
            this.outputSymbol = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fromCurrencyBox
            // 
            this.fromCurrencyBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromCurrencyBox.BackColor = System.Drawing.Color.GhostWhite;
            this.fromCurrencyBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fromCurrencyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromCurrencyBox.ForeColor = System.Drawing.Color.Black;
            this.fromCurrencyBox.FormattingEnabled = true;
            this.fromCurrencyBox.Location = new System.Drawing.Point(43, 190);
            this.fromCurrencyBox.Name = "fromCurrencyBox";
            this.fromCurrencyBox.Size = new System.Drawing.Size(377, 32);
            this.fromCurrencyBox.TabIndex = 1;
            this.fromCurrencyBox.SelectedIndexChanged += new System.EventHandler(this.fromCurrencyBox_SelectedIndexChanged);
            // 
            // inputBox
            // 
            this.inputBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputBox.BackColor = System.Drawing.Color.GhostWhite;
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.ForeColor = System.Drawing.Color.Black;
            this.inputBox.Location = new System.Drawing.Point(294, 132);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(248, 29);
            this.inputBox.TabIndex = 0;
            this.inputBox.Text = "0.00";
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputBox_KeyPress);
            this.inputBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(455, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vers";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.GhostWhite;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(439, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Montant";
            // 
            // toCurrencyBox
            // 
            this.toCurrencyBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toCurrencyBox.BackColor = System.Drawing.Color.GhostWhite;
            this.toCurrencyBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toCurrencyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toCurrencyBox.ForeColor = System.Drawing.Color.Black;
            this.toCurrencyBox.FormattingEnabled = true;
            this.toCurrencyBox.Location = new System.Drawing.Point(544, 190);
            this.toCurrencyBox.Name = "toCurrencyBox";
            this.toCurrencyBox.Size = new System.Drawing.Size(377, 32);
            this.toCurrencyBox.TabIndex = 3;
            this.toCurrencyBox.SelectedIndexChanged += new System.EventHandler(this.toCurrencyBox_SelectedIndexChanged);
            // 
            // inputSymbol
            // 
            this.inputSymbol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputSymbol.AutoSize = true;
            this.inputSymbol.BackColor = System.Drawing.Color.GhostWhite;
            this.inputSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSymbol.ForeColor = System.Drawing.Color.Black;
            this.inputSymbol.Location = new System.Drawing.Point(545, 135);
            this.inputSymbol.Name = "inputSymbol";
            this.inputSymbol.Size = new System.Drawing.Size(21, 24);
            this.inputSymbol.TabIndex = 6;
            this.inputSymbol.Text = "$";
            // 
            // outputSymbol
            // 
            this.outputSymbol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputSymbol.AutoSize = true;
            this.outputSymbol.BackColor = System.Drawing.Color.GhostWhite;
            this.outputSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputSymbol.ForeColor = System.Drawing.Color.Black;
            this.outputSymbol.Location = new System.Drawing.Point(545, 274);
            this.outputSymbol.Name = "outputSymbol";
            this.outputSymbol.Size = new System.Drawing.Size(21, 24);
            this.outputSymbol.TabIndex = 7;
            this.outputSymbol.Text = "$";
            // 
            // Result
            // 
            this.Result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Result.BackColor = System.Drawing.Color.GhostWhite;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Black;
            this.Result.Location = new System.Drawing.Point(294, 271);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(248, 29);
            this.Result.TabIndex = 8;
            this.Result.Text = "0.00";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetOOP_Hivers_2024.Properties.Resources.currencyConvertorBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.outputSymbol);
            this.Controls.Add(this.inputSymbol);
            this.Controls.Add(this.toCurrencyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.fromCurrencyBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CurrencyConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CurrencyConvertor";
            this.Load += new System.EventHandler(this.CurrencyConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fromCurrencyBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox toCurrencyBox;
        private System.Windows.Forms.Label inputSymbol;
        private System.Windows.Forms.Label outputSymbol;
        private System.Windows.Forms.TextBox Result;
    }
}