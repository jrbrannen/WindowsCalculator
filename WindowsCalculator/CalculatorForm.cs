using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculator
{
    public partial class CalculatorForm : Form
    {
        DisplayScreen displayScreen;
        public CalculatorForm()
        {
            InitializeComponent();
            displayScreen = new DisplayScreen(this);
            OpenDisplayScreen();
        }

        public void OpenDisplayScreen()
        {
            this.Controls.Clear();
            //DisplayScreen displayScreen = new DisplayScreen(this);
            this.Controls.Add(displayScreen);
        }
    }
}
