# Strategy Pattern -- C# Example

## Overview

This small project demonstrates the **Strategy Pattern**, which is one
of the classic object‑oriented design patterns.\
The idea behind the pattern is that different algorithms or behaviors
can be encapsulated in separate classes and then selected dynamically at
runtime.

In this example the pattern is used to implement a **simple payment
processing system**.\
Different payment methods (credit card, PayPal and crypto) are
implemented as separate strategy classes. The main processor class
simply uses whichever strategy has been selected.

The goal of the project is mainly educational: to show how the pattern
works in practice in a clear and simple way.

------------------------------------------------------------------------

## Project Structure

    PaymentProcessor/
    ├── IPaymentStrategy.cs
    ├── CreditCardPayment.cs
    ├── PayPalPayment.cs
    ├── CryptoPayment.cs
    ├── PaymentProcessor.cs
    └── Program.cs

**Short description of the files:**

-   **IPaymentStrategy.cs** -- Interface that defines the common method
    used by all strategies.
-   **CreditCardPayment.cs** -- Strategy implementation for credit card
    payments.
-   **PayPalPayment.cs** -- Strategy implementation for PayPal payments.
-   **CryptoPayment.cs** -- Strategy implementation for cryptocurrency
    payments.
-   **PaymentProcessor.cs** -- The context class that uses a selected
    strategy.
-   **Program.cs** -- Example program that demonstrates how strategies
    are switched.

------------------------------------------------------------------------

## How the Strategy Pattern Appears in This Project

### Strategy Interface

`IPaymentStrategy` defines the method that every payment strategy must
implement.

``` csharp
void ProcessPayment(double amount);
```

This allows the processor to use any payment method through the same
interface.

### Concrete Strategies

Each payment type is implemented as its own class:

-   `CreditCardPayment`
-   `PayPalPayment`
-   `CryptoPayment`

Each class implements the `IPaymentStrategy` interface and provides its
own version of `ProcessPayment()`.

### Context Class

It stores a reference to a strategy object and calls it when a payment
needs to be processed.\
Because the processor only knows about the interface, the actual
implementation can be swapped at runtime.

### Client Code

The `Program` class demonstrates how the strategies are used.\
It creates the processor and changes the strategy before executing
different payments.

------------------------------------------------------------------------

## Running the Program

### Option A -- Using VS Code / .NET CLI

    dotnet run

### Option B -- Compile Manually

Compile the files:

    csc Program.cs PaymentProcessor.cs CreditCardPayment.cs PayPalPayment.cs CryptoPayment.cs IPaymentStrategy.cs

Run the program:

    ./Program.exe

------------------------------------------------------------------------

## Expected Output

    Processing credit card payment of $100.00
    Processing PayPal payment of $50.00
    Processing crypto payment of $200.00

------------------------------------------------------------------------

## Why Use the Strategy Pattern?

Some advantages of this design pattern:

**Flexibility**\
New payment methods can be added by simply creating another strategy
class.

**Maintainability**\
Each payment method has its own class, which keeps the code easier to
read and maintain.

**Runtime switching**\
The strategy can be changed while the program is running.

------------------------------------------------------------------------

## Short Finnish Explanation

Strategiakuvio on olio‑ohjelmoinnin suunnittelumalli, jossa erilaiset
toteutukset kapseloidaan erillisiin luokkiin ja niitä käytetään yhteisen
rajapinnan kautta.

Tässä projektissa maksutavat toimivat strategioina.\
`PaymentProcessor` ei tiedä tarkalleen miten maksut käsitellään -- se
vain kutsuu rajapinnan metodia. Näin maksutapaa voidaan vaihtaa helposti
ohjelman aikana.

------------------------------------------------------------------------

## License

This project uses the **MIT License** and is mainly intended for
educational use.
