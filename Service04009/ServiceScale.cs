using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service04009
{
    internal class ServiceScale
    {
        private List<Service> Services { get; }

        //A classe é criada passando o dia do primeiro serviço
        public ServiceScale(DateOnly firstDay)
        {
            Services = new List<Service>();

            // Cria 20 serviços com base no primeiro dia da escala
            for (int i = 0; i < 15; i++)
            {
                Services.Add(new Service(firstDay.AddDays(i)));
            }
        }

        // Método para definir a escala de serviço
        public List<Shooter> DefineScale(List<Shooter> shooters)
        {
            shooters.Sort();
            List<Shooter> cfcShooters = shooters.Where(s => s.isCfc).ToList(); // Lista dos Cfc
            cfcShooters.Sort();  // Ordeno os cfc (menor quantidade de serviços para maior)
            int minServicesCfc = cfcShooters[0].CountService();  //Pego o menor número que um dos cfc tirou de serviço
            List<Shooter> notCfcShooters = shooters.Where(s => !s.isCfc).ToList();  // Lista dos que não são Cfc
            notCfcShooters.Sort();  // Ordeno os que não são do cfc
            int minServices = notCfcShooters[0].CountService();  //Pego o menor número que um dos que não são cfc tirou de serviço

            // Aqui faço o algoritmo para selecionar os comandantes da guarda de cada dia (só pode cfc) enquanto não está completo

            while (!IsCompleteCommanders())
            {
                foreach (var service in Services)
                {
                    List<Shooter> commandersOK = new List<Shooter>();  // Lista para pegar os cfcs disponíveis para a data
                    foreach (var cfcShooter in cfcShooters)
                    {

                        if (cfcShooter.IsOk(service.Date, 1) && !HasInScale(cfcShooter) && cfcShooter.CountService() == minServicesCfc && !service.HasCommanderOfTheGuard()) // Se o cfc pode na data, ainda não foi escalado, não tem comandante da guarda no serviço ainda e o cfc está com o número de serviços tirados igual o menor número
                        {
                            commandersOK.Add(cfcShooter);
                        }
                    }
                    if (commandersOK.Count() != 0)  // Se têm cfcs disponíveis para a data, entra no if e seleciona um deles para o serviço de maneira aleatória
                    {
                        service.SetCommanderOfTheGuard(GetRandomShooter(commandersOK));
                    }
                }

                // Se mesmo tentando os cfcs que podem na data não está completa a escala de comandantes aí pega os que não estão na escala mas têm a menor quantidade de serviços tirados
                if (!IsCompleteCommanders())
                {
                    foreach (var service in Services)
                    {
                        List<Shooter> commanders = new List<Shooter>();
                        foreach (var cfcShooter in cfcShooters)
                        {
                            if (!HasInScale(cfcShooter) && cfcShooter.CountService() == minServicesCfc && !service.HasCommanderOfTheGuard())
                            {
                                commanders.Add(cfcShooter);
                                break;
                            }
                        }
                        if (commanders.Count() != 0)
                        {
                            service.SetCommanderOfTheGuard(GetRandomShooter(commanders));
                        }
                    }
                }
                minServicesCfc++;
            }

            while (!IsCompleteSentinels() || !IsCompletePermanences())
            {
                int aux = 0;
                foreach (var service in Services)
                {
                    List<Shooter> shootersOkPermanences = new List<Shooter>();
                    List<Shooter> shootersOkSentinels = new List<Shooter>();
                    foreach (var shooter in notCfcShooters)
                    {

                        if (shooter.IsOk(service.Date, 0) && !HasInScale(shooter) && shooter.CountService() == minServices && !service.IsCompletePermanences())
                        {
                            shootersOkPermanences.Add(shooter);
                        }
                        if (shooter.IsOk(service.Date, 1) && !HasInScale(shooter) && shooter.CountService() == minServices && !service.IsCompleteSentinels())
                        {
                            shootersOkSentinels.Add(shooter);
                        }
                    }

                    aux = service.GetPermancencesNecessaryAmount();
                    for (int i = 0; i < aux; i++)
                    {
                        if (shootersOkPermanences.Count() != 0)
                        {
                            var shot = GetRandomShooter(shootersOkPermanences);
                            service.AddPermanence(shot);
                            notCfcShooters.Remove(shot);
                            shootersOkPermanences.Remove(shot);
                            shootersOkSentinels.Remove(shot);
                        }
                    }

                    aux = service.GetSentinelsNecessaryAmount();
                    for (int i = 0; i < aux; i++)
                    {
                        if (shootersOkSentinels.Count() != 0)
                        {
                            var shot = GetRandomShooter(shootersOkSentinels);
                            service.AddSentinel(shot);
                            notCfcShooters.Remove(shot);
                            shootersOkSentinels.Remove(shot);
                        }
                    }

                }

                if (!IsCompleteSentinels() || !IsCompletePermanences())
                {
                    foreach (var service in Services)
                    {
                        List<Shooter> shootersPermanences = new List<Shooter>();
                        List<Shooter> shootersSentinels = new List<Shooter>();
                        foreach (var shooter in notCfcShooters)
                        {
                            if (!HasInScale(shooter) && shooter.CountService() == minServices && !service.IsCompletePermanences())
                            {
                                shootersPermanences.Add(shooter);
                            }
                            if (!HasInScale(shooter) && shooter.CountService() == minServices && !service.IsCompleteSentinels())
                            {
                                shootersSentinels.Add(shooter);
                            }
                        }

                        aux = service.GetPermancencesNecessaryAmount();
                        for (int i = 0; i < aux; i++)
                        {
                            if (shootersPermanences.Count() != 0)
                            {
                                var shot = GetRandomShooter(shootersPermanences);
                                service.AddPermanence(shot);
                                notCfcShooters.Remove(shot);
                                shootersPermanences.Remove(shot);
                                shootersSentinels.Remove(shot);
                            }
                        }

                        aux = service.GetSentinelsNecessaryAmount();
                        for (int i = 0; i < aux; i++)
                        {
                            if (shootersSentinels.Count() != 0)
                            {
                                var shot = GetRandomShooter(shootersSentinels);
                                notCfcShooters.Remove(shot);
                                service.AddSentinel(shot);
                                shootersSentinels.Remove(shot);
                            }
                        }
                    }
                }
                minServices++;
            }

            // Aqui depois que a escala estiver completa é verificado se têm atiradores que não podem estar em algum dia mas estão
            // Se houver é tentado realizar a troca dele com outro atirador se possível for
            foreach (var service in Services)
            {
                Shooter? commander = service.ReturnCommanderNotOk();
                List<Shooter> permanencesNotOK = service.ReturnPermancesNotOk();
                List<Shooter> sentinelsNotOK = service.ReturnSentinelsNotOk();

                if (commander != null)
                {
                    bool ultimoRecurso = true;
                    foreach (var serviceSwap in Services)
                    {
                        if (commander.IsOk(serviceSwap.Date, 1))
                        {
                            var codSwap = serviceSwap.GetCommander();
                            if (codSwap != null && codSwap.IsOk(service.Date, 1))
                            {
                                if (service.SetCommanderOfTheGuard(codSwap))
                                {
                                    serviceSwap.SetCommanderOfTheGuard(commander);
                                    ultimoRecurso = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (ultimoRecurso)
                    {
                        foreach (var codSwap in cfcShooters)
                        {
                            if (codSwap.isCfc && !HasInScale(codSwap))
                            {
                                if (codSwap.IsOk(service.Date, 1) && (codSwap.CountService() <= commander.CountService()))
                                {
                                    service.SetCommanderOfTheGuard(codSwap);
                                    break;
                                }
                            }
                        }
                    }
                }

                // permanencia
                foreach (var shooter in permanencesNotOK)
                {
                    bool ultimoRecurso = true;
                    bool aux = false;
                    foreach (var serviceSwap in Services)
                    {
                        List<Shooter> permanencesSwap = serviceSwap.GetPermanences();
                        foreach (var permaSwap in permanencesSwap)
                        {
                            if (shooter.IsOk(serviceSwap.Date, 0) && permaSwap.IsOk(service.Date, 0))
                            {
                                if (service.RemovePermanence(shooter) && serviceSwap.RemovePermanence(permaSwap))
                                {
                                    service.AddPermanence(permaSwap);
                                    serviceSwap.AddPermanence(shooter);
                                    aux = true;
                                    ultimoRecurso = false;
                                    break;
                                }
                            }
                        }
                        if (aux)
                        {
                            break;
                        }
                        else
                        {
                            List<Shooter> sentinelSwap = serviceSwap.GetSentinels();
                            foreach (var sentilSwap in sentinelSwap)
                            {
                                if (shooter.IsOk(serviceSwap.Date, 1) && sentilSwap.IsOk(service.Date, 0))
                                {
                                    if (service.RemovePermanence(shooter) && serviceSwap.RemoveSentinel(sentilSwap))
                                    {
                                        service.AddPermanence(sentilSwap);
                                        serviceSwap.AddSentinel(shooter);
                                        aux = true;
                                        ultimoRecurso = false;
                                        break;
                                    }
                                }
                            }
                        }
                        if (aux)
                        {
                            break;
                        }
                    }

                    if (ultimoRecurso)
                    {
                        foreach (var shooterSwap in shooters)
                        {
                            if (!shooterSwap.isCfc && !HasInScale(shooterSwap))
                            {
                                if (shooterSwap.IsOk(service.Date, 0) && (shooterSwap.CountService() <= shooter.CountService()))
                                {
                                    service.RemovePermanence(shooter);
                                    service.AddPermanence(shooterSwap);
                                    break;
                                }
                            }
                        }
                    }

                }

                // sentinel
                foreach (var shooter in sentinelsNotOK)
                {
                    bool ultimoRecurso = true;
                    bool aux = false;
                    foreach (var serviceSwap in Services)
                    {
                        List<Shooter> permanencesSwap = serviceSwap.GetPermanences();
                        foreach (var permaSwap in permanencesSwap)
                        {
                            if (shooter.IsOk(serviceSwap.Date, 0) && permaSwap.IsOk(service.Date, 1))
                            {
                                if (service.RemoveSentinel(shooter) && serviceSwap.RemovePermanence(permaSwap))
                                {
                                    service.AddSentinel(permaSwap);
                                    serviceSwap.AddPermanence(shooter);
                                    aux = true;
                                    ultimoRecurso = false;
                                    break;
                                }
                            }
                        }
                        if (aux)
                        {
                            break;
                        }
                        else
                        {
                            List<Shooter> sentinelSwap = serviceSwap.GetSentinels();
                            foreach (var sentilSwap in sentinelSwap)
                            {
                                if (shooter.IsOk(serviceSwap.Date, 1) && sentilSwap.IsOk(service.Date, 1))
                                {
                                    if (service.RemoveSentinel(shooter) && serviceSwap.RemoveSentinel(sentilSwap))
                                    {
                                        service.AddSentinel(sentilSwap);
                                        serviceSwap.AddSentinel(shooter);
                                        aux = true;
                                        ultimoRecurso = false;
                                        break;
                                    }
                                }
                            }
                        }
                        if (aux)
                        {
                            break;
                        }
                    }

                    if (ultimoRecurso)
                    {
                        foreach (var shooterSwap in shooters)
                        {
                            if (!shooterSwap.isCfc && !HasInScale(shooterSwap))
                            {
                                if (shooterSwap.IsOk(service.Date, 1) && (shooterSwap.CountService() <= shooter.CountService()))
                                {
                                    service.RemoveSentinel(shooter);
                                    service.AddSentinel(shooterSwap);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            // Foreach para adicionar um serviço nos dados dos atiradores que estão na escala de serviço
            foreach (var shooter in shooters)
            {
                if (HasInScale(shooter))
                {
                    shooter.AddNumService();
                }
            }
            return shooters;
        }

        // Método auxiliar para verificar se um atirador já está em um dos serviços da escala
        private bool HasInScale(Shooter shooter)
        {
            foreach (var service in Services)
            {
                if (service.HasShooter(shooter))
                {
                    return true;
                }
            }
            return false;
        }

        // Método auxiliar para sortear um atirador aleatório
        private Shooter GetRandomShooter(List<Shooter> shooters)
        {
            return shooters[new Random().Next(shooters.Count)];
        }

        // Verifica se todos os serviços estão completos
        public bool IsComplete()
        {
            foreach (var service in Services)
            {
                if (!service.IsComplete())
                {
                    return false;
                }
            }
            return true;
        }

        // Método auxiliar para verificar se todos os serviços têm os comandantes
        public bool IsCompleteCommanders()
        {
            foreach (var service in Services)
            {
                if (!service.HasCommanderOfTheGuard())
                {
                    return false;
                }
            }
            return true;
        }

        // Método auxiliar para verificar se todos os serviços têm os sentinelas necessários
        public bool IsCompleteSentinels()
        {
            foreach (var service in Services)
            {
                if (!service.IsCompleteSentinels())
                {
                    return false;
                }
            }
            return true;
        }

        // Método auxiliar para verificar se todos os serviços têm os permanências necessários
        public bool IsCompletePermanences()
        {
            foreach (var service in Services)
            {
                if (!service.IsCompletePermanences())
                {
                    return false;
                }
            }
            return true;
        }

        // Método ToString para passar informações extras
        public override string ToString()
        {
            if (IsComplete())
            {
                DateOnly firstDay = Services.First().Date;
                DateOnly lastDay = Services.Last().Date;

                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"A escala de serviço do dia {firstDay:dd/MM/yyyy} até o dia {lastDay:dd/MM/yyyy} é:");

                foreach (var service in Services)
                {
                    stringBuilder.AppendLine(service.ToString());
                }

                return stringBuilder.ToString();
            }
            else
            {
                return "A escala não está completa.";
            }
        }

    }
}
