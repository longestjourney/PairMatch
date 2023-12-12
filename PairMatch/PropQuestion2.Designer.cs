namespace NewPicEditApp
{
    partial class PropQuestion2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbProp = new System.Windows.Forms.TextBox();
            this.bgot = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Proszę wczytać wartość progu";
            // 
            // tbProp
            // 
            this.tbProp.Location = new System.Drawing.Point(87, 38);
            this.tbProp.Name = "tbProp";
            this.tbProp.Size = new System.Drawing.Size(61, 20);
            this.tbProp.TabIndex = 3;
            this.tbProp.Text = "127";
            // 
            // bgot
            // 
            this.bgot.Location = new System.Drawing.Point(154, 38);
            this.bgot.Name = "bgot";
            this.bgot.Size = new System.Drawing.Size(75, 23);
            this.bgot.TabIndex = 4;
            this.bgot.Text = "Gotowe";
            this.bgot.UseVisualStyleBackColor = true;
            this.bgot.Click += new System.EventHandler(this.bgot_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "127";
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Location = new System.Drawing.Point(9, 41);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(71, 13);
            this.p1.TabIndex = 7;
            this.p1.Text = "dla obrazka 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "dla obrazka 2";
            // 
            // PropQuestion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bgot);
            this.Controls.Add(this.tbProp);
            this.Controls.Add(this.textBox1);
            this.Name = "PropQuestion2";
            this.Text = "Progowanie";
            this.Load += new System.EventHandler(this.PropQuestion2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.TextBox tbProp;
        private System.Windows.Forms.Button bgot;
        internal System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label label1;
    }
}