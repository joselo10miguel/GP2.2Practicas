/*
Esta clase se la crea para realizar las operaciones de la Clase Producto, sobre ella se realiza
el CRUD (Create-Insert, Read-Select, U-Update, D-Delete)
*/
package OperaBase;

import Modelo.Producto;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class DATProducto extends Conexion{
    /*Método que permite realizar el registro de los datos hacia la base de datos
    Hace uso de una de las formas para enviar los datos a la Base dee Datos, en este caso PreparedStatement.
    El método es boolean, permite retornar true o false en caso de que el registro sea exitoso o no.
    Si visualiza no se envia el ID como parámetro, debido a que esto en la base está como Autonumérico
    Al metodo llega un parámetro de tipo Producto, es decir un objeto
    */
    
    public boolean Registrar(Producto pro) {
        PreparedStatement ps = null;
        Connection con = getConexion();
        String sql = "INSERT INTO producto (codigo, nombre, precio, cantidad) VALUES (?,?,?,?)";
        try {
            ps = con.prepareStatement(sql);
            ps.setString(1, pro.getCodigo());
            ps.setString(2, pro.getNombre());
            ps.setDouble(3, pro.getPrecio());
            ps.setInt(4, pro.getCantidad());
            ps.execute();
            return true;
        } catch (Exception e) {
            System.err.println(e);
            return false;
        } finally {
            try {
                con.close();
            } catch (SQLException e) {
                System.err.println(3);
            }
        }
    }
    /*Método para Modificar un objeto de la clase Producto, llega como parámetro pro que es de tipo Producto.
    La actualización siempre se hace sobre un condicional que re ubica como parte del Where*/
    public boolean Modificar (Producto pro) {
        PreparedStatement ps = null;
        Connection con = getConexion();
        String sql = "UPDATE producto SET codigo=?, nombre=?, precio=?, cantidad=? WHERE id=?";
        try {
            ps = con.prepareStatement(sql);
            ps.setString(1, pro.getCodigo());
            ps.setString(2, pro.getNombre());
            ps.setDouble(3, pro.getPrecio());
            ps.setInt(4, pro.getCantidad());
            ps.setInt(5, pro.getId());
            ps.execute();
            return true;
        } catch (Exception e) {
            System.err.println(e);
            return false;
        } finally {
            try {
                con.close();
            } catch (SQLException e) {
                System.err.println(3);
            }
        }
    }
    /*Método para eliminar un objeto de tipo Producto*/
    public boolean Eliminar (Producto pro) {
        PreparedStatement ps = null;
        Connection con = getConexion();
        String sql = "DELETE FROM producto WHERE id=?";
        try {
            ps = con.prepareStatement(sql);
            ps.setInt(1, pro.getId());
            ps.execute();
            return true;
        } catch (Exception e) {
            System.err.println(e);
            return false;
        } finally {
            try {
                con.close();
            } catch (SQLException e) {
                System.err.println(3);
            }
        }
    }
    /*Método para buscar un objeto de tipo Producto*/
    public boolean Buscar (Producto pro) {
        PreparedStatement ps = null;
        ResultSet rs = null;
        Connection con = getConexion();
        String sql = "SELECT * FROM producto WHERE codigo=?";
        try {
            ps = con.prepareStatement(sql);
            ps.setString(1, pro.getCodigo());
            rs = ps.executeQuery();
            if (rs.next()) {
                pro.setId(Integer.parseInt(rs.getString("id")));
                pro.setCodigo(rs.getString("codigo"));
                pro.setNombre(rs.getString("nombre"));
                pro.setPrecio(Double.parseDouble(rs.getString("precio")));
                pro.setCantidad(Integer.parseInt(rs.getString("cantidad")));
                return true;
            }
            return false;
        } catch (Exception e) {
            System.err.println(e);
            return false;
        } finally {
            try {
                con.close();
            } catch (SQLException e) {
                System.err.println(3);
            }
        }
    }
}
