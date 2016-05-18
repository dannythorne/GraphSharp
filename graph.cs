
namespace GraphSharp
{

using System;
using System.Collections.Generic;

public partial class Graph
{
  List<Vertex> verts; // each vertex contains a list of adjacent edges
  List<Edge> edges; // store references to edges in list for convenience

  int numVerts;
  int numEdges;

  public Graph( int numVerts=8)
  {
    NumVertices = numVerts;
    NumEdges = 0;

    Vertices = new List<Vertex>(NumVertices);
    Edges = new List<Edge>();

    int i;

    for( i=0; i<NumVertices; i++)
    {
      System.Console.WriteLine("{0} of {1}",i,NumVertices);
      Vertices.Add(new Vertex(i));
    }
  }

  public List<Vertex> Vertices
  {
    get { return this.verts;}
    private set { this.verts = value;}
  }

  public List<Edge> Edges
  {
    get { return this.edges;}
    private set { this.edges = value;}
  }

  public int NumVertices
  {
    get { return this.numVerts;}
    private set { this.numVerts = value;}
  }

  public int NumEdges
  {
    get { return this.numEdges;}
    private set { this.numEdges = value;}
  }

  public void InsertRandomEdges()
  {
    Random rand = new Random();

    int start;
    int end;

    Edge edge;

    int NumEdgesToAdd = NumVertices/2+rand.Next(NumVertices);

    System.Console.WriteLine("Adding {0} edges.",NumEdgesToAdd);

    int i;

    // Insert a random number of random edges. The number of edges is in the
    // vicinity of NumVertices so that the graph can be kept sparse.
    for( i=0; i<NumEdgesToAdd; i++)
    {
      // Vertex chosen at random and assigned to both start and end. Below, end
      // will be updated. Having it initialized this way facilitates the while
      // loop in the case that edges from a vertext to itself are disallowed.
      start = end = rand.Next(NumVertices);

      if( /*allow edge to self*/ false)
      {
        end = rand.Next(NumVertices);
      }
      else
      {
        // Make sure end is different from start.
        while( start == end) { end = rand.Next(NumVertices);}
      }

      // Create a new edge (start,end) and add it to the adjacency lists for
      // start and end as well as to the master list maintained here.
      edge = new Edge(start,end);
      Vertices[start].Edges.Add( edge);
      Vertices[end].Edges.Add( edge);
      Edges.Add(edge);

      NumEdges++;
    }

  }

  public void RemoveRandomEdges()
  {
    Random rand = new Random();

    int NumEdgesToRemove = rand.Next(NumEdges/2);
    if( /*more*/ true)
    {
      NumEdgesToRemove += NumEdges/2;
    }

    System.Console.WriteLine("Removing {0} edges.", NumEdgesToRemove);

    int i;
    for( i=0; i<NumEdgesToRemove; i++)
    {
      // Choose and edge at random.
      Edge edge = Edges[rand.Next(NumEdges)];

      // Get its start and end ids for indexing the vertices array.
      int start = edge.StartID;
      int end = edge.EndID;

      System.Console.WriteLine("Removing edge ({0},{1}).",start,end);

      // Remove the edge from the adjacency lists of both the start and the end
      // vertex as well as the master list maintained here.
      Vertices[start].Edges.Remove(edge);
      Vertices[end].Edges.Remove(edge);
      Edges.Remove(edge);

      NumEdges--;
    }
  }

  public void Display()
  {
    System.Console.WriteLine("Graph");
    int i;
    for( i=0; i<NumVertices; i++)
    {
      System.Console.Write("{0,2}: [{1,2}]",i,Vertices[i].ID);
      foreach( Edge edge in Vertices[i].Edges)
      {
        System.Console.Write("{0}",edge);
      }
      System.Console.WriteLine("");
    }
    System.Console.Write("Edges");
    i = 0;
    foreach( Edge edge in Edges)
    {
      System.Console.Write("{0} {1}",edge,i);
      i++;
    }
    System.Console.WriteLine("");

    System.Console.WriteLine("|V| = {0}", NumVertices);
    System.Console.WriteLine("|E| = {0}", NumEdges);
  }
}

}
