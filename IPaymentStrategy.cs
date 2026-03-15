using System;
// Strategy Interface (Defines the common interface for all payment strategies)
// Strategia-rajapinta (Määrittelee yhteisen rajapinnan kaikille maksustrategioille)
public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
}