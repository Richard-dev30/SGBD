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
    public partial class ChoixVraiFaux : Form
    {
        public string choix;
        public ChoixVraiFaux()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            choix = "VRAI";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choix = "FAUX";
            this.Close();
        }
    }
}
