using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOI_CL1_MaribelMaza
{
    public partial class frmPrestamo_Semestral : Form
    {
        
        public frmPrestamo_Semestral()
        {
            InitializeComponent();
        }

        private void frmPrestamo_Semestral_Load(object sender, EventArgs e)
        {
            cboLetras.Items.Add(3);
            cboLetras.Items.Add(6);
            cboLetras.Items.Add(9);
            cboLetras.Items.Add(12);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
           
            // 1. Instancia de la clase Prestamo_Semestral 
            Prestamo_Semestral objPS = new Prestamo_Semestral();

            // 2. Valores del Formulario
            objPS.nombreCliente = txtNomCliente.Text;
            objPS.numCuenta = txtNroCuenta.Text;
            objPS.montoPrestado = int.Parse(txtMontoPrestado.Text);

            if (!cboLetras.Text.Equals("")) { 
                objPS.letras = cboLetras.Text;
            }
            
           

            double montoMensual = objPS.calcularMontoMensual();
            double totalInteres = objPS.calcularTotalInteres();

            // 3.  Añadimos al ListviewItem para la impresión
            ListViewItem fila = new ListViewItem(objPS.nombreCliente);
            fila.SubItems.Add(objPS.numCuenta);
            fila.SubItems.Add(objPS.montoPrestado.ToString("0.00"));
            fila.SubItems.Add(objPS.letras);
            fila.SubItems.Add(montoMensual.ToString("0.00"));
            fila.SubItems.Add(totalInteres.ToString("0.00"));
            lvPrestamo.Items.Add(fila);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            txtNomCliente.Clear();
            txtNroCuenta.Clear();
            txtMontoPrestado.Clear();
            cboLetras.SelectedIndex = -1;
        }
    }
}
