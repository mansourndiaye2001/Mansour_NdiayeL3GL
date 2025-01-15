namespace Mansour_NDIAYE
{
    partial class FormEtudiant
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
            this.txtnom = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.Label();
            this.cmbclasse = new System.Windows.Forms.Label();
            this.prenomtxt = new System.Windows.Forms.TextBox();
            this.nomtxt = new System.Windows.Forms.TextBox();
            this.cmbc = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnmodif = new System.Windows.Forms.Button();
            this.btnsupp = new System.Windows.Forms.Button();
            this.bntann = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnom
            // 
            this.txtnom.AutoSize = true;
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(34, 47);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(39, 16);
            this.txtnom.TabIndex = 0;
            this.txtnom.Text = "Nom";
            // 
            // txtprenom
            // 
            this.txtprenom.AutoSize = true;
            this.txtprenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprenom.Location = new System.Drawing.Point(34, 102);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(60, 16);
            this.txtprenom.TabIndex = 1;
            this.txtprenom.Text = "Prenom";
            // 
            // cmbclasse
            // 
            this.cmbclasse.AutoSize = true;
            this.cmbclasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbclasse.Location = new System.Drawing.Point(34, 159);
            this.cmbclasse.Name = "cmbclasse";
            this.cmbclasse.Size = new System.Drawing.Size(55, 16);
            this.cmbclasse.TabIndex = 2;
            this.cmbclasse.Text = "Classe";
            // 
            // prenomtxt
            // 
            this.prenomtxt.Location = new System.Drawing.Point(151, 102);
            this.prenomtxt.Name = "prenomtxt";
            this.prenomtxt.Size = new System.Drawing.Size(146, 20);
            this.prenomtxt.TabIndex = 3;
            // 
            // nomtxt
            // 
            this.nomtxt.Location = new System.Drawing.Point(151, 43);
            this.nomtxt.Name = "nomtxt";
            this.nomtxt.Size = new System.Drawing.Size(146, 20);
            this.nomtxt.TabIndex = 4;
            // 
            // cmbc
            // 
            this.cmbc.FormattingEnabled = true;
            this.cmbc.Location = new System.Drawing.Point(151, 159);
            this.cmbc.Name = "cmbc";
            this.cmbc.Size = new System.Drawing.Size(146, 21);
            this.cmbc.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 154);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(470, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "GESTION DES ETUDIANTS";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(12, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmodif
            // 
            this.btnmodif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodif.ForeColor = System.Drawing.Color.Gold;
            this.btnmodif.Location = new System.Drawing.Point(242, 339);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(96, 23);
            this.btnmodif.TabIndex = 9;
            this.btnmodif.Text = "Modifier";
            this.btnmodif.UseVisualStyleBackColor = true;
            this.btnmodif.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsupp
            // 
            this.btnsupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupp.ForeColor = System.Drawing.Color.Crimson;
            this.btnsupp.Location = new System.Drawing.Point(473, 339);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.Size = new System.Drawing.Size(96, 23);
            this.btnsupp.TabIndex = 10;
            this.btnsupp.Text = "Supprimer";
            this.btnsupp.UseVisualStyleBackColor = true;
            this.btnsupp.Click += new System.EventHandler(this.button3_Click);
            // 
            // bntann
            // 
            this.bntann.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntann.Location = new System.Drawing.Point(692, 339);
            this.bntann.Name = "bntann";
            this.bntann.Size = new System.Drawing.Size(96, 23);
            this.bntann.TabIndex = 11;
            this.bntann.Text = "Annuler";
            this.bntann.UseVisualStyleBackColor = true;
            // 
            // FormEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntann);
            this.Controls.Add(this.btnsupp);
            this.Controls.Add(this.btnmodif);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbc);
            this.Controls.Add(this.nomtxt);
            this.Controls.Add(this.prenomtxt);
            this.Controls.Add(this.cmbclasse);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Name = "FormEtudiant";
            this.Text = "FormEtudiant";
            this.Load += new System.EventHandler(this.FormEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtnom;
        private System.Windows.Forms.Label txtprenom;
        private System.Windows.Forms.Label cmbclasse;
        private System.Windows.Forms.TextBox prenomtxt;
        private System.Windows.Forms.TextBox nomtxt;
        private System.Windows.Forms.ComboBox cmbc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnmodif;
        private System.Windows.Forms.Button btnsupp;
        private System.Windows.Forms.Button bntann;
    }
}