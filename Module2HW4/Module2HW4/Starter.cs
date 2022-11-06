using System;
using System.IO;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace Module2HW4
{
    public class Starter
    {
        public static void Run()
        {
            CreateBouquet();
            Console.WriteLine("\n\n-Plants sorted by price:-\n" + Bouquet.GetInstance().SortByPrice().FormatHerbalPlantsArray());
            Console.WriteLine("\n-Total price of bouquet-\n" + Bouquet.GetInstance().Plants.GetTotalPrice());
            Console.WriteLine("\n\n-Average price of plant-\n" + Bouquet.GetInstance().Plants.GetAveragePrice());
            Console.WriteLine("\n\n-Plants with lower than average price-\n" + Bouquet.GetInstance().FindHerbalPlantsWithLowerPrice().FormatHerbalPlantsArray());
            Console.WriteLine("\n-Plants with name \"Rose\"-\n" + Bouquet.GetInstance().GetByName("Rose").FormatHerbalPlantsArray());
            Console.WriteLine("\n-Plants with name \"Eucalyptus\"-\n" + Bouquet.GetInstance().GetByName("Eucalyptus").FormatHerbalPlantsArray());

            Console.WriteLine("\n-Growth of plants-\n");
            IGrow grow = (IGrow)Bouquet.GetInstance().GetByName("Reed")[0];
            Console.WriteLine("Grass: " + grow.Grow());
            grow = (IGrow)Bouquet.GetInstance().GetByName("Rose")[0];
            Console.WriteLine("Fresh flower: " + grow.Grow());
            Console.WriteLine("Everlasting flower: " + ((EverlastingFlower)Bouquet.GetInstance().GetByName("Gypsophila")[0]).Grow());

            Console.WriteLine("\n-Smell of fresh flowers-\n");
            ISmell smell = (FreshFlower)Bouquet.GetInstance().GetByName("Rose")[0];
            Console.WriteLine("Rose: " + smell.Smell());
            smell = (FreshFlower)Bouquet.GetInstance().GetByName("Peony")[0];
            Console.WriteLine("Peony: " + smell.Smell());
            smell = (FreshFlower)Bouquet.GetInstance().GetByName("Eustoma")[0];
            Console.WriteLine("Eustoma: " + smell.Smell());

            Console.WriteLine("\n\n-Fading of flowers-\n");
            Console.WriteLine("Fresh flower: " + ((FreshFlower)Bouquet.GetInstance().GetByName("Rose")[0]).Fade());
            Console.WriteLine("Everlasting flower: " + ((EverlastingFlower)Bouquet.GetInstance().GetByName("Gypsophila")[0]).Fade());
            Console.WriteLine("Grass: " + ((Grass)Bouquet.GetInstance().GetByName("Reed")[0]).Fade());
        }

        public static HerbalPlant[] CreateBouquet()
        {
            HerbalPlant[] plants =
            {
               new FreshFlower("Rose", 30, 30, ColorEnum.Pink),
               new FreshFlower("Peony", 10, 20, ColorEnum.Red),
               new FreshFlower("Chamomile", 10, 20, ColorEnum.White),
               new FreshFlower("Chamomile", 10, 20, ColorEnum.White),
               new FreshFlower("Eustoma", 18, 13, ColorEnum.White),
               new EverlastingFlower("Gypsophila", 22, 35, ColorEnum.White),
               new Grass("Eucalyptus", 5, 15, true),
               new Grass("Reed", 2, 45, false)
            };

            Bouquet.GetInstance().Plants = plants;
            Console.Write(Bouquet.GetInstance().ToString());

            return Bouquet.GetInstance().Plants;
        }
    }
}
