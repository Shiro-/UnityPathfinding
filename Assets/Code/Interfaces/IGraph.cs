using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pathfinding.Core
{
    interface IGraph
    {
        Node[] Nodes{ get; set; }
        int Rows { get; set; }
        int columns { get; set; }
        void MainOperation();
    }
}
