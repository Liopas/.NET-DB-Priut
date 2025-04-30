using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'animDataSet.Животное' table. You can move, or remove it, as needed.
            this.ЖивотноеTableAdapter.Fill(this.animDataSet.Животное);
            // TODO: This line of code loads data into the 'animDataSet.Баланс' table. You can move, or remove it, as needed.
            this.БалансTableAdapter.Fill(this.animDataSet.Баланс);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            БалансBindingSource.Filter = "  Дата >= '" + dateTimePicker1.Value.ToShortDateString() + "' and Дата <='" + dateTimePicker2.Value.ToShortDateString() + "'";
            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
