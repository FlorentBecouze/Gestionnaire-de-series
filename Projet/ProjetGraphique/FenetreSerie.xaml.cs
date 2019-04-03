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
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.ComponentModel;

namespace ProjetGraphique
{
    /// <summary>
    ///     Fenêtre principale de notre application, où on retrouve notre Master/Details.
    /// </summary>
    public partial class FenetreSerie : Window
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        public FenetreSerie()
        {
            InitializeComponent();

            // Récupération de l'application du fichier de sauvegarde
            this.app = LectureAppli();

            // DataContext global
            this.DataContext = app;
        }


        /// <summary>
        ///     Instance de ApplicationGlobale qui récupère l'application lue dans le fichier de sauvegarde.
        /// </summary>
        public ApplicationGlobale app { get; set; } = null;


        /// <summary>
        ///    Evènement du bouton de la fenêtre permettant d'ouvrir la fenêtre 'AjoutSerie' pour pouvoir ajouter une série.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void AjouterSerie(object sender, RoutedEventArgs e)
        {
            AjoutSerie ajoutSerie = new AjoutSerie(app);
            ajoutSerie.ShowDialog();
        }


        /// <summary>
        ///    Evènement du bouton de la fenêtre permettant d'ouvrir la fenêtre 'ModifCetteSerie' pour pouvoir modifier la série sélectionnée dans le Master.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi le bouton)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à un clique.</param>
        private void ModifierCetteSerie(object sender, RoutedEventArgs e)
        {
            if (MasterSeries.SelectedItem == null) { return; }

            if (MasterSeries.SelectedItem.GetType() == typeof(Serie))
            {
                Serie se = (Serie)MasterSeries.SelectedItem;
                ModifCetteSerie modif = new ModifCetteSerie(se);
                MasterSeries.SelectedValue = false;
                modif.ShowDialog();
            }
        }



        /// <summary>
        ///     Méthode permettant de lire le fichier de sauvegarde. Utilisée dans le constructeur de 'FenetreSerie'.
        /// </summary>
        /// <returns>Retourne l'application lue.</returns>
        private ApplicationGlobale LectureAppli()
        {
            // Désignation du répertoire courrant de sauvegarde
            Directory.SetCurrentDirectory("../../");

            
            // Fichier de sauvegarde
            string xmlFile = "FichierSauvegarde.xml";
            
            // Création du sérialiseur
            DataContractSerializer serialiseur = new DataContractSerializer(typeof(ApplicationGlobale));


            ApplicationGlobale appLue = new ApplicationGlobale();


            // Création du flux de LECTURE par lequel vont passer les infos
            try
            {
                using (Stream reader = File.OpenRead(xmlFile))
                {
                    return appLue = serialiseur.ReadObject(reader) as ApplicationGlobale;
                }
            }
             catch(FileNotFoundException e)
            {
                ApplicationGlobale s = new ApplicationGlobale();
                MessageBox.Show(s.Description, "Bienvenue");
                return s;
            }

        }



        /// <summary>
        ///    Evènement du bouton de la fenêtre qui quand on ferme la fenêtre 'FenetreSerie', nous demande si l'on veut sauvegarder ce que l'on a fait ou pas.
        /// </summary>
        /// <param name="sender">C'est l'object qui a appelé l'évènement (içi la croix de fermeture de la fenêtre)</param>
        /// <param name="e">C'est une instance d'un type d'évènement qui correspond à une fermeture.</param>
        private void Fermeture(object sender, CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous sauvegarder vos modifications?", "Sauvegarde", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                app.Sauvegarder();
            }
        }
    }
}
