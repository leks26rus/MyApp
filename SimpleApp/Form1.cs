using System;
using System.Windows.Forms;

namespace SimpleApp
{
    public partial class Form1 : Form
    {
        someText text;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = new someText("Вот этот текст будет сверху после нажатия второй кнопки");
            MessageBox.Show(text.getText());
            button2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = text.getText();
            label2.Text = text.getUpperText();
            label3.Text = text.getReverseText();
        }
    }
}
