using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
namespace CapaVista
{
    public partial class MantenimientoAlumno : Form
    {
        public MantenimientoAlumno()
        {
            InitializeComponent();
        }

        Controlador cn = new Controlador();

        public void LlenarCombo()
        {

            List<string> alumno = cn.ObtenerDatosM("carnet_alumno", "nombre_alumno","direccion_alumno","telefono_alumno","email_alumno","estatus_alumno", "alumnos");
            cb_alumno.Items.Clear();
            cb_alumno.Items.AddRange(alumno.ToArray());
         
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cargar_Click(object sender, EventArgs e)
        {
            LlenarCombo();
        }
    }
}
