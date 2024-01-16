using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNominas_v1
{
    public class Nomina
    {
        // MIEMBROS PRIVADOS DE LA CLASE
        private string _nombre;
        private string _apellidos;
        private string _puesto;
        private int _horasTrabajadas;
        private float _salarioHora;



        // PROPIEDADES - Mecanismo para poder acceder a los miembros para poder dotarlos de protección y seguridad

        /// <summary>
        /// Nombre del Empleado
        /// </summary>
        public string NombreEmpleado
        {
            get {
                // Control de Contenido
                if (string.IsNullOrEmpty(_nombre)) throw new Exception("Nombre del Trabajador no establecido");

                //Devolución del valor
                return _nombre;
            }
            set {
                // Validación de los Datos a establecer
                // La "palabra clave" de Set siempre es "value" ya que es lo que establece
                if (string.IsNullOrEmpty(value)) throw new Exception("El Nombre del Trabajador no puede ser null o cadena vacía");


                // Establecimiento del valor al miembro privado
                _nombre = value;
            }
        }

        public string ApellidosEmpleado{
            get {
                // Control de Contenido
                
                
                // Devolución del valor
                return _apellidos;
            }
            set{
                // Validación de los Datos a establecer

                
                // Establecimiento del valor al miembro provado
                _apellidos = value;
            }
        }
        
    }
}
