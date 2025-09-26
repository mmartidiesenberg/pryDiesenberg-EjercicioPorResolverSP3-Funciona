using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenberg_EjercicioPorResolverSP3_Funciona
{
    
    public partial class frmVentaRepuestos : Form
    {
        

        public frmVentaRepuestos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVentaRepuestos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(cmbMarca.Text) ||
                !btnImportado.Checked && !btnNacional.Checked ||
                !int.TryParse(mskNumero.Text, out int numero) || numero == 0 ||
                string.IsNullOrWhiteSpace(mskPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcionRep.Text)
)
            {
                MessageBox.Show("Los Datos están incompletos, por favor complete todos los campos");
            }
            else
            {
                MessageBox.Show("Datos enviados correctamente");
            }
        }
    }
}
