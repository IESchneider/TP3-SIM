using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_SIM.Formularios
{
    public partial class FormMontecarlo : Form
    {
        public string LblPorcentajeSi { get; set; }

        public FormMontecarlo()
        {
            InitializeComponent();
        }

        public DataGridView DevolverGrilla()
        {
            return this.dgvGrillaMontecarlo;
        }

        private void FormMontecarlo_Load(object sender, EventArgs e)
        {
            lblPorcentajeSi.Text = LblPorcentajeSi;
        }

        private void lblPorcentajeSi_Click(object sender, EventArgs e)
        {

        }
    }
}
