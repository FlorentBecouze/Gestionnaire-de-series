using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importation des bibliothèques de classes
using Bibli;
using Donnees2;

using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;
using System.Xml;
using System.Collections.ObjectModel;

namespace Tests
{
    /// <summary>
    ///     Classe permettant de tester l'application sur la console.
    /// </summary>
    public class ProgramConsole
    {
        /// <summary>
        ///     Méthode de tests.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Tests sur console

            // 1ers tests
            //// Tests sur "Application"

            //ApplicationGlobale app1 = new FabriqueApplicationVide().FabriqueAppli();

            //ApplicationGlobale app2 = new FabriqueApplicationSTUB().FabriqueAppli();

            //Console.WriteLine("\n----Toutes les series----\n");

            //List<Serie> liste1 = app1.ListeSeries;

            //foreach (Serie s in liste1)
            //{
            //    Console.WriteLine("\n" + s.Nom);
            //    Console.WriteLine(s.DescriptionSerie + "\n");
            //}

            //List<Serie> liste2 = app2.ListeSeries;

            //foreach (Serie s in liste2)
            //{
            //    Console.WriteLine("\n" + s.Nom);
            //    Console.WriteLine(s.DescriptionSerie + "\n");
            //}





            //// Tests sur "Serie"

            //Serie serie1 = new FabriqueSerieVide().FabriqueS();

            //Serie serie2 = new FabriqueSerieSTUB().FabriqueS();

            //List<Saison> listeSaisons1 = serie2.ListeSaisons;

            //Console.WriteLine("----Toutes les saisons + épisodes----");

            //foreach (Saison s in listeSaisons1)
            //{
            //    Console.WriteLine("\n" + s.Nom);
            //    Console.WriteLine(s.DescriptionSaison + "\n");

            //    foreach (Episode e in s.ListeEpisodes)
            //    {
            //        Console.WriteLine("\t" + e.Nom);
            //        Console.WriteLine("\t" + e.DescriptionEpisode + "\n");
            //    }
            //}

            //List<Personnage> listePersonnages1 = serie2.ListePersonnages;

            //Console.WriteLine("----Tous les personnages----");

            //foreach (Personnage p in listePersonnages1)
            //{
            //    Console.WriteLine("\n" + p.Nom);
            //    Console.WriteLine(p.DescriptionPersonnage + "\n");
            //}

            //Console.WriteLine("----Tous les commentaires----");

            //List<Commentaire> listeCommentaires1 = serie2.ListeCommentaires;

            //foreach (Commentaire c in listeCommentaires1)
            //{
            //    Console.WriteLine("\n" + c.Nom);
            //    Console.WriteLine(c.Texte);
            //    Console.WriteLine(c.Note + "\n");
            //}

            //Console.WriteLine($"Note Moyenne : {serie2.NoteMoyenne}/5\n");




            //// Saisons

            //Console.WriteLine("\n----Ajout Saison----\n");
            //Console.WriteLine("Donnez le nom de la saison :");
            //string nom = Console.ReadLine();

            //Console.WriteLine("Donnez une description de la saison :");
            //string DescriptionSaison = Console.ReadLine();

            //serie2.Ajout(new Saison(nom, DescriptionSaison));

            //List<Saison> listeSaisons2 = serie2.ListeSaisons;

            //foreach (Saison s in listeSaisons2)
            //{
            //    Console.WriteLine("\n" + s.Nom);
            //    Console.WriteLine(s.DescriptionSaison + "\n");
            //}


            //// Personnages

            //Console.WriteLine("\n----Ajout Personnage----\n");
            //Console.WriteLine("Donnez le nom du personnage :");
            //string nomPerso = Console.ReadLine();

            //Console.WriteLine("Donnez un description du personnage :");
            //string descriptionPerso = Console.ReadLine();

            //serie2.Ajout(new Personnage(nomPerso, descriptionPerso, ""));

            //List<Personnage> listePersonnages2 = serie2.ListePersonnages;

            //foreach (Personnage p in listePersonnages2)
            //{
            //    Console.WriteLine("\n" + p.Nom);
            //    Console.WriteLine(p.DescriptionPersonnage + "\n");
            //}


            //// Commentaires

            //Console.WriteLine("\n----Ajout Commentaire----\n");
            //Console.WriteLine("Donnez votre nom :");
            //string NomC = Console.ReadLine();

            //Console.WriteLine("Donnez votre avis sur la série :");
            //string Commentaire = Console.ReadLine();

            //Console.WriteLine("Donnez la note de la série (0-5) :");
            //string NoteLue = Console.ReadLine();
            //int Note;

            //if (NoteLue == "")
            //{
            //    Console.WriteLine("Veuillez rentrez une note comprise en 0 et 5!!\n");
            //    return;
            //}

            //// Permet de convertir une chaine de caractère en entier
            //if (int.TryParse(NoteLue, out Note))
            //{
            //}
            //else
            //{
            //    Console.WriteLine("Problème lors de la conversion de la note!!\n");
            //    return;
            //}

