using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame
{
    public partial class Form1 : Form
    {
        private static int mode = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mode = 1; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mode = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mode = 2;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Game objUI = new Game();
            objUI.ShowDialog();
            this.Close();
        }

        public static int getMode()
        {
            return mode;
        }
    }
}
