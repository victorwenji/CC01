using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void listDesEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EtudiantList f = new EtudiantList();
            f.MdiParent = this;
            f.Show();
        }

        private void creeUnEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new EtudiantEditt();
            f.MdiParent = this;
            f.Show();
        }

        private void creeUneEcoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmEcoleEditt();
            f.MdiParent = this;
            f.Show();
        }

        private void listeDesEcoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmEcolelist();
            f.MdiParent = this;
            f.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmPrevieuw();
            f.MdiParent = this;
            f.Show();
        }

        private void frmParent_Load(object sender, EventArgs e)
        {

        }
    }
}
