class ExpressionsDemo
{
    public void ExpressionsMethod()
    {
        //Declaration and Initialization
        int a=10, b=5, c=8, d=2;
        float x=6.4F,y=3.0F;

        //Order of Evaluation
        int ans1 = a*b*c/d;
        int ans2 = a*(b*c)/d;

        //Modulo Operations
        int ans3 = a%c;
        float ans4 = x%y;

        //Logical Operations
        bool bool1 = a>b && c>d;
        bool bool2 = a<b && c>d;
        bool bool3 = a<b || c>d;
        bool bool4 = !(a-b == c);

        System.Console.WriteLine("Order of Evaluation");
        System.Console.WriteLine("a*b*c/d = "+ ans1);
        System.Console.WriteLine("a*(b*c)/d = "+ ans2);

        System.Console.WriteLine("Modulo Operations");
        System.Console.WriteLine("a%c = "+ ans3);
        System.Console.WriteLine("x%y = "+ ans4);

        System.Console.WriteLine("Logical Operations");
        System.Console.WriteLine("a>b && c>d = "+ bool1);
        System.Console.WriteLine("a<b && c>d = "+ bool2);
        System.Console.WriteLine("a<b || c>d = "+ bool3);
        System.Console.WriteLine("!(a-b == c) = "+ bool4);
    }
}
class Expressions
{
      public static void Main(string[] args)
    {
        ExpressionsDemo obj=new ExpressionsDemo();
        obj.ExpressionsMethod();
    }
}