using QuickGraph;

internal class Program
{
    private static void Main(string[] args)
    {
        var engine = new GraphDungeonGenerator.Engine();
        var simpleGraph = engine.GenerateSimpleGraph(10);
        var randomGraph = engine.GenerateRandomGraphWithOneEntrance(simpleGraph);
        DisplayGraph(randomGraph);
    }

    private static void DisplayGraph(AdjacencyGraph<int, Edge<int>> graph)
    {
        Console.WriteLine($" V {graph.VertexCount}");
        foreach (var item in graph.Vertices)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($" K {graph.EdgeCount}");
        foreach (var item in graph.Edges)
        {
            Console.WriteLine(item);
        }
    }
}