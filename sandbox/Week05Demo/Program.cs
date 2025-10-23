using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Account acct = new Account();
        acct.Deposit(5000); // Initial balance $5000
        acct.Deposit(1000); // Paycheck
        acct.Withdraw(25); // Paycheck
        acct.Withdraw(100); // Groceries
        acct.Deposit(-1000); // Paycheck

        Console.WriteLine($"Your balance is ${acct.GetBalance()}");
    }
}