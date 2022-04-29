using ExamenQuarkAcademy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy
{
    public class Vendedor{
        #region FIELDS
        private string nombre;
        private string apellido;
        private int codVendedor;
        private List<Cotizacion> historialCotizaciones;
        #endregion

        #region PROPERTIES
        public String Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        public int CodVendedor { get { return codVendedor; } }
        public List<Cotizacion> HistorialCotizaciones { get { return historialCotizaciones; } }
        #endregion

        public Vendedor(string nombre, string apellido, int codVendedor){
            this.nombre = nombre;
            this.apellido = apellido;
            this.codVendedor = codVendedor;
            historialCotizaciones = new List<Cotizacion>();
        }

        public void GuardarCotizacion(Cotizacion cotizacion){
            this.historialCotizaciones.Add(cotizacion);
        }
    }
}
