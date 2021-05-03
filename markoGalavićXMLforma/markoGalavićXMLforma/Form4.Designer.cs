namespace markoGalavićXMLforma
{
    partial class Form4
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonUcitajdokument = new System.Windows.Forms.Button();
            this.buttonFiltriraj1 = new System.Windows.Forms.Button();
            this.buttonOdustani1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(477, 347);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonUcitajdokument
            // 
            this.buttonUcitajdokument.Location = new System.Drawing.Point(30, 31);
            this.buttonUcitajdokument.Name = "buttonUcitajdokument";
            this.buttonUcitajdokument.Size = new System.Drawing.Size(134, 23);
            this.buttonUcitajdokument.TabIndex = 1;
            this.buttonUcitajdokument.Text = "Učitaj dokument";
            this.buttonUcitajdokument.UseVisualStyleBackColor = true;
            // 
            // buttonFiltriraj1
            // 
            this.buttonFiltriraj1.Location = new System.Drawing.Point(188, 31);
            this.buttonFiltriraj1.Name = "buttonFiltriraj1";
            this.buttonFiltriraj1.Size = new System.Drawing.Size(119, 23);
            this.buttonFiltriraj1.TabIndex = 2;
            this.buttonFiltriraj1.Text = "Filtriraj";
            this.buttonFiltriraj1.UseVisualStyleBackColor = true;
            this.buttonFiltriraj1.Click += new System.EventHandler(this.buttonFiltriraj1_Click);
            // 
            // buttonOdustani1
            // 
            this.buttonOdustani1.Location = new System.Drawing.Point(330, 31);
            this.buttonOdustani1.Name = "buttonOdustani1";
            this.buttonOdustani1.Size = new System.Drawing.Size(140, 23);
            this.buttonOdustani1.TabIndex = 3;
            this.buttonOdustani1.Text = "Odustani";
            this.buttonOdustani1.UseVisualStyleBackColor = true;
            this.buttonOdustani1.Click += new System.EventHandler(this.buttonOdustani1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.buttonOdustani1);
            this.Controls.Add(this.buttonFiltriraj1);
            this.Controls.Add(this.buttonUcitajdokument);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonUcitajdokument;
        private System.Windows.Forms.Button buttonFiltriraj1;
        private System.Windows.Forms.Button buttonOdustani1;
    }
}