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
    public partial class DELETEFils : Form
    {
        public DELETEFils()
        {
            InitializeComponent();
        }

        private void DELETEFils_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.RequeteFils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.requeteFilsTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.RequeteFils);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ReferenceFils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.referenceFilsTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.ReferenceFils);

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string filsEtDescription = comboBox1.Text;
            string fils = filsEtDescription.Substring(0, 8);
            this.referenceFilsTableAdapter.DeleteQuery(fils);
            MessageBox.Show("Le fils à été supprimé");
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
