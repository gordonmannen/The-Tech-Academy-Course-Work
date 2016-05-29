class Account
{
    public void balance()
    {
        System.Console.WriteLine("Account::balance");
    }
}

class Amount : Account
{
    new public void balance()
    {
        System.Console.WriteLine("Amount::balance");
    }
}

class OverrideTest
{
    public static void Main()
    {
        Account x;
        x = new Account();
        x.balance();
    }
}

