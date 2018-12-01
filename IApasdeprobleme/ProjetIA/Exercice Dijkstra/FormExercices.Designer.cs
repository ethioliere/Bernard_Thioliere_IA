namespace ExerciceDijkstra
{
    partial class FormExercices
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
            this.lbl_enonce = new System.Windows.Forms.Label();
            this.lbl_etapesSBS = new System.Windows.Forms.Label();
            this.tb_propositionOuverts = new System.Windows.Forms.TextBox();
            this.lbl_finOuvertSBS = new System.Windows.Forms.Label();
            this.listBox_fermes = new System.Windows.Forms.ListBox();
            this.listBox_ouverts = new System.Windows.Forms.ListBox();
            this.lbl_titreFermes = new System.Windows.Forms.Label();
            this.lbl_titreOuverts = new System.Windows.Forms.Label();
            this.btn_nextStepSBS = new System.Windows.Forms.Button();
            this.btn_correctionSBS = new System.Windows.Forms.Button();
            this.gb_exoSBS = new System.Windows.Forms.GroupBox();
            this.btn_clearSBS = new System.Windows.Forms.Button();
            this.btn_annulerLastStepSBS = new System.Windows.Forms.Button();
            this.tb_propositionsFermes = new System.Windows.Forms.TextBox();
            this.lbl_debutFerme = new System.Windows.Forms.Label();
            this.lbl_debutOuvertSBS = new System.Windows.Forms.Label();
            this.lbl_finFerme = new System.Windows.Forms.Label();
            this.btn_StepByStep = new System.Windows.Forms.Button();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.btn_graphe3 = new System.Windows.Forms.Button();
            this.tb_noeudDepart = new System.Windows.Forms.TextBox();
            this.btn_graphe2 = new System.Windows.Forms.Button();
            this.tb_noeudArrivee = new System.Windows.Forms.TextBox();
            this.lbl_choixGraphe = new System.Windows.Forms.Label();
            this.btn_graphe1 = new System.Windows.Forms.Button();
            this.lbl_titreNodeDepart = new System.Windows.Forms.Label();
            this.listBox_affichageGraphe = new System.Windows.Forms.ListBox();
            this.lbl_titreNodeArrivee = new System.Windows.Forms.Label();
            this.gb_demarrage = new System.Windows.Forms.GroupBox();
            this.picb_graphe = new System.Windows.Forms.PictureBox();
            this.btn_CompleterTree = new System.Windows.Forms.Button();
            this.gb_exoTV = new System.Windows.Forms.GroupBox();
            this.btn_validerTV = new System.Windows.Forms.Button();
            this.tb_editNodeTV = new System.Windows.Forms.TextBox();
            this.btn_correctionTV = new System.Windows.Forms.Button();
            this.tv_aRemplirTV = new System.Windows.Forms.TreeView();
            this.btn_consignesSBS = new System.Windows.Forms.Button();
            this.lbl_infosTV = new System.Windows.Forms.Label();
            this.btn_consignesTV = new System.Windows.Forms.Button();
            this.lbl_titreTV = new System.Windows.Forms.Label();
            this.gb_exoSBS.SuspendLayout();
            this.gb_demarrage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_graphe)).BeginInit();
            this.gb_exoTV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_enonce
            // 
            this.lbl_enonce.AutoSize = true;
            this.lbl_enonce.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enonce.Location = new System.Drawing.Point(381, 75);
            this.lbl_enonce.Name = "lbl_enonce";
            this.lbl_enonce.Size = new System.Drawing.Size(699, 58);
            this.lbl_enonce.TabIndex = 11;
            this.lbl_enonce.Text = "Faites tourner MANUELLEMENT l\'algorithme de Dijkstra.\r\nObjectif ? Trouver le chem" +
    "in le plus court entre les deux noeuds !";
            this.lbl_enonce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_etapesSBS
            // 
            this.lbl_etapesSBS.AutoSize = true;
            this.lbl_etapesSBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etapesSBS.Location = new System.Drawing.Point(45, 92);
            this.lbl_etapesSBS.Name = "lbl_etapesSBS";
            this.lbl_etapesSBS.Size = new System.Drawing.Size(231, 48);
            this.lbl_etapesSBS.TabIndex = 14;
            this.lbl_etapesSBS.Text = "Entrez vos réponses pour \r\nl\'étape suivante :";
            this.lbl_etapesSBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_etapesSBS.Visible = false;
            // 
            // tb_propositionOuverts
            // 
            this.tb_propositionOuverts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_propositionOuverts.Location = new System.Drawing.Point(97, 200);
            this.tb_propositionOuverts.Name = "tb_propositionOuverts";
            this.tb_propositionOuverts.Size = new System.Drawing.Size(125, 28);
            this.tb_propositionOuverts.TabIndex = 18;
            this.tb_propositionOuverts.Visible = false;
            // 
            // lbl_finOuvertSBS
            // 
            this.lbl_finOuvertSBS.AutoSize = true;
            this.lbl_finOuvertSBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finOuvertSBS.Location = new System.Drawing.Point(228, 200);
            this.lbl_finOuvertSBS.Name = "lbl_finOuvertSBS";
            this.lbl_finOuvertSBS.Size = new System.Drawing.Size(16, 24);
            this.lbl_finOuvertSBS.TabIndex = 20;
            this.lbl_finOuvertSBS.Text = "}";
            this.lbl_finOuvertSBS.Visible = false;
            // 
            // listBox_fermes
            // 
            this.listBox_fermes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_fermes.FormattingEnabled = true;
            this.listBox_fermes.ItemHeight = 20;
            this.listBox_fermes.Location = new System.Drawing.Point(342, 59);
            this.listBox_fermes.Name = "listBox_fermes";
            this.listBox_fermes.Size = new System.Drawing.Size(218, 284);
            this.listBox_fermes.TabIndex = 21;
            this.listBox_fermes.Visible = false;
            // 
            // listBox_ouverts
            // 
            this.listBox_ouverts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_ouverts.FormattingEnabled = true;
            this.listBox_ouverts.ItemHeight = 20;
            this.listBox_ouverts.Location = new System.Drawing.Point(590, 59);
            this.listBox_ouverts.Name = "listBox_ouverts";
            this.listBox_ouverts.Size = new System.Drawing.Size(187, 284);
            this.listBox_ouverts.TabIndex = 22;
            this.listBox_ouverts.Visible = false;
            // 
            // lbl_titreFermes
            // 
            this.lbl_titreFermes.AutoSize = true;
            this.lbl_titreFermes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreFermes.Location = new System.Drawing.Point(399, 28);
            this.lbl_titreFermes.Name = "lbl_titreFermes";
            this.lbl_titreFermes.Size = new System.Drawing.Size(75, 24);
            this.lbl_titreFermes.TabIndex = 23;
            this.lbl_titreFermes.Text = "Fermés";
            this.lbl_titreFermes.Visible = false;
            // 
            // lbl_titreOuverts
            // 
            this.lbl_titreOuverts.AutoSize = true;
            this.lbl_titreOuverts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreOuverts.Location = new System.Drawing.Point(647, 28);
            this.lbl_titreOuverts.Name = "lbl_titreOuverts";
            this.lbl_titreOuverts.Size = new System.Drawing.Size(75, 24);
            this.lbl_titreOuverts.TabIndex = 24;
            this.lbl_titreOuverts.Text = "Ouverts";
            this.lbl_titreOuverts.Visible = false;
            // 
            // btn_nextStepSBS
            // 
            this.btn_nextStepSBS.BackColor = System.Drawing.Color.LightGreen;
            this.btn_nextStepSBS.Location = new System.Drawing.Point(33, 246);
            this.btn_nextStepSBS.Name = "btn_nextStepSBS";
            this.btn_nextStepSBS.Size = new System.Drawing.Size(240, 42);
            this.btn_nextStepSBS.TabIndex = 25;
            this.btn_nextStepSBS.Text = "Etape Suivante";
            this.btn_nextStepSBS.UseVisualStyleBackColor = false;
            this.btn_nextStepSBS.Visible = false;
            this.btn_nextStepSBS.Click += new System.EventHandler(this.btn_nextStep_Click);
            // 
            // btn_correctionSBS
            // 
            this.btn_correctionSBS.BackColor = System.Drawing.Color.LightBlue;
            this.btn_correctionSBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_correctionSBS.Location = new System.Drawing.Point(446, 355);
            this.btn_correctionSBS.Name = "btn_correctionSBS";
            this.btn_correctionSBS.Size = new System.Drawing.Size(256, 42);
            this.btn_correctionSBS.TabIndex = 26;
            this.btn_correctionSBS.Text = "Voir la correction";
            this.btn_correctionSBS.UseVisualStyleBackColor = false;
            this.btn_correctionSBS.Visible = false;
            this.btn_correctionSBS.Click += new System.EventHandler(this.btn_correction_Click);
            // 
            // gb_exoSBS
            // 
            this.gb_exoSBS.Controls.Add(this.btn_consignesSBS);
            this.gb_exoSBS.Controls.Add(this.btn_clearSBS);
            this.gb_exoSBS.Controls.Add(this.btn_annulerLastStepSBS);
            this.gb_exoSBS.Controls.Add(this.tb_propositionOuverts);
            this.gb_exoSBS.Controls.Add(this.tb_propositionsFermes);
            this.gb_exoSBS.Controls.Add(this.lbl_debutFerme);
            this.gb_exoSBS.Controls.Add(this.lbl_etapesSBS);
            this.gb_exoSBS.Controls.Add(this.lbl_titreOuverts);
            this.gb_exoSBS.Controls.Add(this.btn_correctionSBS);
            this.gb_exoSBS.Controls.Add(this.lbl_debutOuvertSBS);
            this.gb_exoSBS.Controls.Add(this.lbl_titreFermes);
            this.gb_exoSBS.Controls.Add(this.listBox_ouverts);
            this.gb_exoSBS.Controls.Add(this.listBox_fermes);
            this.gb_exoSBS.Controls.Add(this.lbl_finFerme);
            this.gb_exoSBS.Controls.Add(this.btn_nextStepSBS);
            this.gb_exoSBS.Controls.Add(this.lbl_finOuvertSBS);
            this.gb_exoSBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_exoSBS.Location = new System.Drawing.Point(31, 400);
            this.gb_exoSBS.Name = "gb_exoSBS";
            this.gb_exoSBS.Size = new System.Drawing.Size(791, 410);
            this.gb_exoSBS.TabIndex = 31;
            this.gb_exoSBS.TabStop = false;
            this.gb_exoSBS.Text = "A vous de jouer";
            this.gb_exoSBS.Visible = false;
            // 
            // btn_clearSBS
            // 
            this.btn_clearSBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearSBS.Location = new System.Drawing.Point(33, 355);
            this.btn_clearSBS.Name = "btn_clearSBS";
            this.btn_clearSBS.Size = new System.Drawing.Size(240, 42);
            this.btn_clearSBS.TabIndex = 28;
            this.btn_clearSBS.Text = "Tout recommencer";
            this.btn_clearSBS.UseVisualStyleBackColor = true;
            this.btn_clearSBS.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_annulerLastStepSBS
            // 
            this.btn_annulerLastStepSBS.BackColor = System.Drawing.Color.LightCoral;
            this.btn_annulerLastStepSBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annulerLastStepSBS.Location = new System.Drawing.Point(33, 294);
            this.btn_annulerLastStepSBS.Name = "btn_annulerLastStepSBS";
            this.btn_annulerLastStepSBS.Size = new System.Drawing.Size(240, 49);
            this.btn_annulerLastStepSBS.TabIndex = 27;
            this.btn_annulerLastStepSBS.Text = "Annuler la dernière étape";
            this.btn_annulerLastStepSBS.UseVisualStyleBackColor = false;
            this.btn_annulerLastStepSBS.Click += new System.EventHandler(this.btn_AnnulerLastStep_Click);
            // 
            // tb_propositionsFermes
            // 
            this.tb_propositionsFermes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_propositionsFermes.Location = new System.Drawing.Point(97, 151);
            this.tb_propositionsFermes.Name = "tb_propositionsFermes";
            this.tb_propositionsFermes.Size = new System.Drawing.Size(125, 28);
            this.tb_propositionsFermes.TabIndex = 15;
            this.tb_propositionsFermes.Visible = false;
            // 
            // lbl_debutFerme
            // 
            this.lbl_debutFerme.AutoSize = true;
            this.lbl_debutFerme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_debutFerme.Location = new System.Drawing.Point(48, 151);
            this.lbl_debutFerme.Name = "lbl_debutFerme";
            this.lbl_debutFerme.Size = new System.Drawing.Size(44, 24);
            this.lbl_debutFerme.TabIndex = 16;
            this.lbl_debutFerme.Text = "F ={";
            this.lbl_debutFerme.Visible = false;
            // 
            // lbl_debutOuvertSBS
            // 
            this.lbl_debutOuvertSBS.AutoSize = true;
            this.lbl_debutOuvertSBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_debutOuvertSBS.Location = new System.Drawing.Point(45, 203);
            this.lbl_debutOuvertSBS.Name = "lbl_debutOuvertSBS";
            this.lbl_debutOuvertSBS.Size = new System.Drawing.Size(47, 24);
            this.lbl_debutOuvertSBS.TabIndex = 17;
            this.lbl_debutOuvertSBS.Text = "O ={";
            this.lbl_debutOuvertSBS.Visible = false;
            // 
            // lbl_finFerme
            // 
            this.lbl_finFerme.AutoSize = true;
            this.lbl_finFerme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finFerme.Location = new System.Drawing.Point(228, 151);
            this.lbl_finFerme.Name = "lbl_finFerme";
            this.lbl_finFerme.Size = new System.Drawing.Size(16, 24);
            this.lbl_finFerme.TabIndex = 19;
            this.lbl_finFerme.Text = "}";
            this.lbl_finFerme.Visible = false;
            // 
            // btn_StepByStep
            // 
            this.btn_StepByStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StepByStep.Location = new System.Drawing.Point(269, 531);
            this.btn_StepByStep.Name = "btn_StepByStep";
            this.btn_StepByStep.Size = new System.Drawing.Size(205, 117);
            this.btn_StepByStep.TabIndex = 27;
            this.btn_StepByStep.Text = "Compléter les Fermes/Ouverts";
            this.btn_StepByStep.UseVisualStyleBackColor = true;
            this.btn_StepByStep.Visible = false;
            this.btn_StepByStep.Click += new System.EventHandler(this.btn_StepByStep_Click);
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Roboto", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.Navy;
            this.lbl_titre.Location = new System.Drawing.Point(601, 25);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(273, 29);
            this.lbl_titre.TabIndex = 33;
            this.lbl_titre.Text = "Algorithme de Dijkstra";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_graphe3
            // 
            this.btn_graphe3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_graphe3.Location = new System.Drawing.Point(337, 168);
            this.btn_graphe3.Name = "btn_graphe3";
            this.btn_graphe3.Size = new System.Drawing.Size(106, 35);
            this.btn_graphe3.TabIndex = 7;
            this.btn_graphe3.Text = "Graphe3";
            this.btn_graphe3.UseVisualStyleBackColor = true;
            // 
            // tb_noeudDepart
            // 
            this.tb_noeudDepart.Enabled = false;
            this.tb_noeudDepart.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_noeudDepart.Location = new System.Drawing.Point(71, 73);
            this.tb_noeudDepart.Name = "tb_noeudDepart";
            this.tb_noeudDepart.Size = new System.Drawing.Size(116, 29);
            this.tb_noeudDepart.TabIndex = 8;
            // 
            // btn_graphe2
            // 
            this.btn_graphe2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_graphe2.Location = new System.Drawing.Point(206, 168);
            this.btn_graphe2.Name = "btn_graphe2";
            this.btn_graphe2.Size = new System.Drawing.Size(113, 35);
            this.btn_graphe2.TabIndex = 6;
            this.btn_graphe2.Text = "Graphe2";
            this.btn_graphe2.UseVisualStyleBackColor = true;
            this.btn_graphe2.Click += new System.EventHandler(this.btn_graphe2_Click);
            // 
            // tb_noeudArrivee
            // 
            this.tb_noeudArrivee.Enabled = false;
            this.tb_noeudArrivee.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_noeudArrivee.Location = new System.Drawing.Point(273, 73);
            this.tb_noeudArrivee.Name = "tb_noeudArrivee";
            this.tb_noeudArrivee.Size = new System.Drawing.Size(100, 29);
            this.tb_noeudArrivee.TabIndex = 9;
            // 
            // lbl_choixGraphe
            // 
            this.lbl_choixGraphe.AutoSize = true;
            this.lbl_choixGraphe.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choixGraphe.Location = new System.Drawing.Point(67, 129);
            this.lbl_choixGraphe.Name = "lbl_choixGraphe";
            this.lbl_choixGraphe.Size = new System.Drawing.Size(200, 23);
            this.lbl_choixGraphe.TabIndex = 5;
            this.lbl_choixGraphe.Text = "Choisissez un graphe :";
            // 
            // btn_graphe1
            // 
            this.btn_graphe1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_graphe1.Location = new System.Drawing.Point(90, 168);
            this.btn_graphe1.Name = "btn_graphe1";
            this.btn_graphe1.Size = new System.Drawing.Size(96, 35);
            this.btn_graphe1.TabIndex = 4;
            this.btn_graphe1.Text = "Graphe1";
            this.btn_graphe1.UseVisualStyleBackColor = true;
            this.btn_graphe1.Click += new System.EventHandler(this.btn_graphe1_Click);
            // 
            // lbl_titreNodeDepart
            // 
            this.lbl_titreNodeDepart.AutoSize = true;
            this.lbl_titreNodeDepart.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreNodeDepart.Location = new System.Drawing.Point(67, 42);
            this.lbl_titreNodeDepart.Name = "lbl_titreNodeDepart";
            this.lbl_titreNodeDepart.Size = new System.Drawing.Size(162, 23);
            this.lbl_titreNodeDepart.TabIndex = 12;
            this.lbl_titreNodeDepart.Text = "Noeud de Départ :";
            // 
            // listBox_affichageGraphe
            // 
            this.listBox_affichageGraphe.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_affichageGraphe.FormattingEnabled = true;
            this.listBox_affichageGraphe.ItemHeight = 20;
            this.listBox_affichageGraphe.Location = new System.Drawing.Point(515, 33);
            this.listBox_affichageGraphe.Name = "listBox_affichageGraphe";
            this.listBox_affichageGraphe.Size = new System.Drawing.Size(207, 204);
            this.listBox_affichageGraphe.TabIndex = 3;
            // 
            // lbl_titreNodeArrivee
            // 
            this.lbl_titreNodeArrivee.AutoSize = true;
            this.lbl_titreNodeArrivee.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreNodeArrivee.Location = new System.Drawing.Point(259, 42);
            this.lbl_titreNodeArrivee.Name = "lbl_titreNodeArrivee";
            this.lbl_titreNodeArrivee.Size = new System.Drawing.Size(157, 23);
            this.lbl_titreNodeArrivee.TabIndex = 13;
            this.lbl_titreNodeArrivee.Text = "Noeud d\'Arrivée  :";
            // 
            // gb_demarrage
            // 
            this.gb_demarrage.Controls.Add(this.lbl_titreNodeArrivee);
            this.gb_demarrage.Controls.Add(this.listBox_affichageGraphe);
            this.gb_demarrage.Controls.Add(this.lbl_titreNodeDepart);
            this.gb_demarrage.Controls.Add(this.btn_graphe1);
            this.gb_demarrage.Controls.Add(this.lbl_choixGraphe);
            this.gb_demarrage.Controls.Add(this.tb_noeudArrivee);
            this.gb_demarrage.Controls.Add(this.btn_graphe2);
            this.gb_demarrage.Controls.Add(this.tb_noeudDepart);
            this.gb_demarrage.Controls.Add(this.btn_graphe3);
            this.gb_demarrage.Font = new System.Drawing.Font("Roboto", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_demarrage.Location = new System.Drawing.Point(31, 136);
            this.gb_demarrage.Name = "gb_demarrage";
            this.gb_demarrage.Size = new System.Drawing.Size(791, 248);
            this.gb_demarrage.TabIndex = 30;
            this.gb_demarrage.TabStop = false;
            this.gb_demarrage.Text = "Démarrage";
            // 
            // picb_graphe
            // 
            this.picb_graphe.Location = new System.Drawing.Point(842, 146);
            this.picb_graphe.Name = "picb_graphe";
            this.picb_graphe.Size = new System.Drawing.Size(605, 238);
            this.picb_graphe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_graphe.TabIndex = 34;
            this.picb_graphe.TabStop = false;
            // 
            // btn_CompleterTree
            // 
            this.btn_CompleterTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CompleterTree.Location = new System.Drawing.Point(1053, 531);
            this.btn_CompleterTree.Name = "btn_CompleterTree";
            this.btn_CompleterTree.Size = new System.Drawing.Size(205, 117);
            this.btn_CompleterTree.TabIndex = 28;
            this.btn_CompleterTree.Text = "Compléter l\'arbre";
            this.btn_CompleterTree.UseVisualStyleBackColor = true;
            this.btn_CompleterTree.Visible = false;
            this.btn_CompleterTree.Click += new System.EventHandler(this.btn_CompleterTree_Click);
            // 
            // gb_exoTV
            // 
            this.gb_exoTV.Controls.Add(this.lbl_titreTV);
            this.gb_exoTV.Controls.Add(this.btn_consignesTV);
            this.gb_exoTV.Controls.Add(this.lbl_infosTV);
            this.gb_exoTV.Controls.Add(this.btn_validerTV);
            this.gb_exoTV.Controls.Add(this.tb_editNodeTV);
            this.gb_exoTV.Controls.Add(this.btn_correctionTV);
            this.gb_exoTV.Controls.Add(this.tv_aRemplirTV);
            this.gb_exoTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_exoTV.Location = new System.Drawing.Point(842, 400);
            this.gb_exoTV.Name = "gb_exoTV";
            this.gb_exoTV.Size = new System.Drawing.Size(605, 410);
            this.gb_exoTV.TabIndex = 36;
            this.gb_exoTV.TabStop = false;
            this.gb_exoTV.Text = "A vous de jouer";
            this.gb_exoTV.Visible = false;
            // 
            // btn_validerTV
            // 
            this.btn_validerTV.BackColor = System.Drawing.Color.LightGreen;
            this.btn_validerTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validerTV.Location = new System.Drawing.Point(77, 265);
            this.btn_validerTV.Name = "btn_validerTV";
            this.btn_validerTV.Size = new System.Drawing.Size(110, 32);
            this.btn_validerTV.TabIndex = 3;
            this.btn_validerTV.Text = "Valider";
            this.btn_validerTV.UseVisualStyleBackColor = false;
            this.btn_validerTV.Click += new System.EventHandler(this.btn_validerTV_Click);
            // 
            // tb_editNodeTV
            // 
            this.tb_editNodeTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_editNodeTV.Location = new System.Drawing.Point(53, 220);
            this.tb_editNodeTV.Name = "tb_editNodeTV";
            this.tb_editNodeTV.Size = new System.Drawing.Size(161, 28);
            this.tb_editNodeTV.TabIndex = 2;
            // 
            // btn_correctionTV
            // 
            this.btn_correctionTV.BackColor = System.Drawing.Color.LightBlue;
            this.btn_correctionTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_correctionTV.Location = new System.Drawing.Point(31, 355);
            this.btn_correctionTV.Name = "btn_correctionTV";
            this.btn_correctionTV.Size = new System.Drawing.Size(256, 42);
            this.btn_correctionTV.TabIndex = 1;
            this.btn_correctionTV.Text = "Voir la correction";
            this.btn_correctionTV.UseVisualStyleBackColor = false;
            this.btn_correctionTV.Click += new System.EventHandler(this.btn_correctionTV_Click);
            // 
            // tv_aRemplirTV
            // 
            this.tv_aRemplirTV.Location = new System.Drawing.Point(307, 92);
            this.tv_aRemplirTV.Name = "tv_aRemplirTV";
            this.tv_aRemplirTV.Size = new System.Drawing.Size(283, 299);
            this.tv_aRemplirTV.TabIndex = 0;
            this.tv_aRemplirTV.Visible = false;
            // 
            // btn_consignesSBS
            // 
            this.btn_consignesSBS.BackColor = System.Drawing.Color.Moccasin;
            this.btn_consignesSBS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_consignesSBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consignesSBS.Location = new System.Drawing.Point(114, 42);
            this.btn_consignesSBS.Name = "btn_consignesSBS";
            this.btn_consignesSBS.Size = new System.Drawing.Size(130, 32);
            this.btn_consignesSBS.TabIndex = 29;
            this.btn_consignesSBS.Text = "Consignes";
            this.btn_consignesSBS.UseVisualStyleBackColor = false;
            this.btn_consignesSBS.Click += new System.EventHandler(this.btn_consignesSBS_Click);
            // 
            // lbl_infosTV
            // 
            this.lbl_infosTV.AutoSize = true;
            this.lbl_infosTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infosTV.Location = new System.Drawing.Point(27, 121);
            this.lbl_infosTV.Name = "lbl_infosTV";
            this.lbl_infosTV.Size = new System.Drawing.Size(222, 72);
            this.lbl_infosTV.TabIndex = 30;
            this.lbl_infosTV.Text = "Entrez la valeur que vous\r\nvoulez attribuer au\r\nnoeud :";
            this.lbl_infosTV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_infosTV.Visible = false;
            // 
            // btn_consignesTV
            // 
            this.btn_consignesTV.BackColor = System.Drawing.Color.Moccasin;
            this.btn_consignesTV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_consignesTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consignesTV.Location = new System.Drawing.Point(79, 59);
            this.btn_consignesTV.Name = "btn_consignesTV";
            this.btn_consignesTV.Size = new System.Drawing.Size(120, 32);
            this.btn_consignesTV.TabIndex = 30;
            this.btn_consignesTV.Text = "Consignes";
            this.btn_consignesTV.UseVisualStyleBackColor = false;
            this.btn_consignesTV.Click += new System.EventHandler(this.btn_consignesTV_Click);
            // 
            // lbl_titreTV
            // 
            this.lbl_titreTV.AutoSize = true;
            this.lbl_titreTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreTV.Location = new System.Drawing.Point(347, 42);
            this.lbl_titreTV.Name = "lbl_titreTV";
            this.lbl_titreTV.Size = new System.Drawing.Size(205, 29);
            this.lbl_titreTV.TabIndex = 30;
            this.lbl_titreTV.Text = "Arbre à compléter";
            this.lbl_titreTV.Visible = false;
            // 
            // FormExercices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 822);
            this.Controls.Add(this.gb_exoTV);
            this.Controls.Add(this.btn_CompleterTree);
            this.Controls.Add(this.picb_graphe);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.lbl_enonce);
            this.Controls.Add(this.gb_demarrage);
            this.Controls.Add(this.gb_exoSBS);
            this.Controls.Add(this.btn_StepByStep);
            this.Name = "FormExercices";
            this.Text = "Application Manuelle de Dijkstra";
            this.gb_exoSBS.ResumeLayout(false);
            this.gb_exoSBS.PerformLayout();
            this.gb_demarrage.ResumeLayout(false);
            this.gb_demarrage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_graphe)).EndInit();
            this.gb_exoTV.ResumeLayout(false);
            this.gb_exoTV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_enonce;
        private System.Windows.Forms.Label lbl_etapesSBS;
        private System.Windows.Forms.TextBox tb_propositionOuverts;
        private System.Windows.Forms.Label lbl_finOuvertSBS;
        private System.Windows.Forms.ListBox listBox_fermes;
        private System.Windows.Forms.ListBox listBox_ouverts;
        private System.Windows.Forms.Label lbl_titreFermes;
        private System.Windows.Forms.Label lbl_titreOuverts;
        private System.Windows.Forms.Button btn_nextStepSBS;
        private System.Windows.Forms.Button btn_correctionSBS;
        private System.Windows.Forms.GroupBox gb_exoSBS;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.TextBox tb_propositionsFermes;
        private System.Windows.Forms.Label lbl_debutFerme;
        private System.Windows.Forms.Label lbl_debutOuvertSBS;
        private System.Windows.Forms.Label lbl_finFerme;
        private System.Windows.Forms.Button btn_graphe3;
        private System.Windows.Forms.TextBox tb_noeudDepart;
        private System.Windows.Forms.Button btn_graphe2;
        private System.Windows.Forms.TextBox tb_noeudArrivee;
        private System.Windows.Forms.Label lbl_choixGraphe;
        private System.Windows.Forms.Button btn_graphe1;
        private System.Windows.Forms.Label lbl_titreNodeDepart;
        private System.Windows.Forms.ListBox listBox_affichageGraphe;
        private System.Windows.Forms.Label lbl_titreNodeArrivee;
        private System.Windows.Forms.GroupBox gb_demarrage;
        private System.Windows.Forms.PictureBox picb_graphe;
        private System.Windows.Forms.Button btn_StepByStep;
        private System.Windows.Forms.Button btn_CompleterTree;
        private System.Windows.Forms.GroupBox gb_exoTV;
        private System.Windows.Forms.TreeView tv_aRemplirTV;
        private System.Windows.Forms.Button btn_correctionTV;
        private System.Windows.Forms.Button btn_clearSBS;
        private System.Windows.Forms.Button btn_annulerLastStepSBS;
        private System.Windows.Forms.TextBox tb_editNodeTV;
        private System.Windows.Forms.Button btn_validerTV;
        private System.Windows.Forms.Button btn_consignesSBS;
        private System.Windows.Forms.Label lbl_titreTV;
        private System.Windows.Forms.Button btn_consignesTV;
        private System.Windows.Forms.Label lbl_infosTV;
    }
}

