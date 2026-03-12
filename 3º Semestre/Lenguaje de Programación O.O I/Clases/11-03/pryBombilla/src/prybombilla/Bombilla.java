/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package prybombilla;

/**
 *
 * @author iryde
 */
public class Bombilla {
    public boolean estado = false;
    public int tipo;
    public int serie;
    
    public void Encender() {
        estado = true;
    }
    
    public void Apagar() {
        estado = false;
    }
  
    public void obtenerDetalles() {
        System.out.println("La bombilla está " + (estado ? "encendida" : "apagada") + " y es de tipo " + tipo + " de la serie " + serie);
    }
}
