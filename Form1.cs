using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_12
{
    public partial class Form1 : Form
    {
        List<ProductionWorker> productionWorkers = new List<ProductionWorker>();
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 3)
            {
                MessageBox.Show("Please enter correct name");
                return;
            }
            int number = int.Parse(numericUpDown1.Value.ToString());
            int shift_number = int.Parse(numericUpDown2.Value.ToString());
            ProductionWorker worker = new ProductionWorker(textBox1.Text, number, shift_number, numericUpDown3.Value);
            productionWorkers.Add(worker);
            textBox1.Text = "";
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value = 0;
            MessageBox.Show("Added to list");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            productionWorkers.ForEach((worker) => listBox1.Items.Add($"{worker.Number}: {worker.Name}, {worker.get_shift_number_value()}, {worker.Hourly_part_rate:C}"));
        }
    }
}
