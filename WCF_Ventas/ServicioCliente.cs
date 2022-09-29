using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
//Agregar 
using System.Data.Entity.Core;
using System.Security.Cryptography.X509Certificates;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código y en el archivo de configuración a la vez.
    public class ServicioCliente : IServicioCliente
    {
        //Instancia del modelo
        VentasLeonEntities MisVentas = new VentasLeonEntities();
        public ClienteDC ConsultarCliente(String strCodigo)
        {
            try
            {
                //Obtenemos con LINQ los datos del cliente consultado 
                Tb_Cliente objConsulta =
                    (
                    from miCliente in MisVentas.Tb_Cliente
                    where miCliente.Cod_cli == strCodigo
                    select miCliente
                    ).FirstOrDefault();

                //Creamos una instancia de la Data Contractual ClienteDC
                ClienteDC objClienteDC = new ClienteDC();
                objClienteDC.Cod_cli = objConsulta.Cod_cli;
                objClienteDC.Raz_soc_cli = objConsulta.Raz_soc_cli;
                objClienteDC.Dir_cli = objConsulta.Dir_cli;
                objClienteDC.Tel_cli = objConsulta.Tel_cli;
                objClienteDC.Contacto = objConsulta.Contacto;
                objClienteDC.Ruc_cli = objConsulta.Ruc_cli;
                objClienteDC.Departamento = objConsulta.Tb_Ubigeo.Departamento;
                objClienteDC.Provincia = objConsulta.Tb_Ubigeo.Provincia;
                objClienteDC.Distrito = objConsulta.Tb_Ubigeo.Distrito;
                objClienteDC.Tip_cli = Convert.ToInt16(objConsulta.Tip_cli);
                objClienteDC.Est_cli = Convert.ToInt16(objConsulta.Est_cli);
                objClienteDC.Fec_reg = Convert.ToDateTime(objConsulta.Fec_reg);
                objClienteDC.Deuda = CalcularDeudaCliente(objConsulta.Cod_cli);
                objClienteDC.Cant_FacturasPendientes = Convert.ToInt16
                    (
                    (from miFactura in MisVentas.Tb_Factura
                    where miFactura.Cod_cli == objConsulta.Cod_cli && miFactura.Est_fac == 1
                    select miFactura).Count()
                    );
                return objClienteDC;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public Single CalcularDeudaCliente(String strCodigo)
        {
            try
            {
                Single sngDeuda = 0;
                //Preguntamos si el cliente tiene facturas pendientes
                if ((from miFactura in MisVentas.Tb_Factura
                     where miFactura.Cod_cli == strCodigo && miFactura.Est_fac == 1
                     select miFactura).Count() == 0)
                {
                    sngDeuda = 0;
                }
                else
                {
                    sngDeuda = Convert.ToSingle
                                (
                        (from miFactura in MisVentas.Tb_Factura join misDetalles in MisVentas.Tb_Detalle_Factura
                          on miFactura.Num_fac  equals  misDetalles.Num_fac
                         where miFactura.Cod_cli == strCodigo && miFactura.Est_fac == 1
                         select misDetalles.Can_ven * misDetalles.Pre_ven).Sum()
                         );
                }
                return sngDeuda;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
