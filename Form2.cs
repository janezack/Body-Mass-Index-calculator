using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Janelastone
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "проектDataSet.Запись_к_диетологу". При необходимости она может быть перемещена или удалена.
            this.запись_к_диетологуTableAdapter.Fill(this.проектDataSet.Запись_к_диетологу);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 af = new Form3();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) { Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 af = new Form4();
            af.Owner = this;
            af.Show();
        }

       

        //private void button4_Click(object sender, EventArgs e)
        //{
        //   запись_к_диетологуTableAdapter.Update(проектDataSet);
        //}
    }
}
