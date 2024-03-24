using System.Data;

namespace Accounts.cs
{
    public class Account
    {
        //Declare and Initialize constant
        public const decimal MINIMUMBALANCE = 25.00m;

        //Instance variables
        private readonly string _title;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _accountNumber;
        private readonly string _pinNumber;
        private decimal _balance;

        //Full-arg Constructor
        public Account(string title, string firstname,
                        string lastname, string accountNumber,
                        string pinNumber, decimal balance)
        {
            _title = title;
            _firstName = firstname;
            _lastName = lastname;
            _accountNumber = accountNumber;
            _pinNumber = pinNumber;
            _balance = balance;
        }

        //Declare and initialze Getters
        public string GetTitle() => _title;
        public string GetFirstName() => _firstName;
        public string GetLastName() => _lastName;
        public string GetAccountNumber() => _accountNumber;
        public string GetPinNumber() => _pinNumber;
        public decimal GetBalance() => _balance;

        //Attempt to make a deposit method
        public void MakeDeposit(decimal deposit)
        {
            //Create a local variable to hold a copy of the attempted deposit
            decimal theDeposit = deposit;

            try
            {
                //Attempt to make a deposit but first verify deposit amount is not negative
                if (theDeposit <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                //Deposit was > 0
                _balance += theDeposit;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("System Message:\t" + aoore.Message +
                                "\n\n" + "Illegal Deposit. " +
                                "Must be greater than zero.",
                                "Illegal Deposit Attempted");
                return;
            }
        }

        //Attempt to make a withdrawal method
        public void MakeWithdrawal(decimal withdrawal)
        {
            //Create a local variable to hold a copy of the attempted withdrawal
            decimal theWithdrawal = withdrawal;
            decimal newBalance = 0;

            try
            {
                //Attempt to make a withdrawal but first verify deposit amount is not negative
                if (theWithdrawal <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                //The withdrawal amount was positive, verify that the
                //withdrawal will leave our account balance with atleast 25
                newBalance = _balance - theWithdrawal;

                if (newBalance < MINIMUMBALANCE)
                {
                    throw new DataException("");
                }
                //Withdrawal was > 0
                //& the balance after the withdrawal is >= 25
                _balance -= theWithdrawal;
            }
            catch (DataException de)
            {
                MessageBox.Show("System Message:\t" + de.Message +
                                "\n\n" + "Insufficient Funds For This Withdrawal.",
                                "INSUFFICIENT FUNDS");
                return;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("System Message:\t" + aoore.Message +
                                "\n\n" + "Illegal Withdrawal. " +
                                "Must be greater than zero.",
                                "Illegal Withdrawal Attempted");
                return;
            }
        }
    }
}
