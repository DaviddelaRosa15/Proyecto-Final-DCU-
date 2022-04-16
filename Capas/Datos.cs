using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas
{
    internal class Datos
    {
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-7EL68FS;DataBase=ProyectoFinalDCU;Integrated Security=true");
        private SqlDataReader leer;
        private DataTable tabla = new DataTable();
        private SqlCommand comando = new SqlCommand();
        public SqlConnection abrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection cerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

        public bool logins(string userName, string password)
        {
            bool login = false;
            try
            {

                abrirConexion();
                SqlCommand cmdEstudiante = new SqlCommand("SELECT * FROM Estudiantes WHERE Usuario ='" + userName + "' AND Contraseña ='" + password + "'", abrirConexion());
                SqlDataReader drEstudiante = cmdEstudiante.ExecuteReader();               
                if (drEstudiante.HasRows)
                {
                    if (drEstudiante.Read())
                    {
                        UserCache.id = drEstudiante.GetInt32(0);
                        UserCache.nombre = drEstudiante.GetString(1);
                        UserCache.apellido = drEstudiante.GetString(2);
                        UserCache.edad = Convert.ToString(drEstudiante.GetInt32(3));
                        UserCache.matricula = drEstudiante.GetString(4);
                        UserCache.telefono = drEstudiante.GetString(5);
                        UserCache.direccion = drEstudiante.GetString(6);
                        UserCache.email = drEstudiante.GetString(7);
                        UserCache.usuario = drEstudiante.GetString(8);
                        UserCache.contraseña = drEstudiante.GetString(9);
                        UserCache.tipo = "Estudiante";
                    }
                    login = true;
                }
                drEstudiante.Close();

                SqlCommand cmdMaestro = new SqlCommand("SELECT * FROM Maestros WHERE Usuario ='" + userName + "' AND Contraseña ='" + password + "'", abrirConexion());
                SqlDataReader drMaestro = cmdMaestro.ExecuteReader();
                if (drMaestro.HasRows)
                {
                    if (drMaestro.Read())
                    {
                        UserCache.id = drMaestro.GetInt32(0);
                        UserCache.nombre = drMaestro.GetString(1);
                        UserCache.apellido = drMaestro.GetString(2);
                        UserCache.edad = Convert.ToString(drMaestro.GetInt32(3));
                        UserCache.telefono = drMaestro.GetString(4);
                        UserCache.direccion = drMaestro.GetString(5);
                        UserCache.email = drMaestro.GetString(6);
                        UserCache.usuario = drMaestro.GetString(7);
                        UserCache.contraseña = drMaestro.GetString(8);
                        UserCache.tipo = "Maestro";
                    }
                    login = true;
                }
                drMaestro.Close();

                SqlCommand cmdDirector = new SqlCommand("SELECT * FROM Directores WHERE Usuario ='" + userName + "' AND Contraseña ='" + password + "'", abrirConexion());
                SqlDataReader drDirector = cmdDirector.ExecuteReader();
                if (drDirector.HasRows)
                {
                    if (drDirector.Read())
                    {
                        UserCache.id = drDirector.GetInt32(0);
                        UserCache.nombre = drDirector.GetString(1);
                        UserCache.apellido = drDirector.GetString(2);
                        UserCache.edad = Convert.ToString(drDirector.GetInt32(3));
                        UserCache.telefono = drDirector.GetString(4);
                        UserCache.direccion = drDirector.GetString(5);
                        UserCache.email = drDirector.GetString(6);
                        UserCache.usuario = drDirector.GetString(7);
                        UserCache.contraseña = drDirector.GetString(8);
                        UserCache.tipo = "Director";
                    }
                    login = true;
                }
                drDirector.Close();
                cerrarConexion();
            }
            catch (Exception ex)
            {

            }

            return login;
        }

        public bool validarExistenEntidades()
        {
            bool validacion = false;
            try
            {
                abrirConexion();
                SqlCommand cmdEstudiante = new SqlCommand("SELECT * FROM Estudiantes", abrirConexion());
                SqlDataReader drEstudiante = cmdEstudiante.ExecuteReader();
                if (drEstudiante.HasRows)
                {
                    validacion = true;                    
                }
                drEstudiante.Close();
                SqlCommand cmdMaestro = new SqlCommand("SELECT * FROM Maestros", abrirConexion());
                SqlDataReader drMaestro = cmdMaestro.ExecuteReader();
                if (drMaestro.HasRows)
                {
                    validacion = true;
                }
                drMaestro.Close();
                SqlCommand cmdDirector = new SqlCommand("SELECT * FROM Directores", abrirConexion());
                SqlDataReader drDirector = cmdDirector.ExecuteReader();
                if (drDirector.HasRows)
                {
                    validacion = true;
                }
                cerrarConexion();
            }
            catch (Exception ex)
            {

            }

            return validacion;
        }

        //Form director
        // Tabla Estudiantes
        public DataTable listarEstudiantes()
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "SpEstudiantesListar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            cerrarConexion();
            return tabla;

        }

        public void insertarEstudiantes(string nombre, string apellido, int edad, string matricula,
            string telefono, string direccion, string email, string usuario, string contraseña, int idCurso)
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "SpEstudiantesInsertar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@Edad", edad);
            comando.Parameters.AddWithValue("@Matricula", matricula);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Contraseña", contraseña);
            comando.Parameters.AddWithValue("@Curso", idCurso);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            cerrarConexion();

        }

        public void actualizarEstudiantes(int idEstudiante, string nombre, string apellido, int edad, string matricula,
            string telefono, string direccion, string email, string usuario, string contraseña, int idCurso)
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "SpEstudiantesActualizar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@Edad", edad);
            comando.Parameters.AddWithValue("@Matricula", matricula);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Contraseña", contraseña);
            comando.Parameters.AddWithValue("@Curso", idCurso);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            cerrarConexion();
        }

        public void eliminarEstudiantes(int idEstudiante)
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "SpEstudiantesEliminar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            cerrarConexion();
        }

        //Tabla Maestros
        public DataTable listarMaestros()
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "SpMaestrosListar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            cerrarConexion();
            return tabla;

        }

        public void insertarMaestros(string nombre, string apellido, int edad, string telefono,
            string direccion, string email, string usuario, string contraseña)
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "SpMaestrosInsertar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@Edad", edad);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Contraseña", contraseña);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            cerrarConexion();

        }

        public void actualizarMaestros(int idMaestro, string nombre, string apellido, int edad,
            string telefono, string direccion, string email, string usuario, string contraseña)
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "SpMaestrosActualizar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idMaestro", idMaestro);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@Edad", edad);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Contraseña", contraseña);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            cerrarConexion();
        }

        public void eliminarMaestros(int idMaestro)
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "SpMaestrosEliminar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idMaestro", idMaestro);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            cerrarConexion();
        }

        //Tabla Cursos
        public DataTable listarCursos()
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "SpCursosListar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            cerrarConexion();
            return tabla;

        }

        public void insertarCursos(string nombre, int idMaestro)
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "SpCursosInsertar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@idMaestro", idMaestro);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            cerrarConexion();

        }

        public void actualizarCursos(int idCurso, string nombre, int idMaestro)
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "SpCursosActualizar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCurso", idCurso);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@idMaestro", idMaestro);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            cerrarConexion();
        }

        public void eliminarCursos(int idCurso)
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "SpCursosEliminar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCurso", idCurso);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            cerrarConexion();
        }
        //Form director

        //Form Maestros
        public DataTable listarCursosMaestros(int idMaestro)
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "spCursosMaestros";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idMaestro", idMaestro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            cerrarConexion();
            return tabla;
        }

        //Tabla calificaciones
        public DataTable listarCalificaciones(int idMaestro)
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "SpCalificacionesListar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idMaestro", idMaestro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            cerrarConexion();
            return tabla;
        }

        public void actualizarCalificaciones(int idCalificacion, int notaFinal)
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "SpCalificacionesActualizar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCalificacion", idCalificacion);
            comando.Parameters.AddWithValue("@notaFinal", notaFinal);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            cerrarConexion();
        }
        //Form Maestros

        //Form Estudiante
        public DataTable listarCalificacionEstudiante(int idEstudiante)
        {
            comando.Connection = abrirConexion();
            comando.CommandText = "spCalificacionesEstudiantes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            cerrarConexion();
            return tabla;
        }
        //Form Estudiante
    }
}
