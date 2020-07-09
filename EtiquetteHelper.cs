using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModificationBaseDeDonnees
{
    public class EtiquetteHelper
    {
        public String reference;
        public int nbreti;
        public TabControl Parametretabpage;
        public TabPage tabPage1;
        public TabPage tabPage2;
        public TabPage tabPage3;
        public TabPage tabPage4;
        public TabPage tabPage5;
        public TabPage tabPage6;
        public TabPage tabPage7;
        public NouvelleBaseEssaieDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        public NouvelleBaseEssaieDataSetTableAdapters.ArborescenceTableAdapter arborescenceTableAdapter;
        public NouvelleBaseEssaieDataSetTableAdapters.ParametreTableAdapter parametreTableAdapter;
        public NouvelleBaseEssaieDataSet nouvelleBaseEssaieDataSet;
        public DataGridView dataGridViewNbrEti;
        public DataGridView dataGridViewParametre;
        public DataGridView dataGridViewParametre2;
        public DataGridView dataGridViewParametre3;
        public DataGridView dataGridViewParametre4;
        public DataGridView dataGridViewParametre5;
        public DataGridView dataGridViewParametre6;
        public DataGridView dataGridViewParametre7;
        public DataGridView dataGridViewFils;
        public DataGridView dataGridViewProduit;

        public EtiquetteHelper(ref String refeerence, ref TabControl tabCtrl, ref TabPage tp1, ref TabPage tp2, ref TabPage tp3, ref TabPage tp4, ref TabPage tp5, ref TabPage tp6, ref TabPage tp7, ref DataGridView dgv1, ref DataGridView dgv2, ref DataGridView dgv3, ref DataGridView dgv4, ref DataGridView dgv5, ref DataGridView dgv6, ref DataGridView dgv7, ref DataGridView dgv8, ref DataGridView dgv9, ref NouvelleBaseEssaieDataSet nouv, ref NouvelleBaseEssaieDataSetTableAdapters.ParametreTableAdapter parametre, ref NouvelleBaseEssaieDataSetTableAdapters.ArborescenceTableAdapter arborescence, ref NouvelleBaseEssaieDataSetTableAdapters.ProduitTableAdapter produit, ref DataGridView dgv10)
        {
            reference = refeerence;
            Parametretabpage = tabCtrl;
            tabPage1 = tp1;
            tabPage2 = tp2;
            tabPage3 = tp3;
            tabPage4 = tp4;
            tabPage5 = tp5;
            tabPage6 = tp6;
            tabPage7 = tp7;
            dataGridViewNbrEti = dgv1;
            dataGridViewParametre = dgv2;
            dataGridViewParametre2 = dgv3;
            dataGridViewParametre3 = dgv4;
            dataGridViewParametre4 = dgv5;
            dataGridViewParametre5 = dgv6;
            dataGridViewParametre6 = dgv7;
            dataGridViewParametre7 = dgv8;
            dataGridViewFils = dgv9;
            nouvelleBaseEssaieDataSet = nouv;
            parametreTableAdapter = parametre;
            arborescenceTableAdapter = arborescence;
            produitTableAdapter = produit;
            dataGridViewProduit = dgv10;
        }

        public void GetEtiquette(out int nbretiq)
        {
            string reef = reference;
            nbretiq = dataGridViewNbrEti.Rows.Count;
            if (nbretiq == 1)
            {
                Parametretabpage.Controls.Remove(tabPage2);
                Parametretabpage.Controls.Remove(tabPage3);
                Parametretabpage.Controls.Remove(tabPage4);
                Parametretabpage.Controls.Remove(tabPage5);
                Parametretabpage.Controls.Remove(tabPage6);
                Parametretabpage.Controls.Remove(tabPage7);
                string nameEti1 = dataGridViewNbrEti.Rows[0].Cells[1].Value.ToString();
                tabPage1.Text = nameEti1;
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti1);
                int nbrrow1 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i < nbrrow1; i++)
                {
                    dataGridViewParametre.Rows.Add();
                    dataGridViewParametre.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                nbreti = 2;
            }
            if (nbretiq == 2)
            {
                Parametretabpage.Controls.Remove(tabPage3);
                Parametretabpage.Controls.Remove(tabPage4);
                Parametretabpage.Controls.Remove(tabPage5);
                Parametretabpage.Controls.Remove(tabPage6);
                Parametretabpage.Controls.Remove(tabPage7);
                string nameEti1 = dataGridViewNbrEti.Rows[0].Cells[1].Value.ToString();
                string nameEti2 = dataGridViewNbrEti.Rows[1].Cells[1].Value.ToString();
                tabPage1.Text = nameEti1;
                tabPage2.Text = nameEti2;
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti1);
                int nbrrow1 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i < nbrrow1; i++)
                {
                    dataGridViewParametre.Rows.Add();
                    dataGridViewParametre.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti2);
                int nbrrow2 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i < nbrrow2; i++)
                {
                    dataGridViewParametre2.Rows.Add();
                    dataGridViewParametre2.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre2.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre2.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                nbreti = 4;
            }
            if (nbretiq == 3)
            {
                Parametretabpage.Controls.Remove(tabPage4);
                Parametretabpage.Controls.Remove(tabPage5);
                Parametretabpage.Controls.Remove(tabPage6);
                Parametretabpage.Controls.Remove(tabPage7);
                string nameEti1 = dataGridViewNbrEti.Rows[0].Cells[1].Value.ToString();
                string nameEti2 = dataGridViewNbrEti.Rows[1].Cells[1].Value.ToString();
                string nameEti3 = dataGridViewNbrEti.Rows[2].Cells[1].Value.ToString();
                tabPage1.Text = nameEti1;
                tabPage2.Text = nameEti2;
                tabPage3.Text = nameEti3;
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti1);
                int nbrrow1 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i < nbrrow1; i++)
                {
                    dataGridViewParametre.Rows.Add();
                    dataGridViewParametre.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti2);
                int nbrrow2 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i < nbrrow2; i++)
                {
                    dataGridViewParametre2.Rows.Add();
                    dataGridViewParametre2.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre2.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre2.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti3);
                int nbrrow3 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow3; i++)
                {
                    dataGridViewParametre3.Rows.Add();
                    dataGridViewParametre3.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre3.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre3.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                nbreti = 6;
            }
            if (nbretiq == 4)
            {
                Parametretabpage.Controls.Remove(tabPage5);
                Parametretabpage.Controls.Remove(tabPage6);
                Parametretabpage.Controls.Remove(tabPage7);
                string nameEti1 = dataGridViewNbrEti.Rows[0].Cells[1].Value.ToString();
                string nameEti2 = dataGridViewNbrEti.Rows[1].Cells[1].Value.ToString();
                string nameEti3 = dataGridViewNbrEti.Rows[2].Cells[1].Value.ToString();
                string nameEti4 = dataGridViewNbrEti.Rows[3].Cells[1].Value.ToString();
                tabPage1.Text = nameEti1;
                tabPage2.Text = nameEti2;
                tabPage3.Text = nameEti3;
                tabPage4.Text = nameEti4;
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti1);
                int nbrrow1 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i < nbrrow1; i++)
                {
                    dataGridViewParametre.Rows.Add();
                    dataGridViewParametre.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti2);
                int nbrrow2 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i < nbrrow2; i++)
                {
                    dataGridViewParametre2.Rows.Add();
                    dataGridViewParametre2.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre2.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre2.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti3);
                int nbrrow3 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow3; i++)
                {
                    dataGridViewParametre3.Rows.Add();
                    dataGridViewParametre3.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre3.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre3.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti4);
                int nbrrow4 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow4; i++)
                {
                    dataGridViewParametre4.Rows.Add();
                    dataGridViewParametre4.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre4.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre4.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                nbreti = 8;
            }
            if (nbretiq == 5)
            {
                Parametretabpage.Controls.Remove(tabPage6);
                Parametretabpage.Controls.Remove(tabPage7);
                string nameEti1 = dataGridViewNbrEti.Rows[0].Cells[1].Value.ToString();
                string nameEti2 = dataGridViewNbrEti.Rows[1].Cells[1].Value.ToString();
                string nameEti3 = dataGridViewNbrEti.Rows[2].Cells[1].Value.ToString();
                string nameEti4 = dataGridViewNbrEti.Rows[3].Cells[1].Value.ToString();
                string nameEti5 = dataGridViewNbrEti.Rows[4].Cells[1].Value.ToString();
                tabPage1.Text = nameEti1;
                tabPage2.Text = nameEti2;
                tabPage3.Text = nameEti3;
                tabPage4.Text = nameEti4;
                tabPage5.Text = nameEti5;
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti1);
                int nbrrow1 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i < nbrrow1; i++)
                {
                    dataGridViewParametre.Rows.Add();
                    dataGridViewParametre.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti2);
                int nbrrow2 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i < nbrrow2; i++)
                {
                    dataGridViewParametre2.Rows.Add();
                    dataGridViewParametre2.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre2.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre2.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti3);
                int nbrrow3 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow3; i++)
                {
                    dataGridViewParametre3.Rows.Add();
                    dataGridViewParametre3.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre3.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre3.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti4);
                int nbrrow4 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow4; i++)
                {
                    dataGridViewParametre4.Rows.Add();
                    dataGridViewParametre4.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre4.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre4.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti5);
                int nbrrow5 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow5; i++)
                {
                    dataGridViewParametre5.Rows.Add();
                    dataGridViewParametre5.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre5.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre5.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                nbreti = 10;
            }
            if (nbretiq == 6)
            {
                Parametretabpage.Controls.Remove(tabPage7);
                string nameEti1 = dataGridViewNbrEti.Rows[0].Cells[1].Value.ToString();
                string nameEti2 = dataGridViewNbrEti.Rows[1].Cells[1].Value.ToString();
                string nameEti3 = dataGridViewNbrEti.Rows[2].Cells[1].Value.ToString();
                string nameEti4 = dataGridViewNbrEti.Rows[3].Cells[1].Value.ToString();
                string nameEti5 = dataGridViewNbrEti.Rows[4].Cells[1].Value.ToString();
                string nameEti6 = dataGridViewNbrEti.Rows[5].Cells[1].Value.ToString();
                tabPage1.Text = nameEti1;
                tabPage2.Text = nameEti2;
                tabPage3.Text = nameEti3;
                tabPage4.Text = nameEti4;
                tabPage5.Text = nameEti5;
                tabPage6.Text = nameEti6;
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti1);
                int nbrrow1 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i < nbrrow1; i++)
                {
                    dataGridViewParametre.Rows.Add();
                    dataGridViewParametre.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti2);
                int nbrrow2 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i < nbrrow2; i++)
                {
                    dataGridViewParametre2.Rows.Add();
                    dataGridViewParametre2.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre2.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre2.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti3);
                int nbrrow3 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow3; i++)
                {
                    dataGridViewParametre3.Rows.Add();
                    dataGridViewParametre3.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre3.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre3.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti4);
                int nbrrow4 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow4; i++)
                {
                    dataGridViewParametre4.Rows.Add();
                    dataGridViewParametre4.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre4.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre4.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti5);
                int nbrrow5 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow5; i++)
                {
                    dataGridViewParametre5.Rows.Add();
                    dataGridViewParametre5.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre5.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre5.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti6);
                int nbrrow6 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow6; i++)
                {
                    dataGridViewParametre6.Rows.Add();
                    dataGridViewParametre6.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre6.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre6.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                nbreti = 12;
            }
            if (nbretiq == 7)
            {
                string nameEti1 = dataGridViewNbrEti.Rows[0].Cells[1].Value.ToString();
                string nameEti2 = dataGridViewNbrEti.Rows[1].Cells[1].Value.ToString();
                string nameEti3 = dataGridViewNbrEti.Rows[2].Cells[1].Value.ToString();
                string nameEti4 = dataGridViewNbrEti.Rows[3].Cells[1].Value.ToString();
                string nameEti5 = dataGridViewNbrEti.Rows[4].Cells[1].Value.ToString();
                string nameEti6 = dataGridViewNbrEti.Rows[5].Cells[1].Value.ToString();
                string nameEti7 = dataGridViewNbrEti.Rows[6].Cells[1].Value.ToString();
                tabPage1.Text = nameEti1;
                tabPage2.Text = nameEti2;
                tabPage3.Text = nameEti3;
                tabPage4.Text = nameEti4;
                tabPage5.Text = nameEti5;
                tabPage6.Text = nameEti6;
                tabPage7.Text = nameEti7;
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti1);
                int nbrrow1 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i < nbrrow1; i++)
                {
                    dataGridViewParametre.Rows.Add();
                    dataGridViewParametre.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti2);
                int nbrrow2 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i < nbrrow2; i++)
                {
                    dataGridViewParametre2.Rows.Add();
                    dataGridViewParametre2.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre2.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre2.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti3);
                int nbrrow3 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow3; i++)
                {
                    dataGridViewParametre3.Rows.Add();
                    dataGridViewParametre3.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre3.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre3.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti4);
                int nbrrow4 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow4; i++)
                {
                    dataGridViewParametre4.Rows.Add();
                    dataGridViewParametre4.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre4.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre4.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti5);
                int nbrrow5 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow5; i++)
                {
                    dataGridViewParametre5.Rows.Add();
                    dataGridViewParametre5.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre5.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre5.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti6);
                int nbrrow6 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow6; i++)
                {
                    dataGridViewParametre6.Rows.Add();
                    dataGridViewParametre6.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre6.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre6.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                this.parametreTableAdapter.FillByRefAndEti(this.nouvelleBaseEssaieDataSet.Parametre, reef, nameEti7);
                int nbrrow7 = dataGridViewNbrEti.Rows.Count;
                for (int i = 0; i == nbrrow7; i++)
                {
                    dataGridViewParametre7.Rows.Add();
                    dataGridViewParametre7.Rows[i].Cells[0].Value = reef;
                    dataGridViewParametre7.Rows[i].Cells[1].Value = dataGridViewNbrEti.Rows[i].Cells[2].Value;
                    dataGridViewParametre7.Rows[i].Cells[2].Value = dataGridViewNbrEti.Rows[i].Cells[3].Value;
                }
                nbreti = 13;
            }
            this.parametreTableAdapter.FiltreParameterByRef(this.nouvelleBaseEssaieDataSet.Parametre, reef);
        }
        public void GetAutoPara(string Parametre, out bool testetl, out bool testmac, out bool testrecap, out bool testimprim, out bool testindice, out bool testindice2, out bool testOrigine, out bool testOrigin, out bool testorigin, out bool testPays, out bool testpays)
        {
            testetl = Parametre == "CodeETL";
            testmac = Parametre == "ChargePointMac";
            testrecap = Parametre == "PrintRecap";
            testimprim = Parametre == "A_Imprimer";
            testindice = Parametre == "Indice";
            testindice2 = Parametre == "indice";
            testOrigine = Parametre == "Origine";
            testOrigin = Parametre == "Origin";
            testorigin = Parametre == "origin";
            testPays = Parametre == "Pays";
            testpays = Parametre == "pays";
        }
        public void Validation()
        {
            string reef = reference;
            int NbrRowP = dataGridViewParametre.Rows.Count;
            int NbrRowF = dataGridViewFils.Rows.Count;
            this.parametreTableAdapter.DeleteByRef(reef);
            this.arborescenceTableAdapter.DeleteByRef(reef);

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
            }
            else
            {
                dataGridViewProduit.Rows[0].Cells[2].Value = true;
            }
            string tyype = dataGridViewProduit.Rows[0].Cells[1].Value.ToString();
            string designation = dataGridViewProduit.Rows[0].Cells[2].Value.ToString();
            string famille = dataGridViewProduit.Rows[0].Cells[3].Value.ToString();
            if (designation == "True")
            {
                bool fils = true;
                this.produitTableAdapter.UpdateProduitQuery(tyype, fils, famille, reef);
            }
            else
            {
                bool fils = false;
                this.produitTableAdapter.UpdateProduitQuery(tyype, fils, famille, reef);
            }
            if (dataGridViewParametre2.Rows[0].Cells[0].Value != null)
            {
                int Nbr2 = dataGridViewParametre2.Rows.Count;
                for (int i = 0; i < Nbr2 - 1; i++)
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
            if (dataGridViewParametre6.Rows[0].Cells[0].Value != null)
            {
                int Nbr6 = dataGridViewParametre6.Rows.Count;
                for (int i = 0; i < Nbr6 - 1; i++)
                {
                    string nameeti = tabPage6.Text;
                    string parametre = dataGridViewParametre6.Rows[i].Cells[1].Value.ToString();
                    string valeur = dataGridViewParametre6.Rows[i].Cells[2].Value.ToString();
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
        }
        public void GetFils(int row)
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
}
        
    

