using System;
using System.Windows.Forms;
using UX.Logica;

namespace UX.Vistas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        AccesoDatos accDatos = new AccesoDatos();

        string saldos;

        private void frmMain_Load(object sender, EventArgs e)
        {
            saldos = "2277, 3953, 4726, 1414, 627, 1784, 1634, 3958, 2156, 1347, 2166, 820, 2325, 3613, 2389, 4130, 2007, 3027, 2591, 3940, 3888, 2975, 4470, 2291, 3393, 3588, 3286, 2293, 4353, 3315, 4900, 794, 4424, 4505, 2643, 2217, 4193, 2893, 4120, 3352, 2355, 3219, 3064, 4893, 272, 1299, 4725, 1900, 4927, 4011";
            txtSaldos.Text = saldos;
        }

        private void btnAsignarSaldos_Click(object sender, EventArgs e)
        {
            dgvSaldosAsignados.DataSource = accDatos.AsignarSaldos(saldos);

            btnAsignarSaldos.Enabled = false;
        }
    }
}
