namespace ComenziPizza
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Pufos");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Crocant");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Clasic");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Special");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFormularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbTopping = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDurata = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBlat = new System.Windows.Forms.ListBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.checkedList = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDurata)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFormularToolStripMenuItem,
            this.xmlToolStripMenuItem,
            this.getDatabaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFormularToolStripMenuItem
            // 
            this.openFormularToolStripMenuItem.Name = "openFormularToolStripMenuItem";
            this.openFormularToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.openFormularToolStripMenuItem.Text = "Open formular";
            this.openFormularToolStripMenuItem.Click += new System.EventHandler(this.openFormularToolStripMenuItem_Click);
            // 
            // xmlToolStripMenuItem
            // 
            this.xmlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.xmlToolStripMenuItem.Text = "Xml";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // getDatabaseToolStripMenuItem
            // 
            this.getDatabaseToolStripMenuItem.Name = "getDatabaseToolStripMenuItem";
            this.getDatabaseToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.getDatabaseToolStripMenuItem.Text = "Get database";
            this.getDatabaseToolStripMenuItem.Click += new System.EventHandler(this.getDatabaseToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbTopping);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbDurata);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbBlat);
            this.panel1.Controls.Add(this.tbNume);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 140);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTopping
            // 
            this.tbTopping.Location = new System.Drawing.Point(546, 57);
            this.tbTopping.Name = "tbTopping";
            this.tbTopping.Size = new System.Drawing.Size(207, 20);
            this.tbTopping.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Topping";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Durata";
            // 
            // tbDurata
            // 
            this.tbDurata.Location = new System.Drawing.Point(546, 3);
            this.tbDurata.Name = "tbDurata";
            this.tbDurata.Size = new System.Drawing.Size(120, 20);
            this.tbDurata.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Blat";
            // 
            // tbBlat
            // 
            this.tbBlat.FormattingEnabled = true;
            this.tbBlat.Items.AddRange(new object[] {
            "Pufos",
            "Crocant",
            "Clasic",
            "Special"});
            this.tbBlat.Location = new System.Drawing.Point(49, 47);
            this.tbBlat.Name = "tbBlat";
            this.tbBlat.Size = new System.Drawing.Size(120, 56);
            this.tbBlat.TabIndex = 2;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(49, 4);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(134, 20);
            this.tbNume.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(13, 174);
            this.treeView.Name = "treeView";
            treeNode13.Name = "Node0";
            treeNode13.Text = "Pufos";
            treeNode14.Name = "Node1";
            treeNode14.Text = "Crocant";
            treeNode15.Name = "Node2";
            treeNode15.Text = "Clasic";
            treeNode16.Name = "Node3";
            treeNode16.Text = "Special";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            this.treeView.Size = new System.Drawing.Size(169, 247);
            this.treeView.TabIndex = 2;
            // 
            // checkedList
            // 
            this.checkedList.FormattingEnabled = true;
            this.checkedList.Location = new System.Drawing.Point(559, 174);
            this.checkedList.Name = "checkedList";
            this.checkedList.Size = new System.Drawing.Size(207, 184);
            this.checkedList.TabIndex = 3;
            this.checkedList.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Adauga buton";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 433);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkedList);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDurata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFormularToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox tbBlat;
        private System.Windows.Forms.TextBox tbTopping;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tbDurata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDatabaseToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox checkedList;
        private System.Windows.Forms.Button button2;
    }
}