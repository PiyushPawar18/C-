class MoneyConDemo
{
    public void MoneyConMethod()
    {
        System.Console.Write("Enter a indian rs := ");
        float rs=float.Parse(System.Console.ReadLine());
        System.Console.WriteLine("\n1.US (dollar) \n2.Japanese (yen) \n3.China (yuan) \n4.Pakistan (pakistani rupee[PKR]) \n5.Russia (russian Ruble [RUB]) \n6.Bangladeshi (Taka)");
        System.Console.Write("Enter a your choices := ");
        int choice = int.Parse(System.Console.ReadLine());
        float ans;
        switch(choice)
        {
            case 1:
                ans=rs/83.77f;
                System.Console.WriteLine(ans + " Dollar");
                break;
            case 2:
                ans=rs/0.57f;
                System.Console.WriteLine(ans + " Yen");
                break;
            case 3:
                ans=rs/11.70f;
                System.Console.WriteLine(ans + " Yuan");
                break;
            case 4:
                ans=rs/0.30f;
                System.Console.WriteLine(ans + " PKR");
                break;
            case 5:
                ans=rs/0.99f;
                System.Console.WriteLine(ans + " RUB");
                break;
            case 6:
                ans=rs/0.72f;
                System.Console.WriteLine(ans + " Taka");
                break;
            default :
                System.Console.WriteLine("Invalid Choice ....!");
                break;

        }
    }
}
class Money2A2
{
    public static void Main(string[] args)
    {
        MoneyConDemo money=new MoneyConDemo();
        money.MoneyConMethod();
    }
}
