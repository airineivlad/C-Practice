namespace SubComenzi
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
            this.codClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codComanda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valoare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valoareAchitata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consola = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codClient,
            this.codComanda,
            this.numeClient,
            this.valoare,
            this.valoareAchitata});
            this.listView1.FullRowSelect = true;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(180, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(535, 275);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            //this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // codClient
            // 
            this.codClient.Text = "codClient";
            this.codClient.Width = 118;
            // 
            // codComanda
            // 
            this.codComanda.Text = "codComanda";
            this.codComanda.Width = 136;
            // 
            // numeClient
            // 
            this.numeClient.Text = "numeClient";
            this.numeClient.Width = 107;
            // 
            // valoare
            // 
            this.valoare.Text = "valoare";
            this.valoare.Width = 114;
            // 
            // valoareAchitata
            // 
            this.valoareAchitata.Text = "valoareAchitata";
            this.valoareAchitata.Width = 117;
            // 
            // consola
            // 
            this.consola.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.consola.Location = new System.Drawing.Point(0, 302);
            this.consola.Multiline = true;
            this.consola.Name = "consola";
            this.consola.Size = new System.Drawing.Size(1078, 45);
            this.consola.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Incarca Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Print ListView";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(733, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 275);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "Draw";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 347);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.consola);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader codClient;
        private System.Windows.Forms.ColumnHeader codComanda;
        private System.Windows.Forms.ColumnHeader numeClient;
        private System.Windows.Forms.ColumnHeader valoare;
        private System.Windows.Forms.ColumnHeader valoareAchitata;
        private System.Windows.Forms.TextBox consola;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
    }
}

