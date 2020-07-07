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
    public partial class ADDParametre : Form
    {
        public ADDParametre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parametre = textBoxParametre.Text;
            if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE / KIT";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE / KIT / MANUT";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE / KIT / MANUT / SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (!checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "CABLE / KIT / MANUT / SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "KIT / MANUT / SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (!checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "MANUT / SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }           
            if (!checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (!checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "MANUT";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "KIT";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "CABLE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "CABLE / MANUT / SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "CABLE / MANUT";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "CABLE / KIT";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (!checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "CABLE / SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (!checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "CABLE / KIT / SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "KIT / SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (!checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "KIT / MANUT";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / MANUT";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / KIT";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "BORNE / SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / KIT / MANUT";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && !checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "BORNE / MANUT / SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE / SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && !checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "BORNE / KIT / SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE / MANUT / SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && !checkBoxManut.Checked && checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE / KIT / SSE";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE / KIT / MANUT";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }
            if (checkBoxBorne.Checked && checkBoxCable.Checked && !checkBoxKIT.Checked && checkBoxManut.Checked && !checkBoxSSE.Checked)
            {
                string assignation = "BORNE / CABLE /MANUT";
                this.parametreListeTableAdapter1.InsertParametreListe(parametre, assignation);
                System.Windows.Forms.MessageBox.Show("Le paramètre a été créé");
                this.Close();
            }            
        }
    }
}
