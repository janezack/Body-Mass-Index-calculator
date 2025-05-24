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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "проектDataSet6.ИМТ_и_тд_клиента". При необходимости она может быть перемещена или удалена.
            this.иМТ_и_тд_клиентаTableAdapter.Fill(this.проектDataSet6.ИМТ_и_тд_клиента);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "проектDataSet1.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.проектDataSet1.Клиент);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            клиентTableAdapter.Update(проектDataSet1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 af = new Form5();
            af.Owner = this;
            af.Show();
        }

        
    }
}
