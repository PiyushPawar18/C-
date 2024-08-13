class PrimeDemo
{
    public void PrimeMethod()
    {
        System.Console.Write("Enter a no := ");
        int x=int.Parse(System.Console.ReadLine());
        if(x % 2==1  || x == 2)
        {
            System.Console.WriteLine(x +" is Prime No ");
        }
        else
        {
            System.Console.WriteLine(x + " is Not Prime NO .");
        }
    }
}
class Prime1D2
{
    public static void Main(string[] args)
    {
        PrimeDemo obj=new PrimeDemo();
        obj.PrimeMethod();
    }
}
