namespace ProjetOOP_Hivers_2024
{
    partial class TemperatureConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemperatureConverter));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cValue = new System.Windows.Forms.TextBox();
            this.fValue = new System.Windows.Forms.TextBox();
            this.kValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "°C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(173, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "°F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "°K";
            // 
            // cValue
            // 
            this.cValue.BackColor = System.Drawing.Color.Black;
            this.cValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cValue.ForeColor = System.Drawing.Color.White;
            this.cValue.Location = new System.Drawing.Point(24, 37);
            this.cValue.Name = "cValue";
            this.cValue.Size = new System.Drawing.Size(44, 26);
            this.cValue.TabIndex = 3;
            this.cValue.Text = "0";
            this.cValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cValue_KeyDown);
            this.cValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cValue_KeyPress);
            this.cValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cValue_KeyUp);
            // 
            // fValue
            // 
            this.fValue.BackColor = System.Drawing.Color.Black;
            this.fValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fValue.ForeColor = System.Drawing.Color.White;
            this.fValue.Location = new System.Drawing.Point(123, 37);
            this.fValue.Name = "fValue";
            this.fValue.Size = new System.Drawing.Size(44, 26);
            this.fValue.TabIndex = 4;
            this.fValue.Text = "32";
            this.fValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fValue_KeyDown);
            this.fValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fValue_KeyPress);
            this.fValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fValue_KeyUp);
            // 
            // kValue
            // 
            this.kValue.BackColor = System.Drawing.Color.Black;
            this.kValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kValue.ForeColor = System.Drawing.Color.White;
            this.kValue.Location = new System.Drawing.Point(221, 37);
            this.kValue.Name = "kValue";
            this.kValue.Size = new System.Drawing.Size(44, 26);
            this.kValue.TabIndex = 5;
            this.kValue.Text = "273";
            this.kValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.kValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kValue_KeyDown);
            this.kValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kValue_KeyPress);
            this.kValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kValue_KeyUp);
            // 
            // TemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ProjetOOP_Hivers_2024.Properties.Resources.temperatureBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kValue);
            this.Controls.Add(this.fValue);
            this.Controls.Add(this.cValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TemperatureConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TemperatureConvertor";
            this.Load += new System.EventHandler(this.TemperatureConverter_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TemperatureConverter_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cValue;
        private System.Windows.Forms.TextBox fValue;
        private System.Windows.Forms.TextBox kValue;
    }
}