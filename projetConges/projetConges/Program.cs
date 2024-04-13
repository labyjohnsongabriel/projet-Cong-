using System;

class Program
{
    static void Main()
    {
        // Créer un tableau de noms et d'âges
        string[] noms = { "John Doe", "Jane Smith", "Bob Johnson" };
        int[] ages = { 30, 25, 40 };
        string[] villes = { "New York", "Los Angeles", "Chicago" };

        // Afficher les en-têtes du tableau
        Console.WriteLine("| Nom\t\t| Âge\t| Ville\t\t|");
        Console.WriteLine("------------------------------------");

        // Afficher les données du tableau
        for (int i = 0; i < noms.Length; i++)
        {
            Console.WriteLine($"| {noms[i]}\t| {ages[i]}\t| {villes[i]}\t|");
        }

        Console.ReadLine();
    }
}
