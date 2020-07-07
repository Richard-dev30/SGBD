using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModificationBaseDeDonnees
{
    public partial class DELETEParametre : Form
    {
        public DELETEParametre()
        {
            InitializeComponent();
        }

        private void DELETEParametre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ParametreListe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.parametreListeTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.ParametreListe);

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string parametre = comboBox1.Text;
            this.parametreListeTableAdapter.DeleteQuery(parametre);
            MessageBox.Show("Le paramètre à été supprimé");
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
