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
using System.Collections.ObjectModel;

namespace ProjetGraphique
{
    /// <summary>
    ///     Fenêtre d'ajout d'une saison.
    /// </summary>
    public partial class AjoutSaison : Window
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="collectionComposants">C'est la collection globale dans laquelle on veut ajouter la saison.</param>
        public AjoutSaison(ObservableCollection<Composant> collectionComposants)
        {
            InitializeComponent();
            this.collectionComposants = collectionComposants;
        }


        /// <summary>
        ///     Instance de ObservableCollection<Composant> qui récupère la collection passée en paramètre dans le constructeur.
        /// </summary>
        private ObservableCollection<Composant> collectionComposants = null;



        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'enregistrer la nouvelle saison.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void EnregistrerNewSaison(object sender, RoutedEventArgs e)
        {
            if (TextBoxNomNewSaison.Text == "")
            {
                MessageBox.Show("Veuillez mettre un nom de saison!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Saison sa = new Saison(TextBoxNomNewSaison.Text, TextBoxDescriptionNewSaison.Text);
                collectionComposants.Add(sa);
                this.Close();
            }
        }


        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'annuler l'enregistrement de la nouvelle saison.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void AnnulerNewSaison(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
