using System;
using System.Collections.Generic;

namespace MultiThreadingEmployee_Payrol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeDetails> employeeDetailsList1 = new List<EmployeeDetails>();

            Console.WriteLine("Welcome to MultiThreading Employee_Payrol..!");

            EmployeePayRollUsingThread employeePayRollUsingThread=new EmployeePayRollUsingThread();
            employeePayRollUsingThread.addEmployeeToPayroll(employeeDetailsList1);

            employeePayRollUsingThread.addEmployeeToPayrollWithThread(employeeDetailsList1);
        }
    }
}
