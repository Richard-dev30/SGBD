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
    public partial class ChoixOrigine : Form
    {
        public string origine;
        public ChoixOrigine()
        {
            InitializeComponent();
        }

        private void ChoixOrigine_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.Parametre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.parametreTableAdapter.FiltreOrigine(this.nouvelleBaseEssaieDataSet.Parametre);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            origine = comboBox1.Text;
            this.Close();
        }
    }
}
