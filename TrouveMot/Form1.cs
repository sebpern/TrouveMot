using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrouveMot
{
    public partial class Form1 : Form
    {
        //Déclaration d'un tableau de 10 chaines
        //Un tableau est un ensemble de variables de même type
        // ces variables sont regroupées dans une même entité
        //une case d'un tableau est décrite par son indice (numéro de la case)
        // et par sa valeur : nomTableau[valeurIndice]
        String[] mots=new String[10];
        public Form1()
        {
            InitializeComponent();
            definirMot();
            
        }
        //on crée un sous programme pour définir les mots
        //on pourrait le faire direcement dans public Form1
        //mais c'est plus propre de découper le programme
         void definirMot()
        {
            mots[0] = "table";
            mots[1] = "chaise";
            mots[2] = "tableau";
            mots[3] = "bureau";
            mots[4] = "horloge";
            mots[5] = "brosse";
            mots[6] = "sujet";
            mots[7] = "copie";
            mots[8] = "surveillant";
            mots[9] = "emargement";
        }

        private void btnAfficherCacher_Click(object sender, EventArgs e)
        {
            int nbClic=Convert.ToInt32(lblClic.Text);
            if (nbClic == 10)
            {
                MessageBox.Show("Arrêtes de cliquer !!!");
            }
            else
            {
                if (nbClic % 2 == 0)
                {
                    gbxJeu.Visible = true;
                }
                else
                {
                    gbxJeu.Visible = false;
                }
                nbClic++;
                lblClic.Text = nbClic.ToString();
            }
            
        }
    }
}
