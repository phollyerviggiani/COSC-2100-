/* 
IP2: Loan Report
Name: Patrick Hollyer-Viggiani
Student Number: 100910706
Date: October 20, 2024
Description: Create a program that showcases classes functionality and importing.
             This is done by generateing a loan form with caclulation, then displaying it
             to a textbox.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2100.IP2
{
    // Making loan class internal so it can only be used within the IP2 Folder
    internal class Loan
    {
        // Initalizing all variables
        internal int loanNumber;
        internal string customerName;
        internal string customerAddress;
        internal double loanAmount;
        internal double interestRate;
        internal int loanDuration;

        // Loan constructor initalizing all variables
        public Loan(int loanNumber, string customerName, string customerAddress, double loanAmount, double interestRate, int loanDuration)
        {
            // Validate the parameters
            if (loanNumber < 0)
                throw new ArgumentOutOfRangeException(nameof(loanNumber), "Loan number must be zero or positive.");
            if (string.IsNullOrWhiteSpace(customerName))
                throw new ArgumentNullException(nameof(customerName), "Customer name cannot be null or empty.");
            if (string.IsNullOrWhiteSpace(customerAddress))
                throw new ArgumentNullException(nameof(customerAddress), "Customer address cannot be null or empty.");
            if (loanAmount <= 0)
                throw new ArgumentOutOfRangeException(nameof(loanAmount), "Loan amount must be greater than zero.");
            if (interestRate < 0)
                throw new ArgumentOutOfRangeException(nameof(interestRate), "Interest rate cannot be negative.");
            if (loanDuration <= 0)
                throw new ArgumentOutOfRangeException(nameof(loanDuration), "Loan duration must be greater than zero.");

            // Assign values to fields
            this.loanNumber = loanNumber;
            this.customerName = customerName;
            this.customerAddress = customerAddress;
            this.loanAmount = loanAmount;
            this.interestRate = interestRate;
            this.loanDuration = loanDuration;
        }

        // CalculatePayment method that handles calculating the monthly payment
        public double CalculatePayment()
        {
            double monthlyInterestRate = interestRate / 100 / 12;
            int totalPayments = loanDuration * 12;

            double monthlyPayments = loanAmount * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, totalPayments)) /
                (Math.Pow(1 + monthlyInterestRate, totalPayments) - 1);

            return monthlyPayments;
        }

        // Generate statement report from the calculated information
        public string GenerateStatement()
        {
            // Assigning monthlyPayment to the calculatepayment method so it displays the proper value
            double monthlyPayment = CalculatePayment();

            // Return statement generating the report
            return "Loan Number: " + loanNumber + Environment.NewLine +
                   "Customer Name: " + customerName + Environment.NewLine +
                   "Customer Address: " + customerAddress + Environment.NewLine +
                   "Loan Amount: " + loanAmount.ToString("C") + Environment.NewLine +
                   "Interest Rate: " + interestRate + "%" + Environment.NewLine +
                   "Loan Duration: " + loanDuration + " years" + Environment.NewLine +
                   "Monthly Payment: " + monthlyPayment.ToString("C") + Environment.NewLine;
        }
    }
}
