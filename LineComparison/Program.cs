class Program
{
    
    public static int x1, x2, y1, y2, i; //variable declaration

    public class FindingLength
    {
        public void FindLen(int x1, int y1, int x2, int y2)
        {
            double sqrt = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); //formula for finding length
            Console.WriteLine(Math.Round(sqrt, 2)); //Here we are rounding up the double value of decimal 2
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for coordinate x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter value for coordinate y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter value for coordinate x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter value for coordinate y2");
        y2 = Convert.ToInt32(Console.ReadLine());
        
        FindingLength obj = new FindingLength();//object for created for class FindingLength
        obj.FindLen(x1, y1, x2, y2);//Here we are passing values to the function
    }

}
