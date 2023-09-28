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
            double C, A;
            
            Console.WriteLine("Quel est votre nom?");
            nom = Console.ReadLine();
            Console.WriteLine("Bienvenue " + nom + "!");
            essai:
            Console.WriteLine("Si vous voulez convertir de $ca à $us, tapez 'C'. Pour convertir de $us à $ca, tapez 'A'.");
            demande = Console.ReadLine();
            if (demande == "C" || demande == "c")
            {

                Console.WriteLine("Quel est la valeur de votre montant en $ca?");
                C = Convert.ToDouble(Console.ReadLine());

                A = C * 0.74;
              
                Console.WriteLine("Votre montant en $us est: " + A + "$.");

            }
            else if (demande == "A" || demande == "a")
            {
                Console.WriteLine("Quel est la valeur de votre montant en $us?");
                A = Convert.ToDouble(Console.ReadLine());
                C = A / 0.74;
                Console.WriteLine($"Votre montant en $ca est: {C}$.");
            }
            else
            {

                Console.WriteLine("Je n'ai pas compris votre demande.");
                goto essai;
            }


            Console.ReadKey();
        }
    }
}
