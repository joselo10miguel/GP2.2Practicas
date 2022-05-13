
package Modelo;

import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.JOptionPane;

public class RutaDao 
{
    public void registrarRuta( RutaVo miRuta)
    {
        
        Conexion conex=new Conexion();
        try
        {
            Statement orden= conex.getConexion().createStatement();
            orden.executeUpdate("INSERT INTO ruta VALUES("+miRuta.getIdRuta()+",'"+miRuta.getOrigen()+"','"+miRuta.getDestino()+"');");
            JOptionPane.showMessageDialog(null,"se ha registrado ok");
            orden.close();
            conex.desconectar();
        }catch(SQLException e)
        {
            System.out.println(e.getMessage());
            JOptionPane.showMessageDialog(null,"No se registro");

        }
    }
     
    public void modificarRuta(RutaVo miRuta){
        Conexion conex=new Conexion();
        try{
            String sentencia="UPDATE ruta SET IdRuta=?, Origen=?, Destino=? WHERE IdRuta=?";
            PreparedStatement estatuto=conex.getConexion().prepareStatement(sentencia);
            estatuto.setString(1, miRuta.getIdRuta());
            estatuto.setString(2, miRuta.getOrigen());
            estatuto.setString(3, miRuta.getDestino());
            estatuto.setString(4, miRuta.getIdRuta());            
            estatuto.executeUpdate();
            JOptionPane.showMessageDialog(null, "Se ha modificado correctamente");
        }catch(SQLException e){
            System.out.println(e.getMessage());
            JOptionPane.showMessageDialog(null, "Error al modificar");
        }
    }
    
    public void eliminarRuta(String codigo){
        Conexion conex=new Conexion();
        try{
            Statement estatuto=conex.getConexion().createStatement();
            estatuto.executeUpdate("DELETE FROM ruta WHERE IdRuta="+codigo+"");
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
