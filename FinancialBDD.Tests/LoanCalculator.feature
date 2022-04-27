Feature: LoanCalculator

A short summary of the feature

@Brazil
Scenario: TotalLoanPayment_1
 Given that the loan amount was 10000 monetary values
 And an interest rate of 2 % has been set
 And in a period of 12 months
 When I calculate the payment amount
 Then the loan payment should be 12682.42 monetary values

@Brazil
Scenario: TotalLoanPayment_2
 Given that the loan amount was 11937.28 monetary values
 And an interest rate of 4 % has been set
 And in a period of 24 months
 When I calculate the payment amount
 Then the loan payment should be 30598.88 monetary values

@Brazil
Scenario: TotalLoanPayment_3
 Given that the loan amount was 15000 monetary values
 And an interest rate of 6 % has been set
 And in a period of 36 months
 When I calculate the payment amount
 Then the loan payment should be 122208.78 monetary values