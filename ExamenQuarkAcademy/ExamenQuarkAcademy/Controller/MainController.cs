using ExamenQuarkAcademy.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy.Controller
{
    public class MainController{

        #region FIELDS
        private I_Vista? vistaTienda;
        private Tienda? tienda;
        private event EventHandler OnModeloActualiza;
        #endregion

        #region PROPERTIES
        public I_Vista? VistaTienda { get { return vistaTienda; } }
        public Tienda? Tienda { get { return tienda; } }
        public EventHandler GetOnModeloActualiza { get { return OnModeloActualiza; } }
        #endregion


        #region Singleton
        private readonly static MainController mainController = new MainController();
        private MainController() {}
        public static MainController Instance{ get{ return mainController; } }
        #endregion


        public void RegisterVistaTienda(object sender, EventArgs e){
            if (sender is I_Vista) {
                try{
                    this.vistaTienda = sender as VistaTienda;
                    Console.WriteLine("VistaTienda registrada satisfactoriamente.");
                }
                catch (Exception){
                    throw;
                }  
            }
        }
        public void UnregisterVistaTienda(object sender, EventArgs e)
        {
            this.vistaTienda = null;
            Console.WriteLine("VistaTienda desregistrada satisfactoriamente.");
        }
        public void InicializarTienda(string nombre, string direccion, List<Prenda> prendas, List<Vendedor> vendedores){
            this.tienda = new Tienda(nombre, direccion, prendas, vendedores);
            Console.WriteLine("Tienda instanciada.");
        }

        public void ActualizarVistaTienda()
        {
            vistaTienda.ActualizarTienda(Tienda);
            Console.WriteLine("Actualizando vistaTienda...");
            
        }
    }
}
