using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP3_SIM.Formularios;

namespace TP3_SIM.Entidades
{
    internal class Montecarlo
    {
        public int CantidadSimulaciones { get; set; }
        public int FilaDesde { get; set; }
        public int FilaHasta { get; set; }
        public double probNoResponde { get; set; }
        public double probRecordaba { get; set; }
        public double probNoRecordaba { get; set; }
        public double probNo1 { get; set; }
        public double probDudoso1 { get; set; }
        public double probSi1 { get; set; }
        public double probNo2 { get; set; }
        public double probDudoso2 { get; set; }
        public double probSi2 { get; set; }
        public FormMontecarlo FormularioMontecarlo { get; set; }
        public DataGridView Grilla { get; set; }

        private readonly Random RND = new Random();

        public double GenerarRND()
        {
            return Math.Truncate(RND.NextDouble() * 100) / 100;
        }

        public void Simular()
        {
            // Obtener la grilla y prepararla (mejora rendimiento).

            DataGridView grilla = FormularioMontecarlo.DevolverGrilla();
            PrepararGrilla(grilla);
            this.Grilla = grilla;

            // Obtener iteraciones a agregar en un HashSet para solo agregar en la grilla los valores deseados.

            HashSet<int> iteracionesGrilla = IteracionesParaGrilla();

            // Inicializar filar y variables a utilizar.

            Fila fila1 = new Fila();
            Fila fila2 = new Fila();

            // Cargar las filas a la grilla.

            CargarFilas(fila1, fila2, iteracionesGrilla);

            // Mostrar formulario.

            MostrarFormulario(FormularioMontecarlo, Grilla);

        }

        public void CargarFilas(Fila fila1, Fila fila2, HashSet<int> iteracionesGrilla)
        {
            fila1.CantCompras = 0;

            // Suspender layout para mejorar rendimiento de grilla

            Grilla.SuspendLayout();

            // Cargar filas y actualizar la anterior.

            for (int i = 1; i <= CantidadSimulaciones; ++i)
            {

                fila2.Persona = i;

                fila2.RNDRta1 = GenerarRND().ToString();
                fila2.Recordaba = CalcularRecordaba(probNoResponde, probRecordaba, probNoRecordaba, Convert.ToDouble(fila2.RNDRta1));

                fila2.RNDRta2 = (fila2.Recordaba == "Si") ? GenerarRND().ToString() : "";
                fila2.Compra1 = (fila2.Recordaba == "Si") ? CalcularCompra(probNo1, probDudoso1, probSi1, Convert.ToDouble(fila2.RNDRta2)) : "";
  
                fila2.RNDRta3 = (fila2.Recordaba == "No") ? GenerarRND().ToString() : "";
                fila2.Compra2 = (fila2.Recordaba == "No") ? CalcularCompra(probNo2, probDudoso2, probSi2, Convert.ToDouble(fila2.RNDRta3)) : "";

                fila2.CantCompras = fila1.CantCompras + ((fila2.Compra1 == "Si" || fila2.Compra2 == "Si") ? 1 : 0);    


                fila1.Persona = fila2.Persona;

                fila1.RNDRta1 = fila2.RNDRta1;
                fila1.Recordaba = fila2.Recordaba;

                fila1.RNDRta2 = fila2.RNDRta2;
                fila1.Compra1 = fila2.Compra1;

                fila1.RNDRta3 = fila2.RNDRta3;
                fila1.Compra2 = fila2.Compra2;

                fila1.CantCompras = fila2.CantCompras;

                // Carga la fila en la grilla. Revisa que sólo se cargue lo seleccionado.

                if (iteracionesGrilla.Contains(i))
                {
                    AgregarFilaEnGrilla(fila2);
                }
            }

            // Calcular y poner el porcentaje de ocupación en la grilla.

            double porcentajeProbabilidadSi = Math.Truncate((Convert.ToDouble(fila2.CantCompras) * 100 / CantidadSimulaciones) * 100) / 100;
            FormularioMontecarlo.LblPorcentajeSi = porcentajeProbabilidadSi.ToString() + "%";

            // Reactivar layout de la grilla al finalizar de actualizar.

            Grilla.ResumeLayout(false);
        }

        private HashSet<int> IteracionesParaGrilla()
        {
            // Agrega a un HashSet los valores de iteraciones que la grilla debería mostrar
            // (el primero, valores desde y hasta del usuario y el último).

            HashSet<int> iteracionesGrilla = new HashSet<int>();

            iteracionesGrilla.Add(1);

            for (int i = FilaDesde; i <= FilaHasta; ++i)
            {
                iteracionesGrilla.Add(i);
            }

            iteracionesGrilla.Add(CantidadSimulaciones);

            return iteracionesGrilla;

        }

        private void PrepararGrilla(DataGridView grilla)
        {
            // Mejorar el rendimiento de la grilla.

            grilla.Rows.Clear();
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grilla.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grilla.RowHeadersVisible = false;
            grilla.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(grilla, true, null);
            grilla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        private void MostrarFormulario(Form formulario, DataGridView grilla)
        {
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.RowHeadersVisible = true;
            formulario.Show();
        }

        static string CalcularRecordaba(double probA, double probB, double probC, double random)
        {
            double sumaProb = probA + probB + probC;

            if (Math.Abs(sumaProb - 1.0) > 0.001)
            {
                //throw new ArgumentException("Las probabilidades deben sumar 1.0");
            }

            if (random < probA)
            {
                return "N/R";
            }
            else if (random < probA + probB)
            {
                return "Si";
            }
            else
            {
                return "No";
            }
        }

        static string CalcularCompra(double probA, double probB, double probC, double random)
        {
            double sumaProb = probA + probB + probC;

            if (Math.Abs(sumaProb - 1.0) > 0.001)
            {
                //throw new ArgumentException("Las probabilidades deben sumar 1.0");
            }

            if (random < probA)
            {
                return "No";
            }
            else if (random < probA + probB)
            {
                return "Dudoso";
            }
            else
            {
                return "Si";
            }
        }

        /*
        private string CalcularRecordaba2(double random)
        {
            if (0.00 <= random && random <= probNoRecordaba - 1) return "N/R";

            if (0.10 <= random && random <= 0.49) return "Si";

            if (0.50 <= random && random <= 0.99) return "No";

            return "";
        }

        private string CalcularCompra1(double random)
        {
            if (0.00 <= random && random <= 0.29) return "No";

            if (0.30 <= random && random <= 0.59) return "Dudoso";

            if (0.60 <= random && random <= 0.99) return "Si";

            return "";
        }

        private string CalcularCompra2(double random)
        {
            if (0.00 <= random && random <= 0.49) return "No";

            if (0.50 <= random && random <= 0.89) return "Dudoso";

            if (0.90 <= random && random <= 0.99) return "Si";

            return "";
        }
        */

        private void AgregarFilaEnGrilla(Fila fila)
        {
            Grilla.Rows.Add
                (
                fila.Persona,
                fila.RNDRta1,
                fila.Recordaba,
                fila.RNDRta2,
                fila.Compra1,
                fila.RNDRta3,
                fila.Compra2,
                fila.CantCompras
                );
        }

    }
}
