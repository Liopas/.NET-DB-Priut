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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void рекламаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рекламаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.animDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'animDataSet.Реклама' table. You can move, or remove it, as needed.
            this.рекламаTableAdapter.Fill(this.animDataSet.Реклама);

        }
    }
}
