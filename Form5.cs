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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
       

    

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "проектDataSet4.Запись_к_диетологу". При необходимости она может быть перемещена или удалена.
            this.запись_к_диетологуTableAdapter1.Fill(this.проектDataSet4.Запись_к_диетологу);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "проектDataSet3.Запись_к_диетологу". При необходимости она может быть перемещена или удалена.
            this.запись_к_диетологуTableAdapter.Fill(this.проектDataSet3.Запись_к_диетологу);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 main = this.Owner as Form4;
            if (main != null)
            {
                DataRow nRow = main.проектDataSet1.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = listBox1.Text;
                nRow[2] = listBox2.Text;
                nRow[3] = textBox1.Text;
                nRow[4] = textBox2.Text;
                nRow[5] = textBox3.Text;
                nRow[6] = textBox4.Text;
                nRow[7] = textBox5.Text;
                nRow[8] = textBox6.Text;
                nRow[9] = textBox7.Text;
                main.проектDataSet1.Tables[0].Rows.Add(nRow);
                main.проектDataSet1.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox4.Text == "") || (textBox3.Text == "") || (textBox5.Text == "") || (textBox6.Text == "") || (textBox7.Text == "") || ((radioButton1.Checked == false) && (radioButton2.Checked == false)) || ((radioButton3.Checked == false) && (radioButton4.Checked == false) && (radioButton5.Checked == false)) || ((radioButton6.Checked == false) && (radioButton7.Checked == false)))
                { MessageBox.Show("Проверьте на все ли вопросы вы ответили!", "Ошибка о незаполненых полях"); }
                else
                {

                    if ((Convert.ToSingle(textBox1.Text) < 0) || ((Convert.ToSingle(textBox1.Text) > 300)))
                    {
                        MessageBox.Show("Вы написали невозможные параметры", "Ошибка");
                    }
                    if ((Convert.ToSingle(textBox1.Text) < 0) || ((Convert.ToSingle(textBox1.Text) > 300)))
                    {
                        MessageBox.Show("Вы написали невозможные параметры", "Ошибка");
                    }
                    if ((Convert.ToSingle(textBox2.Text) < 0) || ((Convert.ToSingle(textBox2.Text) > 300)))
                    {
                        MessageBox.Show("Вы написали невозможные параметры", "Ошибка");
                    }
                    if ((Convert.ToSingle(textBox3.Text) < 0) || ((Convert.ToSingle(textBox3.Text) > 300)))
                    {
                        MessageBox.Show("Вы написали невозможные параметры", "Ошибка");
                    }
                    if ((Convert.ToSingle(textBox5.Text) < 0) || ((Convert.ToSingle(textBox5.Text) > 300)))
                    {
                        MessageBox.Show("Вы написали невозможные параметры", "Ошибка");
                    }
                    if ((Convert.ToSingle(textBox6.Text) < 0) || ((Convert.ToSingle(textBox6.Text) > 300)))
                    {
                        MessageBox.Show("Вы написали невозможные параметры", "Ошибка");
                    }
                    if ((Convert.ToSingle(textBox7.Text) < 0) || ((Convert.ToSingle(textBox7.Text) > 300)))
                    {
                        MessageBox.Show("Вы написали невозможные параметры", "Ошибка");
                    }

                }
                double m, h, c, t, o, p1 = 0, b, m1, t1, z, pp, a, s = 0;
                m = Convert.ToSingle(textBox2.Text);
                h = Convert.ToSingle(textBox1.Text);
                t = Convert.ToSingle(textBox3.Text);
                b = Convert.ToSingle(textBox4.Text) * 0.394;
                m1 = Convert.ToSingle(textBox2.Text) * 2.203;
                t1 = Convert.ToSingle(textBox3.Text) * 0.394;
                z = Convert.ToSingle(textBox5.Text) * 0.394;
                pp = Convert.ToSingle(textBox6.Text) * 0.394;
                a = Convert.ToSingle(textBox7.Text);
                c = m / h / h * 10000;
                o = t / h;
                if (radioButton6.Checked == true)
                {
                    if (radioButton2.Checked == true)
                    {
                        p1 = (-0.082 * m1 + 4.15 * t1 - 94.42) / m1 * 100;
                        s = m * (100 - p1) / 100;
                    }

                    if (radioButton1.Checked == true)
                    {
                        p1 = (0.268 * m1 - 0.318 * z + 0.157 * t1 + 0.245 * b - 0.434 * pp - 8.987) / m1 * 100;
                        s = m * (100 - p1) / 100;
                    }

                }


                if (radioButton7.Checked == true)
                {

                    if (radioButton1.Checked == true)
                    {
                        p1 = 1.39 * c + 0.16 * a - 9;
                        s = m * (100 - p1) / 100;

                    }
                    if (radioButton2.Checked == true)
                    {
                        p1 = 1.39 * c + 0.16 * a - 19.34;
                        s = m * (100 - p1) / 100;
                    }
                }


                if (c <= 16)
                { c = 1; }
                if ((c > 16) && (c < 18.5))
                { c = 2; }
                if ((c < 25) && (c >= 18.5))
                { c = 3; }
                if ((c >= 25) && (c < 30))
                { c = 3; }
                if ((c >= 30) && (c < 35))
                { c = 4; }
                if ((c >= 35) && (c < 40))
                { c = 5; }
                if (c >= 40)
                { c = 6; }
                string lb20, lb21, lb22;
                lb20 = ""; lb21 = ""; lb22 = "";
                switch (c)
                {
                    case 1:
                    case 2:
                        lb20 = "У вас Низкий  риск сопутствующих заболеваний (но повышен риск других заболеваний), " +
                                        " Следует проконсультироваться со специалистом, " +
                                        "так же  при отсутствии заболеваний следует обратить внимание на свое питание в сторону увеличения калорийности  рациона.  ";
                        break;
                    case 3:
                        lb20 = "Старайтесь удерживать вес в этих рамках,  " +
                                         "Рисков, связанных с ожирением нет,  " +
                                         "вес находится в пределах физиологической нормы и беспокоиться вам не о чем.  ";
                        break;
                    case 4:
                    case 5:
                        lb20 = "Этот ИМТ говорит  О  наличии лишнего веса, " +
                                         "стоит пересмотреть рацион и заняться зарядкой," +
                                         " у вас повышенный риск сопутствующих заболеваний.  ";
                        break;

                    case 6:
                        lb20 = "У вас вероятность развития осложнений. " +
                                         "Стоит худеть под контролем специалиста,  " +
                                         "Высокий  риск сопутствующих заболеваний.  ";
                        break;

                }

                if (radioButton2.Checked == true)
                {
                    if (p1 <= 4)
                    {
                        lb21 = "У вас Существенный жир." +
                              "У вас маленькое количество жира в организме " +
                              "советуем следить за своим питанием и" +
                              " больше есть питательных продуктов.";
                    }
                    if ((p1 > 4) && (p1 <= 13))
                    {
                        lb21 = "У вас уровень Спортсмены." +
                              " Такой процент жира в большинство случаев соответствует спортсменам," +
                              " если хотите его поддерживать стоит побороть лень и больше заниматься .";
                    }
                    if ((p1 > 13) && (p1 <= 17))
                    {
                        lb21 = "У вас Средний уровень жира. Не стоит утруждаться, " +
                              "этот процент считается средним, поэтому пытайтесь поддерживать его.";
                    }
                    if ((p1 > 17) && (p1 <= 25))
                    {
                        lb21 = "Такой процент жира считается приемлемым," +
                              " все же стоит следить за своим питанием и немного ограничить его";
                    }
                    if (p1 > 25)
                    {
                        lb21 = "в таком проценте жира стоит обратиться к диетологу " +
                              "и по его советовам действовать обдуманно. " +
                              "Не стоит заниматься самому  вам будет лучше если наймете тренера. ";
                    }
                }
                if (radioButton1.Checked == true)
                {
                    if (p1 <= 12)
                    {
                        lb21 = "У вас маленькое количество жира в организме советуем следить за " +
                              "своим питанием и больше есть питательных продуктов.";
                    }
                    if ((p1 > 12) && (p1 <= 20))
                    {
                        lb21 = "Такой процент жира в большинство случаев соответствует спортсменам, " +
                              "если хотите его поддерживать стоит побороть лень и больше заниматься .";
                    }
                    if ((p1 > 20) && (p1 <= 24))
                    {
                        lb21 = "Не стоит утруждаться, этот процент жира считается средним," +
                              " поэтому пытайтесь поддерживать его.";
                    }
                    if ((p1 > 24) && (p1 <= 31))
                    {
                        lb21 = "Такой процент жира считается приемлемым," +
                              "все же стоит следить за своим питанием и немного ограничить его.";
                    }
                    if (p1 > 31)
                    {
                        lb21 = "Стоит обратиться к диетологу и по его советовам действовать обдуманно. " +
                              "Не стоит заниматься самому  вам будет лучше если наймете тренера. ";
                    }
                }

                if (radioButton3.Checked == true)
                {
                    lb22 = "Так как у вас сидячий образ жизни у вас могут возникнутьи другие но менее заметные заболевание. Поэтому вам стоит быть активнее и больше заниматься!";
                }
                if (radioButton4.Checked == true)
                {
                    lb22 = "не стоит терять этот темп и было бы еще лучше если вы начнете вести активный образ жизни. ";
                }
                if (radioButton5.Checked == true)
                {
                    lb22 = "Продолжайте в этом духе! Желаем удачи! ";
                }



                Form4 glav = this.Owner as Form4;
                if (main != null)
                {
                    DataRow nRow = glav.проектDataSet6.Tables[0].NewRow();
                    int rc = glav.dataGridView1.RowCount + 1;
                    nRow[0] = rc;
                    nRow[1] = listBox1.Text;
                    nRow[2] = listBox2.Text;
                    nRow[3] = Convert.ToString(c); ;
                    nRow[4] = Convert.ToString(o);
                    nRow[5] = Convert.ToString(p1);
                    nRow[6] = Convert.ToString(s);
                    nRow[7] = lb20 + lb21 + lb22;
                    glav.проектDataSet6.Tables[0].Rows.Add(nRow);
                    glav.проектDataSet1.Tables[0].AcceptChanges();
                    glav.dataGridView1.Refresh();
                }
                Form4 af = new Form4();
                af.Owner = this;
                af.Show();
            }
        }
    }
}

        
