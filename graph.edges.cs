
namespace GraphSharp
{

using System;

public partial class Graph
{

  public class Edge
  {
    Node node;

    int startID;
    int endID;

    public Edge( int startID=-1, int endID=-1)
    {
      this.startID = startID;
      this.endID = endID;
    }

    public int StartID
    {
      get { return this.startID;}
    }

    public int EndID
    {
      get { return this.endID;}
    }

    public override string ToString()
    {
      string s = "";
      
      if( /*display hash code*/ false)
      {
        s = String.Format("{0,10} ",this.GetHashCode());
      }

      s = String.Format( " --> {0}({1,2},{2,2})"
                       , s
                       , this.startID
                       , this.endID
                       );
      return s;
    }
  }
}

}
