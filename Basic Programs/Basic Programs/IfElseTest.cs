class IfElseTestDemo
{
    public void IfElseTestMethod()
    {
        int[] number = {50,65,56,71,81};
        int even = 0, odd = 0;

        for (int i=0;i<number.Length;i++)
        {
            if ((number[i]%2)==0)
            {
                even +=1;
            }
            else
            {
                odd +=1;
            }
            System.Console.WriteLine("Even Number: "+even);
            System.Console.WriteLine("Odd Number: "+odd);
        }
    }
}

class IfElseTest
{
    public static void Main(string[] args)
    {
        IfElseTestDemo obj = new IfElseTestDemo();
        obj.IfElseTestMethod();
    } 
}