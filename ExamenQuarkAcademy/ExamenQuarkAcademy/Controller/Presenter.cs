using ExamenQuarkAcademy.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy.Controller{
    public class Presenter{

        #region FIELDS
        private I_Vista vistaTienda;
        private Tienda tienda;
        #endregion

        #region PROPERTIES
        public I_Vista VistaTienda { get { return vistaTienda; } }
        public Tienda Tienda { get { return tienda; } }
        #endregion

        public Presenter(I_Vista vista) {
            this.vistaTienda = vista;
        }

        public void InicializarTienda(string nombre, string direccion, List<Prenda> prendas, List<Vendedor> vendedores){
            this.tienda = new Tienda(nombre, direccion, prendas, vendedores);
            Console.WriteLine("Tienda instanciada.");
        }

        public void ActualizarVistaTienda(){
            vistaTienda.ActualizarTienda(Tienda);
            Console.WriteLine("Actualizando vistaTienda...");
            
        }
    }
}
