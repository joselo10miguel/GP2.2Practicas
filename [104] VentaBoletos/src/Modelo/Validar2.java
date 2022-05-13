package Modelo;

import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import javax.swing.JComboBox;
import javax.swing.JTextField;

/**
 *
 * @author Navarrete
 */
public class Validar2 {
    
    public void validarLetras(JTextField campo)
    {
        campo.addKeyListener(new KeyAdapter(){
            public void keyTyped(KeyEvent e){
                char c=e.getKeyChar();
                if(Character.isDigit(c)){
                    e.consume();
                }
            }
        });
    }
    
    public void validarNumeros(JTextField campo)
    {
        campo.addKeyListener(new KeyAdapter(){
            public void keyTyped(KeyEvent e){
                char c=e.getKeyChar();
                    if(!Character.isDigit(c) &&  c!='.'){
                    e.consume();
                }
            }
        });
    }
    
    public void validarNumerosComboBox(JComboBox campo)
    {
        campo.addKeyListener(new KeyAdapter(){
            public void keyTyped(KeyEvent e){
                char c=e.getKeyChar();
                    if(!Character.isDigit(c) && (c!='.' || c!=',')){
                    e.consume();
                }
            }
        });
    }
    
    public void limitarCaracteres(JTextField campo,int cantidad)
    {
        campo.addKeyListener(new KeyAdapter(){
            public void keyTyped(KeyEvent e){
                char c=e.getKeyChar();
                int tam=campo.getText().length();
                if(tam>=cantidad){
                    e.consume();
                }
            }
        });
    }
    
    public void crearCaracteres(JTextField campo)
    {
        campo.addKeyListener(new KeyAdapter(){
            public void keyTyped(KeyEvent e){
                char c=e.getKeyChar();
                int tam=campo.getText().length();
                if(tam==3){
                    campo.setText(campo.getText()+"-");
                }
                else if(tam==7){
                    campo.setText(campo.getText()+"-");
                }
            }
        });
    }
    
    public void caducaFecha(JTextField campo)
    {
        campo.addKeyListener(new KeyAdapter(){
            public void keyTyped(KeyEvent e){
                char c=e.getKeyChar();
                int tam=campo.getText().length();
                if(tam==2){
                    campo.setText(campo.getText()+"/");
                }
                else if(tam==5){
                    campo.setText(campo.getText()+"/");
                }
            }
        });
    }
    
    public boolean validacionCedula(String cedula){
        int num_provincias = 24;
        //verifica que los dos primeros dígitos correspondan a un valor entre 1 y NUMERO_DE_PROVINCIAS
        int prov = Integer.parseInt(cedula.substring(0, 2));

        if (!((prov > 0) && (prov <= num_provincias))) {
                //addError("La cédula ingresada no es válida");
                System.out.println("Error: cedula incorrecta");
            return false;
        }

        //verifica que el último dígito de la cédula sea válido
        int[] d = new int[10];
        //Asignamos el string a un array
        for (int i = 0; i < d.length; i++) {
            d[i] = Integer.parseInt(cedula.charAt(i) + "");
        }

        int imp = 0;
        int par = 0;

        //sumamos los duplos de posición impar
        for (int i = 0; i < d.length; i += 2) {
            d[i] = ((d[i] * 2) > 9) ? ((d[i] * 2) - 9) : (d[i] * 2);
            imp += d[i];
        }

        //sumamos los digitos de posición par
        for (int i = 1; i < (d.length - 1); i += 2) {
            par += d[i];
        }

        //Sumamos los dos resultados
        int suma = imp + par;

        //Restamos de la decena superior
        int d10 = Integer.parseInt(String.valueOf(suma + 10).substring(0, 1) +
                "0") - suma;

        //Si es diez el décimo dígito es cero        
        d10 = (d10 == 10) ? 0 : d10;

        //si el décimo dígito calculado es igual al digitado la cédula es correcta
        if (d10 == d[9]) {
                return true;
        }else {
                //addError("La cédula ingresada no es válida");
                return false;
        }
    }
}
