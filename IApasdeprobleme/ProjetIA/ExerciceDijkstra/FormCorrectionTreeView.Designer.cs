namespace ExerciceDijkstra
{
    partial class FormCorrectionTreeView
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
            this.tv_corrigéComparaison = new System.Windows.Forms.TreeView();
            this.lbl_titreArbreCorrigé = new System.Windows.Forms.Label();
            this.btn_quitCorrection = new System.Windows.Forms.Button();
            this.lbl_titreVert = new System.Windows.Forms.Label();
            this.lbl_titreRouge = new System.Windows.Forms.Label();
            this.lbl_noeudOK = new System.Windows.Forms.Label();
            this.lbl_noeudFalse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tv_corrigéComparaison
            // 
            this.tv_corrigéComparaison.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_corrigéComparaison.Location = new System.Drawing.Point(46, 61);
            this.tv_corrigéComparaison.Name = "tv_corrigéComparaison";
            this.tv_corrigéComparaison.Size = new System.Drawing.Size(308, 369);
            this.tv_corrigéComparaison.TabIndex = 1;
            // 
            // lbl_titreArbreCorrigé
            // 
            this.lbl_titreArbreCorrigé.AutoSize = true;
            this.lbl_titreArbreCorrigé.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreArbreCorrigé.Location = new System.Drawing.Point(79, 26);
            this.lbl_titreArbreCorrigé.Name = "lbl_titreArbreCorrigé";
            this.lbl_titreArbreCorrigé.Size = new System.Drawing.Size(255, 32);
            this.lbl_titreArbreCorrigé.TabIndex = 3;
            this.lbl_titreArbreCorrigé.Text = "Arbre de correction";
            // 
            // btn_quitCorrection
            // 
            this.btn_quitCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitCorrection.Location = new System.Drawing.Point(57, 553);
            this.btn_quitCorrection.Name = "btn_quitCorrection";
            this.btn_quitCorrection.Size = new System.Drawing.Size(256, 46);
            this.btn_quitCorrection.TabIndex = 37;
            this.btn_quitCorrection.Text = "Quitter la correction";
            this.btn_quitCorrection.UseVisualStyleBackColor = true;
            this.btn_quitCorrection.Click += new System.EventHandler(this.btn_quitCorrection_Click);
            // 
            // lbl_titreVert
            // 
            this.lbl_titreVert.AutoSize = true;
            this.lbl_titreVert.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreVert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_titreVert.Location = new System.Drawing.Point(79, 443);
            this.lbl_titreVert.Name = "lbl_titreVert";
            this.lbl_titreVert.Size = new System.Drawing.Size(95, 34);
            this.lbl_titreVert.TabIndex = 38;
            this.lbl_titreVert.Text = "Noir : ";
            // 
            // lbl_titreRouge
            // 
            this.lbl_titreRouge.AutoSize = true;
            this.lbl_titreRouge.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreRouge.ForeColor = System.Drawing.Color.Red;
            this.lbl_titreRouge.Location = new System.Drawing.Point(50, 493);
            this.lbl_titreRouge.Name = "lbl_titreRouge";
            this.lbl_titreRouge.Size = new System.Drawing.Size(115, 34);
            this.lbl_titreRouge.TabIndex = 39;
            this.lbl_titreRouge.Text = "Rouge :";
            // 
            // lbl_noeudOK
            // 
            this.lbl_noeudOK.AutoSize = true;
            this.lbl_noeudOK.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noeudOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_noeudOK.Location = new System.Drawing.Point(171, 447);
            this.lbl_noeudOK.Name = "lbl_noeudOK";
            this.lbl_noeudOK.Size = new System.Drawing.Size(142, 29);
            this.lbl_noeudOK.TabIndex = 40;
            this.lbl_noeudOK.Text = "Noeud juste";
            // 
            // lbl_noeudFalse
            // 
            this.lbl_noeudFalse.AutoSize = true;
            this.lbl_noeudFalse.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noeudFalse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_noeudFalse.Location = new System.Drawing.Point(171, 497);
            this.lbl_noeudFalse.Name = "lbl_noeudFalse";
            this.lbl_noeudFalse.Size = new System.Drawing.Size(136, 29);
            this.lbl_noeudFalse.TabIndex = 41;
            this.lbl_noeudFalse.Text = "Noeud faux";
            // 
            // FormCorrectionTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 626);
            this.Controls.Add(this.lbl_noeudFalse);
            this.Controls.Add(this.lbl_noeudOK);
            this.Controls.Add(this.lbl_titreRouge);
            this.Controls.Add(this.lbl_titreVert);
            this.Controls.Add(this.btn_quitCorrection);
            this.Controls.Add(this.lbl_titreArbreCorrigé);
            this.Controls.Add(this.tv_corrigéComparaison);
            this.Name = "FormCorrectionTreeView";
            this.Text = "Correction TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView tv_corrigéComparaison;
        private System.Windows.Forms.Label lbl_titreArbreCorrigé;
        private System.Windows.Forms.Button btn_quitCorrection;
        private System.Windows.Forms.Label lbl_titreVert;
        private System.Windows.Forms.Label lbl_titreRouge;
        private System.Windows.Forms.Label lbl_noeudOK;
        private System.Windows.Forms.Label lbl_noeudFalse;
    }
}