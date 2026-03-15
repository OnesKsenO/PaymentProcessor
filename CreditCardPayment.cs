using System;
// Concrete Strategy: Credit Card Payment (Implements credit card payment logic)
// Konkreettinen strategia: Luottokorttimaksu (Toteuttaa luottokorttimaksun logiikan)
public class CreditCardPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount} €");
        // Add Credit Card specific logic here
        // Lisää luottokortteihin liittyvä logiikka tähän
    }
}