using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SetLib;

namespace Task
{
    public partial class Form1 : Form
    {
        Set setA = new Set();
        Set setB = new Set();

        public Form1()
        {
            InitializeComponent();
        }

        private void BttnEnterSet1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num))
            {
                setA += num;
                MessageBox.Show("Элемент добавлен во множество А.", "Результат");
            }
            else
            {
                MessageBox.Show("Неверный ввод элемента в множество А.", "Ошибка");
            }
            textBox1.Clear();
        }

        private void bttnEnterSet2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int num))
            {
                setB += num;
                MessageBox.Show("Элемент добавлен во множество Б.", "Результат");
            }
            else
            {
                MessageBox.Show("Неверный ввод элемента в множество Б.", "Ошибка");
            }
            textBox2.Clear();
        }

        private void BttnUnionSets_Click(object sender, EventArgs e)
        {
            Set unionSets = setA + setB;

            MessageBox.Show($"Объединенное множетсво: {string.Join("; ", unionSets.elements)}", "Результат");
        }

        private void BttnFindUnionSets_Click(object sender, EventArgs e)
        {
            Set findUnionSets = setA * setB;
            MessageBox.Show($"Пересеченное множетсво: {string.Join("; ", findUnionSets.elements)}", "Результат");
        }

        private void BttnPowerSets_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Узнать мощность множетсва А? Да (множество А), Нет (множество Б)", "Результат", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                MessageBox.Show($"Мощность множества А: {(int)setA}", "Результат");
            else
                MessageBox.Show($"Мощность множества Б: {(int)setB}", "Результат");
        }

        private void BttnShowSets_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Множество A: {string.Join("; ", setA.elements)}\nМножество B: {string.Join("; ", setB.elements)}", "Множества");
        }
    }
}
