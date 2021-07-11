/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oop_project2;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import javax.swing.JTextArea;
import static oop_project2.MainForm.filePath;

/**
 *
 * @author Mehmet Anıl TAYSİ
 */
public class Kaydet implements Strategy {

    @Override
    public void kaydetmeCesidi(JTextArea textArea) {
         
        try {
            BufferedWriter bf = new BufferedWriter(new FileWriter(filePath));
            bf.write(textArea.getText());
            bf.flush();
            bf.close();
        } catch (IOException e) {
        }
    }
    
    
    
    
}
