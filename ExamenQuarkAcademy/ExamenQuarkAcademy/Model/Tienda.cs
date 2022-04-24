using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy
{
    public class Tienda{
        #region FIELDS
        private string nombre;
        private string direccion;
        private List<Prenda> prendas;
        private List<Vendedor> vendedores;
        #endregion

        #region PROPERTIES
        public string Nombre { get { return nombre; } }
        public string Direccion { get { return direccion; } }
        public List<Prenda> Prendas { get { return prendas; } }
        public List<Vendedor> Vendedores { get { return vendedores; } }
        #endregion

        public Tienda(string nombre, string direccion, List<Prenda> prendas, List<Vendedor> vendedores)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.prendas = prendas;
            this.vendedores = vendedores;
        }

        public void AgregarPrenda(Prenda prenda)
        {
            this.prendas.Add(prenda);
        }
        public void QuitarPrenda(Prenda prenda)
        {
            this.prendas.Remove(prenda);
        }
        public void AgregarVendedor(Vendedor vendedor)
        {
            this.vendedores.Add(vendedor);
        }
        public void QuitarVendedor(Vendedor vendedor)
        {
            this.vendedores.Remove(vendedor);
        }
    }
}
