using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service04009
{
    internal class ServiceScaleDT
    {
        public int ID_DO_SERVIÇO { get; private set; }
        public DateOnly DATA_DE_INÍCIO_DA_ESCALA_DE_SERVIÇO { get; private set; }
        public DateOnly DATA_DE_FIM_DA_ESCALA_DE_SERVIÇO { get; private set; }

        public ServiceScaleDT(ServiceScale serviceScale)
        {
            ID_DO_SERVIÇO = serviceScale.id;
            DATA_DE_INÍCIO_DA_ESCALA_DE_SERVIÇO = serviceScale.firstDay;
            DATA_DE_FIM_DA_ESCALA_DE_SERVIÇO = serviceScale.lastDay;
        }
    }
}
