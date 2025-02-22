using QuickGraph;

namespace GraphDungeonGenerator
{
    public class Engine
    {
        public AdjacencyGraph<int, Edge<int>> GenerateSimpleGraph(List<int> vertexList)
        {
            var graph = new AdjacencyGraph<int, Edge<int>>();
            graph.AddVertexRange(vertexList);

            foreach (var item in graph.Vertices)
            {
                if (item != graph.VertexCount)
                {
                    graph.AddEdge(new Edge<int>(item, item + 1));
                }
            }

            return graph;
        }
    }
}
