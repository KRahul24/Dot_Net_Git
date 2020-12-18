using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//1. decimal SimpleInterest(decimal P, decimal N, decimal R) -> returns calculated SimpleInterest
//2. bool IsGreater(int a, int b) -> returns true if a is > b
//3. decimal GetBasic(Employee e) -> returns the Basic salary of the employee
//4. bool IsEven(int num) -> returns true if the number is an even number
//5. bool IsGreaterThan10000(Employee e) -> returns true if the Basic Salary is > 10000


namespace LambdaAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple interest:\nenter P, N and R");
            decimal P, N, R;
            P = Convert.ToDecimal(Console.ReadLine());
            N = Convert.ToDecimal(Console.ReadLine());
            R = Convert.ToDecimal(Console.ReadLine());
            Func<decimal, decimal, decimal, decimal> SI = (p,n,r) => ((p*n*r) / 100);
            Console.WriteLine("SI:"+Convert.ToString( SI(P,N,R)));
            Console.WriteLine();


            Console.WriteLine("Greater number:\nEnter two numbers");
            int a,b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Func<int,int,bool> Greater= (A,B) => A>B;
            if(Greater(a,b))
                Console.WriteLine("Greater Number:"+a);
            else
                Console.WriteLine("Greater Number:" + b);
            Console.WriteLine();


            Employee objEmp = new Employee() { EmpNo = 1, Name = "Shubham", Basic = 20000, DeptNo = 10 };
            Console.WriteLine("Basic Salary:");
            Func<Employee, decimal> GetBasic = (emp) => emp.Basic;
            Console.WriteLine("Basic Salary:" + Convert.ToString(GetBasic(objEmp)));
            Console.WriteLine();


            Console.WriteLine("Even or Odd:\nEnter a munber:");
            a = Convert.ToInt32(Console.ReadLine());
            Predicate<int> IsEven = (A) =>a%2==0;
            if (IsEven(a))
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");
            Console.WriteLine();



            Console.WriteLine("If basic salary is greater than 10000:");
            Func<Employee, bool> CheckBasic = (emp) => emp.Basic>10000;
            if (CheckBasic(objEmp))
                Console.WriteLine("Greater than 10000");
            else
                Console.WriteLine("Less than 10000");
            Console.WriteLine();



            Console.ReadLine();
        }
    }

    public class Employee
    {
       public int EmpNo;
       public string Name;
       public decimal Basic;
       public short DeptNo;
    }
}
