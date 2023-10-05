namespace Laboratorium2;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Fruit> FruitList = new List<Fruit>();
        for (int i = 0; i < 15; i++)
        {
            FruitList.Add(Fruit.Create());
        }
        foreach (var fruit in FruitList)
        {
            fruit.show();
        }

    }
}