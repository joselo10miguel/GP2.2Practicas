package crudmvc;

import Controlador.CrtProducto;
import OperaBase.DATProducto;
import Modelo.Producto;
import Vista.frmProducto;

public class CRUDMVC {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        /*Se inicializan las variables que se usarán desde el controlador*/
        Producto mod = new Producto(null, null, 0, 0);
        DATProducto modC = new DATProducto();
        frmProducto frm = new frmProducto();
        
        //Se envia al controlador las variables inicializadas para operar
        CrtProducto ctrl = new CrtProducto(mod, modC, frm);
        //Se llama al método Iniciar que está dentro del Controlador
        ctrl.Iniciar();
        //Se hace visible al UI el JFrame
        frm.setVisible(true);
    }
    
}
