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
    public partial class MODIFListeParametre : Form
    {
        public string nometiquette;
        public MODIFListeParametre()
        {
            InitializeComponent();
            label2.Visible = false;
            textBox1.Visible = false;
            dataGridViewParametre.Visible = false;
            checkBoxBorne.Visible = false;
            checkBoxCable.Visible = false;
            checkBoxKIT.Visible = false;
            checkBoxManut.Visible = false;
            checkBoxSSE.Visible = false;
            buttonValider.Visible = false;
            buttonAnnuler.Visible = false;
            Produit.Visible = false;
        }

        private void MODIFListeParametre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ParametreListe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.parametreListeTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.ParametreListe);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ListeEtiquette'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listeEtiquetteTableAdapter.Fill3(this.nouvelleBaseEssaieDataSet.ListeEtiquette);
        }

        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox1.Visible = true;
            dataGridViewParametre.Visible = true;
            checkBoxBorne.Visible = true;
            checkBoxCable.Visible = true;
            checkBoxKIT.Visible = true;
            checkBoxManut.Visible = true;
            checkBoxSSE.Visible = true;
            buttonValider.Visible = true;
            buttonAnnuler.Visible = true;

            string nomEtiquette = comboBox1.Text;
            this.listeEtiquetteTableAdapter.FiltreByEtiquette(this.nouvelleBaseEssaieDataSet.ListeEtiquette, nomEtiquette);

            textBox1.Text = nomEtiquette;
            nometiquette = nomEtiquette;

            string assignation = dataGridViewParametre.Rows[0].Cells[1].Value.ToString();
            string borne = "BORNE";
            string cable = "CABLE";
            string kit = "KIT";
            string sse = "SSE";
            string manut = "MANUT";

            if (assignation.Contains(borne))
            {
                checkBoxBorne.Checked = true;
            }
            if (assignation.Contains(cable))
            {
                checkBoxCable.Checked = true;
            }
            if (assignation.Contains(kit))
            {
                checkBoxKIT.Checked = true;
            }
            if (assignation.Contains(sse))
            {
                checkBoxSSE.Checked = true;
            }
            if (assignation.Contains(manut))
            {
                checkBoxManut.Checked = true;
            }
            comboBox1.Enabled = false;
        }

        private void dataGridViewParametre_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn &&
                e.RowIndex >= 0)
            {
                string parametre = dataGridViewParametre.Rows[row].Cells[2].Value.ToString();
                dataGridViewParametre.Rows[row].Cells[0].Value = parametre;
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string etiquettedelete = comboBox1.Text;
            string etiquette = textBox1.Text;
            this.listeEtiquetteTableAdapter.DeleteQuery(nometiquette);

            int nbrrow = dataGridViewParametre.Rows.Count;

            for (int i = 0; i < nbrrow - 1; i++)
            {
                string parametre = dataGridViewParametre.Rows[i].Cells[0].Value.ToString();
                if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE / KIT";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE / KIT / MANUT";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE / KIT / MANUT / SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "CABLE / KIT / MANUT / SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "KIT / MANUT / SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "MANUT / SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "MANUT";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "KIT";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "CABLE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "CABLE / MANUT / SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "CABLE / MANUT";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "CABLE / KIT";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "CABLE / SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "CABLE / KIT / SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "KIT / SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "KIT / MANUT";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / MANUT";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / KIT";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / KIT / MANUT";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / MANUT / SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE / SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / KIT / SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE / MANUT / SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE / KIT / SSE";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE / KIT / MANUT";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE /MANUT";
                    this.listeEtiquetteTableAdapter.InsertEtiquette(etiquette, parametre, assignation);
                }              
            }
            System.Windows.Forms.MessageBox.Show("L'étiquette a été modifiée");
            this.Close();
        }
    }
}
