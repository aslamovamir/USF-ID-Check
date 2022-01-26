using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void check_btn_Click(object sender, EventArgs e)
        {
            //let's get the USF ID Letter and store in a local variable
            char id_letter = char.Parse(textBox1.Text);
            //now we check if the letter is equal to 'U' or 'F'
            if (id_letter == 'U')
            {
                //we know that if the input letter is equal to 'U', the text message must be 'Accepted'
                textBox2.Text = "Accepted";
            } else if (id_letter == 'F')
            {
                textBox2.Text = "Rejected";
            } else
            {
                textBox2.Text = "Unknown Input! Re-enter your ID letter.";
            }
        }
    }
}
