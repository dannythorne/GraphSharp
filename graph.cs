
namespace GraphSharp
{

public partial class Graph
{
  Vertex[] verts;
  int numVerts;

  public int NumVertices
  {
    get { return this.numVerts;}
  }

  public Graph( int numVerts=8)
  {
    this.numVerts = numVerts;

    this.verts = new Vertex[NumVertices];

    int i;
    for( i=0; i<NumVertices; i++)
    {
      this.verts[i] = new Vertex();
      //this.verts[i].Value = i;
    }
  }

  public void InsertEdge()
  {
  }

  public void Display()
  {
    System.Console.WriteLine("Graph");
    int i;
    for( i=0; i<NumVertices; i++)
    {
      System.Console.WriteLine("{0}: [{1}]",i,this.verts[i].Value);
    }
  }
}

}
