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
    ///     Un Personnage est ce que l'utilisateur va ajouter à une Serie.
    /// </summary>

    [DataContract]
    public class Personnage : Composite, INotifyPropertyChanged
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="Nom">Nom du personnage que l'utilisateur va ajouter.</param>
        /// <param name="Description">Description du personnage que l'utilisateur va ajouter.</param>
        /// <param name="ImageSource">Image du personnage que l'utilisateur va ajouter.</param>
        public Personnage(string Nom, string Description, string ImageSource)
        {
            this.myNom = Nom;
            this.myDescriptionPersonnage = Description;
            this.myPhoto = ImageSource;
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
        ///     Propriété calculée sur 'myDescriptionPersonnage'
        /// </summary>
        [DataMember (Order = 1)]
        public string DescriptionPersonnage
        {
            get { return myDescriptionPersonnage; }
            set
            {
                myDescriptionPersonnage = value;
                OnPropertyChanged("DescriptionPersonnage");
            }
        }
        private string myDescriptionPersonnage = "";



        /// <summary>
        ///     Propriété calculée sur 'myPhoto'
        /// </summary>
        [DataMember (Order = 2)]
        public string Photo
        {
            get { return myPhoto; }
            set
            {
                myPhoto = value;
                OnPropertyChanged("Photo");
            }
        }
        private string myPhoto = "";



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
        /// <returns>Retour l'affichage d'un personnage complet avec ses différents composants.</returns>
        public override string ToString()
        {
            string message = "\n\n\t\t" + Nom + "\n";
            message += "\t\t" + DescriptionPersonnage + "\n";
            message += "\t\t" + Photo + "\n";

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
            return this.Equals(o as Personnage);
        }


        /// <summary>
        ///     Méthode appelé lors de la méthode 'Equals(object o)'
        /// </summary>
        /// <param name="other">C'est le personnage que l'on essaye de comparer.</param>
        /// <returns>Retourne si oui ou non, les deux personnages sont égaux.</returns>
        public bool Equals(Personnage other)
        {
            return this.Nom == other.Nom;
        }

    }
}
