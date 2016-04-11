using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointAndRectangle
{
    public partial class PountAndRectangle : Form
    {
        public PountAndRectangle()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void Draw()
        {
            var x1 = this.numericUpDownX1.Value;
            var y1 = this.numericUpDownY1.Value;
            var x2 = this.numericUpDownX2.Value;
            var y2 = this.numericUpDownY2.Value;
            var x = this.numericUpDownPointX.Value;
            var y = this.numericUpDownPointY.Value;

            var left = Math.Min(x1, x2);
            var right = Math.Max(x1, x2);
            var up = Math.Min(y1, y2);
            var down = Math.Max(y1, y2);

            if (x > left && x < right && y > up && y < down)
            {
                this.labelInside.Text = "Inside";
                this.labelInside.BackColor = Color.Green;
            }
            else if (x < left || x > right || y < up || y > down)
            {
                this.labelInside.Text = "Outside";
                this.labelInside.BackColor = Color.Red;
            }
            else if (((x == left) || (x == right)) &&
                        (y == up) || (y == down))
            {
                this.labelInside.Text = "Corner";
                this.labelInside.BackColor = Color.Yellow;
            }
            else
            {
                this.labelInside.Text = "Border";
                this.labelInside.BackColor = Color.Blue;
            }

            Visualize();
        }

        private void Visualize()
        {
            throw new NotImplementedException();
        }

        private void numericUpDownX1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownY1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownX2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownY2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void PountAndRectangle_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void PountAndRectangle_Resize(object sender, EventArgs e)
        {
            Draw();
        }

        private void labelInside_Click(object sender, EventArgs e)
        {
        }
    }
}
