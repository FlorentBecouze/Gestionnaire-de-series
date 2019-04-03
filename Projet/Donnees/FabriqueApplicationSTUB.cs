using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bibli;

namespace Donnees2
{
    /// <summary>
    ///     Classe fille de 'FabriqueApplication' et qui implémente la méthode 'FabriqueAppli()'
    /// </summary>

    public class FabriqueApplicationSTUB : FabriqueApplication
    {
        /// <summary>
        ///     Méthode qui crée une application avec des séries, des saisons, des épisodes, des personnages et des commentaires et la retourne.
        /// </summary>
        /// <returns></returns>
        public override ApplicationGlobale FabriqueAppli()
        {
            ApplicationGlobale app = new ApplicationGlobale();


            Serie serie = new Serie("Flash", "Barry Allen, est un analyste dans la police de Central City, jusqu'au jour où l'accélérateur de particules, de l'entreprise StarLab, explose, et lui confère le pouvoir de courir aussi vite qu'un éclair.", "/Images/Affiche_flash.jpg");
            
            serie.Ajout(new Saison("Saison 1", "Description de la 1ère saison"), serie.ListeSaisons);
            serie.Ajout(new Saison("Saison 2", "Description de la 2ème saison"), serie.ListeSaisons);
            serie.Ajout(new Saison("Saison 3", "Description de la 3ème saison"), serie.ListeSaisons);
            serie.Ajout(new Saison("Saison 4", "Description de la 4ème saison"), serie.ListeSaisons);
            
            serie.Ajout(new Personnage("Barry Allen", "Personnage principal de la série, joué par Grant Gustin. Il est recueilli par l'ami (Joe West) de son père, quand ce dernier est accusé d'avoir assassiné sa femme. Barry est amoureux d'Iris depuis l'enfance.", "/Images/Barry_Allen.jpg"), serie.ListePersonnages);
            serie.Ajout(new Personnage("Iris West", "Soeur adoptive de Barry", "/Images/No_Photo.jpg"), serie.ListePersonnages);
            serie.Ajout(new Personnage("Francisco « Cisco » Ramon / Vibe", "Scientifique de StarLab.", "/Images/No_Photo.jpg"), serie.ListePersonnages);
            serie.Ajout(new Personnage("Caitlin Snow / Killer Frost", "Scientifique de StarLab.", "/Images/No_Photo.jpg"), serie.ListePersonnages);
            serie.Ajout(new Personnage("Dr Harrison Wells / Eobard Thawne / Negatif de Flash", "Personnage à multiples facettes dans la série.", "/Images/No_Photo.jpg"), serie.ListePersonnages);
            serie.Ajout(new Personnage("Lieutenant Joe West", "Père adoptif de Barry.", "/Images/No_Photo.jpg"), serie.ListePersonnages);

            serie.Ajout(new Commentaire("Paul", "J'adore vivement la saison 4 en VF", 5), serie.ListeCommentaires);
            serie.Ajout(new Commentaire("Pierre", "Pas assez fidèle à la BD à mon goût", 2), serie.ListeCommentaires);
            serie.Ajout(new Commentaire("Jacques", "Moyen", 3), serie.ListeCommentaires);
            serie.Ajout(new Commentaire("Eric", "Plutôt pas mal", 4), serie.ListeCommentaires);
            serie.Ajout(new Commentaire("Jean", "J'adore vivement la saison 4 en VFJ'adore vivement la saison 4 en VFJ'adore vivement la saison 4 en VFJ'adore vivement la saison 4 en VFJ'adore vivement la saison 4 en VFJ'adore vivement la saison 4 en VF", 3), serie.ListeCommentaires);


            // Ajout de 4 épisodes pour chaque Saison dans la 1ère Serie
            foreach(Composant comp in serie.collectionComposants)
            {
                if(comp.GetType() == typeof(Saison))
                {
                    Saison s = comp as Saison;
                    s.Ajout(new Episode("Episode 1", "Description du 1er épisode"), s.ListeEpisodes);
                    s.Ajout(new Episode("Episode 2", "Description du 2ème épisode"), s.ListeEpisodes);
                    s.Ajout(new Episode("Episode 3", "Description du 3ème épisode"), s.ListeEpisodes);
                    s.Ajout(new Episode("Episode 4", "Description du 4ème épisode"), s.ListeEpisodes);
                }
            }    

            app.AjouterSerie(serie);
            app.AjouterSerie("Arrow", "Description de la série Arrow", "/Images/Affiche_Arrow.jpg");
            app.AjouterSerie("NCIS", "Description de la série NCIS", "/Images/Affiche_NCIS.jpg");
            app.AjouterSerie("Sherlock Holmes", "Description de la série Sherlock Holmes", "/Images/Affiche_Sherlock.jpg");

            return app;

        }
    }
}
