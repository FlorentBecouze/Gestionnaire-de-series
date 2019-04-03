using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Windows.Forms;

namespace Bibli
{
    /// <summary>
    ///     ApplicationGlobale est ce que l'on pourrait dire, la classe "mère"/ de base de notre application, puisque c'est elle qui possède la liste des séries.
    /// </summary>

    // Permet de dire au sérialiseur que ApplicationGlobale doit connaître le type Serie pour pouvoir sérialiser Composant correctement
    [DataContract, KnownType(typeof(Serie))]
    public class ApplicationGlobale : INotifyPropertyChanged
    {
        /// <summary>
        ///     Contructeur
        /// </summary>
        public ApplicationGlobale()
        {
            ListeComposantsApp = new ObservableCollection<Composant>();
        }


        /// <summary>
        ///     C'est la description que l'on peut faire de notre application.
        ///     Elle ne s'affiche seulement que lors de la 1ère ouverture de l'application, là où elle ne possède encore aucune série.
        /// </summary>
        [DataMember (Order = 0)]
        public string Description { get; private set; } = "Bienvenue sur cette application qui va vous permettre de gérer toutes vos séries préférées.\nVous pourrez y ajouter vos séries ainsi que toutes les saisons et toutes les informations sur les personnages et sur les épisodes que vous voulez.\nVous pourrez même donner vos ressentis sur la série, en mettant un petit commentaire et une note.\nVous pourriez aussi demander à vos amis de donner leurs avis et voir si vous avez les mêmes goûts au niveau des séries.";



        /// <summary>
        ///     Propriété calculée sur 'myListeComposantsApp'.
        ///     Elle contient l'ensemble des séries (qui sont des composants) de l'application.
        /// </summary>
        [DataMember (Order = 1)]
        public ObservableCollection<Composant> ListeComposantsApp
        {
            get { return myListeComposantsApp; }
            private set { myListeComposantsApp = value; }
        }
        private ObservableCollection<Composant> myListeComposantsApp;



        /// <summary>
        ///     Evènement lancé par la méthode 'OnPropertyChanged' (implémenté de l'interface 'INotifyPropertyChanged') lorsque les propriétés calculées changent.
        ///     La vue se ré-actualise.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        ///     Cette méthode lance l'évènement 'PropertyChanged'
        /// </summary>
        /// <param name="propertyName">Nom de la propriété calculée qui appelle cette méthode.</param>
        public void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        /// <summary>
        ///     Méthode permettant d'ajouter une série dans la collection de composants de l'application. Une série est aussi un composant.
        /// </summary>
        /// <param name="Nom">Nom de la série à ajouter.</param>
        /// <param name="Description">Description de la série à ajouter.</param>
        /// <param name="Photo">Photo de la série à ajouter.</param>
        public void AjouterSerie(string Nom, string Description, string Photo)
        {
            ListeComposantsApp.Add(new Serie(Nom, Description, Photo));
        }


        /// <summary>
        ///     Méthode permettant d'ajouter un object de type 'Serie', passé en paramètre.
        /// </summary>
        /// <param name="s">Série passée en paramètre qui sera ajoutée à la collection.</param>
        public void AjouterSerie(Serie s)
        {
            ListeComposantsApp.Add(s);
        }



        /// <summary>
        ///     Sauvegarde de l'application dans un fichier XML.
        /// </summary>
        public void Sauvegarder()
        {
            // Fichier de sauvegarde
            string xmlFile = "FichierSauvegarde.xml";


            // Création du sérialiseur
            DataContractSerializer serialiseur = new DataContractSerializer(typeof(ApplicationGlobale));


            // Paramètres du flux d'écriture
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };

            // Création du flux d'ECRITURE par lequel vont passer les infos
            using (XmlWriter writer = XmlWriter.Create(xmlFile, settings))
            {
                serialiseur.WriteObject(writer, this);
            }
        }



        /// <summary>
        ///     Re-définition de la méthode mère 'ToString()'
        /// </summary>
        /// <returns>Retour l'affichage de l'application complète avec ses différents composants.</returns>
        public override string ToString()
        {
            string message = Description + "\n\n";
            message += "Voici la liste des différentes séries et leurs composants :\n";
            foreach (Serie s in ListeComposantsApp)
            {
                message += "\n" + s.ToString() + "\n";
            }
            return message;
        }
    }
}
