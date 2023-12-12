namespace NewPicEditApp
{
    partial class ProfileLine
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ProfilePicbox = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.numAX = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoElementsL = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dGElements = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.PunktBLabel = new System.Windows.Forms.Label();
            this.BY = new System.Windows.Forms.Label();
            this.BX = new System.Windows.Forms.Label();
            this.AX = new System.Windows.Forms.Label();
            this.AY = new System.Windows.Forms.Label();
            this.PunktALabel = new System.Windows.Forms.Label();
            this.numBY = new System.Windows.Forms.NumericUpDown();
            this.numBX = new System.Windows.Forms.NumericUpDown();
            this.numAY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAX)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAY)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfilePicbox
            // 
            this.ProfilePicbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfilePicbox.Location = new System.Drawing.Point(0, 0);
            this.ProfilePicbox.Margin = new System.Windows.Forms.Padding(5);
            this.ProfilePicbox.MaximumSize = new System.Drawing.Size(400, 400);
            this.ProfilePicbox.MinimumSize = new System.Drawing.Size(400, 400);
            this.ProfilePicbox.Name = "ProfilePicbox";
            this.ProfilePicbox.Padding = new System.Windows.Forms.Padding(5);
            this.ProfilePicbox.Size = new System.Drawing.Size(400, 400);
            this.ProfilePicbox.TabIndex = 3;
            this.ProfilePicbox.TabStop = false;
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureLabel.Location = new System.Drawing.Point(0, 0);
            this.PictureLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Padding = new System.Windows.Forms.Padding(3);
            this.PictureLabel.Size = new System.Drawing.Size(55, 19);
            this.PictureLabel.TabIndex = 4;
            this.PictureLabel.Text = "Podgląd:";
            // 
            // numAX
            // 
            this.numAX.Location = new System.Drawing.Point(28, 34);
            this.numAX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAX.Name = "numAX";
            this.numAX.Size = new System.Drawing.Size(90, 20);
            this.numAX.TabIndex = 5;
            this.numAX.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NoElementsL);
            this.panel1.Controls.Add(this.chart);
            this.panel1.Controls.Add(this.dGElements);
            this.panel1.Controls.Add(this.ConfirmButton);
            this.panel1.Controls.Add(this.PunktBLabel);
            this.panel1.Controls.Add(this.BY);
            this.panel1.Controls.Add(this.BX);
            this.panel1.Controls.Add(this.AX);
            this.panel1.Controls.Add(this.AY);
            this.panel1.Controls.Add(this.PunktALabel);
            this.panel1.Controls.Add(this.numBY);
            this.panel1.Controls.Add(this.numBX);
            this.panel1.Controls.Add(this.numAY);
            this.panel1.Controls.Add(this.numAX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(397, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 450);
            this.panel1.TabIndex = 9;
            // 
            // NoElementsL
            // 
            this.NoElementsL.AutoSize = true;
            this.NoElementsL.Location = new System.Drawing.Point(298, 142);
            this.NoElementsL.Name = "NoElementsL";
            this.NoElementsL.Size = new System.Drawing.Size(50, 13);
            this.NoElementsL.TabIndex = 18;
            this.NoElementsL.Text = "Elements";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 161);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(403, 203);
            this.chart.TabIndex = 17;
            this.chart.Text = "chart1";
            // 
            // dGElements
            // 
            this.dGElements.AllowUserToDeleteRows = false;
            this.dGElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGElements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.Value});
            this.dGElements.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGElements.Location = new System.Drawing.Point(0, 364);
            this.dGElements.Name = "dGElements";
            this.dGElements.ReadOnly = true;
            this.dGElements.Size = new System.Drawing.Size(403, 86);
            this.dGElements.TabIndex = 16;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(298, 34);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 99);
            this.ConfirmButton.TabIndex = 15;
            this.ConfirmButton.Text = "Wykonaj";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // PunktBLabel
            // 
            this.PunktBLabel.AutoSize = true;
            this.PunktBLabel.Location = new System.Drawing.Point(11, 84);
            this.PunktBLabel.Name = "PunktBLabel";
            this.PunktBLabel.Size = new System.Drawing.Size(45, 13);
            this.PunktBLabel.TabIndex = 14;
            this.PunktBLabel.Text = "Punkt B";
            // 
            // BY
            // 
            this.BY.AutoSize = true;
            this.BY.Location = new System.Drawing.Point(143, 111);
            this.BY.Name = "BY";
            this.BY.Size = new System.Drawing.Size(14, 13);
            this.BY.TabIndex = 13;
            this.BY.Text = "Y";
            // 
            // BX
            // 
            this.BX.AutoSize = true;
            this.BX.Location = new System.Drawing.Point(11, 111);
            this.BX.Name = "BX";
            this.BX.Size = new System.Drawing.Size(14, 13);
            this.BX.TabIndex = 12;
            this.BX.Text = "X";
            // 
            // AX
            // 
            this.AX.AutoSize = true;
            this.AX.Location = new System.Drawing.Point(8, 36);
            this.AX.Name = "AX";
            this.AX.Size = new System.Drawing.Size(14, 13);
            this.AX.TabIndex = 11;
            this.AX.Text = "X";
            // 
            // AY
            // 
            this.AY.AutoSize = true;
            this.AY.Location = new System.Drawing.Point(143, 36);
            this.AY.Name = "AY";
            this.AY.Size = new System.Drawing.Size(14, 13);
            this.AY.TabIndex = 10;
            this.AY.Text = "Y";
            // 
            // PunktALabel
            // 
            this.PunktALabel.AutoSize = true;
            this.PunktALabel.Location = new System.Drawing.Point(11, 9);
            this.PunktALabel.Name = "PunktALabel";
            this.PunktALabel.Size = new System.Drawing.Size(45, 13);
            this.PunktALabel.TabIndex = 9;
            this.PunktALabel.Text = "Punkt A";
            // 
            // numBY
            // 
            this.numBY.Location = new System.Drawing.Point(163, 109);
            this.numBY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBY.Name = "numBY";
            this.numBY.Size = new System.Drawing.Size(90, 20);
            this.numBY.TabIndex = 8;
            this.numBY.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // numBX
            // 
            this.numBX.Location = new System.Drawing.Point(28, 109);
            this.numBX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBX.Name = "numBX";
            this.numBX.Size = new System.Drawing.Size(90, 20);
            this.numBX.TabIndex = 7;
            this.numBX.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // numAY
            // 
            this.numAY.Location = new System.Drawing.Point(163, 34);
            this.numAY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAY.Name = "numAY";
            this.numAY.Size = new System.Drawing.Size(90, 20);
            this.numAY.TabIndex = 6;
            this.numAY.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // ProfileLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PictureLabel);
            this.Controls.Add(this.ProfilePicbox);
            this.Name = "ProfileLine";
            this.Text = "ProfileLine";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.PanAndZoomPictureBox ProfilePicbox;
        private System.Windows.Forms.Label PictureLabel;
        private System.Windows.Forms.NumericUpDown numAX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGElements;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label PunktBLabel;
        private System.Windows.Forms.Label BY;
        private System.Windows.Forms.Label BX;
        private System.Windows.Forms.Label AX;
        private System.Windows.Forms.Label AY;
        private System.Windows.Forms.Label PunktALabel;
        private System.Windows.Forms.NumericUpDown numBY;
        private System.Windows.Forms.NumericUpDown numBX;
        private System.Windows.Forms.NumericUpDown numAY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label NoElementsL;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}