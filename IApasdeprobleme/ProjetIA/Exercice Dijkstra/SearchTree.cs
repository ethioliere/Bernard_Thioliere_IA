using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceDijkstra
{
    class SearchTree
    {
        //Ces listes contiennent des noeuds. Elles se rempliront lors de la résolution de l'algorithme.
        public List<GenericNode> L_Ouverts;
        public List<GenericNode> L_Fermes;

        //On va avoir des listes contenant des tableaux. Chaque tableau va correspondre à une étape.
        public List<String[]> L_SuiviFermes = new List<String[]>(); 
        public List<String[]> L_SuiviOuverts = new List<String[]>();

        //Va contenir la liste qui va permettre la correction du TreeView
        public List<string> correctionTreeView = new List<string>();

        int etape = 1; //Va permettre de connaitre l'etape

        public int CountInOpenList() //Calcul le nombre d'éléments dans la liste
        {
            return L_Ouverts.Count;
        }
        public int CountInClosedList() //Calcul le nombre d'éléments dans la liste
        {
            return L_Fermes.Count;
        }

        private GenericNode ChercheNodeDansFermes(GenericNode N2) //Permet de trouver un noeud dans les fermes
        {
            int i = 0;

            //On parcourt tous les noeuds des fermés et on continue tant qu'on a pas trouvé celui qu'on veut
            while (i < L_Fermes.Count)
            {
                if (L_Fermes[i].IsEqual(N2))
                    return L_Fermes[i];
                i++;
            }
            return null;
        }
     
        private GenericNode ChercheNodeDansOuverts(GenericNode N2)
        {
            int i = 0;

            //On parcourt tous les noeuds des fouverts et on continue tant qu'on a pas trouvé celui qu'on veut
            while (i < L_Ouverts.Count)
            {
                if (L_Ouverts[i].IsEqual(N2))
                    return L_Ouverts[i];
                i++;
            }
            return null;
        } //Permet de trouver un noeud dans les ouverts

        public void Initialisation(GenericNode N0)
        {
            //On créé les listes
            L_Ouverts = new List<GenericNode>();
            L_Fermes = new List<GenericNode>();

            // Le noeud passé en paramètre est supposé être le noeud initial, donc on l'ajoute aux ouverts            
            L_Ouverts.Add(N0); //On le met dans les ouverts.
        }
        /* Retourne la lettre correspondante au node */
        private string[] SaveStep(List<GenericNode> listAStep)
        {
            string[] noeudsPourUneEtape = new string[listAStep.Count];

            for (int i = 0; i < listAStep.Count; i++)
            {
                noeudsPourUneEtape[i] = Convert.ToString(listAStep[i]);
            }

            return noeudsPourUneEtape;
        }

        /* Fonction principale de résolution de l'algorithme */
        public List<GenericNode> RechercheSolution(GenericNode N0, GenericNode N)
        {          
            //Le noeud passé en paramètre est supposé être le noeud initial
            //GenericNode N = N0;
            L_Ouverts.Add(N0);
            

            // tant que le noeud n'est pas terminal et que ouverts n'est pas vide
            while (L_Ouverts.Count != 0 && N.EndState() == false)
            {
                etape++;
                // Le meilleur noeud des ouverts est supposé placé en tête de liste
                // On le place dans les fermés
                L_Ouverts.Remove(N); //On enlève le meilleur noeud des ouverts...
                L_Fermes.Add(N); //... et on le met dans les fermés car on l'a atteint. 

                // Il faut trouver les noeuds successeurs de N
                this.MAJSuccesseurs(N);
                // Inutile de retrier car les insertions ont été faites en respectant l'ordre

                //Enregistrement de l'étape qu'on vient de faire.
                L_SuiviOuverts.Add(SaveStep(L_Ouverts));
                L_SuiviFermes.Add(SaveStep(L_Fermes));

                // On prend le meilleur, donc celui en position 0, pour continuer à explorer les états
                // A condition qu'il existe bien sûr
                if (etape != 1)
                {
                    if (L_Ouverts.Count > 0) { N = L_Ouverts[0]; }
                    else { N = null; }
                }                
                
            }
            
            // A* terminé
            // On retourne le chemin qui va du noeud initial au noeud final sous forme de liste
            // Le chemin est retrouvé en partant du noeud final et en accédant aux parents de manière
            // itérative jusqu'à ce qu'on tombe sur le noeud initial

            List<GenericNode> solution = RetourneCheminFinal(N, N0);
            return solution;
            
        }

        public List<GenericNode> RetourneCheminFinal(GenericNode N, GenericNode N0)
        {
            List<GenericNode> _LN = new List<GenericNode>(); //Contient le plus court chemin
            if (N != null)
            {
                _LN.Add(N);

                while (N != N0) // On "remonte" l'arbre. Donc on le fait tant qu'on arrive pas au noeud final.
                {
                    N = N.GetNoeud_Parent(); // On regarde le noeud parent du dessus. 
                    _LN.Insert(0, N);  // On insère en position 1 vu qu'on remonte.
                }
            }
            return _LN;
        }
        
        public void MAJSuccesseurs(GenericNode N)
        {
            // On fait appel à GetListSucc, méthode abstraite qu'on doit réécrire pour chaque
            // problème. Elle doit retourner la liste complète des noeuds successeurs de N.
            List<GenericNode> listsucc = N.GetListSucc();
            foreach (GenericNode N2 in listsucc) //Pour chaque noeud enfant pour un parent donné
            {
                // N2 est-il une copie d'un nœud déjà vu et placé dans la liste des fermés ?
                GenericNode N2bis = ChercheNodeDansFermes(N2);

                if (N2bis == null) //Cas où N2 bis n'est pas dans les fermes. (car la fonction renvoie null si il y ait pas)
                {
                    // Rien dans les fermés. Est-il dans les ouverts ?
                    N2bis = ChercheNodeDansOuverts(N2);
                    if (N2bis != null) // Cas où il est dans les ouverts
                    {
                        // Il existe, donc on l'a déjà vu, N2 n'est qu'une copie de N2Bis
                        // Le nouveau chemin passant par N est-il meilleur ?
                        if (N.GetGCost() + N.GetArcCost(N2) < N2bis.GetGCost())
                        {
                            // Mise à jour de N2bis
                            N2bis.SetGCost(N.GetGCost() + N.GetArcCost(N2));
                            // HCost pas recalculé car toujours bon
                            N2bis.RecalculeCoutTotal(); // somme de GCost et HCost
                            // Mise à jour de la famille ....
                            N2bis.Supprime_Liens_Parent();
                            N2bis.SetNoeud_Parent(N);
                            // Mise à jour des ouverts
                            L_Ouverts.Remove(N2bis);
                            this.InsertNewNodeInOpenList(N2bis);
                        }
                        // else on ne fait rien, car le nouveau chemin est moins bon
                    }
                    else
                    {
                        // N2 est nouveau, MAJ et insertion dans les ouverts
                        N2.SetGCost(N.GetGCost() + N.GetArcCost(N2));
                        N2.SetNoeud_Parent(N);
                        N2.calculCoutTotal(); // somme de GCost et HCost
                        this.InsertNewNodeInOpenList(N2);
                    }
                }
                // else il est dans les fermés donc on ne fait rien,
                // car on a déjà trouvé le plus court chemin pour aller en N2
            }
        }

        public void InsertNewNodeInOpenList(GenericNode NewNode)
        {
            // Insertion pour respecter l'ordre du cout total le plus petit au plus grand
            if (this.L_Ouverts.Count == 0) { L_Ouverts.Add(NewNode); } // SI les ouverts sont vides
            else //Ouverts pas vides
            {
                GenericNode N = L_Ouverts[0];
                bool trouve = false;
                int i = 0;
                do
                    if (NewNode.Cout_Total < N.Cout_Total) // Cout plus faible = chemin plus court
                    {
                        L_Ouverts.Insert(i, NewNode); //On le met dans les ouverts
                        trouve = true;
                    }
                    else //Cout plus élevé
                    {
                        i++;
                        if (L_Ouverts.Count == i)
                        {
                            N = null;
                            L_Ouverts.Insert(i, NewNode);
                        }
                        else { N = L_Ouverts[i]; }
                    }
                while ((N != null) && (trouve == false));
            }
        }


        // --------------------- AFFICHAGE ARBRE CORRIGE ------------------------------

        // Si on veut afficher l'arbre de recherche, il suffit de passer un treeview en paramètres
        // Celui-ci est mis à jour avec les noeuds de la liste des fermés, on ne tient pas compte des ouverts
        public void GetSearchTree(TreeView TV)
        {
            if (L_Fermes == null) return;
            if (L_Fermes.Count == 0) return;

            // On suppose le TreeView préexistant
            TV.Nodes.Clear();

            TreeNode TN = new TreeNode(L_Fermes[0].ToString());
            correctionTreeView.Add(L_Fermes[0].ToString()); //Ajout de l'etape pour la correction

            TV.Nodes.Add(TN);

            AjouteBranche(L_Fermes[0], TN);
        }

        // AjouteBranche est exclusivement appelée par GetSearchTree; les noeuds sont ajoutés de manière récursive
        private void AjouteBranche(GenericNode GN, TreeNode TN)
        {
            foreach (GenericNode GNfils in GN.GetEnfants())
            {                
                
                TreeNode TNfils = new TreeNode(GNfils.ToString());
                TN.Nodes.Add(TNfils);
                if (GNfils.GetEnfants().Count > 0) AjouteBranche(GNfils, TNfils);
                correctionTreeView.Add(GNfils.ToString()); //Ajout de l'etape pour la correction
            }
        }

        // --------------------- AFFICHAGE ARBRE A REMPLIR ------------------------------

        //Va permettre d'obtenir la structure du graphe sans avoir les noeuds d'écrit. Le joueur devra les remplir.
        public void GetStructureTree(TreeView TV_vide)
        {
            if (L_Fermes == null) return;
            if (L_Fermes.Count == 0) return;

            // On suppose le TreeView préexistant
            TV_vide.Nodes.Clear();

            TreeNode TN = new TreeNode("__");
            TV_vide.Nodes.Add(TN);

            AjouteBrancheVide(L_Fermes[0], TN);
        }

        private void AjouteBrancheVide(GenericNode GN, TreeNode TN)
        {
            foreach (GenericNode GNfils in GN.GetEnfants())
            {
                TreeNode TNfils = new TreeNode("__");
                TN.Nodes.Add(TNfils);
                if (GNfils.GetEnfants().Count > 0) AjouteBrancheVide(GNfils, TNfils);
            }
        }

    }
}
