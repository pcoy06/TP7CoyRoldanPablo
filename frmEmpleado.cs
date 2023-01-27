using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP7CoyRoldanPablo
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            Empleados nuevo = new Empleados();
            EmpleadosConexion conexion = new EmpleadosConexion();

            // Para agregar a DataGridview y BD lo que se escriba dentro de los Texbox
            nuevo.Nombre = textNombre.Text;
            nuevo.Dni = textDni.Text;
            nuevo.Edad = int.Parse(textEdad.Text);
            nuevo.Casado = Convert.ToBoolean(cmbEstadoCivil.SelectedValue); 
            nuevo.Salario = decimal.Parse(textSalario.Text);

            conexion.agregar(nuevo);
            // Mensaje para el usuario de que se agregó correctamente el nuevo empleado
            MessageBox.Show("Se agregó Correctamente.");
            Close();


        }

        // Método de boton Cancelar para cerrar la ventana
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
