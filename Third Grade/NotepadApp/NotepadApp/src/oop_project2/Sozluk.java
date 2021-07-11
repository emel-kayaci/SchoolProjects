/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oop_project2;

import java.util.ArrayList;

/**
 *
 * @author Mehmet Anıl TAYSİ
 */
public interface Sozluk {
    
    //Sozluk olusturmak icin faktor metod, farkli dosya tipinde sozlukler olursa buradan tanimlanabilir.
    
    ArrayList<String> sozluguAktar(String DosyaAdi);
}
