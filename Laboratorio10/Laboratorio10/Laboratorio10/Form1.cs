using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratorio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbCopa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWafer.Checked)
            {
                txtTipo.Text = 2.00 + "";
            }
            else { txtWafer.Text = "0"; }
        }

        private void rbVaso_CheckedChanged(object sender, EventArgs e)
        {
            txtTipo.Text = 1.00 + "";
        }

        private void chkWafer_CheckedChanged(object sender, EventArgs e)
        {
            txtWafer.Text = "2.00";
        }

        private void chkDulces_CheckedChanged(object sender, EventArgs e)
        {
            txtDulces.Text = "1.50";
        }

        private void chkFudge_CheckedChanged(object sender, EventArgs e)
        {
            txtFudge.Text = "2.50";
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = int.Parse(nudCantidad.Value.ToString());
            txtCantidad.Text = (cantidad * 4) + "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cant = 0, tipo = 0;
            decimal wafer = 0, dulces = 0, fudge = 0, total = 0;
            cant = int.Parse(txtCantidad.Text);
            tipo = int.Parse(txtTipo.Text);
            wafer = decimal.Parse(txtWafer.Text);
            dulces = decimal.Parse(txtDulces.Text);
            fudge = decimal.Parse(txtFudge.Text);
            total = cant + tipo + wafer + dulces + fudge;
            txtTotal.Text = total + "";
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboSabor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
