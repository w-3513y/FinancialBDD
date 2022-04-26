namespace FinancialBDD;

public static class LoanPayment
{
    public static double Payment(
        double loan,
        double months,
        double interesRate)
        => Math.Round(loan * Math.Pow(1 + interesRate / 100, months), 2);

}
