using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingEmployee_Payrol
{
    class EmployeePayRollUsingThread
    {
        public List<EmployeeDetails> employeeDetailsList = new List<EmployeeDetails>();
        public void addEmployeeToPayroll(List<EmployeeDetails> employeeDetailsList)
        {
            employeeDetailsList.ForEach(employeeData =>
            {
                Console.WriteLine(" Employee being added: " + employeeData.EmployeeName);
                this.addEmployeePayroll(employeeData);
                Console.WriteLine(" Employee added: " + employeeData.EmployeeName);
            });
            Console.WriteLine(this.employeeDetailsList.ToString());
        }
        public void addEmployeeToPayrollWithThread(List<EmployeeDetails> employeeDetailsList)
        {
            employeeDetailsList.ForEach(employeeData =>
            {
                // here One Thread is created by using new keyword with "Task" class
                Task thread = new Task(() =>
                {
                    Console.WriteLine(" Employee being added: " + employeeData.EmployeeName);
                    this.addEmployeePayroll(employeeData);
                    Console.WriteLine(" Employee added: " + employeeData.EmployeeName);
                });
                thread.Start(); //here Threa will be start for the execution
            });
            Console.WriteLine(this.employeeDetailsList.Count());
        }

        public void addEmployeePayroll(EmployeeDetails emp)
        {
            employeeDetailsList.Add(emp);
        }
    }
}
