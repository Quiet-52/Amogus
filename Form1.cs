using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;int[,]a= new int [3,3];int i,j;
            Random rand = new Random();
            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                    a[i, j] = rand.Next(-100, 100);
            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
            // на дополнительной диагонали
            int m = int.MinValue;
            for (i = 0; i < 3; i++)
                
            // выводим результат
            textBox1.Text = Convert.ToString(m);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
