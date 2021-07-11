
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.StringTokenizer;

public class Sınıflandırma {

    static Scanner scan = new Scanner(System.in);

    public static void main(String[] args) {

        ArrayList<Zambak> zambakList = dosyaOku();
        //başarı ölçümünün eklenen veya silinen verilerden etkilenmemesi için zambak listesi kopyalandı
        ArrayList<Zambak> başarıÖlçümListesi = (ArrayList<Zambak>) zambakList.clone(); 

        String devam = "e";

        System.out.println("MENÜ");

        System.out.println("Bitki sınıflandırması yapmak için 1'i \n"
                + "Verisetine yeni örnek çiçek verisi eklemek için 2'yi \n"
                + "Verisetinden çiçek verisi silmek için için 3'ü \n"
                + "Başarı ölçümü için 4'ü \n"
                + "Verisetindeki tüm çiçek verilerini görmek için 5'i tıklayınız.");

        while (devam.equalsIgnoreCase("e")) {

            System.out.println("Menüden seçiminizi yapınız.");

            int seçim = scan.nextInt();
            scan.nextLine();

            switch (seçim) {
                case 1:
                    if (zambakList.isEmpty()) {
                        System.out.println("Verisetinde veri bulunmamaktadır. Sınıflandırma yapılamaz.");
                    }
                    bitkiyiSınıflandır(zambakList);
                    scan.nextLine();
                    break;
                case 2:
                    veriEkle(zambakList);
                    break;
                case 3:
                    System.out.println("İndisi girilen veriyi silmek için 1'i \n"
                            + "Tüm verileri silmek için 2'yi tıklayınız.");
                    int silmeSeçim = scan.nextInt();

                    scan.nextLine();
                    switch (silmeSeçim) {
                        case 1:
                            System.out.print("Silinecek verinin indisini giriniz: ");
                            int silinecekVeri = scan.nextInt();
                            scan.nextLine();
                            veriSil(zambakList, silinecekVeri);
                            System.out.println(silinecekVeri + " indisinde bulunan veri silindi.");
                            break;
                        case 2:
                            tümünüSil(zambakList);
                            System.out.println("Listede bulunan tüm veriler silindi.");
                            break;
                    }
                    break;
                case 4:

                    başarıÖlç(başarıÖlçümListesi);
                    scan.nextLine();

                    break;
                case 5:
                    if (zambakList.isEmpty()) {

                        System.out.println("Listede veri bulunmamaktadır.");

                    }
                    listeyiYazdir(zambakList);
                    break;
            }

            System.out.println("Programdan çıkmak için e dışındaki herhangi bir tuşa basınız.");
            devam = scan.nextLine();

        }
    }

    static ArrayList<Zambak> dosyaOku() {

        ArrayList<Zambak> zambakList = new ArrayList<>();

        Scanner file = null;
        try {
            file = new Scanner(new FileInputStream("iris.txt"));
        } catch (FileNotFoundException e) {
            System.out.println("File not found");
            System.exit(0);
        }

        while (file.hasNextLine()) {
            String line = file.nextLine();
            StringTokenizer token = new StringTokenizer(line, ",");

            double çanakUz = Double.parseDouble(token.nextToken());
            double çanakGen = Double.parseDouble(token.nextToken());
            double taçUz = Double.parseDouble(token.nextToken());
            double taçGen = Double.parseDouble(token.nextToken());
            String tür = token.nextToken();

            Zambak zambak = new Zambak(çanakUz, çanakGen, taçUz, taçGen, tür);
            zambakList.add(zambak);
        }
        return zambakList;
    }

    //tüm verisetini yazdırır
    static void listeyiYazdir(ArrayList<Zambak> zambakList) {

        zambakList.forEach((zambak) -> {
            System.out.println(zambak.toString());
            System.out.println(" ");
        });

    }

    static void veriEkle(ArrayList<Zambak> zambakList) {

        double[] çanakYap = yaprakVerisiAl("Çanak");
        double[] taçYap = yaprakVerisiAl("Taç");
        scan.nextLine();
        System.out.print("Tür giriniz: ");
        String tür = scan.nextLine();

        Zambak zambak = new Zambak(çanakYap[0], çanakYap[1], taçYap[0], taçYap[1], tür);

        zambakList.add(zambak);

    }

    static void veriSil(ArrayList<Zambak> zambakList, int silinecekIndex) {
        zambakList.remove(silinecekIndex);
    }

    static void tümünüSil(ArrayList<Zambak> zambakList) {
        zambakList.clear();
    }

