namespace WindowsFormsApplication3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.питаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прививкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рекламаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРасходахНаПериодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.отчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.группыToolStripMenuItem,
            this.преподователиToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.клиентToolStripMenuItem,
            this.оборудованиеToolStripMenuItem,
            this.питаниеToolStripMenuItem,
            this.прививкаToolStripMenuItem,
            this.рекламаToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // группыToolStripMenuItem
            // 
            this.группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            this.группыToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.группыToolStripMenuItem.Text = "Животные";
            this.группыToolStripMenuItem.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // преподователиToolStripMenuItem
            // 
            this.преподователиToolStripMenuItem.Name = "преподователиToolStripMenuItem";
            this.преподователиToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.преподователиToolStripMenuItem.Text = "Болезни";
            this.преподователиToolStripMenuItem.Click += new System.EventHandler(this.преподователиToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.должностиToolStripMenuItem.Text = "Баланс";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.клиентToolStripMenuItem.Text = "Клиент";
            this.клиентToolStripMenuItem.Click += new System.EventHandler(this.клиентToolStripMenuItem_Click);
            // 
            // оборудованиеToolStripMenuItem
            // 
            this.оборудованиеToolStripMenuItem.Name = "оборудованиеToolStripMenuItem";
            this.оборудованиеToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.оборудованиеToolStripMenuItem.Text = "Оборудование";
            this.оборудованиеToolStripMenuItem.Click += new System.EventHandler(this.оборудованиеToolStripMenuItem_Click);
            // 
            // питаниеToolStripMenuItem
            // 
            this.питаниеToolStripMenuItem.Name = "питаниеToolStripMenuItem";
            this.питаниеToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.питаниеToolStripMenuItem.Text = "Питание";
            this.питаниеToolStripMenuItem.Click += new System.EventHandler(this.питаниеToolStripMenuItem_Click);
            // 
            // прививкаToolStripMenuItem
            // 
            this.прививкаToolStripMenuItem.Name = "прививкаToolStripMenuItem";
            this.прививкаToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.прививкаToolStripMenuItem.Text = "Прививка";
            this.прививкаToolStripMenuItem.Click += new System.EventHandler(this.прививкаToolStripMenuItem_Click);
            // 
            // рекламаToolStripMenuItem
            // 
            this.рекламаToolStripMenuItem.Name = "рекламаToolStripMenuItem";
            this.рекламаToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.рекламаToolStripMenuItem.Text = "Реклама";
            this.рекламаToolStripMenuItem.Click += new System.EventHandler(this.рекламаToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оРасходахНаПериодToolStripMenuItem});
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            // 
            // оРасходахНаПериодToolStripMenuItem
            // 
            this.оРасходахНаПериодToolStripMenuItem.Name = "оРасходахНаПериодToolStripMenuItem";
            this.оРасходахНаПериодToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.оРасходахНаПериодToolStripMenuItem.Text = "О расходах и балансе";
            this.оРасходахНаПериодToolStripMenuItem.Click += new System.EventHandler(this.оРасходахНаПериодToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.dogO;
            this.ClientSize = new System.Drawing.Size(425, 257);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оборудованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem питаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прививкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рекламаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРасходахНаПериодToolStripMenuItem;
    }
}

