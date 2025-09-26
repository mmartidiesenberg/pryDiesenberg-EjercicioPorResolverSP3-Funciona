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
        struct Repuesto
        {
            public string marca; //P , R, F
            public char origen;// I, N
            public int numeroRepuesto;
            public float precio;
            public string descripcion;

        }
        public frmVentaRepuestos()
        {
            InitializeComponent();
        }
        
        Repuesto[] vecRepuestos = new Repuesto[100];
        string Descripcion;
        float Precio;

        int Indice = 0;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVentaRepuestos_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Indice <= vecRepuestos.Length)
            {
                //vecRepuestos[Indice] = Convert.ToInt32(mskNumero.Text) + txtDescripcionRep.Text + mskNumero.Text;

                
                vecRepuestos[Indice].marca = cmbMarca.Text;

                if (optNacional.Checked == true)
                {
                    vecRepuestos[Indice].origen = 'N';
                }

                if (optImportado.Checked == true)
                {
                    vecRepuestos[Indice].origen = 'I';
                }

                vecRepuestos[Indice].precio = int.Parse(mskPrecio.Text);
                vecRepuestos[Indice].numeroRepuesto = int.Parse(mskNumero.Text);

                Indice++;

                string texto = "Marca: " + vecRepuestos[Indice - 1].marca +
                      " | Origen: " + vecRepuestos[Indice - 1].origen +
                      " | N°: " + vecRepuestos[Indice - 1].numeroRepuesto +
                      " | Precio: $" + vecRepuestos[Indice - 1].precio.ToString("F2");

                lstDatos.Items.Add(texto);
            }
             }
                
        }
    }
