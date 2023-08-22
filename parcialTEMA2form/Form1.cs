using System.Windows.Forms;

namespace parcialTEMA2form
{
    public partial class Form1 : Form
    {
        private object errorProvider1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvMedidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                InicializarControles();
            }

            private void AgregarFila(DataGridViewRow r) => dgvMedidas.Rows.Add(r);

            private void SetearFila(DataGridViewRow r, double radio, double altura)
            {
                double Base;
                r.Cells[colAltura.Index].Value = altura;
                r.Cells[colRadio.Index].Value = CalcularVolumen;
                r.Cells[colArea.Index].Value = CalcularArea( altura);
                r.Cells[colBase.Index].Value = CalcularBase(volumen);
                r.Cells[colVolumen.Index].Value = CalcularVolumen(radio, altura);
            }

            

            private object CalcularArea( double altura)
            {
                
            }

            private DataGridViewRow ConstruirFila()
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvMedidas);
                return r;
            }

            private bool ValidarDatos()
            {
                bool esValido = true;
                errorProvider1.Clear();
                return esValido;
            }

            private void btnBorrar_Click(object sender, EventArgs e)
            {
                BorrarGrilla();
            }

            private void BorrarGrilla()
            {
                dgvMedidas.Rows.Clear();

                txtAltura.Clear();
               
                txtAltura.Focus();
            }
        }

        private static object CalcularVolumen(double radio, double altura)
        {
            double Resultado;
            Resultado = (Math.PI * Math.Pow(radio, 2)) * altura;
            return Math.Truncate(Resultado);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var altura = double.Parse(txtAltura.Text);
                var radio = double.Parse(txtRadio.Text);
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, altura);
                AgregarFila(r);
                MessageBox.Show("Medidas agregadas",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                InicializarControles();
            }
        }

        private void InicializarControles()
        {
            txtAltura.Clear();

            txtAltura.Focus();
        }
    }

}
    