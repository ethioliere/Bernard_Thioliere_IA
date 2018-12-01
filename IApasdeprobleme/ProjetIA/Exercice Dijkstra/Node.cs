using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDijkstra
{
    class Node : GenericNode
    {
        public int numero;

        // Méthodes abstrates, donc à surcharger obligatoirement avec override dans une classe fille
        public override bool IsEqual(GenericNode N2)
        {
            Node N2bis = (Node)N2;

            return numero == N2bis.numero;
        }

        public override double GetArcCost(GenericNode N2)
        {
            Node N2bis = (Node)N2;
            return FormExercices.matrice[numero, N2bis.numero];
        }

        public override bool EndState()
        {
            return (numero == FormExercices.numNodeFinal);
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();

            for (int i = 0; i < FormExercices.nbnodes; i++)
            {
                if (FormExercices.matrice[numero, i] != -1)
                {
                    Node newNode = new Node();
                    newNode.numero = i;
                    lsucc.Add(newNode);
                }
            }
            return lsucc;
        }


        public override double CalculeHCost()
        {
            return (0);
        }

        public override string ToString()
        {
            return Convert.ToString(numero);
        }
    }
}
