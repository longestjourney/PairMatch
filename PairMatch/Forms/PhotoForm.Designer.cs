namespace NewPicEditApp
{
    partial class PhotoForm
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
            this.pbMyphoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMyphoto
            // 
            this.pbMyphoto.Location = new System.Drawing.Point(12, 12);
            this.pbMyphoto.Name = "pbMyphoto";
            this.pbMyphoto.Size = new System.Drawing.Size(469, 422);
            this.pbMyphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMyphoto.TabIndex = 0;
            this.pbMyphoto.TabStop = false;
            // 
            // PhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 446);
            this.Controls.Add(this.pbMyphoto);
            this.Name = "PhotoForm";
            this.Text = "v";
            ((System.ComponentModel.ISupportInitialize)(this.pbMyphoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMyphoto;
    }
}