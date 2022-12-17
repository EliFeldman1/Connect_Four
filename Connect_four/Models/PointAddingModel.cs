using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_four
{
    internal class PointAddingModel
    {
        public string CurrentPlayer { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int startPointRow { get; set; }
        public int endPointRow { get; set; }
        public int startPointColumn { get; set; }
        public int endPointColumn { get; set; }
    }
}
