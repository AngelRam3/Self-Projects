namespace CAMP_Jeopordy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int buttonWidt = ((this.Width - 50) / 2);
            int buttonWidth = (int)(buttonWidt * 0.4);
            button1.Width = buttonWidth;
            button1.Left = (this.Width - buttonWidth) / 2;
            button1.Top = (this.ClientSize.Height - ((button1.Height * 2) + 20)) / 2;

            button2.Width = buttonWidth;
            button2.Left = button1.Left;
            button2.Top = button1.Bottom + 40;

            label1.Width = this.Width;
            label1.Left = (this.Width - label1.Width) / 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
