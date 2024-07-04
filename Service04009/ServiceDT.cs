using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service04009
{
    internal class ServiceDT
    {
        public int ID_DO_SERVIÇO { get; private set; }
        public DateOnly DIA_DO_SERVIÇO { get; private set; }
        public Shooter? COMANDANTE_DA_GUARDA { get; private set; }
        public Shooter? PERMANÊNCIA_1 { get; private set; }
        public Shooter? PERMANÊNCIA_2 { get; private set; }
        public Shooter? SENTINELA_1 { get; private set; }
        public Shooter? SENTINELA_2 { get; private set; }
        public Shooter? SENTINELA_3 { get; private set; }

        public ServiceDT(Service service)
        {
            ID_DO_SERVIÇO = service.Id;
            DIA_DO_SERVIÇO = service.Date;
            COMANDANTE_DA_GUARDA = service.CommanderOfTheGuard != null
                ? service.CommanderOfTheGuard
                : null;

            if (service.Permanences != null && service.Permanences.Count > 0)
            {
                PERMANÊNCIA_1 = service.Permanences[0] != null
                    ? service.Permanences[0]
                    : null;
            }

            if (service.Permanences != null && service.Permanences.Count > 1)
            {
                PERMANÊNCIA_2 = service.Permanences[1] != null
                    ? service.Permanences[1]
                    : null;
            }

            if (service.Sentinels != null && service.Sentinels.Count > 0)
            {
                SENTINELA_1 = service.Sentinels[0] != null
                    ? service.Sentinels[0]
                    : null;
            }

            if (service.Sentinels != null && service.Sentinels.Count > 1)
            {
                SENTINELA_2 = service.Sentinels[1] != null
                    ? service.Sentinels[1] : null;
            }

            if (service.Sentinels != null && service.Sentinels.Count > 2)
            {
                SENTINELA_3 = service.Sentinels[2] != null
                    ? service.Sentinels[2]
                    : null;
            }
        }
    }
}
