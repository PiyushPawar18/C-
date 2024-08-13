class Fun
{
    int a=4,b=5,c;
    public Fun()
    {
        c=a+b;
        System.Console.WriteLine("4+5 = "+c);
    }
    public Fun(int a,int b)
    {
        c=a+b;
        System.Console.WriteLine(a+"+"+b+" = "+c);
    }
}
class ConOverl1
{
    public static void Main(string[] args)
    {
        //Fun obj=new Fun();
        Fun obj1=new Fun(5,9);
        Fun obj2=new Fun();
        
    }
}
