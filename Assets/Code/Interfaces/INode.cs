using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pathfinding.Core
{
    interface INode
    {
        List<Node> Nodes { get; set; }
        Node PreviusNode { get; set; }
        string NodeName { get; set; }
        void ClearNode();
    }
}
