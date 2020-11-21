using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CC01.BO;
using CC01.BLL;

namespace CC01.WinForms
{
    public partial class EtudiantEditt : Form
    {
        private Action callBack;

        private Etudiant oldetudiant;
        public EtudiantEditt()
        {
            InitializeComponent();
        }
        public EtudiantEditt(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        public EtudiantEditt(Etudiant etudiant, Action callBack) : this(callBack)
        {
            this.oldetudiant = etudiant;
            txtNomEcole.Text = etudiant.Nom_Ecole;
            txtpays.Text = etudiant.Pays;
            txtnometudiant.Text = etudiant.Nom_Ettudiant;
            txtprenometudiant.Text = etudiant.Prenom_etudiant;
            dateTimePicker1.Text = etudiant.Date_Naissance.ToLongDateString();
            txtA.Text = etudiant.Lieu;
            txtidentifiant.Text = etudiant.Identifiant;
            txtcontact.Text = etudiant.Contact;
            txtemail.Text = etudiant.Email;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cheackForm();
                Etudiant newEtudiant = new Etudiant
                (
                     
                    txtNomEcole.Text,
                    txtpays.Text,
                    txtnometudiant.Text,
                    txtprenometudiant.Text,
                    DateTime.Parse(dateTimePicker1.Text),
                    txtidentifiant.Text.ToUpper(),
                    txtA.Text,
                    txtcontact.Text,
                    txtemail.Text
                );

                EtudiantBLO etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldetudiant == null)
                    etudiantBLO.CreatEtudiant(oldetudiant);
                else
                    etudiantBLO.EditEtudiant(oldetudiant, newEtudiant);

                MessageBox.Show(
                    "Enregistrement effectuer",
                    "confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                if (callBack != null)
                    callBack();

                if (oldetudiant != null)
                    Close();

                txtNomEcole.Focus();
                txtNomEcole.Clear();
                txtpays.Clear();
                txtnometudiant.Clear();
                txtprenometudiant.Clear();
                txtidentifiant.Clear();
                txtA.Clear();
                txtcontact.Clear();
                txtemail.Clear();
            }
            catch (TypingException ex)
            {
                MessageBox.Show
                (
                    ex.Message,
                    "typing error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                 );
            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show
                (
                    ex.Message,
                    "duplicate error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                 );
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show
                (
                    ex.Message,
                    "not found error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                 );
            }
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show
               (
                    "une erreur a ete detecter!! ",
                    "erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                 );
            }
        }
        private void cheackForm()
        {
            string text = string.Empty;
            if (string.IsNullOrWhiteSpace(txtidentifiant.Text))
                text += "- idiot utilise ta cervelle !!\n";
            if (string.IsNullOrWhiteSpace(txtidentifiant.Text))
                text += "- idiot utilise ta cervelle!!\n";

            if (!string.IsNullOrEmpty(text))
            {
                throw new TypingException(text);
            }
        }
    }
}
