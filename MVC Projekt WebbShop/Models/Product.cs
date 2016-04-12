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

        public Product(int ID, int INSTORAGE, double PRICE, string NAME, string DESCRIPTION, string PICTUREURL, Product product1, Product product2) : this(ID, INSTORAGE, PRICE, NAME, DESCRIPTION, PICTUREURL)
        {
            this.product1 = product1;
            this.product2 = product2;
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
                        @"https://cf.geekdo-images.com/images/pic2949287_t.jpg"),
     

        new Product (8,9, 500.23,"Seasons",

                      "Features: Superior artwork, Tons of different strategies of game play, 3 different difficulty levels in one game"
                      +"Manage your energy between seasons and adapt your game play"
                      +"Mix cards to create unique combinations to give you more chances to win"
                      +"For 2 to 4 players"
                      +"60 minutes of playtime",
                      @"https://cf.geekdo-images.com/images/pic1299390_t.jpg"),
         new Product (10,8,199.50,
                        "Star Wars: Rebellion",
                        "Star Wars: Rebellion is a board game of epic conflict between the Galactic Empire and Rebel Alliance for two to four players!"
                        +"Experience the Galactic Civil War like never before. In Rebellion, you control the entire Galactic Empire or the fledgling Rebel Alliance. You must command starships, account for troop movements, and rally systems to your cause. Given the differences between the "
                        +"Empire and Rebel Alliance, each side has different win conditions, and you'll need to adjust your play style depending on who you represent:"
                        +"As the Imperial player, you can command legions of Stormtroopers, swarms of TIEs, Star Destroyers, and even the Death Star. You rule the galaxy by fear, relying on the power of your massive military to enforce your will. To win the game, you need to snuff out the budding Rebel Alliance by finding its base and obliterating it. Along the way, you can subjugate worlds or even destroy them."
                        +"As the Rebel player, you can command dozens of troopers, T-47 airspeeders, Corellian corvettes, and fighter squadrons. However, these forces are no match for the Imperial military. In terms of raw strength, you'll find yourself clearly overmatched from the very outset, so you'll need to rally the planets to join your cause and execute targeted military strikes to sabotage Imperial build yards and steal valuable intelligence. To win the Galactic Civil War, you'll need to sway the galaxy's citizens to your cause. If you survive long enough and strengthen your reputation, you inspire the galaxy to a full-scale revolt, and you win."
                        +"Yet for all its grandiosity, Rebellion remains intensely personal, cinematic, and heroic. As much as your success depends upon the strength of your starships, vehicles, and troops, it depends upon the individual efforts of such notable characters as Leia Organa, Mon Mothma, Grand Moff Tarkin, and Emperor Palpatine. As civil war spreads throughout the galaxy, these leaders are invaluable to your efforts, and the secret missions they attempt will evoke many of the most inspiring moments from the classic trilogy. You might send Luke Skywalker to receive Jedi training on Dagobah or have Darth Vader spring a trap that freezes Han Solo in carbonite!",
                        @"https://cf.geekdo-images.com/images/pic2737530_t.png" ),
         new Product (11,9,99.30,"The Lord of the Rings: The Card Game",
                        "The Lord of the Rings: The Card Game is a cooperative adventure game in which the players attempt to complete a scenario, each with three heroes of their choice and a deck of allies, events and attachments to support them. Each round, players send their heroes and allies to quest or to fight with enemies that engage them. However, as the heroes and allies exhaust after questing, defending, or attacking, the players' options are typically insufficient to deal with everything at once. Therefore, players need to determine whether it is more urgent to quest and make progress in the scenario while the enemy forces gain power, or to take down enemies while making no progress, not knowing what will come next."
                        +"The Lord of the Rings: The Card Game is the base game of a Living Card Game for which new adventure packs are released monthly. The base game contains three scenarios, twelve famous characters from the works of J.R.R. Tolkien (including Aragorn, Legolas, Gimli, Denethor and Eowyn), and four pre-constructed player decks. Players can either use one of these decks or construct their own deck to increase their chances to be succesful in the more challenging scenarios. The monthly adventure packs contain a new scenario, a new hero, and new player cards to be used in their deck. The base game is for 1-2 players, but with an additional base game the scenarios can be played with up to four players."
                        +"Although this game is set in Tolkien's Middle Earth, the scenarios do not represent scenes from the books, but rather take place in the seventeen years from Bilbo's 111th birthday until Frodo's departure from the Shire.The scenarios from saga-expansions do represent scenes from the books. Saga-expansions will form the Campaign Mode so that you can play all the saga quests that deal with the trilogy (+ Hobbit) together in one marathon campaign.",
                        @"https://cf.geekdo-images.com/images/pic906495_t.jpg"),
         new  Product (12,10,130.50,"Thunder & Lightning",
                         "Thunder & Lightning, players take on the role of Thor or Loki and fight their way through an army in an epic mythological showdown. Because Loki has already stolen Odin's Crown, the Allfather has entrusted his son Thor with his prized ring of power, Draupnir, to help him defeat the vile trickster. But who really has what it takes to gain control over both relics and therefore claim the throne of Asgard?"
                        +"Thunder & Lightning, a reimplementation of Hera and Zeus, features the same gameplay as the earlier design, but with larger decks of cards with a different distribution of powers"
                        +"In the game, each player starts with nine cards in hand, then places three cards face down in their first row, with these rows butting against one another and each player having space for four rows in their playing area. If a player loses a card in a row, then any cards in the same column behind this card slide forward to fill the empty slot. On a turn, a player has as many action points as the number of columns they have in the playing area. They can use these action points to draw cards, play cards to the battlefield, play a mythological card for its power, or challenge an opponent's card."
                        +"To challenge, the player chooses a card in their first row that abuts an opponent's card, then reveals both of them. Most cards have a strength value (0-7), and the card with the lower strength value is discarded, with the opponent's other cards in the same column then sliding forward."
                        +"If a player cannot use all of their actions or has no actions (due to having no cards on the battlefield) or loses control of Odin's Crown/Ring, then they lose the game.",
                        @"https://cf.geekdo-images.com/images/pic2849820_t.jpg"),
         new Product (13 ,2 , 145.50, "Millennium Blades",
                         "Millennium Blades is a CCG-Simulator -- A game in which you play as a group of friends who play the fictional CCG Millennium Blades"
                         +"In this game you will build decks, play the meta, acquire valuable collections, crack open random boosters, and compete in tournaments for prizes and fame. The game takes you from Starter Deck to Regionals in about 2-3 hours."
                         +"Multiple games can also be chained together to form a Campaign, going from Regionals to Nationals in game 2 and from Nationals to Worlds in game 3, with each game introducing ever more powerful cards and higher stakes, but also resetting the power of the game so that each player has a fair chance to win each 'season' of the campaign."
                         +"The game draws heavily on Manga/Anime inspiration for its art, and parodies Magic: the Gathering, Yugioh, and many other collectible games."
                         +"At its heart, it’s a commodity trading game, except that instead of cubes or stocks, the things you’ll be buying, selling, and speculating on are trading cards that can be used throughout the game in periodic tournaments. By trading wisely, playing the market, working together with friends, building collections, and winning tournaments, you’ll secure points and become the Millennium Blades World Champion",
                         @"https://cf.geekdo-images.com/images/pic2468179_t.jpg"),
         new Product  (14, 4, 99.00, "Blood Rage",
                          "'Life is Battle; Battle is Glory; Glory is ALL'"
                         +"In Blood Rage, each player controls their own Viking clan’s warriors, leader, and ship. Ragnarök has come, and it’s the end of the world! It’s the Vikings’ last chance to go down in a blaze of glory and secure their place in Valhalla at Odin’s side! For a Viking there are many pathways to glory. You can invade and pillage the land for its rewards, crush your opponents in epic battles, fulfill quests, increase your clan's stats, or even die gloriously either in battle or from Ragnarök, the ultimate inescapable doom."
                         +"Most player strategies are guided by the cards drafted at the beginning of each of the three game rounds (or Ages). These “Gods’ Gifts” grant you numerous boons for your clan including: increased Viking strength and devious battle strategies, upgrades to your clan, or even the aid of legendary creatures from Norse mythology. They may also include various quests, from dominating specific provinces, to having lots of your Vikings sent to Valhalla. Most of these cards are aligned with one of the Norse gods, hinting at the kind of strategy they support. For example, Thor gives more glory for victory in battle, Heimdall grants you foresight and surprises, Tyr strengthens you in battle, while the trickster Loki actually rewards you for losing battles, or punishes the winner."
                         +"Players must choose their strategies carefully during the draft phase, but also be ready to adapt and react to their opponents’ strategies as the action phase unfolds. Battles are decided not only by the strength of the figures involved, but also by cards played in secret. By observing your opponent’s actions and allegiances to specific gods, you may predict what card they are likely to play, and plan accordingly. Winning battles is not always the best course of action, as the right card can get you even more rewards by being crushed. The only losing strategy in Blood Rage is to shy away from battle and a glorious death!",
                         @"https://cf.geekdo-images.com/images/pic2439223_t.jpg" )



            

             };
        private Product product1;
        private Product product2;

        ////public static IEnumerable<Product> List = {new  }; 



    }
}