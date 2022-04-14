using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas
{
    public class Dominio
    {
        private Datos datos = new Datos();

        public bool validarUsuario(string userName, string password)
        {
            bool validacion = false;

            validacion = datos.logins(userName, password);

            return validacion;
        }

        //public bool validarExistenciaEntidades()
        //{
        //    bool validacion = false;

        //    validacion = datos.validarExistenEntidades();

        //    return validacion;
        //}

        //Form Directores
        //Tabla Estudiantes
        public DataTable mostrarEstudiantes()
        {
            DataTable tabla = new DataTable();
            tabla = datos.listarEstudiantes();
            return tabla;
        }

        public void insertarEstudiantes(string nombre, string apellido, int edad, string matricula,
            string telefono, string direccion, string email, string usuario, string contraseña, int idCurso)
        {
            datos.insertarEstudiantes(nombre, apellido, edad, matricula, telefono, direccion, email, 
                usuario, contraseña, idCurso);
        }

        public void actualizarEstudiantes(int idEstudiante, string nombre, string apellido, int edad, string matricula,
            string telefono, string direccion, string email, string usuario, string contraseña, int idCurso)
        {
            datos.actualizarEstudiantes(idEstudiante, nombre, apellido, edad, matricula, telefono, direccion, email,
                usuario, contraseña, idCurso);
        }

        public void eliminarEstudiantes(int idEstudiante)
        {
            datos.eliminarEstudiantes(idEstudiante);
        }

        //Tabla Maestros
        public DataTable mostrarMaestros()
        {
            DataTable tabla = new DataTable();
            tabla = datos.listarMaestros();
            return tabla;
        }

        public void insertarMaestros(string nombre, string apellido, int edad,
            string telefono, string direccion, string email, string usuario, string contraseña)
        {
            datos.insertarMaestros(nombre, apellido, edad,telefono, direccion, email,
                usuario, contraseña);
        }

        public void actualizarMaestros(int idMaestro, string nombre, string apellido, int edad,
            string telefono, string direccion, string email, string usuario, string contraseña)
        {
            datos.actualizarMaestros(idMaestro, nombre, apellido, edad, telefono, direccion, email,
                usuario, contraseña);
        }

        public void eliminarMaestros(int idMaestro)
        {
            datos.eliminarMaestros(idMaestro);
        }

        //Tabla Cursos
        public DataTable mostrarCursos()
        {
            DataTable tabla = new DataTable();
            tabla = datos.listarCursos();
            return tabla;
        }

        public void insertarCursos(string nombre, int idMaestro)
        {
            datos.insertarCursos(nombre, idMaestro);
        }

        public void actualizarCursos(int idCurso, string nombre, int idMaestro)
        {
            datos.actualizarCursos(idCurso, nombre, idMaestro);
        }

        public void eliminarCursos(int idCurso)
        {
            datos.eliminarCursos(idCurso);
        }
        //Form Directores

        //Form Maestros
        public DataTable mostrarCursosMaestros(int idMaestro)
        {
            DataTable tabla = new DataTable();
            tabla = datos.listarCursosMaestros(idMaestro);
            return tabla;
        }

        //Tabla calificaciones
        public DataTable mostrarCalificaciones(int idMaestro)
        {
            DataTable tabla = new DataTable();
            tabla = datos.listarCalificaciones(idMaestro);
            return tabla;
        }

        public void actualizarCalificaciones(int idCalificacion, int notaFinal)
        {
            datos.actualizarCalificaciones(idCalificacion, notaFinal);
        }
        //Form Maestros

        //Form Estudiante
        public DataTable mostrarCalificacionEstudiante(int idEstudiante)
        {
            DataTable tabla = new DataTable();
            tabla = datos.listarCalificacionEstudiante(idEstudiante);
            return tabla;
        }
        //Form Estudiante
    }
}
