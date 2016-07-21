namespace CaseteVideo
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adauga = new System.Windows.Forms.Button();
            this.btnInchiriaza = new System.Windows.Forms.Button();
            this.btnSalveazaFisier = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inchiriazaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.returneazaCasetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SkyBlue;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(741, 217);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 32;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Titlu";
            this.columnHeader2.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Aparitiei";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Durata";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pret";
            this.columnHeader5.Width = 78;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Inchiriata";
            this.columnHeader6.Width = 67;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Numar Zile";
            this.columnHeader7.Width = 87;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Note Critici";
            this.columnHeader8.Width = 117;
            // 
            // Adauga
            // 
            this.Adauga.Location = new System.Drawing.Point(13, 254);
            this.Adauga.Name = "Adauga";
            this.Adauga.Size = new System.Drawing.Size(145, 50);
            this.Adauga.TabIndex = 1;
            this.Adauga.Text = "Adauga Caseta Video";
            this.Adauga.UseVisualStyleBackColor = true;
            this.Adauga.Click += new System.EventHandler(this.Adauga_Click);
            // 
            // btnInchiriaza
            // 
            this.btnInchiriaza.Location = new System.Drawing.Point(162, 254);
            this.btnInchiriaza.Name = "btnInchiriaza";
            this.btnInchiriaza.Size = new System.Drawing.Size(145, 50);
            this.btnInchiriaza.TabIndex = 2;
            this.btnInchiriaza.Text = "Inchiriaza Caseta Video";
            this.btnInchiriaza.UseVisualStyleBackColor = true;
            this.btnInchiriaza.Click += new System.EventHandler(this.btnInchiriaza_Click);
            // 
            // btnSalveazaFisier
            // 
            this.btnSalveazaFisier.Location = new System.Drawing.Point(608, 254);
            this.btnSalveazaFisier.Name = "btnSalveazaFisier";
            this.btnSalveazaFisier.Size = new System.Drawing.Size(145, 50);
            this.btnSalveazaFisier.TabIndex = 3;
            this.btnSalveazaFisier.Text = "Salveaza Casetele in Fisier";
            this.btnSalveazaFisier.UseVisualStyleBackColor = true;
            this.btnSalveazaFisier.Click += new System.EventHandler(this.btnSalveazaFisier_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.bazaDeDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveToolStripMenuItem.Text = "Serializare";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Deserializare";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem1,
            this.inchiriazaToolStripMenuItem1,
            this.returneazaCasetaToolStripMenuItem,
            this.sortToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // adaugaToolStripMenuItem1
            // 
            this.adaugaToolStripMenuItem1.Name = "adaugaToolStripMenuItem1";
            this.adaugaToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.adaugaToolStripMenuItem1.Text = "Adauga Caseta";
            this.adaugaToolStripMenuItem1.Click += new System.EventHandler(this.adaugaToolStripMenuItem1_Click);
            // 
            // inchiriazaToolStripMenuItem1
            // 
            this.inchiriazaToolStripMenuItem1.Name = "inchiriazaToolStripMenuItem1";
            this.inchiriazaToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.inchiriazaToolStripMenuItem1.Text = "Inchiriaza Caseta";
            this.inchiriazaToolStripMenuItem1.Click += new System.EventHandler(this.inchiriazaToolStripMenuItem1_Click);
            // 
            // returneazaCasetaToolStripMenuItem
            // 
            this.returneazaCasetaToolStripMenuItem.Name = "returneazaCasetaToolStripMenuItem";
            this.returneazaCasetaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.returneazaCasetaToolStripMenuItem.Text = "Returneaza Caseta";
            this.returneazaCasetaToolStripMenuItem.Click += new System.EventHandler(this.returneazaCasetaToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sortToolStripMenuItem.Text = "Sorteaza Casete";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // bazaDeDateToolStripMenuItem
            // 
            this.bazaDeDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incarcaDateToolStripMenuItem});
            this.bazaDeDateToolStripMenuItem.Name = "bazaDeDateToolStripMenuItem";
            this.bazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.bazaDeDateToolStripMenuItem.Text = "Baza de date";
            // 
            // incarcaDateToolStripMenuItem
            // 
            this.incarcaDateToolStripMenuItem.Name = "incarcaDateToolStripMenuItem";
            this.incarcaDateToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.incarcaDateToolStripMenuItem.Text = "Insereaza Data in Baza de Date";
            this.incarcaDateToolStripMenuItem.Click += new System.EventHandler(this.incarcaDateToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Location = new System.Drawing.Point(763, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 243);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(94, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grafic note";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(763, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 30);
            this.panel2.TabIndex = 6;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Returneaza Caseta Video";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sorteaza Dupa ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1045, 316);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalveazaFisier);
            this.Controls.Add(this.btnInchiriaza);
            this.Controls.Add(this.Adauga);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button Adauga;
        private System.Windows.Forms.Button btnInchiriaza;
        private System.Windows.Forms.Button btnSalveazaFisier;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inchiriazaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaDeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaDateToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem returneazaCasetaToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

