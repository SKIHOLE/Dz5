using System;

namespace Dz5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Ukrword = { "так", "ні" };
            string[] Ruswords = { "да", "нет" };
            string[] Engwords = { "yes", "no" };
            Translator trans = new Translator(Ukrword, Ruswords, Engwords);
            trans.Translate("V", "Ukr");
            Console.ReadKey();
        }
    }
    class Translator
    {
        public string[] RusWords { get; set; }
        public string[] UkrWords { get; set; }
        public string[] EngWords { get; set; }
        int index = 1;
        public Translator(string[] UkrWords, string[] RusWords, string[] EngWords)
        {
            if (UkrWords.Length <= EngWords.Length || UkrWords.Length <= RusWords.Length) index = UkrWords.Length;
            if (RusWords.Length <= UkrWords.Length || RusWords.Length <= EngWords.Length) index = RusWords.Length;
            if (EngWords.Length <= UkrWords.Length || EngWords.Length <= RusWords.Length) index = EngWords.Length;
            this.UkrWords = new string[index];
            this.RusWords = new string[index];
            this.EngWords = new string[index];
            for (int i = 0; i < index; i++)
            {
                this.UkrWords[i] = UkrWords[i];
                this.EngWords[i] = EngWords[i];
                this.RusWords[i] = RusWords[i];
            }
        }
        public void Translate(string Word, string Language)
        {
            bool Found = false;
            switch (Language)
            {
                case "Ukr":
                    for (int i = 0; i < index; i++)
                    {
                        if (Word == UkrWords[i])
                        {
                            Console.WriteLine(this.UkrWords[i]);
                            Console.WriteLine(this.EngWords[i]);
                            Console.WriteLine(this.RusWords[i]);
                            Found = true;
                            break;
                        }
                    }
                    if (!Found) Console.WriteLine("Not found word");
                    break;
                case "Rus":
                    for (int i = 0; i < this.RusWords.Length; i++)
                    {
                        if (Word == RusWords[i])
                        {
                            Console.WriteLine(this.RusWords[i]);
                            Console.WriteLine(this.EngWords[i]);
                            Console.WriteLine(this.UkrWords[i]);
                            Found = true;
                            break;
                        }
                    }
                    if (!Found) Console.WriteLine("Not found word");
                    break;
                case "Eng":
                    for (int i = 0; i < this.EngWords.Length; i++)
                    {
                        if (Word == EngWords[i])
                        {
                            Console.WriteLine(this.EngWords[i]);
                            Console.WriteLine(this.UkrWords[i]);
                            Console.WriteLine(this.RusWords[i]);
                            Found = true;
                            break;
                        }
                    }
                    if (!Found) Console.WriteLine("Not found word");
                    break;
                default:
                    Console.WriteLine("не знайдена мова");
                    break;
            }
        }
    }
}
