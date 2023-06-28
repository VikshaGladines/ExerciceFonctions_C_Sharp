using System;

namespace ExerciceFonctions
{
    class Program
    {
         static long CalculFactorielle(long MonNombre)
         {
             if (MonNombre == 0)
             { 
                 return 1; 
             }
             else
             {
                 return MonNombre * CalculFactorielle(MonNombre - 1);
             }
           // return MonNombre == 0 ? 1 : MonNombre * CalculFactorielle(MonNombre - 1);

        }
    
        static void Main(string[] args)
        {
            Console.WriteLine();  
            Console.WriteLine("Exercice 1");
            // déclaration des 3  tableaux
            int[] Tableau1;
            int[] Tableau2;
            int[] Tableau3;
            // initialisation des 3 tableaux
            Tableau1 = new int[10];
            Tableau2 = new int[10];
            Tableau3 = new int[10];
            // boucle de 10 tour de 0 à 9 pour charger les tableaux 1 & 2 et
            // faire le calcul de chargement de 3 (addition)
            // la boucle sert aussi à l'affichage par Console.Writeline
            for (int MonCompteur=0;MonCompteur<10;MonCompteur=MonCompteur+1)
            {
                Tableau1[MonCompteur] = MonCompteur + 1;
                Tableau2[MonCompteur] = Tableau1[MonCompteur]+10;
                Tableau3[MonCompteur] = Tableau1[MonCompteur]+ Tableau2[MonCompteur];
                if (MonCompteur == 9)
                {
                    Console.WriteLine(Tableau1[MonCompteur] + " | " + Tableau2[MonCompteur] + " | " + Tableau3[MonCompteur]);
                }
                else
                {
                    Console.WriteLine(Tableau1[MonCompteur] + "  | " + Tableau2[MonCompteur] + " | " + Tableau3[MonCompteur]);
                }

            }
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine();
            Console.WriteLine("Exercice 2");

            // init des tableaux exo2
            int[] Tableau4;
            int[] Tableau5;
            int ValeurS=0;  //ititialisation de la ValeurS à 0
            // chargement des 2 tableaux de valeurs
            Tableau4 = new int[] { 6,25,35,61 };
            Tableau5 = new int[] { 12,24,46 };
            // boucles imbriquées sur les 2 tableaux pour effectuer le calcul
            // passage de toutes les valeurs de 2 pour chaque valeur de 1
            foreach (int val1 in Tableau4)// pour chaque valeur de T1
            {
                foreach (int val2 in Tableau5)//pour chaque valeur de T2
                {
                    ValeurS = ValeurS + (val1 * val2);
                }
            }
            Console.WriteLine("La valeur S calculée est : "+ValeurS); // affichage dans la Console.WriteLine();
            
            
            
            
            Console.WriteLine();
            Console.WriteLine("-------------");

            Console.WriteLine();
            Console.WriteLine("Exercice 3");
            Console.WriteLine();
            Console.WriteLine("-------------");
            Random aleatoire = new Random();
            int[] Tableau7;
            Tableau7 = new int[10];
            for (int MonCompteur=0;MonCompteur<Tableau7.Length;MonCompteur++)
            {
                Tableau7[MonCompteur] = aleatoire.Next(1,100);
            }
            Array.Sort(Tableau7);
            string StrValeurs = "";
            foreach (int Val1 in Tableau7)
            {
                
                if (StrValeurs=="")
                {
                    StrValeurs = StrValeurs + Val1;
                }
                else
                {
                    StrValeurs = StrValeurs +";"+ Val1;
                }

  
            }
            Console.WriteLine(StrValeurs);
            Console.WriteLine();
            Console.WriteLine("-------------");
           
            
            
            Console.WriteLine("Exercice 4");
            Console.WriteLine("La factorielle de 20 est : " + CalculFactorielle(20));
            Console.WriteLine();
            Console.WriteLine("-------------");
        }
    }
}
