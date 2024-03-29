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
    public partial class Trangchu : Form
    {
        BankAccountFacade accoutNow;

        public Trangchu(BankAccountFacade accountReceive)
        {
            accoutNow = accountReceive;
            InitializeComponent();
        }

        public void LoadData()
        {
            txtCashAmount.Text = accoutNow.cashManager.GetCashInAccount();
            txtN.Text = accoutNow.GetaccountName();
        }
        private void Trangchu_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnNap_Click(object sender, EventArgs e)
        {
            double cashAmount = double.Parse(txtNhap.Text);
            accoutNow.depositCash(cashAmount);
            LoadData();
            Application.DoEvents();

        }

        private void btnRut_Click(object sender, EventArgs e)
        {
            double cashAmount = double.Parse(txtNhap.Text);
            accoutNow.withdrawCash(cashAmount);
            LoadData();
            Application.DoEvents();
        }
    }
}
