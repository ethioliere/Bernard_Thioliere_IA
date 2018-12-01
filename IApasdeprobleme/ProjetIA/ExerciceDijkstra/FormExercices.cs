using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExerciceDijkstra
{
    public partial class FormExercices : Form
    {
        //--------------------------- INITIALISATION --------------------------

        static public double[,] matrice; //Matrice permettant de stocker les liens existants entre les noeuds et leur coût
        static public int nbnodes; //Nombre de noeuds total dans le graphe
        static public int numNodeInitial; //Numéro du noeud initial
        static public int numNodeFinal; //Numéro du noeud final
        static public int etape=1; //Va permettre d'afficher le numéro de l'étape
        static public int whichCorrection; // va permettre de savoir si on veut la correction de l'arbre ou de l'exercice Step By Step
                
        //Listes de stockage des réponses pour l'exercice StepByStep
        //FERMES
        List<int> etapesJustesF = new List<int>(); //Va stocker le numéro des étapes justes pour les fermes
        List<int> etapesFaussesF = new List<int>(); //Va stocker le numéro des étapes fausses pour les fermes
        //OUVERTS
        List<int> etapesJustesO = new List<int>(); //Va stocker le numéro des étapes justes pour les ouverts
        List<int> etapesFaussesO = new List<int>(); //Va stocker le numéro des étapes fausses pour les ouverts

        //On va avoir des listes contenant des tableaux. Chaque tableau va correspondre à une étape.
        public List<String[]> L_EnsembleEtapesFermesJoueur = new List<String[]>();
        public List<String[]> L_EnsembleEtapesOuvertsJoueur = new List<String[]>();

        //Initialisation d'un random pour choisir les noeuds de départ et d'arrivée
        Random r = new Random();
        FormCorrectionStepByStep f = new FormCorrectionStepByStep();
        FormCorrectionTreeView fTV = new FormCorrectionTreeView();
        TreeView TV = new TreeView(); 
        SearchTree IA = new SearchTree();

        //Liste contenant les réponses de l'arbre du joueur       
        List<string> repTreeView = new List<string>();

        //--------------------- FIN INITIALISATION ------------------------------------
        

        //---------------------------- GESTION DES AFFICHAGES -----------------------

        //********* EXERCICES *********

        //Affichage de l'exercice avec les fermes et les ouverts
        public void AffichageExerciceStepByStep()
        {
            gb_exoSBS.Visible = true;
            lbl_etapesSBS.Visible = true;

            //Fermes
            lbl_titreFermes.Visible = true;
            lbl_debutFerme.Visible = true;
            tb_propositionsFermes.Visible = true;
            lbl_finFerme.Visible = true;
            listBox_fermes.Visible = true;

            //Ouverts
            lbl_titreOuverts.Visible = true;
            lbl_debutOuvertSBS.Visible = true;
            tb_propositionOuverts.Visible = true;
            lbl_finOuvertSBS.Visible = true;
            listBox_ouverts.Visible = true;

            //Boutons
            btn_nextStepSBS.Visible = true;
            btn_correctionSBS.Visible = true;
        }

        //Affichage de l'exercice avec l'arbre à compléter
        public void AffichageExerciceTree()
        {
            gb_exoTV.Visible = true;
            tv_aRemplirTV.Visible = true;
            lbl_infosTV.Visible = true;
            lbl_titreTV.Visible = true;

            AlgorithmeDijkstra();

        }

        //********* CORRECTIONS *********

        //Affichage de la correction de l'exercice StepByStep (avec les fermes et les ouverts)
        public void AfficheCorrectionStepByStep()
        {
            f.GetListBoxCheminFinal().Visible = true;
            f.GetListBoxCorrectionFermes().Visible = true;
            f.GetListBoxCorrectionOuverts().Visible = true;
            f.GetLblCheminAndCOut().Visible = true;
            f.GetLblDescription().Visible = true;
            f.GetTvCorrection().Visible = true;


        } 

       
        //********* AUTRES *********

        // Modifications dans l'exercice Step By Step après demande de correction --> Empeche certaines commandes d'être activées.
        public void DesactivactionFonctionnalites()
        {

            listBox_ouverts.Enabled = false;
            listBox_fermes.Enabled = false;
            tb_propositionsFermes.Enabled = false;
            tb_propositionOuverts.Enabled = false;
            btn_nextStepSBS.Enabled = false;
            btn_annulerLastStepSBS.Enabled = false;

        }
      

        //---------------------------- FIN GESTION DES AFFICHAGES -----------------------

        //---------------------------- CONSTRUCTEUR -----------------------

        //Constructeur par défaut
        public FormExercices()
        {
            InitializeComponent();

        }

        //---------------------------- METHODES -----------------------

        //Initialise les données nécessaires et permet la lecture des fichiers de stockage.
        public void Demarrage(string nomFichier)
        {
            listBox_affichageGraphe.Items.Clear();
            StreamReader file = new StreamReader("../../../Exercice Dijkstra/Graphes/"+nomFichier + ".txt");
            string code = file.ReadLine();
            string[] arc = code.Split(',');

            nbnodes = Convert.ToInt32(arc[arc.Length - 1]);

            matrice = new double[nbnodes, nbnodes];

            for (int j = 0; j < nbnodes; j++)
                for (int k = 0; k < nbnodes; k++)
                    matrice[j, k] = -1;

            for (int i = 0; i < arc.Length - 1; i++)
            {
                int nodeDepart = Convert.ToInt32(arc[i][0]) - 48; //N1
                int nodeArrivee = Convert.ToInt32(arc[i][1]) - 48; //N2
                int cout = Convert.ToInt32(arc[i][2]) - 48; // cout              

                matrice[nodeDepart, nodeArrivee] = cout;
                matrice[nodeArrivee, nodeDepart] = cout;
                listBox_affichageGraphe.Items.Add(Convert.ToString(nodeDepart)
                    + "--->" + Convert.ToString(nodeArrivee)
                    + "   : " + Convert.ToString(cout));

            }

            //Affichage du nombre de noeuds total dans le graphe
            listBox_affichageGraphe.Items.Add("Total de noeuds = " + nbnodes);
               
            // Fermeture du StreamReader (obligatoire) 
            file.Close();

            // Choix aléatoire des noeuds de départ et d'arrivée            
            int noeudDepart = r.Next(nbnodes);
            int noeudArrivee = r.Next(nbnodes);

            if (noeudDepart == noeudArrivee)
            { // pour éviter les cas d'égalités
                noeudArrivee = (noeudArrivee + 1) % nbnodes;
            }
            tb_noeudDepart.Text = noeudDepart.ToString();
            tb_noeudArrivee.Text = noeudArrivee.ToString();

            //On vide les listes box. 
            listBox_fermes.Items.Clear();
            listBox_ouverts.Items.Clear();

            //On écrit la première étape des ouverts et des fermés
            listBox_fermes.Items.Add("(0)   F = { } ");
            listBox_ouverts.Items.Add("(0)   O = { " + noeudDepart + " }");
                        
        }        
        
        //Algorithme permettant de trouver le plus court chemin et de l'enregistrer
        public void AlgorithmeDijkstra()
        {         
            //------- INITIALISATION --------

            //On nettoie les listes de correction
            f.ClearLbCorrectionFermes();
            f.ClearLbCorrectionOuverts();

            //On vide les étapes réalisées
            IA.L_SuiviFermes.Clear();
            IA.L_SuiviOuverts.Clear();

            //On nettoie la liste avec le chemin final et le coût
            f.GetListBoxCheminFinal().Items.Clear();

            //On ajoute l'étape de base sur la listBox de correction
            f.AjoutLbCorrectionFermes("(0)   F = { }");
            f.AjoutLbCorrectionOuverts("(0)   O = { " + tb_noeudDepart.Text + " }");
            
            //On initialise les paramètres
            numNodeInitial = Convert.ToInt32(tb_noeudDepart.Text);
            numNodeFinal = Convert.ToInt32(tb_noeudArrivee.Text);
            Node N0 = new Node();
            N0.numero = numNodeInitial;

            //------- FIN INITIALISATION --------

            //------------------------------- ALGORITHME -------------------------

            IA.Initialisation(N0);

            GenericNode N = N0; //N prend la valeur du noeud initial    
            
            List<GenericNode> solution = IA.RechercheSolution(N0, N); //Contient la solution

            //---------------------------------------------- AFFICHAGE RESULTAT FINAL ---------------------------

            //On écrit le chemin final et le cout dans une chaine de caractère qu'on pourra afficher 

            Node N1 = N0;
            string cheminFinal = "";
            double coutTotal = 0;

            for (int i = 0; i < solution.Count; i++)
            {
                Node N2 = (Node)solution[i];
                if (i == 0) { cheminFinal += (Convert.ToString(N2.numero)); }
                else { cheminFinal += (" ---> " + Convert.ToString(N2.numero)); }
                coutTotal += matrice[N1.numero, N2.numero];

                N1 = N2;
            }
            
            //Affichage du chemin final et du cout pour l'utilisateur.
            f.AjoutLbCheminFinal(cheminFinal);
            f.AjoutLbCheminFinal("Coût total : " + coutTotal);

            //Affichage étape par étape dans la correction
            string correctionFermes;
            for (int i = 1; i < this.IA.L_SuiviFermes.Count; i++)
            {                
                correctionFermes = "(" + i + ")   F = { ";
                for (int j = 1; j < IA.L_SuiviFermes[i].Length; j++)
                {
                    string noeud = IA.L_SuiviFermes[i][j];
                    correctionFermes += (noeud + " ");
                }
                correctionFermes += "}";
                f.AjoutLbCorrectionFermes(correctionFermes);
            }

            string correctionOuverts;
            for (int i = 1; i < this.IA.L_SuiviOuverts.Count; i++)
            {
                string numStep = Convert.ToString(i + 1);
                correctionOuverts = "(" + i + ")   O = { ";
                for(int j = 0; j < IA.L_SuiviOuverts[i].Length; j++) 
                {
                    if (i == 0 && j == 0) { }
                    else
                    {
                        string noeud = IA.L_SuiviOuverts[i][j];
                        correctionOuverts += (noeud + " ");
                    }
                    
                }
                correctionOuverts += "}";
                f.AjoutLbCorrectionOuverts(correctionOuverts);
            }                       


            //Permet d'afficher la correction du TreeView dans le FormCorrection
            IA.GetSearchTree(f.GetTvCorrection());
            f.GetTvCorrection().ExpandAll();
            IA.GetSearchTree(fTV.GetTvCorrige());
            fTV.GetTvCorrige().ExpandAll();
            //Permet d'afficher la structure du TreeView dans le FormExercice
            IA.GetStructureTree(tv_aRemplirTV);
            tv_aRemplirTV.ExpandAll();

        }


        public void AffichageResultatsUser()
        {
            //------------------------------------------- RESULTATS DE L'EXERCICE (pour l'utilisateur) --------------------
            f.Show(); //Affichage form de correction

            //Permet de désactiver certaines fonctionnalités après demande de correction --> On ne peut plus ajouter ou supprimer une etape.
            DesactivactionFonctionnalites();

            int nbItemsCorrectionF = Convert.ToInt32(f.GetListBoxCorrectionFermes().Items.Count - 1); //Nb de lignes de la correction pour les fermes
            int nbItemsCorrectionO = Convert.ToInt32(f.GetListBoxCorrectionOuverts().Items.Count - 1);//Nb de lignes de la correction pour les ouverts
            //Ces trois variables sont sensées être identiques puisque sinon ca affiche un message d'erreur


            //Si l'utilisateur n'a pas le bon nombre d'étapes, il n'accede pas à la correction. Un message d'erreurs s'affiche.
            //Le "whichCorrection" permet de ne pas afficher ce message si on a choisi l'exercice de l'arbre.
            if (listBox_fermes.Items.Count != f.GetListBoxCorrectionFermes().Items.Count) // Si le nb est différent là, il le sera aussi pour les ouverts.
            {

                f.GetLblInfos().Text = "FAUX ! \nNombre d'étapes incorrect. Il y a " + nbItemsCorrectionF + " étape(s). \nRecommencez";

            }
            else
            {
                f.GetLblInfos().Text = "BRAVO ! :D \nVous avez le bon nombre d'étapes !";

            }
        }
        

        //---------------------------- METHODES DE VERIFICATION -----------------------

        //Permet de tester si la chaine de caractère est un nombre
        public bool IsNumeric(string Nombre)
        {
            try
            {
                int.Parse(Nombre);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Test la saisie des box Fermes et Ouverts dans l'exercice StepByStep. Renvoi false si c'est mal saisie.
        private bool TestSaisieExerciceSBS() 
        {
            
            //On vérfie si l'un des deux champs est vide
            if (tb_propositionsFermes.Text.Length == 0) { return false; }
                        

            //On met les différents éléments dans un tableau.
            string[] AllPropFermes = tb_propositionsFermes.Text.Split(' ');
            string[] AllPropOuverts = tb_propositionOuverts.Text.Split(' ');

            //On regarde la taille des éléments  
            foreach (string saisie in AllPropFermes)
            {                
                if (!IsNumeric(saisie)) { return false; }
                
            }
            if (tb_propositionOuverts.Text.Length != 0)
            {
                foreach (string saisie in AllPropOuverts)
                {                    
                    if (!IsNumeric(saisie)) { return false; }
                }
            }

            return true;
        }

        //Test la saisie pour la valeur du noeud sélectionné. Renvoi false si c'est mal saisie.
        private bool TestSaisieExerciceTV()
        {
            //On vérfie que la longueur vaut 1
            if (tb_editNodeTV.Text.Length == 0 || tb_editNodeTV.Text.Length > 1) { return false; }
                     
            //On vérifie que la saisie est numérique.            
           if (!IsNumeric(tb_editNodeTV.Text)) { return false; }
          
            return true;

        }

        private string[] TriTableauOrdreCroissant(string[]tab)
        {
            IEnumerable<string> query = from noeud in tab
                                        orderby noeud.Substring(0, 1)
                                        select noeud;
            int i = 0;
            foreach (string str in query)
            {
                tab[i] = str;
                i++;
            }

            return tab;
                
        }

        private void CompareJoueurAndCorrectionFermes(List<string[]> reponsesJoueur, List<string[]> correction, int nbReponsesJustes)
        {
            bool idem = false;            

            //On compare le tableau correspondant à l'étape pour voir si les noeuds sont identiques
            //On prend le dernier tableau ajouté par le joueur.
            int i = reponsesJoueur.Count - 1;

            if (reponsesJoueur[i].Length != correction[i].Length) //Cas où le nombre de noeuds dans l'étape i n'est pas égal
            {
                //Affichage pour le joueur
                lbl_resultEtapeF.Text = "Etape Fausse !";
                lbl_resultEtapeF.BackColor = Color.Red;
                    
            }
            else // Cas où le nombre de noeuds dans l'étape i est égal
            {
                //On tri les tableaux par ordre croissant, afin que l'ordre de saisie n'influe pas.
                reponsesJoueur[i] = TriTableauOrdreCroissant(reponsesJoueur[i]);
                correction[i] = TriTableauOrdreCroissant(correction[i]);

                //On parcourt le tableau pour comparer noeuds par noeuds. Ils sont triés par ordre croissant donc pas de problème.
                for (int j = 0; j < reponsesJoueur[i].Length; j++)
                {
                    if (reponsesJoueur[i][j] == correction[i][j]) //On compare chaque noeud un à un
                    {                                
                        idem = true;
                    }
                    else
                    {
                        lbl_resultEtapeF.Text = "Etape Fausse !";
                        lbl_resultEtapeF.BackColor = Color.Red;
                        idem = false;
                                
                    }

                }
                if (idem)
                {
                    lbl_resultEtapeF.Text = "Etape Juste !";
                    lbl_resultEtapeF.BackColor = Color.Green;
                    nbReponsesJustes++;
                }

            }

            f.GetLblScoreFermes().Text = nbReponsesJustes + " / " + f.GetListBoxCorrectionFermes().Items.Count;

        }

        private void CompareJoueurAndCorrectionOuverts(List<string[]> reponsesJoueur, List<string[]> correction, int nbReponsesJustes)
        {
            bool idem = false;
            
            
            //On compare le tableau correspondant à l'étape pour voir si les noeuds sont identiques
            //On prend le dernier tableau ajouté par le joueur.
            int i = reponsesJoueur.Count - 1;
            

            if (reponsesJoueur[i].Length != correction[i+1].Length) //Cas où le nombre de noeuds dans l'étape i n'est pas égal
            {
                //Dans la condition on enlève un car 
                //Affichage pour le joueur
                lbl_resultEtapeO.Text = "Etape Fausse !";
                lbl_resultEtapeO.BackColor = Color.Red;

            }
            else // Cas où le nombre de noeuds dans l'étape i est égal
            {
                //On tri les tableaux par ordre croissant, afin que l'ordre de saisie n'influe pas.
                reponsesJoueur[i] = TriTableauOrdreCroissant(reponsesJoueur[i]);
                correction[i+1] = TriTableauOrdreCroissant(correction[i+1]);

                //On parcourt le tableau pour comparer noeuds par noeuds. Ils sont triés par ordre croissant donc pas de problème.
                for (int j = 0; j < reponsesJoueur[i].Length; j++)
                {
                    if (reponsesJoueur[i][j] == correction[i+1][j]) //On compare chaque noeud un à un
                    {
                        idem = true;
                    }
                    else
                    {
                        lbl_resultEtapeO.Text = "Etape Fausse !";
                        lbl_resultEtapeO.BackColor = Color.Red;
                        idem = false;
                    }

                }
                if (idem)
                {
                    lbl_resultEtapeO.Text = "Etape Juste !";
                    lbl_resultEtapeO.BackColor = Color.Green;
                    nbReponsesJustes++;
                }
            }

            f.GetLblScoreOuverts().Text = nbReponsesJustes + " / " + f.GetListBoxCorrectionFermes().Items.Count;
            
        }

        //---------------------------- FIN METHOES -----------------------


        //--------------------------------------------- BOUTONS (Action) ----------------------------------

        // --------------------- MENU DE DEMARRAGE ------------------------------

        private void btn_graphe1_Click(object sender, EventArgs e)
        {
            f.GetListBoxCheminFinal().Items.Clear();
            string nomFichier = btn_graphe1.Text;
            Demarrage(nomFichier);
            picb_graphe.ImageLocation = "../../../Exercice Dijkstra/ImageGraphe/" + nomFichier + ".png";
            btn_StepByStep.Visible = true;
            btn_CompleterTree.Visible = true;
            
        }

        private void btn_graphe2_Click(object sender, EventArgs e)
        {
            f.GetListBoxCheminFinal().Items.Clear();
            string nomFichier = btn_graphe2.Text;
            Demarrage(nomFichier);
            picb_graphe.ImageLocation = "../../../Exercice Dijkstra/ImageGraphe/" + nomFichier + ".png";
            btn_StepByStep.Visible = true;
            btn_CompleterTree.Visible = true;

        }


        //--------------------- EXERCICE STEP BY STEP ------------------------------
        //Bouton permettant d'accéder à l'exercice SBS.
        private void btn_StepByStep_Click(object sender, EventArgs e)
        {
            btn_StepByStep.Visible = false; //Cache le bouton...
            AffichageExerciceStepByStep(); //.... Et le remplace par l'exercice

        }

        //Bouton permettant l'affichage de la consigne pour l'exercice du Step By Step
        private void btn_consignesSBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Faites tourner manuellement Dijkstra étape par étape. \n Remplissez les Fermes et les Ouverts. \n\n /!\\ Attention à respecter certaines règles /!\\ \n\n - Séparez les noeuds par des espaces \n - Ne mettez que des chiffres \n - La dernière étape correspond à l'étape où le noeud à atteindre est en première position dans le domaine des ouverts.");
        }

        //Bouton permettant d'ajouter une étape
        private void btn_nextStep_Click(object sender, EventArgs e)
        {
            int k = 1;
            if (k == 1) { AlgorithmeDijkstra(); k++; }
            //On vérifie saisie du texte
            if (!TestSaisieExerciceSBS())
            {
                MessageBox.Show("Mauvaise saisie !\n\n - Les champs doivent être remplis \n\n - Les noeuds doivent être des nombres \n\n - Vous devez séparer vos saisies par \" , \"");
                return;
            }
            //On écrit les propositions dans la listBox.
            listBox_fermes.Items.Add("(" + etape + ")   F = { " + tb_propositionsFermes.Text + " }");
            listBox_ouverts.Items.Add("(" + etape + ")   O = { " + tb_propositionOuverts.Text + " }");

            //On créé un tableau de string. Chaque case contient un noeud.
            string[] propsFermes = tb_propositionsFermes.Text.Split(' ');
            string[] propsOuverts = tb_propositionOuverts.Text.Split(' ');

            //On ajoute le tableau à la liste contenant toutes les étapes du joueur.
            L_EnsembleEtapesFermesJoueur.Add(propsFermes);
            L_EnsembleEtapesOuvertsJoueur.Add(propsOuverts);

            int nbReponsesJusteF = 0; //Va compter le nombre de réponses justes.
            int nbReponsesJusteO = 0; //Va compter le nombre de réponses justes.

            CompareJoueurAndCorrectionFermes(L_EnsembleEtapesFermesJoueur, IA.L_SuiviFermes, nbReponsesJusteF);
            CompareJoueurAndCorrectionOuverts(L_EnsembleEtapesOuvertsJoueur, IA.L_SuiviOuverts, nbReponsesJusteO);

            //Nettoie les zones de saisie pour l'étape d'après.
            tb_propositionsFermes.Clear();
            tb_propositionOuverts.Clear();

            //Incrémentation de i, ce qui permet de numéroter les étapes pour que l'utilisateur s'y retrouve.
            etape++;
            
            
        }

        //Bouton permettant d'annuler une étape
        private void btn_AnnulerLastStep_Click(object sender, EventArgs e)
        {
            if ((etape - 1) > 0) //On peut supprimer tant que on n'est pas arrivé à l'étape 0.
            {
                listBox_fermes.Items.Remove(listBox_fermes.Items[etape - 1]);
                listBox_ouverts.Items.Remove(listBox_ouverts.Items[etape - 1]);
                //Si on enlève, on décrémente.
                etape--;
            }
            else //On bloque le bouton "Annuler l'étape précédente" car on est retourné au début.
            {
                btn_annulerLastStepSBS.Enabled = false;
            }
            
        }

        //Bouton permettant de recommencer l'exercice en entier
        private void btn_Clear_Click(object sender, EventArgs e)
        {            
            //On nettoie tout. 
            listBox_fermes.Items.Clear();
            listBox_ouverts.Items.Clear();
            etape = 1; //On recommence donc les étapes doivent aussi repartir de 1.

            // On réécrit la situation de départ.
            listBox_fermes.Items.Add("(0)   F = { } ");
            listBox_ouverts.Items.Add("(0)   O = { " + tb_noeudDepart.Text + " }");

            //On réactive tous les boutons
            listBox_ouverts.Enabled = true;
            listBox_fermes.Enabled = true;
            tb_propositionsFermes.Enabled = true;
            tb_propositionOuverts.Enabled = true;
            btn_nextStepSBS.Enabled = true;
            btn_annulerLastStepSBS.Enabled = true;

            
            FormCorrectionStepByStep f = new FormCorrectionStepByStep();
            

        }

        //Bouton permettant de voir la correction
        private void btn_correction_Click(object sender, EventArgs e)
        {
            btn_clearSBS.Visible = false;
            btn_correctionSBS.Visible = false;
            whichCorrection = 1; //Cette valeur permet de "dire" qu'on veut la correction de l'exercice StepByStep            
            AfficheCorrectionStepByStep();
            AlgorithmeDijkstra();
            AffichageResultatsUser();           
            
        }


        //--------------------- EXERCICE TREE VIEW ------------------------------

        //Bouton permettant d'accéder à l'exercice TreeView
        private void btn_CompleterTree_Click(object sender, EventArgs e)
        {
            btn_CompleterTree.Visible = false;//Cache le bouton...            
            AffichageExerciceTree(); //.... Et le remplace par l'exercice
           
        }

        //Bouton permettant l'affichage de la consigne pour l'exercice du TreeView
        private void btn_consignesTV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dans cet exercice vous devez compléter l'arbre présenté ci-contre. \n Le chemin est déjà tracé. \n\n Pour remplir l'arbre : \n - Sélectionnez le noeud en cliquant dessus \n - Ajoutez la valeur dans la case prévue à cet effet \n - Cliquez sur valider ");
        }

        //Bouton permettant d'ajouter une valeur à l'arbre
        private void btn_validerTV_Click(object sender, EventArgs e)
        {
            //On vérifie saisie du texte
            if (!TestSaisieExerciceTV())
            {
                MessageBox.Show("Mauvaise saisie !\n\n - Le champs doit être rempli \n\n - Le noeud doit être un nombre \n\n");
                return;
            }
            tv_aRemplirTV.SelectedNode.Text = tb_editNodeTV.Text;            
            //On ajoute la valeur entrée dans une liste
            repTreeView.Add(tb_editNodeTV.Text);
            tb_editNodeTV.Clear();

        }

        private void btn_correctionTV_Click(object sender, EventArgs e)
        {
            whichCorrection = 2; //Cette valeur permet de "dire" qu'on ne veut PAS la correction de l'exercice StepByStep
                        
            fTV.Show(); //On affiche le form de correction            

            CompareTreeNodes(tv_aRemplirTV, fTV.GetTvCorrige());
            
        }

        void CompareRecursiveTree(TreeNode tn1, TreeNode tn2)
        {            
            if (tn1.Text != tn2.Text)
            {                
                tn1.ForeColor = Color.Red;
                tn2.ForeColor = Color.Red;
            }
            int compare = tn1.Nodes.Count;
            
            // ignore extra nodes
            for (int i = 0; i < compare; i++)
            {
                CompareRecursiveTree(tn1.Nodes[i], tn2.Nodes[i]);
                
            }
            
        }

        void CompareTreeNodes(TreeView tv1, TreeView tv2)
        {
            int compare = tv1.Nodes.Count;
            
            // ignore extra nodes
            for (int i = 0; i < compare; i++)
            {
                CompareRecursiveTree(tv1.Nodes[i], tv2.Nodes[i]);                
            }
        }   
        
    }

    
}


