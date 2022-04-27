class Program
{
    public static int x1, x2, y1, y2;
    static void Main(string[] args)
    {
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Enter value for coordinate x1");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for coordinate y1");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for coordinate x2");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for coordinate y2");
            y2 = Convert.ToInt32(Console.ReadLine());
            
            FindLength obj = new FindLength();//object for created for class FindLength
            obj.LineLength(x1, y1, x2, y2, i);
            Console.WriteLine("\n>>Press Enter to continue...\n");
            Console.ReadKey();
        }
        CheckEquality obj1 = new CheckEquality();
        obj1.ComputeEquals();


    }
}
public class FindLength
{
    public void LineLength(int x1, int y1, int x2, int y2, int i)
    {
        double sqrt = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));//formula for finding length
        string value = Convert.ToString(Math.Round(sqrt, 2));
        Console.WriteLine("\nLength of line "+i+" is:" + value);
        InitializeArray.InsertingValue(value, i);


    }
}
public class CheckEquality
{
    public void ComputeEquals()
    {
        if (InitializeArray.values[0].Equals(InitializeArray.values[1]) == true)
        {
            Console.WriteLine("Result: Both lines are equal");

        }
        else
        {
            Console.WriteLine("Result: Both lines are different");
        }
    }
}

public static class InitializeArray
{
    public static string[] values = new string[2];
    public static void InsertingValue(string val, int index)
    {
        values[index] = val;
    }

}