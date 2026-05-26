/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author iryde
 */
import java.sql.*;

public class ConectorBD {

    private String baseDatos;
    private String usuario;
    private String contraseña;

    public ConectorBD() {
        this.baseDatos = "world";
        this.usuario = "root";
        this.contraseña = "";
    }

    public ConectorBD(String baseDatos) {
        this.baseDatos = baseDatos;
        this.usuario = "root";
        this.contraseña = "";
    }

    public ConectorBD(String baseDatos, String usuario, String contraseña) {
        this.baseDatos = baseDatos;
        this.usuario = usuario;
        this.contraseña = contraseña;
    }

    private Connection conectar() throws SQLException {
        Connection cn = DriverManager.getConnection("jdbc:mysql://localhost:3306/" + this.baseDatos, this.usuario, this.contraseña);
        return cn;
    }

    public ResultSet consultar(String sql, Object... parametros) throws SQLException {
        Connection conexion = this.conectar();

        PreparedStatement ps = conexion.prepareStatement(sql);
        
        for (int i = 0; i < parametros.length; i++) {
            ps.setObject(i+1, parametros[i]);
        }
        
        ResultSet rs = ps.executeQuery();
        
        return rs;
    }
    
    public int modificar(String sql, Object... parametros) throws SQLException {
        Connection conexion = this.conectar();
        
        PreparedStatement ps = conexion.prepareStatement(sql);
        
        for (int i = 0; i < parametros.length; i++) {
            ps.setObject(i+1, parametros[i]);
        }
        
        int cantidad = ps.executeUpdate();
        
        return cantidad;
    }
}
