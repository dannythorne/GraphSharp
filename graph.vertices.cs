
namespace GraphSharp
{

using System.Collections.Generic;

public partial class Graph
{

  public class Vertex
  {
    Node node;

    int id;

    List<Edge> edges;

    public Vertex( int id=-1)
    {
      ID = id;
      Edges = new List<Edge>();
    }

    public int ID
    {
      get { return this.id;}
      private set { this.id = value;}
    }

    public List<Edge> Edges
    {
      get { return this.edges;}
      private set { this.edges = value;}
    }
  }
}

}
