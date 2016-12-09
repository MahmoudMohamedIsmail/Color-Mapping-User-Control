using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Color_Mapping
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Color_Grid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Color_Grid.SelectedIndex == 0)
            {
                Panel_Grid.Invalidate();
            }
            else if (Color_Grid.SelectedIndex == 1)
            {
                Panel_Grid.Invalidate();
            }
        }

        private void Panel_Grid_Paint(object sender, PaintEventArgs e)
        {
            if (Color_Grid.SelectedIndex == 0)
            {
                Color_Functions.createDiscreteColors(Panel_Grid);
            }
            else if (Color_Grid.SelectedIndex == 1)
            {
                Rectangle rect = this.ClientRectangle;
                Color_Functions.createContinuousColors(e, rect);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radio_color.Checked)
            {

                // Wrong here is "How to assign Value to RGB Color".......

                /*
                Test_Value.Text = "";
                Color Cur_color = new Color();
                int r = int.Parse(R_color.Text);
                int b = int.Parse(B_color.Text);
                int g = int.Parse(G_color.Text);
                Cur_color = Color.FromArgb(r,g,b);
                float value = 12;
                Color_Functions.ColorToValue(Cur_color, double.Parse(Smin.Text), double.Parse(Smax.Text), 0, out value);
                MessageBox.Show(value.ToString());
               */
                MessageBox.Show("Not Implemented...");

            }
            else if (radio_value.Checked)
            {
                R_color.Text = "";
                G_color.Text = "";
                B_color.Text = "";
                double r = 0, g = 0, b = 0;
                Color_Functions.ValueToColor(double.Parse(Test_Value.Text), double.Parse(Smin.Text), double.Parse(Smax.Text),Color_Grid.SelectedIndex,out r,out g,out b);
                R_color.Text = r.ToString();
                G_color.Text = g.ToString();
                B_color.Text = b.ToString();
            
            }
            else
            {
                if (Smin.Text == "")
                {
                    MessageBox.Show("Enter Smin Plz..");
                }
                if (Smax.Text == "")
                {
                    MessageBox.Show("Enter Smax Plz..");
                }
                else
                {
                    MessageBox.Show("Enter Data PLz...");
                }
            }


        }
    }
}
