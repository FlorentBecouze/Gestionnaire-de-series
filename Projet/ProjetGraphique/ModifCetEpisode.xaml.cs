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
    ///     Fenêtre de modification d'un épisode sélectionné.
    /// </summary>
    public partial class ModifCetEpisode : Window
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="ep">C'est l'épisode que l'on veut modifier.</param>
        public ModifCetEpisode(Episode ep)
        {
            InitializeComponent();
            this.DataContext = ep;
            this.ep = ep;
        }

        /// <summary>
        ///     Instance d'Episode qui récupère l'épisode passé en paramètre dans le constructeur.
        /// </summary>
        private Episode ep = null;


        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'enregistrer les modifications faites sur l'épisode.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void EnregistrerModifEpisode(object sender, RoutedEventArgs e)
        {
            if(TextBoxNomEpisodeAModif.Text == "")
            {
                MessageBox.Show("Veuillez mettre un nom d'épisode!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                ep.Nom = TextBoxNomEpisodeAModif.Text;
                ep.DescriptionEpisode = TextBoxDescriptionEpisodeAModif.Text;
                this.Close();
            } 
            
        }


        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'annuler les modifications faites sur l'épisode.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void AnnulerModifEpisode(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
