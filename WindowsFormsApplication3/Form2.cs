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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void животноеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.животноеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.animDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'animDataSet.Прививка' table. You can move, or remove it, as needed.
            this.прививкаTableAdapter.Fill(this.animDataSet.Прививка);
            // TODO: This line of code loads data into the 'animDataSet.Питание' table. You can move, or remove it, as needed.
            this.питаниеTableAdapter.Fill(this.animDataSet.Питание);
            // TODO: This line of code loads data into the 'animDataSet.Клиент' table. You can move, or remove it, as needed.
            this.клиентTableAdapter.Fill(this.animDataSet.Клиент);
            // TODO: This line of code loads data into the 'animDataSet.Болезнь' table. You can move, or remove it, as needed.
            this.болезньTableAdapter.Fill(this.animDataSet.Болезнь);
            // TODO: This line of code loads data into the 'animDataSet.Животное' table. You can move, or remove it, as needed.
            this.животноеTableAdapter.Fill(this.animDataSet.Животное);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.животноеBindingSource.EndEdit();
            this.животноеTableAdapter.Update(this.animDataSet.Животное);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            животноеBindingSource.Filter = "[Порода] like'" + textBox2.Text + "%'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            животноеBindingSource.Filter = "";
            textBox2.Text = "";
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox6.Text )
            {
                case "Кто нашел":
                    {
                        животноеBindingSource.Filter = "[Кто_нашел] like'" + textBox2.Text + "%'"; ;
                        break;
                    }
                case "Местонахождение":
                    {
                        животноеBindingSource.Filter = "[Местонахождение] like'" + textBox2.Text + "%'";
                        break;
                    }
                case "Тип":
                    {
                        животноеBindingSource.Filter = "[Тип] like'" + textBox2.Text + "%'";
                        break;
                    }
                case "Окрас":
                    {
                        животноеBindingSource.Filter = "[Окрас] like'" + textBox2.Text + "%'";
                        break;
                    }
                case "Порода":
                    {
                        животноеBindingSource.Filter = "[Порода] like'" + textBox2.Text + "%'";
                        break;
                    }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            животноеBindingSource.Filter = "  Дата >= '" + dateTimePicker1.Value.ToShortDateString() + "' and Дата <='" + dateTimePicker2.Value.ToShortDateString() + "'";
        }
    }
}
