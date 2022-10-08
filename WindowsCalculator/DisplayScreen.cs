using NameConcationationLibrary;
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
    public partial class DisplayScreen : UserControl
    {
        public DisplayScreen(CalculatorForm parentForm)
        {
            InitializeComponent();
        }

        public void DisplayFullName(string firstName, string lastName)
        {
            NameConcationation fullName = new();
            fullName.ConcationateFirstAndLastName(firstName, lastName);
        }

    }
}
