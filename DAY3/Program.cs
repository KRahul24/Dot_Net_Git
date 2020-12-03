﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            CEO c = new CEO("Rahul", 30, 95000);
            Manager m = new Manager("shubham", 10, 45000, "Software");
            GeneralManager gm = new GeneralManager("pratik", 20, 25000, "logistics", "promoted");
            

            Console.WriteLine(c.EMPNO+" "+c.NAME+" "+c.DEPTNO+" "+c.BASIC+" "+c.CalcNetSalary());
            Console.WriteLine(m.EMPNO + " " + m.NAME + " " + m.DEPTNO + " " + m.BASIC + " " +m.DESGN+" "+m.CalcNetSalary());
            Console.WriteLine(gm.EMPNO + " " + gm.NAME + " " + gm.DEPTNO + " " + gm.BASIC + " " + gm.DESGN + " " +gm.PERKS+" "+gm.CalcNetSalary());

            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        private string Name; //-> no blanks
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

        private static int count=0;
        private int EmpNo; //-> readonly, autogenerated
        public int EMPNO
        {
            get
            {
                return EmpNo;
            }
        }

        private short DeptNo; //-> > 0
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    DeptNo = value;
                else
                    Console.WriteLine("DeptNo must be > 0");
            }
            get
            {
                return DeptNo;
            }
        }

        protected decimal Basic;
        public abstract decimal BASIC
        {
            set;
            get;
        }
        public abstract decimal CalcNetSalary();

        public Employee(short DEPTNO = 10,string NAME = "NoName")
        {
            count++;
            EmpNo = count;
            this.DEPTNO = DEPTNO;
            this.NAME = NAME;
        }
    }

    class Manager: Employee 
    {
        private string Designation;
        public string DESGN
        {
            set
            {
                if (value != "")
                    Designation = value;
                else
                    Console.WriteLine("Designaton can't be blank!");
            }
            get
            {
                return Designation;
            }

        }

        public override decimal BASIC
        {
            set
            {
                if (value >=40000 && value <= 60000)
                    Basic = value;
                else
                    Console.WriteLine("Invalid salary for Manager");
            }

            get
            {
                return Basic;
            }
        }

        public Manager(string NAME, short DEPTNO, decimal BASIC, string DESGN="NoDesignation") : base(DEPTNO, NAME)
        {
            this.DESGN = DESGN;
            this.BASIC = BASIC;
        }

        public Manager(string NAME, short DEPTNO,string DESGN = "NoDesignation") : base(DEPTNO, NAME)
        {
            this.DESGN = DESGN;
        }

        public override decimal CalcNetSalary()
        {
            return BASIC + (BASIC / 10);
        }
    }


    class GeneralManager:Manager
    {
        private string Perks;
        public string PERKS
        { 
            set 
            { 
                Perks = value;
            } 
            get 
            { 
                return Perks;
            }
        }

        public new decimal BASIC
        {
            set
            {
                if (value >= 20000 && value <= 39000)
                    Basic = value;
                else
                    Console.WriteLine("Invalid salary for General Manager");
            }

            get
            {
                return Basic;
            }
        }
        public GeneralManager(string NAME, short DEPTNO, decimal BASIC,string DESGN,string PERKS="NoPerks") : base(NAME,DEPTNO,DESGN)
        {
            this.PERKS = PERKS;
            this.BASIC = BASIC;
        }

        public override decimal CalcNetSalary()
        {
            return BASIC + (BASIC / 10);
        }
    }

    class CEO:Employee
    {

        public override decimal BASIC
        {
            set
            {
                if (value >= 61000 && value <= 100000)
                    Basic = value;
                else
                    Console.WriteLine("Invalid salary for CEO");
            }

            get
            {
                return Basic;
            }
        }

        public CEO(string NAME, short DEPTNO, decimal BASIC) : base(DEPTNO,NAME)
        {
            this.BASIC = BASIC;
        }

        public sealed override decimal CalcNetSalary()
        {
            return BASIC + (BASIC / 10);
        }
    }

}











