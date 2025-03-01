using QuickGraph;

namespace GraphDungeonGenerator
{
    public class Engine
    {
        public AdjacencyGraph<int, Edge<int>> GenerateSimpleGraph(int vertices)
        {
            var graph = new AdjacencyGraph<int, Edge<int>>();
            for (int i = 1; i <= vertices; i++)
            {
                graph.AddVertex(i);
            }

            foreach (var item in graph.Vertices)
            {
                if (item != graph.VertexCount)
                {
                    graph.AddEdge(new Edge<int>(item, item + 1));
                }
            }

            return graph;
        }

        public AdjacencyGraph<int, Edge<int>> GenerateRandomGraphWithOneEntrance(int vertices)
        {
            var graphToRandomize = GenerateSimpleGraph(vertices);
            var graph = new AdjacencyGraph<int, Edge<int>>();
            var firstVertex = graphToRandomize.Vertices.First();
            var random = new Random();

            foreach (var vertex in graphToRandomize.Vertices)
            {
                graph.AddVertex(vertex);
            }

            var edges = graphToRandomize.Edges.ToList();
            var secondVertex = graphToRandomize.Vertices.First() + 1;
            var thirdVertex = graphToRandomize.Vertices.First() + 2;

            graph.AddEdge(new Edge<int>(firstVertex, secondVertex));
            graph.AddEdge(new Edge<int>(firstVertex, thirdVertex));
            var rng = new Random();


            foreach (var item in graphToRandomize.Vertices.Where(x => x != firstVertex))
            {
                graph.AddEdge(new Edge<int>(item, GenerateNextVertex(item, graphToRandomize.VertexCount)));
            }

            graph.RemoveEdge(graph.Edges.Last());

            return graph;
        }

        private int GenerateNextVertex(int vertex, int max)
        {
            var rng = new Random();
            int nextVert;


            if (vertex + 1 == max)
            {
                return vertex + 1;
            }

            if (vertex == max)
            {
                return vertex;
            }

            do
            {
                nextVert = rng.Next(vertex, max);
            } while (nextVert <= vertex);

            return nextVert;
        }
    }
}
