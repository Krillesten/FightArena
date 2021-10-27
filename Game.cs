using System;

namespace Game
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
            string[] Monster = { "Rat" , "Troll", "Dragon"};
            
            // Rat [Life, Damage]
            int[] Rat = { 1, 1 };
            // Troll[Life, Damage]
            int[] Troll = { 5, 3 };
            // Dragon[Life, Damage]
            int[] Dragon = { 10, 5 };
                Console.WriteLine("\nWelcome to the arena! \n \nEnter your heroes name:");
                string name = Console.ReadLine();

            while (Game == true)
            {
                Console.WriteLine("\n" + name + "`s stats:");
                Console.WriteLine("Life: " + life);
                Console.WriteLine("Strength: " + damage);

                Console.WriteLine("\nWhat moster do you want to battle!\n" +
                                    Monster[0] + " - Enter R\n" +
                                    Monster[1] + " - Enter T\n" +
                                    Monster[2] + " - Enter D\n");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "R":
                        Console.WriteLine("Your fighting RAT!\n");
                        bool win = Battle(life, damage, Rat[0], Rat[1]);
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
                        win = Battle(life, damage, Troll[0], Troll[1]);
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
                        win = Battle(life, damage, Dragon[0], Dragon[1]);
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

