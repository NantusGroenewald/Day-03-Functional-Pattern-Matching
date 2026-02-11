# Day 3: Functional C# & Pattern Matching

## 🎯 Learning Objectives
- Master **Records** for immutable data modeling.
- Replace verbose `if/else` chains with **Switch Expressions**.
- Use **Property Patterns** (`{ IsVip: true }`), **Logical Patterns** (`and`, `or`, `not`), and **Tuple Patterns** `(x, y)`.

## 📝 The Challenge: "Smart Pricing Engine"
**Goal:** Calculate a discount percentage based on User, Order, and Time data without using `if` statements.

**Rules:**
1. **Name Match:** "Nantus" -> 20%
2. **Loyalty:** VIP & > 5 Years -> 15%
3. **Daily Special:** Tuesday & Not Groceries -> 10%
4. **Volume:** Total > 1000 -> 5%
5. **Default:** 0%

## 🧠 Key Concepts
- **Records:** `public record User(string Name, bool IsVip, int Years);`
- **Pattern Matching:**
  ```csharp
  return input switch
  {
      { Name: "Nantus" } => 0.20m,
      { IsVip: true, Years: > 5 } => 0.15m,
      _ => 0m
  };

#### 5. 🧠 Explanation & Starter Code

Here is how to set up your `PricingEngine` class to get you started.

**Step 1: Define your Data (Records)**
```csharp
// Place these at the bottom of Program.cs or in separate files
public record User(string Name, bool IsVip, int MembershipYears);
public record Order(decimal TotalAmount, bool IsGroceries);