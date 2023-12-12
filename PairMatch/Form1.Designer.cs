namespace NewPicEditApp
{
    partial class PicForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.co_histogram_operations = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozciąToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOperacjeJednop = new System.Windows.Forms.ToolStripMenuItem();
            this.miInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.progowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zwykłeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zPoziomamiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posteryzacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozciąganieSelektywneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(12, 92);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(465, 323);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 1;
            this.picbox.TabStop = false;
            // 
            // co_histogram_operations
            // 
            this.co_histogram_operations.FormattingEnabled = true;
            this.co_histogram_operations.Items.AddRange(new object[] {
            "Pokaż",
            "Rozciaganie",
            "Equalizacja"});
            this.co_histogram_operations.Location = new System.Drawing.Point(93, 52);
            this.co_histogram_operations.Name = "co_histogram_operations";
            this.co_histogram_operations.Size = new System.Drawing.Size(72, 21);
            this.co_histogram_operations.TabIndex = 2;
            this.co_histogram_operations.Text = "Histogram";
            this.co_histogram_operations.SelectedIndexChanged += new System.EventHandler(this.co_histogram_operations_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.histogramToolStripMenuItem,
            this.miOperacjeJednop});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(48, 20);
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokażToolStripMenuItem,
            this.rozciąToolStripMenuItem,
            this.equalizacjaToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // pokażToolStripMenuItem
            // 
            this.pokażToolStripMenuItem.Name = "pokażToolStripMenuItem";
            this.pokażToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.pokażToolStripMenuItem.Text = "Pokaż";
            this.pokażToolStripMenuItem.Click += new System.EventHandler(this.pokażToolStripMenuItem_Click);
            // 
            // rozciąToolStripMenuItem
            // 
            this.rozciąToolStripMenuItem.Name = "rozciąToolStripMenuItem";
            this.rozciąToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.rozciąToolStripMenuItem.Text = "Rozciągnij";
            this.rozciąToolStripMenuItem.Click += new System.EventHandler(this.rozciąToolStripMenuItem_Click);
            // 
            // equalizacjaToolStripMenuItem
            // 
            this.equalizacjaToolStripMenuItem.Name = "equalizacjaToolStripMenuItem";
            this.equalizacjaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.equalizacjaToolStripMenuItem.Text = "Equalizacja";
            this.equalizacjaToolStripMenuItem.Click += new System.EventHandler(this.equalizacjaToolStripMenuItem_Click);
            // 
            // miOperacjeJednop
            // 
            this.miOperacjeJednop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miInvert,
            this.progowanieToolStripMenuItem,
            this.posteryzacjaToolStripMenuItem,
            this.rozciąganieSelektywneToolStripMenuItem});
            this.miOperacjeJednop.Name = "miOperacjeJednop";
            this.miOperacjeJednop.Size = new System.Drawing.Size(152, 20);
            this.miOperacjeJednop.Text = "Operacje jednopunktowe";
            // 
            // miInvert
            // 
            this.miInvert.Name = "miInvert";
            this.miInvert.Size = new System.Drawing.Size(198, 22);
            this.miInvert.Text = "Negatyw";
            this.miInvert.Click += new System.EventHandler(this.miInvert_Click);
            // 
            // progowanieToolStripMenuItem
            // 
            this.progowanieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zwykłeToolStripMenuItem,
            this.zPoziomamiToolStripMenuItem});
            this.progowanieToolStripMenuItem.Name = "progowanieToolStripMenuItem";
            this.progowanieToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.progowanieToolStripMenuItem.Text = "Progowanie";
            // 
            // zwykłeToolStripMenuItem
            // 
            this.zwykłeToolStripMenuItem.Name = "zwykłeToolStripMenuItem";
            this.zwykłeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.zwykłeToolStripMenuItem.Text = "Zwykłe";
            this.zwykłeToolStripMenuItem.Click += new System.EventHandler(this.zwykłeToolStripMenuItem_Click);
            // 
            // zPoziomamiToolStripMenuItem
            // 
            this.zPoziomamiToolStripMenuItem.Name = "zPoziomamiToolStripMenuItem";
            this.zPoziomamiToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.zPoziomamiToolStripMenuItem.Text = "Z poziomami";
            this.zPoziomamiToolStripMenuItem.Click += new System.EventHandler(this.zPoziomamiToolStripMenuItem_Click);
            // 
            // posteryzacjaToolStripMenuItem
            // 
            this.posteryzacjaToolStripMenuItem.Name = "posteryzacjaToolStripMenuItem";
            this.posteryzacjaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.posteryzacjaToolStripMenuItem.Text = "Posteryzacja";
            this.posteryzacjaToolStripMenuItem.Click += new System.EventHandler(this.posteryzacjaToolStripMenuItem_Click);
            // 
            // rozciąganieSelektywneToolStripMenuItem
            // 
            this.rozciąganieSelektywneToolStripMenuItem.Name = "rozciąganieSelektywneToolStripMenuItem";
            this.rozciąganieSelektywneToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.rozciąganieSelektywneToolStripMenuItem.Text = "Rozciąganie selektywne";
            this.rozciąganieSelektywneToolStripMenuItem.Click += new System.EventHandler(this.rozciąganieSelektywneToolStripMenuItem_Click);
            // 
            // PicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.co_histogram_operations);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PicForm";
            this.Text = "PicEditApp";
            this.Load += new System.EventHandler(this.PicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.ComboBox co_histogram_operations;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOperacjeJednop;
        private System.Windows.Forms.ToolStripMenuItem miInvert;
        private System.Windows.Forms.ToolStripMenuItem posteryzacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozciąganieSelektywneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progowanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zwykłeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zPoziomamiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozciąToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizacjaToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

