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
    public partial class Dupliquer : Form
    {
        public int nbreti = 0;
        DupliquerReference DupliquerReference;
        public string reference;
        public string famille;
        ChoixVraiFaux ChoixVraiFaux;
        ChoixOrigine ChoixOrigine;
        ChoixPays ChoixPays;
        public Dupliquer()
        {
            InitializeComponent();
        }
        private void Dupliquer_Load(object sender, EventArgs e)
        {
            string reef = reference;
            string familles = famille;
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.RequeteFils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.requeteFilsTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.RequeteFils);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ReferenceFils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.referenceFilsTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.ReferenceFils);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.FiltrebyRef(this.nouvelleBaseEssaieDataSet.Produit, reef);
            // définie le produit
            string produit = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.Parametre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeFamilleTableAdapter.FiltreFamilleByProduct(this.nouvelleBaseEssaieDataSet.TypeFamille, familles);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.Arborescence'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.arborescenceTableAdapter.FiltreFilsByRef(this.nouvelleBaseEssaieDataSet.Arborescence, produit);
            // Définie la nature du produit
            string natureproduit = dataGridViewNatureDuProduit1.Rows[0].Cells[0].Value.ToString();
            // // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ParametreListe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.parametreListeTableAdapter.FiltreListeParametre(this.nouvelleBaseEssaieDataSet.ParametreListe, natureproduit);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ListeEtiquette'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listeEtiquetteTableAdapter.Fill2(this.nouvelleBaseEssaieDataSet.ListeEtiquette, natureproduit);
            // Création de la nouvelle Référence
            DupliquerReference = new DupliquerReference();
            DupliquerReference.ShowDialog();
            string novuellereference = DupliquerReference.nouvellereferences;
            // Application de la nouvelle Référence
            dataGridViewProduit.Rows[0].Cells[0].Value = novuellereference;
            // Détermine le nombre d'étiquettes
            this.parametreTableAdapter.FillNbrEti(this.nouvelleBaseEssaieDataSet.Parametre, reef);
            // Récupère les étiquettes et les paramètres dédié
            GetEtiquette(out int nbretiq);
            // Récupère le nombres de ligne dans fils pour poser la nouvelle ref
            int rowfils = dataGridViewFils.Rows.Count;
            if (rowfils > 1)
            {
                for (int i = 0; i < rowfils - 1; i++)
                {
                    dataGridViewFils.Rows[i].Cells[0].Value = novuellereference;
                }
            }
            // Si une étiquette est detecté
            if (nbretiq > 0)
            {
                int row = dataGridViewParametre.Rows.Count;
                for (int x = 0; x < row - 1; x++)
                {
                    string Parametre = dataGridViewParametre.Rows[x].Cells[1].Value.ToString();
                    GetAutoPara(Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays);
                    if (testetl == true || testmac == true || testrecap == true || testimprim == true || testindice == true || testindice2 == true || testOrigine == true || testOrigin == true || testorigin == true || testPays == true || testpays == true)
                    {
                        dataGridViewParametre.Rows[x].Cells[4].Style.BackColor = Color.Red;
                        dataGridViewParametre.Rows[x].Cells[4].Value = "OK";
                    }
                    dataGridViewParametre.Rows[x].Cells[0].Value = novuellereference;
                }
            }
            // Si 2 étiquette sont detecté
            if (nbretiq > 1)
            {
                int rowpara2 = dataGridViewParametre2.Rows.Count;
                for (int x = 0; x < rowpara2 - 1; x++)
                {
                    string Parametre = dataGridViewParametre2.Rows[x].Cells[1].Value.ToString();
                    GetAutoPara(Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays);
                    if (testetl == true || testmac == true || testrecap == true || testimprim == true || testindice == true || testindice2 == true || testOrigine == true || testOrigin == true || testorigin == true || testPays == true || testpays == true)
                    {
                        dataGridViewParametre2.Rows[x].Cells[4].Style.BackColor = Color.Red;
                        dataGridViewParametre2.Rows[x].Cells[4].Value = "OK";
                    }
                    dataGridViewParametre2.Rows[x].Cells[0].Value = novuellereference;
                }
            }
            // Si 3 étiquette sont detecté
            if (nbretiq > 2)
            {
                int rowpara3 = dataGridViewParametre3.Rows.Count;
                for (int x = 0; x < rowpara3 - 1; x++)
                {
                    string Parametre = dataGridViewParametre3.Rows[x].Cells[1].Value.ToString();
                    GetAutoPara(Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays);
                    if (testetl == true || testmac == true || testrecap == true || testimprim == true || testindice == true || testindice2 == true || testOrigine == true || testOrigin == true || testorigin == true || testPays == true || testpays == true)
                    {
                        dataGridViewParametre3.Rows[x].Cells[4].Style.BackColor = Color.Red;
                        dataGridViewParametre3.Rows[x].Cells[4].Value = "OK";
                    }
                    dataGridViewParametre3.Rows[x].Cells[0].Value = novuellereference;
                }
            }
            // Si 4 étiquette sont detecté
            if (nbretiq > 3)
            {
                int rowpara4 = dataGridViewParametre4.Rows.Count;
                for (int x = 0; x < rowpara4 - 1; x++)
                {
                    string Parametre = dataGridViewParametre4.Rows[x].Cells[1].Value.ToString();
                    GetAutoPara(Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays);
                    if (testetl == true || testmac == true || testrecap == true || testimprim == true || testindice == true || testindice2 == true || testOrigine == true || testOrigin == true || testorigin == true || testPays == true || testpays == true)
                    {
                        dataGridViewParametre4.Rows[x].Cells[4].Style.BackColor = Color.Red;
                        dataGridViewParametre4.Rows[x].Cells[4].Value = "OK";
                    }
                    dataGridViewParametre4.Rows[x].Cells[0].Value = novuellereference;
                }
            }
            // Si 5 étiquette sont detecté
            if (nbretiq > 4)
            {
                int rowpara5 = dataGridViewParametre5.Rows.Count;
                for (int x = 0; x < rowpara5 - 1; x++)
                {
                    string Parametre = dataGridViewParametre5.Rows[x].Cells[1].Value.ToString();
                    GetAutoPara(Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays);
                    if (testetl == true || testmac == true || testrecap == true || testimprim == true || testindice == true || testindice2 == true || testOrigine == true || testOrigin == true || testorigin == true || testPays == true || testpays == true)
                    {
                        dataGridViewParametre5.Rows[x].Cells[4].Style.BackColor = Color.Red;
                        dataGridViewParametre5.Rows[x].Cells[4].Value = "OK";
                    }
                    dataGridViewParametre5.Rows[x].Cells[0].Value = novuellereference;
                }
            }
            // Si 6 étiquette sont detecté
            if (nbretiq > 5)
            {
                int rowpara6 = dataGridViewParametre61.Rows.Count;
                for (int x = 0; x < rowpara6 - 1; x++)
                {
                    string Parametre = dataGridViewParametre61.Rows[x].Cells[1].Value.ToString();
                    GetAutoPara(Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays);
                    if (testetl == true || testmac == true || testrecap == true || testimprim == true || testindice == true || testindice2 == true || testOrigine == true || testOrigin == true || testorigin == true || testPays == true || testpays == true)
                    {
                        dataGridViewParametre61.Rows[x].Cells[4].Style.BackColor = Color.Red;
                        dataGridViewParametre61.Rows[x].Cells[4].Value = "OK";
                    }
                    dataGridViewParametre61.Rows[x].Cells[0].Value = novuellereference;
                }
            }
            // Si 7 étiquette sont detecté
            if (nbretiq > 6)
            {
                int rowpara7 = dataGridViewParametre7.Rows.Count;
                for (int x = 0; x < rowpara7 - 1; x++)
                {
                    string Parametre = dataGridViewParametre7.Rows[x].Cells[1].Value.ToString();
                    GetAutoPara(Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays);
                    if (testetl == true || testmac == true || testrecap == true || testimprim == true || testindice == true || testindice2 == true || testOrigine == true || testOrigin == true || testorigin == true || testPays == true || testpays == true)
                    {
                        dataGridViewParametre7.Rows[x].Cells[4].Style.BackColor = Color.Red;
                        dataGridViewParametre7.Rows[x].Cells[4].Value = "OK";
                    }
                    dataGridViewParametre7.Rows[x].Cells[0].Value = novuellereference;
                }
            }
        }
        // Remplie automatiqument le paramètre en cliquant sur le bouton "Remplir Automatiquement"
        private void dataGridViewParametre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string Parametre = dataGridViewParametre.Rows[row].Cells[1].Value.ToString();
                GetAutoPara(Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays);
                if (testetl == true || testmac == true || testrecap == true || testimprim == true)
                {
                    ChoixVraiFaux = new ChoixVraiFaux();
                    ChoixVraiFaux.ShowDialog();
                    string choix = ChoixVraiFaux.choix;
                    dataGridViewParametre.Rows[row].Cells[2].Value = choix;
                }
                if (testindice == true || testindice2 == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre.Rows[row].Cells[2].Value = indice;
                }
                if (testOrigine == true || testOrigin == true || testorigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre.Rows[row].Cells[2].Value = origine;
                }
                if (testPays == true || testpays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre.Rows[row].Cells[2].Value = pays;
                }
            }
        }
        // Remplie automatiqument le paramètre en cliquant sur le bouton "Remplir Automatiquement"
        private void dataGridViewParametre2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string Parametre = dataGridViewParametre2.Rows[row].Cells[1].Value.ToString();
                GetAutoPara(Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays);
                if (testetl == true || testmac == true || testrecap == true || testimprim == true)
                {
                    ChoixVraiFaux = new ChoixVraiFaux();
                    ChoixVraiFaux.ShowDialog();
                    string choix = ChoixVraiFaux.choix;
                    dataGridViewParametre2.Rows[row].Cells[2].Value = choix;
                }
                if (testindice == true || testindice2 == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre2.Rows[row].Cells[2].Value = indice;
                }
                if (testOrigine == true || testOrigin == true || testorigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre2.Rows[row].Cells[2].Value = origine;
                }
                if (testPays == true || testpays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre2.Rows[row].Cells[2].Value = pays;
                }
            }
        }
        // Remplie automatiqument le paramètre en cliquant sur le bouton "Remplir Automatiquement"
        private void dataGridViewParametre3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string Parametre = dataGridViewParametre3.Rows[row].Cells[1].Value.ToString();
                GetAutoPara(Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays);
                if (testetl == true || testmac == true || testrecap == true || testimprim == true)
                {
                    ChoixVraiFaux = new ChoixVraiFaux();
                    ChoixVraiFaux.ShowDialog();
                    string choix = ChoixVraiFaux.choix;
                    dataGridViewParametre3.Rows[row].Cells[2].Value = choix;
                }
                if (testindice == true || testindice2 == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre3.Rows[row].Cells[2].Value = indice;
                }
                if (testOrigine == true || testOrigin == true || testorigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre3.Rows[row].Cells[2].Value = origine;
                }
                if (testPays == true || testpays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre3.Rows[row].Cells[2].Value = pays;
                }
            }
        }
        // Remplie automatiqument le paramètre en cliquant sur le bouton "Remplir Automatiquement"
        private void dataGridViewParametre4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string Parametre = dataGridViewParametre4.Rows[row].Cells[1].Value.ToString();
                GetAutoPara(Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays);
                if (testetl == true || testmac == true || testrecap == true || testimprim == true)
                {
                    ChoixVraiFaux = new ChoixVraiFaux();
                    ChoixVraiFaux.ShowDialog();
                    string choix = ChoixVraiFaux.choix;
                    dataGridViewParametre4.Rows[row].Cells[2].Value = choix;
                }
                if (testindice == true || testindice2 == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre4.Rows[row].Cells[2].Value = indice;
                }
                if (testOrigine == true || testOrigin == true || testorigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre4.Rows[row].Cells[2].Value = origine;
                }
                if (testPays == true || testpays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre4.Rows[row].Cells[2].Value = pays;
                }
            }
        }
        // Remplie automatiqument le paramètre en cliquant sur le bouton "Remplir Automatiquement"
        private void dataGridViewParametre5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string Parametre = dataGridViewParametre5.Rows[row].Cells[1].Value.ToString();
                GetAutoPara(Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays);
                if (testetl == true || testmac == true || testrecap == true || testimprim == true)
                {
                    ChoixVraiFaux = new ChoixVraiFaux();
                    ChoixVraiFaux.ShowDialog();
                    string choix = ChoixVraiFaux.choix;
                    dataGridViewParametre5.Rows[row].Cells[2].Value = choix;
                }
                if (testindice == true || testindice2 == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre5.Rows[row].Cells[2].Value = indice;
                }
                if (testOrigine == true || testOrigin == true || testorigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre5.Rows[row].Cells[2].Value = origine;
                }
                if (testPays == true || testpays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre5.Rows[row].Cells[2].Value = pays;
                }
            }
        }
        // Remplie automatiqument le paramètre en cliquant sur le bouton "Remplir Automatiquement"
        private void dataGridViewParametre61_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string Parametre = dataGridViewParametre61.Rows[row].Cells[1].Value.ToString();
                GetAutoPara(Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays);
                if (testetl == true || testmac == true || testrecap == true || testimprim == true)
                {
                    ChoixVraiFaux = new ChoixVraiFaux();
                    ChoixVraiFaux.ShowDialog();
                    string choix = ChoixVraiFaux.choix;
                    dataGridViewParametre61.Rows[row].Cells[2].Value = choix;
                }
                if (testindice == true || testindice2 == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre61.Rows[row].Cells[2].Value = indice;
                }
                if (testOrigine == true || testOrigin == true || testorigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre61.Rows[row].Cells[2].Value = origine;
                }
                if (testPays == true || testpays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre61.Rows[row].Cells[2].Value = pays;
                }
            }
        }
        // Remplie automatiqument le paramètre en cliquant sur le bouton "Remplir Automatiquement"
        private void dataGridViewParametre7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string Parametre = dataGridViewParametre7.Rows[row].Cells[1].Value.ToString();
                GetAutoPara(Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays);
                if (testetl == true || testmac == true || testrecap == true || testimprim == true)
                {
                    ChoixVraiFaux = new ChoixVraiFaux();
                    ChoixVraiFaux.ShowDialog();
                    string choix = ChoixVraiFaux.choix;
                    dataGridViewParametre7.Rows[row].Cells[2].Value = choix;
                }
                if (testindice == true || testindice2 == true)
                {
                    string reference = dataGridViewProduit.Rows[0].Cells[0].Value.ToString();
                    string indice = reference.Substring(6, 2);
                    dataGridViewParametre7.Rows[row].Cells[2].Value = indice;
                }
                if (testOrigine == true || testOrigin == true || testorigin == true)
                {
                    ChoixOrigine = new ChoixOrigine();
                    ChoixOrigine.ShowDialog();
                    string origine = ChoixOrigine.origine;
                    dataGridViewParametre7.Rows[row].Cells[2].Value = origine;
                }
                if (testPays == true || testpays == true)
                {
                    ChoixPays = new ChoixPays();
                    ChoixPays.ShowDialog();
                    string pays = ChoixPays.pays;
                    dataGridViewParametre7.Rows[row].Cells[2].Value = pays;
                }
            }
        }
        // Envoie les Modfifications dans les BDD
        private void button_Valider_Click(object sender, EventArgs e)
        {
            Validation();
            MessageBox.Show("Update successful");
            this.Close();
        }
        // Récupère le paramètre selectionné avec le "combobox ajouter un paramètre" dans le datagridview paramètre
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
        // Récupère le paramètre selectionné avec le "combobox ajouter un paramètre" dans le datagridview paramètre
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
        // Récupère le paramètre selectionné avec le "combobox ajouter un paramètre" dans le datagridview paramètre
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
        // Récupère le paramètre selectionné avec le "combobox ajouter un paramètre" dans le datagridview paramètre
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
        // Récupère le paramètre selectionné avec le "combobox ajouter un paramètre" dans le datagridview paramètre
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
        // Récupère le paramètre selectionné avec le "combobox ajouter un paramètre" dans le datagridview paramètre
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
        // Récupère le paramètre selectionné avec le "combobox ajouter un paramètre" dans le datagridview paramètre
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
        // Récupère le paramètre selectionné avec le "combobox ajouter un paramètre" dans le datagridview paramètre
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
        // Ferme le logiciel sans enregistré les modifs
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // test
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
                    MessageBox.Show(modele);
                }
                nbreti = nbreti + 1;
            }
        }
        private void GetEtiquette(out int nbretiq)
        {
            DataGridView dataGridViewVerifProduit = new DataGridView();
            EtiquetteHelper etiqHelper = new EtiquetteHelper(ref reference, ref Parametretabpage, ref tabPage1, ref tabPage2, ref tabPage3, ref tabPage4, ref tabPage5, ref tabPage6, ref tabPage7, ref dataGridViewNbrEti, ref dataGridViewParametre, ref dataGridViewParametre2, ref dataGridViewParametre3, ref dataGridViewParametre4, ref dataGridViewParametre5, ref dataGridViewParametre61, ref dataGridViewParametre7, ref dataGridViewFils, ref nouvelleBaseEssaieDataSet, ref parametreTableAdapter, ref arborescenceTableAdapter, ref produitTableAdapter, ref dataGridViewProduit);
            etiqHelper.GetEtiquette(out nbretiq);
        }
        private void GetAutoPara(string Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays)
        {
            DataGridView dataGridViewVerifProduit = new DataGridView();
            EtiquetteHelper etiHelper = new EtiquetteHelper(ref reference, ref Parametretabpage, ref tabPage1, ref tabPage2, ref tabPage3, ref tabPage4, ref tabPage5, ref tabPage6, ref tabPage7, ref dataGridViewNbrEti, ref dataGridViewParametre, ref dataGridViewParametre2, ref dataGridViewParametre3, ref dataGridViewParametre4, ref dataGridViewParametre5, ref dataGridViewParametre61, ref dataGridViewParametre7, ref dataGridViewFils, ref nouvelleBaseEssaieDataSet, ref parametreTableAdapter, ref arborescenceTableAdapter, ref produitTableAdapter, ref dataGridViewProduit);
            etiHelper.GetAutoPara(Parametre, out testetl, out testmac, out testrecap, out testimprim, out testindice, out testindice2, out testOrigine, out testOrigin, out testorigin, out testPays, out testpays);
        }
        private void Validation()
        {
            DataGridView dataGridViewVerifProduit = new DataGridView();
            EtiquetteHelper etiHelper = new EtiquetteHelper(ref reference, ref Parametretabpage, ref tabPage1, ref tabPage2, ref tabPage3, ref tabPage4, ref tabPage5, ref tabPage6, ref tabPage7, ref dataGridViewNbrEti, ref dataGridViewParametre, ref dataGridViewParametre2, ref dataGridViewParametre3, ref dataGridViewParametre4, ref dataGridViewParametre5, ref dataGridViewParametre61, ref dataGridViewParametre7, ref dataGridViewFils, ref nouvelleBaseEssaieDataSet, ref parametreTableAdapter, ref arborescenceTableAdapter, ref produitTableAdapter, ref dataGridViewProduit);
            etiHelper.Validation();
        }
        private void GetFils(int row)
        {
            DataGridView dataGridViewVerifProduit = new DataGridView();
            EtiquetteHelper etiHelper = new EtiquetteHelper(ref reference, ref Parametretabpage, ref tabPage1, ref tabPage2, ref tabPage3, ref tabPage4, ref tabPage5, ref tabPage6, ref tabPage7, ref dataGridViewNbrEti, ref dataGridViewParametre, ref dataGridViewParametre2, ref dataGridViewParametre3, ref dataGridViewParametre4, ref dataGridViewParametre5, ref dataGridViewParametre61, ref dataGridViewParametre7, ref dataGridViewFils, ref nouvelleBaseEssaieDataSet, ref parametreTableAdapter, ref arborescenceTableAdapter, ref produitTableAdapter, ref dataGridViewProduit);
            etiHelper.GetFils(row);
        }
    }
}
