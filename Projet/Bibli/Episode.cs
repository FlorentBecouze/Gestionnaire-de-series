using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Runtime.Serialization;

namespace Bibli
{
    /// <summary>
    ///     Un Episode est ce que l'utilisateur va ajouter dans une Saison.
    /// </summary>

    [DataContract]
    public class Episode : Composite, INotifyPropertyChanged
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="Nom">Nom de l'épisode à ajouter.</param>
        /// <param name="Description">Description de l'épisode à ajouter.</param>
        public Episode(string Nom, string Description)
        {
            this.myNom = Nom;
            this.myDescriptionEpisode = Description;
        }


        /// <summary>
        ///     Propriété calculée sur 'myNom'
        /// </summary>
        [DataMember (Order = 0)]
        public string Nom
        {
            get { return myNom; }
            set
            {
                myNom = value;
                OnPropertyChanged("Nom");
            }
        }
        private string myNom = "";


        /// <summary>
        ///     Propriété calculée sur 'myDescriptionEpisode'
        /// </summary>
        [DataMember (Order = 1)]
        public string DescriptionEpisode
        {
            get { return myDescriptionEpisode; }
            set
            {
                myDescriptionEpisode = value;
                OnPropertyChanged("DescriptionEpisode");
            }
        }
        private string myDescriptionEpisode = "";



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
        ///     Re-définition de la méthode mère 'ToString()'
        /// </summary>
        /// <returns>Retour l'affichage d'un épisode complet avec ses différents composants.</returns>
        public override string ToString()
        {
            string message = "\n\t\t" + Nom + "\n";
            message += "\t\t" + DescriptionEpisode + "\n";

            return message;
        }



        /// <summary>
        ///     Re-définition de la méthode mère 'Equals()'
        /// </summary>
        /// <param name="o">o est l'object que l'on essaye de comparer avec celui qui a appelé la méthode.</param>
        /// <returns>Retourne si oui ou non, les deux object sont égaux.</returns>
        public override bool Equals(object o)
        {
            if (object.ReferenceEquals(o, null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, o))
            {
                return true;
            }
            if (this.GetType() != o.GetType())
            {
                return false;
            }
            return this.Equals(o as Episode);
        }


        /// <summary>
        ///     Méthode appelé lors de la méthode 'Equals(object o)'
        /// </summary>
        /// <param name="other">C'est l'épisode que l'on essaye de comparer.</param>
        /// <returns>Retourne si oui ou non, les deux épisodes sont égaux.</returns>
        public bool Equals(Episode other)
        {
            return this.Nom == other.Nom;
        }

    }
}
