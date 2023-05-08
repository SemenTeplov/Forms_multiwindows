using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace LessonCSharpv2
{
    public partial class Save : Form
    {
        public Save()
        {
            InitializeComponent();
        }

        public Save(Form3 f)
        {
            InitializeComponent();

        }

        public Save(List<string> strings)
        {
            InitializeComponent();

            listString = strings;

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            File.AppendAllLines(textBox1.Text, listString);
        }

        private List<string> listString = new List<string>();
    }
}
