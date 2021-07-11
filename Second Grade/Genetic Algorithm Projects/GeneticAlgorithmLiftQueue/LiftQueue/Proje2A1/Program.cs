using System;
using System.Collections.Generic;
using System.Linq;


namespace Proje2A1
{
    class Program
    {
        static readonly Random rand = new Random();

        public static void Main(string[] args)
        {
            string devam = "e";

            while (devam.Equals("e", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Simülasyonda kullanılacak veri setini seçiniz.\n1. Projede verilmiş olan hazır veri seti \n2. Random veri seti");
                int seçim = Convert.ToInt16(Console.ReadLine());

                if (seçim == 1)
                {
                    List<Turist> turistler = new List<Turist>();
                    turistOluştur(turistler, false);

                    Console.WriteLine("1. Her bir turistin ITS ve OITS değerlerini, kazanç tablosunu görüntüle. (b)");
                    Console.WriteLine("2. Kişiler için en uygun asansörü belirle. (c)");

                    int seçim2 = Convert.ToInt16(Console.ReadLine());

                    if (seçim2 == 1)
                    {
                        asansörlereGönder(turistler, false);
                        itsYazdır(turistler);
                        oitsYazdır(turistler);
                        tabloYazdır(turistler);
                    }
                    else
                    {
                        List<DNA> popülasyon = (deneySetiOluştur(turistler, false));
                        DNA sonÇocuk = GenetikAlgoritmaÇalıştır(popülasyon, turistler, 1000, false);
                        int[] numaralar = sonÇocuk.getNumaralar;
                        enUygunAsansörYazdır(numaralar);
                        Console.Write("Minimum OITS: ");
                        Console.WriteLine("{0:N2}", sonÇocuk.getSüre);
                    }
                }
                else
                {
                    List<Turist> turistler = new List<Turist>();
                    turistOluştur(turistler, true);
                    List<Turist> turistlerCopy = turistler.ToList<Turist>();
                    asansörlereGönder(turistler, false);
                    string devam2 = "e";

                    while (devam2.Equals("e", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("1. Her bir turistin ITS ve OITS değerlerini, kazanç tablosunu görüntüle. (d)\n2. Kişiler için en uygun asansörü belirle. (e)");
                        Console.WriteLine("3. Merdiven ile sonuçları görüntüle. (f)");
                        int seçim3 = Convert.ToInt16(Console.ReadLine());

                        if (seçim3 == 1)
                        {
                            itsYazdır(turistler);
                            oitsYazdır(turistler);
                            tabloYazdır(turistler);
                        }
                        else if (seçim3 == 2)
                        {
                            List<DNA> popülasyon = (deneySetiOluştur(turistler, false));
                            DNA sonÇocuk = GenetikAlgoritmaÇalıştır(popülasyon, turistler, 1000, false);
                            int[] numaralar = sonÇocuk.getNumaralar;
                            double minimumOITS = sonÇocuk.getSüre;
                            enUygunAsansörYazdır(numaralar);
                            Console.Write("Minimum OITS: ");
                            Console.WriteLine("{0:N2}", minimumOITS);
                            oitsKazançYazdır(turistler, minimumOITS);

                        }
                        else
                        {
                            asansörlereGönder(turistlerCopy, false);
                            List<DNA> popülasyon = (deneySetiOluştur(turistler, true));
                            DNA sonÇocuk = GenetikAlgoritmaÇalıştır(popülasyon, turistler, 1000, true);
                            int[] numaralar = sonÇocuk.getNumaralar;
                            double minimumOITS = sonÇocuk.getSüre;
                            enUygunAsansörYazdır(numaralar);
                            Console.Write("Minimum OITS: ");
                            Console.WriteLine("{0:N2}", minimumOITS);

                            oitsKazançYazdır(turistler, minimumOITS);
                        }
                        Console.Write("Random üretilen veri setini yenilemek için e dışında herhangi bir tuşa tıklayınız.");
                        devam2 = Console.ReadLine();
                    }
                }
                Console.Write("Programa devam etmek için e tuşuna tıklayınız.");
                devam = Console.ReadLine();
            }


            Console.ReadKey();
        }

        static void enUygunAsansörYazdır(int[] numaralar)
        {
            Console.WriteLine("\nEN UYGUN ASANSÖRLER");
            Console.WriteLine("___________________\n");
            for (int i = 0; i < numaralar.Length; i++)
            {
                if (numaralar[i] == 0)
                {
                    Console.WriteLine(i + " numaralı kişi: FIFO");
                }
                else if (numaralar[i] == 1)
                {
                    Console.WriteLine(i + " numaralı kişi: PQ");
                }
                else
                {
                    Console.WriteLine(i + " numaralı kişi: Merdiven");
                }

            }
        }

        static void oitsKazançYazdır(List<Turist> turistler, double minimumOITS)
        {
            double toplamFIFOsüre = oitsToplamBul(turistler)[0];
            double toplamPQsüre = oitsToplamBul(turistler)[1];
            Console.Write("\nSadece FIFO asansörü kullanma durumuna göre süre kazancı: ");
            Console.WriteLine("{0:N2}", (toplamFIFOsüre / turistler.Count) - minimumOITS);
            Console.Write("Sadece PQ asansörü kullanma durumuna göre süre kazancı: ");
            Console.WriteLine("{0:N2}", (toplamPQsüre / turistler.Count) - minimumOITS);

        }

        static void oitsYazdır(List<Turist> turistler)
        {
            double[] toplamSüreler = oitsToplamBul(turistler);
            double toplamFIFOsüre = toplamSüreler[0];
            double toplamPQsüre = toplamSüreler[1];
            double randomToplam = oitsRandomToplamBul(turistler);

            Console.Write("\nFIFO OITS: ");
            Console.WriteLine("{0:N2}", toplamFIFOsüre / turistler.Count);
            Console.Write("PQ OITS: ");
            Console.WriteLine("{0:N2}", toplamPQsüre / turistler.Count);
            Console.Write("RANDOM OITS: ");
            Console.WriteLine("{0:N2}", randomToplam / turistler.Count);
        }

        static double[] oitsToplamBul(List<Turist> turistler)
        {
            double FIFOtoplam = 0;
            double PQtoplam = 0;

            double[] toplamlar = new double[3];

            foreach (Turist t in turistler)
            {
                FIFOtoplam += t.getFIFOsüre;
                PQtoplam += t.getPQsüre;

            }
            toplamlar[0] = FIFOtoplam; toplamlar[1] = PQtoplam;
            return toplamlar;
        }

        static double oitsRandomToplamBul(List<Turist> turistler)
        {
            double randomToplam = 0;

            foreach (Turist t in turistler)
            {
                randomToplam += t.getRandomSüre;
            }
            return randomToplam;
        }

        static void asansörlereGönder(List<Turist> turistler, bool merdiven_kontrol)
        {
            int döngüSay = (int)Math.Ceiling((double)turistler.Count / 4);
            asansörFIFOyaAl(döngüSay, turistler, false);
            asansörPQyaAl(döngüSay, turistler, false, merdiven_kontrol);
            RandomSırayaYerleştir(turistler, merdiven_kontrol);
        }

        static void itsYazdır(List<Turist> turistler)
        {
            Console.WriteLine("\nITS VE OITS DEĞERLERİ TABLOSU");
            Console.WriteLine("_____________________________\n");
            Console.WriteLine("Numara\tİsim\tKat Numarası\t" +
                "Sadece FIFO ITS\tSadece PQ ITS\tRandom ITS");

            foreach (Turist t in turistler)
            {
                Console.WriteLine(t.toString());
            }
        }

        static void tabloYazdır(List<Turist> turistler)
        {
            Console.WriteLine("\nKAZANÇ TABLOSU");
            Console.WriteLine("______________\n");
            Console.WriteLine("Numara\tPQ'nun FIFO'ya göre Süre Kazancı\tRandom durumun FIFO'ya göre Süre Kazancı");
            for (int i = 0; i < turistler.Count; i++)
            {
                double ilk_durum = turistler[i].getFIFOsüre - turistler[i].getPQsüre;
                double ikinci_durum = turistler[i].getFIFOsüre - turistler[i].getRandomSüre;

                if (ilk_durum > 0 && ikinci_durum > 0)
                {
                    Console.WriteLine(turistler[i].getNumara + "\t" + ilk_durum + " saniye\t\t\t\t" + ikinci_durum + " saniye");

                }
                else if (ikinci_durum > 0 && ilk_durum <= 0)
                {
                    Console.WriteLine(turistler[i].getNumara + "\t\t\t\t\t\t" + ikinci_durum + " saniye\t");
                }
                else if (ilk_durum > 0 && ikinci_durum <= 0)
                {
                    Console.WriteLine(turistler[i].getNumara + "\t" + ilk_durum + " saniye\t");
                }
            }
        }

        static List<DNA> deneySetiOluştur(List<Turist> turistler, bool merdiven_kontrol)
        {
            List<DNA> popülasyon = new List<DNA>();
            for (int i = 0; i < 10; i++) //n adet olmasını buradan ayarla
            {
                int[] numaralar = new int[turistler.Count];
                double[] deney = RandomSırayaYerleştir(turistler, merdiven_kontrol);

                for (int j = 0; j < turistler.Count; j++)
                {
                    numaralar[j] = Convert.ToInt32(deney[j]);
                }
                DNA birey = new DNA(deney[turistler.Count], numaralar);
                popülasyon.Add(birey);
            }
            return popülasyon;
        }

        static double MerdivenSüreHesapla(List<Turist> Merdiven)
        {
            double süre = 0;
            double toplamSüre = 0;

            for (int i = 0; i < Merdiven.Count; i++)
            {
                süre = Merdiven[i].getKatNo * 9;
                Merdiven[i].setRandomSüre = süre;
            }
            toplamSüre += süre;
            return toplamSüre;
        }

        public static DNA GenetikAlgoritmaÇalıştır(List<DNA> popülasyon, List<Turist> turistler, int generasyonSay, bool merdiven_kontrol) //int n: generasyon sayısı
        {
            for (int i = 0; i < generasyonSay; i++)
            {
                List<DNA> popülasyonCopy = popülasyon.ToList();
                popülasyonCopy.Sort((x, y) => x.getSüre.CompareTo(y.getSüre));
                popülasyon.Clear();
                popülasyon.Add(popülasyonCopy[0]);
                popülasyon.Add(popülasyonCopy[1]);
                popülasyon.Add(popülasyonCopy[2]);

                //GENETİK ALGORİTMANIN GENERASYONLARA GÖRE DAHA İYİ SONUÇLAR VERDİĞİNİ GÖZLEMLEMEK İÇİN: 
                //for (int t = 0; t < 10; t++)
                //{
                //    Console.WriteLine(popülasyonCopy[t].getSüre);
                //}
                //Console.WriteLine();

                for (int j = 0; j < popülasyonCopy.Count - 3; j++)
                {
                    int[] çocukNumaralar = GenetikAlgoritma.ParentBelirle(popülasyonCopy);
                    double çocukSüre = ÇocukAsansörAta(çocukNumaralar, turistler, merdiven_kontrol);
                    DNA çocuk = new DNA(çocukSüre, çocukNumaralar);
                    popülasyon.Add(çocuk);

                }
            }
            return popülasyon[0];
        }

        public static double ÇocukAsansörAta(int[] çocuk, List<Turist> turistler, bool merdiven_kontrol)
        {
            List<Turist> FIFOturistler = new List<Turist>();
            List<Turist> PQturistler = new List<Turist>();
            List<Turist> MerdivenTuristler = new List<Turist>();

            int index = 0;
            foreach (Turist t in turistler)
            {
                if (çocuk[index] == 0)
                {
                    t.setRandomNo = 0;
                    FIFOturistler.Add(t);
                }
                else if (çocuk[index] == 1)
                {
                    t.setRandomNo = 1;
                    PQturistler.Add(t);
                }
                else
                {
                    t.setRandomNo = 2;
                    MerdivenTuristler.Add(t);
                }
                index++;
            }
            double toplamSüre = toplamSüreBul(merdiven_kontrol, FIFOturistler, PQturistler, MerdivenTuristler);
            return toplamSüre;
        }

        static double[] RandomSırayaYerleştir(List<Turist> turistler, bool merdiven_kontrol)
        {
            List<Turist> FIFOturistler = new List<Turist>();
            List<Turist> PQturistler = new List<Turist>();
            List<Turist> MerdivenTuristler = new List<Turist>();

            double[] randomNumaralar = new double[turistler.Count + 1];
            int index = 0;

            foreach (Turist t in turistler)
            {
                int randomSıraNo;
                if (merdiven_kontrol)
                {
                    randomSıraNo = rand.Next(0, 3);
                }
                else
                {
                    randomSıraNo = rand.Next(0, 2);
                }
                switch (randomSıraNo)
                {
                    case 0:
                        FIFOturistler.Add(t);
                        t.setRandomNo = 0;
                        break;
                    case 1:
                        PQturistler.Add(t);
                        t.setRandomNo = 1;
                        break;
                    default:
                        MerdivenTuristler.Add(t);
                        t.setRandomNo = 2;
                        break;
                }
                randomNumaralar[index] = randomSıraNo;
                index++;

            }

            double toplamSüre = toplamSüreBul(merdiven_kontrol, FIFOturistler, PQturistler, MerdivenTuristler);
            randomNumaralar[turistler.Count] = toplamSüre / turistler.Count;
            return randomNumaralar;
        }

        static double toplamSüreBul(bool merdiven_kontrol, List<Turist> FIFOturistler, List<Turist> PQturistler, List<Turist> MerdivenTuristler)
        {
            int FdöngüSay = (int)Math.Ceiling((double)FIFOturistler.Count / 4);
            asansörFIFOyaAl(FdöngüSay, FIFOturistler, true);
            double oitsFIFO = oitsRandomToplamBul(FIFOturistler);


            int PdöngüSay = (int)Math.Ceiling((double)PQturistler.Count / 4);
            asansörPQyaAl(PdöngüSay, PQturistler, true, merdiven_kontrol);
            double oitsPQ = oitsRandomToplamBul(PQturistler);

            if (merdiven_kontrol)
            {
                double oitsMerdiven;
                oitsMerdiven = MerdivenSüreHesapla(MerdivenTuristler);
                return oitsFIFO + oitsPQ + oitsMerdiven;
            }
            return oitsPQ + oitsFIFO;
        }

        static void asansörFIFOyaAl(int döngüSay, List<Turist> turistler, bool rnd_kontrol)
        {
            AsansörFIFO asansörFIFO = new AsansörFIFO();

            for (int i = 0; i < turistler.Count; i++)
            {
                asansörFIFO.Enqueue(turistler[i]);
            }

            double toplamSüreGrup = 0;
            for (int i = 0; i < döngüSay; i++)
            {
                toplamSüreGrup = asansörFIFO.FIFOsüre(asansörFIFO, rnd_kontrol, toplamSüreGrup);

            }

        }

        static void asansörPQyaAl(int döngüSay, List<Turist> turistler, bool rnd_kontrol, bool merdiven_kontrol)
        {
            AsansörPQ asansörPQ;
            if (merdiven_kontrol)
            {
                asansörPQ = new AsansörPQ();
                asansörPQ.setKatÇıkışSüresi = 0.83;
            }
            else
            {
                asansörPQ = new AsansörPQ();
                asansörPQ.setKatÇıkışSüresi = 1.66;
            }
            for (int i = 0; i < turistler.Count; i++)
            {
                asansörPQ.Enqueue(turistler[i], turistler[i].getKatNo);
            }
            double toplamSüreGrup = 0;
            for (int i = 0; i < döngüSay; i++)
            {
                toplamSüreGrup += asansörPQ.PQsüre(asansörPQ, rnd_kontrol, toplamSüreGrup);
            }
        }

        static void turistOluştur(List<Turist> turistler, bool rnd_kontrol)
        {
            List<int> katlar = new List<int>();

            if (rnd_kontrol)
            {
                for (int i = 0; i < 43; i++)
                {
                    katlar.Add(rand.Next(1, 51));
                }
            }
            else
            {
                katlar.InsertRange(katlar.Count, new int[] { 3, 8, 8, 4, 4, 1, 1, 3, 2, 5, 6, 8, 1, 5, 7, 6, 3, 7, 2, 7 });
            }

            for (int i = 0; i < katlar.Count; i++)
            {
                Turist turist = new Turist(katlar[i], i, nameGenerator());
                turistler.Add(turist);
            }

        }

        static String nameGenerator()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[5];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[rand.Next(chars.Length)];
            }
            String name = new String(stringChars);
            return name;
        }
    }
}