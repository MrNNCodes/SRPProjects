using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restik
{
    public partial class Form1 : Form
    {
        Server server = new Server();
        int iS = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (iS == 8)
                button1.Enabled = false;
            else
            {
                iS++;
                int chickCount = Convert.ToInt32(textBox1.Text);
                int eggCount = Convert.ToInt32(textBox2.Text);
                string drink = comboBox1.Text;
                server.Receive(chickCount, eggCount, drink);
                button2.Enabled = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            server.Send();
            if (server.GetQuality() != 0)
            {
                label6.Text = $"{server.GetQuality()}/100";
            }
            else
            {
                label6.Text = "";
            }
            label4.Text += "Got The Table Order In!\n";
            button2.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label4.Text += server.Serve();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            iS = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

