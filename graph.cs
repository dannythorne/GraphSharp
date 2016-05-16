
namespace GraphSharp
{

using System;
using System.Collections.Generic;

public partial class Graph
{
  Vertex[] verts;
  int numVerts;

  public Graph( int numVerts=8)
  {
    this.numVerts = numVerts;

    this.verts = new Vertex[NumVertices];

    int i;
    for( i=0; i<NumVertices; i++)
    {
      this.verts[i] = new Vertex(i);
    }
  }

  public int NumVertices
  {
    get { return this.numVerts;}
  }

  public void InsertRandomEdges()
  {
    int i;

    Random rand = new Random();

    int start;
    int end;

    Edge edge;

    for( i=0; i<NumVertices; i++)
    {
      start = end = rand.Next(NumVertices);
      if( /*allow start==end*/ false)
      {
        end = rand.Next(NumVertices);
      }
      else
      {
        while( start == end) { end = rand.Next(NumVertices);}
      }

      edge = new Edge(i,start,end);
      this.verts[start].Edges.Add( edge);

      if( /*duplicate edges*/ false)
      {
        // Any reason for the edge object in start's list be different from the
        // edge object in end's list?
        this.verts[end].Edges.Add( new Edge(i,start,end));
      }
      else
      {
        this.verts[end].Edges.Add( edge);
      }
    }

  }

  public void Display()
  {
    System.Console.WriteLine("Graph");
    int i;
    for( i=0; i<NumVertices; i++)
    {
      System.Console.Write("{0,2}: [{1,2}]",i,this.verts[i].ID);
      foreach( Edge edge in this.verts[i].Edges)
      {
        System.Console.Write(" [{0}]",edge);
      }
      System.Console.WriteLine("");
    }
  }
}

}
