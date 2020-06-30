using System;
using System.Drawing;
using System.Windows.Forms;

namespace ForestLife
{
    public partial class FormForest : Form
    {
        #region My Fields
        Bitmap bitMapCells, bitMapLattice;
        int sizeRect = 40;
        Forest forest;
        Pen penLattice = new Pen(Color.Black);
        SolidBrush brushGreen = new SolidBrush(Color.Green);
        SolidBrush brushRed = new SolidBrush(Color.Red);
        Distribution method = Distribution.Random;
        bool canAcuireMouse = false;
        int n_fired, n_green;
        int snapshots;

        double p;

        #endregion


        #region My Methods
        void Reset()
        {
            int L, H;
            try
            {
                L = int.Parse(textBox_L.Text); //pictureBox1.Width / sizeRect;
                H = int.Parse(textBox_H.Text);//pictureBox1.Height / sizeRect;
                p = double.Parse(textBoxProbability.Text);
            }
            catch (FormatException e) { MessageBox.Show(e.ToString()); return; }

            if (L < 15) sizeRect = 40;
            else if (L < 40) sizeRect = 30;
            else if (L < 90) sizeRect = 15;
            else if (L < 150) sizeRect = 3;
            else sizeRect = 1;

            
            canAcuireMouse = true;
            if (timer1 != null && timer1.Enabled)
            {
                timer1.Stop();
                buttonAutomatic.Text = "Automatic";
            }

            pictureBox1.Size = new Size(L * sizeRect, H * sizeRect);
            groupBoxStructure.Left = pictureBox1.Right + 8;
            groupBoxBoundary.Left = groupBoxStructure.Left;
            trackBar_Latency.Left = groupBoxStructure.Left;

            bool cyclicX = checkBoxCycleX.Checked;
            bool cyclicY = checkBoxCycleY.Checked;

            if (method == Distribution.Random) forest = new Forest(L, H, cyclicX, cyclicY);
            else
            {
                if (n_fired + n_green > L * H) n_fired = n_green = L * H / 2;
                forest = new Forest(L, H, n_fired, n_green, cyclicX, cyclicY);
            }

            SetLabels();


            bitMapCells = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bitMapLattice = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            if (sizeRect > 1)
                SetBackGroundBitMap();
            DrawForestBitmap();
            GC.Collect();
            this.Invalidate();
            pictureBox1.Invalidate();

            
        }

        void SetLabels()
        {
            labelStep.Text = "step " + forest.steps;
            label_nFired.Text = "Fired: " + forest.n_Fired;
            label_nGreen.Text = "Green: " + forest.n_Green;
        }

        void DrawForestBitmap()
        {
            int L = forest.L;
            int H = forest.H;

            Graphics g = Graphics.FromImage(bitMapCells);
            g.Clear(pictureBox1.BackColor);

            if (sizeRect > 1)
                for (int i = 0; i < L; i++)
                    for (int j = 0; j < H; j++)
                    {
                        if (forest.cells[i, j] == 1)
                            g.FillRectangle(brushGreen, i * sizeRect, j * sizeRect, sizeRect, sizeRect);
                        else if (forest.cells[i, j] == 2)
                            g.FillRectangle(brushRed, i * sizeRect, j * sizeRect, sizeRect, sizeRect);
                    }
            else
            {
                for (int i = 0; i < L; i++)
                    for (int j = 0; j < H; j++)
                        if (forest.cells[i, j] == 1)
                            bitMapCells.SetPixel(i, j, Color.Green);
                        else if (forest.cells[i, j] == 2)
                            bitMapCells.SetPixel(i, j, Color.Red);
            }
                    
           
            g.Dispose();
        }

        void SetBackGroundBitMap()
        {
            int L = forest.L;
            int H = forest.H;

            Graphics g = Graphics.FromImage(bitMapLattice);
            for (int i = 1; i < L ; i++)
                g.DrawLine(penLattice, i * sizeRect, 0, i * sizeRect, H * sizeRect);
            for (int j = 1; j < H; j++)
            g.DrawLine(penLattice, 0, j * sizeRect, L * sizeRect, j * sizeRect);

            g.Dispose();
            
        }

