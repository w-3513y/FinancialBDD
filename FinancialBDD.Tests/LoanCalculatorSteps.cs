using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace FinancialBDD.Tests
{
    [Binding]
    internal class LoanCalculatorSteps
    {
        private double _loan;
        private double _interesRate;
        private int _months;
        private double _paymentLoan;

        [Given(@"that the loan amount was (.*) monetary values")]
        public void InitialLoan(double loan)
        {
            _loan = loan;
        }

        [Given("an interest rate of (.*) % has been set")]
        public void InterestRate(double interestRate)
        {
            _interesRate = interestRate;
        }

        [Given("in a period of (.*) months")]
        public void PeriodPayment(int months)
        {
            _months = months;
        }

        [When("I calculate the payment amount")]
        public void CalculateAmount()
        {
            _paymentLoan = LoanPayment.Payment(_loan, _months, _interesRate);
        }

        [Then("the loan payment should be (.*) monetary values")]
        public void PaymentLoan(double paymentLoan)
        {
            Assert.AreEqual(paymentLoan, _paymentLoan);
        }

    }


}