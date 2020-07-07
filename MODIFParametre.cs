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
    public partial class MODIFParametre : Form
    {
        public MODIFParametre()
        {
            InitializeComponent();
        }

        private void MODIFParametre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ParametreListe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.parametreListeTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.ParametreListe);
            textBox1.Visible = false;
            checkBoxBorne.Visible = false;
            checkBoxCable.Visible = false;
            checkBoxKIT.Visible = false;
            checkBoxManut.Visible = false;
            checkBoxSSE.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            checkBoxBorne.Visible = true;
            checkBoxCable.Visible = true;
            checkBoxKIT.Visible = true;
            checkBoxManut.Visible = true;
            checkBoxSSE.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            string parametre1 = comboBox1.Text;
            this.parametreListeTableAdapter.FiltreListeParametreByParametre(this.nouvelleBaseEssaieDataSet.ParametreListe, parametre1);

            string assignation = dataGridView1.Rows[0].Cells[1].Value.ToString();
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
            textBox1.Text = parametre1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parametredelete = comboBox1.Text;
            string parametre = textBox1.Text;
            if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE / KIT";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE / KIT / MANUT";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE / KIT / MANUT / SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (!checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "CABLE / KIT / MANUT / SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "KIT / MANUT / SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (!checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "MANUT / SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (!checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (!checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "MANUT";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "KIT";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "CABLE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "CABLE / MANUT / SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "CABLE / MANUT";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "CABLE / KIT";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "CABLE / SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (!checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "CABLE / KIT / SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "KIT / SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "KIT / MANUT";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / MANUT";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / KIT";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "BORNE / SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / KIT / MANUT";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "BORNE / MANUT / SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE / SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "BORNE / KIT / SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE / MANUT / SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE / KIT / SSE";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE / KIT / MANUT";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE /MANUT";
                this.parametreListeTableAdapter.InsertParametreListe(parametre, assignation);
                this.parametreListeTableAdapter.DeleteQuery(parametredelete);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été modifié");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
