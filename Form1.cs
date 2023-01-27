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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar(); // actualizamos la lista
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEmpleado ventanaEmpleado = new frmEmpleado();
            ventanaEmpleado.ShowDialog();
            cargar(); // actualizamos nuevamente la lista

        }
        private void cargar()
        {
            EmpleadosConexion conexion = new EmpleadosConexion();
            dgvEmpleados.DataSource = conexion.ListarEmpleados();
        }
    }
}
