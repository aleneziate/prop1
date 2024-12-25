using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prop1.Model
{
    internal class username
    {
        private string usrName;
        public string UName
        {
            get
            {
                return usrName;
            }

            set
            {
                if (value != null)
                {
                    usrName = value;
                }
                else Console.WriteLine("invalid username ");
            }
        }
        private double salary;
        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                if (value >= 350 && value <= 900)
                {
                    salary = value;
                }
                else Console.WriteLine("out of range ");
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Username: {usrName} | Salary: {salary}");
        }
    }
}

