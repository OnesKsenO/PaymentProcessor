using System;
// Concrete Strategy: Crypto Payment (Implements crypto payment logic)
// Konkreettinen strategia: Kryptomaksu (Toteuttaa kryptomaksun logiikan)
public class CryptoPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing crypto payment of {amount} €");
        // Add crypto-specific logic here
        // Lisää kryptomaksuihin liittyvä logiikka tähän
    }
}