using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyLib.Class1;
using System.IO;

namespace sippo
{
    public partial class Form1 : Form
    {
        private List<Item> items;

        public Form1()
        {
            InitializeComponent();

            AddItems();
            ShowItems1(items);
        }

        private void AddItems()
        {
            items = new List<Item>();

            /*items.Add(new Item(1, 1, 600));
            items.Add(new Item(2, 2, 5000));
            items.Add(new Item(3, 4, 1500));
            items.Add(new Item(4, 2, 40000));
            items.Add(new Item(5, 1, 500));*/
        }

        /*private void ShowItems(List<Item> _items)
        {
            itemsListView.Items.Clear();

            foreach (Item i in _items)
            {
                itemsListView.Items.Add(new ListViewItem(new string[] { i.num.ToString(), i.weigth.ToString(),
                    i.price.ToString() }));
            }
        }*/

        private void ShowItems1(List<Item> _items)
        {
            listView1.Items.Clear();

            foreach (Item i in _items)
            {
                listView1.Items.Add(new ListViewItem(new string[] { i.num.ToString(), i.weigth.ToString(),
                    i.price.ToString() }));
            }
        }

        private void ShowItems2(List<Item> _items)
        {
            listView2.Items.Clear();

            foreach (Item i in _items)
            {
                listView2.Items.Add(new ListViewItem(new string[] { i.num.ToString(), i.weigth.ToString(),
                    i.price.ToString() }));
            }
        }
        /*
        //показать исходные данные
        private void ShowConditionsButton_Click(object sender, EventArgs e)
        {
            ShowItems(items);
        }

        //решить задачу
        private void solveButton_Click(object sender, EventArgs e)
        {
            Backpack bp = new Backpack(Convert.ToInt32(weightTextBox.Text));

            bp.MakeAllSets(items);

            List<Item> solve = bp.GetBestSet();

            if (solve == null)
            {
                MessageBox.Show("Нет решения!");
            }
            else
            {
                itemsListView.Items.Clear();

                ShowItems(solve);

                MessageBox.Show("Решение приведено в таблице");
            }
        }

        //ввести данные в ручную
        private void button1_Click(object sender, EventArgs e)
        {
            ok.Text = "";
            items = new List<Item>();
            String str = textBox1.Text;
            String[] strWithout = str.Split(' ');
            if (strWithout.Length % 2 == 0)
            {
                for (int i = 0; i < strWithout.Length / 2; i++)
                {

                    items.Add(new Item(i + 1, int.Parse(strWithout[i + i]), int.Parse(strWithout[i + i + 1])));
                }
            }
            else
            {
                ok.Text = "Некоректный ввод!";
            }
            
            ShowItems(items);
        }

        //ввод данных из файла
        private void button2_Click(object sender, EventArgs e)
        {
            ok.Text = "";
            items = new List<Item>();
            try
            {
                String line = File.ReadAllText("D:\\Учёба\\Информатика\\СИППО\\sippo\\" + textBox2.Text);
                //ok.Text = line;
                String[] strWithout = line.Split(' ');
                if (strWithout.Length % 2 != 0)
                {
                    for (int i = 0; i < (strWithout.Length - 1) / 2; i++)
                    {

                        items.Add(new Item(i + 1, int.Parse(strWithout[i + i]), int.Parse(strWithout[i + i + 1])));
                    }
                    weightTextBox.Clear();
                    weightTextBox.Text = strWithout[strWithout.Length - 1];
                }
                else
                {
                    ok.Text = "Некоректный ввод!";
                }

                ShowItems(items);
            }
            catch (Exception E)
            {
                ok.Text = "Некоректный ввод!";
            }
            
        }*/

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Backpack bp = new Backpack(Convert.ToInt32(textBox3.Text));

            bp.MakeAllSets(items);

            List<Item> solve = bp.GetBestSet();

            if (solve == null)
            {
                MessageBox.Show("Нет решения!");
            }
            else
            {
                listView2.Items.Clear();

                ShowItems2(solve);

                MessageBox.Show("Решение приведено в таблице");
            }
        }

        //ввести данные в ручную
        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            items = new List<Item>();
            String str = textBox4.Text;
            String[] strWithout = str.Split(' ');
            if (strWithout.Length % 2 == 0)
            {
                for (int i = 0; i < strWithout.Length / 2; i++)
                {

                    items.Add(new Item(i + 1, int.Parse(strWithout[i + i]), int.Parse(strWithout[i + i + 1])));
                }
            }
            else
            {
                label7.Text = "Некоректный ввод!";
            }

            ShowItems1(items);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            items = new List<Item>();
            try
            {
                String line = File.ReadAllText("D:\\Учёба\\Информатика\\СИППО\\sippo\\" + textBox5.Text);
                //ok.Text = line;
                String[] strWithout = line.Split(' ');
                if (strWithout.Length % 2 != 0)
                {
                    for (int i = 0; i < (strWithout.Length - 1) / 2; i++)
                    {

                        items.Add(new Item(i + 1, int.Parse(strWithout[i + i]), int.Parse(strWithout[i + i + 1])));
                    }
                    textBox3.Clear();
                    textBox3.Text = strWithout[strWithout.Length - 1];
                }
                else
                {
                    label7.Text = "Некоректный ввод!";
                }

                ShowItems1(items);
            }
            catch (Exception E)
            {
                label7.Text = "Некоректный ввод!";
            }
        }
    }
}
