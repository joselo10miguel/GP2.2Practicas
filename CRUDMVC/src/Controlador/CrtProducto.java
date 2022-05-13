/*
Dentro de este paquete por ejemplo se podría crear un controlador para cada una de las clases
*/
package Controlador;

import OperaBase.DATProducto;
import Modelo.Producto;
import Vista.frmProducto;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JOptionPane;

public class CrtProducto implements ActionListener{
    
    /*Sección Variables*/
    private Producto mod;
    private DATProducto modC;
    private frmProducto frm;
    
    /*Sección Constructor. hacer click en el + de la línea 24 para
    visualizar lo que se tiene en cada sección agrupada, así para los demás
    */
    // <editor-fold defaultstate="collapsed" desc="Constructor">
    /*Controlador contiene como parámetros
    Modelo - Clase Producto
    DATProducto - Acceso a las operaciones de la Base de datos
    frmProducto - Acceso a la UI al JFrame
    */
    public CrtProducto(Producto mod, DATProducto modC, frmProducto frm) {
        this.mod = mod;
        this.modC = modC;
        this.frm = frm;
        /*Se crean los eventos para los botones del JFrame
        los eventos están dados a través del addActionListener
        */
        this.frm.btnGuardar.addActionListener(this);
        this.frm.btnBuscar.addActionListener(this);
        this.frm.btnEliminar.addActionListener(this);
        this.frm.btnLimpiar.addActionListener(this);
        this.frm.btnModificar.addActionListener(this);
    }
    // </editor-fold> 

    // <editor-fold defaultstate="collapsed" desc="Métodos">
    //Método que debe existir para crear desplegar y visualizar la UI
        public void Iniciar() {
        frm.setTitle("Productos");
        frm.setLocationRelativeTo(null);
        frm.txtID.setVisible(false);
    }
    //Método que limpia los controles de la UI
    public void limpiar() {
        frm.txtID.setText(null);
        frm.txtCodigo.setText(null);
        frm.txtNombre.setText(null);
        frm.txtCantidad.setText(null);
        frm.txtPrecio.setText(null);
    }        
    // </editor-fold> 
    
    // <editor-fold defaultstate="collapsed" desc="Eventos">
    /*
    Evento de actionPermorfed que se ejecuta cuando acciona el click de un boton por ejemplo.
    El source es una propiedad para capturar el nombre asignado al control JButton, en esta caso
    el nombre es btnGuardar
    */
    
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == frm.btnGuardar) {

            //Forma 1 de crear un objeto de la clase Producto y enviar a la base
            mod = new Modelo.Producto(frm.txtCodigo.getText(), frm.txtNombre.getText(), 
                                        Double.parseDouble(frm.txtPrecio.getText()), 
                                        Integer.parseInt(frm.txtCantidad.getText()));
            //Forma 2 de setear los valores para crear un objeto de la Clase Producto y enviar a la base
            /*mod.setCodigo(frm.txtCodigo.getText());
            mod.setNombre(frm.txtNombre.getText());
            mod.setPrecio((Double.parseDouble(frm.txtPrecio.getText())));
            mod.setCantidad(Integer.parseInt(frm.txtCantidad.getText()));
            */
            
            if (modC.Registrar(mod))
                JOptionPane.showMessageDialog(null, "Registro guardado");             
            else 
                JOptionPane.showMessageDialog(null, "Error al guardar");
            limpiar();
        }
        /*En el caso de que se haga click en el boton Modificar*/
        if (e.getSource() == frm.btnModificar) {
            mod.setId(Integer.parseInt(frm.txtID.getText()));
            mod.setCodigo(frm.txtCodigo.getText());
            mod.setNombre(frm.txtNombre.getText());
            mod.setPrecio((Double.parseDouble(frm.txtPrecio.getText())));
            mod.setCantidad(Integer.parseInt(frm.txtCantidad.getText()));
            if (modC.Modificar(mod))
                JOptionPane.showMessageDialog(null, "Registro modificado");             
            else 
                JOptionPane.showMessageDialog(null, "Error al modificar");
            limpiar();
        }
        /*En el caso de que se haga click en el boton Eliminar*/
        if (e.getSource() == frm.btnEliminar) {
            mod.setId(Integer.parseInt(frm.txtID.getText()));
            if (modC.Eliminar(mod))
                JOptionPane.showMessageDialog(null, "Registro eliminado");             
            else 
            {
                JOptionPane.showMessageDialog(null, "Error al eliminar");
                limpiar();
            }
            limpiar();
        }
        /*En el caso de que se haga click en el boton Buscar*/
        if (e.getSource() == frm.btnBuscar) {
            mod.setCodigo(frm.txtCodigo.getText());
            if (modC.Buscar(mod)) {
                /*Se recupera los valores del objeto y se lo setea en las cajas de texto*/
                frm.txtID.setText(String.valueOf(mod.getId()));
                frm.txtCodigo.setText(String.valueOf(mod.getCodigo()));
                frm.txtNombre.setText(String.valueOf(mod.getNombre()));
                frm.txtCantidad.setText(String.valueOf(mod.getCantidad()));
                frm.txtPrecio.setText(String.valueOf(mod.getPrecio()));
                JOptionPane.showMessageDialog(null, "Registro encontrado");             
            } else 
            {
                JOptionPane.showMessageDialog(null, "Error al buscar");
                limpiar();
            }
        }
        
        if (e.getSource() == frm.btnLimpiar) {
            limpiar();
        }
    }    
    // </editor-fold> 
}
