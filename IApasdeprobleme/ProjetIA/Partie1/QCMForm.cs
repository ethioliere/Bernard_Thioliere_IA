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
using System.Xml;
using System.Xml.Serialization;

namespace Partie1
{
    public partial class QCMForm : Form
    {
		// on définit les différentes variables utiles tout au long du questionnaire :

        public int score = 0; // on stocke ici le nombre de bonnes réponses de l'utilisateur
        public int nbQuestion = 0; // compte le nombre de questions affichées
        public int numQuestion; // nombre qui désigne le numéro de la question en cours dans la liste de question


        List<Question> questions = new List<Question>(); // la liste des questions présentées dans le QCM est stockée ici

        public QCMForm()
        {
            InitializeComponent();
			
			// On récupère les questions contenues dans le fichier questionnaire.xml situé dans Partie1/bin/Debug

            StreamReader reader = new StreamReader("questionnaire.xml");
            List<Question> questionnaire = (List<Question>)new XmlSerializer(typeof(List<Question>)).Deserialize(reader);
            reader.Close();
            questions = questionnaire;

			// On affcihe la première question du QCM

            AfficherQuestion();

			
        }

        private void btn_abandon_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btn_repA_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Correction(btn);
        }

		// Méthode qui affiche la correction de la question en cours : la réponse est teintée en vert si correcte, rouge sinon avec la bonne réponse en vert
        private void Correction(Button btn)
        {
            btn_repA.Enabled = btn_repB.Enabled = btn_repC.Enabled = btn_repD.Enabled = false; // empêche l'utilisateur de cliquer sur d'autres réponses


            if (btn.TabIndex == questions[numQuestion].bonneReponse + 4) // on regarde si la réponse est correcte
            {
                AfficherBonneReponse(btn);
                score += 1;
                lbl_score.Text = score.ToString();
                btn_suivant.Visible = true;

            }
            else // si la réponse est fausse on affiche la bonne en vert et celle choisie par l'utilisateur en rouge
            {
                AfficherMauvaiseReponse(btn);
                if (questions[numQuestion].bonneReponse == 0) AfficherBonneReponse(btn_repA);
                else if (questions[numQuestion].bonneReponse == 1) AfficherBonneReponse(btn_repB);
                else if (questions[numQuestion].bonneReponse == 2) AfficherBonneReponse(btn_repC);
                else if (questions[numQuestion].bonneReponse == 3) AfficherBonneReponse(btn_repD);
                btn_suivant.Visible = true;


            }
        }

        private void AfficherBonneReponse(Button btn) // colore le bouton concerné en vert
        {
            btn.BackColor = Color.FromArgb(0, 192, 0);
        }

        private void AfficherMauvaiseReponse(Button btn) // colore le bouton concerné en rouge
        {
            btn.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void btn_repB_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Correction(btn);
        }

        private void btn_repC_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Correction(btn);
        }

        private void btn_repD_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Correction(btn);
        }

		// Méthode qui passe affiche la question suivante ou bien les résultats
        private void btn_suivant_Click(object sender, EventArgs e)
        {
            if ((nbQuestion < 20)&&(questions.Count>1))
            {
                btn_repA.Enabled = btn_repB.Enabled = btn_repC.Enabled = btn_repD.Enabled = true;

                questions.Remove(questions[numQuestion]); // on retire la question de la liste pour éviter qu'elle ne soit poser à nouveau
                AfficherQuestion();
				// Si on est à la dernière question, remplace "Question Suivante" par "Résultats"
                if ((nbQuestion ==20)||(questions.Count == 1)) btn_suivant.Text = "Résultats";

            }
            else // lorsque l'utilisateur a répondu aux 20 questions, on affiche le formulaire des résultats
            {


                Button btn = sender as Button; //On regarde si le sender est bien un bouton. Si non --> Valeur null. 
                if (btn != null)
                {
                    FormResultats res = new FormResultats(score, nbQuestion);
                    res.Show();
                    Close();
                }
            }
        }
		// Affiche une nouvelle question en en piochant une au hasard dans la liste de questions disponibles
		// Réinitialise l'affichage du formulaire
        private void AfficherQuestion()
        {
            nbQuestion++;
            lbl_numQuestion.Text = nbQuestion.ToString();

            Random alea = new Random();
            numQuestion = alea.Next(questions.Count);

            txt_Questions.Text = questions[numQuestion].enonce;
            btn_repA.Text = questions[numQuestion].reponses[0];
            btn_repB.Text = questions[numQuestion].reponses[1];
            btn_repC.Text = questions[numQuestion].reponses[2];
            btn_repD.Text = questions[numQuestion].reponses[3];

            btn_repA.BackColor = btn_repB.BackColor = btn_repC.BackColor = btn_repD.BackColor = SystemColors.Control;
            btn_suivant.Visible = false;
        }
    }
}

