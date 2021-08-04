using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Week5Day2Assignment1
{
    public partial class Form1 : Form
    {
        ArrayList Checking;
        ArrayList Savings;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Checking = new ArrayList();
            Checking.Add(new CustomerAccount(1, fName: "Hung", lName: "Le", cityState: "Houston, TX", phoneN: "345-123-6789", amount: 1500));
            Checking.Add(new CustomerAccount(1, fName: "Hung", lName: "Le", cityState: "Houston, TX", phoneN: "345-123-6789", amount: 500));
            Checking.Add(new CustomerAccount(1, fName: "Hung", lName: "Le", cityState: "Houston, TX", phoneN: "345-123-6789", amount: 600));
            Checking.Add(new CustomerAccount(1, fName: "Hung", lName: "Le", cityState: "Houston, TX", phoneN: "345-123-6789", amount: 700));
            gridChkAcct.DataSource = Checking;
            comboAcctType.DataSource = Enum.GetValues(typeof(TypeofAccount));
            comboTransfer.DataSource = Enum.GetValues(typeof(TypeofTransaction));

            Savings = new ArrayList();
            Savings.Add(new CustomerAccount(1, fName: "Hung", lName: "Le", cityState: "Houston, TX", phoneN: "345-123-6789", amount: 1500));
            Savings.Add(new CustomerAccount(1, fName: "Hung", lName: "Le", cityState: "Houston, TX", phoneN: "345-123-6789", amount: 1000));
            Savings.Add(new CustomerAccount(1, fName: "Hung", lName: "Le", cityState: "Houston, TX", phoneN: "345-123-6789", amount: 800));
            Savings.Add(new CustomerAccount(1, fName: "Hung", lName: "Le", cityState: "Houston, TX", phoneN: "345-123-6789", amount: 300));
            Savings.Add(new CustomerAccount(1, fName: "Hung", lName: "Le", cityState: "Houston, TX", phoneN: "345-123-6789", amount: 100));
            gridSavings.DataSource = Savings;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (comboAcctType.Text == "Checking" && comboTransfer.Text != string.Empty && txtID.Text != string.Empty && txtFN.Text != string.Empty &&
                txtLN.Text != string.Empty && txtCityState.Text != string.Empty && txtPhone.Text != string.Empty
                && txtAmount.Text != string.Empty)
            {
                CustomerAccount newCheckDep = new CustomerAccount();
                newCheckDep.AcctID = Int32.Parse(txtID.Text);
                newCheckDep.FirstName = txtFN.Text;
                newCheckDep.LastName = txtLN.Text;
                newCheckDep.CityState = txtCityState.Text;
                newCheckDep.PhoneNumber = txtPhone.Text;
                newCheckDep.Amount = Int32.Parse(txtAmount.Text);
                Checking.Add(newCheckDep);

                MoneyTransfer newCMoney = new MoneyTransfer();
                newCMoney.LowMoney += NewCMoney_LowMoney;
                newCMoney._money = newCheckDep.Amount;

                CheckingTotal();
            }
            else if (comboAcctType.Text == "Savings" && comboTransfer.Text != string.Empty && txtID.Text != string.Empty && txtFN.Text != string.Empty &&
                txtLN.Text != string.Empty && txtCityState.Text != string.Empty && txtPhone.Text != string.Empty
                && txtAmount.Text != string.Empty)
            {
                CustomerAccount newSavingsDep = new CustomerAccount();
                
                newSavingsDep.AcctID = Int32.Parse(txtID.Text);
                newSavingsDep.FirstName = txtFN.Text;
                newSavingsDep.LastName = txtLN.Text;
                newSavingsDep.CityState = txtCityState.Text;
                newSavingsDep.PhoneNumber = txtPhone.Text;
                newSavingsDep.Amount = Int32.Parse(txtAmount.Text);
                Savings.Add(newSavingsDep);

                MoneyTransfer newSMoney = new MoneyTransfer();
                newSMoney.LowMoney += NewSMoney_LowMoney;
                newSMoney._money = newSavingsDep.Amount;

                SavingsTotal();
            }
            RefreshAccount();
        }
        private void NewSMoney_LowMoney(int money)
        {
            MessageBox.Show("Your transfer is in progress, Please check your balance!");
        }

        private void NewCMoney_LowMoney(int money)
        {
            MessageBox.Show("Your transfer is in progress, Please check your balance!");
        }



        private void RefreshAccount()
        {
            txtID.Clear();
            txtFN.Clear();
            txtLN.Clear();
            txtCityState.Clear();
            txtPhone.Clear();
            txtAmount.Clear();
            comboTransfer.Text = "Select Transfer Type";
            comboAcctType.Text = "Select Account Type";
            gridChkAcct.DataSource = null;
            gridChkAcct.DataSource = Checking;
            gridSavings.DataSource = null;
            gridSavings.DataSource = Savings;
        }



        private void btnDispChk_Click(object sender, EventArgs e)
        {
            CheckingTotal();
        }
        public void CheckingTotal()
        {
            double sum = 0;
            for (int i = 0; i < gridChkAcct.Rows.Count; i++)
            {
                if (Convert.ToBoolean(gridChkAcct.Rows[i].Cells[0].Value) == true)
                {
                    sum += double.Parse(gridChkAcct.Rows[i].Cells[5].Value.ToString());
                }
            }
            txtChkSum.Text = sum.ToString();
        }


        private void btnDispSavings_Click(object sender, EventArgs e)
        {
            SavingsTotal();
        }
        public void SavingsTotal()
        {
            double sum = 0;
            for (int i = 0; i < gridSavings.Rows.Count; i++)
            {
                if (Convert.ToBoolean(gridSavings.Rows[i].Cells[0].Value) == true)
                {
                    sum += double.Parse(gridSavings.Rows[i].Cells[5].Value.ToString());
                }
            }
        }


        private void txtChkSum_TextChanged(object sender, EventArgs e)
        {
            CustomerAccount newChTotal = new CustomerAccount();
            newChTotal.Amount = Int32.Parse(txtChkSum.Text);
            MoneyTransfer newCTotal = new MoneyTransfer();
            newCTotal.LowMoney += NewTotal_LowMoney;
            newCTotal._money = newChTotal.Amount;
        }

        private void NewTotal_LowMoney(int money)
        {
            MessageBox.Show("Your Checking Account Balance is Below $100.00!!");
        }

        private void txtSavingsSum_TextChanged(object sender, EventArgs e)
        {
            CustomerAccount newSavTotal = new CustomerAccount();
            newSavTotal.Amount = Int32.Parse(txtSavingsSum.Text);
            MoneyTransfer newSTotal = new MoneyTransfer();
            newSTotal.LowMoney += NewSTotal_LowMoney;
            newSTotal._money = newSavTotal.Amount;
        }

        private void NewSTotal_LowMoney(int money)
        {
            MessageBox.Show("Your Savings Account Balance is Below $100.00!!");
        }
    }
}