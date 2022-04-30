using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy{
    public abstract class Prenda {
        #region FIELDS
        private Calidad calidad;
        private int stock;
        #endregion

        #region PROPERTIES
        public int Stock { get { return stock; } }
        public Calidad Calidad { get { return calidad; } }

        public virtual CamisaTipo CamisaTipo { get; }
        public virtual CuelloTipo CuelloTipo { get; }
        public virtual PantalonTipo PantalonTipo { get; }
        #endregion

        public Prenda(Calidad calidad, int stock){
            this.calidad = calidad;
            this.stock = stock;
        }
        public void DescontarStock(int venta){
            this.stock -= venta;
            }


    }
    public enum Calidad{
        Standard,
        Premium
    }
}
