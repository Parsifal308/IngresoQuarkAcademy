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
        public Pantalon(PantalonTipo pantalonTipo, Calidad calidad, int stock) : base(calidad, stock){
            this.pantalonTipo = pantalonTipo;
        }
    }

    public enum PantalonTipo{
        NULL,
        Comun,
        Chupin
    }
}
