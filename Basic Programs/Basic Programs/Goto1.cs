class Goto1Demo
{
    public void Goto1DemoMethod()
    {
        int x,y,m;
        System.Console.WriteLine("Enter a value y:= ");
        y=System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Enter a value m:= ");
        m=System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Select your choice");
        System.Console.WriteLine("1. x=y");
        System.Console.WriteLine("2. x=y+m");
        System.Console.WriteLine("3. x=y-m");
        System.Console.Write("Type your choice:= ");
        
        int choice = System.Convert.ToInt32(System.Console.ReadLine());

        switch (choice)
        {
            case 1:
                x=y;
                System.Console.WriteLine("(x=y) = " + x);
                goto case 2;
            case 2:
                x=y+m;
                System.Console.WriteLine("(x=y+m) = " + x);
                goto case 3;
            case 3:
                x=y-m;
                System.Console.WriteLine("(x=y-m) = " + x);
                goto default;
            default:
                System.Console.WriteLine("Invalid choice");  
                break;     
        }
    }
}
class Goto1
{
    public static void Main(string[] args)
    {
        Goto1Demo obj=new Goto1Demo();
        obj.Goto1DemoMethod();
    }
}