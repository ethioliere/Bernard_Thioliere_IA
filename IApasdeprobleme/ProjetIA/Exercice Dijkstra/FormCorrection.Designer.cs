namespace ExerciceDijkstra
{
    partial class FormCorrection
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
        public void InitializeComponent()
        {
            this.gb_correctionSBS = new System.Windows.Forms.GroupBox();
            this.lbl_detailsOuverts = new System.Windows.Forms.Label();
            this.lbl_detailsFermes = new System.Windows.Forms.Label();
            this.lbl_descriptionSBS = new System.Windows.Forms.Label();
            this.lbl_cheminFinal = new System.Windows.Forms.Label();
            this.tb_infosOuverts = new System.Windows.Forms.TextBox();
            this.tb_infosFermes = new System.Windows.Forms.TextBox();
            this.listBox_O_correction = new System.Windows.Forms.ListBox();
            this.listBox_cheminFinal = new System.Windows.Forms.ListBox();
            this.listBox_F_correction = new System.Windows.Forms.ListBox();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.gb_correctionTV = new System.Windows.Forms.GroupBox();
            this.tv_correctionTV = new System.Windows.Forms.TreeView();
            this.lbl_resultatTV = new System.Windows.Forms.Label();
            this.btn_quitCorrection = new System.Windows.Forms.Button();
            this.gb_correctionSBS.SuspendLayout();
            this.gb_correctionTV.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_correctionSBS
            // 
            this.gb_correctionSBS.Controls.Add(this.lbl_detailsOuverts);
            this.gb_correctionSBS.Controls.Add(this.lbl_detailsFermes);
            this.gb_correctionSBS.Controls.Add(this.lbl_descriptionSBS);
            this.gb_correctionSBS.Controls.Add(this.lbl_cheminFinal);
            this.gb_correctionSBS.Controls.Add(this.tb_infosOuverts);
            this.gb_correctionSBS.Controls.Add(this.tb_infosFermes);
            this.gb_correctionSBS.Controls.Add(this.listBox_O_correction);
            this.gb_correctionSBS.Controls.Add(this.listBox_cheminFinal);
            this.gb_correctionSBS.Controls.Add(this.listBox_F_correction);
            this.gb_correctionSBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_correctionSBS.Location = new System.Drawing.Point(12, 59);
            this.gb_correctionSBS.Name = "gb_correctionSBS";
            this.gb_correctionSBS.Size = new System.Drawing.Size(617, 532);
            this.gb_correctionSBS.TabIndex = 33;
            this.gb_correctionSBS.TabStop = false;
            this.gb_correctionSBS.Text = "Correction étape par étape";
            // 
            // lbl_detailsOuverts
            // 
            this.lbl_detailsOuverts.AutoSize = true;
            this.lbl_detailsOuverts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detailsOuverts.Location = new System.Drawing.Point(377, 392);
            this.lbl_detailsOuverts.Name = "lbl_detailsOuverts";
            this.lbl_detailsOuverts.Size = new System.Drawing.Size(161, 26);
            this.lbl_detailsOuverts.TabIndex = 36;
            this.lbl_detailsOuverts.Text = "Détails Ouverts";
            this.lbl_detailsOuverts.Visible = false;
            // 
            // lbl_detailsFermes
            // 
            this.lbl_detailsFermes.AutoSize = true;
            this.lbl_detailsFermes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detailsFermes.Location = new System.Drawing.Point(58, 392);
            this.lbl_detailsFermes.Name = "lbl_detailsFermes";
            this.lbl_detailsFermes.Size = new System.Drawing.Size(159, 26);
            this.lbl_detailsFermes.TabIndex = 35;
            this.lbl_detailsFermes.Text = "Détails Fermés";
            this.lbl_detailsFermes.Visible = false;
            // 
            // lbl_descriptionSBS
            // 
            this.lbl_descriptionSBS.AutoSize = true;
            this.lbl_descriptionSBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descriptionSBS.Location = new System.Drawing.Point(149, 129);
            this.lbl_descriptionSBS.Name = "lbl_descriptionSBS";
            this.lbl_descriptionSBS.Size = new System.Drawing.Size(278, 26);
            this.lbl_descriptionSBS.TabIndex = 34;
            this.lbl_descriptionSBS.Text = "Description étape par étape";
            this.lbl_descriptionSBS.Visible = false;
            // 
            // lbl_cheminFinal
            // 
            this.lbl_cheminFinal.AutoSize = true;
            this.lbl_cheminFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cheminFinal.Location = new System.Drawing.Point(33, 52);
            this.lbl_cheminFinal.Name = "lbl_cheminFinal";
            this.lbl_cheminFinal.Size = new System.Drawing.Size(164, 26);
            this.lbl_cheminFinal.TabIndex = 33;
            this.lbl_cheminFinal.Text = "Chemin et Cout";
            this.lbl_cheminFinal.Visible = false;
            // 
            // tb_infosOuverts
            // 
            this.tb_infosOuverts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_infosOuverts.Location = new System.Drawing.Point(333, 434);
            this.tb_infosOuverts.Multiline = true;
            this.tb_infosOuverts.Name = "tb_infosOuverts";
            this.tb_infosOuverts.Size = new System.Drawing.Size(233, 69);
            this.tb_infosOuverts.TabIndex = 31;
            this.tb_infosOuverts.Visible = false;
            // 
            // tb_infosFermes
            // 
            this.tb_infosFermes.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.tb_infosFermes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_infosFermes.Location = new System.Drawing.Point(19, 434);
            this.tb_infosFermes.Multiline = true;
            this.tb_infosFermes.Name = "tb_infosFermes";
            this.tb_infosFermes.Size = new System.Drawing.Size(240, 69);
            this.tb_infosFermes.TabIndex = 30;
            this.tb_infosFermes.Visible = false;
            // 
            // listBox_O_correction
            // 
            this.listBox_O_correction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_O_correction.ForeColor = System.Drawing.Color.SeaGreen;
            this.listBox_O_correction.FormattingEnabled = true;
            this.listBox_O_correction.ItemHeight = 20;
            this.listBox_O_correction.Location = new System.Drawing.Point(333, 168);
            this.listBox_O_correction.Name = "listBox_O_correction";
            this.listBox_O_correction.Size = new System.Drawing.Size(233, 204);
            this.listBox_O_correction.TabIndex = 28;
            this.listBox_O_correction.Visible = false;
            // 
            // listBox_cheminFinal
            // 
            this.listBox_cheminFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_cheminFinal.FormattingEnabled = true;
            this.listBox_cheminFinal.ItemHeight = 25;
            this.listBox_cheminFinal.Location = new System.Drawing.Point(253, 52);
            this.listBox_cheminFinal.Name = "listBox_cheminFinal";
            this.listBox_cheminFinal.Size = new System.Drawing.Size(340, 54);
            this.listBox_cheminFinal.TabIndex = 29;
            this.listBox_cheminFinal.Visible = false;
            // 
            // listBox_F_correction
            // 
            this.listBox_F_correction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_F_correction.ForeColor = System.Drawing.Color.SeaGreen;
            this.listBox_F_correction.FormattingEnabled = true;
            this.listBox_F_correction.ItemHeight = 20;
            this.listBox_F_correction.Location = new System.Drawing.Point(19, 168);
            this.listBox_F_correction.Name = "listBox_F_correction";
            this.listBox_F_correction.Size = new System.Drawing.Size(240, 204);
            this.listBox_F_correction.TabIndex = 27;
            this.listBox_F_correction.Visible = false;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Roboto", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.Navy;
            this.lbl_titre.Location = new System.Drawing.Point(484, 9);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(273, 29);
            this.lbl_titre.TabIndex = 34;
            this.lbl_titre.Text = "Algorithme de Dijkstra";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_correctionTV
            // 
            this.gb_correctionTV.Controls.Add(this.lbl_resultatTV);
            this.gb_correctionTV.Controls.Add(this.tv_correctionTV);
            this.gb_correctionTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_correctionTV.Location = new System.Drawing.Point(646, 59);
            this.gb_correctionTV.Name = "gb_correctionTV";
            this.gb_correctionTV.Size = new System.Drawing.Size(500, 532);
            this.gb_correctionTV.TabIndex = 35;
            this.gb_correctionTV.TabStop = false;
            this.gb_correctionTV.Text = "TreeView";
            // 
            // tv_correctionTV
            // 
            this.tv_correctionTV.Location = new System.Drawing.Point(40, 58);
            this.tv_correctionTV.Name = "tv_correctionTV";
            this.tv_correctionTV.Size = new System.Drawing.Size(422, 377);
            this.tv_correctionTV.TabIndex = 0;
            this.tv_correctionTV.Visible = false;
            // 
            // lbl_resultatTV
            // 
            this.lbl_resultatTV.AutoSize = true;
            this.lbl_resultatTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultatTV.Location = new System.Drawing.Point(41, 477);
            this.lbl_resultatTV.Name = "lbl_resultatTV";
            this.lbl_resultatTV.Size = new System.Drawing.Size(0, 24);
            this.lbl_resultatTV.TabIndex = 1;
            // 
            // btn_quitCorrection
            // 
            this.btn_quitCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitCorrection.Location = new System.Drawing.Point(473, 622);
            this.btn_quitCorrection.Name = "btn_quitCorrection";
            this.btn_quitCorrection.Size = new System.Drawing.Size(303, 43);
            this.btn_quitCorrection.TabIndex = 36;
            this.btn_quitCorrection.Text = "Quitter la correction";
            this.btn_quitCorrection.UseVisualStyleBackColor = true;
            this.btn_quitCorrection.Click += new System.EventHandler(this.btn_quitCorrection_Click);
            // 
            // FormCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 677);
            this.Controls.Add(this.btn_quitCorrection);
            this.Controls.Add(this.gb_correctionTV);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.gb_correctionSBS);
            this.Name = "FormCorrection";
            this.Text = "Vos corrections";
            this.gb_correctionSBS.ResumeLayout(false);
            this.gb_correctionSBS.PerformLayout();
            this.gb_correctionTV.ResumeLayout(false);
            this.gb_correctionTV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_correctionSBS;
        private System.Windows.Forms.Label lbl_descriptionSBS;
        private System.Windows.Forms.Label lbl_cheminFinal;
        private System.Windows.Forms.TextBox tb_infosOuverts;
        private System.Windows.Forms.TextBox tb_infosFermes;
        private System.Windows.Forms.ListBox listBox_O_correction;
        private System.Windows.Forms.ListBox listBox_cheminFinal;
        private System.Windows.Forms.ListBox listBox_F_correction;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_detailsOuverts;
        private System.Windows.Forms.Label lbl_detailsFermes;
        private System.Windows.Forms.GroupBox gb_correctionTV;
        private System.Windows.Forms.TreeView tv_correctionTV;
        private System.Windows.Forms.Label lbl_resultatTV;
        private System.Windows.Forms.Button btn_quitCorrection;
    }
}