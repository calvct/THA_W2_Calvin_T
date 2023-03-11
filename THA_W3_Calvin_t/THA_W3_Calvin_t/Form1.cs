using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_Calvin_t
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int umur = Convert.ToInt32(tBox_Age.Text);
            if(umur < 18)
            {
                MessageBox.Show("Name: " + tBox_Name.Text + "\nEmail: " + tBox_Email.Text + "\nPhone Number: " + tBox_Phone.Text+ "\nYou are a minor");
            }
            else
            {
                MessageBox.Show("Name: " + tBox_Name.Text + "\nEmail: " + tBox_Email.Text + "\nPhone Number: " + tBox_Phone.Text + "\nYou are an adult");
            }
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tBox_Age.Clear();
            tBox_Email.Clear();
            tBox_Name.Clear();
            tBox_Phone.Clear();
        }
    }
}
