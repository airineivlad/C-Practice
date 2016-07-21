namespace Client
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.tbPlati = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.showListviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod";
            // 
            // tbCod
            // 
            this.tbCod.ContextMenuStrip = this.contextMenuStrip1;
            this.tbCod.Location = new System.Drawing.Point(51, 21);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(145, 20);
            this.tbCod.TabIndex = 1;
            this.tbCod.TextChanged += new System.EventHandler(this.tbCod_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(51, 43);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(145, 20);
            this.tbNume.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresa";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(51, 75);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(145, 20);
            this.tbAdresa.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tip";
            // 
            // tbTip
            // 
            this.tbTip.Location = new System.Drawing.Point(456, 24);
            this.tbTip.Name = "tbTip";
            this.tbTip.Size = new System.Drawing.Size(181, 20);
            this.tbTip.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Suma";
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(456, 48);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(181, 20);
            this.tbSuma.TabIndex = 9;
            // 
            // tbPlati
            // 
            this.tbPlati.Location = new System.Drawing.Point(456, 74);
            this.tbPlati.Name = "tbPlati";
            this.tbPlati.Size = new System.Drawing.Size(181, 20);
            this.tbPlati.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Plati";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Adaugare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showListviewToolStripMenuItem
            // 
            this.showListviewToolStripMenuItem.Name = "showListviewToolStripMenuItem";
            this.showListviewToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.showListviewToolStripMenuItem.Text = "Show listview";
            this.showListviewToolStripMenuItem.Click += new System.EventHandler(this.showListviewToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showListviewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPlati);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.TextBox tbPlati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showListviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}