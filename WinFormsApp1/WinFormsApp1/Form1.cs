using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string order = "";
        int sum = 0;
        int number = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Добавление заказа
        {
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                ListViewItem item = new ListViewItem(textBox3.Text);

                listView1.Items.Add(item);

                int id = listView1.Items.Count;

                string order = id.ToString();

                item.SubItems.Add(order);
                item.SubItems.Add("в корзине");

                if (listView1.Items.Count > 0)
                {
                    sum = sum + 200;

                }

                string sumtext = sum.ToString();
                if (listView1.Items.Count > 0)
                    label2.Text = sumtext;

                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Заполните поле для добавления заказа", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // Текст для заказа 
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Индекс заказа для удаления 
        {

        }

        private void button2_Click(object sender, EventArgs e) // Удаление заказа 
        {
            if (listView1.Items.Count > 0)
            {
                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    if (listView1.Items.Count > int.Parse(textBox2.Text))
                    {
                        listView1.Items.RemoveAt(int.Parse(textBox2.Text));
                        textBox2.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Введите существующий индекс заказа для удаления, отсчет начинается с 0", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните поле для удаления заказа", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Добавьте хотя бы один заказ для удаления", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Индекс заказа для замены
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) // Заказ для замены
        {

        }

        private void button3_Click(object sender, EventArgs e) // Редактировать
        {
            if (listView1.Items.Count > 0)
            {
                if ((!string.IsNullOrWhiteSpace(textBox1.Text)) && (!string.IsNullOrWhiteSpace(textBox4.Text)))
                {
                    if (listView1.Items.Count > int.Parse(textBox1.Text))
                    {
                        listView1.Items[int.Parse(textBox1.Text)].Text = textBox4.Text;

                        textBox1.Clear();
                        textBox4.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Введите существующий индекс заказа для редактирования, отсчет начинается с 0", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Clear();
                        textBox4.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните оба поля для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox4.Clear();
                }
            }
            else
            {
                MessageBox.Show("Добавьте хотя бы один заказ для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox4.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e) // Оплатить заказ
        {
            int count = listView1.Items.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    order = listView1.Items[i].Text;
                    ListViewItem item = new ListViewItem(order);
                    listView2.Items.Add(item);
                    string a = (number).ToString();
                    number++;
                    item.SubItems.Add(a);
                    item.SubItems.Add("оплачено");
                }
                sum = 0;
                string sumtext = sum.ToString();
                label2.Text = sumtext;

                listView1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Добавьте хотя бы один заказ", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}