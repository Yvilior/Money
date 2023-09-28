using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string nom, demande;
            double C, A, E;
            
            Console.WriteLine("Quel est votre nom?");
            nom = Console.ReadLine();
            Console.WriteLine("Bienvenue " + nom + "!");
            essai1:
            Console.WriteLine("Si vous voulez convertir depuis $ca, tapez 'C'. Pour convertir depuis $us, tapez 'A'. Pour convertir depuis Euro, tapez 'E'.");
            demande = Console.ReadLine();
            if (demande == "C" || demande == "c")
            {
                essai2:
                Console.WriteLine("Vous voulez convertir vers qu'elle monaie? ('A' pour $us, 'E' pour Euro)");
                demande = Console.ReadLine();
                if(demande == "A" || demande == "a")
                {

                    Console.WriteLine("Quel est la valeur de votre montant en $ca?");
                    C = Convert.ToDouble(Console.ReadLine());

                    A = C * 0.74;

                    Console.WriteLine("Votre montant en $us est: " + A + "$.");

                }
                else if (demande == "E" || demande == "e")
                {

                    Console.WriteLine("Quel est la valeur de votre montant en $ca?");
                    C = Convert.ToDouble(Console.ReadLine());
                    E = C * 0.70;
                    Console.WriteLine($"Votre montant en Euro est: {E}Euros.");

                }
                else
                {

                    Console.WriteLine("Je n'ai pas compris votre demande.");
                    goto essai2;
                }
            }
            else if (demande == "A" || demande == "a")
            {
                essai3:
                Console.WriteLine("Vous voulez convertir vers qu'elle monaie? ('C' pour $ca, 'E' pour Euro)");
                demande = Console.ReadLine();
                if (demande == "C" || demande == "c")
                {

                    Console.WriteLine("Quel est la valeur de votre montant en $us?");
                    A = Convert.ToDouble(Console.ReadLine());
                    C = A / 0.74;
                    Console.WriteLine($"Votre montant en $ca est: {C}$.");

                }
                else if (demande == "E" || demande == "e")
                {

                    Console.WriteLine("Quel est la valeur de votre montant en $us?");
                    A = Convert.ToDouble(Console.ReadLine());
                    E = A * 0.70;
                    Console.WriteLine($"Votre montant en Euro est: {E}Euros.");

                }
                else
                {

                    Console.WriteLine("Je n'ai pas compris votre demande.");
                    goto essai3;
                }              
            }
            else if (demande == "E" || demande == "e")
            {
                essai4:
                Console.WriteLine("Vous voulez convertir vers qu'elle monaie? ('A' pour $us, 'C' pour $ca)");
                demande = Console.ReadLine();
                if (demande == "A" || demande == "a")
                {

                    Console.WriteLine("Quel est la valeur de votre montant en Euro?");
                    E = Convert.ToDouble(Console.ReadLine());

                    A = E / 0.95;

                    Console.WriteLine("Votre montant en $us est: " + A + "$.");

                }
                else if (demande == "C" || demande == "c")
                {

                    Console.WriteLine("Quel est la valeur de votre montant en Euro?");
                    E = Convert.ToDouble(Console.ReadLine());
                    C = E / 0.70;
                    Console.WriteLine($"Votre montant en $ca est: {C}$.");

                }
                else
                {

                    Console.WriteLine("Je n'ai pas compris votre demande.");
                    goto essai4;
                }
            }
            else
            {

                Console.WriteLine("Je n'ai pas compris votre demande.");
                goto essai1;
            }


            Console.ReadKey();
        }
    }
}
