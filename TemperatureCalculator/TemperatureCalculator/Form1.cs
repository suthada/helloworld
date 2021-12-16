namespace TemperatureCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {

            // get input form textbox
            //textBoxC.Text = "Hello";
            string input = textBoxC.Text;

            // convert to f
            // f = c * 9/5 + 32  C = f - 32 * 5/9
            // f = input * 9 / 5 + 32;
            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;

            // show input to textbox
            textBoxF.Text = f.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBoxF.Text;
            double f = Convert.ToDouble(input);
            double c = (f - 32) * 5 / 9;
            textBoxC.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
        }
    }
}

