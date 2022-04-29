using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace ExamenQuarkAcademy
{
    public class Tienda
    {
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

        public Tienda(string nombre, string direccion, List<Prenda> prendas, List<Vendedor> vendedores){
            this.nombre = nombre;
            this.direccion = direccion;
            this.prendas = prendas;
            this.vendedores = vendedores;
        }

        public void AgregarPrenda(Prenda prenda){
            this.prendas.Add(prenda);
        }
        public void QuitarPrenda(Prenda prenda){
            this.prendas.Remove(prenda);
        }
        public void AgregarVendedor(Vendedor vendedor){
            this.vendedores.Add(vendedor);
        }
        public void QuitarVendedor(Vendedor vendedor){
            this.vendedores.Remove(vendedor);
        }
        public Camisa BuscarCamisa(CuelloTipo cuelloTipo, CamisaTipo camisaTipo, Calidad calidad){
            try{
                foreach (Prenda prenda in prendas){
                    if (prenda.CuelloTipo == cuelloTipo && prenda.CamisaTipo == camisaTipo && prenda.Calidad == calidad){
                        return prenda as Camisa;
                    }
                }
                return null;
            }
            catch (Exception){
                throw;
            }
            
        }
        public Pantalon BuscarPantalon(PantalonTipo tipo, Calidad calidad){
            try{
                foreach (Prenda prenda in prendas){
                    if (prenda.PantalonTipo == tipo && prenda.Calidad == calidad){
                        return prenda as Pantalon;
                    }
                }
                Console.WriteLine("No se encontro nah");
                return null;
            }
            catch (Exception){
                throw;
            }
        }
        public Vendedor BuscarVendedorPorNombre(string nombre, string apellido){
            try{
                foreach ( Vendedor vendedor in vendedores){
                    if (vendedor.Nombre ==nombre && vendedor.Apellido==apellido){
                        return vendedor;
                    }
                }
                Console.WriteLine("No se encontro el vendedor con el nombre especificado");
                return null;
            }
            catch (Exception){
                throw;
            }
        }
        public Vendedor BuscarVendedorPorId(int id){
            try{
                foreach (Vendedor vendedor in vendedores){
                    if (vendedor.CodVendedor == id){
                        return vendedor;
                    }
                }
                Console.WriteLine("No se encontro el vendedor con el nombre especificado");
                return null;
            }
            catch (Exception){
                throw;
            }
        }
    }
}
