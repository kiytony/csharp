using System;

namespace Salary
{
    class Employee
    {
        public string emp_id { get; set; }
        public string f_name { get; set; }
        public string l_name { get; set; }
        public char gender { get; set; }
        public string position { get; set; }
        public string emp_category { get; set; }
        public double gross_salary { get; set; }
        public double net_salary { get; set; }

        public Employee()
        {
            Console.WriteLine("Employee ID: ");
            this.emp_id = Console.ReadLine();
            Console.WriteLine("First Name: ");
            this.f_name = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            this.l_name = Console.ReadLine();
            Console.WriteLine("Gender: ");
            this.gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Position: ");
            this.position = Console.ReadLine();
            Console.WriteLine("Employee Category: Monthly|Hourly|One-Time");
            this.emp_category = Console.ReadLine();
            Console.WriteLine("Employee Gross Salary: ");
            this.gross_salary = Convert.ToDouble(Console.ReadLine());
        }

        public Employee(string emp_id, string f_name, string l_name, char gender, string position, string emp_category,
            double gross_salary, double net_salary)
        {
            this.emp_id = emp_id;
            this.f_name = f_name;
            this.gender = gender;
            this.position = position;
            this.emp_category = emp_category;
            this.gross_salary = gross_salary;
            this.net_salary = net_salary;
        }

        public string empInfo()
        {
            return string.Format(
                "Employere ID: {0} \nFirst Name: {1} \nLast Name: {2} \nGender: {3} \nEmployee Position: {4} \nEmployee Category: {5} \nEmployee Gross Salary: {6} \n",
                emp_id, f_name, l_name, gender, position, emp_category, gross_salary);
        }

        public double netSalary()
        {
            double tax, rssb, insurance, rate;
            if (emp_category == "Monthly")
            {
                tax = (30 * gross_salary) / 100;
                rssb = (5 * gross_salary) / 100;
                insurance = (3 * gross_salary) / 100;
                net_salary = gross_salary- (tax + rssb + insurance);
            }
            else if (emp_category == "Hourly")
            {
                double hrs;
                Console.WriteLine("Number of Hours Worked: ");
                hrs = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Rate Per Hour: ");
                rate = Convert.ToDouble(Console.ReadLine());
                rssb = (5 * gross_salary) / 100;
                insurance = (3 * gross_salary) / 100;
                net_salary = (hrs * rate) - (rssb + insurance);
            }
            else if (emp_category == "One-Time")
            {
                tax = (30 * gross_salary) / 100;
                net_salary = gross_salary - tax;
            }
            return net_salary;
        }
        static void Main(string[] args)
        {
            Employee emp01 = new Employee();
            Console.WriteLine("Review Information: Y|N ");
            string check = Console.ReadLine();
            if (check == "Y")
            {
                Console.WriteLine(emp01.empInfo());
            }
            else
            {
                Console.WriteLine("OKAY");
            }
            Console.WriteLine("Calculate Net Salary: Y|N ");
            check = Console.ReadLine();
            if (check == "Y")
            {
                Console.WriteLine("Net Salary: "+emp01.netSalary());
            }
            else
            {
                Console.WriteLine("That's All");
            }
        }
    }
}