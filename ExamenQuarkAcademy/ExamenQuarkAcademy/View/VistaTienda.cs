using ExamenQuarkAcademy.Controller;
using ExamenQuarkAcademy.Model;
using ExamenQuarkAcademy.View;
using System.Diagnostics;

namespace ExamenQuarkAcademy
{
    public partial class VistaTienda : Form, I_Vista{

        private Presenter presenter;
        public VistaTienda() {
            InitializeComponent();
            Standard_RadioButton.Checked = true;
            //Camisa_RadioButton.Checked = true;
            Console.WriteLine("\n VistaTienda INSTANCIADA.");
        }
        private void VistaTienda_Load(object sender, EventArgs e)
        {
            presenter = new Presenter(this);

            //DATOS HARDCODEADOS
            presenter.InicializarTienda("Tienda Quark", "Algun Lugar 1234", new List<Prenda>(), new List<Vendedor>());
            presenter.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaCorta, CuelloTipo.Mao, Calidad.Standard, 100));
            presenter.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaCorta, CuelloTipo.Mao, Calidad.Premium, 100));
            presenter.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaCorta, CuelloTipo.Comun, Calidad.Standard, 150));
            presenter.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaCorta, CuelloTipo.Comun, Calidad.Premium, 150));
            presenter.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaLarga, CuelloTipo.Mao, Calidad.Standard, 75));
            presenter.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaLarga, CuelloTipo.Mao, Calidad.Premium, 75));
            presenter.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaLarga, CuelloTipo.Comun, Calidad.Standard, 175));
            presenter.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaLarga, CuelloTipo.Comun, Calidad.Premium, 175));
            presenter.Tienda.AgregarPrenda(new Pantalon(PantalonTipo.Chupin, Calidad.Standard, 750));
            presenter.Tienda.AgregarPrenda(new Pantalon(PantalonTipo.Chupin, Calidad.Premium, 750));
            presenter.Tienda.AgregarPrenda(new Pantalon(PantalonTipo.Comun, Calidad.Standard, 250));
            presenter.Tienda.AgregarPrenda(new Pantalon(PantalonTipo.Comun, Calidad.Premium, 250));
            presenter.Tienda.AgregarVendedor(new Vendedor("Guillermo", "Marinero", 001));
            Console.WriteLine("\n Tienda, Prendas, Vendedor hardcodeados instanciados.");

            this.ActualizarVendedor(presenter.Tienda.Vendedores[0]);
            this.ActualizarTienda(presenter.Tienda);
        }



        public void ActualizarVendedor(Vendedor vendedor)
        {
            this.Nombre_Label.Text = vendedor.Nombre + " " + vendedor.Apellido;
            this.CodVendedor_Label.Text = vendedor.CodVendedor.ToString();
            Console.WriteLine("\n INFORMACION DE VENDEDOR ACTUALIZADA.");
        }

        public void ActualizarTienda(Tienda tienda)
        {
            this.Tienda_Label.Text = tienda.Nombre;
            this.Direccion_Label.Text = tienda.Direccion;
        }
        public Vendedor GetVendedorFromUI()
        {
            Console.WriteLine("\n BUSCANDO VENDEDOR SEGUR INFORMACION DE LA UI...");
            return presenter.Tienda.BuscarVendedorPorId(Int32.Parse(CodVendedor_Label.Text));
        }
        public Prenda GetPrendaFromUI(){
            Console.WriteLine("\n BUSCANDO PRENDA CON SEGUN INFORMACIO DE LA UI...");
            if (this.Camisa_RadioButton.Checked){
                if (this.MangaCorta_CheckBox.Checked){
                    if (this.Mao_CheckBox.Checked){
                        if (this.Standard_RadioButton.Checked){
                            Console.WriteLine(" -> manga corta y cuello mao STANDARD");
                            return presenter.Tienda.BuscarCamisa(CuelloTipo.Mao, CamisaTipo.mangaCorta, Calidad.Standard);
                        }
                        else if (this.Premium_RadioButton.Checked){
                            Console.WriteLine(" -> manga corta y cuello mao PREMIUM");
                            return presenter.Tienda.BuscarCamisa(CuelloTipo.Mao, CamisaTipo.mangaCorta, Calidad.Premium);
                        }
                    }
                    else{
                        if (this.Standard_RadioButton.Checked){
                            Console.WriteLine(" -> manga corta y cuello comun STANDARD");
                            return presenter.Tienda.BuscarCamisa(CuelloTipo.Comun, CamisaTipo.mangaCorta, Calidad.Standard);
                        }
                        else if (this.Premium_RadioButton.Checked){
                            Console.WriteLine(" -> manga corta y cuello comun PREMIUM");
                            return presenter.Tienda.BuscarCamisa(CuelloTipo.Comun, CamisaTipo.mangaCorta, Calidad.Premium);
                        }
                    }
                }
                else{
                    if (this.Mao_CheckBox.Checked){
                        if (this.Standard_RadioButton.Checked){
                            Console.WriteLine(" -> manga larga y cuello mao STANDARD");
                            return presenter.Tienda.BuscarCamisa(CuelloTipo.Mao, CamisaTipo.mangaLarga, Calidad.Standard);
                        }
                        else if (this.Premium_RadioButton.Checked){
                            Console.WriteLine(" -> manga larga y cuello mao PREMIUM");
                            return presenter.Tienda.BuscarCamisa(CuelloTipo.Mao, CamisaTipo.mangaLarga, Calidad.Premium);
                        }
                    }
                    else{
                        if (this.Standard_RadioButton.Checked){
                            Console.WriteLine(" -> manga larga y cuello comun STANDARD");
                            return presenter.Tienda.BuscarCamisa(CuelloTipo.Comun, CamisaTipo.mangaLarga, Calidad.Standard);
                        }
                        else if (this.Premium_RadioButton.Checked){
                            Console.WriteLine(" -> manga larga y cuello comun PREMIUM");
                            return presenter.Tienda.BuscarCamisa(CuelloTipo.Comun, CamisaTipo.mangaLarga, Calidad.Premium);
                        }
                    }
                }
            }
            else if (this.Pantalon_RadioButton.Checked){
                if (this.Chupin_CheckBox.Checked){
                    if (this.Standard_RadioButton.Checked){
                        Console.WriteLine(" -> pantalon chupin STANDARD");
                        return presenter.Tienda.BuscarPantalon(PantalonTipo.Chupin, Calidad.Standard);
                    }
                    else if (this.Premium_RadioButton.Checked){
                        Console.WriteLine(" -> pantalon chupin PREMIUM");
                        return presenter.Tienda.BuscarPantalon(PantalonTipo.Chupin, Calidad.Premium);

                    }
                }
                else{
                    if (this.Standard_RadioButton.Checked){
                        Console.WriteLine(" -> pantalon comun STANDARD");
                        return presenter.Tienda.BuscarPantalon(PantalonTipo.Comun, Calidad.Standard);
                    }
                    else if (this.Premium_RadioButton.Checked){
                        Console.WriteLine(" -> pantalon comun PREMIMUNM");
                        return presenter.Tienda.BuscarPantalon(PantalonTipo.Comun, Calidad.Premium);
                    }
                }
            }
            return null;
        }
        public void ActualizarPrenda(){
            Console.WriteLine("\n ACTUALIZANDO INFORMACION DE PRENDA EN UI...");
            if (this.Camisa_RadioButton.Checked){
                if (this.MangaCorta_CheckBox.Checked) {
                    if (this.Mao_CheckBox.Checked){
                        if (this.Standard_RadioButton.Checked){
                            Console.WriteLine(" -> stock manga corta y cuello mao STANDARD");
                            StockDisponible_Label.Text = presenter.Tienda.BuscarCamisa(CuelloTipo.Mao,CamisaTipo.mangaCorta,Calidad.Standard)?.Stock.ToString();
                        }
                        else if (this.Premium_RadioButton.Checked){
                            Console.WriteLine(" -> stock manga corta y cuello mao PREMIUM");
                            StockDisponible_Label.Text = presenter.Tienda.BuscarCamisa(CuelloTipo.Mao, CamisaTipo.mangaCorta, Calidad.Premium)?.Stock.ToString();
                        }
                    }
                    else{
                        if (this.Standard_RadioButton.Checked){
                            Console.WriteLine(" -> stock manga corta y cuello comun STANDARD");
                            StockDisponible_Label.Text = presenter.Tienda.BuscarCamisa(CuelloTipo.Comun, CamisaTipo.mangaCorta, Calidad.Standard)?.Stock.ToString();
                        }
                        else if (this.Premium_RadioButton.Checked){
                            Console.WriteLine(" -> stock manga corta y cuello comun PREMIUM");
                            StockDisponible_Label.Text = presenter.Tienda.BuscarCamisa(CuelloTipo.Comun, CamisaTipo.mangaCorta, Calidad.Premium)?.Stock.ToString();
                        }
                    }
                }
                else{
                    if (this.Mao_CheckBox.Checked){
                        if (this.Standard_RadioButton.Checked){
                            Console.WriteLine(" -> stock manga larga y cuello mao STANDARD");
                            StockDisponible_Label.Text = presenter.Tienda.BuscarCamisa(CuelloTipo.Mao, CamisaTipo.mangaLarga, Calidad.Standard)?.Stock.ToString();
                        }
                        else if (this.Premium_RadioButton.Checked){
                            Console.WriteLine(" -> stock manga larga y cuello mao PREMIUM");
                            StockDisponible_Label.Text = presenter.Tienda.BuscarCamisa(CuelloTipo.Mao, CamisaTipo.mangaLarga, Calidad.Premium)?.Stock.ToString();
                        }
                    }
                    else{
                        if (this.Standard_RadioButton.Checked){
                            Console.WriteLine(" -> stock manga larga y cuello comun STANDARD");
                            StockDisponible_Label.Text = presenter.Tienda.BuscarCamisa(CuelloTipo.Comun, CamisaTipo.mangaLarga, Calidad.Standard)?.Stock.ToString();
                        }
                        else if (this.Premium_RadioButton.Checked){
                            Console.WriteLine(" -> stock manga larga y cuello comun PREMIUM");
                            StockDisponible_Label.Text = presenter.Tienda.BuscarCamisa(CuelloTipo.Comun, CamisaTipo.mangaLarga, Calidad.Premium)?.Stock.ToString();
                        }
                    }
                }
            }else if (this.Pantalon_RadioButton.Checked){
                if (this.Chupin_CheckBox.Checked){
                    if (this.Standard_RadioButton.Checked){
                        Console.WriteLine(" -> stock pantalon chupin STANDARD");
                        StockDisponible_Label.Text = presenter.Tienda.BuscarPantalon(PantalonTipo.Chupin, Calidad.Standard).Stock.ToString();
                    }
                    else if (this.Premium_RadioButton.Checked){
                        Console.WriteLine(" -> stock pantalon chupin PREMIUM");
                        StockDisponible_Label.Text = presenter.Tienda.BuscarPantalon(PantalonTipo.Chupin, Calidad.Premium).Stock.ToString();
                    }
                }
                else{
                    if (this.Standard_RadioButton.Checked){
                        Console.WriteLine(" -> stock pantalon comun STANDARD");
                        StockDisponible_Label.Text = presenter.Tienda.BuscarPantalon(PantalonTipo.Comun, Calidad.Standard)?.Stock.ToString();
                    }
                    else if (this.Premium_RadioButton.Checked){
                        Console.WriteLine(" -> stock pantalon comun PREMIMUNM");
                        StockDisponible_Label.Text = presenter.Tienda.BuscarPantalon(PantalonTipo.Comun, Calidad.Premium)?.Stock.ToString();
                    }
                }
            }
            
        }

        private void Chupin_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.ActualizarPrenda();
        }

        private void MangaCorta_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.ActualizarPrenda();
        }
        private void CuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            this.ActualizarPrenda();
        }

        private void Camisa_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Chupin_CheckBox.Checked = false;
            this.Chupin_CheckBox.Enabled = false;
            this.MangaCorta_CheckBox.Enabled = true;
            this.Mao_CheckBox.Enabled = true;
            this.ActualizarPrenda();
        }

        private void Pantalon_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.MangaCorta_CheckBox.Checked = false;
            this.Mao_CheckBox.Checked = false;
            this.MangaCorta_CheckBox.Enabled = false;
            this.Mao_CheckBox.Enabled = false;
            this.Chupin_CheckBox.Enabled = true;
            this.ActualizarPrenda();
        }
        private void Standard_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Premium_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ActualizarPrenda();
        }

        private void Historial_Label_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n HISTORIAL...");
            Vendedor vendedor = GetVendedorFromUI();

            //MUESTRA EN CONSOLA EL HISTORIAL
            foreach (Cotizacion cot in vendedor.HistorialCotizaciones)
            {
                Console.WriteLine(" -> Id:" + cot.Id + " | Codigo Vendedor: " + cot.CodVendedor + " | Prenda: " + cot.Prenda + " | Cantidad: " + cot.Cantidad + " Total: | " + cot.Total);
            }
        }
        public void ActualizarTotal(float total)
        {
            Vendedor vendedor = presenter.Tienda.BuscarVendedorPorId(Int32.Parse(CodVendedor_Label.Text));
            this.Total_Label.Text = vendedor.HistorialCotizaciones.Last().Total.ToString();
        }




        private void StockDisponible_Label_Click(object sender, EventArgs e)
        {

        }
        private void Tienda_Label_Click(object sender, EventArgs e)
        {

        }
        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void Nombre_Label_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Total_Label.Text = "";
            Debug.WriteLine("\n COTIZANDO...");
            //buscar vendedor segun datos de UI
            Vendedor vendedor = presenter.Tienda.BuscarVendedorPorId(Int32.Parse(CodVendedor_Label.Text));
            Debug.WriteLine("Vendendor: " + vendedor.Nombre + " " + vendedor.Apellido + " | Codigo:" + vendedor.CodVendedor);

            //buscar prenda segun datos de UI
            Prenda prenda = GetPrendaFromUI();
            Debug.WriteLine("Prenda: " + prenda + " " + prenda.Calidad);

            
            try{
                //Cotizar
                int cant, precioUnit;
                Int32.TryParse(Cantidad_TextBox.Text, out cant);
                Int32.TryParse(PrecioUnit_TextBox.Text, out precioUnit);
                if (cant != 0 && cant <= prenda.Stock && precioUnit!=0){
                    Cotizacion cotizacion = new Cotizacion(0, DateTime.Now, vendedor.CodVendedor, prenda, cant);
                    cotizacion.Total = cotizacion.Cotizar(precioUnit);
                    this.Total_Label.Text = cotizacion.Total.ToString();
                    vendedor.HistorialCotizaciones.Add(cotizacion);
                    Debug.WriteLine("Cotizacion: " + cotizacion.Id + " | Cantidad:  " + cotizacion.Cantidad + " | Precio Unitario: " + cotizacion.PrecioUnit + " | Total: " + cotizacion.Total);

                    //Descontar del stock
                    prenda.DescontarStock(cotizacion.Cantidad);
                }
                else{
                    throw new Exception();
                }
            }
            catch (Exception){
                new Error();
                Console.WriteLine("\n SE INTRODUJO UN VALOR INCORRECTO DE CANTIDAD");
            }
            //Actualizar vista
            this.ActualizarPrenda();
        }

        private void PrecioUnit_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}