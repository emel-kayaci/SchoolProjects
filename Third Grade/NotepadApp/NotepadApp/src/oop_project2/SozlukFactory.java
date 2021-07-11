/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oop_project2;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

/**
 *
 * @author Mehmet Anıl TAYSİ
 */
public class SozlukFactory implements Sozluk{

    @Override
    public ArrayList<String> sozluguAktar(String DosyaAdi) {
                                                                               
        //SOZLUK AKTARIMININ Sozluk interface'i üzerinde FACTORY METOD ile sağlanması
        ArrayList<String> sozluk = new ArrayList<>();
        BufferedReader bf = null;
        try {
            String currentLine;
            bf = new BufferedReader(new FileReader(DosyaAdi));
            while ((currentLine = bf.readLine()) != null) {
                sozluk.add(currentLine);
            }
        } catch (IOException e) {
        } finally {
            try {
                if (bf != null) {
                    bf.close();
                }
            } catch (IOException ex) {
            }
        }
        return sozluk;
    }

}
    
    
    

