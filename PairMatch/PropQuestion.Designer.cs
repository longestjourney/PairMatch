namespace NewPicEditApp
{
    partial class PropQuestion
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
            this.tbProp = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bgot = new System.Windows.Forms.Button();
            this.tbProp2 = new System.Windows.Forms.TextBox();
            this.tbQprop1 = new System.Windows.Forms.TextBox();
            this.tbQprop2 = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.q3 = new System.Windows.Forms.Label();
            this.q4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbProp
            // 
            this.tbProp.Location = new System.Drawing.Point(13, 42);
            this.tbProp.Name = "tbProp";
            this.tbProp.Size = new System.Drawing.Size(61, 20);
            this.tbProp.TabIndex = 0;
            this.tbProp.Text = "127";
            this.tbProp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Proszę wczytać wartość progu";
            // 
            // bgot
            // 
            this.bgot.Location = new System.Drawing.Point(165, 43);
            this.bgot.Name = "bgot";
            this.bgot.Size = new System.Drawing.Size(75, 23);
            this.bgot.TabIndex = 2;
            this.bgot.Text = "Gotowe";
            this.bgot.UseVisualStyleBackColor = true;
            this.bgot.Click += new System.EventHandler(this.bgot_Click);
            // 
            // tbProp2
            // 
            this.tbProp2.Location = new System.Drawing.Point(90, 43);
            this.tbProp2.Name = "tbProp2";
            this.tbProp2.Size = new System.Drawing.Size(61, 20);
            this.tbProp2.TabIndex = 3;
            this.tbProp2.Text = "127";
            this.tbProp2.Visible = false;
            // 
            // tbQprop1
            // 
            this.tbQprop1.Location = new System.Drawing.Point(13, 81);
            this.tbQprop1.Name = "tbQprop1";
            this.tbQprop1.Size = new System.Drawing.Size(61, 20);
            this.tbQprop1.TabIndex = 4;
            this.tbQprop1.Text = "127";
            this.tbQprop1.Visible = false;
            // 
            // tbQprop2
            // 
            this.tbQprop2.Location = new System.Drawing.Point(91, 81);
            this.tbQprop2.Name = "tbQprop2";
            this.tbQprop2.Size = new System.Drawing.Size(61, 20);
            this.tbQprop2.TabIndex = 5;
            this.tbQprop2.Text = "127";
            this.tbQprop2.Visible = false;
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Location = new System.Drawing.Point(12, 26);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(19, 13);
            this.p1.TabIndex = 6;
            this.p1.Text = "p1";
            this.p1.Visible = false;
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Location = new System.Drawing.Point(92, 26);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(19, 13);
            this.p2.TabIndex = 7;
            this.p2.Text = "p2";
            this.p2.Visible = false;
            // 
            // q3
            // 
            this.q3.AutoSize = true;
            this.q3.Location = new System.Drawing.Point(12, 65);
            this.q3.Name = "q3";
            this.q3.Size = new System.Drawing.Size(19, 13);
            this.q3.TabIndex = 8;
            this.q3.Text = "q3";
            this.q3.Visible = false;
            // 
            // q4
            // 
            this.q4.AutoSize = true;
            this.q4.Location = new System.Drawing.Point(93, 66);
            this.q4.Name = "q4";
            this.q4.Size = new System.Drawing.Size(19, 13);
            this.q4.TabIndex = 9;
            this.q4.Text = "q4";
            this.q4.Visible = false;
            // 
            // PropQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 108);
            this.Controls.Add(this.q4);
            this.Controls.Add(this.q3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.tbQprop2);
            this.Controls.Add(this.tbQprop1);
            this.Controls.Add(this.tbProp2);
            this.Controls.Add(this.bgot);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbProp);
            this.Name = "PropQuestion";
            this.Text = "Progowanie";
            this.Load += new System.EventHandler(this.PropQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox tbProp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bgot;
        internal System.Windows.Forms.TextBox tbProp2;
        internal System.Windows.Forms.TextBox tbQprop1;
        internal System.Windows.Forms.TextBox tbQprop2;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label q3;
        private System.Windows.Forms.Label q4;
    }
}