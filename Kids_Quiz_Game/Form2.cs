using System;
using System.Runtime.InteropServices;          //Library
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kids_Quiz_Game
{
  
    public partial class Form2 : Form
    {
        int score = 0;
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
        public Form2()
        {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            Hide();
            f.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void toolTip3_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radiobutton1.Checked ==true)
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
            if(score >= 3)
            {
                MessageBox.Show("Good Effort", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Better Luck Next Time ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void o2_2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void o3_3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void sc_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
