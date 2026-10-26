//SAMPLE CODE 
Console.WriteLine("=== Expense Tracker ===");

Console.Write("Enter expense name: ");
string expenseName = Console.ReadLine()!;

Console.Write("Enter expense amount: ");
decimal amount = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("\n--- Expense Details ---");
Console.WriteLine($"Expense: {expenseName}");
Console.WriteLine($"Amount: Rs. {amount}");