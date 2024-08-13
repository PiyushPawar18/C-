class FibonacciDemo
{
    public void FibonacciMethod()
    {
        System.Console.WriteLine("Enter a no := ");
        int x=int.Parse(System.Console.ReadLine());
        int a=0;
        int b=1,c;
        System.Console.Write(a + " " + b + " ");
        for (int i=2;i<=x;i++)
        {
            c=a+b;
            a=b;
            b=c;
            System.Console.Write(c + " ");
        }
    }
}
class Fibo1D1
{
    public static void Main(string[] args)
    {
        FibonacciDemo obj=new FibonacciDemo();
        obj.FibonacciMethod();
    }
}
