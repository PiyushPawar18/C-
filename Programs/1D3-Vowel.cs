class VowelDemo
{
    public void VowelMethod()
    {
        System.Console.WriteLine("Enter a character := ");
        char x = char.Parse(System.Console.ReadLine());
        if(x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u' || x == 'A' || x == 'E' || x == 'I' || x == 'O' || x == 'U' )
        {
            System.Console.WriteLine(x +" is Vowel .");
        }
        else
        {
            System.Console.WriteLine(x + "is Not Vowel .");
        }
    }
}
class Vowel1D3
{
    public static void Main(string[] args)
    {
        VowelDemo obj=new VowelDemo();
        obj.VowelMethod();
    }
}
