namespace ModificationBaseDeDonnees
{
    partial class DELETEFils
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.nouvelleBaseEssaieDataSet = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSet();
            this.referenceFilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.referenceFilsTableAdapter = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSetTableAdapters.ReferenceFilsTableAdapter();
            this.requeteFilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requeteFilsTableAdapter = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSetTableAdapters.RequeteFilsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceFilsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requeteFilsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.requeteFilsBindingSource;
            this.comboBox1.DisplayMember = "Fils";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Fils";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectionner le fils à supprimer";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(12, 88);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 2;
            this.buttonValider.Text = "Supprimer";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(148, 88);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 3;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // nouvelleBaseEssaieDataSet
            // 
            this.nouvelleBaseEssaieDataSet.DataSetName = "NouvelleBaseEssaieDataSet";
            this.nouvelleBaseEssaieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // requeteFilsBindingSource
            // 
            this.requeteFilsBindingSource.DataMember = "RequeteFils";
            this.requeteFilsBindingSource.DataSource = this.nouvelleBaseEssaieDataSet;
            // 
            // requeteFilsTableAdapter
            // 
            this.requeteFilsTableAdapter.ClearBeforeFill = true;
            // 
            // DELETEFils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 127);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "DELETEFils";
            this.Text = "Supprimer un fils";
            this.Load += new System.EventHandler(this.DELETEFils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceFilsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requeteFilsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private NouvelleBaseEssaieDataSet nouvelleBaseEssaieDataSet;
        private System.Windows.Forms.BindingSource referenceFilsBindingSource;
        private NouvelleBaseEssaieDataSetTableAdapters.ReferenceFilsTableAdapter referenceFilsTableAdapter;
        private System.Windows.Forms.BindingSource requeteFilsBindingSource;
        private NouvelleBaseEssaieDataSetTableAdapters.RequeteFilsTableAdapter requeteFilsTableAdapter;
    }
}