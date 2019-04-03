using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace Bibli
{
    /// <summary>
    ///     Une Saison est ce que l'utilisateur va ajouter à une Serie.
    /// </summary>

    [DataContract]
    public class Saison : Composite, INotifyPropertyChanged
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="Nom">Nom de la saison ajoutée par l'utilisateur.</param>
        /// <param name="Description">Description de la saison ajoutée par l'utilisateur.</param>
        public Saison(string Nom, string Description)
        {
            this.myNom = Nom;
            this.myDescriptionSaison = Description;
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
        ///     Propriété calculée sur 'myDescriptionSaison'
        /// </summary>
        [DataMember (Order = 1)]
        public string DescriptionSaison
        {
            get { return myDescriptionSaison; }
            set
            {
                myDescriptionSaison = value;
                OnPropertyChanged("DescriptionSaison");
            }
        }
        private string myDescriptionSaison = "";


        /// <summary>
        ///     Propriété calculée qui récupère les Episodes de la liste de composants de Composite
        /// </summary>
        [DataMember(Order = 2)]
        public IEnumerable<Composant> ListeEpisodes
        {
            get
            {
                return collectionComposants.Where(comp => comp.GetType() == typeof(Episode));
            }
            set { }
        }



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
        ///     Méthode permettant l'ajout de Composant (içi seulement d'Episode) en appelant la méthode d'ajout de la classe mère.
        /// </summary>
        /// <param name="comp">Composant à ajouter à la collection.</param>
        /// <param name="liste">Liste de la classe fille (içi Saison), qui sera à nouveau chargée et ça lancera le "rechargement" des composants dans la vue.</param>
        public override void Ajout(Composant comp, IEnumerable<Composant> liste)
        {
            if (comp.GetType() == typeof(Episode))
            {
                Episode e = (Episode)comp;
                base.Ajout(e, liste);
                return;
            }
        }




        /// <summary>
        ///     Re-définition de la méthode mère 'ToString()'
        /// </summary>
        /// <returns>Retour l'affichage d'une saison complète avec ses différents composants.</returns>
        public override string ToString()
        {
            string message = "\n\t" + Nom + "\n";
            message += "\t" + DescriptionSaison + "\n";

            foreach(Composant comp in collectionComposants)
            {
                if(comp.GetType() == typeof(Episode))
                {
                    Episode e = comp as Episode;
                    message += e.ToString();
                }   
            }

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

            return this.Equals(o as Saison);
        }


        /// <summary>
        ///     Méthode appelé lors de la méthode 'Equals(object o)'
        /// </summary>
        /// <param name="other">C'est la saison que l'on essaye de comparer.</param>
        /// <returns>Retourne si oui ou non, les deux saisons sont égales.</returns>
        public bool Equals (Saison other)
        {
            return this.Nom == other.Nom;
        }
        
    }
}

