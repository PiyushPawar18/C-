class IfElseNestingDemo
{
    public void IfElseNestingMethod()
{
    {
        int a=325,b=712,c=478;

        System.Console.Write("Largest value is: ");

        if (a>b)
        {
            if (a>c)
            {
                  System.Console.Write(a);
            }
            else
            {
                System.Console.Write(c);
            }
        } 
        else
        {
            if (c>b)
            {
                System.Console.Write(c);
            }
            else
            {
                System.Console.Write(b);
        
            }
        }
    }
}
}

class IfElseNesting
{
    public static void Main(string[] args)
    {
        IfElseNestingDemo obj = new IfElseNestingDemo();
        obj.IfElseNestingMethod();
    }
}