using BankFacade.Pattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankFacade
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String taikhoan = txtMaThe.Text;
            String securityCode = txtSecurityCode.Text;

           

            BankAccountFacade tmpAccount = new BankAccountFacade(taikhoan, securityCode);
            if(tmpAccount != null && BankAccountFacade.accountChecker.isValid(taikhoan, securityCode)) 
            {
                Trangchu trangChu = new Trangchu(tmpAccount);
                trangChu.Show();
                
                

            }else
            {
                MessageBox.Show("khong co tai khoan " + taikhoan + "|" + securityCode);
            }

        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
