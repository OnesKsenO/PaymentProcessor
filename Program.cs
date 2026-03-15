using System;
// Client Code: Demonstrates the Strategy Pattern (English: Shows how to use the pattern)
// Asiakaskoodi: Esittelee strategiakuvion (Suomi: Näyttää, miten kuviota käytetään)
class Program
{
    static void Main()
    {
        // Create the context (Initialize the payment processor)
        // Luo konteksti (Alusta maksuprosessori)
        PaymentProcessor processor = new PaymentProcessor();

        // Set the strategy to Credit Card (Use credit card payment)
        // Aseta strategia luottokortiksi (Käytä luottokorttimaksua)
        processor.SetPaymentStrategy(new CreditCardPayment());
        processor.ExecutePayment(100.00m); // Output: Processing credit card payment of 100.00€

        // Change the strategy to PayPal (Switch to PayPal payment)
        // Vaihda strategia PayPaliin (Vaihda PayPal-maksuun)
        processor.SetPaymentStrategy(new PayPalPayment());
        processor.ExecutePayment(50.00m); // Output: Processing PayPal payment of 50.00€

        // Change the strategy to Crypto (Switch to crypto payment)
        // Vaihda strategia kryptomaksuun (Vaihda kryptomaksuun)
        processor.SetPaymentStrategy(new CryptoPayment());
        processor.ExecutePayment(200.00m); // Output: Processing crypto payment of 200.00€
    }
}