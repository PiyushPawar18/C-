class RevSumDemo
{
    public void RevSumMethod()
    {
        System.Console.WriteLine("Enter a no := ");
        int a =int.Parse(System.Console.ReadLine());
        int b=a,tem=0;
        int sum=0,rev=0;
        while(b!=0)
        {
            tem=b%10;
            rev=rev*10+tem;
            b=b/10;
            sum=sum+tem;
        }
        System.Console.WriteLine("reverse no is := "+rev+" \nSum of digit is := "+sum);
    }
}
class RevSum1D5
{
    public static void Main(string[] args)
    {
        RevSumDemo obj=new RevSumDemo();
        obj.RevSumMethod();
    }
}
