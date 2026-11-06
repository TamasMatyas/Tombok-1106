namespace Tombok_1106
{
    internal class Program
    {
        static Random r = new Random();
        static string[] words = { "alma", "kutya", "macska", "asztal", "iskola", "ceruza", "telefon", "szamitogep", "ablak", "ajto", "labda", "konyv", "virag", "hegy", "folyo", "tenger", "napraforgo", "pillango", "elefant", "zsiraf", "oroszlan", "krokodil", "dinoszaurusz", "repulo", "vonat", "bicikli", "autopalya", "csillag", "hold", "bolygo", "univerzum", "asztrofizika", "fenykepezogep", "huto", "szekreny", "kanape", "fagylalt", "csokolade", "palacsinta", "szendvics", "eper", "cseresznye", "gitar", "dob", "zongora", "futball", "kosarlabda", "bajnoksag", "kaland", "rejtely" };
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
            int tippekSzama = 0;
            string eddigiBetuk = "";
            while (kitalalandoSzo != eddigiTalalatok)
            {
                char betu = betuBeker();
                if (eddigiBetuk.Contains(betu))
                {
                    Console.WriteLine("Ezt a betűt már próbáltad!");
                    Console.WriteLine("\t" + eddigiTalalatok);
                    continue;
                }
                else if (kitalalandoSzo.Contains(betu))
                {
                    tippekSzama++;
                    eddigiBetuk += betu;
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
                Console.WriteLine("\t" + eddigiTalalatok);
                Console.WriteLine("\n");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Gratulálok! Eltaláltad {tippekSzama} próbálkozásból!");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Akasztófa();
        }
    }
}

