using System;

public class BankAccount
{
  private string accountNumber;
  private string name;
  private decimal balance;

  public BankAccount(string accountNumber, string name, decimal initialBalance)
  {
    this.accountNumber = accountNumber;
    this.name = name;
    this.balance = initialBalance;
  }

  public bool Deposit(decimal amount)
  {
    if (amount > 0)
    {
      balance += amount;
      Console.WriteLine("Deposit of {amount:C} successful. New balance: {balance:C}");
      return true;
    }
    else
    {
      Console.WriteLine("Deposit amount must be positive.");
      return false;
    }
  }

  public bool Withdraw(decimal amount)
  {
    if (amount > 0 && amount <= balance)
    {
      balance -= amount;
      Console.WriteLine("Withdrawal of {amount:C} successful. New balance: {balance:C}");
      return true;
    }
    else if (amount <= 0)
    {
      Console.WriteLine("Withdrawal amount must be positive.");
      return false;
    }
    else
    {
      Console.WriteLine("Insufficient funds.");
      return false;
    }
  }

  public void ShowBalance()
  {
    Console.WriteLine("Account Number: {0}",accountNumber);
    Console.WriteLine("Account Name: {0}",name);
    Console.WriteLine("Balance: {0}",balance);
  }
}

public class Bank
{
  public static void Main(string[] args)
  {
    string accountNumber, name;
    decimal initialBalance, amount;
    int choice;

    Console.WriteLine("Welcome to Simple Bank!");

    Console.Write("Enter your account number: ");
    accountNumber = Console.ReadLine();

    Console.Write("Enter your name: ");
    name = Console.ReadLine();

    Console.Write("Enter initial balance: ");
    initialBalance = decimal.Parse(Console.ReadLine());

    BankAccount account = new BankAccount(accountNumber, name, initialBalance);

    do
    {
      Console.WriteLine("\nMenu:");
      Console.WriteLine("1. Check Balance");
      Console.WriteLine("2. Deposit");
      Console.WriteLine("3. Withdraw");
      Console.WriteLine("4. Exit");
      Console.Write("Enter your choice: ");
      choice = int.Parse(Console.ReadLine());

      switch (choice)
      {
        case 1:
          account.ShowBalance();
          break;
        case 2:
          Console.Write("Enter amount to deposit: ");
          amount = decimal.Parse(Console.ReadLine());
          account.Deposit(amount);
          break;
        case 3:
          Console.Write("Enter amount to withdraw: ");
          amount = decimal.Parse(Console.ReadLine());
          account.Withdraw(amount);
          break;
        case 4:
          Console.WriteLine("Thank you for using Simple Bank!");
          break;
        default:
          Console.WriteLine("Invalid choice.");
          break;
      }
    } while (choice != 4);
  }
}