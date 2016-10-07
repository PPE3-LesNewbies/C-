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
    /// FormCRUDSupport : form permettant l'ajout/modification d'un support
    /// </summary>
    public partial class FormCRUDSupport : Form
    {
        private char c='c';
        private int indice = -1;
      
        /// <summary>
        /// constructeur FormCRUDSupport 
        /// </summary>
        /// <param name="action">c : en creation, u : en update</param>
        /// <param name="ind">indice du support sélectionné en cas d'update</param>
        public FormCRUDSupport(char action, int ind)
        {
            InitializeComponent();
            c = action;
            indice = ind;
            
        }

        
    }
}
