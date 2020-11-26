using CC01.BLL;
using CC01.BO;
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
    public partial class frmEcolelist : Form
    {
        private EcolleBLO ecoleBLO;
        public frmEcolelist()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            ecoleBLO = new EcolleBLO(System.Configuration.ConfigurationManager.AppSettings["DbFolder"]);
        }

        private void loadData()
        {
            string value = txtSearch.Text.ToLower();
            var ecoles = ecoleBLO.GetBy
            (
                x =>
                x.Nom_ecole.Contains(value) ||
                x.Date_de_creation.ToLower().Contains(value)
            ).OrderBy(x => x.Nom_ecole).ToArray(); ;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ecoles;
            dataGridView1.ClearSelection();
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form f = new FrmEcoleEditt(loadData);
            f.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this university(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        ecoleBLO.DeleteEcole(dataGridView1.SelectedRows[i].DataBoundItem as Ecole);
                    }
                    loadData();
                }
            }
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
                    Form f = new FrmEcoleEditt
                    (
                        dataGridView1.SelectedRows[i].DataBoundItem as Ecole,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }

        private void frmEcolelist_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
