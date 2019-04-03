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
using Microsoft.Win32;
using System.IO;

namespace ProjetGraphique
{
    /// <summary>
    ///     Fenêtre de modification d'une série sélectionnée.
    /// </summary>
    public partial class ModifCetteSerie : Window
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="s">C'est la série que l'on veut modifier.</param>
        public ModifCetteSerie(Serie s)
        {
            InitializeComponent();
            this.DataContext = s;
            this.s = s;
            this.ImageActuelle = s.Affiche;
        }

        /// <summary>
        ///     Instance de Serie qui récupère la série passée en paramètre dans le constructeur.
        /// </summary>
        private Serie s = null;


        /// <summary>
        ///     String qui récupère l'image actuelle de la série.
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
        ///     Evènement du bouton de la fenêtre permettant d'ouvrir un explorateur de fichier et de pouvoir changer l'image de la série.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void ChangerImageSerie(object sender, RoutedEventArgs e)
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
                    ImageSerie.Source = new BitmapImage(new Uri(sourcePhoto, UriKind.Absolute));
                }
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show("Probleme d'ouverture!");
            }
        }


        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'enregistrer les modifications faites sur la série.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void EnregistrerModifSerie(object sender, RoutedEventArgs e)
        {
            if(TextBoxNomSerieAModif.Text == "")
            {
                MessageBox.Show("Veuillez mettre un nom de série!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                s.Nom = TextBoxNomSerieAModif.Text;
                s.DescriptionSerie = TextBoxDescritionSerieAModif.Text;

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

                    s.Affiche = NewImage;
                }

                this.Close();
            }

        }


        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'annuler les modifications faites sur la série.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void AnnulerModifSerie(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
