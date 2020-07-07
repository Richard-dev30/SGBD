namespace ModificationBaseDeDonnees
{
    partial class MODIFFils
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
            this.comboBoxFils = new System.Windows.Forms.ComboBox();
            this.requeteFilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nouvelleBaseEssaieDataSet = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSet();
            this.labelselection = new System.Windows.Forms.Label();
            this.requeteFilsTableAdapter = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSetTableAdapters.RequeteFilsTableAdapter();
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.textBoxDef = new System.Windows.Forms.TextBox();
            this.labelref = new System.Windows.Forms.Label();
            this.labeldef = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnuler = new System.Windows.Forms.Button();
            this.dataGridViewProduit = new System.Windows.Forms.DataGridView();
            this.typeCarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceFilsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceFilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.referenceFilsTableAdapter = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSetTableAdapters.ReferenceFilsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.requeteFilsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceFilsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFils
            // 
            this.comboBoxFils.DataSource = this.requeteFilsBindingSource;
            this.comboBoxFils.DisplayMember = "Fils";
            this.comboBoxFils.FormattingEnabled = true;
            this.comboBoxFils.Location = new System.Drawing.Point(27, 49);
            this.comboBoxFils.Name = "comboBoxFils";
            this.comboBoxFils.Size = new System.Drawing.Size(188, 21);
            this.comboBoxFils.TabIndex = 0;
            this.comboBoxFils.ValueMember = "Fils";
            this.comboBoxFils.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // requeteFilsBindingSource
            // 
            this.requeteFilsBindingSource.DataMember = "RequeteFils";
            this.requeteFilsBindingSource.DataSource = this.nouvelleBaseEssaieDataSet;
            // 
            // nouvelleBaseEssaieDataSet
            // 
            this.nouvelleBaseEssaieDataSet.DataSetName = "NouvelleBaseEssaieDataSet";
            this.nouvelleBaseEssaieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelselection
            // 
            this.labelselection.AutoSize = true;
            this.labelselection.Location = new System.Drawing.Point(27, 19);
            this.labelselection.Name = "labelselection";
            this.labelselection.Size = new System.Drawing.Size(188, 13);
            this.labelselection.TabIndex = 1;
            this.labelselection.Text = "Sélectionner la référence fils à modifier";
            // 
            // requeteFilsTableAdapter
            // 
            this.requeteFilsTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxRef
            // 
            this.textBoxRef.Location = new System.Drawing.Point(27, 116);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(188, 20);
            this.textBoxRef.TabIndex = 2;
            // 
            // textBoxDef
            // 
            this.textBoxDef.Location = new System.Drawing.Point(27, 189);
            this.textBoxDef.Name = "textBoxDef";
            this.textBoxDef.Size = new System.Drawing.Size(188, 20);
            this.textBoxDef.TabIndex = 3;
            // 
            // labelref
            // 
            this.labelref.AutoSize = true;
            this.labelref.Location = new System.Drawing.Point(30, 94);
            this.labelref.Name = "labelref";
            this.labelref.Size = new System.Drawing.Size(57, 13);
            this.labelref.TabIndex = 4;
            this.labelref.Text = "Référence";
            // 
            // labeldef
            // 
            this.labeldef.AutoSize = true;
            this.labeldef.Location = new System.Drawing.Point(30, 169);
            this.labeldef.Name = "labeldef";
            this.labeldef.Size = new System.Drawing.Size(51, 13);
            this.labeldef.TabIndex = 5;
            this.labeldef.Text = "Définition";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(27, 233);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 6;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnuler
            // 
            this.buttonAnuler.Location = new System.Drawing.Point(140, 233);
            this.buttonAnuler.Name = "buttonAnuler";
            this.buttonAnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuler.TabIndex = 7;
            this.buttonAnuler.Text = "Anuler";
            this.buttonAnuler.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProduit
            // 
            this.dataGridViewProduit.AutoGenerateColumns = false;
            this.dataGridViewProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeCarteDataGridViewTextBoxColumn,
            this.referenceFilsDataGridViewTextBoxColumn});
            this.dataGridViewProduit.DataSource = this.referenceFilsBindingSource;
            this.dataGridViewProduit.Location = new System.Drawing.Point(296, 78);
            this.dataGridViewProduit.Name = "dataGridViewProduit";
            this.dataGridViewProduit.Size = new System.Drawing.Size(284, 58);
            this.dataGridViewProduit.TabIndex = 8;
            this.dataGridViewProduit.Visible = false;
            // 
            // typeCarteDataGridViewTextBoxColumn
            // 
            this.typeCarteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeCarteDataGridViewTextBoxColumn.DataPropertyName = "Type-Carte";
            this.typeCarteDataGridViewTextBoxColumn.HeaderText = "Type-Carte";
            this.typeCarteDataGridViewTextBoxColumn.Name = "typeCarteDataGridViewTextBoxColumn";
            // 
            // referenceFilsDataGridViewTextBoxColumn
            // 
            this.referenceFilsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.referenceFilsDataGridViewTextBoxColumn.DataPropertyName = "Reference-Fils";
            this.referenceFilsDataGridViewTextBoxColumn.HeaderText = "Reference-Fils";
            this.referenceFilsDataGridViewTextBoxColumn.Name = "referenceFilsDataGridViewTextBoxColumn";
            // 
            // referenceFilsBindingSource
            // 
            this.referenceFilsBindingSource.DataMember = "ReferenceFils";
            this.referenceFilsBindingSource.DataSource = this.nouvelleBaseEssaieDataSet;
            // 
            // referenceFilsTableAdapter
            // 
            this.referenceFilsTableAdapter.ClearBeforeFill = true;
            // 
            // MODIFFils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 283);
            this.Controls.Add(this.dataGridViewProduit);
            this.Controls.Add(this.buttonAnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.labeldef);
            this.Controls.Add(this.labelref);
            this.Controls.Add(this.textBoxDef);
            this.Controls.Add(this.textBoxRef);
            this.Controls.Add(this.labelselection);
            this.Controls.Add(this.comboBoxFils);
            this.Name = "MODIFFils";
            this.Text = "Modification d\'un fils";
            this.Load += new System.EventHandler(this.MODIFFils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requeteFilsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceFilsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFils;
        private System.Windows.Forms.Label labelselection;
        private NouvelleBaseEssaieDataSet nouvelleBaseEssaieDataSet;
        private System.Windows.Forms.BindingSource requeteFilsBindingSource;
        private NouvelleBaseEssaieDataSetTableAdapters.RequeteFilsTableAdapter requeteFilsTableAdapter;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.TextBox textBoxDef;
        private System.Windows.Forms.Label labelref;
        private System.Windows.Forms.Label labeldef;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnuler;
        private System.Windows.Forms.DataGridView dataGridViewProduit;
        private System.Windows.Forms.BindingSource referenceFilsBindingSource;
        private NouvelleBaseEssaieDataSetTableAdapters.ReferenceFilsTableAdapter referenceFilsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceFilsDataGridViewTextBoxColumn;
    }
}