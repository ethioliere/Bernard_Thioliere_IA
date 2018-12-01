using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceDijkstra
{
    public partial class FormCorrectionStepByStep : Form
    {        
        
        //------------------------ ACCESSEURS ---------------------------------
        //************* Listbox **********
        public ListBox GetListBoxCorrectionOuverts() { return listBox_O_correction; }
        public ListBox GetListBoxCorrectionFermes() { return listBox_F_correction; }
        public ListBox GetListBoxCheminFinal() { return listBox_cheminFinal; }

        //************* Groupbox **********
        public GroupBox GetGroupBoxCorrection() { return gb_correctionSBS; }
        
        //************* TreeView **********
        public TreeView GetTvCorrection() { return tv_correctionTV; }

        //************* Label **********
        public Label GetLblCheminAndCOut() { return lbl_cheminFinal; }
        public Label GetLblDescription() { return lbl_descriptionSBS; }
        public Label GetLblRepTV() { return lbl_resultatTV; }
        public Label GetLblInfos() { return lbl_infos; }
        public Label GetLblScoreFermes() { return lbl_scoreFermes; }
        public Label GetLblScoreOuverts() { return lbl_scoreOuverts; }




        //Nettoyer des éléments        
        public void ClearLbCorrectionOuverts() { listBox_F_correction.Items.Clear(); }

        public void ClearLbCorrectionFermes() { listBox_O_correction.Items.Clear(); }


        //Modifier des éléments
        public void AjoutLbCheminFinal(string item) { listBox_cheminFinal.Items.Add(item); }
        public void AjoutLbCorrectionOuverts(string item) { listBox_O_correction.Items.Add(item); }
        public void AjoutLbCorrectionFermes(string item) { listBox_F_correction.Items.Add(item); }

        //Constructeur par défaut
        public FormCorrectionStepByStep()
        {
            InitializeComponent();
        }

        //Fermer le form de correction
        private void btn_quitCorrection_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
