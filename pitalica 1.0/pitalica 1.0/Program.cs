using System;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobrodošli na kviz!");

            // Prvo pitanje
            Console.WriteLine("Prvo pitanje: Koji je glavni grad Bosne?");
            string answer1 = Console.ReadLine();

            // Provera odgovora na prvo pitanje
            if (answer1.ToLower() == "sarajevo")
            {
                Console.WriteLine("Tačno! Idemo na sledeće pitanje.");

                // Drugo pitanje
                Console.WriteLine("Drugo pitanje: Koji je najljepše naselje u Sarajevu?");
                string answer2 = Console.ReadLine();

                // Provera odgovora na drugo pitanje
                if (answer2.ToLower() == "vratnik")
                {
                    Console.WriteLine("Ispravno! Na red dolazi treće pitanje.");

                    // Treće pitanje
                    Console.WriteLine("Treće pitanje: Na kojem stadionu igra FK Željezničar?");
                    string answer3 = Console.ReadLine();

                    // Provera odgovora na treće pitanje
                    if (answer3.ToLower() == "grbavica")
                    {
                        Console.WriteLine("Svaka čast, tačno si odgovorio/la na sva tri pitanja!");
                    }
                    else
                    {
                        Console.WriteLine("Nažalost, tačan odgovor je 'Grbavica'.");
                    }
                }
                else
                {
                    Console.WriteLine("Nije tačno, pravo ime naselja je 'Vratnik'.");
                }
            }
            else
            {
                Console.WriteLine("Nije tačno. Glavni grad Bosne je 'Sarajevo'.");
            }

            Console.WriteLine("Hvala što ste učestvovali u kvizu!");
        }
    }
}
