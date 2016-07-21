namespace SubComenzi
{
    partial class Editare
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
            this.label1 = new System.Windows.Forms.Label();
            this.codClient = new System.Windows.Forms.TextBox();
            this.codComanda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numeClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valoare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.valoareAchitata = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod Client";
            // 
            // codClient
            // 
            this.codClient.Location = new System.Drawing.Point(120, 23);
            this.codClient.Name = "codClient";
            this.codClient.ReadOnly = true;
            this.codClient.Size = new System.Drawing.Size(171, 20);
            this.codClient.TabIndex = 1;
            // 
            // codComanda
            // 
            this.codComanda.Location = new System.Drawing.Point(120, 61);
            this.codComanda.Name = "codComanda";
            this.codComanda.ReadOnly = true;
            this.codComanda.Size = new System.Drawing.Size(171, 20);
            this.codComanda.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cod Comanda";
            // 
            // numeClient
            // 
            this.numeClient.Location = new System.Drawing.Point(120, 103);
            this.numeClient.Name = "numeClient";
            this.numeClient.ReadOnly = true;
            this.numeClient.Size = new System.Drawing.Size(171, 20);
            this.numeClient.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nume Client";
            // 
            // valoare
            // 
            this.valoare.Location = new System.Drawing.Point(120, 144);
            this.valoare.Name = "valoare";
            this.valoare.ReadOnly = true;
            this.valoare.Size = new System.Drawing.Size(171, 20);
            this.valoare.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valoare";
            // 
            // valoareAchitata
            // 
            this.valoareAchitata.Location = new System.Drawing.Point(120, 190);
            this.valoareAchitata.Name = "valoareAchitata";
            this.valoareAchitata.Size = new System.Drawing.Size(171, 20);
            this.valoareAchitata.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valoare Achitata";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(15, 242);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(126, 48);
            this.ok.TabIndex = 10;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(165, 242);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(126, 48);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Editare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 302);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.valoareAchitata);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valoare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numeClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codComanda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codClient);
            this.Controls.Add(this.label1);
            this.Name = "Editare";
            this.Text = "Editare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codClient;
        private System.Windows.Forms.TextBox codComanda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valoare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valoareAchitata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
    }
}