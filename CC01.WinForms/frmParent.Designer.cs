namespace CC01.WinForms
{
    partial class frmParent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creeUnEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDesEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creeUneEcoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEcoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.imprimerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.quiterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // quiterToolStripMenuItem
            // 
            this.quiterToolStripMenuItem.Name = "quiterToolStripMenuItem";
            this.quiterToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.quiterToolStripMenuItem.Text = "quiter";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etudiantToolStripMenuItem,
            this.ecoleToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // etudiantToolStripMenuItem
            // 
            this.etudiantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creeUnEtudiantToolStripMenuItem,
            this.listDesEtudiantToolStripMenuItem});
            this.etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            this.etudiantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.etudiantToolStripMenuItem.Text = "etudiant";
            // 
            // creeUnEtudiantToolStripMenuItem
            // 
            this.creeUnEtudiantToolStripMenuItem.Name = "creeUnEtudiantToolStripMenuItem";
            this.creeUnEtudiantToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.creeUnEtudiantToolStripMenuItem.Text = "cree un etudiant";
            this.creeUnEtudiantToolStripMenuItem.Click += new System.EventHandler(this.creeUnEtudiantToolStripMenuItem_Click);
            // 
            // listDesEtudiantToolStripMenuItem
            // 
            this.listDesEtudiantToolStripMenuItem.Name = "listDesEtudiantToolStripMenuItem";
            this.listDesEtudiantToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.listDesEtudiantToolStripMenuItem.Text = "list des etudiant";
            this.listDesEtudiantToolStripMenuItem.Click += new System.EventHandler(this.listDesEtudiantToolStripMenuItem_Click);
            // 
            // ecoleToolStripMenuItem
            // 
            this.ecoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creeUneEcoleToolStripMenuItem,
            this.listeDesEcoleToolStripMenuItem});
            this.ecoleToolStripMenuItem.Name = "ecoleToolStripMenuItem";
            this.ecoleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ecoleToolStripMenuItem.Text = "ecole";
            // 
            // creeUneEcoleToolStripMenuItem
            // 
            this.creeUneEcoleToolStripMenuItem.Name = "creeUneEcoleToolStripMenuItem";
            this.creeUneEcoleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.creeUneEcoleToolStripMenuItem.Text = "cree une ecole";
            this.creeUneEcoleToolStripMenuItem.Click += new System.EventHandler(this.creeUneEcoleToolStripMenuItem_Click);
            // 
            // listeDesEcoleToolStripMenuItem
            // 
            this.listeDesEcoleToolStripMenuItem.Name = "listeDesEcoleToolStripMenuItem";
            this.listeDesEcoleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.listeDesEcoleToolStripMenuItem.Text = "liste des ecole";
            this.listeDesEcoleToolStripMenuItem.Click += new System.EventHandler(this.listeDesEcoleToolStripMenuItem_Click);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.imprimerToolStripMenuItem.Text = "imprimer";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportToolStripMenuItem.Text = "report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmParent";
            this.Text = "frmParent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDesEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creeUnEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creeUneEcoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesEcoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}