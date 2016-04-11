namespace BGN_to_EUR
{
    partial class Form1
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
            this.labelConvert = new System.Windows.Forms.Label();
            this.numericUpDownBGNtoEUR = new System.Windows.Forms.NumericUpDown();
            this.labelLevsinEuro = new System.Windows.Forms.Label();
            this.labelConvertedMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBGNtoEUR)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConvert
            // 
            this.labelConvert.AutoSize = true;
            this.labelConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConvert.Location = new System.Drawing.Point(12, 24);
            this.labelConvert.Name = "labelConvert";
            this.labelConvert.Size = new System.Drawing.Size(120, 20);
            this.labelConvert.TabIndex = 0;
            this.labelConvert.Text = "Конвертирай";
            this.labelConvert.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDownBGNtoEUR
            // 
            this.numericUpDownBGNtoEUR.DecimalPlaces = 2;
            this.numericUpDownBGNtoEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownBGNtoEUR.Location = new System.Drawing.Point(131, 22);
            this.numericUpDownBGNtoEUR.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownBGNtoEUR.Name = "numericUpDownBGNtoEUR";
            this.numericUpDownBGNtoEUR.Size = new System.Drawing.Size(91, 26);
            this.numericUpDownBGNtoEUR.TabIndex = 1;
            this.numericUpDownBGNtoEUR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownBGNtoEUR.ValueChanged += new System.EventHandler(this.numericUpDownBGNtoEUR_ValueChanged);
            // 
            // labelLevsinEuro
            // 
            this.labelLevsinEuro.AutoSize = true;
            this.labelLevsinEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevsinEuro.Location = new System.Drawing.Point(228, 24);
            this.labelLevsinEuro.Name = "labelLevsinEuro";
            this.labelLevsinEuro.Size = new System.Drawing.Size(103, 20);
            this.labelLevsinEuro.TabIndex = 2;
            this.labelLevsinEuro.Text = "Лева в Евро";
            // 
            // labelConvertedMoney
            // 
            this.labelConvertedMoney.BackColor = System.Drawing.Color.Lime;
            this.labelConvertedMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConvertedMoney.ForeColor = System.Drawing.Color.Red;
            this.labelConvertedMoney.Location = new System.Drawing.Point(16, 61);
            this.labelConvertedMoney.Name = "labelConvertedMoney";
            this.labelConvertedMoney.Size = new System.Drawing.Size(314, 39);
            this.labelConvertedMoney.TabIndex = 3;
            this.labelConvertedMoney.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelConvertedMoney.Click += new System.EventHandler(this.labelConvertedMoney_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 127);
            this.Controls.Add(this.labelConvertedMoney);
            this.Controls.Add(this.labelLevsinEuro);
            this.Controls.Add(this.numericUpDownBGNtoEUR);
            this.Controls.Add(this.labelConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "BGN-to-EUR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBGNtoEUR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConvert;
        private System.Windows.Forms.NumericUpDown numericUpDownBGNtoEUR;
        private System.Windows.Forms.Label labelLevsinEuro;
        private System.Windows.Forms.Label labelConvertedMoney;
    }
}

