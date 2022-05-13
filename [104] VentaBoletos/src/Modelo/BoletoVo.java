/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;


public class BoletoVo 
{
    private String idboleto;
    private String nombre;
    private String apellido;
    private String cedula;
    private String edad;
    private String tipoCliente;
    private String fecha;
    private String destino;
    private String origen;
    private int numBoletos;
    private double descuento;
    private double total;
    

    public BoletoVo() {
    }

    public BoletoVo(String idboleto, String nombre, String apellido, String cedula, String edad, String tipoCliente, String fecha, String destino, String origen, int numBoletos, double descuento, double total) {
        this.idboleto = idboleto;
        this.nombre = nombre;
        this.apellido = apellido;
        this.cedula = cedula;
        this.edad = edad;
        this.tipoCliente = tipoCliente;
        this.fecha = fecha;
        this.destino = destino;
        this.origen = origen;
        this.numBoletos = numBoletos;
        this.descuento = descuento;
        this.total = total;
    }

    public String getIdboleto() {
        return idboleto;
    }

    public void setIdboleto(String idboleto) {
        this.idboleto = idboleto;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public String getCedula() {
        return cedula;
    }

    public void setCedula(String cedula) {
        this.cedula = cedula;
    }

    public String getEdad() {
        return edad;
    }

    public void setEdad(String edad) {
        this.edad = edad;
    }

    public String getTipoCliente() {
        return tipoCliente;
    }

    public void setTipoCliente(String tipoCliente) {
        this.tipoCliente = tipoCliente;
    }

    public String getFecha() {
        return fecha;
    }

    public void setFecha(String fecha) {
        this.fecha = fecha;
    }

    public String getDestino() {
        return destino;
    }

    public void setDestino(String destino) {
        this.destino = destino;
    }

    public String getOrigen() {
        return origen;
    }

    public void setOrigen(String origen) {
        this.origen = origen;
    }

    public int getNumBoletos() {
        return numBoletos;
    }

    public void setNumBoletos(int numBoletos) {
        this.numBoletos = numBoletos;
    }

    public double getDescuento() {
        return descuento;
    }

    public void setDescuento(double descuento) {
        this.descuento = descuento;
    }

    public double getTotal() {
        return total;
    }

    public void setTotal(double total) {
        this.total = total;
    }

    @Override
    public String toString() {
        return "BoletoVo{" + "idboleto=" + idboleto + ", nombre=" + nombre + ", apellido=" + apellido + ", cedula=" + cedula + ", edad=" + edad + ", tipoCliente=" + tipoCliente + ", fecha=" + fecha + ", destino=" + destino + ", origen=" + origen + ", numBoletos=" + numBoletos + ", descuento=" + descuento + ", total=" + total + '}';
    }

   
    
    
    
    
}
