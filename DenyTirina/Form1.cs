using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocio;

namespace DenyTirina
{
    public partial class FrmCliente : Form
    {
        CN_Cliente oCliente = new CN_Cliente();
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarEntradas();
            txtCodigo.Enabled = false;
        }
        private void limpiarEntradas()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtNit.Clear();
            txtEmail.Clear();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            oCliente.NOMBRE = txtNombre.Text;
            oCliente.DIRECCION_CLIENTE = txtDireccion.Text;
            oCliente.TELEFONO = txtTelefono.Text;
            oCliente.NIT_CLIENTE = txtNit.Text;
            oCliente.EMAIL_CLIENTE = txtEmail.Text;
            if (oCliente.Guardar())
            {
                MessageBox.Show("Datos introducidos correctamente");
            }
            else
            {
                MessageBox.Show("Error verifique los datos");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            limpiarEntradas();
            txtCodigo.Enabled = true;
            txtCodigo.Focus();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataTable TablaCliente = new DataTable();

                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("Se abre una ventana de busqueda");
                }
                else
                {
                    if (oCliente.VerificarCliente(txtCodigo.Text, ref TablaCliente))
                    {
                        //MessageBox.Show(TablaCliente.Columns[0].ToString());
                        txtNombre.Text = TablaCliente.Rows[0][0].ToString();
                        txtDireccion.Text = TablaCliente.Rows[0][1].ToString();
                        txtTelefono.Text = TablaCliente.Rows[0][2].ToString();
                        txtNit.Text = TablaCliente.Rows[0][3].ToString();
                        txtEmail.Text = TablaCliente.Rows[0][4].ToString();
                    }
                    else
                    {
                        MessageBox.Show("error de dato");
                        txtCodigo.Clear();
                        txtCodigo.Focus();
                    }
                }
            }
        }
    }
}
