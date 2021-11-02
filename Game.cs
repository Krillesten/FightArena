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
            bool Game = true;
            string answer;
            // Characters Specs
            int life = 3;
            int damage = 1;

            /* Monsters */
            Ratinfo Rat = new Ratinfo();
            TrollInfo Troll = new TrollInfo();
            DragonInfo Dragon = new DragonInfo();

                Console.WriteLine("\nWelcome to the arena! \n \nEnter your heroes name:");
                string name = Console.ReadLine();

            while (Game == true)
            {
                Console.WriteLine("\n" + name + "`s stats:");
                Console.WriteLine("Life: " + life);
                Console.WriteLine("Strength: " + damage);

                Console.WriteLine("\nWhat moster do you want to battle!\n" +
                                    Rat.name + " - Enter R\n" +
                                    Troll.name + " - Enter T\n" +
                                    Dragon.name + " - Enter D\n");
                answer = Console.ReadLine();

                Console.Clear();

                switch (answer)
                {
                    case "R":
                        Console.WriteLine("Your fighting RAT!\n");
                        bool win = Battle(life, damage, Rat.life, Rat.damage);
                        if (win == true)
                        {
                            Console.WriteLine("You slayed Rat!\n\n You got 1+ life and 1+ damage\n");
                            life++;
                            damage++;
                        } else
                        {
                            Console.WriteLine("You were slayed by rat!\n");
                            Console.WriteLine("GAME OVER!\n");
                            life = 3;
                            damage = 1;
                        }
                        break;

                    case "T":
                        Console.WriteLine("Your fighting Troll!");
                        win = Battle(life, damage, Troll.life, Troll.damage);
                        if (win == true)
                        {
                            Console.WriteLine("You slayed Troll!\n\n You got 1+ life and 1+ damage\n");
                            life++;
                            damage++;
                        }
                        else
                        {
                            Console.WriteLine("You were slayed by Troll!\n");
                            Console.WriteLine("GAME OVER!");
                            life = 3;
                            damage = 1;
                        }
                        break;

                    case "D":
                        Console.WriteLine("Your fighting Dragon!");
                        win = Battle(life, damage, Dragon.life, Dragon.damage);
                        if (win == true)
                        {
                            Console.WriteLine("\nYou slayed Dragon!\n\n YOU FINALLY WON THE GAME!\n");
                        }
                        else
                        {
                            Console.WriteLine("You were slayed by Dragon!\n");
                            Console.WriteLine("GAME OVER!");
                            life = 3;
                            damage = 1;
                            Game = false;
                        }
                        break;

                    default:
                        Console.WriteLine("Please choose R, T or D");
                        break;
                }
            }
            }
        }
    }

