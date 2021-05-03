namespace markoGalavićXMLforma
{
    partial class Form2
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
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxRazred = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUnos1 = new System.Windows.Forms.Button();
            this.buttonZavrsi1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(62, 46);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(213, 20);
            this.textBoxIme.TabIndex = 0;
            this.textBoxIme.TextChanged += new System.EventHandler(this.textBoxIme_TextChanged);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(62, 105);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(213, 20);
            this.textBoxPrezime.TabIndex = 1;
            this.textBoxPrezime.TextChanged += new System.EventHandler(this.textBoxPrezime_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(62, 163);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(213, 20);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxRazred
            // 
            this.textBoxRazred.Location = new System.Drawing.Point(62, 221);
            this.textBoxRazred.Name = "textBoxRazred";
            this.textBoxRazred.Size = new System.Drawing.Size(213, 20);
            this.textBoxRazred.TabIndex = 3;
            this.textBoxRazred.TextChanged += new System.EventHandler(this.textBoxRazred_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Razred:";
            // 
            // buttonUnos1
            // 
            this.buttonUnos1.Location = new System.Drawing.Point(92, 283);
            this.buttonUnos1.Name = "buttonUnos1";
            this.buttonUnos1.Size = new System.Drawing.Size(132, 37);
            this.buttonUnos1.TabIndex = 8;
            this.buttonUnos1.Text = "Unos";
            this.buttonUnos1.UseVisualStyleBackColor = true;
            this.buttonUnos1.Click += new System.EventHandler(this.buttonUnos1_Click);
            // 
            // buttonZavrsi1
            // 
            this.buttonZavrsi1.Location = new System.Drawing.Point(92, 350);
            this.buttonZavrsi1.Name = "buttonZavrsi1";
            this.buttonZavrsi1.Size = new System.Drawing.Size(132, 37);
            this.buttonZavrsi1.TabIndex = 9;
            this.buttonZavrsi1.Text = "Završi";
            this.buttonZavrsi1.UseVisualStyleBackColor = true;
            this.buttonZavrsi1.Click += new System.EventHandler(this.buttonZavrsi1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.buttonZavrsi1);
            this.Controls.Add(this.buttonUnos1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRazred);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Name = "Form2";
            this.Text = "Unos podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxRazred;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUnos1;
        private System.Windows.Forms.Button buttonZavrsi1;
    }
}