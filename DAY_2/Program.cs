using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee1 o1 = new Employee1();
            Employee1 o2 = new Employee1();
            Employee1 o3 = new Employee1();

            Console.WriteLine(o1.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o3.EMPNO);

            Console.WriteLine(o3.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o1.EMPNO);
            Console.ReadLine();
        }
    }
}

public class Employee1
{
    private string Name;
    public string NAME
    {
        set
        {
            if(value!="")
                Name = value;
            else
                Console.WriteLine("No blank names allowed.");
            
        }
        get
        {
            return Name;
        }
    }

    static int count=0;
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
            if (20000<=value && value<=30000)
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
            if (value>0)
                DeptNo = value;
            else
                Console.WriteLine("Must be > 0");

        }
        get
        {
            return DeptNo;
        }
    }
    public Employee1(string NAME="Amol", decimal BASIC=20000, short DEPTNO=10)
    {
        count++;
        EmpNo = count;
        this.NAME = NAME;
        this.BASIC = BASIC;
        this.DEPTNO = DEPTNO;
    }
    public decimal GetNetSalary()
    {
        return Basic+(Basic/10);
    }
}