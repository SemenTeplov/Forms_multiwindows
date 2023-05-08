using System.Windows.Forms;
using System.Collections.Generic;

namespace LessonCSharpv2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("column1", "Имя");
            dataGridView1.Columns.Add("column2", "Фамилия");
            dataGridView1.Columns.Add("column3", "Возраст");
        }

        public Form3(Open o, List<string> str)
        {
            InitializeComponent();

            dataGridView1.Columns.Add("column1", "Имя");
            dataGridView1.Columns.Add("column2", "Фамилия");
            dataGridView1.Columns.Add("column3", "Возраст");

            listString = str;

            for (int elem = 0; elem < listString.Count; elem++)
            {
                arrString = listString[elem].Split(' ');
                dataGridView1.Rows.Add();

                for (int item = 0; item < 3; item++)
                {
                    dataGridView1[item, elem].Value = arrString[item];
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            for (int elem = 0; elem < dataGridView1.RowCount - 1; elem++)
            {
                listString.Add(dataGridView1[0, elem].Value.ToString() + " " 
                    + dataGridView1[1, elem].Value.ToString() + " " 
                    + dataGridView1[2, elem].Value.ToString());
            }

            Save save = new Save(listString);
            save.Show();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Open open = new Open(this);
            open.Show();
        }

        private List<string> listString = new List<string>();
        private string[] arrString = new string[3];
    }
}
