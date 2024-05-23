using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class FrmCorreos : Form
    {
        private List<string> correosSeleccionados;

        public FrmCorreos()
        {
            InitializeComponent();
            correosSeleccionados = new List<string>();

            // Registrar los eventos
            this.dgvCorreos.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvCorreos_CellDoubleClick);
            this.dgvCorreosSeleccionados.CellClick += new DataGridViewCellEventHandler(this.dgvCorreosSeleccionados_CellClick);

            // Registrar eventos de CheckBox
            this.chkAdministracion.CheckedChanged += new EventHandler(this.chkAdministracion_CheckedChanged);
            this.chkVigilancia.CheckedChanged += new EventHandler(this.chkVigilancia_CheckedChanged);
            this.chkCocina.CheckedChanged += new EventHandler(this.chkCocina_CheckedChanged);
            this.chkLimpieza.CheckedChanged += new EventHandler(this.chkLimpieza_CheckedChanged);
            this.chkEnfermeria.CheckedChanged += new EventHandler(this.chkEnfermeria_CheckedChanged);
        }

        private void FrmCorreos_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
            dgvCorreosSeleccionados.RowHeadersVisible = false;
            dgvCorreos.RowHeadersVisible = false;
        }

        private void LlenarDataGridView()
        {
            List<Empleado> empleados = Empleado.ObtenerEmpleadosParaCorreo();

            foreach (Empleado emp in empleados)
            {
                dgvCorreos.Rows.Add(emp.Nombre, emp.Apellidos, emp.Nif, emp.Puesto, emp.Correo);
            }
        }

        private void dgvCorreos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la celda clickeada es de la columna de correos y es válida
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvCorreos.Columns["dgvCorreo"].Index)
            {
                // Obtener el correo de la celda clickeada
                string correo = dgvCorreos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Añadir el correo a la lista si no está ya en ella
                if (!correosSeleccionados.Contains(correo))
                {
                    correosSeleccionados.Add(correo);

                    // Añadir el correo al DataGridView de correos seleccionados
                    dgvCorreosSeleccionados.Rows.Add(correo);
                }
            }
        }

        private void dgvCorreosSeleccionados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la celda clickeada es válida
            if (e.RowIndex >= 0)
            {
                // Obtener el correo de la celda clickeada
                string correo = dgvCorreosSeleccionados.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Eliminar el correo de la lista
                correosSeleccionados.Remove(correo);

                // Eliminar la fila del DataGridView
                dgvCorreosSeleccionados.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void chkAdministracion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdministracion.Checked)
            {
                ActualizarCorreosSeleccionados("ADMINISTRACION");
            }
            else
            {
                RemoverCorreosSeleccionados("ADMINISTRACION");
            }
        }

        private void chkVigilancia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVigilancia.Checked)
            {
                ActualizarCorreosSeleccionados("VIGILANCIA");
            }
            else
            {
                RemoverCorreosSeleccionados("VIGILANCIA");
            }
        }

        private void chkCocina_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCocina.Checked)
            {
                ActualizarCorreosSeleccionados("COCINA");
            }
            else
            {
                RemoverCorreosSeleccionados("COCINA");
            }
        }

        private void chkLimpieza_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLimpieza.Checked)
            {
                ActualizarCorreosSeleccionados("LIMPIEZA");
            }
            else
            {
                RemoverCorreosSeleccionados("LIMPIEZA");
            }
        }

        private void chkEnfermeria_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnfermeria.Checked)
            {
                ActualizarCorreosSeleccionados("ENFERMERIA");
            }
            else
            {
                RemoverCorreosSeleccionados("ENFERMERIA");
            }
        }

        private void ActualizarCorreosSeleccionados(string puesto)
        {
            // Obtener empleados del puesto que no estén ya en la lista de correos seleccionados
            List<Empleado> empleadosPuesto = Empleado.ObtenerEmpleadosPorPuesto(puesto)
                .Where(emp => !correosSeleccionados.Contains(emp.Correo))
                .ToList();

            // Agregar los correos de los empleados al DataGridView de correos seleccionados
            foreach (Empleado emp in empleadosPuesto)
            {
                correosSeleccionados.Add(emp.Correo);
                dgvCorreosSeleccionados.Rows.Add(emp.Correo);
            }
        }

        private void RemoverCorreosSeleccionados(string puesto)
        {
            // Eliminar los correos de los empleados del puesto de la lista de correos seleccionados si es necesario
            List<string> correosPuesto = Empleado.ObtenerEmpleadosPorPuesto(puesto)
                .Select(emp => emp.Correo)
                .ToList();

            correosSeleccionados = correosSeleccionados.Except(correosPuesto).ToList();

            // Actualizar el DataGridView de correos seleccionados
            dgvCorreosSeleccionados.Rows.Clear();
            foreach (var correo in correosSeleccionados)
            {
                dgvCorreosSeleccionados.Rows.Add(correo);
            }
        }



        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            string asunto = txtAsunto.Text;
            string mensaje = txtMensaje.Text;

            if (string.IsNullOrEmpty(asunto) || string.IsNullOrEmpty(mensaje) || dgvCorreosSeleccionados.Rows.Count == 0)
            {
                MessageBox.Show("Revise y rellene todos los campos", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (DataGridViewRow row in dgvCorreosSeleccionados.Rows)
                {
                    // Suponiendo que la columna del correo electrónico es la primera columna (index 0)
                    string destinatario = row.Cells[0].Value.ToString();

                    Correo correo = new Correo(destinatario, asunto, mensaje);
                    correo.EnviarCorreo(false); // true para mostrar mensaje de éxito o error
                }

                // Limpiar las listas y el DataGridView después de enviar los correos electrónicos
                txtAsunto.Clear();
                txtMensaje.Clear();

                // Limpiar el DataGridView
                dgvCorreosSeleccionados.Rows.Clear();

                // Limpiar la lista de correos seleccionados
                correosSeleccionados.Clear();

                // Actualizar el DataGridView para asegurar que está listo para nuevas entradas
                dgvCorreosSeleccionados.Refresh();
                MessageBox.Show("Correo enviados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
