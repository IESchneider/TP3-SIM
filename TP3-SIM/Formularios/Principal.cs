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

            //montecarlo.LimiteInferiorNormal = Convert.ToDouble(numLimiteInferiorNormal.Value);
            //montecarlo.LimiteSuperiorNormal = Convert.ToDouble(numLimiteSuperiorNormal.Value);
            //montecarlo.CostoPasarNoche = Convert.ToDouble(numCostoPasarNoche.Value);
            //montecarlo.CostoMuelleDesocupado = Convert.ToDouble(numCostoMuelleDesocupado.Value);
            //montecarlo.MinimoCantidadBarcosDescargados = Convert.ToInt32(numMinimoUniforme.Value);
            //montecarlo.MaximoCantidadBarcosDescargados = Convert.ToInt32(numMaximoUniforme.Value);
            //montecarlo.MediaLlegadaBarcos = Convert.ToInt32(numMediaPoisson.Value);

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
            if (numLimiteInferiorNormal.Value > numLimiteSuperiorNormal.Value || numLimiteSuperiorNormal.Value == 0)
            {
                MessageBox.Show("Los valores de costo de descarga son inválidos, intente nuevamente.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numCostoPasarNoche.Value == 0)
            {
                MessageBox.Show("El valor de costo de pasar la noche es inválido, intente nuevamente.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numCostoMuelleDesocupado.Value == 0)
            {
                MessageBox.Show("El valor de costo de muelle desocupado es inválido, intente nuevamente.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numMinimoUniforme.Value > numMaximoUniforme.Value || numMaximoUniforme.Value == 0)
            {
                MessageBox.Show("Los valores de cantidad de barcos descargados son inválidos, intente nuevamente.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numMediaPoisson.Value == 0)
            {
                MessageBox.Show("La media de llegadas para la distribución de Poisson debe ser mayor a cero, intente nuevamente.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            */
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

            //numLimiteInferiorNormal.Value = 120;
            //numLimiteSuperiorNormal.Value = 800;
            //numCostoPasarNoche.Value = 1500;
            //numCostoMuelleDesocupado.Value = 3200;
            //numMinimoUniforme.Value = 0;
            //numMaximoUniforme.Value = 9;
            //numMediaPoisson.Value = 2;
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
            //numLimiteInferiorNormal.Enabled = false;
            //numLimiteSuperiorNormal.Enabled = false;
            //numCostoPasarNoche.Enabled = false;
            //numCostoMuelleDesocupado.Enabled = false;
            //numMinimoUniforme.Enabled = false;
            //numMaximoUniforme.Enabled = false;
            //numMediaPoisson.Enabled = false;
        }

        private void ActivarBotonesParametros()
        {
            //numLimiteInferiorNormal.Enabled = true;
            //numLimiteSuperiorNormal.Enabled = true;
            //numCostoPasarNoche.Enabled = true;
            //numCostoMuelleDesocupado.Enabled = true;
            //numMinimoUniforme.Enabled = true;
            //numMaximoUniforme.Enabled = true;
            //numMediaPoisson.Enabled = true;
        }
    }
}
