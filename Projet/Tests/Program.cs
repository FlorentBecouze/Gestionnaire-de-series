using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importation de la bibliothèque de classes
using Bibli;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tests sur console


            // Tests sur "Application"
            
            Application app = new Application("description de l'application");
           
            //Uri affiche = "U:\\Projet C#\\Projet\\Images\\Affiche_Arrow.jpg";

         /*   Console.WriteLine("Donnez le nom de la nouvelle série : ");
            string Nom = Console.ReadLine();
            Console.WriteLine("Donnez la description de la nouvelle série : ");
            string Description = Console.ReadLine();
            Console.WriteLine("Donnez le chemin d'acces vers l'image");
          
            
            app.AjoutSerie(Nom, Description);

            Console.WriteLine("Donnez le nom de la nouvelle série : ");
            string Nom2 = Console.ReadLine();
            Console.WriteLine("Donnez la description de la nouvelle série : ");
            string Description2 = Console.ReadLine();
            Console.WriteLine("Donnez le chemin d'acces vers l'image");




            app.AjoutSerie(Nom2, Description2);

            List<Serie> li = app.RecupListe();

            foreach (Serie s in li)
            {
                Console.WriteLine();
                Console.WriteLine(s.GetNom());
                Console.WriteLine(s.GetDesc());
                Console.WriteLine();
            }


            // Modification d'une série
            Serie serieAModif = new Serie("Flash", "coucou");
            app.ModifierSerie(serieAModif, "Flash 2", "nouvelle description pour Flash");

            List<Serie> li2 = app.RecupListe();

            foreach (Serie s in li2)
            {
                Console.WriteLine();
                Console.WriteLine(s.GetNom());
                Console.WriteLine(s.GetDesc());
                Console.WriteLine();
            }

           
                        // La série se supprime car elle est égale à une qui est déjà dans la liste
                        app.SupprimerSerie(new Serie("Flash 2", "nouvelle description pour Flash"));

                        
                        List<Serie> li3 = app.RecupListe();

                        foreach (Serie s in li3)
                        {
                            Console.WriteLine();
                            Console.WriteLine(s.GetNom());
                            Console.WriteLine(s.GetDesc());
                            Console.WriteLine();
                        }*/





            // Tests sur "Series"
           Serie ser = new Serie("Archer", "jsp");
                          // Tests sur "commentaire
           Console.WriteLine("Donnez votre nom :");
           string NomC = Console.ReadLine();
           Console.WriteLine("Donnez votre avis sur le Serie");
           string Commentaire = Console.ReadLine();
           Console.WriteLine("Donnez la note du serie (0-5)");
           int Note = Console.Read();
           if(Note>5)
           {
           Console.WriteLine("il faut donner une note entre 0 et 5 !!! note changé à 5");
           }
           if(Note<0)
           {
           Console.WriteLine("il faut donner une note entre 0 et 5 !!! note changé à 5");
           }

           ser.AjouterCommentaire(NomC, Commentaire, Note);

           List<Commentaire> li4 = ser.recupListCommentaires();

           foreach (Commentaire t in li4)
           {
          Console.WriteLine();
          Console.WriteLine(t.getNomC());
          Console.WriteLine(t.GetTexte());
          Console.Write(t.GetNote()); //Pour une raison elle me donne a chaque fois 52 comme valeur
          Console.WriteLine();
            }             

                //Tests sur "saisons"

          Console.WriteLine("Donnez le nom du Saison");
          string nom = Console.ReadLine();
          Console.WriteLine("Donnez une description du Saison");
          string DescriptionSais = Console.ReadLine();
          ser.AjouterSaison(nom, DescriptionSais);

        }
    }
}
