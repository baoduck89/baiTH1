using System;
namespace baithuchanh1
{
    class Employee
    {
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;
        private double basicSalary;
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getyearOfBirth()
        {
            return yearOfBirth;
        }
        public double getIncome()
        {
            return salaryLevel * basicSalary;
        }
        public void display()
        {
            Console.WriteLine("Thong tin nguoi lao dong");
            Console.Write("Dinh danh: ", id, "Ten: ", name, "Nam sinh: ", yearOfBirth, "Luong co ban: ", basicSalary, "Thu nhap: ", getIncome());
        }
        public double setSalaryLevel
        {
            get
            {
                return salaryLevel;
            }
            set
            {
                salaryLevel = value;
            }
        }
        public double setBasicSalary
        {
            get
            {
                return basicSalary;
            }
            set
            {
                basicSalary = value;
            }
        }
        static void Main2(string[] args)
        {
        }
    }
}