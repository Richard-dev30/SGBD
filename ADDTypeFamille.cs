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
    public partial class ADDTypeFamille : Form
    {
        public ADDTypeFamille()
        {
            InitializeComponent();
        }

        private void ADDTypeFamille_Load(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string famille = textBoxFamille.Text;
            string produit = comboBoxProduit.Text;
            string type = textBoxDesignation.Text;
            bool fils = checkBoxfils.Checked;

            this.typeFamilleTableAdapter1.InsertTypeFamille(famille, produit, type, fils);
            System.Windows.Forms.MessageBox.Show("La famille a été créée");
            this.Close();
        }
    }
}
