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
    public partial class FrmEcoleEditt : Form
    {
        private Action callBack;
        private Ecole oldecole;
        public FrmEcoleEditt()
        {
            InitializeComponent();
        }

        public FrmEcoleEditt(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        public FrmEcoleEditt(Ecole ecole, Action callBack) : this(callBack)
        {
            this.oldecole = ecole;
            txtnomecole.Text = oldecole.Nom_ecole;
            txtDatedecreation.Text = oldecole.Date_de_creation;
            txtContact.Text = oldecole.Contact.ToString();
            txtLieu.Text = oldecole.Lieu;
            txtBP.Text = oldecole.BP;

            if (oldecole.Logo != null)
               pictureBoxUniversity.Image = Image.FromStream(new MemoryStream(oldecole.Logo));


            //txtUniversityName.Text = oldecole.UniversityName;
            //txtDate.Text = oldecole.Born;
            //txtLocationUniversity.Text = oldecole.Location;
            //txtContactUniversity.Text = oldUniversity.Contact.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxUniversity_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a picture";
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUniversity.ImageLocation = ofd.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Ecole newUniversity = new Ecole
                (
                    txtnomecole.Text.ToUpper(),
                    txtDatedecreation.Text,
                 
                    txtabreviation.Text,
                    txtLieu.Text,
                    txtBP.Text,
                    long.Parse(txtContact.Text),
                    !string.IsNullOrEmpty(pictureBoxUniversity.ImageLocation) ? File.ReadAllBytes(pictureBoxUniversity.ImageLocation) : this.oldecole?.Logo
                );

                EcolleBLO universityBLO = new EcolleBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldecole == null)
                    universityBLO.CreateEcole(newUniversity);
                else
                    universityBLO.EditEcole(oldecole, newUniversity);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Close();


            }
            catch (TypingException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Typing error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show
               (
                   "An error occurred! Please try again later.",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }
    }
}
