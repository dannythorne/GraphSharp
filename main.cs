
using GraphSharp;

public class Program
{
  public static void Main()
  {
    System.Console.WriteLine("Hello");

    Graph graph = new Graph(12);
    graph.Display();
    graph.InsertEdge();
  }
}

