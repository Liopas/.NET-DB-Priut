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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void питаниеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.питаниеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.animDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'animDataSet.Питание' table. You can move, or remove it, as needed.
            this.питаниеTableAdapter.Fill(this.animDataSet.Питание);

        }
    }
}
