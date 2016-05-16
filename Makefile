
main.exe: Graph.dll main.cs
	mcs /reference:Graph.dll main.cs

Graph.dll: graph.cs graph.edges.cs graph.vertices.cs
	mcs /target:library /out:Graph.dll graph.cs graph.edges.cs graph.vertices.cs

a:
	mono ./main.exe

sweep:
	mv *~ ./tildes
