//    Filename: Employee.cs
// Description: Program 
//      Author: Drew Thomas 11419895
//        Date: 10/20/2015
//     History: Last modified 10/20 at 8:40
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thomasdy_EX4
{
    public class Employee
    {
        //All code past here is copied straight from Ed Hassler's Code
        private int id;
        private string name;
        private DateTime startDate;
        private double rate;
        private double hours;

        // Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        //initializing name of employee
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        //intializing start date
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }


        //intializing Rate for Employee
        public double Rate
        {
            get { return rate; }
            set {  rate = value;}
        }


        //initializing hours for employee
        public double Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        // Constructors
        public Employee()
        {
            id = 1234;
            name = "John Doe";
            startDate = DateTime.Now;
            rate = 7.25;
            hours = 0;
        }

        //another constructor
        public Employee(int id, string name, DateTime hireDate, double rate, double hours)
        {
            this.Id = id;
            this.Name = name;
            this.StartDate = hireDate;
            this.Rate = rate;
            this.Hours = hours;
        }

        // Work methods
        //this code was not used since it was not required
        public double CalcPay()
        {
            return rate * hours;
        }

        //This code is not used since it was not required
        public int GetTenure()
        {
            // Get today's date
            DateTime currDate = DateTime.Now;

            // Get the difference in years
            int years = currDate.Year - startDate.Year;

            // Subtract another year if we're before the
            // start date in the current year
            if (currDate.Month < startDate.Month || (currDate.Month == startDate.Month && currDate.Day < startDate.Day))
                years--;

            return years;
        }
        
    }
}


