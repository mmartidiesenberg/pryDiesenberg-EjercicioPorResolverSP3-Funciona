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
    public struct Repuesto
    {
        public int Numero;           // número de repuesto (único)
        public string Descripcion;   // descripción
        public char Marca;           // 'P', 'F' o 'R'
        public string Origen;        // "Nacional" o "Importado"
        public double Precio;        // precio
    }
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
    }
}