        void InitialzeFirst()
        {
            timer1.Interval = CalculateTimerInterval();
            p = 0.08;
            textBoxProbability.Text = p.ToString();
            textBox_L.Text = "150";
            textBox_H.Text = "150";
        }



        void ChangeOneSiteColor(int i, int j, byte value)
        {
            if (sizeRect > 1)
            {
                Graphics g = Graphics.FromImage(bitMapCells);
                Rectangle rect = new Rectangle(i * sizeRect, j * sizeRect, sizeRect, sizeRect);

                if (value == 0) g.FillRectangle(new SolidBrush(pictureBox1.BackColor), rect);
                else if (value == 1) g.FillRectangle(brushGreen, rect);
                else g.FillRectangle(brushRed, rect);

                g.Dispose();
            }
            else
            {
                if (value == 0) bitMapCells.SetPixel(i, j, pictureBox1.BackColor);
                else if (value == 1) bitMapCells.SetPixel(i, j, Color.Green);
                else bitMapCells.SetPixel(i, j, Color.Red);
            }

        }


        int CalculateTimerInterval()
        {
            int maxInterval = 600, minInterval = 10,
                min = trackBar_Latency.Minimum, max = trackBar_Latency.Maximum, value = trackBar_Latency.Value;

            return ((minInterval - maxInterval) * (value - min)) / (max - min) + maxInterval;
        }

        #endregion

        public FormForest()
        {
            InitializeComponent();
            InitialzeFirst();
            Reset();
        }

        private void buttonNextStep_Click(object sender, EventArgs ev)
        {
            try
            {
                p = double.Parse(textBoxProbability.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.ToString());
                return;
            }

            DoNextSteps();
            pictureBox1.Invalidate();

            
        }

        void DoNextSteps()
        {
            canAcuireMouse = false;

            int steps = (int)numericUpDownIt.Value;
            for (int i = 0; i < steps; i++)
                forest.NextStep(p);
            SetLabels();
            DrawForestBitmap();
        }

        private void buttonAutomatic_Click(object sender, EventArgs e)
        {
            if (buttonAutomatic.Text == "Automatic")
            {
                buttonAutomatic.Text = "Pause";
                timer1.Start();
            }
            else if (buttonAutomatic.Text == "Pause")
            {
                buttonAutomatic.Text = "Automatic";
                timer1.Stop();
            }

        }

        

       

        private void menuItemManualDistribution_Click(object sender, EventArgs e)
        {
            int L = forest.L;
            int H = forest.H;
            FormManual formManual = new FormManual(L, H);
            formManual.ShowDialog();
            if (formManual.isAccpeted)
            {
                method = Distribution.Manual;
                n_fired = formManual.n_fired;
                n_green = formManual.n_green;
                Reset();

            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(bitMapCells, 0, 0);
            g.DrawImage(bitMapLattice, 0, 0);
        }

      

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!canAcuireMouse) return;
           

            int i = e.X / sizeRect;
            int j = e.Y / sizeRect;

            byte value = forest.cells[i, j];
            if (value == 1) forest.n_Green--;
            else if (value == 2) forest.n_Fired--;

            value = (byte)((value + 1) % 3);
            forest.cells[i, j] = value;
            if (value == 1) forest.n_Green++;
            else if (value == 2) forest.n_Fired++;

            ChangeOneSiteColor(i, j, value);
            SetLabels();

            pictureBox1.Invalidate();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void menuItemRandom_Click(object sender, EventArgs e)
        {
            method = Distribution.Random;
            Reset();
        }
     

        private void FormForest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer1 != null && timer1.Enabled)
                timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DoNextSteps();
            pictureBox1.Invalidate();
        }

        private void trackBar_Latency_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = CalculateTimerInterval();
        }

        private void checkBoxCycleX_Click(object sender, EventArgs e)
        {
            forest.cyclicX = checkBoxCycleX.Checked;
            forest.cyclicY = checkBoxCycleY.Checked;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Designed by Hor Dashti (h.dashti2@gmail.com)";
            MessageBox.Show(text);
        }

        private void buttonSnapshot_Click(object sender, EventArgs e)
        {
            string namefile = snapshots.ToString() + ".jpeg";
            bitMapCells.Save(namefile);
            snapshots++;
        }

       

        
    }
}