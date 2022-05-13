
package Modelo;

import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.JOptionPane;

public class UsuarioDao 
{
     public void registrarUsuario( UsuarioVo miUsuario)
    {
        
        Conexion conex=new Conexion();
        try
        {
            Statement orden= conex.getConexion().createStatement();
            orden.executeUpdate("INSERT INTO usuario VALUES("+miUsuario.getCedula()+",'"+miUsuario.getNombre1()+"','"+miUsuario.getNombre2()
            +"','"+miUsuario.getApellido1()+"','"+miUsuario.getApellido2()+"','"+miUsuario.getUsername()+"','"+miUsuario.getPassword()+"');");
            JOptionPane.showMessageDialog(null,"se ha registrado ok");
            orden.close();
            conex.desconectar();
        }catch(SQLException e)
        {
            System.out.println(e.getMessage());
            JOptionPane.showMessageDialog(null,"No se registro");

        }
    }
     
    public void modificarUsuario(UsuarioVo miUsuario){
        Conexion conex=new Conexion();
        try{
            String sentencia="UPDATE usuario SET Cedula=?, Nombre1=?, Nombre2=?, Apellido1=?, Apellido2=?, Username=?, Password=? WHERE Cedula=?";
            PreparedStatement estatuto=conex.getConexion().prepareStatement(sentencia);
            estatuto.setString(1, miUsuario.getCedula());
            estatuto.setString(2, miUsuario.getNombre1());
            estatuto.setString(3, miUsuario.getNombre2());
            estatuto.setString(4, miUsuario.getApellido1());
            estatuto.setString(5, miUsuario.getApellido2());
            estatuto.setString(6, miUsuario.getUsername());
            estatuto.setString(7, miUsuario.getPassword());
            estatuto.setString(8, miUsuario.getCedula());
            estatuto.executeUpdate();
            JOptionPane.showMessageDialog(null, "Se ha modificado correctamente");
        }catch(SQLException e){
            System.out.println(e.getMessage());
            JOptionPane.showMessageDialog(null, "Error al modificar");
        }
    }
    
    public void eliminarUsuario(String codigo){
        Conexion conex=new Conexion();
        try{
            Statement estatuto=conex.getConexion().createStatement();
            estatuto.executeUpdate("DELETE FROM usuario WHERE Cedula="+codigo+"");
            JOptionPane.showMessageDialog(null, "Se ha eliminado correctamente");
            estatuto.close();
            conex.desconectar();
        }
        catch(SQLException e){
            System.out.println(e.getMessage());
            JOptionPane.showMessageDialog(null, "Error al eliminar");
        }
    }
}
