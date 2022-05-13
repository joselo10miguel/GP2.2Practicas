
package Modelo;


public class UsuarioVo 
{
    private String nombre1;
    private String nombre2;
    private String apellido1;
    private String apellido2;
    private String cedula;
    private String username;
    private String password;

    public UsuarioVo(String nombre1, String nombre2, String apellido1, String apellido2, String cedula,  String username, String password) {
        this.nombre1 = nombre1;
        this.nombre2 = nombre2;
        this.apellido1 = apellido1;
        this.apellido2 = apellido2;
        this.cedula = cedula;
        
        this.username = username;
        this.password = password;
    }

    public UsuarioVo() {
    }

  

    public String getNombre1() {
        return nombre1;
    }

    public void setNombre1(String nombre1) {
        this.nombre1 = nombre1;
    }

    public String getNombre2() {
        return nombre2;
    }

    public void setNombre2(String nombre2) {
        this.nombre2 = nombre2;
    }

    public String getApellido1() {
        return apellido1;
    }

    public void setApellido1(String apellido1) {
        this.apellido1 = apellido1;
    }

    public String getApellido2() {
        return apellido2;
    }

    public void setApellido2(String apellido2) {
        this.apellido2 = apellido2;
    }

    public String getCedula() {
        return cedula;
    }

    public void setCedula(String cedula) {
        this.cedula = cedula;
    }

 

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    @Override
    public String toString() {
        return "Usuario: " +nombre1 + ", " + nombre2 + ", " + apellido1 + ", " + apellido2 + ", " + cedula ;
    }


    
    
}
