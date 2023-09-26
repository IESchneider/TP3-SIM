using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP3_SIM.Entidades;
using TP3_SIM.Formularios;

namespace TP3_SIM
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            LimpiarCampos();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            // Revisar que los datos ingresados pasen por todas las validaciones.

            if (txtNumeroSimulaciones.Text.Equals("") || txtFilaDesde.Text.Equals("") || txtFilaHasta.Text.Equals(""))
            {
                MessageBox.Show("No ha ingresado todos los datos requeridos, intente nuevamente.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidacionDesdeHasta()) return;

            if (!ValidacionesParametros()) return;

            // Si validó la información, comenzar la simulación.

            ComenzarSimulacion();
        }

        private void ComenzarSimulacion()
        {
            // Enviar los datos de los valores de la primera simulación.

            Montecarlo montecarlo = new Montecarlo();

            montecarlo.CantidadSimulaciones = Convert.ToInt32(txtNumeroSimulaciones.Text.Trim());
            montecarlo.FilaDesde = Convert.ToInt32(txtFilaDesde.Text.Trim());
            montecarlo.FilaHasta = Convert.ToInt32(txtFilaHasta.Text.Trim());
            
            montecarlo.probNoResponde = Convert.ToDouble(probNoResponde.Value);
            montecarlo.probRecordaba = Convert.ToDouble(probRecordaba.Value);
            montecarlo.probNoRecordaba = Convert.ToDouble(probNoRecordaba.Value);

            montecarlo.probNo1 = Convert.ToDouble(probNo1.Value);
            montecarlo.probDudoso1 = Convert.ToDouble(probDudoso1.Value);
            montecarlo.probSi1 = Convert.ToDouble(probSi1.Value);

            montecarlo.probNo2 = Convert.ToDouble(probNo2.Value);
            montecarlo.probDudoso2 = Convert.ToDouble(probDudoso2.Value);
            montecarlo.probSi2 = Convert.ToDouble(probSi2.Value);

            montecarlo.FormularioMontecarlo = new FormMontecarlo();

            montecarlo.Simular();
        }

        private bool ValidacionDesdeHasta()
        {
            // Lista de validaciones para los números desde y hasta.

            int numeroSimulaciones = Convert.ToInt32(txtNumeroSimulaciones.Text.Trim());
            int filaDesde = Convert.ToInt32(txtFilaDesde.Text.Trim());
            int filaHasta = Convert.ToInt32(txtFilaHasta.Text.Trim());

            if (filaDesde > numeroSimulaciones || filaHasta > numeroSimulaciones)
            {
                MessageBox.Show("Las filas a mostrar deben estar dentro del número de simulaciones realizadas, intente nuevamente.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (filaHasta < filaDesde)
            {
                MessageBox.Show("El valor ingresado en la fila de comienzo debe ser menor al de la fila de fin, intente nuevamente.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que la diferencia de filas ingresada por el usuario sea menor a 500.

            int diferencia = filaHasta - filaDesde;

            if (diferencia > 500)
            {
                MessageBox.Show("El valor de filas a mostrar debe ser de hasta 500, intente nuevamente.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtFilaDesde.Clear();
            txtFilaHasta.Clear();
            txtNumeroSimulaciones.Clear();
        }

        private bool ValidacionesParametros()
        {

            // Lista de validaciones de todos los parámetros.

            /*
            if (probNoResponde.Value >= 0 && probRecordaba.Value >= 0 && probNoRecordaba.Value >= 0 &&
                probNo1.Value >= 0 && probDudoso1.Value >= 0 && probSi1.Value >= 0 &&
                probNo2.Value >= 0 && probDudoso2.Value >= 0 && probSi2.Value >= 0)
            {

            }
            else
            {
                // Al menos uno de los valores es negativo
                MessageBox.Show("Hay un valor de probabilidad que es negativo, intente nuevamente.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            */

            if ((Math.Abs(Convert.ToDouble(probNoResponde.Value + probRecordaba.Value + probNoRecordaba.Value) - 1.0) > 0.001) ||
                (Math.Abs(Convert.ToDouble(probNo1.Value + probDudoso1.Value + probSi1.Value) - 1.0) > 0.001) ||
                (Math.Abs(Convert.ToDouble(probNo2.Value + probDudoso2.Value + probSi2.Value) - 1.0) > 0.001))
            {
                MessageBox.Show("La suma de las probabilidades tiene que sumar 1, intente nuevamente.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            // Desactivar botones hasta que se active la casilla de permitir edición.

            if (checkBoxEdicion.Checked == false)
            {
                DesactivarBotonesParametros();
            }

            // Cargar los valores por defecto del ejercicio en los numerics.

            CargarValoresPorDefecto();
        }

        private void CargarValoresPorDefecto()
        {
            // Insertar valores por defecto en los numerics.

            probNoResponde.Value = 0.10M;
            probRecordaba.Value = 0.40M;
            probNoRecordaba.Value = 0.50M;
            
            probNo1.Value = 0.30M;
            probDudoso1.Value = 0.30M;
            probSi1.Value = 0.40M;

            probNo2.Value = 0.50M;
            probDudoso2.Value = 0.40M;
            probSi2.Value = 0.10M;
        }

        private void checkBoxEdicion_CheckedChanged(object sender, EventArgs e)
        {
            // Activar o desactivar la edición de parámetros según el checkbox.

            if (checkBoxEdicion.Checked)
            {
                ActivarBotonesParametros();
            }
            else
            {
                DesactivarBotonesParametros();
            }
        }

        private void DesactivarBotonesParametros()
        {
            probNoResponde.Enabled = false;
            probRecordaba.Enabled = false;
            probNoRecordaba.Enabled = false;

            probNo1.Enabled = false;
            probDudoso1.Enabled = false;
            probSi1.Enabled = false;

            probNo2.Enabled = false;
            probDudoso2.Enabled = false;
            probSi2.Enabled = false;
        }

        private void ActivarBotonesParametros()
        {
            probNoResponde.Enabled = true;
            probRecordaba.Enabled = true;
            probNoRecordaba.Enabled = true;

            probNo1.Enabled = true;
            probDudoso1.Enabled = true;
            probSi1.Enabled = true;

            probNo2.Enabled = true;
            probDudoso2.Enabled = true;
            probSi2.Enabled = true;
        }
    }
}
