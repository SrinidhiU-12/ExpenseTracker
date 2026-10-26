//SAMPLE CODE 
Console.WriteLine("=== Expense Tracker ===");

Console.Write("Enter expense name: ");
string expenseName = Console.ReadLine()!;

Console.Write("Enter expense amount: ");
decimal amount = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("\n--- Expense Details ---");
Console.WriteLine($"Expense: {expenseName}");
Console.WriteLine($"Amount: Rs. {amount}");

Console.WriteLine("Category: Groceries");
Console.WriteLine("Temporary change for stash practice"); Console.WriteLine("Payment feature added");
Console.WriteLine("Master update for rebase"); Console.WriteLine("ExpenseTracker project updated");