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
    public partial class DELETEListeParametre : Form
    {
        public DELETEListeParametre()
        {
            InitializeComponent();
        }

        private void DELETEListeParametre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ListeEtiquette'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listeEtiquetteTableAdapter.Fill3(this.nouvelleBaseEssaieDataSet.ListeEtiquette);

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string parametreliste = comboBox1.Text;
            this.listeEtiquetteTableAdapter.DeleteQuery(parametreliste);
            MessageBox.Show("La liste de paramètre à été supprimé");
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
