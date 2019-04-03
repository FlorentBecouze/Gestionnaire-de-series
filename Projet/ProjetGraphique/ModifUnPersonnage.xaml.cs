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
using Microsoft.Win32;
using System.IO;

namespace ProjetGraphique
{
    /// <summary>
    ///     Fenêtre de modification d'un personnage sélectionné.
    /// </summary>
    public partial class ModifUnPersonnage : Window
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="p">C'est le personnage que l'on veut modifier.</param>
        /// <param name="onglet">
        ///     C'est l'onglet "Personnages" de l'application, qui nous permet de déselectionner le personnage précédemment sélectionné dans le DataGrid,
        ///     quand on avait voulu le modifier et après avoir enregistrer les modifications.</param>
        public ModifUnPersonnage(Personnage p, OngletPersonnages onglet)
        {
            InitializeComponent();
            this.p = p;
            this.DataContext = p;
            this.ImageActuelle = p.Photo;
            this.onglet = onglet;
        }


        /// <summary>
        ///     Instance de Personnage qui récupère le personnage passé en paramètre dans le constructeur.
        /// </summary>
        private Personnage p = null;

        /// <summary>
        ///     Instance de OngletPersonnages qui récupère l'onglet "Personnages" passé en paramètre dans le constructeur.
        /// </summary>
        private OngletPersonnages onglet = null;


        /// <summary>
        ///     String qui récupère l'image actuelle du personnage.
        /// </summary>
        private string ImageActuelle = null;


        /// <summary>
        ///     String qui récupèrera la nouvelle image qui remplacera l'ancienne, si il y en a une choisie par l'utilisateur.
        /// </summary>
        private string NewImage = null;


        /// <summary>
        ///     Différents string permettant de récupérer le chemin source de la photo, le nom de la photo et le chemin de destination.
        /// </summary>
        private string sourcePhoto = "";
        private string nomPhoto = "";
        private string destinationPhoto = "";


        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'ouvrir un explorateur de fichier et de pouvoir changer l'image du personnage.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void ChangerImagePersonnage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
            dlg.DefaultExt = ".jpg | .png";
            dlg.Filter = "All images files (.jpg, .png)|*.jpg;*.png;*.gif|JPG files (.jpg)|*.jpg|PNG files (.png)|*.png";

            try
            {
                bool? result = dlg.ShowDialog();

                if (result.Value)
                {
                    // On récupère les informations pour copier l'image
                    this.sourcePhoto = dlg.FileName;    // Chemin d'accès à l'image
                    this.nomPhoto = dlg.SafeFileName;   // Nom de l'image sans le chemin d'accès
                    this.destinationPhoto = System.IO.Path.Combine(Directory.GetCurrentDirectory(), @"Images\", nomPhoto);  // Dossier destination où on copie l'image

                    this.NewImage = destinationPhoto;
                    ImagePerso.Source = new BitmapImage(new Uri(sourcePhoto, UriKind.Absolute));
                }
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show("Probleme d'ouverture!");
            }
        }


        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'enregistrer les modifications faites sur le personnage.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void EnregistrerModifPersonnage(object sender, RoutedEventArgs e)
        {
            if(TextBoxNomPersonnageAModif.Text == "")
            {
                MessageBox.Show("Veuillez mettre un nom de personnage!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                p.Nom = TextBoxNomPersonnageAModif.Text;
                p.DescriptionPersonnage = TextBoxDescritionPersonnageAModif.Text;

                if (NewImage != null)
                {
                    try
                    {
                        File.Copy(sourcePhoto, destinationPhoto);
                    }
                    catch (IOException io)
                    {
                        MessageBox.Show(io.Message);
                    }

                    p.Photo = NewImage;
                }
                onglet.DataGridPerso.SelectedIndex = 0;

                this.Close();
            }

        }


        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'annuler les modifications faites sur le personnage.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void AnnulerModifPersonnage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
