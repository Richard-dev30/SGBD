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
    public partial class ADDEtiquette : Form
    {
        public ADDEtiquette()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string etiquette = textBox1.Text;
            int nbrrow = dataGridViewParametre.Rows.Count;

            for (int i = 0; i < nbrrow-1; i++)
            {
                string parametre = dataGridViewParametre.Rows[i].Cells[0].Value.ToString();
                if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE / KIT";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE / KIT / MANUT";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE / KIT / MANUT / SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "CABLE / KIT / MANUT / SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "KIT / MANUT / SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "MANUT / SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "MANUT";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "KIT";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "CABLE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "CABLE / MANUT / SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "CABLE / MANUT";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "CABLE / KIT";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "CABLE / SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "CABLE / KIT / SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "KIT / SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "KIT / MANUT";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / MANUT";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / KIT";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / KIT / MANUT";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / MANUT / SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE / SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / KIT / SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE / MANUT / SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE / KIT / SSE";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE / KIT / MANUT";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
                if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
                {
                    string assignation = "BORNE / CABLE /MANUT";
                    this.listeEtiquetteTableAdapter1.InsertEtiquette(etiquette, parametre, assignation);
                }
            }
            System.Windows.Forms.MessageBox.Show("La liste de paramètre a été créée");
            this.Close();
        }

        private void ADDEtiquette_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ParametreListe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.parametreListeTableAdapter.Fill2(this.nouvelleBaseEssaieDataSet.ParametreListe);

        }

        private void dataGridViewParametre_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn &&
                e.RowIndex >= 0)
            {
                string parametre = dataGridViewParametre.Rows[row].Cells[1].Value.ToString();
                dataGridViewParametre.Rows[row].Cells[0].Value = parametre;
            }
        }
    }
}
