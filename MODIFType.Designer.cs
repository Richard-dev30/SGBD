namespace ModificationBaseDeDonnees
{
    partial class MODIFType
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
            this.typeFamilleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nouvelleBaseEssaieDataSet = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.typeFamilleTableAdapter = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSetTableAdapters.TypeFamilleTableAdapter();
            this.textBoxFamille = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.comboBoxNature = new System.Windows.Forms.ComboBox();
            this.presencefils = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewType = new System.Windows.Forms.DataGridView();
            this.familleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonrecherche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.typeFamilleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.typeFamilleBindingSource;
            this.comboBox1.DisplayMember = "Type";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Type";
            // 
            // typeFamilleBindingSource
            // 
            this.typeFamilleBindingSource.DataMember = "TypeFamille";
            this.typeFamilleBindingSource.DataSource = this.nouvelleBaseEssaieDataSet;
            // 
            // nouvelleBaseEssaieDataSet
            // 
            this.nouvelleBaseEssaieDataSet.DataSetName = "NouvelleBaseEssaieDataSet";
            this.nouvelleBaseEssaieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectionner le type à modifier";
            // 
            // typeFamilleTableAdapter
            // 
            this.typeFamilleTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxFamille
            // 
            this.textBoxFamille.Location = new System.Drawing.Point(22, 148);
            this.textBoxFamille.Name = "textBoxFamille";
            this.textBoxFamille.Size = new System.Drawing.Size(148, 20);
            this.textBoxFamille.TabIndex = 2;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(22, 262);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(148, 20);
            this.textBoxType.TabIndex = 3;
            // 
            // comboBoxNature
            // 
            this.comboBoxNature.FormattingEnabled = true;
            this.comboBoxNature.Items.AddRange(new object[] {
            "BORNE",
            "MANUT",
            "CABLE",
            "KIT",
            "SSE"});
            this.comboBoxNature.Location = new System.Drawing.Point(22, 203);
            this.comboBoxNature.Name = "comboBoxNature";
            this.comboBoxNature.Size = new System.Drawing.Size(148, 21);
            this.comboBoxNature.TabIndex = 4;
            // 
            // presencefils
            // 
            this.presencefils.AutoSize = true;
            this.presencefils.Location = new System.Drawing.Point(22, 316);
            this.presencefils.Name = "presencefils";
            this.presencefils.Size = new System.Drawing.Size(109, 17);
            this.presencefils.TabIndex = 5;
            this.presencefils.Text = "Présence d\'un fils";
            this.presencefils.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Famille";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nature du produit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewType
            // 
            this.dataGridViewType.AutoGenerateColumns = false;
            this.dataGridViewType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.familleDataGridViewTextBoxColumn,
            this.pRODUITDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.filsDataGridViewCheckBoxColumn});
            this.dataGridViewType.DataSource = this.typeFamilleBindingSource;
            this.dataGridViewType.Location = new System.Drawing.Point(231, 18);
            this.dataGridViewType.Name = "dataGridViewType";
            this.dataGridViewType.Size = new System.Drawing.Size(509, 150);
            this.dataGridViewType.TabIndex = 11;
            this.dataGridViewType.Visible = false;
            // 
            // familleDataGridViewTextBoxColumn
            // 
            this.familleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.familleDataGridViewTextBoxColumn.DataPropertyName = "Famille";
            this.familleDataGridViewTextBoxColumn.HeaderText = "Famille";
            this.familleDataGridViewTextBoxColumn.Name = "familleDataGridViewTextBoxColumn";
            // 
            // pRODUITDataGridViewTextBoxColumn
            // 
            this.pRODUITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pRODUITDataGridViewTextBoxColumn.DataPropertyName = "PRODUIT";
            this.pRODUITDataGridViewTextBoxColumn.HeaderText = "PRODUIT";
            this.pRODUITDataGridViewTextBoxColumn.Name = "pRODUITDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // filsDataGridViewCheckBoxColumn
            // 
            this.filsDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filsDataGridViewCheckBoxColumn.DataPropertyName = "Fils";
            this.filsDataGridViewCheckBoxColumn.HeaderText = "Fils";
            this.filsDataGridViewCheckBoxColumn.Name = "filsDataGridViewCheckBoxColumn";
            // 
            // buttonrecherche
            // 
            this.buttonrecherche.Location = new System.Drawing.Point(57, 76);
            this.buttonrecherche.Name = "buttonrecherche";
            this.buttonrecherche.Size = new System.Drawing.Size(75, 23);
            this.buttonrecherche.TabIndex = 12;
            this.buttonrecherche.Text = "Recherche";
            this.buttonrecherche.UseVisualStyleBackColor = true;
            this.buttonrecherche.Click += new System.EventHandler(this.buttonrecherche_Click);
            // 
            // MODIFType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 417);
            this.Controls.Add(this.buttonrecherche);
            this.Controls.Add(this.dataGridViewType);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.presencefils);
            this.Controls.Add(this.comboBoxNature);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxFamille);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "MODIFType";
            this.Text = "Modification d\'un type";
            this.Load += new System.EventHandler(this.MODIFType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeFamilleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private NouvelleBaseEssaieDataSet nouvelleBaseEssaieDataSet;
        private System.Windows.Forms.BindingSource typeFamilleBindingSource;
        private NouvelleBaseEssaieDataSetTableAdapters.TypeFamilleTableAdapter typeFamilleTableAdapter;
        private System.Windows.Forms.TextBox textBoxFamille;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.ComboBox comboBoxNature;
        private System.Windows.Forms.CheckBox presencefils;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewType;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn filsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button buttonrecherche;
    }
}