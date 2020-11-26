using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class EtudiantList : Form
    {
        private EtudiantBLO etudiantBLO;
        public EtudiantList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadData()
        {
            string value = txtSearch.Text.ToLower();
            var products = etudiantBLO.GetBy
            (
                x =>
                x.Identifiant.ToLower().Contains(value) ||
                x.Nom_Ettudiant.ToLower().Contains(value)
            ).OrderBy(x => x.Identifiant).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
            lblRowCount.Text = $"{dataGridView1.RowCount} rows";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form f = new EtudiantEditt(loadData);
            f.Show();
        }

        private void EtudiantList_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                loadData();
            else
                txtSearch.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new EtudiantEditt
                        (
                            dataGridView1.SelectedRows[i].DataBoundItem as Etudiant,
                            loadData
                        );
                    f.ShowDialog();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show
                    (
                        "Do yo really want to delete this product(s)?",
                        "Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        ) == DialogResult.Yes
                    )
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        etudiantBLO.DeleteEtudiant(dataGridView1.SelectedRows[1].DataBoundItem as Etudiant);

                    }
                loadData();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            List<EtudiantlistPrint> items = new List<EtudiantlistPrint>();

            Etudiant etudiant = EtudiantBLO.Getetudiant();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Etudiant p = dataGridView1.Rows[i].DataBoundItem as Etudiant;
                items.Add
                (
                   new EtudiantlistPrint
                   (
                       p.Nom_Ecole,
                       p.Pays,
                       p.Nom_Ettudiant,
                       p.Prenom_etudiant,
                       p.Identifiant,
                       p.Lieu,
                       p.Date_Naissance,
                       p.Contact,
                       p.Email,
                       !string.IsNullOrEmpty((etudiant?.Picture).ToString()) ? File.ReadAllBytes((etudiant?.Picture).ToString()) : null
                    )
                );
            }

            Form f = new FrmPrevieuw("EtudiantlistRpt.rdlc", items);
            f.Show();
        }
    }
}
    