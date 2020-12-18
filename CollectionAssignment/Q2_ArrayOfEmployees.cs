using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_ArrayToList
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] arrEmpObj=new Employee[3];
            for(int i=0;i<arrEmpObj.Length;i++)
            {
                Console.WriteLine("Enter EmpName, Salary, DeptNo");
                arrEmpObj[i] = new Employee { NAME = Console.ReadLine(), BASIC = Convert.ToDecimal(Console.ReadLine()), DEPTNO = short.Parse(Console.ReadLine()) };
            }


            List<Employee> listEmps = new List<Employee>();
            listEmps=arrEmpObj.ToList();

            Console.WriteLine("TOTAL EMPLOYEES in LIST:");
            foreach (Employee emp in listEmps)
            {
                Console.WriteLine(emp.EMPNO + " " + emp.NAME + " " + emp.BASIC + " " + emp.DEPTNO);
            }

            Console.ReadLine();
        }
    }



    class Employee
    {
        private string Name;
        public string NAME
        {
            set
            {
                if (value != "")
                    Name = value;
                else
                    Console.WriteLine("No blank names allowed.");

            }
            get
            {
                return Name;
            }
        }

        static int count = 0;
        private int EmpNo;
        public int EMPNO
        {
            get
            {
                return EmpNo;
            }
        }

        private decimal Basic;
        public decimal BASIC
        {
            set
            {
                if (20000 <= value && value <= 30000)
                    Basic = value;
                else
                    Console.WriteLine("Not valid.");

            }
            get
            {
                return Basic;
            }
        }

        private short DeptNo;
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    DeptNo = value;
                else
                    Console.WriteLine("Must be > 0");

            }
            get
            {
                return DeptNo;
            }
        }
        public Employee(string NAME = "Amol", decimal BASIC = 20000, short DEPTNO = 10)
        {
            count++;
            EmpNo = count;
            this.NAME = NAME;
            this.BASIC = BASIC;
            this.DEPTNO = DEPTNO;
        }
    }
}

