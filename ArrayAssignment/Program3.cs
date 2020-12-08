using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_StudentStructArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            ArrayList arr = new ArrayList();
            arr.Capacity = 5;
            for(int i=0; i<5;i++)
            {
                Console.WriteLine("Enter Name, Roll No, Marks of Student {0}",(i+1));
                std.NAME = Console.ReadLine();
                std.ROLLNO = Convert.ToInt32(Console.ReadLine());
                std.MARKS = Convert.ToDecimal(Console.ReadLine());
                arr.Add(std);
            }
            Console.WriteLine();
            Console.WriteLine();

            foreach(Student o in arr)
            {
                Console.WriteLine(o.NAME+" "+o.ROLLNO+" "+o.MARKS);
            }

            Console.ReadLine();
        }
    }
}

public struct Student
{
    private string Name;
    private int RollNo;
    private decimal Marks;

    public string NAME
    {
        set
        {
            if(value!="")
                Name = value;
            else
                Console.WriteLine("Name can't be blank!");
        }
        get
        {
            return Name;
        }
    }

    public int ROLLNO
    {
        set
        {
            if (value != 0)
                RollNo = value;
            else
                Console.WriteLine("Roll number can't be 0!");
        }
        get
        {
            return RollNo;
        }
    }
    public decimal MARKS
    {
        set
        {
            if (value != 0)
                Marks = value;
            else
                Console.WriteLine("Marks can't be 0!");
        }
        get
        {
            return Marks;
        }
    }

    public Student(string NAME="NoName",int ROLLNO=100,decimal MARKS=15)
    {
        Name = "aa";
        RollNo = 1;
        Marks = 0;
        this.NAME = NAME;
        this.ROLLNO= ROLLNO;
        this.MARKS= MARKS;
    }

}
