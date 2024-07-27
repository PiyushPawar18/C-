class RelationalOperatorsDemo
{
    public void RelationalMethod()
    {
        float a=15.0F,b=20.75F,c=15.0F;
        System.Console.WriteLine(" a = "+a);
        System.Console.WriteLine(" b = "+b);
        System.Console.WriteLine(" c = "+c);
        System.Console.WriteLine(" a<b ="+(a<b));
        System.Console.WriteLine(" a>b ="+(a>b));
        System.Console.WriteLine(" a==c ="+(a==c));
        System.Console.WriteLine(" a<=c ="+(a<=c));
        System.Console.WriteLine(" a>=b ="+(a>=b));
        System.Console.WriteLine(" b!=c ="+(b!=c));
        System.Console.WriteLine(" b == a+c ="+(b==a+c));
    }
}
class RelationalOperators
{
    public static void Main(string[] args)
    {
        RelationalOperatorsDemo obj=new RelationalOperatorsDemo();
        obj.RelationalMethod();
    }
}