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
            // show input to textbox
            textBoxF.Text = input;
        }
    }
}