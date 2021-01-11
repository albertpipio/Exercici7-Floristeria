using System;
using System.Collections.Generic;

namespace Ex7_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FlowerShop> FloristeriaAlbert = new List<FlowerShop>();
            FlowerShop defaultFlowerShop = new FlowerShop("FLORISTERIA ALBERT", 2015);
            FloristeriaAlbert.Add(defaultFlowerShop);
            
            Console.WriteLine();
            Console.WriteLine("=======================================================================");
            Console.WriteLine($" *** Benvingut a la {defaultFlowerShop.Name}, al teu servei des de {defaultFlowerShop.YearOfCreation}! *** ");
            Console.WriteLine("=======================================================================");
            Console.WriteLine();

            List<Tree> TreeList = new List<Tree>();
            
            Tree Tree1 = new Tree ("Avet", 1557, 35);
            TreeList.Add(Tree1);
            Tree Tree2 = new Tree ("Alzina", 2540, 56);
            TreeList.Add(Tree2);
            Tree Tree3 = new Tree ("Olivera", 6678, 87);
            TreeList.Add(Tree3);

            List<Flower> FlowerList = new List<Flower>();

            Flower Flower1 = new Flower ("Violeta", "lila", 23);
            FlowerList.Add(Flower1);
            Flower Flower2 = new Flower ("Rosa", "vermell", 15);
            FlowerList.Add(Flower2);
            Flower Flower3 = new Flower ("Ginesta", "groc", 67);
            FlowerList.Add(Flower3);

            List<Decoration> DecorationType = new List<Decoration>();

            Decoration WoodDecoration = new Decoration ("Nadalenca", "fusta", 44);
            DecorationType.Add(WoodDecoration);
            Decoration PlasticDecoration = new Decoration ("Estiuenca", "plàstic", 12);
            DecorationType.Add(PlasticDecoration);

            var temps = DateTime.Now;

            Console.WriteLine($"A dia {temps}, l'stock és el següent:");
            Console.WriteLine();
            Console.WriteLine("ARBRES:");
            Console.WriteLine();    

            foreach (var tree in TreeList)
            {
                Console.WriteLine(tree.getTreeInfo());
            }

            Console.WriteLine("FLORS:");
            Console.WriteLine();

            foreach (var flower in FlowerList)
            {
                Console.WriteLine(flower.getFlowerInfo());
            }

            Console.WriteLine("DECORACIÓ:");
            Console.WriteLine();

            foreach (var decoration in DecorationType)
            {
                Console.WriteLine(decoration.getDecorationInfo());
            }
            
            Console.WriteLine("Això és tot, fins aviat!");
        }
    }
}