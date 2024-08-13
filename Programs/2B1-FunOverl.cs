class Fun
{
    int a=4,b=5,c;
    public void add()
    {
        c=a+b;
        System.Console.WriteLine("4+5 = "+c);
    }
    public void add(int a,int b)
    {
        c=a+b;
        System.Console.WriteLine(a+"+"+b+" = "+c);
    }
}
class FunOverlo
{
    public static void Main(string[] args)
    {
        Fun obj=new Fun();
        obj.add();
        obj.add(5,9);
    }
}
