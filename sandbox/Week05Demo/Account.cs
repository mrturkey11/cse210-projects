public class Account
{
    public List<double> _transactions = new List<double>();

    public void Deposit(double amount)
    {
        if (amount > 0)
            _transactions.Add(amount);
        else
            Console.WriteLine("Error, deposit must be positive");
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount < _balance)
            _transactions.Add(-amount);
        else
            Console.WriteLine("Error, cannot withdraw more than the balance");
    }
    public double GetBalance()
    {
        return _transactions.Sum();
    }
}