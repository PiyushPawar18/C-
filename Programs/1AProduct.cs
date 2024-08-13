class ProductDemo
{
    public void ProductMethod()
    {
        System.Console.WriteLine("Enter a 4 int no := ");
        int a = int.Parse(System.Console.ReadLine());
        int b = int.Parse(System.Console.ReadLine());
        int c = int.Parse(System.Console.ReadLine());
        int d = int.Parse(System.Console.ReadLine());

        int product=a*b*c*d;
        System.Console.WriteLine("product of 4 int no is := "+ product);
    }
}
class Product1a
{
    public static void Main(string[] args)
    {
        ProductDemo obj=new ProductDemo();
        obj.ProductMethod();
    }
}