            //if (Note < 0)
            //{
            //    Console.WriteLine("Il faut donner une note entre 0 et 5. Note modifiée à 0 !!");
            //    serie2.Ajout(new Commentaire(NomC, Commentaire, 0));
            //}
            //else if (Note > 5)
            //{
            //    Console.WriteLine("Il faut donner une note entre 0 et 5. Note modifiée à 5 !!");
            //    serie2.Ajout(new Commentaire(NomC, Commentaire, 5));
            //}
            //else
            //{
            //    serie2.Ajout(new Commentaire(NomC, Commentaire, Note));
            //}


            //List<Commentaire> listeCommentaires2 = serie2.ListeCommentaires;


            //foreach (Commentaire t in listeCommentaires2)
            //{
            //    Console.WriteLine("\n" + t.Nom);
            //    Console.WriteLine(t.Texte);
            //    Console.Write(t.Note + "\n");
            //}
            //Console.WriteLine($"\nNote Moyenne : {serie2.NoteMoyenne}/5\n");



            //Console.WriteLine("\n----Suppression d'une Saison----\n");
            //// La description peut être différente, car 'Equals' gère seulement le Nom de la Saison.
            //serie2.Supprimer(new Saison("Saison 1", "DescriptionPersonnage de la 1ère saison"));

            //foreach (Saison s in listeSaisons2)
            //{
            //    Console.WriteLine("\n" + s.Nom);
            //    Console.WriteLine(s.DescriptionSaison + "\n");
            //}



            ////Console.WriteLine("\n----Suppression d'un Personnage----\n");
            ////// La description peut être différente, car 'Equals' gère seulement le Nom du Personnage.
            ////serie2.Supprimer(new Personnage("Iris West", "Soeur adoptive de Barry", ""));

            ////foreach (Personnage p in listePersonnages2)
            ////{
            ////    Console.WriteLine("\n" + p.Nom);
            ////    Console.WriteLine(p.DescriptionPersonnage + "\n");
            ////}



            //Console.WriteLine("\n----Suppression d'un Episode----\n");

            //List<Episode> listeEpisodes = serie2.ListeSaisons[0].ListeEpisodes;

            //foreach (Episode e in listeEpisodes)
            //{
            //    Console.WriteLine("\n" + e.Nom);
            //    Console.WriteLine(e.DescriptionEpisode + "\n");
            //}
            //Console.WriteLine("\n");

            //// La description peut être différente, car 'Equals' gère seulement le Nom de l'Episode.
            //serie2.ListeSaisons[0].Supprimer(new Episode("Episode 1", "DescriptionPersonnage du 1er épisode"));
            //// Autre méthode --> serie2.listeSaisons[0].Supprimer(serie2.listeSaisons[0].listeEpisodes[0]);

            //listeEpisodes = serie2.ListeSaisons[0].ListeEpisodes;

            //foreach (Episode e in listeEpisodes)
            //{
            //    Console.WriteLine("\n" + e.Nom);
            //    Console.WriteLine(e.DescriptionEpisode + "\n");
            //}



            //Console.WriteLine("\n----Suppression d'une Série----\n");

            //List<Serie> listeSeries1 = app2.ListeSeries;

            //foreach (Serie s in listeSeries1)
            //{
            //    Console.WriteLine("\n" + s.Nom);
            //    Console.WriteLine(s.DescriptionSerie + "\n");
            //}

            //// La description peut être différente, car 'Remove' gère seulement le Nom de la Série.
            //app2.Supprimer(new Serie("Flash", "DescriptionPersonnage de la série Flash", ""));

            //List<Serie> listeSeries2 = app2.ListeSeries;

            //foreach (Serie s in listeSeries2)
            //{
            //    Console.WriteLine("\n" + s.Nom);
            //    Console.WriteLine(s.DescriptionSerie + "\n");
            //}






            // 2èmes tests


            ApplicationGlobale app = new FabriqueApplicationSTUB().FabriqueAppli();

            

            // Sauvegarde

            // Désignation du répertoire courrant de sauvegarde
            Directory.SetCurrentDirectory("../../");


            // Fichier de sauvegarde
            string xmlFile = "FichierSauvegarde.xml";


            // Création du sérialiseur
            DataContractSerializer serialiseur = new DataContractSerializer(typeof(ApplicationGlobale));


            // Création du flux d'ECRITURE par lequel vont passer les infos
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };

            using (XmlWriter writer = XmlWriter.Create(xmlFile, settings))
            {
                serialiseur.WriteObject(writer, app);
            }


            ApplicationGlobale appLue = new ApplicationGlobale();


            //// Création du flux de LECTURE par lequel vont passer les infos

            using (Stream reader = File.OpenRead(xmlFile))
            {
                appLue = serialiseur.ReadObject(reader) as ApplicationGlobale;
            }

            Console.WriteLine(appLue);

        }


    }
}
