
public class Program
{
    static double CalculateTotal(double price, int quantity) // calculates total price
    {
        double total = price * quantity;
        return total; // returns the total to Main
    }

    static double ApplyDiscount(double total, double discount) // calculates discounted price
    {
        double discountAmount = total * discount;
        double finalPrice = total - discountAmount;
        return finalPrice; // returns final price
    }

    public static void Main() // program starts here
    {
        // Question 1
        double returned_total = 0.0;
        returned_total = CalculateTotal(6.50, 4); // price and quantity

        Console.WriteLine($"{returned_total:F2}"); // F2 displays 2 decimal places

        // Question 2
        double returned_price = 0.0;
        returned_price = ApplyDiscount(returned_total, 0.15); // applies 15% discount

        Console.WriteLine($"{returned_price:F2}"); // prints discounted price
    }
}

