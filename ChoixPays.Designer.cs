namespace ModificationBaseDeDonnees
{
    partial class ChoixPays
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
            this.nouvelleBaseEssaieDataSet = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSet();
            this.parametreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parametreTableAdapter = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSetTableAdapters.ParametreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.parametreBindingSource;
            this.comboBox1.DisplayMember = "Valeur";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(353, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Valeur";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nouvelleBaseEssaieDataSet
            // 
            this.nouvelleBaseEssaieDataSet.DataSetName = "NouvelleBaseEssaieDataSet";
            this.nouvelleBaseEssaieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parametreBindingSource
            // 
            this.parametreBindingSource.DataMember = "Parametre";
            this.parametreBindingSource.DataSource = this.nouvelleBaseEssaieDataSet;
            // 
            // parametreTableAdapter
            // 
            this.parametreTableAdapter.ClearBeforeFill = true;
            // 
            // ChoixPays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 90);
            this.Controls.Add(this.comboBox1);
            this.Name = "ChoixPays";
            this.Text = "Choix du Pays";
            this.Load += new System.EventHandler(this.ChoixPays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private NouvelleBaseEssaieDataSet nouvelleBaseEssaieDataSet;
        private System.Windows.Forms.BindingSource parametreBindingSource;
        private NouvelleBaseEssaieDataSetTableAdapters.ParametreTableAdapter parametreTableAdapter;
    }
}