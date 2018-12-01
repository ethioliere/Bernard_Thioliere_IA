using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Partie1;

namespace Création_questionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
			// -------------------------------------SERIALISATION QUESTIONNAIRE-------------------------------------------------

			// Ici, on stock les questions du QCM dans un fichier XML nommé questionnaire.xml situé dans Partie1/bin/Debug.
			// Les questions sont stockées dans une liste de question.

            string filepath = "../../../Partie1/bin/Debug/questionnaire.xml";
            
            List<Question> questions = new List<Question>();
            
            questions.Add(new Question("De combien de degré de liberté est pourvu une liaison de type “rotule” ?", "1", "2", "3", "4", 2));
            questions.Add(new Question("Qu’est-ce qui caractérise une IA forte ?", "Une conscience et une personnalité", "La complexité du programme", "Un algorithme génétique", "Un apprentissage automatique", 0));
            questions.Add(new Question("La stratégie FIFO est une stratégie qui…", "Parcourt en longueur d’abord", "Parcourt en profondeur d’abord", "Parcourt en largeur d’abord", "Parcourt en surface d’abord", 2));
            questions.Add(new Question("Quelle est la différence entre un algorithme MinMax et un algorithme Alpha Beta ?", "L’algorithme MinMax est plus rapide car plus optimisé", "Alpha Beta évite le développement de branches inutiles", "Il n’y aucune différence : les deux noms désignent le même type d’algorithme", "L’algorithme Alpha Beta n’existe pas", 1));
            questions.Add(new Question("Un des objectifs de l’algorithme de Dijkstra est :", "De permettre la reconnaissance faciale", "Trouver le plus court chemin entre une état initial et un état final", "Trouver la solution mathématique de polynômes du troisième degré", "Calculer le pourcentage de réussite d’un processus", 1));
            questions.Add(new Question("Le problème de Dijkstra utilise une exploration :", "Longitudinale", "Pyramidale", "Radiale", "En profondeur", 2));
            questions.Add(new Question("“L’algorithme de Dijkstra prend en compte le contexte ou les informations de haut niveau pour guider la recherche ou décomposer le problème en sous-problèmes”. Cette affirmation est :", "Toujours vraie", "Toujours fausse", "Vraie uniquement si le nombre de successeurs est très grand", "Vraie uniquement si on indique explicitement à l’algorithme de le faire", 1));
            questions.Add(new Question("Une matrice d’adjacence est :", "toujours symétrique", "symétrique si le graphe est orienté", "symétrique si le graphe n’est pas orienté", "jamais symétrique", 2));
            questions.Add(new Question("Un graphe non orienté est composé de trois points A, B, C. Il y a une arête uniquement entre A et B, et B et C. La relation entre A et B vaut 2 et la relation entre B et C vaut 1. Quelle valeur y a-t-il dans les cases [A;C] et [C;A] de la matrice d’adjacence ?", "-1", "1", "3", "On a besoin de connaître l’angle ABC pour calculer cette valeur", 0));
            questions.Add(new Question("Dans quel cas, l’algorithme A* n’est pas équivalent à Dijkstra ?", "Pour la stratégie de classement des nœuds qui sont placés dans les Fermés", "Pour la stratégie de classement des nœuds qui sont placés dans les Ouverts", "Les deux algorithmes sont toujours équivalents", "Il n’est jamais équivalent à Dijkstra", 1));
            questions.Add(new Question("L’heuristique h(N) permet…", "d’afficher le chemin restant pour atteindre le but", "d’afficher le chemin entre le point de départ et le point d’arrivée", "d’estimer le coût du chemin entre le point de départ et et le point d’arrivée", "d’estimer le coût du chemin restant pour atteindre le but", 3));
            questions.Add(new Question("Quelle est la formule de Tri des ouverts en fonction de f(N) ?", "f(N) = coût_chemin (N) + h(N)", "f(N) = coût_chemin (N) * h(N)", "f(N) = (coût_chemin (N) + h(N))/2", "f(N) = h(N) - coût_chemin (N)", 0));
            questions.Add(new Question("Sous quelle condition A* garantit que le chemin trouvé est le plus court ?", "Si h(N) est un minorant du coût du chemin restant réel", "Si h(N) est un majorant du coût du chemin restant réel", "Si h(N) = 0", "Si h(N) est un entier", 0));
            questions.Add(new Question("Quel est le point fort d’un algorithme génétique ?", "Le code évolue de lui-même", "Il permet d’effectuer de multiples recherches simultanées", "Il est facilement applicable à une situation présentant de nombreux variables", "Il s’adapte à son environnement", 1));
            questions.Add(new Question("Si on pose h(N)=0 pour tout N, alors", "A* équivalent à Dijkstra", "On ne peut pas utiliser Dijkstra", "On ne peut pas utiliser A*", "On doit utiliser MinMax", 0));
            questions.Add(new Question("Dans un graphe, quelle est la différence entre un arc et une arête", "Aucune, les deux termes désignent la même chose", "L’arête désigne une relation dans un graphe orienté alors que pour l’arc le graphe est non orienté", "L’arête désigne une relation dans un graphe non orienté alors que pour l’arc le graphe est orienté", "Un arc relie trois points alors qu’une arête en relie deux", 2));
            questions.Add(new Question("De quoi n’a-t-on pas besoin dans un algorithme génétique où l’on veut trouver la valeur optimale ?", "Une grande population de valeurs", "Une fonction d’évaluation d’une valeur", "Une fonction de mutation qui modifie les valeurs ayant la moins bonne note", "Une fonction de croisement de deux valeurs", 2));
            questions.Add(new Question("Quelle est la bonne orthographe :", "Djikstra", "Dijsktra", "Djisktra", "Dijkstra", 3));
            questions.Add(new Question("Parmi les assertions suivantes, laquelle est un principe de base de la théorie des jeux ?", "On considère que l’adversaire est aussi doué que soi-même", "On considère que la victoire réside dans la compréhension des règles du jeu", "On considère que l’adversaire a plus de chance que nous", "On considère que l’adversaire joue de façon optimale", 3));
            questions.Add(new Question("Si on compare au “model based” le “data based”, on peut dire que ce dernier est", "Globalement identique au premier", "Complètement différent du premier", "Basé sur un faible nombre de données", "Basé sur un grand nombre de données", 3));
            questions.Add(new Question("Enlever une heuristique consiste à", "Compliquer la résolution du problème", "Modifier le sens d’exploration de l’arbre d’exploration", "Supprimer une contrainte pour simplifier le problème", "Enlever une partie des possibilités pour se focaliser sur l’autre partie", 2));
            questions.Add(new Question("Qu’est ce que “l’espace d’états” ?", "L’ensemble des positions que l’on peut attendre au prochain coup", "L’ensemble des positions que l’on peut attendre depuis l’état initial avec un nombre de coups illimités", "L’ensemble des positions initialement connues", "L’ensemble des positions effectivement atteintes lorsque l’on est arrivé à l’état final", 1));
            questions.Add(new Question("Un arbre d’exploration correspond à :", "L’ensemble des possibilités d’exploration de l’algorithme", "L’ensemble des possibilités l’algorithme que l’algorithme a exploré", "L’ensemble des possibilités amenant au résultat voulu", "L’ordre dans lequel les possibilités vont être explorées", 0));

            StreamWriter writer = new StreamWriter(filepath);
                XmlSerializer x = new XmlSerializer(typeof(List<Question>));
                x.Serialize(writer, questions);
            Console.WriteLine("Done");
                writer.Close();
            //}



        }
    }
}
