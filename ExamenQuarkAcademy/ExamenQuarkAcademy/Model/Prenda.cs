using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy
{
    public abstract class Prenda {
        #region FIELDS
        private float precioUnit;
        private Calidad calidad;
        private int stock;
        #endregion

        #region PROPERTIES
        public float PrecioUnit { get { return precioUnit; } }
        public int Stock { get { return stock; } }
        public Calidad Calidad { get { return calidad; } }

        public virtual CamisaTipo CamisaTipo { get; }
        public virtual CuelloTipo CuelloTipo { get; }
        public virtual PantalonTipo PantalonTipo { get; }
        #endregion

        public Prenda(float precioUnit, Calidad calidad, int stock)
        {
            this.precioUnit = precioUnit;
            this.calidad = calidad;
            this.stock = stock;
        }


    }
    public enum Calidad{
        Standard,
        Premium
    }
}
