namespace Cwiczenia_8_Zad_8b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KOLORY. \nWpisz kilka kolorów od ulubionego do najmniej lubianego");
            Console.WriteLine(" ");

            Stack<string> kolory = new Stack<string>();
            string kolor;
            string na_bok;

            do
            {
                Console.WriteLine("Wpisz kolor (lub wciśnij ENTER aby zakończyć");
                kolor = Console.ReadLine();

                if (kolor == "")
                    break;
                else
                    kolory.Push(kolor);


            }while(true);

            na_bok = kolory.Pop();

            while (kolory.Count != 1)
            {
                kolory.Pop();
            }

            kolory.Push(na_bok);

            foreach (string barwa in kolory)
                Console.Write(barwa + " ");

            Console.ReadKey();
        }
    }
}