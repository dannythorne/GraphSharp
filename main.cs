
using GraphSharp;

public class Program
{
  public static void Main()
  {
    System.Console.WriteLine("Hello");

    Graph graph = new Graph(32);
    //graph.Display();
    graph.InsertRandomEdges();
    graph.Display();
    graph.RemoveRandomEdges();
    graph.RemoveRandomEdges();
    graph.RemoveRandomEdges();
    graph.RemoveRandomEdges();
    graph.Display();

    System.Console.WriteLine("Good Bye");
  }
}

