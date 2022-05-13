/*
Paquete que se usa para realizar operaciones de éstablecimiento de conexión dependiendo 
del motor de base de datos que se requiera para trabajar.
*/
package OperaBase;
import com.mysql.jdbc.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.logging.Level;

    /*Clase que se usa para gestionar la conexion a la base, aqui debe ubicar lo que corresponda a su base de datos
    en el caso de que el usuario y clave sean las mismas o no la tenga debe modificar en esta sección.
    Como se usa MySQL este se levanta en el puerto 3306, por ello se lo ubica*/
    public class Conexion {
        private final String base = "DEMO";
        private final String usuario = "root";
        private final String clave = "root";
        private final String url = "jdbc:mysql://localhost:3306/" + base;
        private Connection con = null;

        public Connection getConexion() {
            try {
                //En el caso de que se use mysql como Driver debe cambiarlo en esta seccion si usa Oracle
                Class.forName("com.mysql.jdbc.Driver");
                con = (Connection) DriverManager.getConnection(this.url, this.usuario, this.clave);
            } catch (SQLException e) {
                System.err.println(e);
            } catch (ClassNotFoundException ex) {
                java.util.logging.Logger.getLogger(Conexion.class.getName()).log(Level.SEVERE, null, ex);
            } 
            return con;
        }
}
