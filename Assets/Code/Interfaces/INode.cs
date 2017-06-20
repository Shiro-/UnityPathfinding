using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pathfinding.Core
{
    interface INode<T>
    {
        List<T> AdjacentsNodes { get; set; }
        T PreviusNode { get; set; }
        bool IsWalkable { get; set; }
        string NodeID { get; set; }
        void ClearNode();
    }
}
