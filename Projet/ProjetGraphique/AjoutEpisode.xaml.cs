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

namespace ProjetGraphique
{
    /// <summary>
    ///     Fenêtre d'ajout d'un épisode.
    /// </summary>
    public partial class AjoutEpisode : Window
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="s">C'est la saison dans laquelle on veut ajouter l'épisode.</param>
        public AjoutEpisode(Saison s)
        {
            InitializeComponent();
            this.s = s;
        }

        /// <summary>
        ///     Instance de Saison qui récupère la saison passée en paramètre dans le constructeur.
        /// </summary>
        private Saison s = null;


        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'enregistrer le nouvel épisode.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void EnregistrerNewEpisode(object sender, RoutedEventArgs e)
        {
            if (TextBoxNomNewEpisode.Text == "")
            {
                MessageBox.Show("Veuillez mettre un nom d'épisode!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Episode ep = new Episode(TextBoxNomNewEpisode.Text, TextBoxDescriptionNewEpisode.Text);
                s.Ajout(ep, s.ListeEpisodes);
                this.Close();
            }

        }

        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'annuler l'enregistrement du nouvel épisode.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void AnnulerNewEpisode(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
