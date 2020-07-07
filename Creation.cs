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
    public partial class Creation : Form
    {
        public int nbreti = 0;
        ChoixVraiFaux ChoixVraiFaux;
        ChoixOrigine ChoixOrigine;
        ChoixPays ChoixPays;
        public Creation()
        {
            InitializeComponent();
        }

        private void Creation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet1.RequeteFils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.requeteFilsTableAdapter.Fill(this.nouvelleBaseEssaieDataSet1.RequeteFils);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ListeEtiquette'. Vous pouvez la déplacer ou la supprimer selon les besoins.           
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.TypeFamille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeFamilleTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.TypeFamille);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ReferenceFils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.referenceFilsTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.ReferenceFils);
            this.dataGridViewProduit.Rows.Add();
            Parametretabpage.Visible = false;
            dataGridViewFils.Visible = false;
            dataGridViewProduit.Rows[0].Cells[1].ReadOnly = true;
            dataGridViewProduit.Rows[0].Cells[2].ReadOnly = true;
            dataGridViewProduit.Rows[0].Cells[3].ReadOnly = true;
            dataGridViewParametre.Enabled = false;
            dataGridViewParametre.BackgroundColor = Color.Gray;
            dataGridViewFils.Enabled = false;
            dataGridViewFils.BackgroundColor = Color.Gray;
            Parametretabpage.Controls.Remove(tabPage2);
            Parametretabpage.Controls.Remove(tabPage3);
            Parametretabpage.Controls.Remove(tabPage4);
            Parametretabpage.Controls.Remove(tabPage5);
            Parametretabpage.Controls.Remove(tabPage6);
            Parametretabpage.Controls.Remove(tabPage7);
            buttonValider.Visible = false;
        }


        private void dataGridViewProduit_CellClick(object sender, DataGridViewCellEventArgs e)
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

            if (dataGridViewProduit.Rows[0].Cells[0].Value != null)
            {
                if (dataGridViewProduit.Rows[0].Cells[0].Value.ToString().Length != 8)
                {
                    System.Windows.Forms.MessageBox.Show("La référence doit être dans le format #####_##");
                    dataGridViewProduit.Rows[0].Cells[0].Value = null;
                }
                if (dataGridViewProduit.Rows[0].Cells[0].Value.ToString().Length == 8)
                {
                    Reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    debutRef = Reference.Substring(0, 4);
                    finRef = Reference.Substring(6, 2);
                    result = int.TryParse(debutRef, out verif1);
                    result2 = int.TryParse(finRef, out verif2);
                    result3 = milieuRef == Reference.Substring(5, 1);
                    if (result == false || result2 == false || result3 == false)
                    {
                        System.Windows.Forms.MessageBox.Show("La référence doit être dans le format #####_##");
                        dataGridViewProduit.Rows[0].Cells[0].Value = null;
                    }
                    if (result == true && result2 == true && result3 == true)
                    {
                        this.produitTableAdapter.FiltreVerif(this.nouvelleBaseEssaieDataSet.Produit, Reference);
                        if (dataGridViewVerifProduit.Rows[0].Cells[0].Value == null)
                        {
                            dataGridViewProduit.Rows[0].Cells[1].ReadOnly = false;
                            dataGridViewProduit.Rows[0].Cells[3].ReadOnly = false;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("La référence séléctionnée existe déjà");
                            dataGridViewProduit.Rows[0].Cells[0].Value = null;
                        }
                    }
                }
            }
            if (dataGridViewProduit.Rows[0].Cells[1].Value != null && dataGridViewProduit.Rows[0].Cells[3].Value == null || dataGridViewProduit.Rows[0].Cells[3].Value != null)
            {
                string type = dataGridViewProduit.Rows[0].Cells[1].Value.ToString();
                this.typeFamilleTableAdapter.FiltreProductByType(this.nouvelleBaseEssaieDataSet.TypeFamille, type);
                string faamille = dataGridViewNatureDuProduit.Rows[0].Cells[1].Value.ToString();
                string produit = dataGridViewNatureDuProduit.Rows[0].Cells[2].Value.ToString();
                string fils = dataGridViewNatureDuProduit.Rows[0].Cells[4].Value.ToString();
                bool filss = false;
                if (fils != "False")
                {
                    filss = true;
                }
                dataGridViewProduit.Rows[0].Cells[3].Value = faamille;
                dataGridViewProduitConfirmation.Rows[0].Cells[0].Value = faamille;
                dataGridViewProduitConfirmation.Rows[0].Cells[1].Value = produit;
                dataGridViewProduitConfirmation.Rows[0].Cells[2].Value = type;
                dataGridViewProduitConfirmation.Rows[0].Cells[3].Value = filss;
                if (filss == false)
                {
                    dataGridViewParametre.Enabled = true;
                    dataGridViewParametre.BackgroundColor = Color.DarkGray;
                    dataGridViewFils.Enabled = false;
                    dataGridViewFils.BackgroundColor = Color.Gray;
                }
                if (filss == true)
                {
                    dataGridViewParametre.Enabled = true;
                    dataGridViewParametre.BackgroundColor = Color.DarkGray;
                    dataGridViewFils.Visible = true;
                    dataGridViewFils.Enabled = true;
                    dataGridViewFils.BackgroundColor = Color.DarkGray;
                }
            }
            string produit2 = dataGridViewNatureDuProduit.Rows[0].Cells[2].Value.ToString();
            this.typeFamilleTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.TypeFamille);
            this.listeEtiquetteTableAdapter.Fill2(this.nouvelleBaseEssaieDataSet.ListeEtiquette, produit2);
            this.parametreListeTableAdapter.FiltreListeParametre(this.nouvelleBaseEssaieDataSet.ParametreListe, produit2);
        }
        /*private void comboBoxListeEtiquette_Validating(object sender, CancelEventArgs e)
        {
            nbreti = nbreti + 1;
            int i = 0;
            string etiquette = comboBoxListeEtiquette.Text;
            this.listeEtiquetteTableAdapter.FiltreByEtiquette(this.nouvelleBaseEssaieDataSet.ListeEtiquette, etiquette);
            int nbrroweti = dataGridViewEtiquette.Rows.Count;
            string produit = dataGridViewProduitConfirmation.Rows[0].Cells[1].Value.ToString();
            if (nbreti == 1)
            {
                for (i = 0; i < nbrroweti - 1; i++)
                {
                    Parametretabpage.Visible = true;
                    string parametre = dataGridViewEtiquette.Rows[i].Cells[1].Value.ToString();
                    dataGridViewParametre.Rows.Add();
                    dataGridViewParametre.Rows[i].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    dataGridViewParametre.Rows[i].Cells[1].Value = parametre;
                }
                tabPage1.Text = etiquette;
                this.listeEtiquetteTableAdapter.Fill2(this.nouvelleBaseEssaieDataSet.ListeEtiquette, produit);
                nbreti = nbreti + 1;
                buttonValider.Visible = true;
                int rowpara = dataGridViewParametre.Rows.Count;
                for (int x = 0; x < rowpara - 1; x++)
                {
                    string variable = dataGridViewParametre.Rows[x].Cells[1].Value.ToString();
                    bool testetl = variable == "CodeETL";
                    bool testmac = variable == "ChargePointMac";
                    bool testrecap = variable == "PrintRecap";
                    bool testimprim = variable == "A_Imprimer";
                    bool testindice = variable == "Indice";
                    bool testindice2 = variable == "indice";
                    bool testOrigine = variable == "Origine";
                    bool testOrigin = variable == "Origin";
                    bool testorigin = variable == "origin";
                    bool testPays = variable == "Pays";
                    bool testpays = variable == "pays";
                    bool testModele = variable == "Modele";
                    bool testModelePath = variable == "Modele_Path";
                    if (testetl == true || testmac == true || testrecap == true || testimprim == true || testindice == true || testindice2 == true || testOrigine == true || testOrigin == true || testorigin == true || testPays == true || testpays == true || testModele == true || testModelePath == true)
                    {
                        dataGridViewParametre.Rows[x].DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }


            if (nbreti == 3)
            {
                Parametretabpage.Controls.Add(tabPage2);
                string etiquette2 = comboBoxListeEtiquette.Text;
                this.listeEtiquetteTableAdapter.FiltreByEtiquette(this.nouvelleBaseEssaieDataSet.ListeEtiquette, etiquette2);
                int nbrroweti2 = dataGridViewEtiquette.Rows.Count;
                for (i = 0; i < nbrroweti2 - 1; i++)
                {
                    string parametre = dataGridViewEtiquette.Rows[i].Cells[1].Value.ToString();
                    dataGridViewParametre2.Rows.Add();
                    dataGridViewParametre2.Rows[i].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    dataGridViewParametre2.Rows[i].Cells[1].Value = parametre;
                }
                tabPage2.Text = etiquette;
                this.listeEtiquetteTableAdapter.Fill2(this.nouvelleBaseEssaieDataSet.ListeEtiquette, produit);
                nbreti = nbreti + 1;
            }


            if (nbreti == 5)
            {
                Parametretabpage.Controls.Add(tabPage3);
                string etiquette3 = comboBoxListeEtiquette.Text;
                this.listeEtiquetteTableAdapter.FiltreByEtiquette(this.nouvelleBaseEssaieDataSet.ListeEtiquette, etiquette3);
                int nbrroweti3 = dataGridViewEtiquette.Rows.Count;
                for (i = 0; i < nbrroweti3 - 1; i++)
                {
                    string parametre = dataGridViewEtiquette.Rows[i].Cells[1].Value.ToString();
                    dataGridViewParametre3.Rows.Add();
                    dataGridViewParametre3.Rows[i].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    dataGridViewParametre3.Rows[i].Cells[1].Value = parametre;
                }
                tabPage3.Text = etiquette;
                this.listeEtiquetteTableAdapter.Fill2(this.nouvelleBaseEssaieDataSet.ListeEtiquette, produit);
                nbreti = nbreti + 1;
            }

            if (nbreti == 7)
            {
                Parametretabpage.Controls.Add(tabPage4);
                string etiquette4 = comboBoxListeEtiquette.Text;
                this.listeEtiquetteTableAdapter.FiltreByEtiquette(this.nouvelleBaseEssaieDataSet.ListeEtiquette, etiquette4);
                int nbrroweti4 = dataGridViewEtiquette.Rows.Count;
                for (i = 0; i < nbrroweti4 - 1; i++)
                {
                    string parametre = dataGridViewEtiquette.Rows[i].Cells[1].Value.ToString();
                    dataGridViewParametre4.Rows.Add();
                    dataGridViewParametre4.Rows[i].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    dataGridViewParametre4.Rows[i].Cells[1].Value = parametre;
                }
                tabPage4.Text = etiquette;
                this.listeEtiquetteTableAdapter.Fill2(this.nouvelleBaseEssaieDataSet.ListeEtiquette, produit);
                nbreti = nbreti + 1;
            }

            if (nbreti == 9)
            {
                Parametretabpage.Controls.Add(tabPage5);
                string etiquette5 = comboBoxListeEtiquette.Text;
                this.listeEtiquetteTableAdapter.FiltreByEtiquette(this.nouvelleBaseEssaieDataSet.ListeEtiquette, etiquette5);
                int nbrroweti5 = dataGridViewEtiquette.Rows.Count;
                for (i = 0; i < nbrroweti5 - 1; i++)
                {
                    string parametre = dataGridViewEtiquette.Rows[i].Cells[1].Value.ToString();
                    dataGridViewParametre5.Rows.Add();
                    dataGridViewParametre5.Rows[i].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    dataGridViewParametre5.Rows[i].Cells[1].Value = parametre;
                }
                tabPage5.Text = etiquette;
                this.listeEtiquetteTableAdapter.Fill2(this.nouvelleBaseEssaieDataSet.ListeEtiquette, produit);
                nbreti = nbreti + 1;
            }

            if (nbreti == 11)
            {
                Parametretabpage.Controls.Add(tabPage6);
                string etiquette6 = comboBoxListeEtiquette.Text;
                this.listeEtiquetteTableAdapter.FiltreByEtiquette(this.nouvelleBaseEssaieDataSet.ListeEtiquette, etiquette6);
                int nbrroweti6 = dataGridViewEtiquette.Rows.Count;
                for (i = 0; i < nbrroweti6 - 1; i++)
                {
                    string parametre = dataGridViewEtiquette.Rows[i].Cells[1].Value.ToString();
                    dataGridViewParametre61.Rows.Add();
                    dataGridViewParametre61.Rows[i].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    dataGridViewParametre61.Rows[i].Cells[1].Value = parametre;
                }
                tabPage6.Text = etiquette;
                this.listeEtiquetteTableAdapter.Fill2(this.nouvelleBaseEssaieDataSet.ListeEtiquette, produit);
                nbreti = nbreti + 1;
            }

            if (nbreti == 13)
            {
                Parametretabpage.Controls.Add(tabPage7);
                string etiquette7 = comboBoxListeEtiquette.Text;
                this.listeEtiquetteTableAdapter.FiltreByEtiquette(this.nouvelleBaseEssaieDataSet.ListeEtiquette, etiquette7);
                int nbrroweti7 = dataGridViewEtiquette.Rows.Count;
                for (i = 0; i < nbrroweti7 - 1; i++)
                {
                    string parametre = dataGridViewEtiquette.Rows[i].Cells[1].Value.ToString();
                    dataGridViewParametre7.Rows.Add();
                    dataGridViewParametre7.Rows[i].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    dataGridViewParametre7.Rows[i].Cells[1].Value = parametre;
                }
                tabPage7.Text = etiquette;
                this.listeEtiquetteTableAdapter.Fill2(this.nouvelleBaseEssaieDataSet.ListeEtiquette, produit);
                nbreti = nbreti + 1;
            }
        }*/

        private void buttonValider_Click(object sender, EventArgs e)
        {
            bool pfil;
            string reef = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
            string tyype = dataGridViewProduit.Rows[0].Cells[1].Value.ToString();
            string famille = dataGridViewProduit.Rows[0].Cells[3].Value.ToString();

            int NbrRowP = dataGridViewParametre.Rows.Count;
            int NbrRowF = dataGridViewFils.Rows.Count;

            for (int i = 0; i < NbrRowP - 1; i++)
            {
                string nameeti = tabPage1.Text;
                string parametre = dataGridViewParametre.Rows[i].Cells[1].Value.ToString();
                string valeur = dataGridViewParametre.Rows[i].Cells[2].Value.ToString();
                this.parametreTableAdapter.InsertParametre(reef, parametre, valeur, nameeti);
            }
            for (int a = 0; a < NbrRowF - 1; a++)
            {
                string type = dataGridViewFils.Rows[a].Cells[1].Value.ToString();
                string fils = dataGridViewFils.Rows[a].Cells[2].Value.ToString();
                string qty = dataGridViewFils.Rows[a].Cells[3].Value.ToString();
                this.arborescenceTableAdapter.InsertArborescence(reef, type, fils, qty);
            }
            if (dataGridViewFils.Rows.Count == 1)
            {
                dataGridViewProduit.Rows[0].Cells[2].Value = false;
                pfil = false;
            }
            else
            {
                dataGridViewProduit.Rows[0].Cells[2].Value = true;
                pfil = true;
            }
            this.produitTableAdapter.InsertProduit(reef, tyype, pfil, famille);


            string raf = reef.Substring(0, 5);
            this.sN_ProduitsFinisTableAdapter.FiltrebyRef(compteurs_SN_IESDataSet.SN_ProduitsFinis, raf);
            if (dataGridViewSN.Rows.Count == 1 )
            { 
                int compteur = 0;
                this.sN_ProduitsFinisTableAdapter.InsertSN(raf, compteur);
            }


            if (dataGridViewParametre2.Rows[0].Cells[0].Value != null)
            {
                int Nbr = dataGridViewParametre2.Rows.Count;
                for (int i = 0; i < Nbr - 1; i++)
                {
                    string nameeti = tabPage2.Text;
                    string parametre = dataGridViewParametre2.Rows[i].Cells[1].Value.ToString();
                    string valeur = dataGridViewParametre2.Rows[i].Cells[2].Value.ToString();
                    this.parametreTableAdapter.InsertParametre(reef, parametre, valeur, nameeti);
                }
            }
            if (dataGridViewParametre3.Rows[0].Cells[0].Value != null)
            {
                int Nbr3 = dataGridViewParametre3.Rows.Count;
                for (int i = 0; i < Nbr3 - 1; i++)
                {
                    string nameeti = tabPage3.Text;
                    string parametre = dataGridViewParametre3.Rows[i].Cells[1].Value.ToString();
                    string valeur = dataGridViewParametre3.Rows[i].Cells[2].Value.ToString();
                    this.parametreTableAdapter.InsertParametre(reef, parametre, valeur, nameeti);
                }
            }
            if (dataGridViewParametre4.Rows[0].Cells[0].Value != null)
            {
                int Nbr4 = dataGridViewParametre4.Rows.Count;
                for (int i = 0; i < Nbr4 - 1; i++)
                {
                    string nameeti = tabPage4.Text;
                    string parametre = dataGridViewParametre4.Rows[i].Cells[1].Value.ToString();
                    string valeur = dataGridViewParametre4.Rows[i].Cells[2].Value.ToString();
                    this.parametreTableAdapter.InsertParametre(reef, parametre, valeur, nameeti);
                }
            }
            if (dataGridViewParametre5.Rows[0].Cells[0].Value != null)
            {
                int Nbr5 = dataGridViewParametre5.Rows.Count;
                for (int i = 0; i < Nbr5 - 1; i++)
                {
                    string nameeti = tabPage5.Text;
                    string parametre = dataGridViewParametre5.Rows[i].Cells[1].Value.ToString();
                    string valeur = dataGridViewParametre5.Rows[i].Cells[2].Value.ToString();
                    this.parametreTableAdapter.InsertParametre(reef, parametre, valeur, nameeti);
                }
            }
            if (dataGridViewParametre61.Rows[0].Cells[0].Value != null)
            {
                int Nbr6 = dataGridViewParametre61.Rows.Count;
                for (int i = 0; i < Nbr6 - 1; i++)
                {
                    string nameeti = tabPage6.Text;
                    string parametre = dataGridViewParametre61.Rows[i].Cells[1].Value.ToString();
                    string valeur = dataGridViewParametre61.Rows[i].Cells[2].Value.ToString();
                    this.parametreTableAdapter.InsertParametre(reef, parametre, valeur, nameeti);
                }
            }
            if (dataGridViewParametre7.Rows[0].Cells[0].Value != null)
            {
                int Nbr7 = dataGridViewParametre7.Rows.Count;
                for (int i = 0; i < Nbr7 - 1; i++)
                {
                    string nameeti = tabPage7.Text;
                    string parametre = dataGridViewParametre7.Rows[i].Cells[1].Value.ToString();
                    string valeur = dataGridViewParametre7.Rows[i].Cells[2].Value.ToString();
                    this.parametreTableAdapter.InsertParametre(reef, parametre, valeur, nameeti);
                }
            }
            System.Windows.Forms.MessageBox.Show("La référence a été créée");
            this.Close();
        }

        private void dataGridViewParametre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string variable = dataGridViewParametre.Rows[row].Cells[1].Value.ToString();
                bool testetl = variable == "CodeETL";
                bool testmac = variable == "ChargePointMac";
                bool testrecap = variable == "PrintRecap";
                bool testimprim = variable == "A_Imprimer";
                bool testindice = variable == "Indice";
                bool testindice2 = variable == "indice";
                bool testOrigine = variable == "Origine";
                bool testOrigin = variable == "Origin";
                bool testorigin = variable == "origin";
                bool testPays = variable == "Pays";
                bool testpays = variable == "pays";
                bool testModele = variable == "Modele";
                bool testModelePath = variable == "Modele_Path";
                if (testetl == true || testmac == true || testrecap == true || testimprim == true)
                {
                    ChoixVraiFaux = new ChoixVraiFaux();
                    ChoixVraiFaux.ShowDialog();
                    string choix = ChoixVraiFaux.choix;
                    dataGridViewParametre.Rows[row].Cells[2].Value = choix;
                }
                if (testindice == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre.Rows[row].Cells[2].Value = indice;
                }
                if (testindice2 == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre.Rows[row].Cells[2].Value = indice;
                }
                if (testOrigine == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre.Rows[row].Cells[2].Value = origine;
                }
                if (testOrigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre.Rows[row].Cells[2].Value = origine;
                }
                if (testorigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre.Rows[row].Cells[2].Value = origine;
                }
                if (testPays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre.Rows[row].Cells[2].Value = pays;
                }
                if (testpays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre.Rows[row].Cells[2].Value = pays;
                }
                if (testModele == true)
                {
                    OpenFileDialog Browser = new OpenFileDialog();
                    Browser.DefaultExt = ".btw";
                    Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                    Browser.ShowDialog();                   
                    string modeleprimaire = Browser.FileName;
                    if (modeleprimaire != "")
                    {
                        int caractere = modeleprimaire.Length;
                        string modele = modeleprimaire.Substring(33, caractere - 33);
                        dataGridViewParametre.Rows[row].Cells[2].Value = modele;
                    }
                }
                if (testModelePath == true)
                {
                    OpenFileDialog Browser = new OpenFileDialog();
                    Browser.DefaultExt = ".btw";
                    Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                    Browser.ShowDialog();
                    string modeleprimaire = Browser.FileName;
                    if (modeleprimaire != "")
                    {
                        int caractere = modeleprimaire.Length;
                        string modele = modeleprimaire.Substring(33, caractere - 33);
                        dataGridViewParametre.Rows[row].Cells[2].Value = modele;
                    }
                }
            }
        }

        private void dataGridViewParametre2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string variable = dataGridViewParametre2.Rows[row].Cells[1].Value.ToString();
                bool testetl = variable == "CodeETL";
                bool testmac = variable == "ChargePointMac";
                bool testrecap = variable == "PrintRecap";
                bool testimprim = variable == "A_Imprimer";
                bool testindice = variable == "Indice";
                bool testindice2 = variable == "indice";
                bool testOrigine = variable == "Origine";
                bool testOrigin = variable == "Origin";
                bool testorigin = variable == "origin";
                bool testPays = variable == "Pays";
                bool testpays = variable == "pays";
                bool testModele = variable == "Modele";
                bool testModelePath = variable == "Modele_Path";
                if (testetl == true || testmac == true || testrecap == true || testimprim == true)
                {
                    ChoixVraiFaux = new ChoixVraiFaux();
                    ChoixVraiFaux.ShowDialog();
                    string choix = ChoixVraiFaux.choix;
                    dataGridViewParametre2.Rows[row].Cells[2].Value = choix;
                }
                if (testindice == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre2.Rows[row].Cells[2].Value = indice;
                }
                if (testindice2 == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre2.Rows[row].Cells[2].Value = indice;
                }
                if (testOrigine == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre2.Rows[row].Cells[2].Value = origine;
                }
                if (testOrigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre2.Rows[row].Cells[2].Value = origine;
                }
                if (testorigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre2.Rows[row].Cells[2].Value = origine;
                }
                if (testPays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre2.Rows[row].Cells[2].Value = pays;
                }
                if (testpays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre2.Rows[row].Cells[2].Value = pays;
                }
                if (testModele == true)
                {
                    OpenFileDialog Browser = new OpenFileDialog();
                    Browser.DefaultExt = ".btw";
                    Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                    Browser.ShowDialog();
                    string modeleprimaire = Browser.FileName;
                    if (modeleprimaire != "")
                    {
                        int caractere = modeleprimaire.Length;
                        string modele = modeleprimaire.Substring(33, caractere - 33);
                        dataGridViewParametre2.Rows[row].Cells[2].Value = modele;
                    }
                }
                if (testModelePath == true)
                {
                    OpenFileDialog Browser = new OpenFileDialog();
                    Browser.DefaultExt = ".btw";
                    Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                    Browser.ShowDialog();
                    string modeleprimaire = Browser.FileName;
                    if (modeleprimaire != "")
                    {
                        int caractere = modeleprimaire.Length;
                        string modele = modeleprimaire.Substring(33, caractere - 33);
                        dataGridViewParametre2.Rows[row].Cells[2].Value = modele;
                    }
                }
            }
        }

        private void dataGridViewParametre3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string variable = dataGridViewParametre3.Rows[row].Cells[1].Value.ToString();
                bool testetl = variable == "CodeETL";
                bool testmac = variable == "ChargePointMac";
                bool testrecap = variable == "PrintRecap";
                bool testimprim = variable == "A_Imprimer";
                bool testindice = variable == "Indice";
                bool testindice2 = variable == "indice";
                bool testOrigine = variable == "Origine";
                bool testOrigin = variable == "Origin";
                bool testorigin = variable == "origin";
                bool testPays = variable == "Pays";
                bool testpays = variable == "pays";
                bool testModele = variable == "Modele";
                bool testModelePath = variable == "Modele_Path";
                if (testetl == true || testmac == true || testrecap == true || testimprim == true)
                {
                    ChoixVraiFaux = new ChoixVraiFaux();
                    ChoixVraiFaux.ShowDialog();
                    string choix = ChoixVraiFaux.choix;
                    dataGridViewParametre3.Rows[row].Cells[2].Value = choix;
                }
                if (testindice == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre3.Rows[row].Cells[2].Value = indice;
                }
                if (testindice2 == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre3.Rows[row].Cells[2].Value = indice;
                }
                if (testOrigine == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre3.Rows[row].Cells[2].Value = origine;
                }
                if (testOrigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre3.Rows[row].Cells[2].Value = origine;
                }
                if (testorigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre3.Rows[row].Cells[2].Value = origine;
                }
                if (testPays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre3.Rows[row].Cells[2].Value = pays;
                }
                if (testpays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre3.Rows[row].Cells[2].Value = pays;
                }
                if (testModele == true)
                {
                    OpenFileDialog Browser = new OpenFileDialog();
                    Browser.DefaultExt = ".btw";
                    Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                    Browser.ShowDialog();
                    string modeleprimaire = Browser.FileName;
                    if (modeleprimaire != "")
                    {
                        int caractere = modeleprimaire.Length;
                        string modele = modeleprimaire.Substring(33, caractere - 33);
                        dataGridViewParametre3.Rows[row].Cells[2].Value = modele;
                    }
                }
                if (testModelePath == true)
                {
                    OpenFileDialog Browser = new OpenFileDialog();
                    Browser.DefaultExt = ".btw";
                    Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                    Browser.ShowDialog();
                    string modeleprimaire = Browser.FileName;
                    if (modeleprimaire != "")
                    {
                        int caractere = modeleprimaire.Length;
                        string modele = modeleprimaire.Substring(33, caractere - 33);
                        dataGridViewParametre3.Rows[row].Cells[2].Value = modele;
                    }
                }
            }
        }

        private void dataGridViewParametre4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string variable = dataGridViewParametre4.Rows[row].Cells[1].Value.ToString();
                bool testetl = variable == "CodeETL";
                bool testmac = variable == "ChargePointMac";
                bool testrecap = variable == "PrintRecap";
                bool testimprim = variable == "A_Imprimer";
                bool testindice = variable == "Indice";
                bool testindice2 = variable == "indice";
                bool testOrigine = variable == "Origine";
                bool testOrigin = variable == "Origin";
                bool testorigin = variable == "origin";
                bool testPays = variable == "Pays";
                bool testpays = variable == "pays";
                bool testModele = variable == "Modele";
                bool testModelePath = variable == "Modele_Path";
                if (testetl == true || testmac == true || testrecap == true || testimprim == true)
                {
                    ChoixVraiFaux = new ChoixVraiFaux();
                    ChoixVraiFaux.ShowDialog();
                    string choix = ChoixVraiFaux.choix;
                    dataGridViewParametre4.Rows[row].Cells[2].Value = choix;
                }
                if (testindice == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre4.Rows[row].Cells[2].Value = indice;
                }
                if (testindice2 == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre4.Rows[row].Cells[2].Value = indice;
                }
                if (testOrigine == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre4.Rows[row].Cells[2].Value = origine;
                }
                if (testOrigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre4.Rows[row].Cells[2].Value = origine;
                }
                if (testorigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre4.Rows[row].Cells[2].Value = origine;
                }
                if (testPays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre4.Rows[row].Cells[2].Value = pays;
                }
                if (testpays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre4.Rows[row].Cells[2].Value = pays;
                }
                if (testModele == true)
                {
                    OpenFileDialog Browser = new OpenFileDialog();
                    Browser.DefaultExt = ".btw";
                    Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                    Browser.ShowDialog();
                    string modeleprimaire = Browser.FileName;
                    if (modeleprimaire != "")
                    {
                        int caractere = modeleprimaire.Length;
                        string modele = modeleprimaire.Substring(33, caractere - 33);
                        dataGridViewParametre4.Rows[row].Cells[2].Value = modele;
                    }
                }
                if (testModelePath == true)
                {
                    OpenFileDialog Browser = new OpenFileDialog();
                    Browser.DefaultExt = ".btw";
                    Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                    Browser.ShowDialog();
                    string modeleprimaire = Browser.FileName;
                    if (modeleprimaire != "")
                    {
                        int caractere = modeleprimaire.Length;
                        string modele = modeleprimaire.Substring(33, caractere - 33);
                        dataGridViewParametre4.Rows[row].Cells[2].Value = modele;
                    }
                }
            }
        }

        private void dataGridViewParametre5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string variable = dataGridViewParametre5.Rows[row].Cells[1].Value.ToString();
                bool testetl = variable == "CodeETL";
                bool testmac = variable == "ChargePointMac";
                bool testrecap = variable == "PrintRecap";
                bool testimprim = variable == "A_Imprimer";
                bool testindice = variable == "Indice";
                bool testindice2 = variable == "indice";
                bool testOrigine = variable == "Origine";
                bool testOrigin = variable == "Origin";
                bool testorigin = variable == "origin";
                bool testPays = variable == "Pays";
                bool testpays = variable == "pays";
                bool testModele = variable == "Modele";
                bool testModelePath = variable == "Modele_Path";
                if (testetl == true || testmac == true || testrecap == true || testimprim == true)
                {
                    ChoixVraiFaux = new ChoixVraiFaux();
                    ChoixVraiFaux.ShowDialog();
                    string choix = ChoixVraiFaux.choix;
                    dataGridViewParametre5.Rows[row].Cells[2].Value = choix;
                }
                if (testindice == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre5.Rows[row].Cells[2].Value = indice;
                }
                if (testindice2 == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre5.Rows[row].Cells[2].Value = indice;
                }
                if (testOrigine == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre5.Rows[row].Cells[2].Value = origine;
                }
                if (testOrigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre5.Rows[row].Cells[2].Value = origine;
                }
                if (testorigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre5.Rows[row].Cells[2].Value = origine;
                }
                if (testPays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre5.Rows[row].Cells[2].Value = pays;
                }
                if (testpays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre5.Rows[row].Cells[2].Value = pays;
                }
                if (testModele == true)
                {
                    OpenFileDialog Browser = new OpenFileDialog();
                    Browser.DefaultExt = ".btw";
                    Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                    Browser.ShowDialog();
                    string modeleprimaire = Browser.FileName;
                    if (modeleprimaire != "")
                    {
                        int caractere = modeleprimaire.Length;
                        string modele = modeleprimaire.Substring(33, caractere - 33);
                        dataGridViewParametre5.Rows[row].Cells[2].Value = modele;
                    }
                }
                if (testModelePath == true)
                {
                    OpenFileDialog Browser = new OpenFileDialog();
                    Browser.DefaultExt = ".btw";
                    Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                    Browser.ShowDialog();
                    string modeleprimaire = Browser.FileName;
                    if (modeleprimaire != "")
                    {
                        int caractere = modeleprimaire.Length;
                        string modele = modeleprimaire.Substring(33, caractere - 33);
                        dataGridViewParametre5.Rows[row].Cells[2].Value = modele;
                    }
                }
            }
        }

        private void dataGridViewParametre61_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string variable = dataGridViewParametre61.Rows[row].Cells[1].Value.ToString();
                bool testetl = variable == "CodeETL";
                bool testmac = variable == "ChargePointMac";
                bool testrecap = variable == "PrintRecap";
                bool testimprim = variable == "A_Imprimer";
                bool testindice = variable == "Indice";
                bool testindice2 = variable == "indice";
                bool testOrigine = variable == "Origine";
                bool testOrigin = variable == "Origin";
                bool testorigin = variable == "origin";
                bool testPays = variable == "Pays";
                bool testpays = variable == "pays";
                bool testModele = variable == "Modele";
                bool testModelePath = variable == "Modele_Path";
                if (testetl == true || testmac == true || testrecap == true || testimprim == true)
                {
                    ChoixVraiFaux = new ChoixVraiFaux();
                    ChoixVraiFaux.ShowDialog();
                    string choix = ChoixVraiFaux.choix;
                    dataGridViewParametre61.Rows[row].Cells[2].Value = choix;
                }
                if (testindice == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre61.Rows[row].Cells[2].Value = indice;
                }
                if (testindice2 == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre61.Rows[row].Cells[2].Value = indice;
                }
                if (testOrigine == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre61.Rows[row].Cells[2].Value = origine;
                }
                if (testOrigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre61.Rows[row].Cells[2].Value = origine;
                }
                if (testorigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre61.Rows[row].Cells[2].Value = origine;
                }
                if (testPays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre61.Rows[row].Cells[2].Value = pays;
                }
                if (testpays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre61.Rows[row].Cells[2].Value = pays;
                }
                if (testModele == true)
                {
                    OpenFileDialog Browser = new OpenFileDialog();
                    Browser.DefaultExt = ".btw";
                    Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                    Browser.ShowDialog();
                    string modeleprimaire = Browser.FileName;
                    if (modeleprimaire != "")
                    {
                        int caractere = modeleprimaire.Length;
                        string modele = modeleprimaire.Substring(33, caractere - 33);
                        dataGridViewParametre61.Rows[row].Cells[2].Value = modele;
                    }
                }
                if (testModelePath == true)
                {
                    OpenFileDialog Browser = new OpenFileDialog();
                    Browser.DefaultExt = ".btw";
                    Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                    Browser.ShowDialog();
                    string modeleprimaire = Browser.FileName;
                    if (modeleprimaire != "")
                    {
                        int caractere = modeleprimaire.Length;
                        string modele = modeleprimaire.Substring(33, caractere - 33);
                        dataGridViewParametre61.Rows[row].Cells[2].Value = modele;
                    }
                }
            }
        }

        private void dataGridViewParametre7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string variable = dataGridViewParametre7.Rows[row].Cells[1].Value.ToString();
                bool testetl = variable == "CodeETL";
                bool testmac = variable == "ChargePointMac";
                bool testrecap = variable == "PrintRecap";
                bool testimprim = variable == "A_Imprimer";
                bool testindice = variable == "Indice";
                bool testindice2 = variable == "indice";
                bool testOrigine = variable == "Origine";
                bool testOrigin = variable == "Origin";
                bool testorigin = variable == "origin";
                bool testPays = variable == "Pays";
                bool testpays = variable == "pays";
                bool testModele = variable == "Modele";
                bool testModelePath = variable == "Modele_Path";
                if (testetl == true || testmac == true || testrecap == true || testimprim == true)
                {
                    ChoixVraiFaux = new ChoixVraiFaux();
                    ChoixVraiFaux.ShowDialog();
                    string choix = ChoixVraiFaux.choix;
                    dataGridViewParametre7.Rows[row].Cells[2].Value = choix;
                }
                if (testindice == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre7.Rows[row].Cells[2].Value = indice;
                }
                if (testindice2 == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre7.Rows[row].Cells[2].Value = indice;
                }
                if (testOrigine == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre7.Rows[row].Cells[2].Value = origine;
                }
                if (testOrigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre7.Rows[row].Cells[2].Value = origine;
                }
                if (testorigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre7.Rows[row].Cells[2].Value = origine;
                }
                if (testPays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre7.Rows[row].Cells[2].Value = pays;
                }
                if (testpays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre7.Rows[row].Cells[2].Value = pays;
                }
                if (testModele == true)
                {
                    OpenFileDialog Browser = new OpenFileDialog();
                    Browser.DefaultExt = ".btw";
                    Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                    Browser.ShowDialog();
                    string modeleprimaire = Browser.FileName;
                    if (modeleprimaire != "")
                    {
                        int caractere = modeleprimaire.Length;
                        string modele = modeleprimaire.Substring(33, caractere - 33);
                        dataGridViewParametre7.Rows[row].Cells[2].Value = modele;
                    }
                }
                if (testModelePath == true)
                {
                    OpenFileDialog Browser = new OpenFileDialog();
                    Browser.DefaultExt = ".btw";
                    Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                    Browser.ShowDialog();
                    string modeleprimaire = Browser.FileName;
                    if (modeleprimaire != "")
                    {
                        int caractere = modeleprimaire.Length;
                        string modele = modeleprimaire.Substring(33, caractere - 33);
                        dataGridViewParametre7.Rows[row].Cells[2].Value = modele;
                    }
                }
            }
        }


        private void dataGridViewFils_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn &&
                e.RowIndex >= 0)
            {
                string fils = dataGridViewFils.Rows[row].Cells[4].Value.ToString();
                int fils1 = fils.Length;
                string reffils = fils.Substring(0, 8);

                string carte = fils.Substring(11, fils1 - 11);
                dataGridViewFils.Rows[row].Cells[2].Value = reffils;
                dataGridViewFils.Rows[row].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                dataGridViewFils.Rows[row].Cells[1].Value = carte;
            }
        }

        private void dataGridViewParametre_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn &&
                e.RowIndex >= 0)
            {
                string parametre = dataGridViewParametre.Rows[row].Cells[3].Value.ToString();
                dataGridViewParametre.Rows[row].Cells[1].Value = parametre;
                dataGridViewParametre.Rows[row].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
            }
        }

        private void dataGridViewParametre2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn &&
                e.RowIndex >= 0)
            {
                string parametre = dataGridViewParametre2.Rows[row].Cells[3].Value.ToString();
                dataGridViewParametre2.Rows[row].Cells[1].Value = parametre;
                dataGridViewParametre2.Rows[row].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
            }
        }

        private void dataGridViewParametre3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn &&
                e.RowIndex >= 0)
            {
                string parametre = dataGridViewParametre3.Rows[row].Cells[3].Value.ToString();
                dataGridViewParametre3.Rows[row].Cells[1].Value = parametre;
                dataGridViewParametre3.Rows[row].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
            }
        }

        private void dataGridViewParametre4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn &&
                e.RowIndex >= 0)
            {
                string parametre = dataGridViewParametre4.Rows[row].Cells[3].Value.ToString();
                dataGridViewParametre4.Rows[row].Cells[1].Value = parametre;
                dataGridViewParametre4.Rows[row].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
            }
        }

        private void dataGridViewParametre5_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn &&
                e.RowIndex >= 0)
            {
                string parametre = dataGridViewParametre5.Rows[row].Cells[3].Value.ToString();
                dataGridViewParametre5.Rows[row].Cells[1].Value = parametre;
                dataGridViewParametre5.Rows[row].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
            }
        }

        private void dataGridViewParametre61_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn &&
                e.RowIndex >= 0)
            {
                string parametre = dataGridViewParametre61.Rows[row].Cells[3].Value.ToString();
                dataGridViewParametre61.Rows[row].Cells[1].Value = parametre;
                dataGridViewParametre61.Rows[row].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
            }
        }

        private void dataGridViewParametre7_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn &&
                e.RowIndex >= 0)
            {
                string parametre = dataGridViewParametre7.Rows[row].Cells[3].Value.ToString();
                dataGridViewParametre7.Rows[row].Cells[1].Value = parametre;
                dataGridViewParametre7.Rows[row].Cells[0].Value = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEtiquette_Click(object sender, EventArgs e)
        {
            nbreti = nbreti + 1;
            if (nbreti == 1)
            {
                OpenFileDialog Browser = new OpenFileDialog();
                Browser.DefaultExt = ".btw";
                Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                Browser.ShowDialog();
                string modeleprimaire = Browser.FileName;
                if (modeleprimaire != "")
                {
                    int caractere = modeleprimaire.Length;
                    string modele = modeleprimaire.Substring(33, caractere - 33);
                    Parametretabpage.Visible = true;
                    tabPage1.Text = modele;
                    buttonValider.Visible = true;
                    MessageBox.Show(modele);
                }
                nbreti = nbreti + 1;
            }
            if (nbreti == 3)
            {
                OpenFileDialog Browser = new OpenFileDialog();
                Browser.DefaultExt = ".btw";
                Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                Browser.ShowDialog();
                string modeleprimaire = Browser.FileName;
                if (modeleprimaire != "")
                {
                    int caractere = modeleprimaire.Length;
                    string modele = modeleprimaire.Substring(33, caractere - 33);
                    Parametretabpage.Controls.Add(tabPage2);
                    tabPage2.Text = modele;                   
                    buttonValider.Visible = true;
                    MessageBox.Show(modele);
                }
                nbreti = nbreti + 1;
            }
            if (nbreti == 5)
            {
                OpenFileDialog Browser = new OpenFileDialog();
                Browser.DefaultExt = ".btw";
                Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                Browser.ShowDialog();
                string modeleprimaire = Browser.FileName;
                if (modeleprimaire != "")
                {
                    int caractere = modeleprimaire.Length;
                    string modele = modeleprimaire.Substring(33, caractere - 33);
                    Parametretabpage.Controls.Add(tabPage3);
                    tabPage3.Text = modele;
                    buttonValider.Visible = true;
                    MessageBox.Show(modele);
                }
                nbreti = nbreti + 1;
            }
            if (nbreti == 7)
            {
                OpenFileDialog Browser = new OpenFileDialog();
                Browser.DefaultExt = ".btw";
                Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                Browser.ShowDialog();
                string modeleprimaire = Browser.FileName;
                if (modeleprimaire != "")
                {
                    int caractere = modeleprimaire.Length;
                    string modele = modeleprimaire.Substring(33, caractere - 33);
                    Parametretabpage.Controls.Add(tabPage4);
                    tabPage4.Text = modele;
                    buttonValider.Visible = true;
                    MessageBox.Show(modele);
                }
                nbreti = nbreti + 1;
            }
            if (nbreti == 9)
            {
                OpenFileDialog Browser = new OpenFileDialog();
                Browser.DefaultExt = ".btw";
                Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                Browser.ShowDialog();
                string modeleprimaire = Browser.FileName;
                if (modeleprimaire != "")
                {
                    int caractere = modeleprimaire.Length;
                    string modele = modeleprimaire.Substring(33, caractere - 33);
                    Parametretabpage.Controls.Add(tabPage5);
                    tabPage5.Text = modele;
                    buttonValider.Visible = true;
                    MessageBox.Show(modele);
                }
                nbreti = nbreti + 1;
            }
            if (nbreti == 11)
            {
                OpenFileDialog Browser = new OpenFileDialog();
                Browser.DefaultExt = ".btw";
                Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                Browser.ShowDialog();
                string modeleprimaire = Browser.FileName;
                if (modeleprimaire != "")
                {
                    int caractere = modeleprimaire.Length;
                    string modele = modeleprimaire.Substring(33, caractere - 33);
                    Parametretabpage.Controls.Add(tabPage6);
                    tabPage6.Text = modele;
                    buttonValider.Visible = true;
                    MessageBox.Show(modele);
                }
                nbreti = nbreti + 1;
            }
            if (nbreti == 13)
            {
                OpenFileDialog Browser = new OpenFileDialog();
                Browser.DefaultExt = ".btw";
                Browser.InitialDirectory = "S:\\Production\\Etiquettes\\MODELES";
                Browser.ShowDialog();
                string modeleprimaire = Browser.FileName;
                if (modeleprimaire != "")
                {
                    int caractere = modeleprimaire.Length;
                    string modele = modeleprimaire.Substring(33, caractere - 33);
                    Parametretabpage.Controls.Add(tabPage7);
                    tabPage7.Text = modele;
                    buttonValider.Visible = true;
                    MessageBox.Show(modele);
                }
                nbreti = nbreti + 1;
            }
        }
    }
}