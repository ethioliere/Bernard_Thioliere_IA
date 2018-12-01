using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExerciceDijkstra;

namespace Partie1
{
    public partial class FormAccueil : Form
    {
		// Formulaire d'Accueil de l'application qui permet de faire un QCM ou de travailler sur l'algorithme de Dijkstra

        public FormAccueil()
        {
            InitializeComponent();
        }

        private void btn_QCM_Click(object sender, EventArgs e) // ouvre le formulaire du QCM
        {
            Button btn = sender as Button; //On regarde si le sender est bien un bouton. Si non --> Valeur null. 
            if (btn != null)
            {
                QCMForm qf = new QCMForm();
                qf.Show(); 
            }
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {

        }
        

        private void btn_Dijkstra_Click(object sender, EventArgs e) // ouvre le formulaire Dijkstra
        {
            Button btn = sender as Button; //On regarde si le sender est bien un bouton. Si non --> Valeur null. 
            if (btn != null)
            {
                FormExercices fE = new FormExercices();
                fE.Show();
            }
        }
        

        /*
         If Me._DataSet.Table.Contrat = "True" then
             Me.Button_AddListBox.BackColor = Drawing.Color.Red
        elseif Me._DataSet.Table.Contrat = "False" then 
             Me.Button_AddListBox.BackColor = Drawing.Color.Green
        */
    }
}
