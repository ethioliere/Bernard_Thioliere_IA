namespace Partie1
{
    partial class FormResultats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultats));
            this.lbl_voici = new System.Windows.Forms.Label();
            this.btn_retour = new System.Windows.Forms.Button();
            this.lbl_score = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_voici
            // 
            this.lbl_voici.AutoSize = true;
            this.lbl_voici.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_voici.Location = new System.Drawing.Point(113, 44);
            this.lbl_voici.Name = "lbl_voici";
            this.lbl_voici.Size = new System.Drawing.Size(261, 38);
            this.lbl_voici.TabIndex = 0;
            this.lbl_voici.Text = "Voici votre score :";
            // 
            // btn_retour
            // 
            this.btn_retour.Font = new System.Drawing.Font("Roboto Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retour.Location = new System.Drawing.Point(120, 356);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(245, 46);
            this.btn_retour.TabIndex = 2;
            this.btn_retour.Text = "Retourner au menu";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(221, 93);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(35, 38);
            this.lbl_score.TabIndex = 3;
            this.lbl_score.Text = "X";
            this.lbl_score.Click += new System.EventHandler(this.lbl_score_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormResultats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.lbl_voici);
            this.Name = "FormResultats";
            this.Text = "Résultats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_voici;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}