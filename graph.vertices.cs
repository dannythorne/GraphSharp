
namespace GraphSharp
{

public partial class Graph
{
  public class Vertex
  {
    int val;
    Edge[] edges;

    public Vertex( int val=0)
    {
      this.val = val;
    }

    public int Value
    {
      get { return this.val;}
      set { this.val = value;}
    }
  }
}

}
