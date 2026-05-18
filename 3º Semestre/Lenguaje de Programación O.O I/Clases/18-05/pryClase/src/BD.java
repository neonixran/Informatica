/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author iryde
 */
import java.sql.*;

public class BD {

    private String ruta_bd;
    private String usuario_bd;
    private String contraseña_bd;

    public BD(String usuario_bd, String contraseña_bd) {
        this.usuario_bd = usuario_bd;
        this.contraseña_bd = contraseña_bd;
        
        try {
            Connection cn = DriverManager.getConnection(ruta_bd, usuario_bd, contraseña_bd);
        } catch(SQLException e) {
            System.out.println(e.getMessage());
        }
    }
    
    public boolean consultar() {
        
    }
    
    public boolean agregar() {
        
    }
    
    public boolean modificar() {
        
    }
    
    public boolean eliminar() {
        
    }
}
