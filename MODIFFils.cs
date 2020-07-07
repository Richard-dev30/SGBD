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
    public partial class MODIFFils : Form
    {
        string premiereref;
        public MODIFFils()
        {
            InitializeComponent();
        }

        private void MODIFFils_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ReferenceFils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.referenceFilsTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.ReferenceFils);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.RequeteFils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.requeteFilsTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.RequeteFils);

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reffilscomplete = comboBoxFils.Text;
            int nbrcarac = reffilscomplete.Length;
            string reffils = reffilscomplete.Substring(0, 8);
            string def = reffilscomplete.Substring(11, nbrcarac - 11);
            textBoxRef.Text = reffils;
            textBoxDef.Text = def;
            premiereref = reffils;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            int verif2 = 0;
            int verif1 = 0;
            string debutRef;
            string finRef;
            string milieuRef = "_";
            string Reference;
            bool result;
            bool result2;
            bool result3;

            if (textBoxRef.Text != null)
            {
                if (textBoxRef.Text.Length != 8)
                {
                    System.Windows.Forms.MessageBox.Show("La référence doit être dans le format #####_##");
                    textBoxRef.Text = null;
                }
                if (textBoxRef.Text.Length == 8)
                {
                    Reference = textBoxRef.Text;
                    debutRef = Reference.Substring(0, 4);
                    finRef = Reference.Substring(6, 2);
                    result = int.TryParse(debutRef, out verif1);
                    result2 = int.TryParse(finRef, out verif2);
                    result3 = milieuRef == Reference.Substring(5, 1);
                    if (result == false || result2 == false || result3 == false)
                    {
                        System.Windows.Forms.MessageBox.Show("La référence doit être dans le format #####_##");
                        textBoxRef.Text = null;
                    }
                    if (result == true && result2 == true && result3 == true)
                    {
                        this.referenceFilsTableAdapter.FiltreFilsParRef(nouvelleBaseEssaieDataSet.ReferenceFils, Reference);
                        if (dataGridViewProduit.Rows[0].Cells[0].Value == null || textBoxRef.Text == premiereref)
                        {
                            this.referenceFilsTableAdapter.DeleteQuery(premiereref);
                            this.referenceFilsTableAdapter.InsertFils(textBoxDef.Text, textBoxRef.Text);
                            this.Close();
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("La référence séléctionnée existe déjà");
                            textBoxRef.Text = null;
                        }
                    }
                }
            }
        }
    }
}