    //öklid uzaklıkları bulunur, sıralanır, tür tahmini yapılır ve en yakın zambaklar yazdırılır
    static void bitkiyiSınıflandır(ArrayList<Zambak> zambakList) {

        System.out.print("kNN algoritmasında kullanılacak k değerini giriniz: ");
        int k = scan.nextInt();

        System.out.println("\nAşağıdaki seçeneklere göre seçiminizi giriniz. (1/2/3)"
                + "\n 1. Sınıflandırmak istenilen çiçeğin 4 adet özelliği girdi olarak alınacak."
                + "\n 2. Sınıflandırmak istenilen çiçeğin 2 adet çanak yaprak özelliği (uzunluk ve genişlik) girdi olarak alınacak."
                + "\n 3. Sınıflandırmak istenilen çiçeğin 2 adet taç yaprak özelliği (uzunluk ve genişlik) girdi olarak alınacak.");
        int secim = scan.nextInt();
        double[][] uzakliklar;
        double[] çanakYap;
        double[] taçYap;
        String tür;
        Zambak zambak = new Zambak();

        switch (secim) {
            case 1:
                çanakYap = yaprakVerisiAl("Çanak");
                taçYap = yaprakVerisiAl("Taç");
                zambak = new Zambak(çanakYap[0], çanakYap[1], taçYap[0], taçYap[1]);
                uzakliklar = uzaklikBul(zambakList, zambak, 1, zambakList.size());
                uzakliklariSirala(uzakliklar);
                tür = türüTahminEt(k, uzakliklar, zambakList);
                enYakınZambaklarıYazdir(k, uzakliklar, zambakList);
                System.out.println("Tahmin edilen tür: " + tür);

                break;

            case 2:
                çanakYap = yaprakVerisiAl("Çanak");
                zambak.setÇanakUz(çanakYap[0]);
                zambak.setÇanakGen(çanakYap[1]);
                uzakliklar = uzaklikBul(zambakList, zambak, 2, zambakList.size());
                uzakliklariSirala(uzakliklar);
                tür = türüTahminEt(k, uzakliklar, zambakList);
                enYakınZambaklarıYazdir(k, uzakliklar, zambakList);
                System.out.println("Tahmin edilen tür: " + tür);
                break;

            case 3:
                taçYap = yaprakVerisiAl("Taç");
                zambak.setTaçUz(taçYap[0]);
                zambak.setTaçGen(taçYap[1]);
                uzakliklar = uzaklikBul(zambakList, zambak, 3, zambakList.size());
                uzakliklariSirala(uzakliklar);
                tür = türüTahminEt(k, uzakliklar, zambakList);
                enYakınZambaklarıYazdir(k, uzakliklar, zambakList);
                System.out.println("Tahmin edilen tür: " + tür);
                break;
        }

    }

    static double[][] uzaklikBul(ArrayList<Zambak> zambakList, Zambak yeniDeğer, int durum, int karsilastirmaSay) {

        double[][] uzakliklar = new double[karsilastirmaSay][2]; 
        double uzaklik = 0;
        double index = 0;
        int i = 0;
        for (Zambak zambak : zambakList) {
            index = zambakList.indexOf(zambak);
            uzaklik = 0;
            //öklid uzaklıkları hesaplanıyor
            switch (durum) {
                case 1:
                    uzaklik += Math.sqrt(Math.pow(zambak.getÇanakUz() - yeniDeğer.getÇanakUz(), 2)
                            + Math.pow(zambak.getÇanakGen() - yeniDeğer.getÇanakGen(), 2)
                            + Math.pow(zambak.getTaçUz() - yeniDeğer.getTaçUz(), 2)
                            + Math.pow(zambak.getTaçGen() - yeniDeğer.getTaçGen(), 2));
                    break;
                case 2:
                    uzaklik += Math.sqrt(Math.pow(zambak.getÇanakUz() - yeniDeğer.getÇanakUz(), 2)
                            + Math.pow(zambak.getÇanakGen() - yeniDeğer.getÇanakGen(), 2));
                    break;
                default:
                    uzaklik += Math.sqrt(Math.pow(zambak.getTaçUz() - yeniDeğer.getTaçUz(), 2)
                            + Math.pow(zambak.getTaçGen() - yeniDeğer.getTaçGen(), 2));
                    break;
            }

            uzakliklar[i][0] = uzaklik;
            uzakliklar[i][1] = index;
            i++;

        }

        return uzakliklar;
    }

