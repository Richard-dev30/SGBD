namespace ModificationBaseDeDonnees
{
    partial class ADDFils
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
            this.textBoxReferenceFils = new System.Windows.Forms.TextBox();
            this.textBoxNomFils = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreefils = new System.Windows.Forms.Button();
            this.dataGridViewVerif = new System.Windows.Forms.DataGridView();
            this.referenceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceFilsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceFilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nouvelleBaseEssaieDataSet = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSet();
            this.referenceFilsTableAdapter = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSetTableAdapters.ReferenceFilsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceFilsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxReferenceFils
            // 
            this.textBoxReferenceFils.Location = new System.Drawing.Point(12, 41);
            this.textBoxReferenceFils.Name = "textBoxReferenceFils";
            this.textBoxReferenceFils.Size = new System.Drawing.Size(324, 20);
            this.textBoxReferenceFils.TabIndex = 0;
            this.textBoxReferenceFils.Text = "Exemple : 09495_07";
            this.textBoxReferenceFils.Validated += new System.EventHandler(this.textBoxReferenceFils_Validated);
            // 
            // textBoxNomFils
            // 
            this.textBoxNomFils.Location = new System.Drawing.Point(12, 143);
            this.textBoxNomFils.Name = "textBoxNomFils";
            this.textBoxNomFils.Size = new System.Drawing.Size(324, 20);
            this.textBoxNomFils.TabIndex = 1;
            this.textBoxNomFils.Text = "Exemple : Distri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Indiquer la référence fils que vous voullez créer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Indiquer le nom du fils";
            // 
            // buttonCreefils
            // 
            this.buttonCreefils.Location = new System.Drawing.Point(130, 199);
            this.buttonCreefils.Name = "buttonCreefils";
            this.buttonCreefils.Size = new System.Drawing.Size(75, 23);
            this.buttonCreefils.TabIndex = 4;
            this.buttonCreefils.Text = "Créer";
            this.buttonCreefils.UseVisualStyleBackColor = true;
            this.buttonCreefils.Click += new System.EventHandler(this.buttonCreefils_Click);
            // 
            // dataGridViewVerif
            // 
            this.dataGridViewVerif.AutoGenerateColumns = false;
            this.dataGridViewVerif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVerif.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referenceTypeDataGridViewTextBoxColumn,
            this.typeCarteDataGridViewTextBoxColumn,
            this.referenceFilsDataGridViewTextBoxColumn});
            this.dataGridViewVerif.DataSource = this.referenceFilsBindingSource;
            this.dataGridViewVerif.Location = new System.Drawing.Point(370, 25);
            this.dataGridViewVerif.Name = "dataGridViewVerif";
            this.dataGridViewVerif.Size = new System.Drawing.Size(353, 196);
            this.dataGridViewVerif.TabIndex = 5;
            this.dataGridViewVerif.Visible = false;
            // 
            // referenceTypeDataGridViewTextBoxColumn
            // 
            this.referenceTypeDataGridViewTextBoxColumn.DataPropertyName = "ReferenceType";
            this.referenceTypeDataGridViewTextBoxColumn.HeaderText = "ReferenceType";
            this.referenceTypeDataGridViewTextBoxColumn.Name = "referenceTypeDataGridViewTextBoxColumn";
            // 
            // typeCarteDataGridViewTextBoxColumn
            // 
            this.typeCarteDataGridViewTextBoxColumn.DataPropertyName = "Type-Carte";
            this.typeCarteDataGridViewTextBoxColumn.HeaderText = "Type-Carte";
            this.typeCarteDataGridViewTextBoxColumn.Name = "typeCarteDataGridViewTextBoxColumn";
            // 
            // referenceFilsDataGridViewTextBoxColumn
            // 
            this.referenceFilsDataGridViewTextBoxColumn.DataPropertyName = "Reference-Fils";
            this.referenceFilsDataGridViewTextBoxColumn.HeaderText = "Reference-Fils";
            this.referenceFilsDataGridViewTextBoxColumn.Name = "referenceFilsDataGridViewTextBoxColumn";
            // 
            // referenceFilsBindingSource
            // 
            this.referenceFilsBindingSource.DataMember = "ReferenceFils";
            this.referenceFilsBindingSource.DataSource = this.nouvelleBaseEssaieDataSet;
            // 
            // nouvelleBaseEssaieDataSet
            // 
            this.nouvelleBaseEssaieDataSet.DataSetName = "NouvelleBaseEssaieDataSet";
            this.nouvelleBaseEssaieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // referenceFilsTableAdapter
            // 
            this.referenceFilsTableAdapter.ClearBeforeFill = true;
            // 
            // ADDFils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 244);
            this.Controls.Add(this.dataGridViewVerif);
            this.Controls.Add(this.buttonCreefils);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomFils);
            this.Controls.Add(this.textBoxReferenceFils);
            this.Name = "ADDFils";
            this.Text = "Ajouter un fils";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceFilsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReferenceFils;
        private System.Windows.Forms.TextBox textBoxNomFils;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreefils;
        private System.Windows.Forms.DataGridView dataGridViewVerif;
        private NouvelleBaseEssaieDataSet nouvelleBaseEssaieDataSet;
        private System.Windows.Forms.BindingSource referenceFilsBindingSource;
        private NouvelleBaseEssaieDataSetTableAdapters.ReferenceFilsTableAdapter referenceFilsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceFilsDataGridViewTextBoxColumn;
    }
}