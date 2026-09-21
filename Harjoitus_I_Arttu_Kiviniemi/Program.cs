namespace Harjoitus_IArttu_Kiviniemi
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Opiskelija: Arttu Kiviniemi");
            Console.WriteLine("Opiskelijatunnus: 12345");

            // 2
            Console.WriteLine(MuutaIsoiksi("Hello World"));

            // 3
            Console.WriteLine(MuutaPieniksi("HELLO WORLD"));

            // 4
            VahennaKymmenen("25");

            // 5
            LueSyntymavuosi();

            // 6
            string lause = "Olio-ohjelmoinnin opintojakso Csharp perusteet";
            string[] sanat = PilkoSanoiksi(lause);

            foreach (string sana in sanat)
            {
                Console.WriteLine(sana);
            }

            // 7
            TulostaSanamaara(lause);

            // 8
            Console.WriteLine(MuutaEnsimmaisetKirjaimetIsoiksi(lause));
        }

        static string MuutaIsoiksi(string teksti)
        {
            return teksti.ToUpper();
        }

        static string MuutaPieniksi(string teksti)
        {
            return teksti.ToLower();
        }

        static void VahennaKymmenen(string luku)
        {
            int numero = int.Parse(luku);
            Console.WriteLine(numero - 10);
        }

        static void LueSyntymavuosi()
        {
            Console.Write("Anna syntymävuosi: ");
            int vuosi = int.Parse(Console.ReadLine());

            Console.WriteLine("Täytät 50 vuotta vuonna " + (vuosi + 50));
        }

        static string[] PilkoSanoiksi(string lause)
        {
            return lause.Split(' ');
        }

        static void TulostaSanamaara(string lause)
        {
            string[] sanat = lause.Split(' ');
            Console.WriteLine("Sanoja: " + sanat.Length);
        }

        static string MuutaEnsimmaisetKirjaimetIsoiksi(string lause)
        {
            string[] sanat = lause.Split(' ');

            for (int i = 0; i < sanat.Length; i++)
            {
                sanat[i] = char.ToUpper(sanat[i][0]) + sanat[i].Substring(1).ToLower();
            }

            return string.Join(" ", sanat);
        }
    }
}