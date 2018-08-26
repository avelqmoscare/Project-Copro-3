using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsInputProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            btnCon.Enabled = false;
            btnDis.Enabled = true;
            txtbox.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            String input = txtbox.Text;
            string comp = "";
            switch (input)
            {
                case "Hello":
                    comp = "Hi";
                    break;
                case "Hi":
                    comp = "Hello";
                    break;
                case "How are you?":
                    comp = "I'm fine";
                    break;
                case "What is date Now":
                    comp = date.ToLongDateString();
                    break;
                default:
                    comp = "The text is not recognize";
                    break;
            }
            richTextBox1.AppendText(date.ToString() + "\nYou: " + input + "\nComputer: " + comp + "\n");
            txtbox.Text = "";
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You don't have an any text please put text in textbox");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {
            if (txtbox.Text == "")
            {
                btnBlack.Visible = true;
                btnGr.Visible = false;
            }
            else
            {
                btnGr.Visible = true;
                btnBlack.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            if (txtbox.Text == "")
            {
                MessageBox.Show("We don't have a text to clear");
            }
            else
            {
                txtbox.Text = "";
            }
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            btnDis.Enabled = false;
            btnCon.Enabled = true;
            richTextBox1.Clear();
            txtbox.Enabled = false;
            txtbox.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to exit?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                this.Close();
                }
        }

        private void frmClose(object sender, FormClosingEventArgs e)
        {
           
            }
        }
    }

