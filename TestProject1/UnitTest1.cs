using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MultiThreadingEmployee_Payrol;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "vishal", PhoneNumber: 123456789, Address: "pusad", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435)); ;
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 2, EmployeeName: "Rakesh", PhoneNumber: 123456789, Address: "washim", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 3, EmployeeName: "Amir", PhoneNumber: 123456789, Address: "mumbai", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 4, EmployeeName: "Rajesh", PhoneNumber: 123456789, Address: "Pune", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 5, EmployeeName: "Ramesh", PhoneNumber: 123456789, Address: "Mumbai", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435)); ;

            EmployeePayRollUsingThread employeePayrollUsingThreads = new EmployeePayRollUsingThread();
            DateTime startDateTime = DateTime.Now;
            employeePayrollUsingThreads.addEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));

            DateTime startDateTimeThread = DateTime.Now;
            employeePayrollUsingThreads.addEmployeeToPayrollWithThread(employeeDetails);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with thread: " + (stopDateTimeThread - startDateTimeThread));
        }
    }
}
