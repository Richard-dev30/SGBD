using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public EtiquetteHelper(ref String refeerence, ref TabControl tabCtrl, ref TabPage tp1, ref TabPage tp2, ref TabPage tp3, ref TabPage tp4, ref TabPage tp5, ref TabPage tp6, ref TabPage tp7, ref DataGridView dgv1, ref DataGridView dgv2, ref DataGridView dgv3, ref DataGridView dgv4, ref DataGridView dgv5, ref DataGridView dgv6, ref DataGridView dgv7, ref DataGridView dgv8, ref DataGridView dgv9)
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
        }

        public void GetEtiquette(out int nbretiq)
        {
            string reef = reference;
            parametreTableAdapter.FillNbrEti(this.nouvelleBaseEssaieDataSet.Parametre, reef);
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
    }
    
}
