using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class frmDataEntry : Form
    {
        TimeSpan elapsedTime;
        DateTime lastElapsed;

        public frmDataEntry()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtZip.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtName.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime += DateTime.Now - lastElapsed;
            lastElapsed = DateTime.Now;

            txtTimer.Text = Convert.ToString(new TimeSpan(elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            timTimer.Enabled = true;
            grbDataEntry.Enabled = true;
            txtName.Focus();
            lastElapsed = DateTime.Now;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            grbDataEntry.Enabled = false;
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            timTimer.Enabled = false;
        }
    }
}
