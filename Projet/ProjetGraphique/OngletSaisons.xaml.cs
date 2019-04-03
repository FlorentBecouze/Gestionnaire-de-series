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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Bibli;
using Donnees2;
using System.Collections.ObjectModel;

namespace ProjetGraphique
{
    /// <summary>
    ///     UserControl permettant d'afficher l'onglet destiné aux saisons.
    /// </summary>
    public partial class OngletSaisons : UserControl
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        public OngletSaisons()
        {
            InitializeComponent();
            // Le DataContext de l'OngletSaisons est la série correspondante à celle cliquée
        }
        

        /// <summary>
        ///     Evènement du UserControl permettant d'ajouter une saison.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void AjouterSaison(object sender, RoutedEventArgs e)
        {
            // Le DataContext du bouton est une Collection de séries(ou de Composant)
            object toto = (sender as Button).DataContext;

            ObservableCollection<Composant> collectionComposants = toto as ObservableCollection<Composant>;

            if (collectionComposants == null)
            {
                MessageBox.Show("Veuillez ajouter une Série", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            AjoutSaison ajout = new AjoutSaison(collectionComposants);

            ajout.ShowDialog();
        }


        /// <summary>
        ///    Evènement du UserControl pour pouvoir modifier la saison sélectionnée dans le Master.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void ModifierCetteSaison(object sender, RoutedEventArgs e)
        {
            if(MasterSaisons.SelectedItem == null) { return; }

            if (MasterSaisons.SelectedItem.GetType() == typeof(Saison))
            {
                Saison sa = MasterSaisons.SelectedItem as Saison;
                ModifCetteSaison modif = new ModifCetteSaison(sa);
                MasterSaisons.SelectedValue = false;
                modif.ShowDialog();
            }
        }



        /// <summary>
        ///     Evènement du UserControl permettant d'ajouter un épisode.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void AjouterEpisode(object sender, RoutedEventArgs e)
        {
            if (MasterSaisons.SelectedItem == null) { return; }

            if (MasterSaisons.SelectedItem.GetType() == typeof(Saison))
            {
                Saison sa = MasterSaisons.SelectedItem as Saison;
                AjoutEpisode ajout = new AjoutEpisode(sa);
                ajout.ShowDialog();
                
            }  
        }


        /// <summary>
        ///     Evènement du UserControl permettant d'afficher l'épisode cliqué dans le Master.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le TextBlock).</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void CliqueEpisode(object sender, RoutedEventArgs e)
        {
            if (MasterEpisodes.SelectedItem == null) { return; }

            if (MasterEpisodes.SelectedItem.GetType() == typeof(Episode))
            {
                Episode ep = MasterEpisodes.SelectedItem as Episode;
                Pop_Up_Episode pop = new Pop_Up_Episode(ep);
                MasterEpisodes.SelectedValue = false;
                pop.ShowDialog();
            }
        }


    }
}
    