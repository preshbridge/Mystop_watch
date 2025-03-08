using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyStop_Watch
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Stopwatch instance to track time.
        /// </summary>
        Stopwatch stopWatch;

        /// <summary>
        /// Initializes the form components.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event triggered when the form loads.
        /// Initializes the Stopwatch instance.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        /// <summary>
        /// Starts the stopwatch timer when Button 1 is clicked.
        /// Prevents duplicate starts.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!stopWatch.IsRunning)
            {
                stopWatch.Start();
            }
            else
            {
                MessageBox.Show("Stopwatch is already running!");
            }
        }
        /// taiwo's part
        /// <summary>
        /// Updates the label with the elapsed time every tick of the timer.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch.Elapsed);
        }

        /// <summary>
        /// Stops the stopwatch timer.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        /// <summary>
        /// Resets the stopwatch timer.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
            label1.Text = "00:00:00"; // Reset label to zero
        }

        /// <summary>
        /// Resumes the stopwatch timer.
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            if (!stopWatch.IsRunning)
            {
                stopWatch.Start();
            }
        }

        /// <summary>
        /// Restarts the stopwatch timer from zero.
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            stopWatch.Restart();
        }
    }
}