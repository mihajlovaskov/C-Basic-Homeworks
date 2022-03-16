using System;

namespace FindWordsInSentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any sentence and click enter:");
            string anySentence = Console.ReadLine();
            int counter = 1;
            string[] wordsInAnySentence = anySentence.Split(' ');
            Console.WriteLine($"This is a list of words in your sentence:"); 
            for (int i = 0; i < wordsInAnySentence.Length; i++)//Nadolu obrabotuvam razlicni scenarija koga C#
                //dobiva recenica so razlicni interpunkciski znaci (tocka, zapirka, izvicnik....).
                //Ako se odi so Split na prazno mesto (sto e prvo resenie sto pagja na pamet) site interpunkciski
                //znaci, zavisno kolku korisnikot pravopisno ja napisal recenicata, moze da bidat del od nekoj zbor
                //ili duri da bidat izdvoeni kako poseben zbor. No, zadacata bara da se izdvojat cisti zborovi...
                //Taka da, po split po prazno mesto, pravam split po sekoj od oddelnite interpunkciski znaci.
                //Bidejkji na kraj moze da ima prazni polinja izdvoeni kako zborovi, preku "continue" vo "for"
                //ciklusot so koj gi ispisuvam zborovite, gi "preskoknuvam" praznite polinja.
                //Ne isklucuvam moznost deka ima i drugi interpunkciski znaci sto ne mi se opfateni.
                // Veruvam deka za ova ima i poelegantno resenie... Zasto vaka "for"
                // vo "for" vo "for" ne mi izgleda bas dobro resenie.
            {
                string[] wordsInAnySentence2 = wordsInAnySentence[i].Split(",");
                for (int y = 0; y < wordsInAnySentence2.Length; y++)
                {
                    string[] wordsInAnySentence3 = wordsInAnySentence2[y].Split(".");
                    for (int x = 0; x < wordsInAnySentence3.Length; x++)
                    {
                        string[] wordsInAnySentence4 = wordsInAnySentence3[x].Split(":");
                        for (int z = 0; z < wordsInAnySentence4.Length; z++)
                        {
                            string[] wordsInAnySentence5 = wordsInAnySentence4[z].Split(";");
                            for (int n = 0; n < wordsInAnySentence5.Length; n++)
                            {
                                string[] wordsInAnySentence6 = wordsInAnySentence5[n].Split("\"");
                                for (int o = 0; o < wordsInAnySentence6.Length; o++)
                                {
                                    string[] wordsInAnySentence7 = wordsInAnySentence6[o].Split("?");
                                    for (int p = 0; p < wordsInAnySentence7.Length; p++)
                                    {
                                        string[] wordsInAnySentence8 = wordsInAnySentence7[p].Split("!");
                                        for (int q = 0; q < wordsInAnySentence8.Length; q++)
                                        {
                                            string[] wordsInAnySentence9 = wordsInAnySentence8[q].Split("'");
                                            for (int r = 0; r < wordsInAnySentence9.Length; r++)
                                            {
                                                string[] wordsInAnySentence10 = wordsInAnySentence9[r].Split("-");
                                                for (int s = 0; s < wordsInAnySentence10.Length; s++)
                                                {
                                                    string[] wordsInAnySentence11 = wordsInAnySentence10[s].Split("(");
                                                    for (int t = 0; t < wordsInAnySentence11.Length; t++)
                                                    {
                                                        string[] wordsInAnySentence12 = wordsInAnySentence11[t].Split(")");
                                                        for (int u = 0; u < wordsInAnySentence12.Length; u++)
                                                        {
                                                            string[] wordsInAnySentence13 = wordsInAnySentence12[u].Split("/");
                                                            for (int v = 0; v < wordsInAnySentence13.Length; v++)
                                                            {
                                                                string[] wordsInAnySentence14 = wordsInAnySentence13[v].Split("\\");
                                                                for (int m = 0; m < wordsInAnySentence14.Length; m++)
                                                                {
                                                                    if (wordsInAnySentence14[m] == "")
                                                                    {
                                                                        continue;
                                                                    }
                                                                    Console.WriteLine($"{counter++}. {wordsInAnySentence14[m]}");
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
