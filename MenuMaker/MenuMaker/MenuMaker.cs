using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker
{
    class MenuMaker
    {
        public Random Randomizer;
        string[] Meats = {"Salame", 
                         "Costela", 
                         "Maminha", 
                         "Picanha", 
                         "Guisado", 
                         "Salsicha", 
                         "Hamburguer"
                         };
        string[] Condiments = {"Mostarda Amarela",
                              "Catchup", 
                              "Mostarda Preta", 
                              "Pimenta", 
                              "Molho Shoyu", 
                              "Maionese", 
                              "Mel", 
                              "Molho Quatro Queijos"};
        string[] Breads = {"Cacetinho",
                          "Sovadinho",
                          "Croissant",
                          "Baby",
                          "Pão de Centeio",
                          "Pão de Sanduiche"};

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + " com " + randomCondiment + " em um " + randomBread;
        }
    }
}
