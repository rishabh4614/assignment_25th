using System;

namespace assignment_25th
{

/*    1. Create a class called Accounts which has data members like Account no, Customer name, Account type, Transaction type(d/w), amount, balance
D->Deposit
W->Withdrawal

-write a function that updates the balance depending upon the transaction type

	-If transaction type is deposit call the credit(int amount) function and update balance
	-If transaction type is withdraw call debit(int amt)function and update balance
-Pass the other information like Acount no,name,acc type through constructor
-call the show data method to display the values.

*/

    class Accounts
    {
       private int Account_no;
       private string Customer_name;
       private string Account_type;
       private int Amount;
       
        
        public string Details                                //PROPERTY
        {
            get { return Customer_name; }
        }

        public int credit(ref int amount)
        {
            Amount = Amount + amount;
            return Amount;
        }

        public int withdraw(ref int amt)
        {
            Amount = Amount - amt;
            return Amount;
        }
        
        public void show()
        {
            Console.WriteLine("Your Name is: " + Customer_name);
            Console.WriteLine("You account number is: " + Account_no);
            Console.WriteLine("Your account type is: " + Account_type);
            Console.WriteLine("Balance in your account: " + Amount);
        }
        public Accounts(int acc_no, string name, string acc_type)
        {
            Account_no = acc_no;
            Customer_name = name;
            Account_type = acc_type;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------Welcome to Online Bank--------------------");
            Console.WriteLine("-----------------Enter below details to proceed--------------------");
            Console.WriteLine("1. Account No");
            int accNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Your Name");
            string naMe = (Console.ReadLine());
            Console.WriteLine("3. Account Type");
            string accType = (Console.ReadLine());

            Accounts ac = new Accounts(accNo,naMe,accType);
            int choice;

            while (true)
            {
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Press 1 to Show account Details");
                Console.WriteLine("Press 2 to Withdraw");
                Console.WriteLine("Press 3 to Diposit");
                Console.WriteLine("Press 0 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    return;
                }

                switch (choice)
                {
                    case 1:
                        ac.show();
                        break;
                    case 2:
                        Console.Write("Enter amount to Withdraw: ");
                        int amt = Convert.ToInt32(Console.ReadLine());
                        ac.withdraw(ref amt);
                        Console.WriteLine("Amount Withdraw.");
                        Console.WriteLine("Thankyou for Banking with us !!!");
                        break;
                    case 3:
                        Console.Write("Enter amount to Diposit: ");
                        int dep = Convert.ToInt32(Console.ReadLine());
                        ac.credit(ref dep);
                        Console.WriteLine("Amount has been credited.");
                        Console.WriteLine("Thankyou for Banking with us !!!");
                        break;

                }
            }
            
        }

    }
}
