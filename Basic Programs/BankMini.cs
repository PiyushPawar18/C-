using System;

class Banker
{
    public void Bankers(Customer[] customers)
    {
        bool exitBanker = true;
        while (exitBanker)
        {
            System.Console.WriteLine("\n1. Add New Customer Account");
            System.Console.WriteLine("2. Delete Existing Customer Account");
            System.Console.WriteLine("3. Check Customer Details");
            System.Console.WriteLine("4. Display All Customers");
            System.Console.WriteLine("5. Exit [ Banker ]");
            System.Console.Write("Select an option: ");
            int option = int.Parse(System.Console.ReadLine());
            switch (option)
            {
                case 1:
                    AddNewCustomer(customers);
                    break;
                case 2:
                    DeleteCustomer(customers);
                    break;
                case 3:
                    CheckCustomerDetails(customers);
                    break;
                case 4:
                    DisplayAllCustomers(customers);
                    break;
                case 5:
                    exitBanker = false;
                    break;
                default:
                    System.Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    public static Customer FindCustomer(Customer[] customers, int accountNumber)
    {
        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i].AccountNumber == accountNumber)
            {
                return customers[i];
            }
        }
        return null;
    }

    public static void AddNewCustomer(Customer[] customers)
    {
        for (int i = 0; i <= customers.Length; i++)
        {
            int pp=1;
            if (customers[i].AccountNumber == 0)
            {
                System.Console.Write("Enter Account Number: ");
                customers[i].AccountNumber = int.Parse(System.Console.ReadLine());
                for(int j=1;j<i;j++)
                {
                    if(customers[i].AccountNumber == customers[j].AccountNumber)
                    {
                        pp=2;
                        System.Console.WriteLine("This Account No is Already Exist ..\nTry Again");
                        break;
                    }
                }
                if(pp==2)
                {
                    break;
                }
                System.Console.Write("Enter Customer Name: ");
                customers[i].Name = System.Console.ReadLine();
                System.Console.Write("Enter Initial Balance : ");
                customers[i].Balance = double.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Customer account added successfully.");
                break;
            }
            
        }
    }

    public static void DeleteCustomer(Customer[] customers)
    {
        System.Console.Write("Enter Account Number to Delete: ");
        int accountNumber = int.Parse(System.Console.ReadLine());

        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i].AccountNumber == accountNumber)
            {
                customers[i] = new Customer(); // Reset the customer data.
                System.Console.WriteLine("Customer account deleted successfully.");
                return;
            }
        }
        System.Console.WriteLine("Customer not found.");
    }

    public static void CheckCustomerDetails(Customer[] customers)
    {
        System.Console.Write("Enter Account Number: ");
        int accountNumber = int.Parse(System.Console.ReadLine());
        Customer customer = FindCustomer(customers, accountNumber);

        if (customer != null)
        {
            System.Console.WriteLine("Account Number: {0}", customer.AccountNumber);
            System.Console.WriteLine("Name: {0}", customer.Name);
            System.Console.WriteLine("Balance: {0}", customer.Balance);
        }
        else
        {
            System.Console.WriteLine("Customer not found.");
        }
    }

    public static void DisplayAllCustomers(Customer[] customers)
    {
        System.Console.WriteLine("All Customer Information:");
        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i].AccountNumber != 0)
            {
                System.Console.WriteLine("Account Number: {0}", customers[i].AccountNumber);
                System.Console.WriteLine("Name: {0}", customers[i].Name);
                System.Console.WriteLine("Balance: {0}", customers[i].Balance);
                System.Console.WriteLine();
            }
        }
    }
}

class Customer
{
    public int AccountNumber;
    public string Name;
    public double Balance;

    public Customer()
    {
        AccountNumber = 0;
        Name = "";
        Balance = 0;
    }
}

class CustomerMain
{
    public void Customers(Customer[] customers)
    {
        System.Console.Write("Enter Account Number: ");
        int accountNumber = int.Parse(System.Console.ReadLine());
        Customer customer = Banker.FindCustomer(customers, accountNumber); // Corrected method call

        if (customer != null)
        {
            bool exitCustomer = false;
            while (!exitCustomer)
            {
                System.Console.WriteLine("\n1. Deposit Money");
                System.Console.WriteLine("2. Withdraw Money");
                System.Console.WriteLine("3. Check Balance");
                System.Console.WriteLine("4. Exit Customer Mode");
                System.Console.Write("Select an option: ");
                int option = int.Parse(System.Console.ReadLine());

                switch (option)
                {
                    case 1:
                        DepositMoney(customer);
                        break;
                    case 2:
                        WithdrawMoney(customer);
                        break;
                    case 3:
                        CheckBalance(customer);
                        break;
                    case 4:
                        exitCustomer = true;
                        break;
                    default:
                        System.Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
        else
        {
            System.Console.WriteLine("Customer not found.");
        }
    }

    public static void DepositMoney(Customer customer)
    {
        System.Console.Write("Enter Amount to Deposit: ");
        double amount = double.Parse(System.Console.ReadLine());
        customer.Balance += amount;
        System.Console.WriteLine("Amount deposited successfully.");
    }

    public static void WithdrawMoney(Customer customer)
    {
        System.Console.Write("Enter Amount to Withdraw: ");
        double amount = double.Parse(System.Console.ReadLine());

        if (amount <= customer.Balance)
        {
            customer.Balance -= amount;
            System.Console.WriteLine("Amount withdrawn successfully.");
        }
        else
        {
            System.Console.WriteLine("Insufficient balance.");
        }
    }

    public static void CheckBalance(Customer customer)
    {
        System.Console.WriteLine("Current Balance: {0}", customer.Balance);
    }
}

class BankMini
{
    public static void Main(string[] args)
    {
        Banker bk = new Banker();
        CustomerMain cr = new CustomerMain();
        Customer[] customers = new Customer[10];
        InitializeCustomers(customers);

        do
        {
            System.Console.WriteLine("\n1. Banker");
            System.Console.WriteLine("2. Customer");
            System.Console.WriteLine("3. Exit");
            System.Console.Write("Enter your choice (1|2): ");
            int choice1 = int.Parse(System.Console.ReadLine());
            if (choice1 == 1)
            {
                bk.Bankers(customers);
            }
            else if (choice1 == 2)
            {
                cr.Customers(customers);
            }
            else if (choice1 == 3)
            {
                Environment.Exit(0);
            }
            else
            {
                System.Console.WriteLine("Please Enter a valid choice ...");
            }
        } while (true);
    }

    public static void InitializeCustomers(Customer[] customers)
    {
        for (int i = 0; i < customers.Length; i++)
        {
            customers[i] = new Customer();
        }
    }
}
