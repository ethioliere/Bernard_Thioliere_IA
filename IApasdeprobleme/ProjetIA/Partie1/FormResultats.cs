using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partie1
{
    public partial class FormResultats : Form
    {
		// Formulaire qui affiche le résultats du QCM : c'est-à dire un score de bonnes réponses par rapport au nombre de questions posées.

        public FormResultats(int score, int nbquestion)
        {
            InitializeComponent();
            lbl_score.Text= score.ToString() + " / " + nbquestion.ToString();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl_score_Click(object sender, EventArgs e)
        {

        }
    }
}