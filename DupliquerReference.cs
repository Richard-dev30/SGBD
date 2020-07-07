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
    public partial class DupliquerReference : Form
    {
        public string nouvellereferences;
        public DupliquerReference()
        {
            InitializeComponent();
        }

        private void DupliquerReference_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
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

            if (textBox1.Text != null)
            {
                if (textBox1.Text.Length != 8)
                {
                    System.Windows.Forms.MessageBox.Show("La référence doit être dans le format #####_##");
                    textBox1.Text = null;
                }
                if (textBox1.Text.Length == 8)
                {
                    Reference = textBox1.Text;
                    debutRef = Reference.Substring(0, 4);
                    finRef = Reference.Substring(6, 2);
                    result = int.TryParse(debutRef, out verif1);
                    result2 = int.TryParse(finRef, out verif2);
                    result3 = milieuRef == Reference.Substring(5, 1);
                    if (result == false || result2 == false || result3 == false)
                    {
                        System.Windows.Forms.MessageBox.Show("La référence doit être dans le format #####_##");
                        textBox1.Text = null;
                    }
                    if (result == true && result2 == true && result3 == true)
                    {
                        this.produitTableAdapter.FiltreVerif(this.nouvelleBaseEssaieDataSet.Produit, Reference);
                        if (dataGridViewProduit.Rows[0].Cells[0].Value == null)
                        {
                            string nouvellereference = textBox1.Text;
                            nouvellereferences = nouvellereference;
                            this.Close();
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("La référence séléctionnée existe déjà");
                            textBox1.Text = null;
                        }
                    }
                }
            }
        }
    }
}
