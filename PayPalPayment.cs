using System;
// Concrete Strategy: PayPal Payment (Implements PayPal payment logic)
// Konkreettinen strategia: PayPal-maksu (Toteuttaa PayPal-maksun logiikan)
public class PayPalPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount} €");
        // Add PayPal-specific logic here
        // Lisää PayPaliin liittyvä logiikka tähän
    }
}