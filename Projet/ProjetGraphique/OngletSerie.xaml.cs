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
using System.IO;

namespace ProjetGraphique
{
    /// <summary>
    ///     UserControl permettant d'afficher l'onglet destiné aux séries.
    /// </summary>
    public partial class OngletSerie : UserControl
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        public OngletSerie()
        {
            InitializeComponent();
        }


        /// <summary>
        ///     Evènement du UserControl permettant de supprimer la série sélectionnée dans le Master.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement
        private void SupprimerCetteSerie(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette série, ainsi que tout ce qui la compose?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            
            if (result == MessageBoxResult.Yes)
            {
                // Le DataContext de l'onglet est une collection de séries (ou de Composant)
                object dataContextOnglet = this.DataContext;
                ObservableCollection<Composant> collectionSeries = dataContextOnglet as ObservableCollection<Composant>;

                Serie s = new Serie(TBNomSerie.Text, TBDescriptionSerie.Text, "");

                collectionSeries.Remove(s);
            }
        }
    }
}
