/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oop_project2;

import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JTextArea;
import javax.swing.text.BadLocationException;

/**
 *
 * @author Mehmet Anıl TAYSİ
 */
public class UndoCommand implements Command {
    
    private final JTextArea areaCommand;
    
    public UndoCommand(JTextArea areaGUI){
        areaCommand = areaGUI;
    }

    @Override
    public void execute() {
         try {
            if (areaCommand.getText().length() != 0) {
                areaCommand.setText(areaCommand.getText(0, areaCommand.getText().length() - 1));
            }
        } catch (BadLocationException ex) {
            Logger.getLogger(MainForm.class.getName()).log(Level.SEVERE, null, ex);
        }

    }
    
}
