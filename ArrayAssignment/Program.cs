using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region ArrayOfEmployeeObjects

namespace ArrayOfEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter number of employees: ");
            i = Convert.ToInt32(Console.ReadLine());
            
            Employee[] arr = new Employee[i];
            Console.WriteLine();

            for(int j=0; j<arr.Length; j++)
            {
                Console.WriteLine("Enter Name, Salary and Department number of employees no. " + (j + 1));
                string name = Console.ReadLine();
                decimal sal = Convert.ToDecimal(Console.ReadLine());
                short dept = short.Parse(Console.ReadLine());
                arr[j] = new Employee(name, sal, dept);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            Boolean b = true;
            while(b)
            {
                int choice;
                Console.WriteLine("1. Find Employee with highest salary \n2. Search Employee using EmpNo\n3.Exit");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        {
                            decimal high = 0;
                            foreach(Employee o in arr)
                            {
                                if(o.BASIC>high)
                                {
                                    high = o.BASIC;
                                }
                            }
                            foreach (Employee o in arr)
                            {
                                if (o.BASIC == high)
                                {
                                    Console.WriteLine(o.EMPNO+" "+o.NAME+" "+o.BASIC+" "+o.DEPTNO);
                                }
                            }

                            break;
                        }
                    case 2:
                        {
                            int eNo;
                            Console.WriteLine("Enter Employee Number: ");
                            eNo = Convert.ToInt32(Console.ReadLine());
                            foreach (Employee o in arr)
                            {
                                if (o.EMPNO == eNo)
                                {
                                    Console.WriteLine(o.EMPNO + " " + o.NAME + " " + o.BASIC + " " + o.DEPTNO);
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            b = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice!");
                            break;
                        }
                }
            }

            Console.ReadLine();
        }
    }
}

public class Employee
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
            if (10000 <= value && value <= 90000)
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

#endregion