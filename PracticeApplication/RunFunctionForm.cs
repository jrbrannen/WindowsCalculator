using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApplication
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void RunFunctionButton_Click(object sender, EventArgs e)
        {
            string aFriend = "Jeremy";
            Console.WriteLine($"Hello {aFriend}");
        }
    }
}
