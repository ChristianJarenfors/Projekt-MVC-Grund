using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.IO;

namespace MVC_Projekt_WebbShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InStorage { get; set; }
        public double Price { get; set; }
        public string PictureURL{ get; set; }
        public string Description { get; set; }
        public Product() { }
        public Product(int ID, int INSTORAGE, double PRICE, string NAME, string DESCRIPTION, string PICTUREURL)
        {
            Id = ID;
            InStorage = INSTORAGE;
            Price = PRICE;
            Name = NAME;
            Description = DESCRIPTION;
            PictureURL = PICTUREURL;
        }

        //public static IEnumerable<Product> List = {new  }; 
        public static List<Product> Catalogue = new List<Product>()
        { new Product(1, 3, 499.99, 
                    "Trivial Pursuit", 
                    "Trivial Pursuit Master är fyllt av nya aktuella ämnen som ger en rejäl uppfräschning av "
                   +"det klassiska favoritspelet. Testa era kunskaper och lär er massor av fantastiska fakta. "
                   +"Sätt igång - imponera på varandra och ha kul under tiden. Om du har koll på omvärlden så är"
                   +" Trivial Pursuit Master något för dig. /n 3000 spännande och till och med dråpliga frågor."
                   +" Spelet innehåller även en elektronisk timer som skyndar på spelet. Batterier ingår ej."
                    , @"https://cf.geekdo-images.com/images/pic393209_t.jpg"),
         new Product (2, 4, 399.99, 
                      "Talisman",
                      "Talisman is an adventure board game set in a high fantasy medieval world. "
                     +"Players have 14 characters to choose from all based on role playing archetypes, "
                     +"such as heroes, wizards, villains, thieves, monsters, etc. The game makes players "
                     +"feel they are traveling the world to find equipment, weapons, ancient relics, and "
                     +"companions that will help them on their quest to acquire the Crown of Command. "
                     +"Along the way they visit various locales in the worlds, battle each other and "
                     +"fantastic creatures to make their way to the top."
                     ,@"https://cf.geekdo-images.com/images/pic332870_t.jpg"),
         new Product (3,3,799.99, 
                      "Massive Darkness",
                      "Massive Darkness brings the classic fantasy RPG experience to modern board gaming, with an action-packed campaign chock full of gorgeous miniatures and a streamlined system that keeps the focus on the heroes' actions, with no need for a game master to control the enemies. Using the popular Zombicide system as a starting point, Massive Darkness adds all the richness of a dungeon crawl RPG. Pick your hero, choose a class, decide on which skills to spend your XP, and get loot by searching the dungeon or killing special enemies that can use the equipment against you! Face a multitude of different enemy types, coming in all shapes and sizes, whose behavior is resolved automatically...or you can try to sneak around enemies by taking advantage of dark areas of the map. Players begin their adventure in Massive Darkness by picking a Hero – each with two special starting skills – and pair them with a Class of their choosing.Depending on the combination, another skill can be unlocked, giving players a wide range of choices and play styles. In Massive Darkness, the created Heroes go on Quests, killing monsters, collecting loot, and gaining XP.Players spend their XP to unlock new Skills, growing more powerful as the Quest progresses. Throughout the game, players encounter different monsters, including Minions, Agents, Roaming Monsters, and Bosses.An unique mechanism of the game is the Guardian.Any of the monster types have a chance of spawning as a Guardian, meaning it will use a random piece of equipment in the fight against Heroes. However, if players are able to overcome this difficult encounter, they will acquire that piece of loot!",
                       @"https://cf.geekdo-images.com/images/pic2957948_t.jpg"),
         new Product (4,5,499.99,"Jamaica",
                     "Summary: This is a pirate-themed tactical race game with player interaction and side goals (e.g. detouring for treasure). The winner is the player who best balances their position in the race with their success at the side goals. /n Setting: Jamaica, 1675. /n After a long career in piracy, Captain Henry Morgan skillfully gets appointed to be Governor of Jamaica, with the explicit order to cleanse the Caribbean of pirates and buccaneers! Instead, he invites all of his former colleagues to join him in his retirement, to enjoy the fruits of their looting with impunity.Each year, in remembrance of the \"good old days,\" Morgan organizes the Great Challenge, a race around the island, and at its end, the Captain with the most gold is declared Grand Winner. Goal: The game ends on the turn when at least one player's ship reaches the finish line, completing one circuit around the island of Jamaica. At that point, players are awarded different amounts of gold in accordance with how far away from the finish line they were when the race concluded. This gold is added to any gold a player gathered along the way by detouring from the race to search for valuable treasure, by stealing gold or treasure from other players, or just by loading gold as directed by the cards the player played during the race. The player with the most total gold acquired through all these means is then declared the winner.",
                     "https://cf.geekdo-images.com/images/pic1502119_t.jpg"),
         new Product (5,6, 599.99, "Sea Fall"
                      ,"SeaFall is a 4X game (explore, expand, exploit, and exterminate) set in an \"age of sail\" world reminiscent of our world. /n In SeaFall, the world is starting to claw its way out of a dark age and has begun to rediscover seafaring technology. Players take on the role of a mainland empire that consults with a consortium of advisors to discover new islands, explore those islands, develop trade, send out raiding parties, take part in ship-to-ship combat, and more. As in Risk Legacy and Pandemic Legacy, co-designed by Rob Daviau, SeaFall evolves as the game is played, setting their grudges into the history of the game and building a different narrative at every table as players open up the world.",
                        @"https://cf.geekdo-images.com/images/pic2949287_t.jpg")

             };

        ////public static IEnumerable<Product> List = {new  }; 
       


    }
}