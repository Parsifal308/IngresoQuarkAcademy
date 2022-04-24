using ExamenQuarkAcademy.Controller;
using ExamenQuarkAcademy.View;
using System.Diagnostics;

namespace ExamenQuarkAcademy
{
    public partial class VistaTienda : Form, I_Vista{
        private event EventHandler? OnVistaCreada, OnVistaCerrada;
        public VistaTienda()
        {
            OnVistaCreada += MainController.Instance.RegisterVistaTienda;
            InitializeComponent();
            Console.WriteLine("VistaTienda instanciada.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.Chupin_CheckBox.Checked = false;
        }

        private void Cotizar_Click(object sender, EventArgs e)
        {
            //BOTON COTIZAR
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void VistaTienda_Load(object sender, EventArgs e)
        {
            OnVistaCreada?.Invoke(this, EventArgs.Empty);
            ActualizarTienda(MainController.Instance.Tienda);


            ActualizarVendedor(MainController.Instance.Tienda.Vendedores[0]); //VENDEDOR HARCODEADO

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

        public void ActualizarVendedor(Vendedor vendedor)
        {
            this.Nombre_Label.Text = vendedor.Nombre + " " + vendedor.Apellido;
            this.CodVendedor_Label.Text = vendedor.CodVendedor.ToString();
            Console.WriteLine("...vendedor actualizado.");
        }

        public void ActualizarTienda(Tienda tienda)
        {
            this.Tienda_Label.Text = tienda.Nombre;
            this.Direccion_Label.Text = tienda.Direccion;
        }

        public void ActualizarPrenda(){
            Console.WriteLine("Actualizando informacion de prenda");
            if (this.Camisa_RadioButton.Checked){
                if (this.MangaCorta_CheckBox.Checked) {
                    if (this.Mao_CheckBox.Checked){
                        if (this.Standard_RadioButton.Checked){
                            //stock manga corta y cuello mao STANDARD
                        }
                        else if (this.Premium_RadioButton.Checked){
                            //stock manga corta y cuello mao PREMIUM
                        }
                    }
                    else{
                        if (this.Standard_RadioButton.Checked){
                            //stock manga corta y cuello comun STANDARD
                        }
                        else if (this.Premium_RadioButton.Checked){
                            //stock manga corta y cuello comun PREMIUM
                        }
                    }
                }
                else{
                    if (this.Mao_CheckBox.Checked){
                        if (this.Standard_RadioButton.Checked){
                            //stock manga larga y cuello mao STANDARD
                        }
                        else if (this.Premium_RadioButton.Checked){
                            //stock manga larga y cuello mao PREMIum
                        }
                    }
                    else{
                        if (this.Standard_RadioButton.Checked){
                            //stock manga larga y cuello comun STANDARD
                        }
                        else if (this.Premium_RadioButton.Checked){
                            //stock manga larga y cuello comun PREMIUM
                        }
                    }
                }
            }else if (this.Pantalon_RadioButton.Checked){
                if (this.Chupin_CheckBox.Checked){
                    if (this.Standard_RadioButton.Checked){
                        //stock pantalon chupin STANDARD
                    }
                    else if (this.Premium_RadioButton.Checked){
                        //stock pantalon chupin PREMIUM
                    }
                }
                else{
                    if (this.Standard_RadioButton.Checked){
                        //stock pantalon comun STANDARD
                    }
                    else if (this.Premium_RadioButton.Checked){
                        //stock pantalon comun PREMIMUNM
                    }
                }
            }
            
        }

        private void Chupin_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.MangaCorta_CheckBox.Checked = false;
            this.Mao_CheckBox.Checked = false;
        }

        private void MangaCorta_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.Chupin_CheckBox.Checked = false;
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

        private void Historial_Label_Click(object sender, EventArgs e)
        {
            Console.WriteLine("MOSTRAR HISTORIAL");
        }

        private void StockDisponible_Label_Click(object sender, EventArgs e)
        {

        }

        private void Standard_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ActualizarPrenda();
        }

        private void Premium_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ActualizarPrenda();
        }

        public void ActualizarTotal(float total)
        {
            throw new NotImplementedException();
        }
    }
}