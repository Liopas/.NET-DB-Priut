﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void болезньBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.болезньBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.animDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'animDataSet.Болезнь' table. You can move, or remove it, as needed.
            this.болезньTableAdapter.Fill(this.animDataSet.Болезнь);

        }
    }
}
