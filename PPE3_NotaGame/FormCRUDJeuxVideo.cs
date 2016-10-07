using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_NotaGame
{
    /// <summary>
    /// FormCRUDjeuxVideos : feuille qui permet la gestion Ajout/modification d'un jeux vidéo
    /// </summary>
    public partial class FormCRUDJeuxVideo : Form
    {
        private char c = 'c';
        private int indice = -1;

        /// <summary>
        /// Constructeur FormCRUDConstructeur
        /// </summary>
        /// /// <param name="action">c : en creation, u : en update</param>
        /// <param name="ind">indice du support sélectionné en cas d'update</param>
        public FormCRUDJeuxVideo(char action, int ind)
        {
            InitializeComponent();
            c = action;
            indice = ind;
        }

        /// <summary>
        /// Chargement de FormCRUD : remplissage de la comboBox des constructeurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCRUD_Load(object sender, EventArgs e)
        {
            
        }
    }
}
