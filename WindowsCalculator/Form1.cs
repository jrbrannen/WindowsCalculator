namespace WindowsCalculator
{
    public partial class Form1 : Form
    {
        private string? inputString = "";
        private char operation;
        private float? firstInputFloat = null;
        private float? secondInputFloat = null;
        //private string? displayOutput;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(inputString == null)
            //{
                inputString += "1";
                label1.Text = inputString;
            //}
            //else
            //{
            //    secondInputString +="1";
            //    label1.Text = secondInputString;
            //}
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (inputString == null)
            //{
                inputString += "2";
                label1.Text = inputString;
            //}
            //else
            //{
            //    secondInputString += "2";
            //    label1.Text = secondInputString;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputString += "3";
            label1.Text = inputString;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputString += "4";
            label1.Text = inputString;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputString += "5";
            label1.Text = inputString;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputString += "6";
            label1.Text = inputString;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputString += "7";
            label1.Text = inputString;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputString += "8";
            label1.Text = inputString;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void display_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputString += "9";
            label1.Text = inputString;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            inputString += "0";
            label1.Text = inputString;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            operation = '+';
            firstInputFloat = float.Parse(inputString);
            inputString = "";
            label1.Text = inputString;
            //if (inputString != null)
            //{
            //    if (firstInputFloat == null && secondInputFloat == null)
            //    {
            //        try
            //        {
            //            firstInputFloat = float.Parse(inputString);
            //            inputString = "";
            //            label1.Text = inputString;
            //        }
            //        catch (Exception)
            //        {
            //        }
            //    }
            //    else if (firstInputFloat != null && secondInputFloat == null)
            //    {
            //        secondInputFloat = float.Parse(inputString);
            //        firstInputFloat = firstInputFloat + secondInputFloat;
            //        inputString = "";
            //        label1.Text = inputString;

            //    }
            //    else if (firstInputFloat != null && secondInputFloat != null)
            //    {
            //        firstInputFloat += secondInputFloat;
            //        secondInputFloat = null;
            //        inputString = "";
            //        label1.Text = inputString;
            //    }
            //}

        }

        private void subtractButoon_Click(object sender, EventArgs e)
        {
            operation = '-';
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            secondInputFloat = float.Parse(inputString);
            label1.Text = calculate(firstInputFloat, secondInputFloat, operation).ToString();
            
        }

        private float? calculate(float? firstInput, float? secondInput, char operation)
        {
            if (operation == '+')
            {
                return firstInput + secondInput;
            }
            else if (operation == '-')
            {
                return firstInput - secondInput;
            }
            else if (operation == '*')
            {
                return firstInput * secondInput;
            }
            else if (operation == '/')
            {
                return firstInput / secondInput;
            }
            return float.NaN;
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            inputString = "";
            firstInputFloat = 0.0f;
            secondInputFloat = 0.0f;
        }
    }
}