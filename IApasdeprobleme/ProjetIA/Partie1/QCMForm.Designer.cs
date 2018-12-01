namespace Partie1
{
    partial class QCMForm
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
            this.txt_Questions = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_question = new System.Windows.Forms.Label();
            this.btn_repA = new System.Windows.Forms.Button();
            this.btn_repB = new System.Windows.Forms.Button();
            this.btn_repC = new System.Windows.Forms.Button();
            this.btn_repD = new System.Windows.Forms.Button();
            this.lbl_numQuestion = new System.Windows.Forms.Label();
            this.txt_annonceScore = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_abandon = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Questions
            // 
            this.txt_Questions.Enabled = false;
            this.txt_Questions.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Questions.Location = new System.Drawing.Point(81, 114);
            this.txt_Questions.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Questions.Multiline = true;
            this.txt_Questions.Name = "txt_Questions";
            this.txt_Questions.Size = new System.Drawing.Size(547, 88);
            this.txt_Questions.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question.Location = new System.Drawing.Point(177, 37);
            this.lbl_question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(220, 48);
            this.lbl_question.TabIndex = 3;
            this.lbl_question.Text = "Question N°";
            // 
            // btn_repA
            // 
            this.btn_repA.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repA.Location = new System.Drawing.Point(81, 223);
            this.btn_repA.Margin = new System.Windows.Forms.Padding(4);
            this.btn_repA.Name = "btn_repA";
            this.btn_repA.Size = new System.Drawing.Size(548, 57);
            this.btn_repA.TabIndex = 4;
            this.btn_repA.Text = "Réponse A";
            this.btn_repA.UseVisualStyleBackColor = true;
            this.btn_repA.Click += new System.EventHandler(this.btn_repA_Click);
            // 
            // btn_repB
            // 
            this.btn_repB.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repB.Location = new System.Drawing.Point(81, 304);
            this.btn_repB.Margin = new System.Windows.Forms.Padding(4);
            this.btn_repB.Name = "btn_repB";
            this.btn_repB.Size = new System.Drawing.Size(548, 57);
            this.btn_repB.TabIndex = 5;
            this.btn_repB.Text = "Réponse B";
            this.btn_repB.UseVisualStyleBackColor = true;
            this.btn_repB.Click += new System.EventHandler(this.btn_repB_Click);
            // 
            // btn_repC
            // 
            this.btn_repC.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repC.Location = new System.Drawing.Point(81, 379);
            this.btn_repC.Margin = new System.Windows.Forms.Padding(4);
            this.btn_repC.Name = "btn_repC";
            this.btn_repC.Size = new System.Drawing.Size(548, 57);
            this.btn_repC.TabIndex = 6;
            this.btn_repC.Text = "Réponse C";
            this.btn_repC.UseVisualStyleBackColor = true;
            this.btn_repC.Click += new System.EventHandler(this.btn_repC_Click);
            // 
            // btn_repD
            // 
            this.btn_repD.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repD.Location = new System.Drawing.Point(81, 455);
            this.btn_repD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_repD.Name = "btn_repD";
            this.btn_repD.Size = new System.Drawing.Size(548, 57);
            this.btn_repD.TabIndex = 7;
            this.btn_repD.Text = "Réponse D";
            this.btn_repD.UseVisualStyleBackColor = true;
            this.btn_repD.Click += new System.EventHandler(this.btn_repD_Click);
            // 
            // lbl_numQuestion
            // 
            this.lbl_numQuestion.AutoSize = true;
            this.lbl_numQuestion.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numQuestion.Location = new System.Drawing.Point(431, 39);
            this.lbl_numQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numQuestion.Name = "lbl_numQuestion";
            this.lbl_numQuestion.Size = new System.Drawing.Size(43, 48);
            this.lbl_numQuestion.TabIndex = 8;
            this.lbl_numQuestion.Text = "X";
            // 
            // txt_annonceScore
            // 
            this.txt_annonceScore.AutoSize = true;
            this.txt_annonceScore.Font = new System.Drawing.Font("Roboto Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_annonceScore.Location = new System.Drawing.Point(84, 615);
            this.txt_annonceScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_annonceScore.Name = "txt_annonceScore";
            this.txt_annonceScore.Size = new System.Drawing.Size(277, 41);
            this.txt_annonceScore.TabIndex = 9;
            this.txt_annonceScore.Text = "Votre score est de :";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Roboto Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(399, 615);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(35, 41);
            this.lbl_score.TabIndex = 10;
            this.lbl_score.Text = "0";
            // 
            // btn_abandon
            // 
            this.btn_abandon.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abandon.Location = new System.Drawing.Point(616, 624);
            this.btn_abandon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_abandon.Name = "btn_abandon";
            this.btn_abandon.Size = new System.Drawing.Size(116, 32);
            this.btn_abandon.TabIndex = 11;
            this.btn_abandon.Text = "Abandonner";
            this.btn_abandon.UseVisualStyleBackColor = true;
            this.btn_abandon.Click += new System.EventHandler(this.btn_abandon_Click);
            // 
            // btn_suivant
            // 
            this.btn_suivant.Font = new System.Drawing.Font("Roboto Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suivant.Location = new System.Drawing.Point(201, 536);
            this.btn_suivant.Margin = new System.Windows.Forms.Padding(4);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(315, 50);
            this.btn_suivant.TabIndex = 12;
            this.btn_suivant.Text = "Question Suivante";
            this.btn_suivant.UseVisualStyleBackColor = true;
            this.btn_suivant.Visible = false;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // QCMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 690);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_abandon);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.txt_annonceScore);
            this.Controls.Add(this.lbl_numQuestion);
            this.Controls.Add(this.btn_repD);
            this.Controls.Add(this.btn_repC);
            this.Controls.Add(this.btn_repB);
            this.Controls.Add(this.btn_repA);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.txt_Questions);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QCMForm";
            this.Text = "Bienvenue sur le QCM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Questions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Button btn_repA;
        private System.Windows.Forms.Button btn_repB;
        private System.Windows.Forms.Button btn_repC;
        private System.Windows.Forms.Button btn_repD;
        private System.Windows.Forms.Label lbl_numQuestion;
        private System.Windows.Forms.Label txt_annonceScore;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_abandon;
        private System.Windows.Forms.Button btn_suivant;
    }
}