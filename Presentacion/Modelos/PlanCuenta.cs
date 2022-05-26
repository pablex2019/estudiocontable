using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Modelos
{
    public class PlanCuenta
    {
        public int idPlanCuenta { get; set; }
        public int PlanCuentacol { get; set; }
        public List<TipoCuenta> TiposCuentas { get; set; }
        public PlanCuentaBase PlanCuentaBase { get; set; }
    }
}
