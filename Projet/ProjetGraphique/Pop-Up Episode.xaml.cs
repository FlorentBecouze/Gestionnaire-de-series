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
    ///     Fenêtre pop-up de l'épisode sélectionné dans le Master.
    /// </summary>
    public partial class Pop_Up_Episode : Window
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="ep">C'est l'épisode que l'on va afficher dans cette fenêtre.</param>
        public Pop_Up_Episode(Episode ep)
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
        ///    Evènement du bouton de la fenêtre permettant d'ouvrir la fenêtre 'ModifCetEpisode' pour pouvoir modifier l'épisode.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void ModifierCetEpisode(object sender, RoutedEventArgs e)
        {
            ModifCetEpisode modif = new ModifCetEpisode(ep);
            modif.ShowDialog();
        }

    }
}
