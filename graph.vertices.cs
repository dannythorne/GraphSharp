
namespace GraphSharp
{

using System.Collections.Generic;

public partial class Graph
{

  public class Vertex
  {
    int id;

    List<Edge> edges;

    public Vertex( int id=-1)
    {
      this.id = id;
      this.edges = new List<Edge>();
    }

    public int ID
    {
      get { return this.id;}
    }

    public List<Edge> Edges
    {
      get { return this.edges;}
    }
  }
}

}
