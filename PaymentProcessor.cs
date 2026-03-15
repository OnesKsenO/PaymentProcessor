using System;
// Context Class: Uses the strategy (Holds and executes the payment strategy)
// Kontekstiluokka: Käyttää strategiaa (Pitää sisällään ja suorittaa maksustrategian)
public class PaymentProcessor
{
    private IPaymentStrategy _paymentStrategy;

    // Set the strategy at runtime (Allows changing the payment method dynamically)
    // Aseta strategia suorituksen aikana (Mahdollistaa maksutavan vaihtamisen dynaamisesti)
    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    // Execute the strategy (Calls the selected payment method)
    // Suorita strategia (Kutsuu valittua maksutapaa)
    public void ExecutePayment(decimal amount)
    {
        _paymentStrategy.ProcessPayment(amount);
    }
}