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
    public partial class MODIFType : Form
    {
        string premiertype;
        public MODIFType()
        {
            InitializeComponent();
        }

        private void MODIFType_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.TypeFamille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeFamilleTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.TypeFamille);

        }

        private void buttonrecherche_Click(object sender, EventArgs e)
        {
            premiertype = comboBox1.Text;
            this.typeFamilleTableAdapter.FiltreProductByType(nouvelleBaseEssaieDataSet.TypeFamille, premiertype);
            string famille = dataGridViewType.Rows[0].Cells[0].Value.ToString();
            string produit = dataGridViewType.Rows[0].Cells[1].Value.ToString();
            string type2 = dataGridViewType.Rows[0].Cells[2].Value.ToString();
            string fils = dataGridViewType.Rows[0].Cells[3].Value.ToString();
            textBoxFamille.Text = famille;
            textBoxType.Text = type2;
            int index;
            if (fils == "True")
            {
                presencefils.Checked = true;
            }
            if (produit == "BORNE")
            {
                index = 0;
                comboBoxNature.SelectedIndex = index;
            }
            if (produit == "MANUT")
            {
                index = 1;
                comboBoxNature.SelectedIndex = index;
            }
            if (produit == "CABLE")
            {
                index = 2;
                comboBoxNature.SelectedIndex = index;
            }
            if (produit == "KIT")
            {
                index = 3;
                comboBoxNature.SelectedIndex = index;
            }
            if (produit == "SSE")
            {
                index = 4;
                comboBoxNature.SelectedIndex = index;
            }
            this.typeFamilleTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.TypeFamille);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.typeFamilleTableAdapter.DeleteQuery(premiertype);
            string newfamille = textBoxFamille.Text;
            string newproduit = comboBoxNature.Text;
            string newtype = textBoxType.Text;
            bool newfils = presencefils.Checked;
            this.typeFamilleTableAdapter.InsertTypeFamille(newfamille, newproduit, newtype, newfils);
            MessageBox.Show("update successfull");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
