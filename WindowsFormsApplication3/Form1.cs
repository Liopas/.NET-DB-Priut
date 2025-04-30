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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 myform2 = new Form2();
            myform2.Show();
        }

        private void преподователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 myform3 = new Form3();
            myform3.Show();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 myform4 = new Form4();
            myform4.Show();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 myform5 = new Form5();
            myform5.Show();
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 myform6 = new Form6();
            myform6.Show();
        }

        private void питаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 myform7 = new Form7();
            myform7.Show();
        }

        private void прививкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 myform8 = new Form8();
            myform8.Show();
        }

        private void рекламаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 myform9 = new Form9();
            myform9.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 myform10 = new Form10();
            myform10.Show();
        }

        private void оРасходахНаПериодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 myform13 = new Form13();
            myform13.Show();
        }

      

        private void sssToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    }

