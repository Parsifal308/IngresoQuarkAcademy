using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy.View{
    public interface I_Vista{

        public void ActualizarVendedor(Vendedor vendedor);
        public void ActualizarTienda(Tienda tienda);
        public void ActualizarPrenda();
        public void ActualizarTotal(float total);
    }
}
