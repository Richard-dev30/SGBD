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
    public partial class ChoixPays : Form
    {
        public string pays;
        public ChoixPays()
        {
            InitializeComponent();
        }

        private void ChoixPays_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.Parametre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.parametreTableAdapter.FiltrePays(this.nouvelleBaseEssaieDataSet.Parametre);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pays = comboBox1.Text;
            this.Close();
        }
    }
}
