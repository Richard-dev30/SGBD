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
    public partial class Main : Form
    {
        Modif Modif;
        Creation Creation;
        ADDFils ADDFils;
        ADDTypeFamille ADDTypeFamille;
        ADDParametre ADDParametre;
        ADDEtiquette ADDEtiquette;
        CommentaireDeSuppression CommentaireDeSuppression;
        Dupliquer Dupliquers;
        MODIFFils MODIFFils;
        MODIFType MODIFType;
        MODIFParametre MODIFParametre;
        MODIFListeParametre MODIFListeParametre;
        DELETEFils DELETEFils;
        DELETEType DELETEType;
        DELETEParametre DELETEParametre;
        DELETEListeParametre DELETEListeParametre;
        VUEBDD VUEBDD;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDDEtiquettesPFDataSet.LogProduitFini'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.logProduitFiniTableAdapter.Fill(this.bDDEtiquettesPFDataSet.LogProduitFini);
            // TODO: cette ligne de code charge les données dans la table 'nouvelleBaseEssaieDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.nouvelleBaseEssaieDataSet.Produit);
        }

        private void textBoxReference_TextChanged(object sender, EventArgs e)
        {
            string reef = textBoxReference.Text;
            int nResult;
            if (int.TryParse(textBoxReference.Text, out nResult) == false)
            {
                this.produitTableAdapter.FiltrebyType(this.nouvelleBaseEssaieDataSet.Produit, reef);
            }
            else
            {
                this.produitTableAdapter.FiltrebyRef(this.nouvelleBaseEssaieDataSet.Produit, reef);
            }
        }

        private void dataGridViewProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProduit.Columns["Modifier"].Index && e.RowIndex >= 0)                
            {
                    Modif = new Modif();
                    int row = e.RowIndex;
                    Modif.reference = dataGridViewProduit.Rows[row].Cells[0].Value.ToString();
                    Modif.famille = dataGridViewProduit.Rows[row].Cells[3].Value.ToString();
                    Modif.ShowDialog();    
            }
            if (e.ColumnIndex == dataGridViewProduit.Columns["Dupliquer"].Index && e.RowIndex >= 0)
            {
                Dupliquers = new Dupliquer();
                int row = e.RowIndex;
                Dupliquers.reference = dataGridViewProduit.Rows[row].Cells[0].Value.ToString();
                Dupliquers.famille = dataGridViewProduit.Rows[row].Cells[3].Value.ToString();
                Dupliquers.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creation = new Creation();
            Creation.ShowDialog();
        }

        private void unFilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void uneFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void unParamètreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void uneÉtiquetteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxSN_TextChanged(object sender, EventArgs e)
        {
            string rref = textBoxSN.Text;
            this.logProduitFiniTableAdapter.FiltreLOGBorne(this.bDDEtiquettesPFDataSet.LogProduitFini, rref);
        }

        private void textBoxCarte_TextChanged(object sender, EventArgs e)
        {
            string cref = textBoxCarte.Text;
            this.logProduitFiniTableAdapter.FiltreLOGCarte(this.bDDEtiquettesPFDataSet.LogProduitFini, cref, cref, cref, cref, cref, cref, cref, cref, cref, cref, cref, cref, cref, cref, cref, cref, cref, cref, cref, cref);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int row = e.RowIndex;
                string date = dataGridViewLOG.Rows[row].Cells[0].Value.ToString();
                string reef = dataGridViewLOG.Rows[row].Cells[1].Value.ToString();
                string carte1 = dataGridViewLOG.Rows[row].Cells[2].Value.ToString();
                string carte2 = dataGridViewLOG.Rows[row].Cells[3].Value.ToString();
                string carte3 = dataGridViewLOG.Rows[row].Cells[4].Value.ToString();
                string carte4 = dataGridViewLOG.Rows[row].Cells[5].Value.ToString();
                string carte5 = dataGridViewLOG.Rows[row].Cells[6].Value.ToString();
                string carte6 = dataGridViewLOG.Rows[row].Cells[7].Value.ToString();
                string carte7 = dataGridViewLOG.Rows[row].Cells[8].Value.ToString();
                string carte8 = dataGridViewLOG.Rows[row].Cells[9].Value.ToString();
                string carte9 = dataGridViewLOG.Rows[row].Cells[10].Value.ToString();
                string carte10 = dataGridViewLOG.Rows[row].Cells[11].Value.ToString();
                string carte11 = dataGridViewLOG.Rows[row].Cells[12].Value.ToString();
                string carte12 = dataGridViewLOG.Rows[row].Cells[13].Value.ToString();
                string carte13 = dataGridViewLOG.Rows[row].Cells[14].Value.ToString();
                string carte14 = dataGridViewLOG.Rows[row].Cells[15].Value.ToString();
                string carte15 = dataGridViewLOG.Rows[row].Cells[16].Value.ToString();
                string carte16 = dataGridViewLOG.Rows[row].Cells[17].Value.ToString();
                string carte17 = dataGridViewLOG.Rows[row].Cells[18].Value.ToString();
                string carte18 = dataGridViewLOG.Rows[row].Cells[19].Value.ToString();
                string carte19 = dataGridViewLOG.Rows[row].Cells[20].Value.ToString();
                string carte20 = dataGridViewLOG.Rows[row].Cells[21].Value.ToString();
                string sNSST = dataGridViewLOG.Rows[row].Cells[22].Value.ToString();
                string commentaire = dataGridViewLOG.Rows[row].Cells[23].Value.ToString();
                string etl = dataGridViewLOG.Rows[row].Cells[24].Value.ToString();
                string mac = dataGridViewLOG.Rows[row].Cells[25].Value.ToString();
                string eti = dataGridViewLOG.Rows[row].Cells[26].Value.ToString();
                string today = DateTime.Today.ToString("d");
                DateTime date2 = Convert.ToDateTime(date);

                CommentaireDeSuppression = new CommentaireDeSuppression();
                CommentaireDeSuppression.ShowDialog();

                string commentairedelete = CommentaireDeSuppression.commentairedelete;
                string ValiderAnuller = CommentaireDeSuppression.ValiderAnnuler;

                if (ValiderAnuller == "Valider")
                {
                    this.logProduitFiniTableAdapter.DeleteLOGQuery(reef);
                    this.logProduitFiniTableAdapter.InsertlogdeleteQuery(date2, reef, carte1, carte2, carte3, carte4, carte5, carte6, carte7, carte8, carte9, carte10, carte11, carte12, carte13, carte14, carte15, carte16, carte17, carte18, carte19, carte20, sNSST, commentaire, etl, mac, eti, today, commentairedelete);
                }
            }
        }

        private void unFilsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ADDFils = new ADDFils();
            ADDFils.ShowDialog();
        }

        private void unTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDTypeFamille = new ADDTypeFamille();
            ADDTypeFamille.ShowDialog();
        }

        private void unParamètreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ADDParametre = new ADDParametre();
            ADDParametre.ShowDialog();
        }

        private void uneListeDeParamètreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDEtiquette = new ADDEtiquette();
            ADDEtiquette.ShowDialog();
        }

        private void unFilsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MODIFFils = new MODIFFils();
            MODIFFils.ShowDialog();
        }

        private void unTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MODIFType = new MODIFType();
            MODIFType.ShowDialog();
        }

        private void unParamètreToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MODIFParametre = new MODIFParametre();
            MODIFParametre.ShowDialog();
        }

        private void uneListeDeParamètreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MODIFListeParametre = new MODIFListeParametre();
            MODIFListeParametre.ShowDialog();
        }

        private void unFilsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DELETEFils = new DELETEFils();
            DELETEFils.ShowDialog();
        }

        private void unTypeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DELETEType = new DELETEType();
            DELETEType.ShowDialog();
        }

        private void unParamètreToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DELETEParametre = new DELETEParametre();
            DELETEParametre.ShowDialog();
        }

        private void uneListeDeParamètreToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DELETEListeParametre = new DELETEListeParametre();
            DELETEListeParametre.ShowDialog();
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            VUEBDD = new VUEBDD();
            VUEBDD.VUE = "produit";
            VUEBDD.Show();
        }

        private void arborescenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VUEBDD = new VUEBDD();
            VUEBDD.VUE = "arborescence";
            VUEBDD.Show();           
        }

        private void parametreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VUEBDD = new VUEBDD();
            VUEBDD.VUE = "parametre";
            VUEBDD.Show();           
        }

        private void parametreListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VUEBDD = new VUEBDD();
            VUEBDD.VUE = "parametreliste";
            VUEBDD.Show();            
        }

        private void filsListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VUEBDD = new VUEBDD();
            VUEBDD.VUE = "filsliste";
            VUEBDD.Show();            
        }

        private void typeListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VUEBDD = new VUEBDD();
            VUEBDD.VUE = "typeliste";
            VUEBDD.Show();           
        }

        private void etiquetteListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VUEBDD = new VUEBDD();
            VUEBDD.VUE = "etiquetteliste";
            VUEBDD.Show();            
        }

        private void requeteFilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VUEBDD = new VUEBDD();
            VUEBDD.VUE = "requetefils";
            VUEBDD.Show();            
        }

        private void sNProduitFinisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VUEBDD = new VUEBDD();
            VUEBDD.VUE = "snproduitfinis";
            VUEBDD.Show();            
        }

        private void sNCarteBornesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VUEBDD = new VUEBDD();
            VUEBDD.VUE = "sncartebornes";
            VUEBDD.Show();           
        }

        private void logProduitFiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VUEBDD = new VUEBDD();
            VUEBDD.VUE = "logproduitfini";
            VUEBDD.Show();  
        }

        private void logProduitDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VUEBDD = new VUEBDD();
            VUEBDD.VUE = "logproduitdelete";
            VUEBDD.Show();           
        }
    }
}
