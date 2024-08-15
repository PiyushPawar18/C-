using System;
using System.Collections;

class ArrayListDemo
{
    string item_name;
    public void AddArrayList(ArrayList al)
    {
        Console.Write("Enter a item name :=");
        item_name=Console.ReadLine();
        al.Add(item_name);
        Console.WriteLine(item_name +" is Added Succesfully ..");
    }
    public void FindIndex(ArrayList al)
    {
        Console.Write("Enter the item name to find there index :=");
        item_name=Console.ReadLine();
        int index_item=al.IndexOf(item_name);
        if(index_item>=0)
        {
            Console.WriteLine("Index of "+item_name+ " is "+index_item);
        }
        else
        {
            Console.WriteLine(item_name + " is not in a Array .");
        }
    }
    public void CheckElement(ArrayList al)
    {
        if(al.Count > 0)
        {
            Console.WriteLine("The array contains elements.");
        }
        else
        {
            Console.WriteLine("Array is empty ..");
        }
    }
    public void CountElement(ArrayList al)
    {
        Console.WriteLine("Total elements is := "+al.Count);
    }
    public void ReverseElement(ArrayList al)
    {
        al.Reverse();
        Console.WriteLine("Array is Reversed ..");
    }
    public void SortElement(ArrayList al)
    {
        al.Sort();
        Console.WriteLine("Array is Sorted ..");
    }
    public void Display(ArrayList al)
    {
        foreach(var item in al)
        {
            Console.WriteLine(item);
        }
    }
    public void RemoveLast(ArrayList al)
    {
        if(al.Count>0)
        {
            Console.WriteLine("Remove Last item := "+al[al.Count-1]);
            al.RemoveAt(al.Count-1);
        }
        else
        {
            Console.WriteLine("The array is empty, nothing to remove.");
        }
    }
    public void RemoveIndex(ArrayList al)
    {
        
        Console.Write("Enter a item index to remove := ");
        int remove_index=int.Parse(Console.ReadLine());
        if(remove_index>=0 && remove_index < al.Count)
        {
            Console.WriteLine("Remove item := "+al[remove_index] + " from index "+ remove_index );
            al.RemoveAt(remove_index);
        }
        else
        {
            Console.WriteLine("The array is empty, nothing to remove.");
        }
    }

}
class ArrayListPro
{
    public static void Main(string[] args)
    {
        ArrayList al=new ArrayList();
        ArrayListDemo d=new ArrayListDemo();
        bool userInput=true;

        while(userInput!=false)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Add an item");
            Console.WriteLine("2. Find index of a value");
            Console.WriteLine("3. Check if array contains any elements");
            Console.WriteLine("4. Count of elements");
            Console.WriteLine("5. Reverse the array");
            Console.WriteLine("6. Sort the array");
            Console.WriteLine("7. List the items in the array");
            Console.WriteLine("8. Remove the last item");
            Console.WriteLine("9. Remove item at a specific index");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: "); 
            int choice =int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 0:
                    userInput=false;
                    break;
                case 1:
                    d.AddArrayList(al);
                    break;
                case 2:
                    d.FindIndex(al);
                    break;
                case 3:
                    d.CheckElement(al);
                    break;
                case 4:
                    d.CountElement(al);
                    break;
                case 5:
                    d.ReverseElement(al);
                    break;
                case 6:
                    d.SortElement(al);
                    break;
                case 7:
                    d.Display(al);
                    break;
                case 8:
                    d.RemoveLast(al);
                    break;
                case 9:
                    d.RemoveIndex(al);
                    break;
                default:
                    Console.WriteLine("Invalid choice ... ");
                    break;
            }
        }
    }
}