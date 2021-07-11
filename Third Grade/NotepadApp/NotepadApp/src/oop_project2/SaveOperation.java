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
public class SaveOperation {
    
    //kaydetme operasyonunun gerçkelştirimini sağlayan sınıf
    
    private Strategy strategy;
    
    public SaveOperation(Strategy strategy){
        this.strategy=strategy;
    }
    
    public void executeStrategy(JTextArea textArea){
        strategy.kaydetmeCesidi(textArea);
    }
}
