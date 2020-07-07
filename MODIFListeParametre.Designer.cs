namespace ModificationBaseDeDonnees
{
    partial class MODIFListeParametre
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listeEtiquetteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nouvelleBaseEssaieDataSet = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.listeEtiquetteTableAdapter = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSetTableAdapters.ListeEtiquetteTableAdapter();
            this.buttonRecherche = new System.Windows.Forms.Button();
            this.dataGridViewParametre = new System.Windows.Forms.DataGridView();
            this.etiquetteParameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parametre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.parametreListeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxKIT = new System.Windows.Forms.CheckBox();
            this.checkBoxSSE = new System.Windows.Forms.CheckBox();
            this.checkBoxManut = new System.Windows.Forms.CheckBox();
            this.checkBoxCable = new System.Windows.Forms.CheckBox();
            this.checkBoxBorne = new System.Windows.Forms.CheckBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.parametreListeTableAdapter = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSetTableAdapters.ParametreListeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listeEtiquetteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParametre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametreListeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.listeEtiquetteBindingSource;
            this.comboBox1.DisplayMember = "EtiquetteName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "EtiquetteName";
            // 
            // listeEtiquetteBindingSource
            // 
            this.listeEtiquetteBindingSource.DataMember = "ListeEtiquette";
            this.listeEtiquetteBindingSource.DataSource = this.nouvelleBaseEssaieDataSet;
            // 
            // nouvelleBaseEssaieDataSet
            // 
            this.nouvelleBaseEssaieDataSet.DataSetName = "NouvelleBaseEssaieDataSet";
            this.nouvelleBaseEssaieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectionner la liste de paramètre à modifiée";
            // 
            // listeEtiquetteTableAdapter
            // 
            this.listeEtiquetteTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRecherche
            // 
            this.buttonRecherche.Location = new System.Drawing.Point(290, 57);
            this.buttonRecherche.Name = "buttonRecherche";
            this.buttonRecherche.Size = new System.Drawing.Size(90, 23);
            this.buttonRecherche.TabIndex = 2;
            this.buttonRecherche.Text = "Recherche";
            this.buttonRecherche.UseVisualStyleBackColor = true;
            this.buttonRecherche.Click += new System.EventHandler(this.buttonRecherche_Click);
            // 
            // dataGridViewParametre
            // 
            this.dataGridViewParametre.AutoGenerateColumns = false;
            this.dataGridViewParametre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParametre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.etiquetteParameterDataGridViewTextBoxColumn,
            this.Produit,
            this.Parametre});
            this.dataGridViewParametre.DataSource = this.listeEtiquetteBindingSource;
            this.dataGridViewParametre.Location = new System.Drawing.Point(13, 136);
            this.dataGridViewParametre.Name = "dataGridViewParametre";
            this.dataGridViewParametre.Size = new System.Drawing.Size(375, 302);
            this.dataGridViewParametre.TabIndex = 3;
            this.dataGridViewParametre.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParametre_CellValueChanged);
            // 
            // etiquetteParameterDataGridViewTextBoxColumn
            // 
            this.etiquetteParameterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.etiquetteParameterDataGridViewTextBoxColumn.DataPropertyName = "EtiquetteParameter";
            this.etiquetteParameterDataGridViewTextBoxColumn.HeaderText = "EtiquetteParameter";
            this.etiquetteParameterDataGridViewTextBoxColumn.Name = "etiquetteParameterDataGridViewTextBoxColumn";
            // 
            // Produit
            // 
            this.Produit.DataPropertyName = "Produit";
            this.Produit.HeaderText = "Produit";
            this.Produit.Name = "Produit";
            // 
            // Parametre
            // 
            this.Parametre.DataSource = this.parametreListeBindingSource;
            this.Parametre.DisplayMember = "ListParametre";
            this.Parametre.HeaderText = "Ajouter un paramètre";
            this.Parametre.Name = "Parametre";
            // 
            // parametreListeBindingSource
            // 
            this.parametreListeBindingSource.DataMember = "ParametreListe";
            this.parametreListeBindingSource.DataSource = this.nouvelleBaseEssaieDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom de l\'etiquette";
            // 
            // checkBoxKIT
            // 
            this.checkBoxKIT.AutoSize = true;
            this.checkBoxKIT.Location = new System.Drawing.Point(294, 444);
            this.checkBoxKIT.Name = "checkBoxKIT";
            this.checkBoxKIT.Size = new System.Drawing.Size(43, 17);
            this.checkBoxKIT.TabIndex = 11;
            this.checkBoxKIT.Text = "KIT";
            this.checkBoxKIT.UseVisualStyleBackColor = true;
            // 
            // checkBoxSSE
            // 
            this.checkBoxSSE.AutoSize = true;
            this.checkBoxSSE.Location = new System.Drawing.Point(241, 444);
            this.checkBoxSSE.Name = "checkBoxSSE";
            this.checkBoxSSE.Size = new System.Drawing.Size(47, 17);
            this.checkBoxSSE.TabIndex = 10;
            this.checkBoxSSE.Text = "SSE";
            this.checkBoxSSE.UseVisualStyleBackColor = true;
            // 
            // checkBoxManut
            // 
            this.checkBoxManut.AutoSize = true;
            this.checkBoxManut.Location = new System.Drawing.Point(179, 444);
            this.checkBoxManut.Name = "checkBoxManut";
            this.checkBoxManut.Size = new System.Drawing.Size(56, 17);
            this.checkBoxManut.TabIndex = 9;
            this.checkBoxManut.Text = "Manut";
            this.checkBoxManut.UseVisualStyleBackColor = true;
            // 
            // checkBoxCable
            // 
            this.checkBoxCable.AutoSize = true;
            this.checkBoxCable.Location = new System.Drawing.Point(120, 444);
            this.checkBoxCable.Name = "checkBoxCable";
            this.checkBoxCable.Size = new System.Drawing.Size(53, 17);
            this.checkBoxCable.TabIndex = 8;
            this.checkBoxCable.Text = "Cable";
            this.checkBoxCable.UseVisualStyleBackColor = true;
            // 
            // checkBoxBorne
            // 
            this.checkBoxBorne.AutoSize = true;
            this.checkBoxBorne.Location = new System.Drawing.Point(60, 444);
            this.checkBoxBorne.Name = "checkBoxBorne";
            this.checkBoxBorne.Size = new System.Drawing.Size(54, 17);
            this.checkBoxBorne.TabIndex = 7;
            this.checkBoxBorne.Text = "Borne";
            this.checkBoxBorne.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(12, 480);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(90, 23);
            this.buttonValider.TabIndex = 12;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(298, 480);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(90, 23);
            this.buttonAnnuler.TabIndex = 13;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // parametreListeTableAdapter
            // 
            this.parametreListeTableAdapter.ClearBeforeFill = true;
            // 
            // MODIFListeParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 515);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.checkBoxKIT);
            this.Controls.Add(this.checkBoxSSE);
            this.Controls.Add(this.checkBoxManut);
            this.Controls.Add(this.checkBoxCable);
            this.Controls.Add(this.checkBoxBorne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewParametre);
            this.Controls.Add(this.buttonRecherche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "MODIFListeParametre";
            this.Text = "Modifier une liste de paramètre";
            this.Load += new System.EventHandler(this.MODIFListeParametre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeEtiquetteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParametre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametreListeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private NouvelleBaseEssaieDataSet nouvelleBaseEssaieDataSet;
        private System.Windows.Forms.BindingSource listeEtiquetteBindingSource;
        private NouvelleBaseEssaieDataSetTableAdapters.ListeEtiquetteTableAdapter listeEtiquetteTableAdapter;
        private System.Windows.Forms.Button buttonRecherche;
        private System.Windows.Forms.DataGridView dataGridViewParametre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxKIT;
        private System.Windows.Forms.CheckBox checkBoxSSE;
        private System.Windows.Forms.CheckBox checkBoxManut;
        private System.Windows.Forms.CheckBox checkBoxCable;
        private System.Windows.Forms.CheckBox checkBoxBorne;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.BindingSource parametreListeBindingSource;
        private NouvelleBaseEssaieDataSetTableAdapters.ParametreListeTableAdapter parametreListeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn etiquetteParameterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewComboBoxColumn Parametre;
    }
}