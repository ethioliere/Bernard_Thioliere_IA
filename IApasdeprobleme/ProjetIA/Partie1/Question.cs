using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Partie1
{
    [Serializable]

    public class Question

		// La classe question défini un objet contenant un chaine de caractères correspondant à l'énoncé de la question, un tableau de 4
		// de caractères contenant les 4 possibilités de réponse et un entier correspondant à la bonne réponse : 0 pour la réponse A,
		// 1 pour la B, 2 pour la C, 3 pour la D.
    {
        [XmlElement("enonce", typeof(string))]
        public string enonce { get; set; }

        [XmlElement("reponses", typeof(string[]))]
        public string[] reponses { get; set; }

        [XmlElement("bonneReponse", typeof(int))]
        public int bonneReponse { get; set; }

        //Constructeur

        public Question(string quest, string repA, string repB, string repC, string repD, int bonneRep)
        {
            this.enonce = quest;
            this.reponses = new string [] { repA, repB, repC, repD };
            this.bonneReponse = bonneRep;            

        }
        public Question() { }

        

    }
}
