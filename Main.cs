using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallNeuralNetwork
{
    public partial class Main : Form
    {
        public static Main selfref { get; set; }
        ControllerNeuralNetwork neuralnetwork = new ControllerNeuralNetwork();
        public Main()
        {
            InitializeComponent();
            selfref = this;
            neuralnetwork.InitCells();
        }
    }
}
