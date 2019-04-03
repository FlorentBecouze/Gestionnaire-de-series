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
    ///     Une Serie est ce que l'utilisateur va ajouter à l'ApplicationGlobale.
    /// </summary>

    [DataContract]
    public class Serie : Composite, INotifyPropertyChanged
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="Nom">Nom de la série ajoutée par l'utilisateur.</param>
        /// <param name="Description">Description de la série ajoutée par l'utilisateur.</param>
        /// <param name="ImageSource">Image de la série ajoutée par l'utilisateur.</param>
        public Serie(string Nom, string Description, string ImageSource)
        {
            this.myNom = Nom;
            this.myDescriptionSerie = Description;
            this.myAffiche = ImageSource;
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
        ///     Propriété calculée sur 'myDescriptionSerie'
        /// </summary>
        [DataMember (Order = 1)]
        public string DescriptionSerie
        {
            get { return myDescriptionSerie; }
            set
            {
                myDescriptionSerie = value;
                OnPropertyChanged("DescriptionSerie");
            }
        }
        private string myDescriptionSerie = "";


        /// <summary>
        ///     Propriété calculée sur 'myAffiche'
        /// </summary>
        [DataMember (Order = 2)]
        public string Affiche
        {
            get { return myAffiche; }
            set
            {
                myAffiche = value;
                OnPropertyChanged("Affiche");
            }
        }
        private string myAffiche = "";



        /// <summary>
        ///     Propriété calculée qui récupère les Saisons de la liste de composants de Composite
        /// </summary>
        [DataMember(Order = 4)]
        public IEnumerable<Composant> ListeSaisons
        {
            get
            {
                return collectionComposants.Where(comp => comp.GetType() == typeof(Saison));               
            }
            set { }
        }


        /// <summary>
        ///     Propriété calculée qui récupère les Personnages de la liste de composants de Composite
        /// </summary>
        [DataMember(Order = 5)]
        public IEnumerable<Composant> ListePersonnages
        {
            get
            {
                return collectionComposants.Where(comp => comp.GetType() == typeof(Personnage));
            }
            set { }
        }


        /// <summary>
        ///     Propriété calculée qui récupère les Commentaires de la liste de composants de Composite
        /// </summary>
        [DataMember(Order = 6)]
        public IEnumerable<Composant> ListeCommentaires
        {
            get
            {
                return collectionComposants.Where(comp => comp.GetType() == typeof(Commentaire));
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
        ///     Méthode permettant l'ajout de Composant (içi de Saison, de Personnage ou de Commentaire) en appelant la méthode d'ajout de la classe mère.
        /// </summary>
        /// <param name="comp">Composant à ajouter à la collection.</param>
        /// <param name="liste">Liste de la classe fille (içi Serie), qui sera à nouveau chargée et ça lancera le "rechargement" des composants dans la vue.</param>
        public override void Ajout(Composant comp, IEnumerable<Composant> liste)
        {
            if(comp.GetType() == typeof(Saison))
            {
                Saison s = comp as Saison;
                base.Ajout(s, liste);

                return;
            }

            if (comp.GetType() == typeof(Personnage))
            {
                Personnage p = comp as Personnage;
                base.Ajout(p, liste);

                return;
            }

            if (comp.GetType() == typeof(Commentaire))
            {
                Commentaire c = comp as Commentaire;
                base.Ajout(c, liste);

                return;
            }
        }




        /// <summary>
        ///     Re-définition de la méthode mère 'ToString()'
        /// </summary>
        /// <returns>Retour l'affichage d'une série complète avec ses différents composants.</returns>
        public override string ToString()
        {
            string message = Nom + "\n";
            message += DescriptionSerie + "\n";
            message += Affiche + "\n";

            foreach(Composant comp in collectionComposants)
            {
                if(comp.GetType() == typeof(Saison))
                {
                    Saison s = comp as Saison;
                    message += s.ToString();
                }
                
            }

            message += "\n\n\tListe des personnages de la série :";

            foreach(Composant comp in collectionComposants)
            {
                if (comp.GetType() == typeof(Personnage))
                {
                    Personnage p = comp as Personnage;
                    message += p.ToString();
                }
            }

            message += "\n\n\tListe des commentaires de la série :";

            foreach(Composant comp in collectionComposants)
            {
                if (comp.GetType() == typeof(Commentaire))
                {
                    Commentaire c = comp as Commentaire;
                    message += c.ToString();
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
            if(object.ReferenceEquals(o, null))
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
            return this.Equals(o as Serie);
        }


        /// <summary>
        ///     Méthode appelé lors de la méthode 'Equals(object o)'
        /// </summary>
        /// <param name="other">C'est la série que l'on essaye de comparer.</param>
        /// <returns>Retourne si oui ou non, les deux séries sont égales.</returns>
        public bool Equals(Serie other)
        {
            return this.Nom == other.Nom;
        }

    }
}