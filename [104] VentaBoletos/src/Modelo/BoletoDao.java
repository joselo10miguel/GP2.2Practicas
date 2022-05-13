/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.JOptionPane;

public class BoletoDao {
    
    public void venderBoleto( BoletoVo miBoleto)
    {
        
        Conexion conex=new Conexion();
        try
        {
            Statement orden= conex.getConexion().createStatement();
            orden.executeUpdate("INSERT INTO boleto VALUES("+miBoleto.getIdboleto()+",'"+miBoleto.getNombre()+"','"+miBoleto.getApellido()
                    +"','"+miBoleto.getCedula()+"','"+miBoleto.getEdad()+"','"+miBoleto.getTipoCliente()+"','"+miBoleto.getFecha()
                    +"','"+miBoleto.getDestino()+"','"+miBoleto.getOrigen()+"','"+miBoleto.getNumBoletos()
                    +"','"+miBoleto.getDescuento()+"','"+miBoleto.getTotal()+"');");
            JOptionPane.showMessageDialog(null,"se ha registrado la venta");
            orden.close();
            conex.desconectar();
        }catch(SQLException e)
        {
            System.out.println(e.getMessage());
            JOptionPane.showMessageDialog(null,"No se registro la venta");

        }
    }
}
