using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioFactura" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioFactura
    {
        [OperationContract]
        List<FacturaDC> ListarFacturasClienteFechas(String strCodigo, DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<FacturaDC> ListarFacturasVendedorFechas(String strCodigo, DateTime fecini, DateTime fecfin);
    }
    [DataContract]
    [Serializable]
    public class FacturaDC
    {
        [DataMember]
        public String Num_fac { get; set; }
        [DataMember]
        public DateTime Fec_fac { get; set; }
        [DataMember]
        public DateTime Fec_can { get; set; }
        [DataMember]
        public String Cod_cli { get; set; }
        [DataMember]
        public String Raz_soc_cli { get; set; }
        [DataMember]
        public Single Total { get; set; }
        [DataMember]
        public Int16 Est_fac { get; set; }
        [DataMember]
        public String Estado { get; set; }
        [DataMember]
        public String Cod_ven { get; set; }
        [DataMember]
        public String ApellNom_ven { get; set; }

    }

}
