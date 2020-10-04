using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallNeuralNetwork
{
    public class Cell
    {
        public Cell(string CellName) {
            Relevance = 0;
            this.CellName = CellName;
        }
        public Cell() {
            Relevance = 0;
        }
        public string CellName { get; set; }
        public string ChildName { get; set; }
        public float Relevance { get; set; }
    }
}
