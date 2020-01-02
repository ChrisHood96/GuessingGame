using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program p = new Program();
            string Guess = "";
            string SecretWord; 
            SecretWord = p.word();
            string[] clues = p.clues(SecretWord);
            int guessCount = 0;
            int guessLimit = 3;
            bool OutOfGuesses = false;

            Console.WriteLine("Guess the word, you have 3 attempts");
            
            if (guessCount == 0)
            {
                Console.WriteLine("Clue: " + clues[0]);
            } 
            
                while (SecretWord != Guess && !OutOfGuesses)
                { 
                if (guessCount < guessLimit)
                {
                    Console.Write("Your guess: ");
                    Guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    OutOfGuesses = true;
                }


            
            if (guessCount == 1 && SecretWord != Guess)
            {
                    Console.WriteLine("Clue: " + clues[1]);
            }
            else if (guessCount == 2 && SecretWord != Guess)
            {
                Console.WriteLine("Final Clue: " + clues[2]);
            }
                
            
            }
            if (SecretWord == Guess)
            {
                Console.WriteLine("Congratulations, right word!");
            }
            else 
            {
                Console.WriteLine("Out of guesses, unlucky");
            }
                Console.ReadLine();
            }

        private string word()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 6);

            string[] secretword = new string[6]
            {
            "potato","spade" ,"flask" ,"computer" ,"cat" ,"dog"
            };

            string word = secretword[i];


            return word;
        }
        private string[] clues(string word)
        {
            string[] answer = new string[3];
            string[] potato = new string[3]
            {
                "grows in the ground","boil em, mash em, put em in a stew","chups"
            };
            string[] spade = new string[3]
            {
                "useful for digging","i am a dwarf","and im digging a hole"
            };
            string[] flask = new string[3]
            {
                "container","hot drink goes here","maybe soup goes here"
            };
            string[] computer = new string[3]
            {
                "you're using this","contains many parts","cpu,gpu,monitor..."
            };
            string[] cat = new string[3]
            {
                "Covered in fur","pointy ears","makes use of flap in door"
            };
            string[] dog = new string[3]
            {
                "there are many types","big and smol","borf"
            };


            if (word == "potato")
            {
                answer = potato;
            }
            else if (word == "spade")
            {
                answer = spade;
            }
            else if (word == "flask")
            {
                answer = flask;
            }
            else if (word == "computer")
            {
                answer = computer;
            }
            else if (word == "cat")
            {
                answer = cat;
            }
            else if (word == "dog")
            {
                answer = dog;
            }

            return answer;
        }

            
            
        }
       
        

        }
        

