using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class TiposForm : Form
    {
        public TiposForm()
        {
            InitializeComponent();
        }
        ProductoDatos proDatos = new ProductoDatos();
        Producto producto = new Producto();
        string tipoOperacion = string.Empty;

        private void TiposForm_Load(object sender, EventArgs e)
        {
             

        }
        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            DescripcionTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;
            ExistenciaTextBox.Enabled = true;
            FechaDateTimePicker.Enabled = true;
            
        }

        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            DescripcionTextBox.Clear();
            PrecioTextBox.Clear();
            ExistenciaTextBox.Clear();
            FechaDateTimePicker.Value = DateTime.Now;
            
        }

        private void DesabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            DescripcionTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            ExistenciaTextBox.Enabled = false;
            FechaDateTimePicker.Enabled = false;
            
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Nuevo";
            HabilitarControles();
        }
    }
}
