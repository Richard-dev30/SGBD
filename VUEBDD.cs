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
    public partial class VUEBDD : Form
    {
        public string VUE;
        public VUEBDD()
        {
            InitializeComponent();
        }

        private void VUEBDD_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDDEtiquettesPFDataSet.LogProduitFiniDelete'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.logProduitFiniDeleteTableAdapter.Fill(this.bDDEtiquettesPFDataSet.LogProduitFiniDelete);
            // TODO: cette ligne de code charge les données dans la table 'bDDEtiquettesPFDataSet.LogProduitFini'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.logProduitFiniTableAdapter.Fill(this.bDDEtiquettesPFDataSet.LogProduitFini);
            // TODO: cette ligne de code charge les données dans la table 'compteurs_SN_IESDataSet.SN_CartesBornes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sN_CartesBornesTableAdapter.Fill(this.compteurs_SN_IESDataSet.SN_CartesBornes);
            // TODO: cette ligne de code charge les données dans la table 'compteurs_SN_IESDataSet.SN_ProduitsFinis'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sN_ProduitsFinisTableAdapter.Fill(this.compteurs_SN_IESDataSet.SN_ProduitsFinis);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.RequeteFils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.requeteFilsTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.RequeteFils);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ListeEtiquette'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listeEtiquetteTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.ListeEtiquette);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.TypeFamille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeFamilleTableAdapter.FillOrder(this.nouvelleBaseEssaieDataSet.TypeFamille);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ReferenceFils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.referenceFilsTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.ReferenceFils);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.ParametreListe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.parametreListeTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.ParametreListe);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.Parametre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.parametreTableAdapter.FillOrder(this.nouvelleBaseEssaieDataSet.Parametre);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.Arborescence'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.arborescenceTableAdapter.FillOrder(this.nouvelleBaseEssaieDataSet.Arborescence);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.Produit);


            if (VUE == "produit")
            {
                tabControl1.Controls.Remove(tabPage2);
                tabControl1.Controls.Remove(tabPage3);
                tabControl1.Controls.Remove(tabPage4);
                tabControl1.Controls.Remove(tabPage5);
                tabControl1.Controls.Remove(tabPage6);
                tabControl1.Controls.Remove(tabPage7);
                tabControl1.Controls.Remove(tabPage8);
                tabControl1.Controls.Remove(tabPage9);
                tabControl1.Controls.Remove(tabPage10);
                tabControl1.Controls.Remove(tabPage11);
                tabControl1.Controls.Remove(tabPage12);
            }
            if (VUE == "arborescence")
            {
                tabControl1.Controls.Remove(tabPage1);
                tabControl1.Controls.Remove(tabPage3);
                tabControl1.Controls.Remove(tabPage4);
                tabControl1.Controls.Remove(tabPage5);
                tabControl1.Controls.Remove(tabPage6);
                tabControl1.Controls.Remove(tabPage7);
                tabControl1.Controls.Remove(tabPage8);
                tabControl1.Controls.Remove(tabPage9);
                tabControl1.Controls.Remove(tabPage10);
                tabControl1.Controls.Remove(tabPage11);
                tabControl1.Controls.Remove(tabPage12);
            }
            if (VUE == "parametre")
            {
                tabControl1.Controls.Remove(tabPage1);
                tabControl1.Controls.Remove(tabPage2);
                tabControl1.Controls.Remove(tabPage4);
                tabControl1.Controls.Remove(tabPage5);
                tabControl1.Controls.Remove(tabPage6);
                tabControl1.Controls.Remove(tabPage7);
                tabControl1.Controls.Remove(tabPage8);
                tabControl1.Controls.Remove(tabPage9);
                tabControl1.Controls.Remove(tabPage10);
                tabControl1.Controls.Remove(tabPage11);
                tabControl1.Controls.Remove(tabPage12);
            }
            if (VUE == "parametreliste")
            {
                tabControl1.Controls.Remove(tabPage1);
                tabControl1.Controls.Remove(tabPage2);
                tabControl1.Controls.Remove(tabPage3);
                tabControl1.Controls.Remove(tabPage5);
                tabControl1.Controls.Remove(tabPage6);
                tabControl1.Controls.Remove(tabPage7);
                tabControl1.Controls.Remove(tabPage8);
                tabControl1.Controls.Remove(tabPage9);
                tabControl1.Controls.Remove(tabPage10);
                tabControl1.Controls.Remove(tabPage11);
                tabControl1.Controls.Remove(tabPage12);
            }
            if (VUE == "filsliste")
            {
                tabControl1.Controls.Remove(tabPage1);
                tabControl1.Controls.Remove(tabPage2);
                tabControl1.Controls.Remove(tabPage3);
                tabControl1.Controls.Remove(tabPage4);
                tabControl1.Controls.Remove(tabPage6);
                tabControl1.Controls.Remove(tabPage7);
                tabControl1.Controls.Remove(tabPage8);
                tabControl1.Controls.Remove(tabPage9);
                tabControl1.Controls.Remove(tabPage10);
                tabControl1.Controls.Remove(tabPage11);
                tabControl1.Controls.Remove(tabPage12);
            }
            if (VUE == "typeliste")
            {
                tabControl1.Controls.Remove(tabPage1);
                tabControl1.Controls.Remove(tabPage2);
                tabControl1.Controls.Remove(tabPage3);
                tabControl1.Controls.Remove(tabPage4);
                tabControl1.Controls.Remove(tabPage5);
                tabControl1.Controls.Remove(tabPage7);
                tabControl1.Controls.Remove(tabPage8);
                tabControl1.Controls.Remove(tabPage9);
                tabControl1.Controls.Remove(tabPage10);
                tabControl1.Controls.Remove(tabPage11);
                tabControl1.Controls.Remove(tabPage12);
            }
            if (VUE == "etiquetteliste")
            {
                tabControl1.Controls.Remove(tabPage1);
                tabControl1.Controls.Remove(tabPage2);
                tabControl1.Controls.Remove(tabPage3);
                tabControl1.Controls.Remove(tabPage4);
                tabControl1.Controls.Remove(tabPage5);
                tabControl1.Controls.Remove(tabPage6);
                tabControl1.Controls.Remove(tabPage8);
                tabControl1.Controls.Remove(tabPage9);
                tabControl1.Controls.Remove(tabPage10);
                tabControl1.Controls.Remove(tabPage11);
                tabControl1.Controls.Remove(tabPage12);
            }
            if (VUE == "requetefils")
            {
                tabControl1.Controls.Remove(tabPage1);
                tabControl1.Controls.Remove(tabPage2);
                tabControl1.Controls.Remove(tabPage3);
                tabControl1.Controls.Remove(tabPage4);
                tabControl1.Controls.Remove(tabPage5);
                tabControl1.Controls.Remove(tabPage6);
                tabControl1.Controls.Remove(tabPage7);
                tabControl1.Controls.Remove(tabPage9);
                tabControl1.Controls.Remove(tabPage10);
                tabControl1.Controls.Remove(tabPage11);
                tabControl1.Controls.Remove(tabPage12);
            }
            if (VUE == "snproduitfinis")
            {
                tabControl1.Controls.Remove(tabPage1);
                tabControl1.Controls.Remove(tabPage2);
                tabControl1.Controls.Remove(tabPage3);
                tabControl1.Controls.Remove(tabPage4);
                tabControl1.Controls.Remove(tabPage5);
                tabControl1.Controls.Remove(tabPage6);
                tabControl1.Controls.Remove(tabPage7);
                tabControl1.Controls.Remove(tabPage8);
                tabControl1.Controls.Remove(tabPage10);
                tabControl1.Controls.Remove(tabPage11);
                tabControl1.Controls.Remove(tabPage12);
            }
            if (VUE == "sncartebornes")
            {
                tabControl1.Controls.Remove(tabPage1);
                tabControl1.Controls.Remove(tabPage2);
                tabControl1.Controls.Remove(tabPage3);
                tabControl1.Controls.Remove(tabPage4);
                tabControl1.Controls.Remove(tabPage5);
                tabControl1.Controls.Remove(tabPage6);
                tabControl1.Controls.Remove(tabPage7);
                tabControl1.Controls.Remove(tabPage8);
                tabControl1.Controls.Remove(tabPage9);
                tabControl1.Controls.Remove(tabPage11);
                tabControl1.Controls.Remove(tabPage12);
            }
            if (VUE == "logproduitfini")
            {
                tabControl1.Controls.Remove(tabPage1);
                tabControl1.Controls.Remove(tabPage2);
                tabControl1.Controls.Remove(tabPage3);
                tabControl1.Controls.Remove(tabPage4);
                tabControl1.Controls.Remove(tabPage5);
                tabControl1.Controls.Remove(tabPage6);
                tabControl1.Controls.Remove(tabPage7);
                tabControl1.Controls.Remove(tabPage8);
                tabControl1.Controls.Remove(tabPage9);
                tabControl1.Controls.Remove(tabPage10);
                tabControl1.Controls.Remove(tabPage12);
            }
            if (VUE == "logproduitdelete")
            {
                tabControl1.Controls.Remove(tabPage1);
                tabControl1.Controls.Remove(tabPage2);
                tabControl1.Controls.Remove(tabPage3);
                tabControl1.Controls.Remove(tabPage4);
                tabControl1.Controls.Remove(tabPage5);
                tabControl1.Controls.Remove(tabPage6);
                tabControl1.Controls.Remove(tabPage7);
                tabControl1.Controls.Remove(tabPage8);
                tabControl1.Controls.Remove(tabPage9);
                tabControl1.Controls.Remove(tabPage10);
                tabControl1.Controls.Remove(tabPage11);
            }
        }
    }
}
