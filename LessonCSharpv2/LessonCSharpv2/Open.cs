using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace LessonCSharpv2
{
    public partial class Open : Form
    {
        public Open()
        {
            InitializeComponent();
        }

        public Open(Form3 f)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (File.Exists(textBox1.Text)) {
                string[] arrStr = File.ReadAllLines(textBox1.Text);

                foreach (var str in arrStr)
                {
                    list.Add(str);
                }

                Open open = new Open();
                Form3 f = new Form3(open, list);
                f.Show();
            }
            else
            {
                MessageBox.Show("Такого файла нет.");
            }
        }

        private List<string> list = new List<string>();
    }
}
