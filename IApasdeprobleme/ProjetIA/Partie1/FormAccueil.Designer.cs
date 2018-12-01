namespace Partie1
{
    partial class FormAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_explication1 = new System.Windows.Forms.Label();
            this.lbl_demandeChoix = new System.Windows.Forms.Label();
            this.btn_QCM = new System.Windows.Forms.Button();
            this.btn_Dijkstra = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.Font = new System.Drawing.Font("Roboto Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_titre.Location = new System.Drawing.Point(44, 5);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(615, 106);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "IApasdeproblème";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_explication1
            // 
            this.lbl_explication1.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_explication1.Location = new System.Drawing.Point(57, 113);
            this.lbl_explication1.Name = "lbl_explication1";
            this.lbl_explication1.Size = new System.Drawing.Size(589, 79);
            this.lbl_explication1.TabIndex = 1;
            this.lbl_explication1.Text = "Venez tester vos connaissances en Intelligence Artificielle de manière ludique ! " +
    "";
            this.lbl_explication1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_demandeChoix
            // 
            this.lbl_demandeChoix.AutoSize = true;
            this.lbl_demandeChoix.Font = new System.Drawing.Font("Roboto Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_demandeChoix.Location = new System.Drawing.Point(51, 431);
            this.lbl_demandeChoix.Name = "lbl_demandeChoix";
            this.lbl_demandeChoix.Size = new System.Drawing.Size(591, 35);
            this.lbl_demandeChoix.TabIndex = 2;
            this.lbl_demandeChoix.Text = "Choisissez le sujet que vous souhaitez travailler : ";
            // 
            // btn_QCM
            // 
            this.btn_QCM.Font = new System.Drawing.Font("Roboto Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QCM.Location = new System.Drawing.Point(48, 478);
            this.btn_QCM.Name = "btn_QCM";
            this.btn_QCM.Size = new System.Drawing.Size(223, 86);
            this.btn_QCM.TabIndex = 5;
            this.btn_QCM.Text = "QCM";
            this.btn_QCM.UseVisualStyleBackColor = true;
            this.btn_QCM.Click += new System.EventHandler(this.btn_QCM_Click);
            // 
            // btn_Dijkstra
            // 
            this.btn_Dijkstra.Font = new System.Drawing.Font("Roboto Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dijkstra.Location = new System.Drawing.Point(406, 478);
            this.btn_Dijkstra.Name = "btn_Dijkstra";
            this.btn_Dijkstra.Size = new System.Drawing.Size(223, 86);
            this.btn_Dijkstra.TabIndex = 6;
            this.btn_Dijkstra.Text = "Dijkstra";
            this.btn_Dijkstra.UseVisualStyleBackColor = true;
            this.btn_Dijkstra.Click += new System.EventHandler(this.btn_Dijkstra_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(276, 586);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(124, 45);
            this.btn_Quit.TabIndex = 7;
            this.btn_Quit.Text = "Quitter";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(703, 637);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Dijkstra);
            this.Controls.Add(this.btn_QCM);
            this.Controls.Add(this.lbl_demandeChoix);
            this.Controls.Add(this.lbl_explication1);
            this.Controls.Add(this.lbl_titre);
            this.Name = "FormAccueil";
            this.Text = "Tester vos connaissances en Intelligence Artificielle !";
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_explication1;
        private System.Windows.Forms.Label lbl_demandeChoix;
        private System.Windows.Forms.Button btn_QCM;
        private System.Windows.Forms.Button btn_Dijkstra;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

