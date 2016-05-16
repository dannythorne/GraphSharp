
namespace GraphSharp
{

using System;

public partial class Graph
{

  public class Edge
  {
    int id;
    int startID;
    int endID;

    public Edge( int id=-1, int startID=-1, int endID=-1)
    {
      this.id = id;
      this.startID = startID;
      this.endID = endID;
    }

    public int ID
    {
      get { return this.id;}
    }

    public override string ToString()
    {
      string s = "";
      
      if( /*display hash code for diagnostics*/ true)
      {
        s = String.Format("{0,9} ",this.GetHashCode());
      }

      s = String.Format("{0}Edge {1,2} ({2,2},{3,2})"
                       ,s
                       ,this.ID
                       ,this.startID
                       ,this.endID
                       );
      return s;
    }
  }
}

}
