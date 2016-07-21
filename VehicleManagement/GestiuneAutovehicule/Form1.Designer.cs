namespace GestiuneAutovehicule
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPutere = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ordineLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(61, 45);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(157, 20);
            this.tbId.TabIndex = 2;
            this.tbId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbId_KeyDown);
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(61, 93);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(157, 20);
            this.tbMarca.TabIndex = 4;
            this.tbMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbId_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca:";
            // 
            // tbPutere
            // 
            this.tbPutere.Location = new System.Drawing.Point(61, 141);
            this.tbPutere.Name = "tbPutere";
            this.tbPutere.Size = new System.Drawing.Size(157, 20);
            this.tbPutere.TabIndex = 6;
            this.tbPutere.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbId_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Putere:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "< Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(122, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Next >";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ordineLabel
            // 
            this.ordineLabel.AutoSize = true;
            this.ordineLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ordineLabel.Location = new System.Drawing.Point(12, 180);
            this.ordineLabel.Name = "ordineLabel";
            this.ordineLabel.Size = new System.Drawing.Size(103, 13);
            this.ordineLabel.TabIndex = 9;
            this.ordineLabel.Text = "Inregistrarea K din N";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 20);
            this.button4.TabIndex = 10;
            this.button4.Text = "Modifica";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(238, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 20);
            this.button5.TabIndex = 11;
            this.button5.Text = "Incarca Date din BD";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(10, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 265);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(238, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 20);
            this.button6.TabIndex = 13;
            this.button6.Text = "Putere Medie";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(238, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(238, 137);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(206, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "Insert din Clipboard";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(9, 201);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(206, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "Save to TXT";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 507);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ordineLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbPutere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPutere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ordineLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

