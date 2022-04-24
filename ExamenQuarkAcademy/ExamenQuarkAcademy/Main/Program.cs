using ExamenQuarkAcademy.Controller;

namespace ExamenQuarkAcademy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(){

            MainController.Instance.InicializarTienda("Tienda Quark", "Algun Lugar 1234", new List<Prenda>(), new List<Vendedor>());
            MainController.Instance.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaCorta, CuelloTipo.Mao,  1000f,  Calidad.Standard,  100));
            MainController.Instance.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaCorta, CuelloTipo.Mao, 1000f, Calidad.Premium, 100));
            MainController.Instance.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaCorta, CuelloTipo.Comun, 1000f, Calidad.Standard, 150));
            MainController.Instance.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaCorta, CuelloTipo.Comun, 1000f, Calidad.Premium, 150));
            MainController.Instance.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaLarga, CuelloTipo.Mao, 1000f, Calidad.Standard, 75));
            MainController.Instance.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaLarga, CuelloTipo.Mao, 1000f, Calidad.Premium, 75));
            MainController.Instance.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaLarga, CuelloTipo.Comun, 1000f, Calidad.Standard, 175));
            MainController.Instance.Tienda.AgregarPrenda(new Camisa(CamisaTipo.mangaLarga, CuelloTipo.Comun, 1000f, Calidad.Premium, 175));
            MainController.Instance.Tienda.AgregarPrenda(new Pantalon(PantalonTipo.Chupin, 1000f, Calidad.Standard, 750));
            MainController.Instance.Tienda.AgregarPrenda(new Pantalon(PantalonTipo.Chupin, 1000f, Calidad.Premium, 750));
            MainController.Instance.Tienda.AgregarPrenda(new Pantalon(PantalonTipo.Comun, 1000f, Calidad.Standard, 250));
            MainController.Instance.Tienda.AgregarPrenda(new Pantalon(PantalonTipo.Comun, 1000f, Calidad.Premium, 250));
            MainController.Instance.Tienda.AgregarVendedor(new Vendedor("Guillermo", "Marinero", 001));
            Console.WriteLine("Objetos de Tienda, Prendas, Vendedor hardcodeados.");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new VistaTienda());
        }
    }
}