    //öklid uzaklıkları küçükten büyüğe sıralanır
    static double[][] uzakliklariSirala(double[][] uzakliklar) {
        java.util.Arrays.sort(uzakliklar, (double[] a, double[] b) -> Double.compare(a[0], b[0]));
        return uzakliklar;
    }

    static double[] yaprakVerisiAl(String tür) {

        System.out.print(tür + " yaprak uzunluğunu giriniz: ");
        double yapUz = scan.nextDouble();
        System.out.print(tür + " yaprak genişliğini giriniz: ");
        double yapGen = scan.nextDouble();

        double[] yaprak = new double[2];
        yaprak[0] = yapUz;
        yaprak[1] = yapGen;

        return yaprak;
    }

    //k en yakın komşu verileri yazdırılıyor
    static void enYakınZambaklarıYazdir(int k, double[][] sıralıUzaklıklar, ArrayList<Zambak> zambakList) {

        System.out.println("Örnek" + "\tÇanUz" + "\tÇanGen"
                + "\tTaçUz" + "\tTaçGen" + "\tTür" + "\t\tUzaklık");

        for (int i = 0; i < k; i++) {
            int index = (int) sıralıUzaklıklar[i][1];

            System.out.println((i + 1) + "\t" + zambakList.get(index).getÇanakUz() + "\t" + zambakList.get(index).getÇanakGen()
                    + "\t" + zambakList.get(index).getTaçUz() + "\t" + zambakList.get(index).getTaçGen()
                    + "\t" + zambakList.get(index).getTür() + "\t" + sıralıUzaklıklar[i][0]);

        }

    }

    static String türüTahminEt(int k, double[][] sıralıUzaklıklar, ArrayList<Zambak> zambakList) {

        int setosaSay = 0;
        int versicolorSay = 0;
        int virginicaSay = 0;

        for (int i = 0; i < k; i++) {

            int index = (int) sıralıUzaklıklar[i][1];

            String benzerTür = zambakList.get(index).getTür();

            switch (benzerTür) {
                case "Iris-setosa":
                    setosaSay += 1;
                    break;
                case "Iris-virginica":
                    virginicaSay += 1;
                    break;
                default:
                    versicolorSay += 1;
                    break;
            }

        }

        if (setosaSay > versicolorSay && setosaSay > virginicaSay) {
            return "Iris-setosa";
        } else if (versicolorSay > setosaSay && versicolorSay > virginicaSay) {
            return "Iris-versicolor";
        } else if (virginicaSay > setosaSay && virginicaSay > versicolorSay) {
            return "Iris-virginica";
        } else {
            return zambakList.get((int) sıralıUzaklıklar[0][1]).getTür();
        }

    }

    //başarı ölçümü için veriseti test ve karşılaştırma verilerine bölünür
    static void başarıÖlç(ArrayList<Zambak> zambakList) {
        System.out.print("kNN algoritmasında kullanılacak k değerini giriniz: ");
        int k = scan.nextInt();

        ArrayList<Zambak> test = new ArrayList<>();
        test.addAll(zambakList.subList(40, 50));
        test.addAll(zambakList.subList(90, 100));
        test.addAll(zambakList.subList(140, 150));

        ArrayList<Zambak> karsilastirma = new ArrayList<>();
        karsilastirma.addAll(zambakList.subList(0, 40));

        karsilastirma.addAll(zambakList.subList(50, 90));

        karsilastirma.addAll(zambakList.subList(100, 140));

        int dogruTahminSay = testVeriSınıflandır(karsilastirma, test, k);
        başarıOranıÖlç(dogruTahminSay);

    }
    
    //kullanılan test verilerinde tür tahmini yapar
    static int testVeriSınıflandır(ArrayList<Zambak> karsilastirma, ArrayList<Zambak> test, int k) {

        int dogruTahminSay = 0;

        for (Zambak zambak : test) {

            double[][] uzakliklar = uzaklikBul(karsilastirma, zambak, 1, 120);
            uzakliklariSirala(uzakliklar);
            String tür = türüTahminEt(k, uzakliklar, karsilastirma);
            enYakınZambaklarıYazdir(k, uzakliklar, karsilastirma);
            System.out.println("Tahmin edilen tür: " + tür);
            System.out.println("Gerçek tür: " + zambak.getTür() + "\n");

            if (zambak.getTür().equals(tür)) {

                dogruTahminSay++;

            }

        }

        return dogruTahminSay;
    }

    static void başarıOranıÖlç(int dogruTahmin) {
        double başarıOranı = (double) dogruTahmin / 30;
        System.out.println("Başarı oranı: " + başarıOranı);
    }
}
