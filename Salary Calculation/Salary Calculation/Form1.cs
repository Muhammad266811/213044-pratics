using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            private void btnCalculateSalary_Click(object sender, EventArgs e)
            {
                // Retrieve selected values from the form controls
                string employeeName = txtEmployeeName.Text;
                string grade = cmbGradeLevel.SelectedItem.ToString();
                int basicSalary = 0;
                int benefitsTotal = 0;
                int bonusesTotal = 0;

                // Determine the basic salary based on the grade
                if (grade == "Director")
                    basicSalary = 100000;
                else if (grade == "Manager")
                    basicSalary = 50000;
                else if (grade == "Project Manager")
                    basicSalary = 40000;
                else if (grade == "Programmer")
                    basicSalary = 30000;

                // Calculate benefits total
                if (chkHousingAllowance.Checked)
                    benefitsTotal += 20000;
                if (chkConveyanceAllowance.Checked)
                    benefitsTotal += 15000;
                if (chkOtherBenefit1.Checked)
                    benefitsTotal += 10000;
                if (chkOtherBenefit2.Checked)
                    benefitsTotal += 10000;

                // Calculate bonuses total
                foreach (var item in clbBonuses.CheckedItems)
                {
                    string bonus = item.ToString();
                    if (bonus == "Project Completion Bonus")
                        bonusesTotal += 20000;
                    else if (bonus == "Year End Bonus")
                        bonusesTotal += 30000;
                    else if (bonus == "Performance Bonus")
                        bonusesTotal += 25000;
                    else if (bonus == "Customer appreciation Bonus")
                        bonusesTotal += 15000;
                }

                // Calculate the total salary
                int deductions = string.IsNullOrEmpty(txtDeductions.Text) ? 0 : int.Parse(txtDeductions.Text);
                int totalSalary = basicSalary + benefitsTotal + bonusesTotal - deductions;

                // Display the result
                MessageBox.Show($"Employee Name: {employeeName}\nGrade: {grade}\nTotal Salary: {totalSalary}");
            }

        }
    }
}
