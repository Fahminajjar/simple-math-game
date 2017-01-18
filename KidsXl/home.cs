using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsXl
{
    public partial class home : Form
    {

        public home()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 frmAdd = new Form1();
            frmAdd.setOp("+");
            frmAdd.StartPosition = FormStartPosition.CenterScreen;
            frmAdd.Show();
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Form1 frmSub = new Form1();
            frmSub.setOp("-");
            frmSub.StartPosition = FormStartPosition.CenterScreen;
            frmSub.Show();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMulti_Click_1(object sender, EventArgs e)
        {
            Form1 frmMulti = new Form1();
            frmMulti.setOp("*");
            frmMulti.StartPosition = FormStartPosition.CenterScreen;
            frmMulti.Show();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Form1 frmDiv = new Form1();
            frmDiv.setOp("/");
            frmDiv.StartPosition = FormStartPosition.CenterScreen;
            frmDiv.Show();
        }
    }
}
