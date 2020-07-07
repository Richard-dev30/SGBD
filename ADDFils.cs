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
    public partial class ADDFils : Form
    {
        public ADDFils()
        {
            InitializeComponent();
        }


        private void textBoxReferenceFils_Validated(object sender, EventArgs e)
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

            if (textBoxReferenceFils != null)
            {
                if (textBoxReferenceFils.Text.Length != 8)
                {
                    System.Windows.Forms.MessageBox.Show("La référence doit être dans le format #####_##");
                }
                if (textBoxReferenceFils.Text.Length == 8)
                {
                    Reference = textBoxReferenceFils.Text;
                    debutRef = Reference.Substring(0, 4);
                    finRef = Reference.Substring(6, 2);
                    result = int.TryParse(debutRef, out verif1);
                    result2 = int.TryParse(finRef, out verif2);
                    result3 = milieuRef == Reference.Substring(5, 1);
                    if (result == false || result2 == false || result3 == false)
                    {
                        System.Windows.Forms.MessageBox.Show("La référence doit être dans le format #####_##");
                    }
                    if (result == true && result2 == true && result3 == true)
                    {
                        this.referenceFilsTableAdapter.FiltreFilsParRef(this.nouvelleBaseEssaieDataSet.ReferenceFils, Reference);
                        if (dataGridViewVerif.Rows[0].Cells[0].Value != null)
                        {
                            System.Windows.Forms.MessageBox.Show("La référence séléctionnée existe déjà");
                            textBoxReferenceFils.Text = null;
                        }
                    }
                }
            }
        }

        private void buttonCreefils_Click(object sender, EventArgs e)
        {
            string Reference = textBoxReferenceFils.Text;
            string TypeCarte = textBoxNomFils.Text;
            this.referenceFilsTableAdapter.InsertFils(TypeCarte, Reference);
            System.Windows.Forms.MessageBox.Show("La référence fils a été créée");
            this.Close();
        }
    }
}
