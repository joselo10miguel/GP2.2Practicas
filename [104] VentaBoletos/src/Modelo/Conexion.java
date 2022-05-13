package Modelo;

import java.sql.Connection;
import java.sql.DriverManager;


public class Conexion 
{
    static String bd="coperativa";
    static String login="root";
    static String password="";
    static String url="jdbc:mysql://localhost/"+bd;
    
    ClienteVo cliente;
    RutaVo ruta;
    UsuarioVo usuario;
    Connection connec=null;
    
    public Conexion()
    {
        cliente =new ClienteVo();
        ruta =new RutaVo();
        usuario =new UsuarioVo();
        try
        {
            Class.forName("com.mysql.jdbc.Driver");
            connec=DriverManager.getConnection(url, login, password);
            if(connec != null)
            {
                System.out.println("CONEXION A LA BASE DE DATOS CORRECTO");
            }
        }catch(Exception e)
        {
            System.out.println(e.getMessage());
            System.out.println(e.toString());
            System.out.println("Conexion a la base "+bd+" incorrecto");
        }
    }
    
    public Connection getConexion(){
        return connec;
    }
    
    public void desconectar(){
        connec=null;
    }
}
