using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithmsBookExampleWithXSharp
{
    public class Graph
    {
        LinkedList<int>[] _linkedListArray;

        public Graph(int v)
        {
            _linkedListArray = new LinkedList<int>[v];
        }

        public void AddEdge(int u, int v, bool blnBiDie = true)
        {
            if (_linkedListArray[u] == null)
            {
                _linkedListArray[u] = new LinkedList<int>();
                _linkedListArray[u].AddFirst(v);
            }
        }
    }
}
