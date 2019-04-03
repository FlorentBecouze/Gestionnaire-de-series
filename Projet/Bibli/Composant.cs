using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace Bibli
{
    /// <summary>
    ///     'Composant' est la classe abstract mère de tous les types d'object qui sont contenus dans une série : Saison, Episode, Personnage, Commentaire
    ///     Elle a aussi une fille 'Composite' qui pourra contenir un ensemble de 'Composant'
    /// </summary>

    // Permet de dire au sérialiseur que Composant peut être de ces différents types
    [DataContract, KnownType(typeof(Saison)), KnownType(typeof(Episode)), KnownType(typeof(Personnage)), KnownType(typeof(Commentaire))]
    public abstract class Composant
    {
        /// <summary>
        ///     Constructeur
        /// </summary>
        public Composant() { }
    }

}
