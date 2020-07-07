namespace ModificationBaseDeDonnees
{
    partial class ADDParametre
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
            this.textBoxParametre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxBorne = new System.Windows.Forms.CheckBox();
            this.checkBoxCable = new System.Windows.Forms.CheckBox();
            this.checkBoxManut = new System.Windows.Forms.CheckBox();
            this.checkBoxSSE = new System.Windows.Forms.CheckBox();
            this.checkBoxKIT = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.parametreListeTableAdapter1 = new ModificationBaseDeDonnees.NouvelleBaseEssaieDataSetTableAdapters.ParametreListeTableAdapter();
            this.SuspendLayout();
            // 
            // textBoxParametre
            // 
            this.textBoxParametre.Location = new System.Drawing.Point(22, 45);
            this.textBoxParametre.Name = "textBoxParametre";
            this.textBoxParametre.Size = new System.Drawing.Size(277, 20);
            this.textBoxParametre.TabIndex = 0;
            this.textBoxParametre.Text = "Exemple : PN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du paramètre";
            // 
            // checkBoxBorne
            // 
            this.checkBoxBorne.AutoSize = true;
            this.checkBoxBorne.Location = new System.Drawing.Point(26, 116);
            this.checkBoxBorne.Name = "checkBoxBorne";
            this.checkBoxBorne.Size = new System.Drawing.Size(54, 17);
            this.checkBoxBorne.TabIndex = 2;
            this.checkBoxBorne.Text = "Borne";
            this.checkBoxBorne.UseVisualStyleBackColor = true;
            // 
            // checkBoxCable
            // 
            this.checkBoxCable.AutoSize = true;
            this.checkBoxCable.Location = new System.Drawing.Point(86, 116);
            this.checkBoxCable.Name = "checkBoxCable";
            this.checkBoxCable.Size = new System.Drawing.Size(53, 17);
            this.checkBoxCable.TabIndex = 3;
            this.checkBoxCable.Text = "Cable";
            this.checkBoxCable.UseVisualStyleBackColor = true;
            // 
            // checkBoxManut
            // 
            this.checkBoxManut.AutoSize = true;
            this.checkBoxManut.Location = new System.Drawing.Point(145, 116);
            this.checkBoxManut.Name = "checkBoxManut";
            this.checkBoxManut.Size = new System.Drawing.Size(56, 17);
            this.checkBoxManut.TabIndex = 4;
            this.checkBoxManut.Text = "Manut";
            this.checkBoxManut.UseVisualStyleBackColor = true;
            // 
            // checkBoxSSE
            // 
            this.checkBoxSSE.AutoSize = true;
            this.checkBoxSSE.Location = new System.Drawing.Point(207, 116);
            this.checkBoxSSE.Name = "checkBoxSSE";
            this.checkBoxSSE.Size = new System.Drawing.Size(47, 17);
            this.checkBoxSSE.TabIndex = 5;
            this.checkBoxSSE.Text = "SSE";
            this.checkBoxSSE.UseVisualStyleBackColor = true;
            // 
            // checkBoxKIT
            // 
            this.checkBoxKIT.AutoSize = true;
            this.checkBoxKIT.Location = new System.Drawing.Point(260, 116);
            this.checkBoxKIT.Name = "checkBoxKIT";
            this.checkBoxKIT.Size = new System.Drawing.Size(43, 17);
            this.checkBoxKIT.TabIndex = 6;
            this.checkBoxKIT.Text = "KIT";
            this.checkBoxKIT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Indiquer pour quelle type de produit le paramètre peut être choisi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // parametreListeTableAdapter1
            // 
            this.parametreListeTableAdapter1.ClearBeforeFill = true;
            // 
            // ADDParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 198);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxKIT);
            this.Controls.Add(this.checkBoxSSE);
            this.Controls.Add(this.checkBoxManut);
            this.Controls.Add(this.checkBoxCable);
            this.Controls.Add(this.checkBoxBorne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxParametre);
            this.Name = "ADDParametre";
            this.Text = "Ajouter un paramètre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParametre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxBorne;
        private System.Windows.Forms.CheckBox checkBoxCable;
        private System.Windows.Forms.CheckBox checkBoxManut;
        private System.Windows.Forms.CheckBox checkBoxSSE;
        private System.Windows.Forms.CheckBox checkBoxKIT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private NouvelleBaseEssaieDataSetTableAdapters.ParametreListeTableAdapter parametreListeTableAdapter1;
    }
}