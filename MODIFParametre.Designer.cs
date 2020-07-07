namespace ModificationBaseDeDonnees
{
    partial class MODIFParametre
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
            this.nouvelleBaseEssaieDataSet = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSet();
            this.parametreListeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parametreListeTableAdapter = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSetTableAdapters.ParametreListeTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxKIT = new System.Windows.Forms.CheckBox();
            this.checkBoxSSE = new System.Windows.Forms.CheckBox();
            this.checkBoxManut = new System.Windows.Forms.CheckBox();
            this.checkBoxCable = new System.Windows.Forms.CheckBox();
            this.checkBoxBorne = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parametreListeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listParametreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametreListeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametreListeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.parametreListeBindingSource;
            this.comboBox1.DisplayMember = "ListParametre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ListParametre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectionner le paramètre à modifier";
            // 
            // nouvelleBaseEssaieDataSet
            // 
            this.nouvelleBaseEssaieDataSet.DataSetName = "NouvelleBaseEssaieDataSet";
            this.nouvelleBaseEssaieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parametreListeBindingSource
            // 
            this.parametreListeBindingSource.DataMember = "ParametreListe";
            this.parametreListeBindingSource.DataSource = this.nouvelleBaseEssaieDataSet;
            // 
            // parametreListeTableAdapter
            // 
            this.parametreListeTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 2;
            // 
            // checkBoxKIT
            // 
            this.checkBoxKIT.AutoSize = true;
            this.checkBoxKIT.Location = new System.Drawing.Point(246, 110);
            this.checkBoxKIT.Name = "checkBoxKIT";
            this.checkBoxKIT.Size = new System.Drawing.Size(43, 17);
            this.checkBoxKIT.TabIndex = 11;
            this.checkBoxKIT.Text = "KIT";
            this.checkBoxKIT.UseVisualStyleBackColor = true;
            // 
            // checkBoxSSE
            // 
            this.checkBoxSSE.AutoSize = true;
            this.checkBoxSSE.Location = new System.Drawing.Point(193, 110);
            this.checkBoxSSE.Name = "checkBoxSSE";
            this.checkBoxSSE.Size = new System.Drawing.Size(47, 17);
            this.checkBoxSSE.TabIndex = 10;
            this.checkBoxSSE.Text = "SSE";
            this.checkBoxSSE.UseVisualStyleBackColor = true;
            // 
            // checkBoxManut
            // 
            this.checkBoxManut.AutoSize = true;
            this.checkBoxManut.Location = new System.Drawing.Point(131, 110);
            this.checkBoxManut.Name = "checkBoxManut";
            this.checkBoxManut.Size = new System.Drawing.Size(56, 17);
            this.checkBoxManut.TabIndex = 9;
            this.checkBoxManut.Text = "Manut";
            this.checkBoxManut.UseVisualStyleBackColor = true;
            // 
            // checkBoxCable
            // 
            this.checkBoxCable.AutoSize = true;
            this.checkBoxCable.Location = new System.Drawing.Point(72, 110);
            this.checkBoxCable.Name = "checkBoxCable";
            this.checkBoxCable.Size = new System.Drawing.Size(53, 17);
            this.checkBoxCable.TabIndex = 8;
            this.checkBoxCable.Text = "Cable";
            this.checkBoxCable.UseVisualStyleBackColor = true;
            // 
            // checkBoxBorne
            // 
            this.checkBoxBorne.AutoSize = true;
            this.checkBoxBorne.Location = new System.Drawing.Point(12, 110);
            this.checkBoxBorne.Name = "checkBoxBorne";
            this.checkBoxBorne.Size = new System.Drawing.Size(54, 17);
            this.checkBoxBorne.TabIndex = 7;
            this.checkBoxBorne.Text = "Borne";
            this.checkBoxBorne.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listParametreDataGridViewTextBoxColumn,
            this.assignationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parametreListeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(337, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 190);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Visible = false;
            // 
            // parametreListeBindingSource1
            // 
            this.parametreListeBindingSource1.DataMember = "ParametreListe";
            this.parametreListeBindingSource1.DataSource = this.nouvelleBaseEssaieDataSet;
            // 
            // listParametreDataGridViewTextBoxColumn
            // 
            this.listParametreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.listParametreDataGridViewTextBoxColumn.DataPropertyName = "ListParametre";
            this.listParametreDataGridViewTextBoxColumn.HeaderText = "ListParametre";
            this.listParametreDataGridViewTextBoxColumn.Name = "listParametreDataGridViewTextBoxColumn";
            // 
            // assignationDataGridViewTextBoxColumn
            // 
            this.assignationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.assignationDataGridViewTextBoxColumn.DataPropertyName = "Assignation";
            this.assignationDataGridViewTextBoxColumn.HeaderText = "Assignation";
            this.assignationDataGridViewTextBoxColumn.Name = "assignationDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Recherche";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MODIFParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 197);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxKIT);
            this.Controls.Add(this.checkBoxSSE);
            this.Controls.Add(this.checkBoxManut);
            this.Controls.Add(this.checkBoxCable);
            this.Controls.Add(this.checkBoxBorne);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "MODIFParametre";
            this.Text = "Modifier un paramètre";
            this.Load += new System.EventHandler(this.MODIFParametre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nouvelleBaseEssaieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametreListeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametreListeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private NouvelleBaseEssaieDataSet nouvelleBaseEssaieDataSet;
        private System.Windows.Forms.BindingSource parametreListeBindingSource;
        private NouvelleBaseEssaieDataSetTableAdapters.ParametreListeTableAdapter parametreListeTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxKIT;
        private System.Windows.Forms.CheckBox checkBoxSSE;
        private System.Windows.Forms.CheckBox checkBoxManut;
        private System.Windows.Forms.CheckBox checkBoxCable;
        private System.Windows.Forms.CheckBox checkBoxBorne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn listParametreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource parametreListeBindingSource1;
        private System.Windows.Forms.Button button3;
    }
}