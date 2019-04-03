using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace Bibli
{
    /// <summary>
    ///     Un Commentaire est ce que l'utilisateur ou une personne tierce pourra ajouter pour donner son avis sur une série.
    /// </summary>

    [DataContract]
    public class Commentaire : Composite
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="Nom">Nom de la personne qui va ajouter le commentaire.</param>
        /// <param name="Texte">Commentaire de la personne qui va ajouter le commentaire.</param>
        /// <param name="Note">Note de la personne qui va ajouter le commentaire.</param>
        public Commentaire(string Nom, string Texte, int Note)
        {
            this.myNom = Nom;
            this.myTexte = Texte;
            this.myNote = Note;
        }



        /// <summary>
        ///     Propriété calculée sur 'myNom'.
        /// </summary>
        [DataMember (Order = 0)]
        public string Nom
        {
            get { return myNom; }
            set { myNom = value; }
        }
        private string myNom = "";



        /// <summary>
        ///     Propriété calculée sur 'myTexte'.
        /// </summary>
        [DataMember (Order = 1)]
        public string Texte
        {
            get { return myTexte; }
            set { myTexte = value; }
        }
        private string myTexte = "";



        /// <summary>
        ///     Propriété calculée sur 'myNote'.
        /// </summary>
        [DataMember (Order = 2)]
        public int Note
        {
            get { return myNote; }
            set { myNote = value; }
        }
        private int myNote = 0;




        /// <summary>
        ///     Re-définition de la méthode mère 'ToString()'
        /// </summary>
        /// <returns>Retour l'affichage d'un commentaire complet avec ses différents composants.</returns>
        public override string ToString()
        {
            string message = "\n\t\t" + Nom + "\n";
            message += "\t\t" + Texte + "\n";
            message += "\t\t" + "Note : " + Note + "\n";

            return message;
        }

    }
}
