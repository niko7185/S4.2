using System;
using System.Text;

namespace DataStructures
{
    public class Vertex<T>: Node<T>
    {

        protected bool visited;
        protected List<Vertex<T>> neighbours;


        public List<Vertex<T>> Neighbours => neighbours;

        public Vertex(T value) : base(value)
        {
            neighbours = new List<Vertex<T>>();
        }

        public void AddNeighbour(Vertex<T> neighbour)
        {

            neighbours.InsertItem(neighbour);

            bool hasNeighbour = neighbour.HasNeighbour(this);

            if(!hasNeighbour)
                neighbour.AddNeighbour(this);

        }

        public bool HasNeighbour(Vertex<T> neighbour)
        {

            bool exists = false;

            for(int i = 0; i < neighbours.Count; i++)
            {

                if(neighbours.GetItem(i).Equals(neighbour))
                    exists = true;

                if(exists)
                    break;

            }

            return exists;

        }

        public string PrintGraph(int level)
        {
            string result = $"({Value.ToString()})";

            if(level <= 1)
                return result;

            result += ":\n";

            for(int i = 0; i < neighbours.Count; i++)
            {
                result += $"[{neighbours.GetItem(i).PrintGraph(level - 1)}]\n";
            }

            return result;
        }

    }
}
