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
    public partial class DELETEType : Form
    {
        public DELETEType()
        {
            InitializeComponent();
        }

        private void DELETEType_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.TypeFamille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeFamilleTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.TypeFamille);

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string type = comboBox1.Text;
            this.typeFamilleTableAdapter.DeleteQuery(type);
            MessageBox.Show("Le type à été supprimé");
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
