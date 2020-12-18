using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListOfEmployee
{
    class Program
    {
        static int n = 0;

        static void Main(string[] args)
        {
            bool c = true;
            SortedList<int, Employee> lstEmps = new SortedList<int, Employee>();
            string choice = "yes";

            while (c == true)
            {
                Console.WriteLine("Add Employee??(yes/no)");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "yes":
                        {
                            n++;
                            Console.WriteLine("Enter EmpName, Salary, DeptNo");
                            lstEmps.Add(n, new Employee { NAME = Console.ReadLine(), BASIC = Convert.ToDecimal(Console.ReadLine()), DEPTNO = short.Parse(Console.ReadLine()) });
                            break;
                        }
                    case "no":
                        {
                            c = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please, only enter yes/no !!");
                            break;
                        }
                }
            }


            Employee objEmp = new Employee();

            Console.WriteLine("TOTAL EMPLOYEES:");
            foreach (KeyValuePair<int, Employee> emp in lstEmps)
            {
                objEmp = emp.Value;
                Console.WriteLine(objEmp.EMPNO + " " + objEmp.NAME + " " + objEmp.BASIC + " " + objEmp.DEPTNO);
            }

            
            Console.WriteLine();
            Console.WriteLine("Employee with highest salary:");
            decimal max = 0;
            foreach (KeyValuePair<int, Employee> emp in lstEmps)
            {
                objEmp = emp.Value;
                if (max < objEmp.BASIC)
                    max = objEmp.BASIC;
            }
            foreach (KeyValuePair<int, Employee> emp in lstEmps)
            {
                objEmp = emp.Value;
                if (max == objEmp.BASIC)
                {
                    Console.WriteLine(objEmp.EMPNO + " " + objEmp.NAME + " " + objEmp.BASIC + " " + objEmp.DEPTNO);
                }
            }


            Console.WriteLine();
            Console.WriteLine("Enter Employee number to be searched:");
            int x=Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<int, Employee> emp in lstEmps)
            {
                objEmp = emp.Value;
                if (x == objEmp.EMPNO)
                {
                    Console.WriteLine(objEmp.EMPNO + " " + objEmp.NAME + " " + objEmp.BASIC + " " + objEmp.DEPTNO);
                }
            }

            Console.ReadLine();
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
}
