using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_practice
{
    public partial class Form1 : Form
    {
        DataTable data = new DataTable();
        int edit;
        public Form1()
        {
            InitializeComponent();

            data.Columns.Add("Name");
            data.Columns.Add("id");
            data.Columns.Add("age");
            data.Columns.Add("gender");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataRow row1 = data.NewRow();

            row1["Name"] = textBox1.Text;
            row1["id"] = textBox2.Text;
            row1["age"] = textBox3.Text;
            row1["gender"] = textBox4.Text;
            data.Rows.Add(row1);

            dataGridView1.DataSource = data;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowdel = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowdel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow newrow = dataGridView1.Rows[edit];

            newrow.Cells[0].Value = textBox1.Text;
            newrow.Cells[1].Value = textBox2.Text;
            newrow.Cells[2].Value = textBox3.Text;
            newrow.Cells[3].Value = textBox4.Text;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edit = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[edit];

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            
        }
    }
}
