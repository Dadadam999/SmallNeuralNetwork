using SmallNeuralNetwork.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallNeuralNetwork
{
    public class ControllerNeuralNetwork
    {
        List<Cell> Cells = new List<Cell>();
        public void InitCells()
        {
            for (int i = 1; i <= 25; i++)
                Cells.Add(new Cell("cell" + i.ToString()));

            Cells[0].ChildName = "Mouse";

            Cells[3].ChildName = "Cat";
            Cells[5].ChildName = "Cat";
            Cells[8].ChildName = "Cat";
            Cells[13].ChildName = "Cat";
            Cells[12].ChildName = "Cat";
            Cells[22].ChildName = "Cat";
            Cells[15].ChildName = "Cat";
            Cells[19].ChildName = "Cat";

            Cells[24].ChildName = "Cheese";

            for (int i = 0; i < 25; i++)
            {
                if (Cells[i].ChildName == "Cat")
                    Main.selfref.MainGrid.Controls[i].Controls.Add(new Cat());

                if (Cells[i].ChildName == "Mouse")
                    Main.selfref.MainGrid.Controls[i].Controls.Add(new Mouse());

                if (Cells[i].ChildName == "Cheese")
                    Main.selfref.MainGrid.Controls[i].Controls.Add(new Cheese());
            }
        }
    }
}
