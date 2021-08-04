using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Day2Assignment1
{
    public delegate string LowMoney(string name);
    public delegate void MoneyCheck(int money);
    enum TypeofAccount { Checking, Savings}
    enum TypeofTransaction { Deposits, Transfer}
    struct CustomerAccount
    {
        public int AcctID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CityState { get; set; }
        public string PhoneNumber { get; set; }
        public int Amount { get; set; }

        public CustomerAccount(int acctID, string fName, string lName, string cityState, string phoneN, int amount)
        {
            this.AcctID = acctID;
            this.FirstName = fName;
            this.LastName = lName;
            this.CityState = cityState;
            this.PhoneNumber = phoneN;
            this.Amount = amount;
        }
    }
    class MoneyTransfer
    {
        private int money;
        public event MoneyCheck LowMoney;
        public int _money
        {
            get { return this.money; }
            set
            {
                if (value < 100)
                {
                    LowMoney(value);
                }
                else
                {
                    this.money = value;
                }
            }
        }
    }
}
