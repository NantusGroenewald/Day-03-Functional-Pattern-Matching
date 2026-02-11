User user = new("Nantus", false, 0);
Order order = new(500, false);
DayOfWeek day = DayOfWeek.Tuesday;

decimal discount = CalculateDiscount(user, order, day);
Console.WriteLine($"Discount: {discount * 100}%");

// TODO: Implement this using a Switch Expression!
decimal CalculateDiscount(User u, Order o, DayOfWeek d)
{
    // HINT: You can switch on a "Tuple" of all three inputs
    return (u, o, d) switch
    {
        ({ Name: "Nantus" }, _, _) => 0.20m,
        ({ IsVip: true, MembershipYears: > 5 }, _, _) => 0.15m,
        (_, {IsGroceries: false},DayOfWeek.Tuesday) => 0.10m, 
        (_, { TotalAmount: > 1000 }, _) => 0.05m,
        ({IsVip: true}, _ , _) or (_, {TotalAmount: > 500 }, _) => 0.02m,

        // Default
        _ => 0.0m
    };
}


public record User(string Name, bool IsVip, int MembershipYears);
public record Order(decimal TotalAmount, bool IsGroceries);