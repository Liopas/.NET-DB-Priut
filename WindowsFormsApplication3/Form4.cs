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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void балансBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.балансBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.animDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'animDataSet.Баланс' table. You can move, or remove it, as needed.
            this.балансTableAdapter.Fill(this.animDataSet.Баланс);

        }
    }
}
