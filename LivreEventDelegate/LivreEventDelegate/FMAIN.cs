using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivreEventDelegate
{
    public partial class FMAIN : Form
    {
        FLIVRE maFenetreLivre;
        FHISTORIQUE maFenetreHistorique;
        public FMAIN()
        {
            InitializeComponent();
            btnNouveauLivre.Click += btnNouveauLivre_Click;
            Livre unLivre = new Livre("Le seigneur des anneaux", 15, 8);
            maFenetreLivre = new FLIVRE(unLivre);
            maFenetreHistorique = new FHISTORIQUE(unLivre);
        }

        private void btnNouveauLivre_Click(object sender, EventArgs e)
        {
            maFenetreLivre.Show();
            maFenetreHistorique.Show();
        }

        private void FMAIN_Load(object sender, EventArgs e)
        {

        }
    }
}
