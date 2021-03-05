using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class GraphTraverser<T>
    {

        private List<Vertex<T>> listOfVisited;
        private int exploreIndex;

        public string PrintBSF(Vertex<T> vertex)
        {
            listOfVisited = new List<Vertex<T>>();

            listOfVisited.InsertItem(vertex);

            return PrintBreadthFirst(vertex);

        }

        private string PrintBreadthFirst(Vertex<T> vertex)
        {

            string result = $"({vertex.Value}):\n[";
            exploreIndex++;

            for(int i = 0; i < vertex.Neighbours.Count; i++)
            {

                Vertex<T> neighbour = vertex.Neighbours.GetItem(i);

                if(!listOfVisited.Contains(neighbour))
                {
                    result += $"({neighbour.Value})";

                    listOfVisited.InsertItem(neighbour);
                }

            }
            result += "]\n";

            if(listOfVisited.Count > exploreIndex)
                result += PrintBreadthFirst(listOfVisited.GetItem(exploreIndex));

            return result;
        }

        public string PrintDSF(Vertex<T> vertex)
        {


            listOfVisited = new List<Vertex<T>>();

            listOfVisited.InsertItem(vertex);

            return PrintDepthFirst(vertex);

        }

        private string PrintDepthFirst(Vertex<T> vertex)
        {


            string result = $"({vertex.Value}):\n[";

            for(int i = 0; i < vertex.Neighbours.Count; i++)
            {

                Vertex<T> neighbour = vertex.Neighbours.GetItem(i);

                if(!listOfVisited.Contains(neighbour))
                {
                    result += PrintDepthFirst(neighbour);

                    listOfVisited.InsertItem(neighbour);
                }
            }

            return result;
        }


    }
}
