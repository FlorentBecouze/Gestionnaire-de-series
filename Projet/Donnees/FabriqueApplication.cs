using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bibli;

namespace Donnees2
{
    /// <summary>
    ///     Classe abstract qui aura une fille et qui créera une application et la retournera.
    /// </summary>

    public abstract class FabriqueApplication
    {
        /// <summary>
        ///     Méthode abstract qui sera re-définie dans la classe fille.
        /// </summary>
        /// <returns>Elle retournera une ApplicationGlobale</returns>
        public abstract ApplicationGlobale FabriqueAppli();
    }
}
