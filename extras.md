# Extras -- Strategy Pattern Background Notes

This document contains some extra notes and background information
related to the Strategy Pattern example used in this project.

It is not strictly required for running the project, but it may help in
understanding the design pattern itself.

------------------------------------------------------------------------

## What the Strategy Pattern Means in Practice

The main idea behind the Strategy Pattern is fairly simple:

Instead of writing one large class that contains many conditional
branches for different behaviors, we separate those behaviors into their
own classes.

The program then chooses which one to use.

A simplified mental model could look like this:

    Processor -> Strategy Interface -> Concrete Strategy

Because the processor only depends on the interface, new strategies can
be added without modifying the processor itself.

This follows the **Open/Closed Principle**: software should be open for
extension but closed for modification.

------------------------------------------------------------------------

## Short History

The Strategy Pattern is one of the famous **Gang of Four design
patterns**.

The term comes from the book:

*Design Patterns: Elements of Reusable Object‑Oriented Software* (1994)

The authors were:

-   Erich Gamma\
-   Richard Helm\
-   Ralph Johnson\
-   John Vlissides

The book introduced a standardized way to describe common design
solutions in object‑oriented software development. Many of those
patterns are still widely taught today.

------------------------------------------------------------------------

## Typical Situations Where Strategy Is Useful

Strategy is helpful whenever a program has **multiple ways of performing
the same task**.

A few common examples:

### Payment systems

Different payment providers can be implemented as strategies.

Examples:

-   credit card
-   PayPal
-   crypto

### Navigation software

Route calculation could have different strategies:

-   fastest route
-   shortest route
-   eco route

### Games

A game character might have different attack strategies:

-   melee attack
-   ranged attack
-   magic attack

The selected strategy depends on the current situation or player choice.

------------------------------------------------------------------------

## Strategy vs Some Other Patterns

Sometimes Strategy is confused with similar patterns.

For example:

**Strategy vs State**

-   Strategy: the client chooses which algorithm to use.
-   State: the object changes behavior based on its internal state.

They can look similar structurally but their purpose is different.

------------------------------------------------------------------------

## Final Thoughts

The Strategy Pattern is one of the simpler design patterns conceptually,
but it is very practical.

Even small programs can benefit from separating behaviors into
independent classes. It usually makes the code easier to extend later.

In this project the pattern is intentionally implemented in a
straightforward way so the structure is easy to see.
