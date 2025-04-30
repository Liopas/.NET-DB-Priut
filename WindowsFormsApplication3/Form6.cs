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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void оборудованиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оборудованиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.animDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'animDataSet.Оборудование' table. You can move, or remove it, as needed.
            this.оборудованиеTableAdapter.Fill(this.animDataSet.Оборудование);

        }
    }
}
