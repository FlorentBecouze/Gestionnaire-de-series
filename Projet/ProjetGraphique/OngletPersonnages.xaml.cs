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
    ///     UserControl permettant d'afficher l'onglet destiné aux personnages.
    /// </summary>
    public partial class OngletPersonnages : UserControl
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        public OngletPersonnages()
        {
            InitializeComponent();
        }


        /// <summary>
        ///     Evènement du UserControl permettant d'ajouter un personnage.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void AjouterPersonnage(object sender, RoutedEventArgs e)
        {
            // Le DataContext du bouton est une collection de séries (ou de Composant)
            object toto = (sender as Button).DataContext;
            ObservableCollection<Composant> collectionComposants = toto as ObservableCollection<Composant>;

            if(collectionComposants == null)
            {
                MessageBox.Show("Veuillez ajouter une Série", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            AjoutPersonnage ajout = new AjoutPersonnage(collectionComposants);
            ajout.ShowDialog();
        }


        /// <summary>
        ///    Evènement du UserControl pour pouvoir modifier le personnage sélectionné dans le DataGrid.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void ModifierPersonnage(object sender, RoutedEventArgs e)
        {
            if (DataGridPerso.SelectedItem == null) { return; }
            
            if (DataGridPerso.SelectedItem.GetType() == typeof(Personnage))
            {
                Personnage perso = (Personnage)DataGridPerso.SelectedItem;

                ModifUnPersonnage modif = new ModifUnPersonnage(perso, this);
                DataGridPerso.SelectedValue = false;
                modif.ShowDialog();
            }
        }

    }
}
