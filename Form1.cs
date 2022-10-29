using System;
using System.Windows.Forms;

namespace devoir3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Name = "00";
            Logic.checkAndDisplay(btn);
            Logic.verify(btn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Name = "01";
            Logic.checkAndDisplay(btn);
            Logic.verify(btn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Name = "02";
            Logic.checkAndDisplay(btn);
            Logic.verify(btn);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Name = "10";
            Logic.checkAndDisplay(btn);
            Logic.verify(btn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Name = "11";
            Logic.checkAndDisplay(btn);
            Logic.verify(btn);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Name = "12";
            Logic.checkAndDisplay(btn);
            Logic.verify(btn);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Name = "20";
            Logic.checkAndDisplay(btn);
            Logic.verify(btn);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Name = "21";
            Logic.checkAndDisplay(btn);
            Logic.verify(btn);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Name = "22";
            Logic.checkAndDisplay(btn);
            Logic.verify(btn);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button0.Text = String.Empty;
            button1.Text = String.Empty;
            button2.Text = String.Empty;
            button3.Text = String.Empty;
            button4.Text = String.Empty;
            button5.Text = String.Empty;
            button6.Text = String.Empty;
            button7.Text = String.Empty;
            button8.Text = String.Empty;

            Logic.clear();
        }
    }
}
