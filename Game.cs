using System;

namespace FightArena
{
    class Game
    {
        static bool Battle(int life, int damage, int monsterLife, int monsterDamage)
        {
            bool win = false;
            bool playerTurn = false;

            while(life > 0 && monsterLife > 0)
            {
                if (playerTurn == false)
                {
                    life = life - monsterDamage;
                    playerTurn = true;
                } else
                {
                    monsterLife = monsterLife - damage;
                    playerTurn = false;
                }
            }

            if (monsterLife <= 0)
            {
                win = true;
            } else
            {
                win = false;
            }
            return win;
        }

        static void Main(string[] args)
        {
            bool gameRunning = true;
            while (gameRunning)
            {
                bool Game = true;
                string answer;
                string continueGame;
                
                // Characters Specs
                int life = 3;
                int damage = 1;

                /* Monsters */
                Ratinfo Rat = new Ratinfo();
                TrollInfo Troll = new TrollInfo();
                DragonInfo Dragon = new DragonInfo();

                Console.WriteLine("\nWelcome to the arena! \n \nEnter your heroes name:");
                string name = Console.ReadLine();

                do
                {
                    // Show players stats and let the player choose an opponent
                    Console.WriteLine($"\n {name}`s stats:");
                    Console.WriteLine($"Life: {life}");
                    Console.WriteLine($"Strength: {damage}");

                    Console.WriteLine("\nWhat moster do you want to battle!\n" +
                                        Rat.name + " - Enter r\n" +
                                        Troll.name + " - Enter t\n" +
                                        Dragon.name + " - Enter d\n");
                    answer = Console.ReadLine();

                    Console.Clear();

                    // Run battle depending on players input
                    switch (answer)
                    {
                        case "r":
                            Console.WriteLine("You fighting RAT!\n");
                            bool win = Battle(life, damage, Rat.life, Rat.damage);
                            if (win == true)
                            {
                                Console.WriteLine("You slayed the Rat!\n\n You got 1+ life and 1+ damage\n");
                                life++;
                                damage++;
                            }
                            else
                            {
                                Console.WriteLine("You were slayed by the rat!\n");
                                Console.WriteLine("GAME OVER!\n Do you want to play again? (y/n)");
                                continueGame = Console.ReadLine();
                                if (continueGame == "y")
                                {
                                    Game = false;
                                    gameRunning = true;
                                }
                                else if (continueGame == "n")
                                {
                                    Game = false;
                                    gameRunning = false;
                                }
                        }
                            break;

                        case "t":
                            Console.WriteLine("You fighting the Troll!");
                            win = Battle(life, damage, Troll.life, Troll.damage);
                            if (win == true)
                            {
                                Console.WriteLine("You slayed the Troll!\n\n You got 1+ life and 1+ damage\n");
                                life++;
                                damage++;
                            }
                            else
                            {
                                Console.WriteLine("You were slayed by the Troll!\n");
                                Console.WriteLine("GAME OVER!\n Do you want to play again? (y/n)");
                                continueGame = Console.ReadLine();
                                if (continueGame == "y")
                                {
                                    Game = false;
                                    gameRunning = true;
                                }
                                else if (continueGame == "n")
                                {
                                    Game = false;
                                    gameRunning = false;
                                }
                        }
                            break;

                        case "d":
                            Console.WriteLine("You fighting the Dragon!");
                            win = Battle(life, damage, Dragon.life, Dragon.damage);
                            if (win == true)
                            {
                                Console.WriteLine("\nYou slayed the Dragon!\n\n YOU FINALLY WON THE GAME!\n");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You were slayed by the Dragon!\n");
                                Console.WriteLine("GAME OVER!\n Do you want to play again? (y/n)");
                                continueGame = Console.ReadLine();
                                if (continueGame == "y" )
                                {
                                    Game = false;
                                    gameRunning = true;
                                } 
                                else if (continueGame == "n")
                                {
                                    Game = false;
                                    gameRunning = false;
                                }
                            }
                            break;

                        default:
                            Console.WriteLine("Please choose R, T or D");
                            break;
                    }
                } while (Game == true);
            }
        }
        }
    }

