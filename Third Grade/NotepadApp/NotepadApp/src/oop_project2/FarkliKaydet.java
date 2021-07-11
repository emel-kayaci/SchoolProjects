/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oop_project2;

import java.io.File;
import javax.swing.JFileChooser;
import javax.swing.JTextArea;
import javax.swing.filechooser.FileNameExtensionFilter;
import static oop_project2.MainForm.filePath;

/**
 *
 * @author Mehmet Anıl TAYSİ
 */
public class FarkliKaydet implements Strategy {

    
    //FarkliKaydetin icinde kaydet yeniden cagiriliyor, kaydetmenin gerceklestirilmesi icin
    @Override
    public void kaydetmeCesidi(JTextArea textArea) {
       
        JFileChooser fc = new JFileChooser();
        FileNameExtensionFilter filter = new FileNameExtensionFilter(".txt files", "txt", "text");
        fc.setFileFilter(filter);
        int result = fc.showSaveDialog(fc);

        File selectedFile;                                                      
        if (result == JFileChooser.APPROVE_OPTION) {
            selectedFile = new File(fc.getSelectedFile() + ".txt");
            filePath = selectedFile.getPath();
        }
        Kaydet kyd = new Kaydet();
        kyd.kaydetmeCesidi(textArea);
    }
    
    
}
