class QuadraticDemo
{
    public void QuadraticMethod()
    {
        int a,b,c,ans;
        double x1,x2;
        a=int.Parse(System.Console.ReadLine());
        b=int.Parse(System.Console.ReadLine());
        c=int.Parse(System.Console.ReadLine());

        ans=b*b-4*a*c;
        if(ans==0)
        {
            System.Console.WriteLine("both root is real and equal .");
            x1=-b/2*a;
            x2=x1;
            System.Console.WriteLine("Root of x1 is := "+x1+"\nRoot of x2 is := "+x2);
        }
        else if(ans>0)
        {
            System.Console.WriteLine("Root is real and unequal .");
            x1=(-b-System.Math.Sqrt(ans))/2*a;
            x2=(-b+System.Math.Sqrt(ans))/2*a;
            System.Console.WriteLine("Root of x1 is := "+x1+"\nRoot of x2 is := "+x2);
        }
        else
        {
            System.Console.WriteLine("Roots are imaginary ..\nNo Solution.");
        }
        
    }
}
class Quadratic2A3
{
    public static void Main(string[] args)
    {
        QuadraticDemo obj=new QuadraticDemo();
        obj.QuadraticMethod();
    }
}
