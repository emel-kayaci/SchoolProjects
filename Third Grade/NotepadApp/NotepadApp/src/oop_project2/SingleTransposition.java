package oop_project2;


import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;

public class SingleTransposition {

    
    public static ArrayList<String> yanlislariBul(String metin, ArrayList<String> sozluk) {

        ArrayList<String> yanlisKelimeler = new ArrayList<>();                  //MainFormdaki TextAreaya girilecek metinin yanlis kelimelerini verilen sozluge göre bulmak.
                                                                                //Formdaki yanlısları bul tusu üzerinden yanlislar tespit edilebilir.
        String[] tokens = metin.split("[^a-zA-Z]+");
        
        String tokenCopy;
        for (String token: tokens) {
           tokenCopy=token.toLowerCase();                                       //copy lower case oldu ama kelime orijinal haliyle yüklendi.
            
            if (!sozluk.contains(tokenCopy)) {
                yanlisKelimeler.add(token);
            }
        }
        return yanlisKelimeler;
    }

    public static Map<String, String> yanlislariDuzelt(ArrayList<String> yanlisKelimeler, ArrayList<String> sozluk) {

        Map<String, String> duzeltilen = new HashMap<>(); 
                                                                                //SingleTransposition gereğini yerine getiren metod. 
        sozluk.forEach((kelime) -> {
           
            //yanlisKelimeler ArrayList'ini dolaşma yapısı ITERATOR ile gerçekleştirildi
            Iterator itr = yanlisKelimeler.iterator();
            while(itr.hasNext()){
                
                String yanlisKelime = (String)itr.next();
                String yanlisKelimeCopy = yanlisKelime;                         //çok önemli, eğer lowercase olmazsa sözlükten karşılaştıramıyor ve hata görmüyor.
                
                if (yanlisKelime.length() == kelime.length()) {
                    yanlisKelimeCopy=yanlisKelimeCopy.toLowerCase();
                    
                    char[] kelimeKarakter = kelime.toCharArray();
                    char[] yanlisKelimeKarakter = yanlisKelimeCopy.toCharArray();

                    Arrays.sort(kelimeKarakter);
                    Arrays.sort(yanlisKelimeKarakter);

                    int comp = 0;
                  
                    for (int i = 0; i < kelimeKarakter.length; i++) {
                        if (kelimeKarakter[i] == yanlisKelimeKarakter[i]) {
                        } else {
                            comp++;
                        }
                    }

                    int maksYerDegistirme = 0;
                    if (comp == 0) {

                        kelimeKarakter = kelime.toCharArray();
                        yanlisKelimeKarakter = yanlisKelimeCopy.toCharArray();

                        for (int i = 0; i < kelimeKarakter.length; i++) {
                            if (kelimeKarakter[i] != yanlisKelimeKarakter[i]) {
                                maksYerDegistirme++;
                            }
                        }
                    }

                    if (maksYerDegistirme == 2) {
                        duzeltilen.put(yanlisKelime, kelime);
                    }

                }
                
                    
            }
        });
        return duzeltilen;
    }
}
