//    Filename: Form1.cs
// Description: Windows Form Application
//      Author: Drew Thomas 11419895
//        Date: 10/20/2015
//     History: Last modified 10/20 at 8:40
//      Extras: 1. Code is neatly typed and spaced
//              2. Code has well typed notes for easy following
//              3. Code has a picture that outputs at the beginning of the debugging
//              4. Code allows user to press button to display an Auburn Tiger
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thomasdy_EX4;

namespace Thomasdy_EX4
{
    public partial class Form1 : Form
    {
        //initialization of the employee object for population
        private Employee employeeData;
        public Form1()
        {

            InitializeComponent();
            
            employeeData=new Employee();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //This button saves the information to the Employee object
        private void Save_Click(object sender, EventArgs e)
        {
            //data that saves the ID of the employee
            string cuf = " ";
            cuf=IDBox.Text;
            int j=0;
            Int32.TryParse(cuf, out j);
            employeeData.Id=j;

            //code that takes in the name of the employee
            cuf = " ";
            cuf=NameBox.Text;
            employeeData.Name = cuf;

            //code that allows user entry for Start Date
            cuf = " ";
            cuf=StartDateBox.Text;
            DateTime i;
            DateTime.TryParse(cuf, out i);
            employeeData.StartDate=i;


            
            //code that allows entry for rate
            cuf = " ";
            cuf=RateBox.Text;
            double z;
            Double.TryParse(cuf, out z);
            employeeData.Rate=x;


            //Code that allows entry for how many hours a week this employee works
            cuf = " ";
            cuf=HoursBox.Text;
            double y;
            Double.TryParse(cuf, out y);
            employeeData.Hours=y;

        }
        

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void StartDateBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void RateBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void HoursBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        //This button displays all the information to text boxes adjacent to their other boxes
        private void Display_Click(object sender, EventArgs e)
        {
            OutputId.Text = employeeData.Id.ToString();
            OutputName.Text = employeeData.Name;
            OutputStartDate.Text = employeeData.StartDate.ToString();
            OutputRate.Text = employeeData.Rate.ToString();
            OutputHours.Text = employeeData.Hours.ToString();
        }



        //TextBox
        private void DisplayBox_TextChanged(object sender, EventArgs e)
        {

        }



        //This button clears the object, and all text boxes
        private void Clear_Click(object sender, EventArgs e)
        {
            //code that clears all boxes in the Windows form
            IDBox.Text = null;
            NameBox.Text = null;
            StartDateBox.Text = null;
            HoursBox.Text = null;
            RateBox.Text = null;
            OutputId.Text = null;
            OutputName.Text = null;
            OutputStartDate.Text = null;
            OutputRate.Text = null;
            OutputHours.Text = null;

            //Code that deletes all information that was within the EmployeeData object
            employeeData.Id = 0;
            employeeData.Name = " ";
            employeeData.StartDate = DateTime.MinValue;
            employeeData.Rate = 0;
            employeeData.Hours = 0;

        }
        


        //code that shows a picture of an aurburn tiger if the user chooses to
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = !pictureBox2.Visible;
        }


        //A picture is shown of the Tide
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
            
}

