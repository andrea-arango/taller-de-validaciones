using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones.Elementos;

namespace Validaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // crear los tipos de documentos
            System.Collections.Generic.List<TipoDocumento>
                TiposDocumentos = new List<TipoDocumento> ();

              TiposDocumentos.Add(new TipoDocumento() { IdPaciente = 1, Nombre = "Tarjeta de Identidad"});
                TiposDocumentos.Add(new TipoDocumento() { IdPaciente = 2, Nombre = "Registro civil"}); 
               TiposDocumentos.Add(new TipoDocumento() { IdPaciente = 3, Nombre = "Cedula Ciudadania"}); 
             TiposDocumentos.Add(new TipoDocumento() { IdPaciente = 4, Nombre = "pasaporte"});
           
            CboTipoDocumento.DataSource = TiposDocumentos;
            CboTipoDocumento.DisplayMember = "Nombre";


            // crear los rangos
            System.Collections.Generic.List<Elementos.Rango>
           rangos = new List<Elementos.Rango>();

            rangos.Add(new Elementos.Rango() { IdPaciente = 1, Nombre = "Rango A" });
            rangos.Add(new Elementos.Rango() { IdPaciente = 2, Nombre = "Rango N" });
            rangos.Add(new Elementos.Rango() { IdPaciente = 3, Nombre = "Rango D" });

            CboRango.DataSource = rangos;
            CboRango.DisplayMember = "Nombre";


        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            // la casilla nombre se debe llenar
            if( string.IsNullOrEmpty(textNombre.Text))
            {
                erpMensaje.SetError(textNombre, "El nombre se debe llenar");
            }

            // el tipo de documento se debe llenar

            if (string.IsNullOrEmpty(CboTipoDocumento.Text))
            {
                erpMensaje.SetError(CboTipoDocumento, "debe seleccionar un tipo de documento");
                return;
            }

            // el sexo se debe llenar
            if (string.IsNullOrEmpty(rbMujer.Text))
            {
                erpMensaje.SetError(rbMujer, "debe seleccionar un tipo de sexo");
                return;
            }

            else
            {
                erpMensaje.SetError(rbHombre, "por  si no es mujer ");
                return;
            }

            // el numero de docuemnto se debe llenar
                if ( string.IsNullOrEmpty(textNumeroDocumento.Text))
            {
                erpMensaje.SetError(textNumeroDocumento, " se debe ingresar los numeros de documentos");
                return;
            }

            // el nuemero de documento debe ser mayor a 0
            if (Convert.ToInt64(textNumeroDocumento.Text) <=0)
            {
                erpMensaje.SetError(textNumeroDocumento, "el numero que se ingrese debe ser mayor a 0");
                return;
            }


            // el costo se servicio no puede ir vacio
            if( string.IsNullOrEmpty(textCosto.Text))
            {
                erpMensaje.SetError(textCosto, " se debe ingresar un costo de servicio");
                return;
            }

            // el costo no  puede dar 0
            if(Convert.ToInt64(textCosto.Text)<=0)
            {
                erpMensaje.SetError(textCosto, " el numero que se ingrese debe ser mayor a 0");
                return;
            }

            // mensaje del registro de paciente se ingreso bien 
            Paciente registro = new Paciente();
            registro.NombrePaciente = textNumeroDocumento.Text;
            registro.NumeroDocumento = Convert.ToInt64(textNumeroDocumento.Text);
            registro.Costos = Convert.ToInt64(textCosto.Text);

            MessageBox.Show(" el paciente se ingreso exitosamente");


        }

        private void btnMontoPagar_Click(object sender, EventArgs e)
        {
            double MontoPagar = 0;

            // monto a pagar del rango A

            if (((Rango)CboRango.SelectedItem).IdPaciente ==1)
            {
                MontoPagar = (Convert.ToInt64( textCosto.Text)-((Convert.ToInt64(textCosto.Text) *20)));
            }

            // monto a pagar del rango N

            if (((Rango)CboRango.SelectedItem).IdPaciente == 2)
            {
                MontoPagar = (Convert.ToInt64(textCosto.Text) - ((Convert.ToInt64(textCosto.Text) * 15)));
            }


            // monto a pagar del rango D

            if (((Rango)CboRango.SelectedItem).IdPaciente == 3)
            {
                MontoPagar = (Convert.ToInt64(textCosto.Text) - ((Convert.ToInt64(textCosto.Text) * 10)));
            }

            MessageBox.Show("debe pagar:" + MontoPagar);




        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
