using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Bibli
{
    /// <summary>
    ///     'Composite' permet d'avoir un ensemble de 'Composant' de tous types. Ainsi toutes les classes filles et en particulier 'Serie' pourront avoir accès
    ///     à cette collection et pourra obtenir un ensemble de Saison, de Personnage et de Commentaire, comme aurai une véritable série.
    /// </summary>

    [DataContract]
    public class Composite : Composant , INotifyPropertyChanged
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        public Composite()
        {
            this.myCollectionComposants = new ObservableCollection<Composant>();
        }


        /// <summary>
        ///     Propriété calculée sur 'myCollectionComposants'
        /// </summary>
        [DataMember (Order = 0)]
        public ObservableCollection<Composant> collectionComposants
        {
            get { return myCollectionComposants; }
            set
            {
                myCollectionComposants = value;
            }
        }
        private ObservableCollection<Composant> myCollectionComposants;



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
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        
        /// <summmary>
        ///     Méthode permettant d'ajouter un Composant dans la collection et de dire grâce à la méthode 'OnPropertyChanged' à la liste de la classe fille,
        ///     qui a appelé 'Ajout', qu'elle peut à nouveau se recharger pour pouvoir afficher ce nouveau composant dans la vue.
        /// </summary>
        /// <param name="comp">Composant à ajouter dans la collection.</param>
        /// <param name="liste">Liste de la classe fille, qui sera à nouveau chargée et ça lancera le "rechargement" des composants dans la vue.</param>
        public virtual void Ajout(Composant comp, IEnumerable<Composant> liste)
        {
            collectionComposants.Add(comp);
            OnPropertyChanged("liste");
        }


    }

}
