


package Controlador;

    import Modelo.*;
    import Vista.*;

public class CoordinadorUsuario 
{
    //private VentanaInicial ventanaInicial;
    private RegistrarUsuario ventanaUsuario;
    private UsuarioDao miUsuario = new  UsuarioDao();

    public RegistrarUsuario getVentanaUsuario() {
        return ventanaUsuario;
    }

    public void setVentanaUsuario(RegistrarUsuario ventanaUsuario) {
        this.ventanaUsuario = ventanaUsuario;
    }

    public UsuarioDao getMiUsuario() {
        return miUsuario;
    }

    public void setMiUsuario(UsuarioDao miUsuario) {
        this.miUsuario = miUsuario;
    }
    
    public void mostrarVentanaUsuario()
    {
        ventanaUsuario.setVisible(true);
    }
    
    public void registrarUsuario(UsuarioVo objUsuario){
        miUsuario.registrarUsuario(objUsuario);
    }
    
    public void modificarUsuario(UsuarioVo objUsuario){
        miUsuario.modificarUsuario(objUsuario);
    }
    
    public void eliminarUsuario(String codigo){
        miUsuario.eliminarUsuario(codigo);
    }
    
}
