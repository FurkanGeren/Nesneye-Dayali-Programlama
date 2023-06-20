namespace ndpödevi1
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
            this.ciz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ciz
            // 
            this.ciz.Location = new System.Drawing.Point(623, 612);
            this.ciz.Name = "ciz";
            this.ciz.Size = new System.Drawing.Size(75, 23);
            this.ciz.TabIndex = 0;
            this.ciz.Text = "Çiz";
            this.ciz.UseVisualStyleBackColor = true;
            this.ciz.Click += new System.EventHandler(this.ciz_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 647);
            this.Controls.Add(this.ciz);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ciz;
    }
}