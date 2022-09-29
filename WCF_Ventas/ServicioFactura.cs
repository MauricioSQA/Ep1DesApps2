using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
//Agregar
using System.Data.Entity.Core;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioFactura" en el código y en el archivo de configuración a la vez.
    public class ServicioFactura : IServicioFactura
    {
        //Instanciamos el modelo...
        VentasLeonEntities MisVentas = new VentasLeonEntities();
        public List<FacturaDC> ListarFacturasClienteFechas(String strCodigo,DateTime fecini,DateTime fecfin)
        {
            try
            {
                //Creamos una lista de facturas...
                List<FacturaDC> objListaFacturaDC = new List<FacturaDC>();

                //Hacemos la consulta con LINQ
                var query = (from miFactura in MisVentas.Tb_Factura
                             where miFactura.Cod_cli == strCodigo && miFactura.Fec_fac >= fecfin
                             select miFactura
                             );
                //Recorremos el resultado...
                foreach (var resultado in query)
                {
                    FacturaDC objFacturaDC = new FacturaDC();
                    objFacturaDC.Num_fac = resultado.Num_fac;
                    objFacturaDC.Fec_fac = Convert.ToDateTime(resultado.Fec_fac);
                    objFacturaDC.Fec_can = Convert.ToDateTime(resultado.Fec_can);
                    objFacturaDC.Est_fac = Convert.ToInt16(resultado.Est_fac);
                    if (objFacturaDC.Est_fac == 1)
                    {
                        objFacturaDC.Estado = "Pendiente";
                    }
                    else if (objFacturaDC.Est_fac == 2)
                    {
                        objFacturaDC.Estado = "Cancelado";
                    }
                    else
                    {
                        objFacturaDC.Estado = "Anulada";
                    }
                    objFacturaDC.Cod_ven = resultado.Cod_ven;
                    objFacturaDC.ApellNom_ven = resultado.Tb_Vendedor.Ape_ven + "," + resultado.Tb_Vendedor.Nom_ven;
                    objFacturaDC.Total = Convert.ToSingle(
                        (
                        from miDetalle in MisVentas.Tb_Detalle_Factura
                        where miDetalle.Num_fac == resultado.Num_fac
                        select miDetalle.Can_ven * miDetalle.Pre_ven).Sum()
                        );
                    objListaFacturaDC.Add(objFacturaDC);
                }
                return objListaFacturaDC;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    
        public List<FacturaDC>ListarFacturasVendedorFechas(String strCodigo, DateTime fecfini, DateTime fecfin)
        {
            try
            {
                //Creamos una lista de facturas...
                List<FacturaDC> objListaFacturaDC = new List<FacturaDC>();

                //Hacemos la consulta con LINQ
                var query = MisVentas.usp_ListarFacturasVendedorFechas(strCodigo, fecfini, fecfin);

                //Recorremos el resultado   
                foreach (var resultado in query)
                {
                    FacturaDC objFacturaDC = new FacturaDC();
                    objFacturaDC.Num_fac = resultado.num_fac;
                    objFacturaDC.Fec_fac = Convert.ToDateTime(resultado.fec_fac);
                    objFacturaDC.Fec_can = Convert.ToDateTime(resultado.fec_can);
                    objFacturaDC.Estado = resultado.estado;

                    objFacturaDC.Cod_cli = resultado.Cod_cli;
                    objFacturaDC.Raz_soc_cli = resultado.Raz_soc_cli;
                    objFacturaDC.Total = Convert.ToSingle(resultado.total);
                    
                    //Agregamos la instancia a la lista...
                    objListaFacturaDC.Add(objFacturaDC);
                }
                return objListaFacturaDC;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
