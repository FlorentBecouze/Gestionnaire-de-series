using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    ///     Fenêtre d'ajout d'une série.
    /// </summary>
    public partial class AjoutSerie : Window
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="a">C'est l'application dans laquelle on veut ajouter la série.</param>
        public AjoutSerie(ApplicationGlobale a)
        {
            InitializeComponent();
            this.app = a;
        }


        /// <summary>
        ///     Instance de ApplicationGlobale qui récupère l'application passée en paramètre dans le constructeur.
        /// </summary>
        private ApplicationGlobale app = null;

        /// <summary>
        ///     String qui récupèrera la nouvelle image, si il y en a une choisie par l'utilisateur.
        /// </summary>
        private string Image = null;


        /// <summary>
        ///     Différents string permettant de récupérer le chemin source de la photo, le nom de la photo et le chemin de destination.
        /// </summary>
        private string sourcePhoto = "";
        private string nomPhoto = "";
        private string destinationPhoto = "";



        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'ouvrir un explorateur de fichier et d'y choisir l'image de la nouvelle série.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void ImageNewSerie(object sender, RoutedEventArgs e)
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

                    this.Image = destinationPhoto;
                    ImagePerso.Source = new BitmapImage(new Uri(sourcePhoto, UriKind.Absolute));
                }
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show("Probleme d'ouverture!");
            }
        }


        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'enregistrer la nouvelle série.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void EnregistrerNewSerie(object sender, RoutedEventArgs e)
        {
            string nom = TextBoxNomNewSerie.Text;
            string description = TextBoxDescritionNewSerie.Text;
            string photoAMettre = destinationPhoto;

            if(TextBoxNomNewSerie.Text == "")
            {
                MessageBox.Show("Veuillez mettre un nom de série!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (Image != null)
                {
                    try
                    {
                        File.Copy(sourcePhoto, destinationPhoto);
                    }
                    catch (IOException io)
                    {
                        MessageBox.Show(io.Message);
                    }

                    Serie s = new Serie(nom, description, photoAMettre);
                    app.AjouterSerie(s);
                }
                else
                {
                    Serie s = new Serie(nom, description, "/Images/No_Photo.jpg");
                    app.AjouterSerie(s);
                }

                this.Close();
            }
            
        }


        /// <summary>
        ///     Evènement du bouton de la fenêtre permettant d'annuler l'enregistrement de la nouvelle série.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void AnnulerNewSerie(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
