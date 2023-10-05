namespace Laboratorium2;
internal class Program
{
    private static async Task Main(string[] args)
    {
        List<Fruit> FruitList = new List<Fruit>();
        for (int i = 0; i < 15; i++)
        {
            FruitList.Add(Fruit.Create());
        }

        Console.WriteLine("=== All Fruits ===");
        foreach (var fruit in FruitList)
        {
            Console.WriteLine(fruit.ToString());
        }
        Console.WriteLine("\n=== Sweet Fruits By Price ===");
        var sweetFruit = FruitList.Where(x => x.IsSweet.Equals(true)).OrderBy(x => x.Price);
        foreach (var fruit in sweetFruit)
        {
            Console.WriteLine(fruit.ToString());
        }

        UsdCourse.Current = await UsdCourse.GetUsdCourseAsync();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine( $"\nCurrent USD Course: {UsdCourse.Current} PLN");
        Console.ResetColor();

    }
}