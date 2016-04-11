namespace PointAndRectangle
{
    partial class PountAndRectangle
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
            this.labelRectangle = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.numericUpDownX1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX2 = new System.Windows.Forms.NumericUpDown();
            this.labelX2 = new System.Windows.Forms.Label();
            this.numericUpDownY1 = new System.Windows.Forms.NumericUpDown();
            this.labelY1 = new System.Windows.Forms.Label();
            this.numericUpDownY2 = new System.Windows.Forms.NumericUpDown();
            this.labelY2 = new System.Windows.Forms.Label();
            this.numericUpDownPointY = new System.Windows.Forms.NumericUpDown();
            this.labelPointY = new System.Windows.Forms.Label();
            this.numericUpDownPointX = new System.Windows.Forms.NumericUpDown();
            this.labelPointX = new System.Windows.Forms.Label();
            this.labelPoint = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.labelInside = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRectangle
            // 
            this.labelRectangle.AutoSize = true;
            this.labelRectangle.Location = new System.Drawing.Point(12, 9);
            this.labelRectangle.Name = "labelRectangle";
            this.labelRectangle.Size = new System.Drawing.Size(86, 20);
            this.labelRectangle.TabIndex = 0;
            this.labelRectangle.Text = "Rectangle:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(24, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(38, 20);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "x1 =";
            // 
            // numericUpDownX1
            // 
            this.numericUpDownX1.DecimalPlaces = 2;
            this.numericUpDownX1.Location = new System.Drawing.Point(68, 32);
            this.numericUpDownX1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownX1.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownX1.Name = "numericUpDownX1";
            this.numericUpDownX1.Size = new System.Drawing.Size(78, 26);
            this.numericUpDownX1.TabIndex = 2;
            this.numericUpDownX1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownX1.ValueChanged += new System.EventHandler(this.numericUpDownX1_ValueChanged);
            // 
            // numericUpDownX2
            // 
            this.numericUpDownX2.DecimalPlaces = 2;
            this.numericUpDownX2.Location = new System.Drawing.Point(68, 96);
            this.numericUpDownX2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownX2.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownX2.Name = "numericUpDownX2";
            this.numericUpDownX2.Size = new System.Drawing.Size(78, 26);
            this.numericUpDownX2.TabIndex = 4;
            this.numericUpDownX2.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownX2.ValueChanged += new System.EventHandler(this.numericUpDownX2_ValueChanged);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(24, 98);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(38, 20);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "x2 =";
            // 
            // numericUpDownY1
            // 
            this.numericUpDownY1.DecimalPlaces = 2;
            this.numericUpDownY1.Location = new System.Drawing.Point(68, 64);
            this.numericUpDownY1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownY1.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownY1.Name = "numericUpDownY1";
            this.numericUpDownY1.Size = new System.Drawing.Size(78, 26);
            this.numericUpDownY1.TabIndex = 6;
            this.numericUpDownY1.Value = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.numericUpDownY1.ValueChanged += new System.EventHandler(this.numericUpDownY1_ValueChanged);
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(24, 66);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(38, 20);
            this.labelY1.TabIndex = 5;
            this.labelY1.Text = "y1 =";
            // 
            // numericUpDownY2
            // 
            this.numericUpDownY2.DecimalPlaces = 2;
            this.numericUpDownY2.Location = new System.Drawing.Point(68, 128);
            this.numericUpDownY2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownY2.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownY2.Name = "numericUpDownY2";
            this.numericUpDownY2.Size = new System.Drawing.Size(78, 26);
            this.numericUpDownY2.TabIndex = 8;
            this.numericUpDownY2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownY2.ValueChanged += new System.EventHandler(this.numericUpDownY2_ValueChanged);
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(24, 130);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(38, 20);
            this.labelY2.TabIndex = 7;
            this.labelY2.Text = "y2 =";
            // 
            // numericUpDownPointY
            // 
            this.numericUpDownPointY.DecimalPlaces = 2;
            this.numericUpDownPointY.Location = new System.Drawing.Point(68, 231);
            this.numericUpDownPointY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPointY.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownPointY.Name = "numericUpDownPointY";
            this.numericUpDownPointY.Size = new System.Drawing.Size(78, 26);
            this.numericUpDownPointY.TabIndex = 13;
            this.numericUpDownPointY.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownPointY.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelPointY
            // 
            this.labelPointY.AutoSize = true;
            this.labelPointY.Location = new System.Drawing.Point(32, 233);
            this.labelPointY.Name = "labelPointY";
            this.labelPointY.Size = new System.Drawing.Size(29, 20);
            this.labelPointY.TabIndex = 12;
            this.labelPointY.Text = "y =";
            // 
            // numericUpDownPointX
            // 
            this.numericUpDownPointX.DecimalPlaces = 2;
            this.numericUpDownPointX.Location = new System.Drawing.Point(68, 199);
            this.numericUpDownPointX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPointX.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownPointX.Name = "numericUpDownPointX";
            this.numericUpDownPointX.Size = new System.Drawing.Size(78, 26);
            this.numericUpDownPointX.TabIndex = 11;
            this.numericUpDownPointX.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownPointX.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // labelPointX
            // 
            this.labelPointX.AutoSize = true;
            this.labelPointX.Location = new System.Drawing.Point(32, 201);
            this.labelPointX.Name = "labelPointX";
            this.labelPointX.Size = new System.Drawing.Size(29, 20);
            this.labelPointX.TabIndex = 10;
            this.labelPointX.Text = "x =";
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Location = new System.Drawing.Point(12, 176);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(49, 20);
            this.labelPoint.TabIndex = 9;
            this.labelPoint.Text = "Point:";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(16, 279);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(130, 27);
            this.buttonDraw.TabIndex = 14;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // labelInside
            // 
            this.labelInside.BackColor = System.Drawing.Color.Yellow;
            this.labelInside.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInside.ForeColor = System.Drawing.Color.Black;
            this.labelInside.Location = new System.Drawing.Point(24, 322);
            this.labelInside.Name = "labelInside";
            this.labelInside.Size = new System.Drawing.Size(100, 33);
            this.labelInside.TabIndex = 15;
            this.labelInside.Text = "Result";
            this.labelInside.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelInside.Click += new System.EventHandler(this.labelInside_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(161, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 344);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // PountAndRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelInside);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.numericUpDownPointY);
            this.Controls.Add(this.labelPointY);
            this.Controls.Add(this.numericUpDownPointX);
            this.Controls.Add(this.labelPointX);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.numericUpDownY2);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.numericUpDownY1);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.numericUpDownX2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.numericUpDownX1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelRectangle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "PountAndRectangle";
            this.Text = "Point And Rectangle";
            this.Load += new System.EventHandler(this.PountAndRectangle_Load);
            this.Resize += new System.EventHandler(this.PountAndRectangle_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRectangle;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.NumericUpDown numericUpDownX1;
        private System.Windows.Forms.NumericUpDown numericUpDownX2;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.NumericUpDown numericUpDownY1;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.NumericUpDown numericUpDownY2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.NumericUpDown numericUpDownPointY;
        private System.Windows.Forms.Label labelPointY;
        private System.Windows.Forms.NumericUpDown numericUpDownPointX;
        private System.Windows.Forms.Label labelPointX;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label labelInside;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

