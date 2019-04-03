using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Bibli;
using Donnees2;

namespace ProjetGraphique
{
    /// <summary>
    ///     Fenêtre de modification d'une saison sélectionnée.
    /// </summary>
    public partial class ModifCetteSaison : Window
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="s">C'est la saison que l'on veut modifier.</param>
        public ModifCetteSaison(Saison s)
        {
            InitializeComponent();
            this.DataContext = s;
            this.s = s;
        }

        /// <summary>
        ///     Instance de Saison qui récupère la saison passée en paramètre dans le constructeur.
        /// </summary>
        private Saison s = null;


        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'enregistrer les modifications faites sur la saison.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void EnregistrerModifSaison(object sender, RoutedEventArgs e)
        {
            if(TextBoxNomSaisonAModif.Text == "")
            {
                MessageBox.Show("Veuillez mettre un nom de saison!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                s.Nom = TextBoxNomSaisonAModif.Text;
                s.DescriptionSaison = TextBoxDescriptionSaisonAModif.Text;

                this.Close();
            }
            
        }


        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'annuler les modifications faites sur la saison.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void AnnulerModifSaison(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
