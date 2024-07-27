class Trial1
{
    private int x;
    public void setX(int x)
    {
        this.x=x;
        int result=Calculate();
        System.Console.WriteLine("x = {0} ",result);	
    }
    public int Calculate(){
        return(x*x);
    }
}
class Trial2 : Trial1
{
    private int z;
    public void Display(int z,int x)
    {
        this.z=z;
        System.Console.WriteLine("z = {0} ",this.z);
        setX(x);
    }
}
class TrailClient
{
	public static void Main(string[] args)
	{
		Trial2 obj=new Trial2();
		obj.Display(3,2);
	}
}
