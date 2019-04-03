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
    ///     UserControl permettant d'afficher l'onglet destiné aux commentaires.
    /// </summary>
    public partial class OngletCommentaires : UserControl
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        public OngletCommentaires()
        {
            InitializeComponent();
            // Le DataContext est la série sélectionnée dans le master
        }


        /// <summary>
        ///     Evènement du UserControl permettant d'ajouter un commentaire.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void EnvoyerCommentaire(object sender, RoutedEventArgs e)
        {
            string nom = TextBoxNomCommentaire.Text;
            string commentaire = TextBoxCommentaire.Text;
            int note = 0;

            if(nom == "" || commentaire == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs!!", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if ((bool)NoteCheckBox1.IsChecked)
            {
                note++;
                if ((bool)NoteCheckBox2.IsChecked)
                {
                    note++;
                    if ((bool)NoteCheckBox3.IsChecked)
                    {
                        note++;
                        if ((bool)NoteCheckBox4.IsChecked)
                        {
                            note++;
                            if ((bool)NoteCheckBox5.IsChecked)
                            {
                                note++;
                            }
                        }
                    }
                }
            }

            object dataContextBouton = (sender as Button).DataContext;
            ObservableCollection<Composant> collectionComposants = dataContextBouton as ObservableCollection<Composant>;
            
            if (collectionComposants == null)
            {
                MessageBox.Show("Veuillez ajouter une Série!!", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            collectionComposants.Add(new Commentaire(nom, commentaire, note));


            // Pour enlever les informations qui restent dans les TextBox et dans les CheckBox après avoir appuyer sur le bouton 'Envoyer'
            TextBoxCommentaire.Text = null;
            TextBoxNomCommentaire.Text = null;
            NoteCheckBox1.IsChecked = false;
            NoteCheckBox2.IsChecked = false;
            NoteCheckBox3.IsChecked = false;
            NoteCheckBox4.IsChecked = false;
            NoteCheckBox5.IsChecked = false;

        }


        /// <summary>
        ///     Evènement du UserControl permettant de cocher/décocher le 1er CheckBox
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void CheckNote1(object sender, RoutedEventArgs e)
        {
            if ((bool)NoteCheckBox2.IsChecked || (bool)NoteCheckBox3.IsChecked || (bool)NoteCheckBox4.IsChecked || (bool)NoteCheckBox5.IsChecked)
            {
                NoteCheckBox1.IsChecked = false;
                NoteCheckBox2.IsChecked = false;
                NoteCheckBox3.IsChecked = false;
                NoteCheckBox4.IsChecked = false;
                NoteCheckBox5.IsChecked = false;
            }
            NoteCheckBox1.IsChecked = true;
            NoteCheckBox2.IsChecked = false;
            NoteCheckBox3.IsChecked = false;
            NoteCheckBox4.IsChecked = false;
            NoteCheckBox5.IsChecked = false;
        }


        /// <summary>
        ///     Evènement du UserControl permettant de cocher/décocher le 2ème CheckBox
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void CheckNote2(object sender, RoutedEventArgs e)
        {
            if ((bool)NoteCheckBox3.IsChecked || (bool)NoteCheckBox4.IsChecked || (bool)NoteCheckBox5.IsChecked)
            {
                NoteCheckBox1.IsChecked = true;
                NoteCheckBox2.IsChecked = false;
                NoteCheckBox3.IsChecked = false;
                NoteCheckBox4.IsChecked = false;
                NoteCheckBox5.IsChecked = false;
            }
            NoteCheckBox1.IsChecked = true;
            NoteCheckBox2.IsChecked = true;
            NoteCheckBox3.IsChecked = false;
            NoteCheckBox4.IsChecked = false;
            NoteCheckBox5.IsChecked = false;
        }


        /// <summary>
        ///     Evènement du UserControl permettant de cocher/décocher le 3ème CheckBox
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void CheckNote3(object sender, RoutedEventArgs e)
        {
            if ((bool)NoteCheckBox4.IsChecked || (bool)NoteCheckBox5.IsChecked)
            {
                NoteCheckBox1.IsChecked = true;
                NoteCheckBox2.IsChecked = true;
                NoteCheckBox3.IsChecked = false;
                NoteCheckBox4.IsChecked = false;
                NoteCheckBox5.IsChecked = false;
            }
            NoteCheckBox1.IsChecked = true;
            NoteCheckBox2.IsChecked = true;
            NoteCheckBox3.IsChecked = true;
            NoteCheckBox4.IsChecked = false;
            NoteCheckBox5.IsChecked = false;
        }


        /// <summary>
        ///     Evènement du UserControl permettant de cocher/décocher le 4ème CheckBox
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void CheckNote4(object sender, RoutedEventArgs e)
        {
            if ((bool)NoteCheckBox5.IsChecked)
            {
                NoteCheckBox1.IsChecked = true;
                NoteCheckBox2.IsChecked = true;
                NoteCheckBox3.IsChecked = true;
                NoteCheckBox4.IsChecked = false;
                NoteCheckBox5.IsChecked = false;
            }
            NoteCheckBox1.IsChecked = true;
            NoteCheckBox2.IsChecked = true;
            NoteCheckBox3.IsChecked = true;
            NoteCheckBox4.IsChecked = true;
            NoteCheckBox5.IsChecked = false;
        }


        /// <summary>
        ///     Evènement du UserControl permettant de cocher/décocher le 5ème CheckBox
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void CheckNote5(object sender, RoutedEventArgs e)
        {
            NoteCheckBox1.IsChecked = true;
            NoteCheckBox2.IsChecked = true;
            NoteCheckBox3.IsChecked = true;
            NoteCheckBox4.IsChecked = true;
            NoteCheckBox5.IsChecked = true;
        }

    }
}
