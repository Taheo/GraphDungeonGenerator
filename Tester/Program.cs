internal class Program
{
    private static void Main(string[] args)
    {
        var engine = new GraphDungeonGenerator.Engine().GenerateSimpleGraph(new List<int> {1,2,3});

        Console.WriteLine($" V {engine.VertexCount}");
        foreach (var item in engine.Vertices)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($" K {engine.EdgeCount}");
        foreach (var item in engine.Edges)
        {
            Console.WriteLine(item);
        }
    }
}