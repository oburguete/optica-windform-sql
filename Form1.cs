using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace OpticaWinForms
{
    public partial class FrmPedido : Form
    {
        string conexion = "server=127.0.0.1;port=3307;database=optica_db;user=root;password=1234;";
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMica.Items.Add("Monofocal");
            cmbMica.Items.Add("Bifocal");
            cmbMica.Items.Add("Progresivo");

            cmbTratamiento.Items.Add("Sin tratamiento");
            cmbTratamiento.Items.Add("Antirreflejante");
            cmbTratamiento.Items.Add("Fotocromático");
            cmbTratamiento.Items.Add("Fotocromático + Antirreflejante");

            cmbArmazon.Items.Add("Metal");
            cmbArmazon.Items.Add("Pasta");
            cmbArmazon.Items.Add("Aro completo");
            cmbArmazon.Items.Add("Semi al aire");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precio, anticipo, resta;

            if (txtPrecio.Text == "" || txtAnticipo.Text == "")
            {
                MessageBox.Show("Escribe precio y anticipo");
                return;
            }

            precio = Convert.ToDouble(txtPrecio.Text);
            anticipo = Convert.ToDouble(txtAnticipo.Text);

            resta = precio - anticipo;

            txtResta.Text = resta.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtTelefono.Clear();

            txtODEsfera.Clear();
            txtODCilindro.Clear();
            txtODEje.Clear();

            txtOIEsfera.Clear();
            txtOICilindro.Clear();
            txtOIEje.Clear();

            txtAdicion.Clear();
            txtObservaciones.Clear();

            txtPrecio.Clear();
            txtAnticipo.Clear();
            txtResta.Clear();

            cmbMica.SelectedIndex = -1;
            cmbTratamiento.SelectedIndex = -1;
            cmbArmazon.SelectedIndex = -1;

            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" ||
        txtTelefono.Text == "" ||
        txtODEsfera.Text == "" ||
        txtODCilindro.Text == "" ||
        txtODEje.Text == "" ||
        txtOIEsfera.Text == "" ||
        txtOICilindro.Text == "" ||
        txtOIEje.Text == "" ||
        cmbMica.SelectedIndex == -1 ||
        cmbTratamiento.SelectedIndex == -1 ||
        cmbArmazon.SelectedIndex == -1)
            {
                MessageBox.Show("Llena todos los campos");
                return;
            }
            MySqlConnection con = new MySqlConnection(conexion);

            try
            {
                con.Open();
                string sql = "INSERT INTO pedidos (nombre_cliente, telefono, od_esfera, od_cilindro, od_eje, oi_esfera, oi_cilindro, oi_eje, adicion, total, anticipo, saldo) " +
                "VALUES (@nombre, @telefono, @odesfera, @odcilindro, @odeje, @oiesfera, @oicilindro, @oieje, @adicion, @total, @anticipo, @saldo)";




                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@odesfera", txtODEsfera.Text);
                cmd.Parameters.AddWithValue("@odcilindro", txtODCilindro.Text);
                cmd.Parameters.AddWithValue("@odeje", txtODEje.Text);
                cmd.Parameters.AddWithValue("@oiesfera", txtOIEsfera.Text);
                cmd.Parameters.AddWithValue("@oicilindro", txtOICilindro.Text);
                cmd.Parameters.AddWithValue("@oieje", txtOIEje.Text);

                cmd.Parameters.AddWithValue("@adicion", txtAdicion.Text);
                cmd.Parameters.AddWithValue("@total", txtPrecio.Text);
                cmd.Parameters.AddWithValue("@anticipo", txtAnticipo.Text);
                cmd.Parameters.AddWithValue("@saldo", txtResta.Text);

                int filas = cmd.ExecuteNonQuery();

                MessageBox.Show("Filas guardadas: " + filas);


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void ss(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
