/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oop_project2;

import javax.swing.JTextArea;

/**
 *
 * @author Mehmet Anıl TAYSİ
 */
public interface Strategy {
    
    //farkli kaydet ve kaydet seçenekleri STRATEGY design pattern kullanılarak yeniden tasarlanmıştır
    public void kaydetmeCesidi(JTextArea textArea);
}
