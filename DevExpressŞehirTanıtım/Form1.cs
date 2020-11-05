using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressŞehirTanıtım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            listBoxControl1.Items.Add("Barajyolu");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Add(textEdit1.Text);
            textEdit1.Text=" " ;
        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkEdit4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkEdit5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Form3 frmm = new Form3();
            frmm.Show();
        }
    }
}
