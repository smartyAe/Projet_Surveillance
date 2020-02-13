namespace Mini_Projet
{
    partial class Surveillance
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.impressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoiDuProgrammeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTousLesEnseigantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auxEnseignantsSelectionnésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherTousLesEngeignantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesEnseignantsDunDepartementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departement1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departement2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departement3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesEnseignantsDétatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionDeRechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheParNomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheParEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheParDepartementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Enregistrer = new System.Windows.Forms.Button();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.Btn_Modifier = new System.Windows.Forms.Button();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impressionToolStripMenuItem,
            this.envoiDuProgrammeToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.optionDeRechercheToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1085, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // impressionToolStripMenuItem
            // 
            this.impressionToolStripMenuItem.Name = "impressionToolStripMenuItem";
            this.impressionToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.impressionToolStripMenuItem.Text = "Impression";
            // 
            // envoiDuProgrammeToolStripMenuItem
            // 
            this.envoiDuProgrammeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aTousLesEnseigantsToolStripMenuItem,
            this.auxEnseignantsSelectionnésToolStripMenuItem});
            this.envoiDuProgrammeToolStripMenuItem.Name = "envoiDuProgrammeToolStripMenuItem";
            this.envoiDuProgrammeToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.envoiDuProgrammeToolStripMenuItem.Text = "Envoyer  par email";
            // 
            // aTousLesEnseigantsToolStripMenuItem
            // 
            this.aTousLesEnseigantsToolStripMenuItem.Name = "aTousLesEnseigantsToolStripMenuItem";
            this.aTousLesEnseigantsToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.aTousLesEnseigantsToolStripMenuItem.Text = "A tous les enseigants";
            // 
            // auxEnseignantsSelectionnésToolStripMenuItem
            // 
            this.auxEnseignantsSelectionnésToolStripMenuItem.Checked = true;
            this.auxEnseignantsSelectionnésToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.auxEnseignantsSelectionnésToolStripMenuItem.Name = "auxEnseignantsSelectionnésToolStripMenuItem";
            this.auxEnseignantsSelectionnésToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.auxEnseignantsSelectionnésToolStripMenuItem.Text = "Aux enseignants selectionnés";
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherTousLesEngeignantsToolStripMenuItem,
            this.afficherLesEnseignantsDunDepartementToolStripMenuItem,
            this.afficherLesEnseignantsDétatToolStripMenuItem});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // afficherTousLesEngeignantsToolStripMenuItem
            // 
            this.afficherTousLesEngeignantsToolStripMenuItem.Checked = true;
            this.afficherTousLesEngeignantsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.afficherTousLesEngeignantsToolStripMenuItem.Name = "afficherTousLesEngeignantsToolStripMenuItem";
            this.afficherTousLesEngeignantsToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.afficherTousLesEngeignantsToolStripMenuItem.Text = "Afficher tous les engeignants";
            // 
            // afficherLesEnseignantsDunDepartementToolStripMenuItem
            // 
            this.afficherLesEnseignantsDunDepartementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departement1ToolStripMenuItem,
            this.departement2ToolStripMenuItem,
            this.departement3ToolStripMenuItem});
            this.afficherLesEnseignantsDunDepartementToolStripMenuItem.Name = "afficherLesEnseignantsDunDepartementToolStripMenuItem";
            this.afficherLesEnseignantsDunDepartementToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.afficherLesEnseignantsDunDepartementToolStripMenuItem.Text = "Afficher les enseignants d\'un departement ";
            // 
            // departement1ToolStripMenuItem
            // 
            this.departement1ToolStripMenuItem.Name = "departement1ToolStripMenuItem";
            this.departement1ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.departement1ToolStripMenuItem.Text = "Departement1";
            // 
            // departement2ToolStripMenuItem
            // 
            this.departement2ToolStripMenuItem.Name = "departement2ToolStripMenuItem";
            this.departement2ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.departement2ToolStripMenuItem.Text = "Departement2";
            // 
            // departement3ToolStripMenuItem
            // 
            this.departement3ToolStripMenuItem.Name = "departement3ToolStripMenuItem";
            this.departement3ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.departement3ToolStripMenuItem.Text = "Departement3";
            // 
            // afficherLesEnseignantsDétatToolStripMenuItem
            // 
            this.afficherLesEnseignantsDétatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enCoursToolStripMenuItem,
            this.terminéToolStripMenuItem});
            this.afficherLesEnseignantsDétatToolStripMenuItem.Name = "afficherLesEnseignantsDétatToolStripMenuItem";
            this.afficherLesEnseignantsDétatToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.afficherLesEnseignantsDétatToolStripMenuItem.Text = "Afficher les enseignants d\'état";
            // 
            // enCoursToolStripMenuItem
            // 
            this.enCoursToolStripMenuItem.Name = "enCoursToolStripMenuItem";
            this.enCoursToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.enCoursToolStripMenuItem.Text = "En cours";
            // 
            // terminéToolStripMenuItem
            // 
            this.terminéToolStripMenuItem.Name = "terminéToolStripMenuItem";
            this.terminéToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.terminéToolStripMenuItem.Text = "Terminé";
            // 
            // optionDeRechercheToolStripMenuItem
            // 
            this.optionDeRechercheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercheParNomToolStripMenuItem,
            this.rechercheParEmailToolStripMenuItem,
            this.rechercheParDepartementToolStripMenuItem});
            this.optionDeRechercheToolStripMenuItem.Name = "optionDeRechercheToolStripMenuItem";
            this.optionDeRechercheToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.optionDeRechercheToolStripMenuItem.Text = "Option de recherche";
            // 
            // rechercheParNomToolStripMenuItem
            // 
            this.rechercheParNomToolStripMenuItem.Checked = true;
            this.rechercheParNomToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rechercheParNomToolStripMenuItem.Name = "rechercheParNomToolStripMenuItem";
            this.rechercheParNomToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.rechercheParNomToolStripMenuItem.Text = "Recherche par nom";
            // 
            // rechercheParEmailToolStripMenuItem
            // 
            this.rechercheParEmailToolStripMenuItem.Name = "rechercheParEmailToolStripMenuItem";
            this.rechercheParEmailToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.rechercheParEmailToolStripMenuItem.Text = "Recherche par email";
            // 
            // rechercheParDepartementToolStripMenuItem
            // 
            this.rechercheParDepartementToolStripMenuItem.Name = "rechercheParDepartementToolStripMenuItem";
            this.rechercheParDepartementToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.rechercheParDepartementToolStripMenuItem.Text = "Recherche par departement";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(20, 605);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1085, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabel.Text = "État";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.ForeColor = System.Drawing.Color.Lime;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 87);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1077, 513);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Btn_Enregistrer);
            this.groupBox2.Controls.Add(this.Btn_Supprimer);
            this.groupBox2.Controls.Add(this.Btn_Modifier);
            this.groupBox2.Controls.Add(this.Btn_Ajouter);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(435, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 497);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Programmes de surveillance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(433, 37);
            this.label7.TabIndex = 9;
            this.label7.Text = "Programme de l\'enseignant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Etat de finalisation";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "En cours",
            "Terminé"});
            this.comboBox3.Location = new System.Drawing.Point(488, 108);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(136, 24);
            this.comboBox3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Département        :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nom  Prénom(s)  :";
            // 
            // Btn_Enregistrer
            // 
            this.Btn_Enregistrer.Location = new System.Drawing.Point(488, 424);
            this.Btn_Enregistrer.Name = "Btn_Enregistrer";
            this.Btn_Enregistrer.Size = new System.Drawing.Size(136, 44);
            this.Btn_Enregistrer.TabIndex = 4;
            this.Btn_Enregistrer.Text = "Enregistrer";
            this.Btn_Enregistrer.UseVisualStyleBackColor = true;
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.Location = new System.Drawing.Point(488, 348);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(136, 44);
            this.Btn_Supprimer.TabIndex = 3;
            this.Btn_Supprimer.Text = "Supprimer";
            this.Btn_Supprimer.UseVisualStyleBackColor = true;
            this.Btn_Supprimer.Click += new System.EventHandler(this.Btn_Supprimer_Click);
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.Location = new System.Drawing.Point(488, 272);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(136, 44);
            this.Btn_Modifier.TabIndex = 2;
            this.Btn_Modifier.Text = "Modifier";
            this.Btn_Modifier.UseVisualStyleBackColor = true;
            this.Btn_Modifier.Click += new System.EventHandler(this.Btn_Modifier_Click);
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Location = new System.Drawing.Point(488, 196);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(136, 44);
            this.Btn_Ajouter.TabIndex = 1;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 196);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(464, 295);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 497);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enseignants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liste des enseignants";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 22);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(396, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 10;
            // 
            // Surveillance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 647);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Surveillance";
            this.Text = "Surveillance";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem impressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoiDuProgrammeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTousLesEnseigantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auxEnseignantsSelectionnésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherTousLesEngeignantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesEnseignantsDunDepartementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departement1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departement2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departement3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesEnseignantsDétatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionDeRechercheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheParNomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheParEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheParDepartementToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Enregistrer;
        private System.Windows.Forms.Button Btn_Supprimer;
        private System.Windows.Forms.Button Btn_Modifier;
        private System.Windows.Forms.Button Btn_Ajouter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}



