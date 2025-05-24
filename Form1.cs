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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Form2 glav = new Form2();
            if (textBox1.Text == "dietolog" && textBox2.Text == "123456")
            {
                MessageBox.Show("Недостаток веса может стать причиной нарушения водно-солевого баланса в организме, " +
                           "гормональных сбоев, нарушения обмена веществ, авитаминоза и так далее." +
                           " А избыточный - негативно влияет на работу опорно-двигательного аппарата, " +
                           "сердечно-сосудистой системы. Поэтому важно следить за своим ИМТ. " +
                           "Если по прогнозам нашей программы обнаружились проблемы со здоровьем тогда пожалуйста обязательно посоветуйтесь с близкими и с врачом." +
                           " НЕ СТОИТ решать эти проблемы самому без совета врачей.  " +
                           "Для оценки полученного параметра ИМТ используется таблица," +
                           " утвержденная Всемирной организацией здравоохранения еще в 1997 г.," +
                           " так что пожалуйста обратите внимание на нашим советам и предупреждениям. ", "Внимание!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                glav.ShowDialog();
                Application.Exit();
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Wrong answer! please try again");
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) { Application.Exit(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.textBox1, "Vvedite login");
            ToolTip toolTip2 = new ToolTip();
            toolTip2.SetToolTip(this.textBox2, "Vvedite parol");
            ToolTip toolTip3 = new ToolTip();
            toolTip3.SetToolTip(this.button1, "Nazhmite...");
        }
    }
}
