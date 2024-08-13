class Factorial
{
    public void FactorialMethod()
    {
        System.Console.Write("Enter a no := ");
        int num=int.Parse(System.Console.ReadLine());
        int a=num,tem=1;

        for(int i=0;i<num;i++)
        {
           tem=tem*a;  
           if(a==1)
           {
            System.Console.Write(a);
           }
           else
           {
            System.Console.Write(a +"*");
           }
           a--;
        }
        System.Console.WriteLine("\nfactorial of "+num+" is := "+tem);
    }
}
class Facto2A1
{
    public static void Main(string[] args)
    {
        Factorial fact=new Factorial();
        fact.FactorialMethod();
    }
}
