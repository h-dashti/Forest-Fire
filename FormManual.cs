using System;
using System.Windows.Forms;

namespace ForestLife
{
    public partial class FormManual : Form
    {
        int L, H;
        public bool isAccpeted = false;
        public int n_fired, n_green;

        public FormManual(int L, int H)
        {
            InitializeComponent();
            labelIntro.Text = "Width = " + L + "\r\n" + "Height = " + H;
            this.L = L;
            this.H = H;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                n_fired = int.Parse(textBox_red.Text);
                n_green = int.Parse(textBox_green.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.ToString());
                return;
            }
            if (n_fired + n_green > L * H)
            {
                MessageBox.Show("The input data is not correct!");
                return;
            }
            isAccpeted = true;
            this.Close();


        }
    }
}