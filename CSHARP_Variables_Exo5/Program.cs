using System;

namespace CSHARP_Variables_Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Today;

            Console.WriteLine("Utilisateur numéro 751 203C, veuillez renseigner votre prénom:");
            string firstname = Console.ReadLine();

            Console.WriteLine("Utilisateur 751 203C. Veuillez maintenant renseigner votre nom de famille:");
            string lastname = Console.ReadLine();

            Console.WriteLine($"Bonjour {lastname} {firstname}, nous sommes le {date:dddd M MMMM}, comment allez-vous?");
        }
    }
}