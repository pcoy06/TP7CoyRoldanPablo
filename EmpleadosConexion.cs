using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TP7CoyRoldanPablo
{
    class EmpleadosConexion // Conexion para mostrar en lista de empleados desde BD
    {
        public List<Empleados> ListarEmpleados()
        {
            List<Empleados> lista = new List<Empleados>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            conexion.ConnectionString = "data source=PABLO-PC; initial catalog=EMPLEADOS_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select Id, NombreCompleto, Dni, Edad, Casado, Salario from Empleados";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Empleados aux = new Empleados();
                aux.Id = lector.GetInt32(0);
                aux.Nombre = lector.GetString(1);
                aux.Dni = lector.GetString(2);
                aux.Edad = lector.GetInt32(3);
                aux.Casado = lector.GetBoolean(4);
                aux.Salario = lector.GetDecimal(5);

                lista.Add(aux);
            }
            conexion.Close();

            return lista;




        }
        // Conexion para agregar Empleados nuevos
        internal void agregar(Empleados nuevo)
        {
            
            
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

             conexion.ConnectionString = "data source = PABLO-PC; initial catalog = EMPLEADOS_DB; integrated security=sspi";
             comando.CommandType = System.Data.CommandType.Text;
             comando.CommandText = "insert into Empleados values (@nombre, @dni, @edad, @casado, @salario)";
             comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
             comando.Parameters.AddWithValue("@dni", nuevo.Dni);
             comando.Parameters.AddWithValue("@edad", nuevo.Edad);
             comando.Parameters.AddWithValue("@casado", nuevo.Casado);
             comando.Parameters.AddWithValue("@salario", nuevo.Salario); 
             comando.Connection = conexion;


             conexion.Open();
             comando.ExecuteNonQuery();

            




        }
    }
}
