# Strategy Pattern Implementation in C#

## Overview
This project demonstrates the **Strategy Pattern**, a behavioral design pattern that enables selecting an algorithm's behavior at runtime. The example focuses on a **Payment Processing System** where different payment methods (Credit Card, PayPal, Crypto) can be dynamically selected.

## Project Structure

```
PaymentProcessor/
├── IPaymentStrategy.cs      # Strategy Interface
├── CreditCardPayment.cs    # Concrete Strategy: Credit Card
├── PayPalPayment.cs        # Concrete Strategy: PayPal
├── CryptoPayment.cs        # Concrete Strategy: Crypto
├── PaymentProcessor.cs     # Context Class
└── Program.cs              # Client Code
```

## Key Components

### 1. Strategy Interface (`IPaymentStrategy`)
- Defines the common interface for all payment strategies.
- Ensures that all concrete strategies implement the `ProcessPayment` method.

### 2. Concrete Strategies
- **CreditCardPayment**: Implements payment logic for credit card transactions.
- **PayPalPayment**: Implements payment logic for PayPal transactions.
- **CryptoPayment**: Implements payment logic for cryptocurrency transactions.

### 3. Context Class (`PaymentProcessor`)
- Holds a reference to a strategy object.
- Delegates the payment processing to the selected strategy.
- Allows dynamic switching of strategies at runtime.

### 4. Client Code (`Program`)
- Demonstrates how to use the Strategy Pattern.
- Shows dynamic switching between different payment methods.

## How to Run

1. **Compile the Code**:
   ```bash
   csc Program.cs PaymentProcessor.cs CreditCardPayment.cs PayPalPayment.cs CryptoPayment.cs IPaymentStrategy.cs
   ```

2. **Run the Executable**:
   ```bash
   ./Program.exe
   ```

## Expected Output

```
Processing credit card payment of $100.00
Processing PayPal payment of $50.00
Processing crypto payment of $200.00
```

## Benefits of the Strategy Pattern

- **Flexibility**: Easily add new payment methods without modifying existing code.
- **Maintainability**: Each payment method is encapsulated in its own class.
- **Runtime Switching**: Change payment methods dynamically during execution.

## Finnish Explanation (Suomenkielinen selitys)

### Strategiakuvio
Strategiakuvio on käyttäytymiseen liittyvä suunnittelumalli, joka mahdollistaa algoritmin valinnan suorituksen aikana. Tämä esimerkki keskittyy **maksujärjestelmään**, jossa eri maksutavat (luottokortti, PayPal, kryptovaluutta) voidaan valita dynaamisesti.

### Tärkeimmät osat

1. **Strategia-rajapinta (`IPaymentStrategy`)**
   - Määrittelee yhteisen rajapinnan kaikille maksustrategioille.
   - Varmistaa, että kaikki konkreettiset strategiat toteuttavat `ProcessPayment`-metodin.

2. **Konkreettiset strategiat**
   - **CreditCardPayment**: Toteuttaa luottokorttimaksun logiikan.
   - **PayPalPayment**: Toteuttaa PayPal-maksun logiikan.
   - **CryptoPayment**: Toteuttaa kryptomaksun logiikan.

3. **Kontekstiluokka (`PaymentProcessor`)**
   - Pitää sisällään viitteen strategiaolioon.
   - Delegoi maksun käsittelyn valitulle strategialle.
   - Mahdollistaa strategian vaihtamisen suorituksen aikana.

4. **Asiakaskoodi (`Program`)**
   - Näyttää, miten strategiakuviota käytetään.
   - Esittelee dynaamisen vaihtamisen eri maksutapojen välillä.

### Hyödyt

- **Joustavuus**: Uusia maksutapoja on helppo lisätä ilman, että olemassa olevaa koodia tarvitsee muuttaa.
- **Ylläpidettävyys**: Jokainen maksutapa on kapseloitu omaan luokkaansa.
- **Dynaaminen vaihtaminen**: Maksutapoja voidaan vaihtaa suorituksen aikana.

## License

This project is licensed under the MIT License. Feel free to use and modify it for educational purposes.
