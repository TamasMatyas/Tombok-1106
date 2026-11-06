namespace Tombok_1106
{
    internal class Program
    {
        static Random r = new Random();
        static string[] words = { "Hűtőszekrény", "Villanykörte", "Monitor", "Eper", "Egér" };
        static string Kivalasztas()
        {
            int index = r.Next(0, words.Length);
            return words[index];
        }
        static char betuBeker()
        {
            Console.Write("Kérek egy betűt: ");
            char betu = Console.ReadLine()[0];
            return betu;
        }
        static void Akasztófa()
        {
            string kitalalandoSzo = Kivalasztas();
            string eddigiTalalatok = new string('_', kitalalandoSzo.Length);
            Console.WriteLine(eddigiTalalatok);
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

                        }
                    }

                }
                else
                {
                    Console.WriteLine("Nincs ilyen betű a szóban!");
                }

            }




        }
        static void Main(string[] args)
        {
            Akasztófa();
        }
    }
}

