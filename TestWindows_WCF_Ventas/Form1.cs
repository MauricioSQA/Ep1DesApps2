namespace TestWindows_WCF_Ventas
{
    public partial class Form1 : Form
    {   
        //Instancias del servicio...
        ProxyFactura.ServicioFacturaClient objServiceFactura = new ProxyFactura.ServicioFacturaClient();
        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();
        //Instancia  de la DataContractual
        ProxyCliente.ClienteDC objClienteDC = new ProxyCliente.ClienteDC();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                objClienteDC = objServiceCliente.ConsultarCliente(txtCod.Text.Trim());

                //Mostramos los datos...
                lblRs.Text = objClienteDC.Raz_soc_cli;
                lblRUC.Text = objClienteDC.Ruc_cli;
                lblDir.Text = objClienteDC.Dir_cli;
                lblUbigeo.Text = objClienteDC.Departamento + " - " + objClienteDC.Provincia + " - " + 
                        objClienteDC.Distrito;
                lblDeuda.Text = objClienteDC.Deuda.ToString("##,###,##0.00");

                //Llenamos el datagri con las facturas...
                dtgFacturas.DataSource = objServiceFactura.ListarFacturasClienteFechas(txtCod.Text.Trim(),
                    dtpFecIni.Value.Date, dtpFecFin.Value.Date);
                lblRegistros.Text = dtgFacturas.Rows.Count.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgFacturas.AutoGenerateColumns = false;
        }
    }
}