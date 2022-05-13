/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;

import Modelo.*;
import Vista.*;

public class CoordinadorBoleto {
    
    //private VentanaInicial ventanaInicial;
    private VentaBoletos ventanaVenta;
    private BoletoDao miBoleto = new  BoletoDao();

    public VentaBoletos getVentanaVenta() {
        return ventanaVenta;
    }

    public void setVentanaVenta(VentaBoletos ventanaVenta) {
        this.ventanaVenta = ventanaVenta;
    }

    public BoletoDao getMiBoleto() {
        return miBoleto;
    }

    public void setMiBoleto(BoletoDao miBoleto) {
        this.miBoleto = miBoleto;
    }
    
     public void venderBoleto(BoletoVo objBoleto){
        miBoleto.venderBoleto(objBoleto);
    }
}
