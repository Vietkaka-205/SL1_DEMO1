using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SL1_DEMO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string str = "";
            str = str + "Họ Tên : " + txtHoTen.Text + "\nLớp : " + txtLop.Text + "\nDanh Sách môn: ";
            if (chkCShap.Checked == true) str = str + "CShap,";
            if (chkSQL.Checked == true) str = str + "SQL,";
            if (chkJaVa.Checked == true) str = str + "JaVa,";
            if (chkHTML.Checked == true) str = str + "HTML,";
            MessageBox.Show(str);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
