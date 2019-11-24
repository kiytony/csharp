using System;

namespace Bank
{
    class Customer
    {
        public string f_name { get; set; }
        public string l_name { get; set; }
        public char gender { get; set; }
        public string acc_num { get; set; }
        public string acc_type { get; set; }
        public string currency { get; set; }
        public double initial_balance { get; set; }
        public double balance { get; set; }

        public Customer()
        {
            Console.WriteLine("First Name: ");
            this.f_name = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            this.l_name = Console.ReadLine();
            Console.WriteLine("Gender: M|F");
            this.gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Account Number: ");
            this.acc_num = Console.ReadLine();
            Console.WriteLine("Account Type: ");
            this.acc_type = Console.ReadLine();
            Console.WriteLine("Choose Account Currency: RWF|USD|EUR");
            this.currency = Console.ReadLine();
            

            if (currency == "RWF")
            {
                this.initial_balance = 50000;
            }
            else if ((currency == "USD")|| (currency == "EUR"))
            {
                this.initial_balance = 50;
            }
            this.balance = 0;
        }

        public Customer(string f_name, string l_name, char gender, string acc_num, string acc_type, string currency, double initial_balance, double balance)
        {
            this.f_name = f_name;
            this.l_name = l_name;
            this.gender = gender;
            this.acc_num = acc_num;
            this.acc_type = acc_type;
            this.currency = currency;
            this.initial_balance = initial_balance;
            this.balance = balance;
        }

        public string displayInfo()
        {
            return string.Format(
                "First Name: {0} \nLast Name: {1} \nGender: {2} \nAccount Number: {3} \nAccount Type: {4} \nAccoount Currency: {5} \nInitial Balance: {6}",
                f_name, l_name, gender, acc_num, acc_type, currency, initial_balance);
        }

        public double depositOperation(double depositAmount)
        {
            balance = initial_balance + depositAmount;
            return balance;
        }

        public double withdrawOperation(double withdrawAmount)
        {
            balance = initial_balance - withdrawAmount;
            return balance;
        }
        
        static void Main(string[] args)
        {
            Customer cust01 = new Customer();
            Console.WriteLine("Review Information: Y|N ");
            string check = Console.ReadLine();
            if (check == "Y")
            {
                Console.WriteLine(cust01.displayInfo());
            }
            else
            {
                Console.WriteLine("OKAY");
            }
            Console.WriteLine("Perform Operation: 1->Deposit|2->Withdraw");
            string op = Console.ReadLine();
            if (op == "1")
            {
                Console.WriteLine("Amount to Deposit: ");
                double amt = Convert.ToDouble(Console.ReadLine());
                cust01.depositOperation(amt);
            }
            else if (op == "2")
            {
                Console.WriteLine("Amount to Withdraw: ");
                double amt = Convert.ToDouble(Console.ReadLine());
                if (amt == 0)
                {
                    Console.WriteLine("You need to deposit amount more than 0");
                }
                cust01.withdrawOperation(amt);
            }

        }
    }
}