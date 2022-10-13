using System;
using System.Runtime.InteropServices;          //Library
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kids_Quiz_Game
{
    public partial class Form3 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double score = 0;
            if(radiobutton1.Checked==true)
            {
                score++;
            }
            if (radiobutton2.Checked == true)
            {
                score++;

            }
            if (radiobutton3.Checked == true)
            {
                score++;
            }
            if (radiobutton4.Checked == true)
            {
                score++;
            }
            if (radiobutton5.Checked == true)
            {
                score++;
            }
            if (radiobutton6.Checked == true)
            {
                score++;

            }
            marks.Text = score.ToString();
            if (score >= 3)
            {
                MessageBox.Show("Good Effort", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Better Luck Next Time ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
