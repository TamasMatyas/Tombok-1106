namespace Tombok_1106
{
    internal class Program
    {
        static Random r = new Random();
        static string[] words = { "hűtőszekrény", "villanykörte", "monitor", "eper", "egér" };
        static string Kivalasztas()
        {
            int index = r.Next(0, words.Length);
            return words[index];
        }
        static char betuBeker()
        {
            Console.Write("Kérek egy betűt: ");
            char betu = Console.ReadLine()[0];
            Console.Clear();
            return betu;
        }
        static void Akasztófa()
        {
            string kitalalandoSzo = Kivalasztas();
            string eddigiTalalatok = new string('_', kitalalandoSzo.Length);
            while (kitalalandoSzo != eddigiTalalatok)
            {
                char betu = betuBeker();
                if (kitalalandoSzo.Contains(betu))
                {
                    string seged = "";
                    for (int i = 0; i < kitalalandoSzo.Length; i++)
                    {
                        if (betu == kitalalandoSzo[i])
                        {
                            seged += betu;
                        }
                        else
                        {
                            seged += eddigiTalalatok[i];
                        }
                    }
                    eddigiTalalatok = seged;
                }
                else
                {
                    Console.WriteLine("Nincs ilyen betű a szóban!");
                }
                Console.WriteLine("\t"+eddigiTalalatok);
                Console.WriteLine("\n");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gratulálok a kitalálásra!");
            Console.ResetColor();



        }
        static void Main(string[] args)
        {
            Akasztófa();
        }
    }
}

