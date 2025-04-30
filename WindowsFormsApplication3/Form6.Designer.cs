namespace WindowsFormsApplication3
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.animDataSet = new WindowsFormsApplication3.animDataSet();
            this.оборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оборудованиеTableAdapter = new WindowsFormsApplication3.animDataSetTableAdapters.ОборудованиеTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication3.animDataSetTableAdapters.TableAdapterManager();
            this.оборудованиеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.оборудованиеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.оборудованиеDataGridView = new System.Windows.Forms.DataGridView();
            this.кодоборудованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.списан = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаприобритенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датасписанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.animDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingNavigator)).BeginInit();
            this.оборудованиеBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // animDataSet
            // 
            this.animDataSet.DataSetName = "animDataSet";
            this.animDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оборудованиеBindingSource
            // 
            this.оборудованиеBindingSource.DataMember = "Оборудование";
            this.оборудованиеBindingSource.DataSource = this.animDataSet;
            // 
            // оборудованиеTableAdapter
            // 
            this.оборудованиеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication3.animDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БалансTableAdapter = null;
            this.tableAdapterManager.БолезньTableAdapter = null;
            this.tableAdapterManager.ЖивотноеTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ОборудованиеTableAdapter = this.оборудованиеTableAdapter;
            this.tableAdapterManager.ПитаниеTableAdapter = null;
            this.tableAdapterManager.ПрививкаTableAdapter = null;
            this.tableAdapterManager.РекламаTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // оборудованиеBindingNavigator
            // 
            this.оборудованиеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.оборудованиеBindingNavigator.BindingSource = this.оборудованиеBindingSource;
            this.оборудованиеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.оборудованиеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.оборудованиеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.оборудованиеBindingNavigatorSaveItem});
            this.оборудованиеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.оборудованиеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.оборудованиеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.оборудованиеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.оборудованиеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.оборудованиеBindingNavigator.Name = "оборудованиеBindingNavigator";
            this.оборудованиеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.оборудованиеBindingNavigator.Size = new System.Drawing.Size(661, 25);
            this.оборудованиеBindingNavigator.TabIndex = 0;
            this.оборудованиеBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // оборудованиеBindingNavigatorSaveItem
            // 
            this.оборудованиеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.оборудованиеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("оборудованиеBindingNavigatorSaveItem.Image")));
            this.оборудованиеBindingNavigatorSaveItem.Name = "оборудованиеBindingNavigatorSaveItem";
            this.оборудованиеBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.оборудованиеBindingNavigatorSaveItem.Text = "Save Data";
            this.оборудованиеBindingNavigatorSaveItem.Click += new System.EventHandler(this.оборудованиеBindingNavigatorSaveItem_Click);
            // 
            // оборудованиеDataGridView
            // 
            this.оборудованиеDataGridView.AutoGenerateColumns = false;
            this.оборудованиеDataGridView.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.оборудованиеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.оборудованиеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодоборудованияDataGridViewTextBoxColumn,
            this.списан,
            this.названиеDataGridViewTextBoxColumn,
            this.датаприобритенияDataGridViewTextBoxColumn,
            this.датасписанияDataGridViewTextBoxColumn});
            this.оборудованиеDataGridView.DataSource = this.оборудованиеBindingSource;
            this.оборудованиеDataGridView.Location = new System.Drawing.Point(12, 28);
            this.оборудованиеDataGridView.Name = "оборудованиеDataGridView";
            this.оборудованиеDataGridView.Size = new System.Drawing.Size(629, 224);
            this.оборудованиеDataGridView.TabIndex = 1;
            // 
            // кодоборудованияDataGridViewTextBoxColumn
            // 
            this.кодоборудованияDataGridViewTextBoxColumn.DataPropertyName = "Код_оборудования";
            this.кодоборудованияDataGridViewTextBoxColumn.HeaderText = "Код_оборудования";
            this.кодоборудованияDataGridViewTextBoxColumn.Name = "кодоборудованияDataGridViewTextBoxColumn";
            // 
            // списан
            // 
            this.списан.DataPropertyName = "списан";
            this.списан.HeaderText = "Списан";
            this.списан.Name = "списан";
            this.списан.Width = 80;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // датаприобритенияDataGridViewTextBoxColumn
            // 
            this.датаприобритенияDataGridViewTextBoxColumn.DataPropertyName = "Дата_приобритения";
            this.датаприобритенияDataGridViewTextBoxColumn.HeaderText = "Дата_приобритения";
            this.датаприобритенияDataGridViewTextBoxColumn.Name = "датаприобритенияDataGridViewTextBoxColumn";
            // 
            // датасписанияDataGridViewTextBoxColumn
            // 
            this.датасписанияDataGridViewTextBoxColumn.DataPropertyName = "Дата_списания";
            this.датасписанияDataGridViewTextBoxColumn.HeaderText = "Дата_списания";
            this.датасписанияDataGridViewTextBoxColumn.Name = "датасписанияDataGridViewTextBoxColumn";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(661, 293);
            this.Controls.Add(this.оборудованиеDataGridView);
            this.Controls.Add(this.оборудованиеBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Оборудование";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingNavigator)).EndInit();
            this.оборудованиеBindingNavigator.ResumeLayout(false);
            this.оборудованиеBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private animDataSet animDataSet;
        private System.Windows.Forms.BindingSource оборудованиеBindingSource;
        private animDataSetTableAdapters.ОборудованиеTableAdapter оборудованиеTableAdapter;
        private animDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator оборудованиеBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton оборудованиеBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView оборудованиеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодоборудованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn списан;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаприобритенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датасписанияDataGridViewTextBoxColumn;
    }
}