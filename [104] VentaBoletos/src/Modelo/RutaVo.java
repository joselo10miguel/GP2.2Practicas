
package Modelo;

public class RutaVo 
{
    private String idRuta;
    private String origen;
    private String destino;

    public RutaVo() {
    }
    
    public RutaVo(String origen, String destino, String idRuta) {
        this.origen = origen;
        this.destino = destino;
        this.idRuta = idRuta;
    }

    public String getOrigen() {
        return origen;
    }

    public void setOrigen(String origen) {
        this.origen = origen;
    }

    public String getDestino() {
        return destino;
    }

    public void setDestino(String destino) {
        this.destino = destino;
    }

    public String getIdRuta() {
        return idRuta;
    }

    public void setIdRuta(String idRuta) {
        this.idRuta = idRuta;
    }

    @Override
    public String toString() {
        return "RutaVo{" + "idRuta=" + idRuta + ", origen=" + origen + ", destino=" + destino + '}';
    }

    
    
    
    
}
