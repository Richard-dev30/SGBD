namespace ModificationBaseDeDonnees
{
    partial class ADDEtiquette
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewParametre = new System.Windows.Forms.DataGridView();
            this.Paramètre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListeParametre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.parametreListeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nouvelleBaseEssaieDataSet = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSet();
            this.checkBoxKIT = new System.Windows.Forms.CheckBox();
            this.checkBoxSSE = new System.Windows.Forms.CheckBox();
            this.checkBoxManut = new System.Windows.Forms.CheckBox();
            this.checkBoxCable = new System.Windows.Forms.CheckBox();
            this.checkBoxBorne = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listeEtiquetteTableAdapter1 = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSetTableAdapters.ListeEtiquetteTableAdapter();
            this.parametreListeTableAdapter = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSetTableAdapters.ParametreListeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParametre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametreListeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Exemple : Borne 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de la liste de paramètre";
            // 
            // dataGridViewParametre
            // 
            this.dataGridViewParametre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParametre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Paramètre,
            this.ListeParametre});
            this.dataGridViewParametre.Location = new System.Drawing.Point(13, 69);
            this.dataGridViewParametre.Name = "dataGridViewParametre";
            this.dataGridViewParametre.Size = new System.Drawing.Size(311, 336);
            this.dataGridViewParametre.TabIndex = 2;
            this.dataGridViewParametre.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParametre_CellValueChanged);
            // 
            // Paramètre
            // 
            this.Paramètre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Paramètre.HeaderText = "Paramètre";
            this.Paramètre.Name = "Paramètre";
            // 
            // ListeParametre
            // 
            this.ListeParametre.DataSource = this.parametreListeBindingSource;
            this.ListeParametre.DisplayMember = "ListParametre";
            this.ListeParametre.HeaderText = "Liste des paramètre";
            this.ListeParametre.Name = "ListeParametre";
            // 
            // parametreListeBindingSource
            // 
            this.parametreListeBindingSource.DataMember = "ParametreListe";
            this.parametreListeBindingSource.DataSource = this.nouvelleBaseEssaieDataSet;
            // 
            // nouvelleBaseEssaieDataSet
            // 
            this.nouvelleBaseEssaieDataSet.DataSetName = "NouvelleBaseEssaieDataSet";
            this.nouvelleBaseEssaieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBoxKIT
            // 
            this.checkBoxKIT.AutoSize = true;
            this.checkBoxKIT.Location = new System.Drawing.Point(262, 453);
            this.checkBoxKIT.Name = "checkBoxKIT";
            this.checkBoxKIT.Size = new System.Drawing.Size(43, 17);
            this.checkBoxKIT.TabIndex = 11;
            this.checkBoxKIT.Text = "KIT";
            this.checkBoxKIT.UseVisualStyleBackColor = true;
            // 
            // checkBoxSSE
            // 
            this.checkBoxSSE.AutoSize = true;
            this.checkBoxSSE.Location = new System.Drawing.Point(209, 453);
            this.checkBoxSSE.Name = "checkBoxSSE";
            this.checkBoxSSE.Size = new System.Drawing.Size(47, 17);
            this.checkBoxSSE.TabIndex = 10;
            this.checkBoxSSE.Text = "SSE";
            this.checkBoxSSE.UseVisualStyleBackColor = true;
            // 
            // checkBoxManut
            // 
            this.checkBoxManut.AutoSize = true;
            this.checkBoxManut.Location = new System.Drawing.Point(147, 453);
            this.checkBoxManut.Name = "checkBoxManut";
            this.checkBoxManut.Size = new System.Drawing.Size(56, 17);
            this.checkBoxManut.TabIndex = 9;
            this.checkBoxManut.Text = "Manut";
            this.checkBoxManut.UseVisualStyleBackColor = true;
            // 
            // checkBoxCable
            // 
            this.checkBoxCable.AutoSize = true;
            this.checkBoxCable.Location = new System.Drawing.Point(88, 453);
            this.checkBoxCable.Name = "checkBoxCable";
            this.checkBoxCable.Size = new System.Drawing.Size(53, 17);
            this.checkBoxCable.TabIndex = 8;
            this.checkBoxCable.Text = "Cable";
            this.checkBoxCable.UseVisualStyleBackColor = true;
            // 
            // checkBoxBorne
            // 
            this.checkBoxBorne.AutoSize = true;
            this.checkBoxBorne.Location = new System.Drawing.Point(28, 453);
            this.checkBoxBorne.Name = "checkBoxBorne";
            this.checkBoxBorne.Size = new System.Drawing.Size(54, 17);
            this.checkBoxBorne.TabIndex = 7;
            this.checkBoxBorne.Text = "Borne";
            this.checkBoxBorne.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Indiquer pour quelle type de produit les paramètre peut être choisi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listeEtiquetteTableAdapter1
            // 
            this.listeEtiquetteTableAdapter1.ClearBeforeFill = true;
            // 
            // parametreListeTableAdapter
            // 
            this.parametreListeTableAdapter.ClearBeforeFill = true;
            // 
            // ADDEtiquette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxKIT);
            this.Controls.Add(this.checkBoxSSE);
            this.Controls.Add(this.checkBoxManut);
            this.Controls.Add(this.checkBoxCable);
            this.Controls.Add(this.checkBoxBorne);
            this.Controls.Add(this.dataGridViewParametre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "ADDEtiquette";
            this.Text = "Ajouter une liste de paramètre";
            this.Load += new System.EventHandler(this.ADDEtiquette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParametre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametreListeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewParametre;
        private System.Windows.Forms.CheckBox checkBoxKIT;
        private System.Windows.Forms.CheckBox checkBoxSSE;
        private System.Windows.Forms.CheckBox checkBoxManut;
        private System.Windows.Forms.CheckBox checkBoxCable;
        private System.Windows.Forms.CheckBox checkBoxBorne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private NouvelleBaseEssaieDataSetTableAdapters.ListeEtiquetteTableAdapter listeEtiquetteTableAdapter1;
        private NouvelleBaseEssaieDataSet nouvelleBaseEssaieDataSet;
        private System.Windows.Forms.BindingSource parametreListeBindingSource;
        private NouvelleBaseEssaieDataSetTableAdapters.ParametreListeTableAdapter parametreListeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paramètre;
        private System.Windows.Forms.DataGridViewComboBoxColumn ListeParametre;
    }
}