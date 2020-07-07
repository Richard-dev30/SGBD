namespace ModificationBaseDeDonnees
{
    partial class ADDTypeFamille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.textBoxFamille = new System.Windows.Forms.TextBox();
            this.comboBoxProduit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxfils = new System.Windows.Forms.CheckBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.typeFamilleTableAdapter1 = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSetTableAdapters.TypeFamilleTableAdapter();
            this.SuspendLayout();
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(12, 150);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(315, 20);
            this.textBoxDesignation.TabIndex = 0;
            this.textBoxDesignation.Text = "Exemple : Cube 19kW";
            // 
            // textBoxFamille
            // 
            this.textBoxFamille.Location = new System.Drawing.Point(12, 264);
            this.textBoxFamille.Name = "textBoxFamille";
            this.textBoxFamille.Size = new System.Drawing.Size(315, 20);
            this.textBoxFamille.TabIndex = 1;
            this.textBoxFamille.Text = "Exemple : CU19";
            // 
            // comboBoxProduit
            // 
            this.comboBoxProduit.FormattingEnabled = true;
            this.comboBoxProduit.Items.AddRange(new object[] {
            "MANUT",
            "BORNE",
            "CABLE",
            "SSE",
            "KIT"});
            this.comboBoxProduit.Location = new System.Drawing.Point(12, 51);
            this.comboBoxProduit.Name = "comboBoxProduit";
            this.comboBoxProduit.Size = new System.Drawing.Size(315, 21);
            this.comboBoxProduit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choisir le produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Désignation du produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Famille du produit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Présence de fils";
            // 
            // checkBoxfils
            // 
            this.checkBoxfils.AutoSize = true;
            this.checkBoxfils.Location = new System.Drawing.Point(38, 355);
            this.checkBoxfils.Name = "checkBoxfils";
            this.checkBoxfils.Size = new System.Drawing.Size(15, 14);
            this.checkBoxfils.TabIndex = 7;
            this.checkBoxfils.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(172, 341);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(155, 23);
            this.buttonValider.TabIndex = 8;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // typeFamilleTableAdapter1
            // 
            this.typeFamilleTableAdapter1.ClearBeforeFill = true;
            // 
            // ADDTypeFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 387);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.checkBoxfils);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProduit);
            this.Controls.Add(this.textBoxFamille);
            this.Controls.Add(this.textBoxDesignation);
            this.Name = "ADDTypeFamille";
            this.Text = "Ajouter une famille de produit";
            this.Load += new System.EventHandler(this.ADDTypeFamille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.TextBox textBoxFamille;
        private System.Windows.Forms.ComboBox comboBoxProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxfils;
        private System.Windows.Forms.Button buttonValider;
        private NouvelleBaseEssaieDataSetTableAdapters.TypeFamilleTableAdapter typeFamilleTableAdapter1;
    }
}