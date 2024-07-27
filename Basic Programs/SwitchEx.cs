class SwitchDemo
{
    public void SwitchDemoMethod()
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
                break;
            case 2:
                x=y+m;
                System.Console.WriteLine("(x=y+m) = " + x);
                break; 
            case 3:
                x=y-m;
                System.Console.WriteLine("(x=y-m) = "  + x);
                break;
            default:
                System.Console.WriteLine("Invalid choice");  
                break;     
        }
    }
}
class SwitchEx
{
    public static void Main(string[] args)
    {
        SwitchDemo obj=new SwitchDemo();
        obj.SwitchDemoMethod();
    }
}