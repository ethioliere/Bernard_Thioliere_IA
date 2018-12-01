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
    public partial class FormCorrection : Form
    {        
        
        //------------------------ ACCESSEURS ---------------------------------
        //************* Listbox **********
        public ListBox GetListBoxCorrectionOuverts() { return listBox_O_correction; }
        public ListBox GetListBoxCorrectionFermes() { return listBox_F_correction; }
        public ListBox GetListBoxCheminFinal() { return listBox_cheminFinal; }

        //************* Groupbox **********
        public GroupBox GetGroupBoxCorrection() { return gb_correctionSBS; }

        //************* Textbox **********
        public TextBox GetTbInfosFermes() { return tb_infosFermes; }
        public TextBox GetTbInfosOuverts() { return tb_infosOuverts; }

        //************* TreeView **********
        public TreeView GetTvCorrection() { return tv_correctionTV; }

        //************* Label **********
        public Label GetLblCheminAndCOut() { return lbl_cheminFinal; }
        public Label GetLblDetailsO() { return lbl_detailsOuverts; }
        public Label GetLblDetailsF() { return lbl_detailsFermes; }
        public Label GetLblDescription() { return lbl_descriptionSBS; }
        public Label GetLblRepTV() { return lbl_resultatTV; }




        //Nettoyer des éléments        
        public void ClearLbCorrectionOuverts() { listBox_F_correction.Items.Clear(); }

        public void ClearLbCorrectionFermes() { listBox_O_correction.Items.Clear(); }


        //Modifier des éléments
        public void AjoutLbCheminFinal(string item) { listBox_cheminFinal.Items.Add(item); }
        public void AjoutLbCorrectionOuverts(string item) { listBox_O_correction.Items.Add(item); }
        public void AjoutLbCorrectionFermes(string item) { listBox_F_correction.Items.Add(item); }

        //Constructeur par défaut
        public FormCorrection()
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
