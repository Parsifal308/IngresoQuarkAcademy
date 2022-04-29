using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy{
    public class Pantalon : Prenda{
        #region FIELDS
        private PantalonTipo pantalonTipo;
        #endregion

        #region PROPERTIES
        public override PantalonTipo PantalonTipo { get { return pantalonTipo; } }
        #endregion
        public Pantalon(PantalonTipo pantalonTipo, float precioUnit, Calidad calidad, int stock) : base(precioUnit, calidad, stock){
            this.pantalonTipo = pantalonTipo;
        }
    }

    public enum PantalonTipo{
        NULL,
        Comun,
        Chupin
    }
}
