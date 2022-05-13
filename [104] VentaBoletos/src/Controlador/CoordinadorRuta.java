
package Controlador;

import Modelo.*;
import Vista.*;
public class CoordinadorRuta
{
    //private VentanaInicial ventanaInicial;
    private RegistrarRuta ventanaRuta;
    private RutaDao miRuta = new  RutaDao();

    public RegistrarRuta getVentanaRuta() {
        return ventanaRuta;
    }

    public void setVentanaRuta(RegistrarRuta ventanaRuta) {
        this.ventanaRuta = ventanaRuta;
    }

    public RutaDao getMiRuta() {
        return miRuta;
    }

    public void setMiRuta(RutaDao miRuta) {
        this.miRuta = miRuta;
    }
    
    public void registrarRuta(RutaVo objRuta){
        miRuta.registrarRuta(objRuta);
    }
    
    public void modificarRuta(RutaVo objRuta){
        miRuta.modificarRuta(objRuta);
    }
    
    public void eliminarRuta(String codigo){
        miRuta.eliminarRuta(codigo);
    }
}
