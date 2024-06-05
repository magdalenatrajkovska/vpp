using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeSeObesamm
{
    public class HangmanWord
    {
        // zborot koj sho ke nie 
        public string Word { get; set; }// zborot za besenje
        public HashSet<char> LettersInWord { get; set; }  // bukvite vo lista
        public HashSet<char> GuessedLetters { get; set; } // od azbukaata
        public int WrongCount { get; set; } // max 5
        public static readonly int MAX_RETRIES = 5;


        public HangmanWord(string Word) 
        {
            this.Word = Word;
            LettersInWord = new HashSet<char>(); // gi inicijalizirame
            foreach (char c in Word) // word na c bukvi
            {
                LettersInWord.Add(Char.ToLower(c)); // addd vo lettersinword
            }
            GuessedLetters = new HashSet<char>(); // samo inicijaliirame
            WrongCount = 0; 

        }


        public string GetMaskedWord() //ova za da se pokazat bukvite od zborot
        {
            StringBuilder sb = new StringBuilder(); //go prajme kak string ---------sfffafewrferg
            foreach (char c in Word)
            {
                if (LettersInWord.Contains(Char.ToLower(c)))//Ne e pogodena akoushte e vo letters in word
                {
                    sb.Append("_");
                }
                else //Bukavata e pogodena hihihi
                {
                    sb.Append(c);
                }
                sb.Append(" ");
            }
            return sb.ToString();
        }

        public string GetMaskedGuessedLetters()//ova od azbukata masked ako ne probani
        {

            StringBuilder sb = new StringBuilder();
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (GuessedLetters.Contains(c))
                {
                    sb.Append(Char.ToUpper(c));
                }
                else
                {
                    sb.Append("_");
                }
                sb.Append(" ");
            }


            return sb.ToString();
        }

        public bool GuessLetter(char letter)// od tb idi tuka
        {
            //bukvata od tb
            letter = Char.ToLower(letter);
            if (GuessedLetters.Contains(letter)) //ako e tuka ne praj nishto
            {
                return false;
            }
            else   // ako prvpat ja godime
            {
                if (LettersInWord.Contains(letter)) //i ako ja ima vo letter izvaja 
                {
                    LettersInWord.Remove(letter);

                }
                else
                {
                    WrongCount++; // ako e greshna bukva izbrishija
                }
                GuessedLetters.Add(letter); // i dodaja vo ova
                return true;
            }


        }
        public bool Win() //amin
        {
            return LettersInWord.Count == 0;
        }
        public bool Lose()
        {
            return WrongCount == MAX_RETRIES;
        }
    }
}
