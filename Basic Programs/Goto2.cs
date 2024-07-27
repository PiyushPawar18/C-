class Goto2Demo
{
    public void Goto2DemoMethod()
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
            default:
                System.Console.WriteLine("Invalid choice");  
                break; 
            case 3:
                x=y-m;
                System.Console.WriteLine("(x=y-m) = " + x);
                goto default;
            case 2:
                x=y+m;
                System.Console.WriteLine("(x=y+m) = " + x);
                goto case 3;
            case 1:
                x=y;
                System.Console.WriteLine("(x=y) = " + x);
                goto case 2;
                
        }
    }
}
class Goto2
{
    public static void Main(string[] args)
    {
        Goto2Demo obj=new Goto2Demo();
        obj.Goto2DemoMethod();
    }
}